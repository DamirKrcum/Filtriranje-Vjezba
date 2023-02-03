using DLWMS.Data;
using DLWMS.WinForms.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IspitIB200264
{
    public partial class frmStudentProfil : Form
    {
        private Student student;
        DLWMSDbContext db = new DLWMSDbContext();
              

        public frmStudentProfil(Student _odabraniStudent)
        {
            InitializeComponent();
            this.student = _odabraniStudent;
            dgvPolozeni.AutoGenerateColumns = false;
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            pbSlikaStudenta.Image = ImageHelper.FromByteToImage(student.Slika);
            txtIme.Text = student.Ime;
            txtPrezime.Text = student.Prezime;
            txtBrojIndeksa.Text = student.BrojIndeksa;
            txtEmail.Text = student.Email;
            dtpDatumRodjenja.Value= student.DatumRodjenja;
            cbAktivan.Checked = student.Aktivan;
            cbPredmet.DataSource = db.Predmeti.ToList();

            UcitajPolozene();


        }

        private void UcitajPolozene()
        {
            var binding = new BindingSource();
            binding.DataSource = db.studentiPredmeti.Include(pr => pr.Predmet).Where(st=>st.StudentId == student.Id).ToList();
            // List<StudentiPredmeti> nova = new List<StudentiPredmeti>();
            // for (int i = 0; i < lista.Count(); i++)
            // {
            //     if (lista[i].StudentId == st.Id)
            //     {
            //         nova.Add(lista[i]);
            //     }
            // 
            // }
            //var binding = new BindingSource();
            //binding.DataSource = null;
            //binding.DataSource = lista;
            dgvPolozeni.DataSource = binding;
            dgvPolozeni.Refresh();
        }

        private void lblDodaj_Click(object sender, EventArgs e)
        {
            var polozeni = new StudentiPredmeti();
            polozeni.Ocjena = int.Parse(cmbOcjena.Text);
            polozeni.PredmetId = (cbPredmet.SelectedValue as Predmeti).id;
            polozeni.Datum = dtpDatumPolaganja.Value;
            polozeni.StudentId= student.Id;

            db.studentiPredmeti.Add(polozeni);
            db.SaveChanges();
            UcitajPodatke();
        }
    }
}
