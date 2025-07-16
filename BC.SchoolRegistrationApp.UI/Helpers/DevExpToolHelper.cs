using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BC.SchoolRegistrationApp.UI.Helpers
{
    public static class DevExpToolHelper
    {
        public static void ClearInputs(Control container)
        {
            foreach (Control control in container.Controls)
            {
                if (control is TextEdit textEdit)
                    textEdit.Text = string.Empty;

                else if (control is ImageEdit imageEdit)
                    imageEdit.Image = null;

                if (control.HasChildren)
                    ClearInputs(control);
            }
        }
        public static bool HasEmptyFields(string name, string surname, string number, object _class)
        {
            string classStr = _class?.ToString();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname) || string.IsNullOrWhiteSpace(number) || string.IsNullOrWhiteSpace(classStr))
            {
                MessageBox.Show("Please fill in the blank fields.");
                return true;
            }
            else
                return false;
        }
        public static void AddButtonColumn(GridView gridView, GridControl gridControl, string fieldName, string columnName, string iconPath)
        {
            var icon = ImageHelper.ResizeImage(iconPath, 24, 24);
            RepositoryItemButtonEdit buttonEdit = new RepositoryItemButtonEdit();
            buttonEdit.Buttons[0].Caption = "";
            buttonEdit.Buttons[0].ImageOptions.Image = icon;
            buttonEdit.Buttons[0].Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph;
            buttonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            gridControl.RepositoryItems.Add(buttonEdit);

            GridColumn colButton = new GridColumn();
            colButton.FieldName = fieldName;
            colButton.Name = columnName;
            colButton.Caption = "";
            colButton.Visible = true;
            colButton.ColumnEdit = buttonEdit;
            colButton.OptionsColumn.ReadOnly = false;
            colButton.OptionsColumn.AllowEdit = true;
            colButton.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            gridView.Columns.Add(colButton);
        }

    }
}
