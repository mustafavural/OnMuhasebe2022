using System;
using System.Windows.Forms;

namespace WindowsFormUI.Helpers
{
    public static class ErrorMessageHelper
    {
        private static string ErrorStringResult { get; set; }

        private static void Builder(Exception err)
        {
            ErrorStringResult += err.Message;
            if (err.InnerException != null)
            {
                ErrorStringResult += "\n ------";
                Builder(err.InnerException);
            }
        }

        public static void ErrorMessageBuilder(Exception err)
        {
            Builder(err);
            MessageBox.Show(ErrorStringResult, err.Source, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        public static void ErrorMessageBuilder(string errorMessage, string caption)
        {
            MessageBox.Show(errorMessage, caption, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }
    }
}