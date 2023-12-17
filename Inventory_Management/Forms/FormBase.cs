namespace Inventory_Management.Forms
{
    public class FormBase : Form
    {
        protected void ResetForm(Control control)
        {
            Utilities.ResetAllControls(control);
        }
    }
}
