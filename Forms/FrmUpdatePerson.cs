using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonsApp.Model;

namespace PersonsApp.Forms
{
    public partial class FrmUpdatePerson : Form
    {
        private FrmDisplayVaccinationList frmDisplayVaccinationList;
        public FrmUpdatePerson()
        {
            InitializeComponent();
        }

        public FrmUpdatePerson(Persons editperson, FrmDisplayVaccinationList frmDisplayVaccinationList) : this()
        {
            lblId.Text = editperson.Id.ToString();
            txtLastName.Text = editperson.LastName;
            txtFirstName.Text = editperson.FirstName;
            numAge.Text = editperson.Age.ToString();
            cmbVaccinationListbox.Text = editperson.VaccinationStatus.ToString();
            this.frmDisplayVaccinationList = frmDisplayVaccinationList;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string response = Persons.UpdatePerson(
                new Persons
                {
                    Id = Convert.ToInt32(lblId.Text),
                    LastName = txtLastName.Text,
                    FirstName = txtFirstName.Text,
                    Age = Convert.ToInt32(numAge.Text),
                    VaccinationStatus = cmbVaccinationListbox.Text
                }
            );

            if (response.Equals(response))
                {
                   MessageBox.Show("Data successfully Updated u dumbfuck");
                   frmDisplayVaccinationList.Close();
                   FrmDisplayVaccinationList frmDisplayList = new FrmDisplayVaccinationList();
                   frmDisplayList.Show();


            }
            else
                {
                    MessageBox.Show($"Error: {response}");
                    Clear();
            }
        }

        private void Clear()
        {
            lblId.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            numAge.Text = string.Empty;
            cmbVaccinationListbox.Text = string.Empty;


        }
    }
}
