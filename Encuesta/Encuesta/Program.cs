using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Encuesta
{
    static class Program
    {
        private static Stack<Form> previousForms = new Stack<Form>();
        private static Stack<Form> nextForms = new Stack<Form>();
        public static ResultSet Results { get; set;  }

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Results = new ResultSet();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            previousForms.Push(new FrmGeneral());
            Application.Run(previousForms.Peek());
        }

        public static void Forward(Form defaultForm)
        {
            if (nextForms.Count > 0 && !nextForms.Peek().IsDisposed)
            {
                nextForms.Peek().Visible = true;
                previousForms.Push(nextForms.Pop());
            }
            else
            {
                nextForms.Clear();
                previousForms.Push(defaultForm);
                defaultForm.Show();
            }
        }

        public static void Back()
        {
            previousForms.Peek().Visible = false;
            nextForms.Push(previousForms.Pop());
        }
    }
}
