﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbpaste
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console.Write(Clipboard.GetText());
        }
    }
}
