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
        private Student st;
        DLWMSDbContext db = new DLWMSDbContext();
              

        public frmStudentProfil(Student _odabraniStudent)
        {
            InitializeComponent();
            this.st = _odabraniStudent;
            dgvPolozeni.AutoGenerateColumns = false;
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            pbSlikaStudenta.Image = ImageHelper.FromByteToImage(st.Slika);
            txtIme.Text = st.Ime;
            txtPrezime.Text = st.Prezime;
            txtBrojIndeksa.Text = st.BrojIndeksa;
            txtEmail.Text = st.Email;
            dtpDatumRodjenja.Value= st.DatumRodjenja;
            cbAktivan.Checked = st.Aktivan;
            cbPredmet.DataSource = db.Predmeti.ToList();

            UcitajPolozene();


        }

        private void UcitajPolozene()
        {
            var binding = new BindingSource();
            binding.DataSource = null;
            binding.DataSource = db.studentiPredmeti.Where(student => student.Id == st.Id).Include(pr => pr.Predmet).ToList();
            dgvPolozeni.DataSource = binding;
            dgvPolozeni.Refresh();
        }

        private void lblDodaj_Click(object sender, EventArgs e)
        {
            var polozeni = new StudentiPredmeti();
            polozeni.Ocjena = int.Parse(cmbOcjena.Text);
            polozeni.PredmetId = (cbPredmet.SelectedValue as Predmeti).id;
            polozeni.Datum = dtpDatumPolaganja.Value;
            polozeni.StudentId= st.Id;

            db.studentiPredmeti.Add(polozeni);
            db.SaveChanges();
            UcitajPodatke();
        }
    }
}
