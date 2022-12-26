using System;
using System.Windows.Forms;

namespace WindowsFormUI.Helpers
{
    public static class MessageHelper
    {
        private static string ErrorStringResult { get; set; }
        private static string SuccessStringResult { get; set; }

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
            ErrorStringResult = "";
        }

        public static void ErrorMessageBuilder(string errorMessage, string caption)
        {
            MessageBox.Show(errorMessage, caption, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        public static void SuccessMessageBuilder(string successMessage, string caption)
        {
            MessageBox.Show(successMessage, caption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
        }

        public static void InformationMessageBuilder(string info, string caption)
        {
            MessageBox.Show(info, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}