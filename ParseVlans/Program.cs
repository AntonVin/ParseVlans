﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParseVlans
{
    internal static class Program
    {
        
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var generatorListVlans = new GeneratorListVlans(new ExtractorNumbersVlans(), new ExtractorDictionaryVlans());
            Application.Run(new Form1(generatorListVlans));
        }
    }
}
