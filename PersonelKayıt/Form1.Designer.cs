
namespace PersonelKayıt
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.EkleBtn = new System.Windows.Forms.Button();
            this.SilBtn = new System.Windows.Forms.Button();
            this.ListeleBtn = new System.Windows.Forms.Button();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.bolumTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelKayıtDBDataSet2 = new PersonelKayıt.PersonelKayıtDBDataSet2();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BirthDayPicker = new System.Windows.Forms.DateTimePicker();
            this.JoinDayPicker = new System.Windows.Forms.DateTimePicker();
            this.GüncelleBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.personelTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelKayıtDBDataSet = new PersonelKayıt.PersonelKayıtDBDataSet();
            this.personelTblTableAdapter = new PersonelKayıt.PersonelKayıtDBDataSetTableAdapters.PersonelTblTableAdapter();
            this.bolumTblTableAdapter = new PersonelKayıt.PersonelKayıtDBDataSet2TableAdapters.BolumTblTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.personelKayıtDBDataSet1 = new PersonelKayıt.PersonelKayıtDBDataSet1();
            this.personelKayıtDBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelTblBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.personelTblTableAdapter1 = new PersonelKayıt.PersonelKayıtDBDataSet1TableAdapters.PersonelTblTableAdapter();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.personelTblBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bolumTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelKayıtDBDataSet2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelKayıtDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelKayıtDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelKayıtDBDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelTblBindingSource1)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personelTblBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // EkleBtn
            // 
            this.EkleBtn.Location = new System.Drawing.Point(221, 30);
            this.EkleBtn.Name = "EkleBtn";
            this.EkleBtn.Size = new System.Drawing.Size(100, 23);
            this.EkleBtn.TabIndex = 1;
            this.EkleBtn.Text = "Personel Ekle";
            this.EkleBtn.UseVisualStyleBackColor = true;
            this.EkleBtn.Click += new System.EventHandler(this.EkleBtn_Click);
            // 
            // SilBtn
            // 
            this.SilBtn.Location = new System.Drawing.Point(374, 30);
            this.SilBtn.Name = "SilBtn";
            this.SilBtn.Size = new System.Drawing.Size(99, 23);
            this.SilBtn.TabIndex = 2;
            this.SilBtn.Text = "Personel Sil";
            this.SilBtn.UseVisualStyleBackColor = true;
            this.SilBtn.Click += new System.EventHandler(this.SilBtn_Click);
            // 
            // ListeleBtn
            // 
            this.ListeleBtn.Location = new System.Drawing.Point(49, 30);
            this.ListeleBtn.Name = "ListeleBtn";
            this.ListeleBtn.Size = new System.Drawing.Size(121, 23);
            this.ListeleBtn.TabIndex = 3;
            this.ListeleBtn.Text = "Personelleri Listele";
            this.ListeleBtn.UseVisualStyleBackColor = true;
            this.ListeleBtn.Click += new System.EventHandler(this.ListeleBtn_Click);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(70, 32);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 4;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(70, 66);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 5;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bolumTblBindingSource, "BolumIsmi", true));
            this.cmbDepartment.DataSource = this.bolumTblBindingSource;
            this.cmbDepartment.DisplayMember = "BolumIsmi";
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(560, 51);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(121, 21);
            this.cmbDepartment.TabIndex = 9;
            this.cmbDepartment.ValueMember = "Bolum_ID";
            // 
            // bolumTblBindingSource
            // 
            this.bolumTblBindingSource.DataMember = "BolumTbl";
            this.bolumTblBindingSource.DataSource = this.personelKayıtDBDataSet2;
            // 
            // personelKayıtDBDataSet2
            // 
            this.personelKayıtDBDataSet2.DataSetName = "PersonelKayıtDBDataSet2";
            this.personelKayıtDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "AD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "SOYAD:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Doğum Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "İşe Giriş Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(492, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Departman:";
            // 
            // BirthDayPicker
            // 
            this.BirthDayPicker.Location = new System.Drawing.Point(282, 32);
            this.BirthDayPicker.Name = "BirthDayPicker";
            this.BirthDayPicker.Size = new System.Drawing.Size(200, 20);
            this.BirthDayPicker.TabIndex = 16;
            // 
            // JoinDayPicker
            // 
            this.JoinDayPicker.Location = new System.Drawing.Point(282, 69);
            this.JoinDayPicker.Name = "JoinDayPicker";
            this.JoinDayPicker.Size = new System.Drawing.Size(200, 20);
            this.JoinDayPicker.TabIndex = 17;
            // 
            // GüncelleBtn
            // 
            this.GüncelleBtn.Location = new System.Drawing.Point(528, 30);
            this.GüncelleBtn.Name = "GüncelleBtn";
            this.GüncelleBtn.Size = new System.Drawing.Size(121, 23);
            this.GüncelleBtn.TabIndex = 18;
            this.GüncelleBtn.Text = "Personel Güncelle";
            this.GüncelleBtn.UseVisualStyleBackColor = true;
            this.GüncelleBtn.Click += new System.EventHandler(this.GüncelleBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.JoinDayPicker);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.BirthDayPicker);
            this.groupBox1.Controls.Add(this.cmbDepartment);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(699, 125);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Bilgileri";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ListeleBtn);
            this.groupBox2.Controls.Add(this.EkleBtn);
            this.groupBox2.Controls.Add(this.GüncelleBtn);
            this.groupBox2.Controls.Add(this.SilBtn);
            this.groupBox2.Location = new System.Drawing.Point(12, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(699, 75);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 224);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(699, 229);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(693, 210);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // personelTblBindingSource
            // 
            this.personelTblBindingSource.DataMember = "PersonelTbl";
            this.personelTblBindingSource.DataSource = this.personelKayıtDBDataSet;
            // 
            // personelKayıtDBDataSet
            // 
            this.personelKayıtDBDataSet.DataSetName = "PersonelKayıtDBDataSet";
            this.personelKayıtDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelTblTableAdapter
            // 
            this.personelTblTableAdapter.ClearBeforeFill = true;
            // 
            // bolumTblTableAdapter
            // 
            this.bolumTblTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(448, 457);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 22;
            this.textBox1.Visible = false;
            // 
            // personelKayıtDBDataSet1
            // 
            this.personelKayıtDBDataSet1.DataSetName = "PersonelKayıtDBDataSet1";
            this.personelKayıtDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelKayıtDBDataSet1BindingSource
            // 
            this.personelKayıtDBDataSet1BindingSource.DataSource = this.personelKayıtDBDataSet1;
            this.personelKayıtDBDataSet1BindingSource.Position = 0;
            // 
            // personelTblBindingSource1
            // 
            this.personelTblBindingSource1.DataMember = "PersonelTbl";
            this.personelTblBindingSource1.DataSource = this.personelKayıtDBDataSet1BindingSource;
            // 
            // personelTblTableAdapter1
            // 
            this.personelTblTableAdapter1.ClearBeforeFill = true;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(726, 25);
            this.fillToolStrip.TabIndex = 23;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(26, 22);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // personelTblBindingSource2
            // 
            this.personelTblBindingSource2.DataMember = "PersonelTbl";
            this.personelTblBindingSource2.DataSource = this.personelKayıtDBDataSet1BindingSource;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 456);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Kayıt Programı";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bolumTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelKayıtDBDataSet2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelKayıtDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelKayıtDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelKayıtDBDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelTblBindingSource1)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personelTblBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button EkleBtn;
        private System.Windows.Forms.Button SilBtn;
        private System.Windows.Forms.Button ListeleBtn;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker BirthDayPicker;
        private System.Windows.Forms.DateTimePicker JoinDayPicker;
        private System.Windows.Forms.Button GüncelleBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private PersonelKayıtDBDataSet personelKayıtDBDataSet;
        private System.Windows.Forms.BindingSource personelTblBindingSource;
        private PersonelKayıtDBDataSetTableAdapters.PersonelTblTableAdapter personelTblTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PersonelKayıtDBDataSet2 personelKayıtDBDataSet2;
        private System.Windows.Forms.BindingSource bolumTblBindingSource;
        private PersonelKayıtDBDataSet2TableAdapters.BolumTblTableAdapter bolumTblTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private PersonelKayıtDBDataSet1 personelKayıtDBDataSet1;
        private System.Windows.Forms.BindingSource personelKayıtDBDataSet1BindingSource;
        private System.Windows.Forms.BindingSource personelTblBindingSource1;
        private PersonelKayıtDBDataSet1TableAdapters.PersonelTblTableAdapter personelTblTableAdapter1;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.BindingSource personelTblBindingSource2;
    }
}

