namespace gestpro
{
    partial class FFOURNIS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FFOURNIS));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fOURNISSEURBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestProDBDataSet3 = new gestpro.GestProDBDataSet3();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.fOURNISSEURTableAdapter = new gestpro.GestProDBDataSet3TableAdapters.FOURNISSEURTableAdapter();
            this.ID_FRS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOM_FRS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEG_FRS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADR_FRS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VILLE_FRS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEL_FRS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOBIL_FRS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL_FRS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIF_FRS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIS_FRS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLDE_DETTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATETIMECREATION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAI_FRS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NRC_FRS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOURNISSEURBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestProDBDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_FRS,
            this.NOM_FRS,
            this.CATEG_FRS,
            this.ADR_FRS,
            this.VILLE_FRS,
            this.TEL_FRS,
            this.MOBIL_FRS,
            this.EMAIL_FRS,
            this.NIF_FRS,
            this.NIS_FRS,
            this.SOLDE_DETTE,
            this.DATETIMECREATION,
            this.NAI_FRS,
            this.NRC_FRS});
            this.dataGridView1.DataSource = this.fOURNISSEURBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(150, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(800, 300);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // fOURNISSEURBindingSource
            // 
            this.fOURNISSEURBindingSource.DataMember = "FOURNISSEUR";
            this.fOURNISSEURBindingSource.DataSource = this.gestProDBDataSet3;
            // 
            // gestProDBDataSet3
            // 
            this.gestProDBDataSet3.DataSetName = "GestProDBDataSet3";
            this.gestProDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(273, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(143, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Liste des Fournisseurs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Azure;
            this.label2.Location = new System.Drawing.Point(159, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rechercher ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Azure;
            this.label3.Location = new System.Drawing.Point(452, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ajouter/Modifier";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(612, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(708, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Actualiser";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fOURNISSEURTableAdapter
            // 
            this.fOURNISSEURTableAdapter.ClearBeforeFill = true;
            // 
            // ID_FRS
            // 
            this.ID_FRS.DataPropertyName = "ID_FRS";
            this.ID_FRS.HeaderText = "ID_FRS";
            this.ID_FRS.Name = "ID_FRS";
            this.ID_FRS.ReadOnly = true;
            // 
            // NOM_FRS
            // 
            this.NOM_FRS.DataPropertyName = "NOM_FRS";
            this.NOM_FRS.HeaderText = "NOM_FRS";
            this.NOM_FRS.Name = "NOM_FRS";
            this.NOM_FRS.ReadOnly = true;
            // 
            // CATEG_FRS
            // 
            this.CATEG_FRS.DataPropertyName = "CATEG_FRS";
            this.CATEG_FRS.HeaderText = "CATEG_FRS";
            this.CATEG_FRS.Name = "CATEG_FRS";
            this.CATEG_FRS.ReadOnly = true;
            // 
            // ADR_FRS
            // 
            this.ADR_FRS.DataPropertyName = "ADR_FRS";
            this.ADR_FRS.HeaderText = "ADR_FRS";
            this.ADR_FRS.Name = "ADR_FRS";
            this.ADR_FRS.ReadOnly = true;
            // 
            // VILLE_FRS
            // 
            this.VILLE_FRS.DataPropertyName = "VILLE_FRS";
            this.VILLE_FRS.HeaderText = "VILLE_FRS";
            this.VILLE_FRS.Name = "VILLE_FRS";
            this.VILLE_FRS.ReadOnly = true;
            // 
            // TEL_FRS
            // 
            this.TEL_FRS.DataPropertyName = "TEL_FRS";
            this.TEL_FRS.HeaderText = "TEL_FRS";
            this.TEL_FRS.Name = "TEL_FRS";
            this.TEL_FRS.ReadOnly = true;
            // 
            // MOBIL_FRS
            // 
            this.MOBIL_FRS.DataPropertyName = "MOBIL_FRS";
            this.MOBIL_FRS.HeaderText = "MOBIL_FRS";
            this.MOBIL_FRS.Name = "MOBIL_FRS";
            this.MOBIL_FRS.ReadOnly = true;
            // 
            // EMAIL_FRS
            // 
            this.EMAIL_FRS.DataPropertyName = "EMAIL_FRS";
            this.EMAIL_FRS.HeaderText = "EMAIL_FRS";
            this.EMAIL_FRS.Name = "EMAIL_FRS";
            this.EMAIL_FRS.ReadOnly = true;
            // 
            // NIF_FRS
            // 
            this.NIF_FRS.DataPropertyName = "NIF_FRS";
            this.NIF_FRS.HeaderText = "NIF_FRS";
            this.NIF_FRS.Name = "NIF_FRS";
            this.NIF_FRS.ReadOnly = true;
            // 
            // NIS_FRS
            // 
            this.NIS_FRS.DataPropertyName = "NIS_FRS";
            this.NIS_FRS.HeaderText = "NIS_FRS";
            this.NIS_FRS.Name = "NIS_FRS";
            this.NIS_FRS.ReadOnly = true;
            // 
            // SOLDE_DETTE
            // 
            this.SOLDE_DETTE.DataPropertyName = "SOLDE_DETTE";
            this.SOLDE_DETTE.HeaderText = "SOLDE_DETTE";
            this.SOLDE_DETTE.Name = "SOLDE_DETTE";
            this.SOLDE_DETTE.ReadOnly = true;
            // 
            // DATETIMECREATION
            // 
            this.DATETIMECREATION.DataPropertyName = "DATETIMECREATION";
            this.DATETIMECREATION.HeaderText = "DATETIMECREATION";
            this.DATETIMECREATION.Name = "DATETIMECREATION";
            this.DATETIMECREATION.ReadOnly = true;
            // 
            // NAI_FRS
            // 
            this.NAI_FRS.DataPropertyName = "NAI_FRS";
            this.NAI_FRS.HeaderText = "NAI_FRS";
            this.NAI_FRS.Name = "NAI_FRS";
            this.NAI_FRS.ReadOnly = true;
            // 
            // NRC_FRS
            // 
            this.NRC_FRS.DataPropertyName = "NRC_FRS";
            this.NRC_FRS.HeaderText = "NRC_FRS";
            this.NRC_FRS.Name = "NRC_FRS";
            this.NRC_FRS.ReadOnly = true;
            // 
            // FFOURNIS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Location = new System.Drawing.Point(150, 0);
            this.Name = "FFOURNIS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FFOURNIS";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FFOURNIS_FormClosed);
            this.Load += new System.EventHandler(this.FFOURNIS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOURNISSEURBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestProDBDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
     
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
      
        private GestProDBDataSet3 gestProDBDataSet3;
        private System.Windows.Forms.BindingSource fOURNISSEURBindingSource;
        private GestProDBDataSet3TableAdapters.FOURNISSEURTableAdapter fOURNISSEURTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_FRS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOM_FRS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEG_FRS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADR_FRS;
        private System.Windows.Forms.DataGridViewTextBoxColumn VILLE_FRS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEL_FRS;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOBIL_FRS;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL_FRS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIF_FRS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIS_FRS;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLDE_DETTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATETIMECREATION;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAI_FRS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NRC_FRS;
    }
}