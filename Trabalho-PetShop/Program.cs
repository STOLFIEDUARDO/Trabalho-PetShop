using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace entra21_trabalho_02
{
    static class Program
    {
        public static List<Cliente> Client = new List<Cliente>();
        public static List<ZooPets> Pet = new List<ZooPets>();
        public static List<Tosa> Tosar = new List<Tosa>();
        public static List<Animais> Animal = new List<Animais>();
        public static List<Funcionario> funcionario = new List<Funcionario>();
        public static List<Veterinario> veterinario = new List<Veterinario>();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new btnListar());
        }
    }
}
