namespace gestpro
{
    partial class FComercial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FComercial));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestProDBDataSet = new gestpro.GestProDBDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.AJOUTER = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.advancedDataGridView1 = new Zuby.ADGV.AdvancedDataGridView();
            this.ID_CLT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMCLTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cATEGCLTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDRCLTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vILLECLTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELCLTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mOBILCLTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILCLTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIFCLTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nISCLTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOLDECREANCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATETIMECREATIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nRCCLTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAICLTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cLIENTTableAdapter = new gestpro.GestProDBDataSetTableAdapters.CLIENTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestProDBDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.cLIENTBindingSource;
            // 
            // cLIENTBindingSource
            // 
            this.cLIENTBindingSource.DataMember = "CLIENT";
            this.cLIENTBindingSource.DataSource = this.gestProDBDataSet;
            // 
            // gestProDBDataSet
            // 
            this.gestProDBDataSet.DataSetName = "GestProDBDataSet";
            this.gestProDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(856, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.AJOUTER);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.advancedDataGridView1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 611);
            this.panel1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(890, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 28);
            this.button2.TabIndex = 13;
            this.button2.Text = "REGLEMENT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(391, 100);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButton1.Size = new System.Drawing.Size(88, 27);
            this.simpleButton1.TabIndex = 12;
            this.simpleButton1.Text = "Actualiser";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // AJOUTER
            // 
            this.AJOUTER.Location = new System.Drawing.Point(696, 99);
            this.AJOUTER.Name = "AJOUTER";
            this.AJOUTER.Size = new System.Drawing.Size(104, 27);
            this.AJOUTER.TabIndex = 11;
            this.AJOUTER.Text = "Ajouter";
            this.AJOUTER.UseVisualStyleBackColor = true;
            this.AJOUTER.Click += new System.EventHandler(this.AJOUTER_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(485, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ajouter/Modifier un Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(43, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Rechercher un client ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "Liste des Clients";
            // 
            // advancedDataGridView1
            // 
            this.advancedDataGridView1.AllowUserToAddRows = false;
            this.advancedDataGridView1.AllowUserToDeleteRows = false;
            this.advancedDataGridView1.AutoGenerateColumns = false;
            this.advancedDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.advancedDataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.advancedDataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.advancedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_CLT,
            this.nOMCLTDataGridViewTextBoxColumn,
            this.cATEGCLTDataGridViewTextBoxColumn,
            this.aDRCLTDataGridViewTextBoxColumn,
            this.vILLECLTDataGridViewTextBoxColumn,
            this.tELCLTDataGridViewTextBoxColumn,
            this.mOBILCLTDataGridViewTextBoxColumn,
            this.eMAILCLTDataGridViewTextBoxColumn,
            this.nIFCLTDataGridViewTextBoxColumn,
            this.nISCLTDataGridViewTextBoxColumn,
            this.sOLDECREANCEDataGridViewTextBoxColumn,
            this.dATETIMECREATIONDataGridViewTextBoxColumn,
            this.nRCCLTDataGridViewTextBoxColumn,
            this.nAICLTDataGridViewTextBoxColumn});
            this.advancedDataGridView1.DataSource = this.bindingSource1;
            this.advancedDataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.advancedDataGridView1.FilterAndSortEnabled = true;
            this.advancedDataGridView1.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.advancedDataGridView1.Location = new System.Drawing.Point(47, 135);
            this.advancedDataGridView1.MaxFilterButtonImageHeight = 23;
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.ReadOnly = true;
            this.advancedDataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.advancedDataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.advancedDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.advancedDataGridView1.Size = new System.Drawing.Size(997, 300);
            this.advancedDataGridView1.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.advancedDataGridView1.TabIndex = 7;
            this.advancedDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.advancedDataGridView1_CellContentClick);
            // 
            // ID_CLT
            // 
            this.ID_CLT.DataPropertyName = "ID_CLT";
            this.ID_CLT.HeaderText = "ID_CLT";
            this.ID_CLT.MinimumWidth = 24;
            this.ID_CLT.Name = "ID_CLT";
            this.ID_CLT.ReadOnly = true;
            this.ID_CLT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ID_CLT.Width = 69;
            // 
            // nOMCLTDataGridViewTextBoxColumn
            // 
            this.nOMCLTDataGridViewTextBoxColumn.DataPropertyName = "NOM_CLT";
            this.nOMCLTDataGridViewTextBoxColumn.HeaderText = "NOM_CLT";
            this.nOMCLTDataGridViewTextBoxColumn.MinimumWidth = 24;
            this.nOMCLTDataGridViewTextBoxColumn.Name = "nOMCLTDataGridViewTextBoxColumn";
            this.nOMCLTDataGridViewTextBoxColumn.ReadOnly = true;
            this.nOMCLTDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.nOMCLTDataGridViewTextBoxColumn.Width = 83;
            // 
            // cATEGCLTDataGridViewTextBoxColumn
            // 
            this.cATEGCLTDataGridViewTextBoxColumn.DataPropertyName = "CATEG_CLT";
            this.cATEGCLTDataGridViewTextBoxColumn.HeaderText = "CATEG_CLT";
            this.cATEGCLTDataGridViewTextBoxColumn.MinimumWidth = 24;
            this.cATEGCLTDataGridViewTextBoxColumn.Name = "cATEGCLTDataGridViewTextBoxColumn";
            this.cATEGCLTDataGridViewTextBoxColumn.ReadOnly = true;
            this.cATEGCLTDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.cATEGCLTDataGridViewTextBoxColumn.Width = 94;
            // 
            // aDRCLTDataGridViewTextBoxColumn
            // 
            this.aDRCLTDataGridViewTextBoxColumn.DataPropertyName = "ADR_CLT";
            this.aDRCLTDataGridViewTextBoxColumn.HeaderText = "ADR_CLT";
            this.aDRCLTDataGridViewTextBoxColumn.MinimumWidth = 24;
            this.aDRCLTDataGridViewTextBoxColumn.Name = "aDRCLTDataGridViewTextBoxColumn";
            this.aDRCLTDataGridViewTextBoxColumn.ReadOnly = true;
            this.aDRCLTDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.aDRCLTDataGridViewTextBoxColumn.Width = 81;
            // 
            // vILLECLTDataGridViewTextBoxColumn
            // 
            this.vILLECLTDataGridViewTextBoxColumn.DataPropertyName = "VILLE_CLT";
            this.vILLECLTDataGridViewTextBoxColumn.HeaderText = "VILLE_CLT";
            this.vILLECLTDataGridViewTextBoxColumn.MinimumWidth = 24;
            this.vILLECLTDataGridViewTextBoxColumn.Name = "vILLECLTDataGridViewTextBoxColumn";
            this.vILLECLTDataGridViewTextBoxColumn.ReadOnly = true;
            this.vILLECLTDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.vILLECLTDataGridViewTextBoxColumn.Width = 87;
            // 
            // tELCLTDataGridViewTextBoxColumn
            // 
            this.tELCLTDataGridViewTextBoxColumn.DataPropertyName = "TEL_CLT";
            this.tELCLTDataGridViewTextBoxColumn.HeaderText = "TEL_CLT";
            this.tELCLTDataGridViewTextBoxColumn.MinimumWidth = 24;
            this.tELCLTDataGridViewTextBoxColumn.Name = "tELCLTDataGridViewTextBoxColumn";
            this.tELCLTDataGridViewTextBoxColumn.ReadOnly = true;
            this.tELCLTDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.tELCLTDataGridViewTextBoxColumn.Width = 78;
            // 
            // mOBILCLTDataGridViewTextBoxColumn
            // 
            this.mOBILCLTDataGridViewTextBoxColumn.DataPropertyName = "MOBIL_CLT";
            this.mOBILCLTDataGridViewTextBoxColumn.HeaderText = "MOBIL_CLT";
            this.mOBILCLTDataGridViewTextBoxColumn.MinimumWidth = 24;
            this.mOBILCLTDataGridViewTextBoxColumn.Name = "mOBILCLTDataGridViewTextBoxColumn";
            this.mOBILCLTDataGridViewTextBoxColumn.ReadOnly = true;
            this.mOBILCLTDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.mOBILCLTDataGridViewTextBoxColumn.Width = 91;
            // 
            // eMAILCLTDataGridViewTextBoxColumn
            // 
            this.eMAILCLTDataGridViewTextBoxColumn.DataPropertyName = "EMAIL_CLT";
            this.eMAILCLTDataGridViewTextBoxColumn.HeaderText = "EMAIL_CLT";
            this.eMAILCLTDataGridViewTextBoxColumn.MinimumWidth = 24;
            this.eMAILCLTDataGridViewTextBoxColumn.Name = "eMAILCLTDataGridViewTextBoxColumn";
            this.eMAILCLTDataGridViewTextBoxColumn.ReadOnly = true;
            this.eMAILCLTDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.eMAILCLTDataGridViewTextBoxColumn.Width = 90;
            // 
            // nIFCLTDataGridViewTextBoxColumn
            // 
            this.nIFCLTDataGridViewTextBoxColumn.DataPropertyName = "NIF_CLT";
            this.nIFCLTDataGridViewTextBoxColumn.HeaderText = "NIF_CLT";
            this.nIFCLTDataGridViewTextBoxColumn.MinimumWidth = 24;
            this.nIFCLTDataGridViewTextBoxColumn.Name = "nIFCLTDataGridViewTextBoxColumn";
            this.nIFCLTDataGridViewTextBoxColumn.ReadOnly = true;
            this.nIFCLTDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.nIFCLTDataGridViewTextBoxColumn.Width = 75;
            // 
            // nISCLTDataGridViewTextBoxColumn
            // 
            this.nISCLTDataGridViewTextBoxColumn.DataPropertyName = "NIS_CLT";
            this.nISCLTDataGridViewTextBoxColumn.HeaderText = "NIS_CLT";
            this.nISCLTDataGridViewTextBoxColumn.MinimumWidth = 24;
            this.nISCLTDataGridViewTextBoxColumn.Name = "nISCLTDataGridViewTextBoxColumn";
            this.nISCLTDataGridViewTextBoxColumn.ReadOnly = true;
            this.nISCLTDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.nISCLTDataGridViewTextBoxColumn.Width = 76;
            // 
            // sOLDECREANCEDataGridViewTextBoxColumn
            // 
            this.sOLDECREANCEDataGridViewTextBoxColumn.DataPropertyName = "SOLDE_CREANCE";
            this.sOLDECREANCEDataGridViewTextBoxColumn.HeaderText = "SOLDE_CREANCE";
            this.sOLDECREANCEDataGridViewTextBoxColumn.MinimumWidth = 24;
            this.sOLDECREANCEDataGridViewTextBoxColumn.Name = "sOLDECREANCEDataGridViewTextBoxColumn";
            this.sOLDECREANCEDataGridViewTextBoxColumn.ReadOnly = true;
            this.sOLDECREANCEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.sOLDECREANCEDataGridViewTextBoxColumn.Width = 125;
            // 
            // dATETIMECREATIONDataGridViewTextBoxColumn
            // 
            this.dATETIMECREATIONDataGridViewTextBoxColumn.DataPropertyName = "DATETIMECREATION";
            this.dATETIMECREATIONDataGridViewTextBoxColumn.HeaderText = "DATETIMECREATION";
            this.dATETIMECREATIONDataGridViewTextBoxColumn.MinimumWidth = 24;
            this.dATETIMECREATIONDataGridViewTextBoxColumn.Name = "dATETIMECREATIONDataGridViewTextBoxColumn";
            this.dATETIMECREATIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.dATETIMECREATIONDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dATETIMECREATIONDataGridViewTextBoxColumn.Width = 142;
            // 
            // nRCCLTDataGridViewTextBoxColumn
            // 
            this.nRCCLTDataGridViewTextBoxColumn.DataPropertyName = "NRC_CLT";
            this.nRCCLTDataGridViewTextBoxColumn.HeaderText = "NRC_CLT";
            this.nRCCLTDataGridViewTextBoxColumn.MinimumWidth = 24;
            this.nRCCLTDataGridViewTextBoxColumn.Name = "nRCCLTDataGridViewTextBoxColumn";
            this.nRCCLTDataGridViewTextBoxColumn.ReadOnly = true;
            this.nRCCLTDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.nRCCLTDataGridViewTextBoxColumn.Width = 81;
            // 
            // nAICLTDataGridViewTextBoxColumn
            // 
            this.nAICLTDataGridViewTextBoxColumn.DataPropertyName = "NAI_CLT";
            this.nAICLTDataGridViewTextBoxColumn.HeaderText = "NAI_CLT";
            this.nAICLTDataGridViewTextBoxColumn.MinimumWidth = 24;
            this.nAICLTDataGridViewTextBoxColumn.Name = "nAICLTDataGridViewTextBoxColumn";
            this.nAICLTDataGridViewTextBoxColumn.ReadOnly = true;
            this.nAICLTDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.nAICLTDataGridViewTextBoxColumn.Width = 76;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(227, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 29);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // cLIENTTableAdapter
            // 
            this.cLIENTTableAdapter.ClearBeforeFill = true;
            // 
            // FComercial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1100, 650);
            this.MinimumSize = new System.Drawing.Size(1100, 650);
            this.Name = "FComercial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FCOMMERCIALE";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.FComercial_HelpButtonClicked);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FComercial_FormClosing);
            this.Load += new System.EventHandler(this.FComercial_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestProDBDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GestProDBDataSet gestProDBDataSet;
        private System.Windows.Forms.BindingSource cLIENTBindingSource;
        private GestProDBDataSetTableAdapters.CLIENTTableAdapter cLIENTTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Zuby.ADGV.AdvancedDataGridView advancedDataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button AJOUTER;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CLT;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMCLTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cATEGCLTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDRCLTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vILLECLTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELCLTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOBILCLTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILCLTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIFCLTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nISCLTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOLDECREANCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATETIMECREATIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nRCCLTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAICLTDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
    }
}