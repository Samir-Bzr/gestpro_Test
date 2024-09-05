
namespace gestpro
{
    partial class Fregldirect
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fregldirect));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DATE = new System.Windows.Forms.TextBox();
            this.LBDT = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmpttxt = new System.Windows.Forms.TextBox();
            this.tx3 = new System.Windows.Forms.TextBox();
            this.tx1 = new System.Windows.Forms.TextBox();
            this.cmpt = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.Label();
            this.LB1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gestProDBDataSet7 = new gestpro.GestProDBDataSet7();
            this.gestProDBDataSet7BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gestProDBDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestProDBDataSet7BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(100, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(805, 189);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.DATE);
            this.panel1.Controls.Add(this.LBDT);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cmpttxt);
            this.panel1.Controls.Add(this.tx3);
            this.panel1.Controls.Add(this.tx1);
            this.panel1.Controls.Add(this.cmpt);
            this.panel1.Controls.Add(this.num);
            this.panel1.Controls.Add(this.LB1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(100, 328);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 183);
            this.panel1.TabIndex = 1;
            // 
            // DATE
            // 
            this.DATE.Location = new System.Drawing.Point(255, 150);
            this.DATE.Name = "DATE";
            this.DATE.Size = new System.Drawing.Size(186, 20);
            this.DATE.TabIndex = 12;
            // 
            // LBDT
            // 
            this.LBDT.AutoSize = true;
            this.LBDT.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBDT.ForeColor = System.Drawing.Color.GhostWhite;
            this.LBDT.Location = new System.Drawing.Point(457, 150);
            this.LBDT.Name = "LBDT";
            this.LBDT.Size = new System.Drawing.Size(62, 22);
            this.LBDT.TabIndex = 11;
            this.LBDT.Text = "DATE";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(708, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "INSERER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmpttxt
            // 
            this.cmpttxt.Location = new System.Drawing.Point(255, 113);
            this.cmpttxt.Name = "cmpttxt";
            this.cmpttxt.Size = new System.Drawing.Size(186, 20);
            this.cmpttxt.TabIndex = 8;
            // 
            // tx3
            // 
            this.tx3.Location = new System.Drawing.Point(255, 75);
            this.tx3.Name = "tx3";
            this.tx3.Size = new System.Drawing.Size(186, 20);
            this.tx3.TabIndex = 6;
            // 
            // tx1
            // 
            this.tx1.Location = new System.Drawing.Point(255, 43);
            this.tx1.Name = "tx1";
            this.tx1.Size = new System.Drawing.Size(186, 20);
            this.tx1.TabIndex = 5;
            // 
            // cmpt
            // 
            this.cmpt.AutoSize = true;
            this.cmpt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmpt.ForeColor = System.Drawing.Color.GhostWhite;
            this.cmpt.Location = new System.Drawing.Point(456, 113);
            this.cmpt.Name = "cmpt";
            this.cmpt.Size = new System.Drawing.Size(145, 22);
            this.cmpt.TabIndex = 3;
            this.cmpt.Text = "NUM COMPTE";
            // 
            // num
            // 
            this.num.AutoSize = true;
            this.num.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num.ForeColor = System.Drawing.Color.GhostWhite;
            this.num.Location = new System.Drawing.Point(456, 75);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(63, 22);
            this.num.TabIndex = 2;
            this.num.Text = "NUM°";
            // 
            // LB1
            // 
            this.LB1.AutoSize = true;
            this.LB1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB1.ForeColor = System.Drawing.Color.GhostWhite;
            this.LB1.Location = new System.Drawing.Point(456, 43);
            this.LB1.Name = "LB1";
            this.LB1.Size = new System.Drawing.Size(109, 22);
            this.LB1.TabIndex = 1;
            this.LB1.Text = "MONTANT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(480, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "AJOUTER UN REGLEMENT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.GhostWhite;
            this.label5.Location = new System.Drawing.Point(329, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 36);
            this.label5.TabIndex = 2;
            this.label5.Text = "Client";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(434, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(296, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // gestProDBDataSet7
            // 
            this.gestProDBDataSet7.DataSetName = "GestProDBDataSet7";
            this.gestProDBDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gestProDBDataSet7BindingSource
            // 
            this.gestProDBDataSet7BindingSource.DataSource = this.gestProDBDataSet7;
            this.gestProDBDataSet7BindingSource.Position = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(718, 304);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(187, 21);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Fregldirect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1100, 650);
            this.MinimumSize = new System.Drawing.Size(1100, 650);
            this.Name = "Fregldirect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fregldirect";
            this.Load += new System.EventHandler(this.Fregldirect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gestProDBDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestProDBDataSet7BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label cmpt;
        private System.Windows.Forms.Label num;
        private System.Windows.Forms.Label LB1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox cmpttxt;
        private System.Windows.Forms.TextBox tx3;
        private System.Windows.Forms.TextBox tx1;
        private GestProDBDataSet7 gestProDBDataSet7;
        private System.Windows.Forms.BindingSource gestProDBDataSet7BindingSource;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox DATE;
        private System.Windows.Forms.Label LBDT;
    }
}