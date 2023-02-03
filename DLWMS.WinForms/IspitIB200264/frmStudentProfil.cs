using DLWMS.Data;
using DLWMS.WinForms.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
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
            txtProsjek.Text = IzracunajProsjek(student).ToString();
            
            
            UcitajPolozene();


        }

        private double IzracunajProsjek(Student student)
        {
            List<StudentiPredmeti> _lst = db.studentiPredmeti.Where(st => st.StudentId == student.Id).ToList();
            double avg;
            if (_lst.Count() == 0)
                avg = 5;
            else
                avg = Math.Round(_lst.Average(x => x.Ocjena),2);

            return avg;
            

            
        }

        private void UcitajPolozene()
        {
            var binding = new BindingSource();
            List<StudentiPredmeti> lista = db.studentiPredmeti.Include(pr => pr.Predmet).Where(st => st.StudentId == student.Id).ToList();
            
            binding.DataSource = lista;
        
            dgvPolozeni.DataSource = binding;
            //dgvPolozeni.Refresh();
        }

        

        private void lblDodaj_Click(object sender, EventArgs e)
        {
            var polozeni = new StudentiPredmeti();
            polozeni.Ocjena = int.Parse(cmbOcjena.Text);
            polozeni.PredmetId = (cbPredmet.SelectedValue as Predmeti).id;
            polozeni.Datum = dtpDatumPolaganja.Value;
            polozeni.StudentId= student.Id;
            if (PremetPolozen(polozeni))
            {
                MessageBox.Show("Predmet je već položen!");
            }
            else
            {
                db.studentiPredmeti.Add(polozeni);
                db.SaveChanges();
                UcitajPodatke();
            }

        }

        private bool PremetPolozen(StudentiPredmeti polozeni)
        {
            List<StudentiPredmeti> lst = db.studentiPredmeti.Include(pr => pr.Predmet).Where(st => st.StudentId == student.Id).ToList();
            for (int i = 0; i < lst.Count(); i++)
            {
                if (polozeni.PredmetId == lst[i].PredmetId)
                {
                    
                    return true;
                }
                                    
            }
            MessageBox.Show("Predmet uspješno dodan!");
            return false;
        }

        private void dgvPolozeni_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 3)
            {
               var polozeni = dgvPolozeni.Rows[e.RowIndex].DataBoundItem as StudentiPredmeti;
                try
                {
                    db.studentiPredmeti.Remove(polozeni);
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    throw;
                }
                db.SaveChanges();
                MessageBox.Show($"Predmet {polozeni.Predmet} uspješno obrisan!");

            }
                UcitajPodatke();
        }
    }
}
