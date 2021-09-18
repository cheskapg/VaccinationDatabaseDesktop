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
using PersonsApp.Forms;

namespace PersonsApp
{
    public partial class FrmDisplayVaccinationList : Form
    {
        public FrmDisplayVaccinationList()
        {
            InitializeComponent();
        }

        private void FrmDisplayVaccinationList_Load(object sender, EventArgs e)
        {
            LoadPersonsList();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            Persons editperson = new Persons
            {
                Id = (int)dgPersonsList.CurrentRow.Cells["colId"].Value,
                LastName = (string)dgPersonsList.CurrentRow.Cells["colLastName"].Value,
                FirstName = (string)dgPersonsList.CurrentRow.Cells["colFirstName"].Value,
                Age = (int)dgPersonsList.CurrentRow.Cells["colAge"].Value,
                VaccinationStatus = (string)dgPersonsList.CurrentRow.Cells["colVaccinationStatus"].Value
            };
            FrmUpdatePerson frmUpdatePerson = new FrmUpdatePerson(editperson, this);
            frmUpdatePerson.ShowDialog();
        }


        internal void LoadPersonsList()
        {
            var person = Persons.GetPersons();

            foreach (var Listperson in person)
            {
                dgPersonsList.Rows.Add(
                    Listperson.Id,
                    Listperson.LastName,
                    Listperson.FirstName,
                    Listperson.Age,
                    Listperson.VaccinationStatus
                    );
            }
        }
    }
}
