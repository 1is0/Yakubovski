using System.Runtime.InteropServices;

namespace LR4_2
{
    class Linker
    {
        //chage path please
        private const string path = @"C:\Users\user\Desktop\CSharp\LR4\LR4_2\LR4_2\Dll1.dll";

        [DllImport(path, EntryPoint = "Perimeter", CallingConvention = CallingConvention.StdCall)]
        public static extern double Perimeter(double a, double b);

        [DllImport(path, EntryPoint = "Area", CallingConvention = CallingConvention.Cdecl)]
        public static extern double Area(double a, double b);

        [DllImport(path, EntryPoint = "Diagonal", CallingConvention = CallingConvention.StdCall)]
        public static extern double Diagonal(double a, double b);

    }
}
