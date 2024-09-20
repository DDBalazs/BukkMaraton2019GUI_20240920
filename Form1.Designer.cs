namespace BukkMaraton2019GUI_20240920
{
    partial class form
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
            this.lb1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btszamol = new System.Windows.Forms.Button();
            this.lbkm = new System.Windows.Forms.Label();
            this.lbm = new System.Windows.Forms.Label();
            this.txido = new System.Windows.Forms.TextBox();
            this.vbtav = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(27, 36);
            this.lb1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(37, 13);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "Táv: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Idő [Óra:perc:mp]: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Átlagsebesség [km/h]: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Átlagsebesség [m/s]: ";
            // 
            // btszamol
            // 
            this.btszamol.Location = new System.Drawing.Point(270, 25);
            this.btszamol.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btszamol.Name = "btszamol";
            this.btszamol.Size = new System.Drawing.Size(76, 67);
            this.btszamol.TabIndex = 4;
            this.btszamol.Text = "Számol";
            this.btszamol.UseVisualStyleBackColor = true;
            this.btszamol.Click += new System.EventHandler(this.btszamol_Click);
            // 
            // lbkm
            // 
            this.lbkm.AutoSize = true;
            this.lbkm.Location = new System.Drawing.Point(250, 127);
            this.lbkm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbkm.Name = "lbkm";
            this.lbkm.Size = new System.Drawing.Size(41, 13);
            this.lbkm.TabIndex = 5;
            this.lbkm.Text = "label4";
            // 
            // lbm
            // 
            this.lbm.AutoSize = true;
            this.lbm.Location = new System.Drawing.Point(250, 168);
            this.lbm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbm.Name = "lbm";
            this.lbm.Size = new System.Drawing.Size(41, 13);
            this.lbm.TabIndex = 6;
            this.lbm.Text = "label5";
            // 
            // txido
            // 
            this.txido.Location = new System.Drawing.Point(145, 69);
            this.txido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txido.Name = "txido";
            this.txido.Size = new System.Drawing.Size(104, 20);
            this.txido.TabIndex = 7;
            // 
            // vbtav
            // 
            this.vbtav.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vbtav.FormattingEnabled = true;
            this.vbtav.Items.AddRange(new object[] {
            "Mini - 16km",
            "Rövid - 38km",
            "Pedelec - 54km",
            "Közép - 57km",
            "Hosszú - 94km"});
            this.vbtav.Location = new System.Drawing.Point(72, 36);
            this.vbtav.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.vbtav.Name = "vbtav";
            this.vbtav.Size = new System.Drawing.Size(177, 21);
            this.vbtav.TabIndex = 8;
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 200);
            this.Controls.Add(this.vbtav);
            this.Controls.Add(this.txido);
            this.Controls.Add(this.lbm);
            this.Controls.Add(this.lbkm);
            this.Controls.Add(this.btszamol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "form";
            this.Text = "Bükk Maraton 2019";
            this.Load += new System.EventHandler(this.form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btszamol;
        private System.Windows.Forms.Label lbkm;
        private System.Windows.Forms.Label lbm;
        private System.Windows.Forms.TextBox txido;
        private System.Windows.Forms.ComboBox vbtav;
    }
}

