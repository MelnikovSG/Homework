using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson7
{
    //а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
    //б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок.
    //Игрок должен получить это число за минимальное количество ходов.
    // Мельников Сергей

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
