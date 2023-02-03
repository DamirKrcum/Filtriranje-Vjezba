namespace DLWMS.WinForms.IspitIB200264
{
    partial class frmStudentProfil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbSlikaStudenta = new System.Windows.Forms.PictureBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.lblBrojIndeksa = new System.Windows.Forms.Label();
            this.txtBrojIndeksa = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cbAktivan = new System.Windows.Forms.CheckBox();
            this.dtpDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtProsjek = new System.Windows.Forms.TextBox();
            this.cbPredmet = new System.Windows.Forms.ComboBox();
            this.dgvPolozeni = new System.Windows.Forms.DataGridView();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obrisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbOcjena = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDatumPolaganja = new System.Windows.Forms.Label();
            this.lblProsjek = new System.Windows.Forms.Label();
            this.dtpDatumPolaganja = new System.Windows.Forms.DateTimePicker();
            this.lblDodaj = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSpasi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlikaStudenta)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolozeni)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSlikaStudenta
            // 
            this.pbSlikaStudenta.Location = new System.Drawing.Point(12, 12);
            this.pbSlikaStudenta.Name = "pbSlikaStudenta";
            this.pbSlikaStudenta.Size = new System.Drawing.Size(200, 179);
            this.pbSlikaStudenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlikaStudenta.TabIndex = 1;
            this.pbSlikaStudenta.TabStop = false;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(12, 228);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(200, 23);
            this.txtIme.TabIndex = 2;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(12, 208);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(27, 15);
            this.lblIme.TabIndex = 3;
            this.lblIme.Text = "Ime";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(12, 256);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(49, 15);
            this.lblPrezime.TabIndex = 5;
            this.lblPrezime.Text = "Prezime";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(12, 276);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(200, 23);
            this.txtPrezime.TabIndex = 4;
            // 
            // lblBrojIndeksa
            // 
            this.lblBrojIndeksa.AutoSize = true;
            this.lblBrojIndeksa.Location = new System.Drawing.Point(12, 304);
            this.lblBrojIndeksa.Name = "lblBrojIndeksa";
            this.lblBrojIndeksa.Size = new System.Drawing.Size(71, 15);
            this.lblBrojIndeksa.TabIndex = 7;
            this.lblBrojIndeksa.Text = "Broj indeksa";
            // 
            // txtBrojIndeksa
            // 
            this.txtBrojIndeksa.Location = new System.Drawing.Point(12, 324);
            this.txtBrojIndeksa.Name = "txtBrojIndeksa";
            this.txtBrojIndeksa.ReadOnly = true;
            this.txtBrojIndeksa.Size = new System.Drawing.Size(200, 23);
            this.txtBrojIndeksa.TabIndex = 6;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(12, 352);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(36, 15);
            this.lblMail.TabIndex = 9;
            this.lblMail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 372);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 23);
            this.txtEmail.TabIndex = 8;
            // 
            // cbAktivan
            // 
            this.cbAktivan.AutoSize = true;
            this.cbAktivan.Location = new System.Drawing.Point(146, 203);
            this.cbAktivan.Name = "cbAktivan";
            this.cbAktivan.Size = new System.Drawing.Size(66, 19);
            this.cbAktivan.TabIndex = 11;
            this.cbAktivan.Text = "Aktivan";
            this.cbAktivan.UseVisualStyleBackColor = true;
            // 
            // dtpDatumRodjenja
            // 
            this.dtpDatumRodjenja.Location = new System.Drawing.Point(12, 420);
            this.dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            this.dtpDatumRodjenja.Size = new System.Drawing.Size(200, 23);
            this.dtpDatumRodjenja.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Datum rođenja";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtProsjek);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cbPredmet);
            this.groupBox1.Controls.Add(this.dgvPolozeni);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbOcjena);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblDatumPolaganja);
            this.groupBox1.Controls.Add(this.lblProsjek);
            this.groupBox1.Controls.Add(this.dtpDatumPolaganja);
            this.groupBox1.Controls.Add(this.lblDodaj);
            this.groupBox1.Location = new System.Drawing.Point(234, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 460);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Položeni predmeti";
            // 
            // txtProsjek
            // 
            this.txtProsjek.Location = new System.Drawing.Point(415, 283);
            this.txtProsjek.Name = "txtProsjek";
            this.txtProsjek.Size = new System.Drawing.Size(61, 23);
            this.txtProsjek.TabIndex = 23;
            // 
            // cbPredmet
            // 
            this.cbPredmet.FormattingEnabled = true;
            this.cbPredmet.Location = new System.Drawing.Point(6, 310);
            this.cbPredmet.Name = "cbPredmet";
            this.cbPredmet.Size = new System.Drawing.Size(202, 23);
            this.cbPredmet.TabIndex = 16;
            // 
            // dgvPolozeni
            // 
            this.dgvPolozeni.AllowUserToAddRows = false;
            this.dgvPolozeni.AllowUserToDeleteRows = false;
            this.dgvPolozeni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPolozeni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Predmet,
            this.Ocjena,
            this.Datum,
            this.Obrisi});
            this.dgvPolozeni.Location = new System.Drawing.Point(6, 22);
            this.dgvPolozeni.Name = "dgvPolozeni";
            this.dgvPolozeni.ReadOnly = true;
            this.dgvPolozeni.RowTemplate.Height = 25;
            this.dgvPolozeni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPolozeni.Size = new System.Drawing.Size(476, 254);
            this.dgvPolozeni.TabIndex = 0;
            this.dgvPolozeni.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPolozeni_CellContentClick);
            // 
            // Predmet
            // 
            this.Predmet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Predmet.DataPropertyName = "Predmet";
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.Name = "Predmet";
            this.Predmet.ReadOnly = true;
            // 
            // Ocjena
            // 
            this.Ocjena.DataPropertyName = "Ocjena";
            this.Ocjena.HeaderText = "Ocjena";
            this.Ocjena.Name = "Ocjena";
            this.Ocjena.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum Polaganja";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // Obrisi
            // 
            this.Obrisi.HeaderText = "";
            this.Obrisi.Name = "Obrisi";
            this.Obrisi.ReadOnly = true;
            this.Obrisi.Text = "Obriši";
            this.Obrisi.UseColumnTextForButtonValue = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Ocjena";
            // 
            // cmbOcjena
            // 
            this.cmbOcjena.FormattingEnabled = true;
            this.cmbOcjena.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbOcjena.Location = new System.Drawing.Point(6, 360);
            this.cmbOcjena.Name = "cmbOcjena";
            this.cmbOcjena.Size = new System.Drawing.Size(202, 23);
            this.cmbOcjena.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Predmet";
            // 
            // lblDatumPolaganja
            // 
            this.lblDatumPolaganja.AutoSize = true;
            this.lblDatumPolaganja.Location = new System.Drawing.Point(6, 388);
            this.lblDatumPolaganja.Name = "lblDatumPolaganja";
            this.lblDatumPolaganja.Size = new System.Drawing.Size(98, 15);
            this.lblDatumPolaganja.TabIndex = 21;
            this.lblDatumPolaganja.Text = "Datum polaganja";
            // 
            // lblProsjek
            // 
            this.lblProsjek.AutoSize = true;
            this.lblProsjek.Location = new System.Drawing.Point(364, 286);
            this.lblProsjek.Name = "lblProsjek";
            this.lblProsjek.Size = new System.Drawing.Size(45, 15);
            this.lblProsjek.TabIndex = 24;
            this.lblProsjek.Text = "Prosjek";
            // 
            // dtpDatumPolaganja
            // 
            this.dtpDatumPolaganja.Location = new System.Drawing.Point(6, 408);
            this.dtpDatumPolaganja.Name = "dtpDatumPolaganja";
            this.dtpDatumPolaganja.Size = new System.Drawing.Size(200, 23);
            this.dtpDatumPolaganja.TabIndex = 20;
            // 
            // lblDodaj
            // 
            this.lblDodaj.Location = new System.Drawing.Point(229, 412);
            this.lblDodaj.Name = "lblDodaj";
            this.lblDodaj.Size = new System.Drawing.Size(106, 23);
            this.lblDodaj.TabIndex = 23;
            this.lblDodaj.Text = "Dodaj";
            this.lblDodaj.UseVisualStyleBackColor = true;
            this.lblDodaj.Click += new System.EventHandler(this.lblDodaj_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Printaj potvrdu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSpasi
            // 
            this.btnSpasi.Location = new System.Drawing.Point(106, 449);
            this.btnSpasi.Name = "btnSpasi";
            this.btnSpasi.Size = new System.Drawing.Size(106, 23);
            this.btnSpasi.TabIndex = 22;
            this.btnSpasi.Text = "Spasi izmjene";
            this.btnSpasi.UseVisualStyleBackColor = true;
            // 
            // frmStudentProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 481);
            this.Controls.Add(this.btnSpasi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDatumRodjenja);
            this.Controls.Add(this.cbAktivan);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblBrojIndeksa);
            this.Controls.Add(this.txtBrojIndeksa);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.pbSlikaStudenta);
            this.Name = "frmStudentProfil";
            this.Text = "Profil studenta";
            ((System.ComponentModel.ISupportInitialize)(this.pbSlikaStudenta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolozeni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pbSlikaStudenta;
        private TextBox txtIme;
        private Label lblIme;
        private Label lblPrezime;
        private TextBox txtPrezime;
        private Label lblBrojIndeksa;
        private TextBox txtBrojIndeksa;
        private Label lblMail;
        private TextBox txtEmail;
        private CheckBox cbAktivan;
        private DateTimePicker dtpDatumRodjenja;
        private Label label1;
        private GroupBox groupBox1;
        private DataGridView dgvPolozeni;
        private Button button1;
        private ComboBox cbPredmet;
        private Label label2;
        private Label label3;
        private ComboBox cmbOcjena;
        private Label lblDatumPolaganja;
        private DateTimePicker dtpDatumPolaganja;
        private Button btnSpasi;
        private Button lblDodaj;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Ocjena;
        private DataGridViewTextBoxColumn Datum;
        private DataGridViewButtonColumn Obrisi;
        private TextBox txtProsjek;
        private Label lblProsjek;
    }
}