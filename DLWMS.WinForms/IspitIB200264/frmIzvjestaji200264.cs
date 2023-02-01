using DLWMS.Data;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace DLWMS.WinForms.IspitIB200264
{
    public partial class frmIzvjestaji200264 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<Student> students = new List<Student>();

        public frmIzvjestaji200264()
        {
            InitializeComponent();      
            dgvStudenti.AutoGenerateColumns = false;
            
            UcitajKontrole();
            Ucitaj();
        }

        private void UcitajKontrole()
        {
            cmbSpol.DataSource = db.Spolovi.ToList();
        }

        private void Ucitaj()
        {
            var binding = new BindingSource();
            students.Clear();
            students = db.Studenti.Include(st => st.Spol).ToList();
            students = db.Studenti.Where(filtriraj).ToList();
            for (int i = 0; i < students.Count(); i++)
            {
                var student = students[i];
                student.imePrezime = $"{student.Ime} {student.Prezime}";
            }
            binding.DataSource = students;
            dgvStudenti.DataSource = binding;

        }

        private void frmIzvjestaji200264_Load(object sender, EventArgs e)
        {
            
            Ucitaj();
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            Ucitaj();
        }

        private void cmbSpol_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ucitaj();
        }

        private void dtpOd_ValueChanged(object sender, EventArgs e)
        {
            Ucitaj();
        }

        private void dtpDo_ValueChanged(object sender, EventArgs e)
        {
            Ucitaj();
        }

        private void cmbGodina_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ucitaj();
        }

        // F I L T E R I

        public bool filtriraj(Student st)
        {

            return FiltrirajPretragu(st) && FiltrirajGodinuSudija(st) && FiltrirajSpol(st) && FiltrirajPeriod(st);

        }
        public bool FiltrirajPeriod(Student st)
        {
            var datumOd = dtpOd.Value;
            var datumDo = dtpDo.Value;
            return datumOd < st.DatumRodjenja && datumDo > st.DatumRodjenja;
        }

        public bool FiltrirajSpol(Student st)
        {
            var spol = cmbSpol.SelectedItem as Spol;
            return st.Spol == spol;
        }

        public bool FiltrirajGodinuSudija(Student st)
        {
            var godinaStudija = cmbGodina.SelectedIndex + 1;
            if (godinaStudija == 0) { return true; }
            else
            {
                return st.GodinaStudija == godinaStudija;
            }
        }

        public bool FiltrirajPretragu(Student st)
        {
            var pretraga = txtPretraga.Text.ToLower();
            return st.Ime.ToLower().Contains(pretraga) || st.Prezime.ToLower().Contains(pretraga) || string.IsNullOrEmpty(pretraga);
        }
    }
}
