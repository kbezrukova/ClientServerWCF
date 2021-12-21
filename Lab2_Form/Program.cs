using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library;

namespace Lab2_Form
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ChannelFactory<IContract> factory = new ChannelFactory<IContract>("transpositionTCP");
            Library.IContract transposition = factory.CreateChannel();
            
            Application.Run(new Form1(transposition));
        }
    }
}
