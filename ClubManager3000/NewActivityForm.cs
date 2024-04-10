using System;
using System.Windows.Forms;

namespace ClubManager3000
{
    public partial class NewActivityForm : Form
    {
        public NewActivityForm()
        {
            InitializeComponent();
        }

        

        private void NewActivityForm_Load(object sender, EventArgs e)
        {
            okButton.DialogResult = DialogResult.OK;
            cancelButton.DialogResult = DialogResult.Cancel;
            this.AcceptButton = okButton;
            this.CancelButton = cancelButton;
      
            
        }

        public (DialogResult, string) InputBox()
        {
            DialogResult result = ShowDialog();
            var value = newActivityTextBox.Text;
            Console.WriteLine(value);
            return (result, value);
        }

        private void newActivityTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
