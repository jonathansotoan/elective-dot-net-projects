using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PersonaFormulario.Facturas
{
    public static class ErrorProviderExtension
    {
        private static bool existsError = false;

        public static void CustomSetError(this ErrorProvider errorProvider, Control control, string message)
        {
            errorProvider.SetError(control, message);
            existsError = true;
        }

        public static void CustomClear(this ErrorProvider errorProvider)
        {
            errorProvider.Clear();
            existsError = false;
        }

        public static bool ExistsError(this ErrorProvider errorProvider)
        {
            return existsError;
        }
    }
}
