using System;
using System.Windows.Forms;

namespace Tyuiu.KruchininEP.Sprint6.Task7.V10
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения KEP.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Включаем визуальные стили для приложения
            Application.EnableVisualStyles();

            // Настраиваем отображение текста для совместимости
            Application.SetCompatibleTextRenderingDefault(false);

            // Создаем и запускаем главную форму приложения
            Application.Run(new FormMain());
        }
    }
}