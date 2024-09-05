namespace gestpro
{
    partial class Fprincipale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fprincipale));
            this.menu = new System.Windows.Forms.Panel();
            this.PANCOMMERCE = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelchild = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.PANCOMMERCE.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.AutoScroll = true;
            this.menu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menu.BackgroundImage")));
            this.menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menu.Controls.Add(this.PANCOMMERCE);
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(168, 611);
            this.menu.TabIndex = 0;
            // 
            // PANCOMMERCE
            // 
            this.PANCOMMERCE.BackColor = System.Drawing.Color.Transparent;
            this.PANCOMMERCE.Controls.Add(this.button3);
            this.PANCOMMERCE.Controls.Add(this.button2);
            this.PANCOMMERCE.Controls.Add(this.button1);
            this.PANCOMMERCE.Dock = System.Windows.Forms.DockStyle.Top;
            this.PANCOMMERCE.Location = new System.Drawing.Point(0, 0);
            this.PANCOMMERCE.Name = "PANCOMMERCE";
            this.PANCOMMERCE.Size = new System.Drawing.Size(168, 189);
            this.PANCOMMERCE.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.LightCyan;
            this.button2.Location = new System.Drawing.Point(0, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "FOURNISSEUR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightCyan;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "CLIENT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelchild
            // 
            this.panelchild.AutoScroll = true;
            this.panelchild.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelchild.BackgroundImage")));
            this.panelchild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelchild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelchild.Location = new System.Drawing.Point(168, 0);
            this.panelchild.Name = "panelchild";
            this.panelchild.Size = new System.Drawing.Size(916, 611);
            this.panelchild.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.LightCyan;
            this.button3.Location = new System.Drawing.Point(0, 90);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 56);
            this.button3.TabIndex = 3;
            this.button3.Text = "BON DE LIVRAISON";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Fprincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.panelchild);
            this.Controls.Add(this.menu);
            this.Name = "Fprincipale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fprincipale";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Fprincipale_FormClosing);
            this.Load += new System.EventHandler(this.Fprincipale_Load);
            this.menu.ResumeLayout(false);
            this.PANCOMMERCE.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel PANCOMMERCE;
        private System.Windows.Forms.Panel panelchild;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}