using ClubManager3000.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace ClubManager3000
{
    public partial class FormClubManager3000 : Form
    {

        private DataManager _dataManager;
        private const string FILENAME = "dades.txt";
        private List<Soci> SociList = new List<Soci>();

        // Helper list to add activities during soci creation
        private List<string> newSociActivities = new List<string>();

        // flag to differentiate between adding or modify a soci
        private bool AddNewSoci = false;

        public FormClubManager3000()
        {
            InitializeComponent();
            InitializeToolTips();
            SetHeaderTextTransparency();
            _dataManager = new DataManager(FILENAME,statusTextBox);
            LoadData();
            DeactivateInputControls();
       
        }


        private void SetHeaderTextTransparency()
        {
            headerTextLabel.Parent = headerPictureBox;
            headerTextLabel.BackColor = Color.Transparent;
        
        }


        // Set tooltip messages
        private void InitializeToolTips()
        {
            toolTipControl.SetToolTip(addSociButton, "Afegir un nou soci");
            toolTipControl.SetToolTip(removeSociButton, "Eliminar soci seleccionat");
            toolTipControl.SetToolTip(modifySociButton, "Modificar soci seleccionat");
            toolTipControl.SetToolTip(saveSociButton, "Desar canvis");
        }


        // Load data from file
        private void LoadData()
        {
            SociList = _dataManager.LoadData();
            socisListBox.DataSource = SociList;
        }


        // Save data to file
        private void SaveData()
        {
            _dataManager.SaveData(SociList);
        }


        // Show currently selected soci data in all fileds
        // Controls are disabled by default unless modify button is pressed
        private void SocisListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            DeactivateInputControls();

            int index = socisListBox.SelectedIndex;

            if (index != -1)
            {
                nomTextBox.Text = SociList[index].Name;
                cognomsTextBox.Text = SociList[index].Lastnames;
                emailTextBox.Text = SociList[index].Email;
                mobilTextBox.Text = SociList[index].Phone;
                dataAltaTextBox.Text = SociList[index].SignupDate;
                activitatsListBox.DataSource = SociList[index].Activities;
            }
            else
            {
                activitatsListBox.DataSource = null;
            }
        }


        // Starts the adding a new soci flow
        private void AddSociButton_Click(object sender, EventArgs e)
        {
            socisListBox.SelectedIndex = -1;
            AddNewSoci = true;

            nomTextBox.Clear();
            cognomsTextBox.Clear();
            emailTextBox.Clear();
            mobilTextBox.Clear();
            dataAltaTextBox.Clear();
            activitatsListBox.DataSource = null;
            activitatsListBox.Items.Clear();


            ActivateInputControls();

            nomTextBox.Focus();
        }


        private void ToolTipControl_Popup(object sender, PopupEventArgs e)
        {

        }


        // Removes currently selected soci
        private void RemoveSociButton_Click(object sender, EventArgs e)
        {
            var index = socisListBox.SelectedIndex;

            if (index != -1)
            {

                SociList.RemoveAt(index);
                RefreshListBox(socisListBox, SociList);
                statusTextBox.Text = "Soci esborrat correctament!";
                socisListBox.SelectedIndex = 0;
                SaveData();
            }
            else
            {
                statusTextBox.Text = "Primer has de seleccionar un soci!";
            }


        }


        // Generic helper method to refresh a ListBox
        private void RefreshListBox<T>(ListBox listBox, List<T> list)
        {
            listBox.DataSource = null;
            listBox.DataSource = list;
        }


        // Activate all contorls in dadesSociGroupBox
        private void ActivateInputControls()
        {

            ToggleControlState(dadesSociGroupBox,true);
        }


        // Deactivate all contorls in dadesSociGroupBox
        private void DeactivateInputControls()
        {

            ToggleControlState(dadesSociGroupBox, false);
        }


        // Toggle enabled stat in all controls inside another contorl
        private void ToggleControlState(Control control, bool state)
        {
            control.Controls
                .OfType<Control>()
                .ToList()
                .ForEach(textBox => textBox.Enabled = state);
        }



        private void ModifySociButton_Click(object sender, EventArgs e)
        {
            if (socisListBox.SelectedIndex != -1)
            {
                ActivateInputControls();
            }
        }


        // Same button creates or modifies a soci based on the boolean flag AddNewSoci
        private void SaveSociButton_Click(object sender, EventArgs e)
        {
            if (AddNewSoci)
            {
                GuardarNouSoci();
                AddNewSoci = false;
            }
            else
            {
                GuardarSociModificat();
            }

            SaveData();

        }


        private bool ValidateUserGroupBoxData()
        {
            foreach (Control control in dadesSociGroupBox.Controls)
            {
                if (control is TextBox && string.IsNullOrEmpty(control.Text))
                {
                    MessageBox.Show("There should be no empty fields!", "Error in data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    statusTextBox.Text = "Error! Les dades no s'han modificat";
                    return false;
                }
            }

            return true;
        }


        private void GuardarNouSoci()
        {

            var userInputIsValid = ValidateUserGroupBoxData();

            if(userInputIsValid)
            {
                var nom = nomTextBox.Text;
                var cognoms = cognomsTextBox.Text;
                var mobil = mobilTextBox.Text;
                var email = emailTextBox.Text;
                var signupDate = dataAltaTextBox.Text;

                var activitats = new List<string>();


                var soci = new Soci(nom, cognoms, mobil, email, signupDate);
                soci.Activities.AddRange(activitats);

                // Add selected activities to the activitats list
                foreach (var item in activitatsListBox.Items)
                {
                    soci.Activities.Add(item.ToString());
                }


                // Add the new Soci object to SociList and refresh the ListBox
                SociList.Add(soci);
                SociList = SociList.OrderBy(x => x.Name).ToList();


                RefreshListBox(socisListBox, SociList);
                newSociActivities.Clear();

                // Select new soci in the socisListBox
                socisListBox.SelectedIndex = SociList.IndexOf(soci);

                statusTextBox.Text = "Soci afegit correctament!";
            }
            else
            {
                statusTextBox.Text = "Dades incorrectes, no es pot guardar!";
            }
        }


        private void GuardarSociModificat()
        {
            if (socisListBox.SelectedIndex != -1)
            {
                var userInputIsValid = ValidateUserGroupBoxData();

                if (userInputIsValid)
                {
                    var index = socisListBox.SelectedIndex;

                    SociList[index].Name = nomTextBox.Text;
                    SociList[index].Email = emailTextBox.Text;
                    SociList[index].Phone = mobilTextBox.Text;
                    SociList[index].Lastnames = cognomsTextBox.Text;
                    DeactivateInputControls();
                    statusTextBox.Text = "Dades modificades correctament!";
                }
                else
                {
                    statusTextBox.Text = "Dades incorrectes, no es pot modificar!";
                }

            }
            else
            {
                statusTextBox.Text = "Primer s'ha de seleccionar un soci";
            }
        }



        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (MessageBox.Show("Segur que vols sortir del programa?", "Closing...", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }



        private void AddActivitatButton_Click(object sender, EventArgs e)
        {


            NewActivityForm newActivityForm = new NewActivityForm();
            var (result, inputValue) = newActivityForm.InputBox();


            if (socisListBox.SelectedIndex != -1)
            {
                if (result == DialogResult.OK)
                {
                    var index = socisListBox.SelectedIndex;

                    SociList[index].Activities.Add(inputValue);

                    RefreshListBox(activitatsListBox, SociList[index].Activities);
                }
            }
            else
            {
                if (result == DialogResult.OK)
                {

                    newSociActivities.Add(inputValue);

                    RefreshListBox(activitatsListBox, newSociActivities);
                }
            }


        }


        private void RemoveActivitatButton_Click(object sender, EventArgs e)
        {
            var index = socisListBox.SelectedIndex;

            var activitatsIndex = activitatsListBox.SelectedIndex;

            if (activitatsIndex == -1) return;

            SociList[index].Activities.RemoveAt(activitatsIndex);

            RefreshListBox(activitatsListBox, SociList[index].Activities);
        }
    }
}