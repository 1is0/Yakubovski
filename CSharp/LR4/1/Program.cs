using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace LR4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1)Start");
                Console.WriteLine("2)Close");
                if (int.TryParse(Console.ReadLine(), out int choice) && (choice == 1 || choice == 2))
                {
                    if (choice == 1)
                    {
                        ShowAllProcesse();
                    }
                    else if (choice == 2) return;

                }
                else
                {
                    Console.WriteLine("Invalid input");
                    Console.ReadLine();
                    Console.Clear();
                }

            }
        }
        private static void ShowAllProcesse()
        {
            Process anotherProc = null;
            IntPtr snap = WinAPIImport.CreateToolhelp32Snapshot(WinAPIImport.SnapshotFlags.Process, 0);
            WinAPIImport.PROCESSENTRY32 pe = new WinAPIImport.PROCESSENTRY32();
            pe.dwSize = (UInt32)Marshal.SizeOf(typeof(WinAPIImport.PROCESSENTRY32));
            try
            {
                if (WinAPIImport.Process32First(snap, ref pe))
                {
                    //ProcessesTreeView.Nodes.Clear();
                    Console.Clear();
                    do
                    {
                        anotherProc = Process.GetProcessById((int)pe.th32ProcessID);
                        //TreeNode tmp = ProcessesTreeView.Nodes.Add($"ID: {anotherProc.Id} Name: {anotherProc.ProcessName}");
                        //tmp.Nodes.Add($"Memory size allocated for process: {anotherProc.VirtualMemorySize64} bytes");
                        Console.WriteLine($"ID: {anotherProc.Id} Name: {anotherProc.ProcessName}");
                        Console.WriteLine($"Memory size allocated for process: {anotherProc.VirtualMemorySize64} bytes");
                    } while (WinAPIImport.Process32Next(snap, ref pe));
                }
                else
                {
                    //MessageBox.Show("Unable to get any process!");
                    Console.WriteLine("Unable to get any process!");
                }

            }
            catch (System.ComponentModel.Win32Exception)
            {
                //MessageBox.Show("Something went wrong, try again please (:");
                Console.WriteLine("Something went wrong, try again please.");
            }
            catch (System.ArgumentException)
            {
                //MessageBox.Show("Some process has just terminated in runtime, please try again.");
                Console.WriteLine("Some process has just terminated in runtime, please try again.");
            }
            finally
            {
                // Must clean up the snapshot object!
                WinAPIImport.CloseHandle(snap);
            }
        }
    }
}
