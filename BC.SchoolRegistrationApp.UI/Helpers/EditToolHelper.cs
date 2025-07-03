using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BC.SchoolRegistrationApp.UI.Helpers
{
    public static class EditToolHelper
    {
        public static void ClearInputs(Control container)
        {
            foreach (Control control in container.Controls)
            {
                if (control is TextEdit textEdit)
                    textEdit.Text = string.Empty;

                else if (control is ComboBoxEdit comboBoxEdit)
                    comboBoxEdit.SelectedIndex = -1;

                else if (control is ImageEdit imageEdit)
                    imageEdit.Image = null;
            }
        }
        public static bool HasEmptyFields(string name, string surname, string number, object _class)
        {
            string classStr = _class?.ToString();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname) || string.IsNullOrWhiteSpace(number) || string.IsNullOrWhiteSpace(classStr))
            {
                MessageBox.Show("Please fill in the blank fields.");
                return false;
            }
            else
                return true;
        }
    }
}
