
namespace Inventory_Management
{
    internal class Utilities
    {
        public static void ResetAllControls(Control control)
        {
            foreach(Control current in control.Controls)
            {
                if (current is TextBox)
                    ResetTextBox(current);

                if(current is GroupBox)
                {
                    foreach(Control groupBoxItem in current.Controls)
                    {
                        if(groupBoxItem is TextBox)
                            ResetTextBox(groupBoxItem);

                        if (groupBoxItem is ComboBox)
                            ResetComboBox(groupBoxItem);
                    }
                }

                if(current is CheckBox)
                    ResetCheckBox(current);

                if(current is ComboBox)
                    ResetComboBox(current);
            }
        }

        private static void ResetTextBox(Control control)
        {
            TextBox textBox = (TextBox)control;
            textBox.Text = null;
        }

        private static void ResetCheckBox(Control control)
        {
            CheckBox checkBox = (CheckBox)control;
            checkBox.Checked = false;
        }

        private static void ResetComboBox(Control control)
        {
            ComboBox comboBox = (ComboBox)control;
            comboBox.SelectedIndex = 0;
        }
    }
}
