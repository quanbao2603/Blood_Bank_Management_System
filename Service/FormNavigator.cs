using System;
using System.Windows.Forms;

namespace Blood_Bank.UI_Helper
{
    public static class FormNavigator
    {
        public static void Navigate(Form currentForm, Form nextForm)
        {
            nextForm.Show();
            currentForm.Hide();
        }
    }
}
