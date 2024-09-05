namespace gestpro
{
    partial class Fmodifclient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fmodifclient));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestProDBDataSet = new gestpro.GestProDBDataSet();
            this.SAVE = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.NAI = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.NIS = new System.Windows.Forms.TextBox();
            this.MOB = new System.Windows.Forms.TextBox();
            this.SOLD = new System.Windows.Forms.TextBox();
            this.NIF = new System.Windows.Forms.TextBox();
            this.RC = new System.Windows.Forms.TextBox();
            this.VILLE = new System.Windows.Forms.TextBox();
            this.MAIL = new System.Windows.Forms.TextBox();
            this.TEL = new System.Windows.Forms.TextBox();
            this.ADR = new System.Windows.Forms.TextBox();
            this.CAT = new System.Windows.Forms.TextBox();
            this.NOM = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cLIENTTableAdapter = new gestpro.GestProDBDataSetTableAdapters.CLIENTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestProDBDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // SAVE
            // 
            this.SAVE.Location = new System.Drawing.Point(695, 340);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(96, 31);
            this.SAVE.TabIndex = 3;
            this.SAVE.Text = "MODIFIER";
            this.SAVE.UseVisualStyleBackColor = true;
            this.SAVE.Click += new System.EventHandler(this.SAVE_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.NAI);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.SAVE);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.NIS);
            this.panel1.Controls.Add(this.MOB);
            this.panel1.Controls.Add(this.SOLD);
            this.panel1.Controls.Add(this.NIF);
            this.panel1.Controls.Add(this.RC);
            this.panel1.Controls.Add(this.VILLE);
            this.panel1.Controls.Add(this.MAIL);
            this.panel1.Controls.Add(this.TEL);
            this.panel1.Controls.Add(this.ADR);
            this.panel1.Controls.Add(this.CAT);
            this.panel1.Controls.Add(this.NOM);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 386);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Ivory;
            this.label9.Location = new System.Drawing.Point(505, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 24);
            this.label9.TabIndex = 32;
            this.label9.Text = "NAI";
            // 
            // NAI
            // 
            this.NAI.Location = new System.Drawing.Point(695, 191);
            this.NAI.Name = "NAI";
            this.NAI.Size = new System.Drawing.Size(150, 20);
            this.NAI.TabIndex = 31;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(152, 340);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 31);
            this.button4.TabIndex = 28;
            this.button4.Text = "EFFACER";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(293, 340);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 31);
            this.button3.TabIndex = 27;
            this.button3.Text = "SUPRIMER";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(439, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 31);
            this.button2.TabIndex = 26;
            this.button2.Text = "ACTUALISER";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Ivory;
            this.label12.Location = new System.Drawing.Point(505, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 24);
            this.label12.TabIndex = 25;
            this.label12.Text = "NIS";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Ivory;
            this.label11.Location = new System.Drawing.Point(505, 277);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 24);
            this.label11.TabIndex = 24;
            this.label11.Text = "MOBILE";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(571, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 31);
            this.button1.TabIndex = 21;
            this.button1.Text = "INSERER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NIS
            // 
            this.NIS.Location = new System.Drawing.Point(695, 144);
            this.NIS.Name = "NIS";
            this.NIS.Size = new System.Drawing.Size(150, 20);
            this.NIS.TabIndex = 23;
            // 
            // MOB
            // 
            this.MOB.Location = new System.Drawing.Point(695, 274);
            this.MOB.Name = "MOB";
            this.MOB.Size = new System.Drawing.Size(150, 20);
            this.MOB.TabIndex = 22;
            // 
            // SOLD
            // 
            this.SOLD.Location = new System.Drawing.Point(695, 232);
            this.SOLD.Name = "SOLD";
            this.SOLD.Size = new System.Drawing.Size(150, 20);
            this.SOLD.TabIndex = 18;
            // 
            // NIF
            // 
            this.NIF.Location = new System.Drawing.Point(695, 103);
            this.NIF.Name = "NIF";
            this.NIF.Size = new System.Drawing.Size(150, 20);
            this.NIF.TabIndex = 17;
            // 
            // RC
            // 
            this.RC.Location = new System.Drawing.Point(695, 54);
            this.RC.Name = "RC";
            this.RC.Size = new System.Drawing.Size(150, 20);
            this.RC.TabIndex = 16;
            // 
            // VILLE
            // 
            this.VILLE.Location = new System.Drawing.Point(207, 292);
            this.VILLE.Name = "VILLE";
            this.VILLE.Size = new System.Drawing.Size(150, 20);
            this.VILLE.TabIndex = 15;
            // 
            // MAIL
            // 
            this.MAIL.Location = new System.Drawing.Point(207, 241);
            this.MAIL.Name = "MAIL";
            this.MAIL.Size = new System.Drawing.Size(150, 20);
            this.MAIL.TabIndex = 14;
            // 
            // TEL
            // 
            this.TEL.Location = new System.Drawing.Point(207, 194);
            this.TEL.Name = "TEL";
            this.TEL.Size = new System.Drawing.Size(150, 20);
            this.TEL.TabIndex = 13;
            // 
            // ADR
            // 
            this.ADR.Location = new System.Drawing.Point(207, 144);
            this.ADR.Name = "ADR";
            this.ADR.Size = new System.Drawing.Size(150, 20);
            this.ADR.TabIndex = 12;
            // 
            // CAT
            // 
            this.CAT.Location = new System.Drawing.Point(207, 94);
            this.CAT.Name = "CAT";
            this.CAT.Size = new System.Drawing.Size(150, 20);
            this.CAT.TabIndex = 11;
            // 
            // NOM
            // 
            this.NOM.Location = new System.Drawing.Point(207, 52);
            this.NOM.Name = "NOM";
            this.NOM.Size = new System.Drawing.Size(150, 20);
            this.NOM.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Ivory;
            this.label10.Location = new System.Drawing.Point(505, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 22);
            this.label10.TabIndex = 9;
            this.label10.Text = "SOLDE ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Ivory;
            this.label8.Location = new System.Drawing.Point(505, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "NIF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Ivory;
            this.label7.Location = new System.Drawing.Point(505, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "NRC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Ivory;
            this.label6.Location = new System.Drawing.Point(55, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "VILLE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Ivory;
            this.label5.Location = new System.Drawing.Point(50, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "EMAIL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Ivory;
            this.label4.Location = new System.Drawing.Point(50, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "TELEPHONE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Ivory;
            this.label3.Location = new System.Drawing.Point(50, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "ADRESSE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Ivory;
            this.label2.Location = new System.Drawing.Point(50, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "CATEGORIE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(55, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOM";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 386);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1084, 197);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // cLIENTTableAdapter
            // 
            this.cLIENTTableAdapter.ClearBeforeFill = true;
            // 
            // Fmodifclient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1100, 650);
            this.MinimumSize = new System.Drawing.Size(1100, 650);
            this.Name = "Fmodifclient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fmodifclient";
            this.Load += new System.EventHandler(this.Fmodifclient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestProDBDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GestProDBDataSet gestProDBDataSet;
        private System.Windows.Forms.BindingSource cLIENTBindingSource;
        private GestProDBDataSetTableAdapters.CLIENTTableAdapter cLIENTTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button SAVE;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SOLD;
        private System.Windows.Forms.TextBox NIF;
        private System.Windows.Forms.TextBox RC;
        private System.Windows.Forms.TextBox VILLE;
        private System.Windows.Forms.TextBox MAIL;
        private System.Windows.Forms.TextBox TEL;
        private System.Windows.Forms.TextBox ADR;
        private System.Windows.Forms.TextBox CAT;
        private System.Windows.Forms.TextBox NOM;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox NIS;
        private System.Windows.Forms.TextBox MOB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NAI;
    }
}