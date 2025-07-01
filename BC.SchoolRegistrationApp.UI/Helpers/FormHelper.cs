using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BC.SchoolRegistrationApp.UI.Helpers
{
    public static class FormHelper
    {
        public static T ShowForm<T>(ref T formInstance, Func<T> createForm, Form mdiParent) where T : Form
        {
            if(formInstance==null || formInstance.IsDisposed)
            {
                formInstance= createForm();
                formInstance.MdiParent = mdiParent;
                formInstance.Show();
            }
            else
                formInstance.BringToFront();

            return formInstance;
        }

    }
}
