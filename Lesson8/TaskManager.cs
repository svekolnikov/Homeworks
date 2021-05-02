using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Channels;

namespace Lesson8
{
    public class TaskManager
    {
        private readonly string[] headers = {"Имя процесса", "PID", "№ сеанса", "Память, КБ"};
        private readonly List<int> colPosX;
        private readonly List<string> underlines;

        public TaskManager()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            underlines = new List<string>();
            colPosX = new List<int>();
            int lineLenght = 0; 
            for (int i = 0; i < headers.Length; i++)
            {
                colPosX.Add(lineLenght);
                lineLenght += headers[i].Length + 10;
                underlines.Add(new string('=', headers[i].Length + 9));
            }
        }

        // Имя процесса             PID      № сеанса    Память, КБ
        // ======================== ======== =========== ============
        public void PrintProcesses()
        {
            Console.Clear();
            for (int i = 0; i < colPosX.Count; i++){ PrintCell(colPosX[i],0, headers[i]);}
            for (int i = 0; i < colPosX.Count; i++) { PrintCell(colPosX[i], 1, underlines[i] + " "); }

            Process[] p = Process.GetProcesses();
            string name;

            for (int i = 0; i < p.Length; i++)
            {
                name = p[i].ProcessName;
                if (name.Length > underlines[0].Length)
                {
                    name = name.Substring(0, underlines[0].Length-1) + "~";
                }
                PrintCell(colPosX[0], i + 2, name);
                PrintCell(colPosX[1], i + 2, p[i].Id.ToString());
                PrintCell(colPosX[2], i + 2, p[i].SessionId.ToString());
                PrintCell(colPosX[3], i + 2, p[i].WorkingSet64.ToString());
            }

            Console.WriteLine();
        }

        private void PrintCell(int left, int top, string value)
        {
            Console.SetCursorPosition(left, top);
            Console.Write(value);
        }

        public void KillProcessById(int pid)
        {
            Process[] p = Process.GetProcesses();
            foreach (Process process in p)
            {
                if (process.Id == pid)
                {
                    process.Kill();
                    PrintProcesses();
                    return;
                }
            }

            Console.WriteLine("Процесс ненаеден.");
        }

        public void KillProcessByName(string name)
        {
            Process[] p = Process.GetProcesses();
            foreach (Process process in p)
            {
                if (process.ProcessName == name)
                {
                    process.Kill();
                    PrintProcesses();
                    return;
                }
            }

            Console.WriteLine("Процесс ненаеден.");
        }
    }
}
