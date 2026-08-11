using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BibliotecaDeJogos
{
	
	internal sealed class Program
	{
		
	   [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}