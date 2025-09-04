using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemaforoTimer
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal da aplicação.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles(); // visual diferente que gostei
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new SemaforoTimer()); // Inicia o primeiro form
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro fatal ao iniciar o programa:\n" + ex.Message,
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}