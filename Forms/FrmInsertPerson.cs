using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonsApp
{
	public partial class FrmInsertPerson : Form
	{
		public FrmInsertPerson()
		{
			InitializeComponent();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			CancelClear();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			string save = Model.Persons.InsertPerson(txtLastName.Text, txtFirstName.Text, Convert.ToInt32(numAge.Text), cmbVaccinationListbox.Text);
			MessageBox.Show(save);
			CancelClear();
		}

		private void CancelClear()
		{	
			txtLastName.ResetText();
			txtFirstName.ResetText();
			numAge.ResetText();
			cmbVaccinationListbox.ResetText();
			cmbVaccinationListbox.SelectedIndex = -1;
			txtLastName.Focus();
		}


    }
}
