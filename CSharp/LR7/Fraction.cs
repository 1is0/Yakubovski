using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace LR7
{
    class Fraction : IComparable<Fraction>
    {
        private int m = 0;
        private int n = 1;
        public int M
        {
            get => m;
            set => m = value;
        }
        public int N
        {
            get => n;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Denominator must be a natural number");
                else n = value;
            }
        }
        public Fraction()
        {
            M = 0;
            N = 1;
        }
        public Fraction(int m, int n)
        {
            M = m;
            N = n;
            AdjustFraction();
        }
        public Fraction(string num)
        {
            bool slash = false;
            foreach (char c in num)
            {
                if (!char.IsDigit(c) && c != '/' && c != '-' && c != '+')
                {
                    throw new ArgumentException("Invalid format.");
                }
                if (c == '/')
                {
                    if (slash == true)
                        throw new ArgumentException("Invalid format.");
                    else
                    {
                        slash = true;
                    }
                }
            }
            if (!slash) throw new ArgumentException("Invalid format.");
            int slashIndex = num.IndexOf('/');
            string mStr = num.Substring(0, slashIndex);
            string nStr = num.Substring(slashIndex + 1, num.Length - slashIndex - 1);
            M = Convert.ToInt32(mStr);
            N = Convert.ToInt32(nStr);
            AdjustFraction();


        }
        public Fraction(int num)
        {
            M = num;
            N = 1;
        }
        public override string ToString()
        {
            if (N == 1)
                return M.ToString();
            return String.Format($"{M}/{N}");
        }
        public override int GetHashCode() => this.ToString().GetHashCode();
        private void AdjustFraction()
        {
            if (M == 0)
            {
                N = 1;
                return;
            }
            int nod = NOD(M, N);
            M /= nod;
            N /= nod;
        }
        public static int NOD(int num1, int num2)
        {
            num1 = Math.Abs(num1);
            num2 = Math.Abs(num2);
            while (num2 > 0)
            {
                int temp = num2;
                num2 = num1 % num2;
                num1 = temp;
            }
            return num1;
        }

        public static int NOK(int num1, int num2)
        {
            for (int i = 1; i < Math.Abs(num1) * Math.Abs(num2) + 1; i++)
            {
                if (i % num1 == 0 && i % num2 == 0)
                {
                    return i;
                }
            }
            return 0;
        }
        public int CompareTo(Fraction other)
        {
            if (this.M == 0 && other.M == 0) return 0;
            if (this.M >= 0 && other.M <= 0) return 1;
            if (this.M <= 0 && other.M >= 0) return -1;
            int nok = NOK(this.N, other.N);
            int extra1 = nok / this.N;
            int extra2 = nok / other.N;
            int top1 = this.M * extra1;
            int top2 = other.M * extra2;
            if (top1 == top2) return 0;
            if (top1 > top2) return 1;
            else return -1;
        }
        public override bool Equals(object obj)
        {
            return this.ToString() == obj.ToString();
        }

        public static bool operator ==(Fraction f1, Fraction f2) => f1.Equals(f2);
        public static bool operator !=(Fraction f1, Fraction f2) => !f1.Equals(f2);
        public static bool operator >(Fraction f1, Fraction f2) => f1.CompareTo(f2) > 0;
        public static bool operator <(Fraction f1, Fraction f2) => f1.CompareTo(f2) < 0;
        public static bool operator >=(Fraction f1, Fraction f2) => f1.CompareTo(f2) >= 0;
        public static bool operator <=(Fraction f1, Fraction f2) => f1.CompareTo(f2) <= 0;
        public static Fraction operator -(Fraction f)
        {
            return new Fraction(-f.M, f.N);
        }
        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            int nok = NOK(f1.N, f2.N);
            int top1 = f1.M * nok / f1.N;
            int top2 = f2.M * nok / f2.N;
            return new Fraction(top1 + top2, nok);
        }
        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            return f1 + (-f2);
        }
        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.M * f2.M, f1.N * f2.N);
        }
        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.M * f2.N, f1.N * f2.M);
        }
        public static Fraction operator ++(Fraction f)
        {
            return new Fraction(f.M + f.N, f.N);
        }
        public static Fraction operator --(Fraction f)
        {
            return new Fraction(f.M - f.N, f.N);
        }

        public static implicit operator Fraction(int i)
        {
            return new Fraction(i);
        }
        public static explicit operator int(Fraction f)
        {
            return (int)(f.M / f.N);
        }
        public static explicit operator float(Fraction f)
        {
            return (float)f.M / (float)f.N;
        }
        public static explicit operator Fraction(float flt)
        {
            return new Fraction((int)flt);
        }
    }

}
