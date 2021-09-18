using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonsApp.Forms
{
    public partial class Vaccine_Registration : Form
    {
        public Vaccine_Registration()
        {
            InitializeComponent();
        }

        private void btnRegisterNow_Click(object sender, EventArgs e)
        {
            FrmInsertPerson frmRegisterPersons = new FrmInsertPerson();
            frmRegisterPersons.ShowDialog();
        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            FrmDisplayVaccinationList frmDisplayList = new FrmDisplayVaccinationList();
            frmDisplayList .ShowDialog();
        }

        private void Vaccine_Registration_Load(object sender, EventArgs e)
        {
             
        }
    }
}
