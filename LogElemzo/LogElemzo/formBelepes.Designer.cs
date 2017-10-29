namespace LogElemzo
{
    partial class formBelepes
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
            this.txtNev = new System.Windows.Forms.TextBox();
            this.txtJelszo = new System.Windows.Forms.TextBox();
            this.btnBelep = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKilep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNev
            // 
            this.txtNev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNev.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNev.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNev.Location = new System.Drawing.Point(12, 89);
            this.txtNev.Multiline = true;
            this.txtNev.Name = "txtNev";
            this.txtNev.Size = new System.Drawing.Size(235, 28);
            this.txtNev.TabIndex = 0;
            this.txtNev.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNev.Click += new System.EventHandler(this.txtNev_Click);
            this.txtNev.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtNev_PreviewKeyDown);
            // 
            // txtJelszo
            // 
            this.txtJelszo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtJelszo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtJelszo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtJelszo.Location = new System.Drawing.Point(12, 129);
            this.txtJelszo.Multiline = true;
            this.txtJelszo.Name = "txtJelszo";
            this.txtJelszo.Size = new System.Drawing.Size(235, 28);
            this.txtJelszo.TabIndex = 1;
            this.txtJelszo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtJelszo.Click += new System.EventHandler(this.txtJelszo_Click);
            this.txtJelszo.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtJelszo_PreviewKeyDown);
            // 
            // btnBelep
            // 
            this.btnBelep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBelep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBelep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBelep.Location = new System.Drawing.Point(12, 174);
            this.btnBelep.Name = "btnBelep";
            this.btnBelep.Size = new System.Drawing.Size(235, 28);
            this.btnBelep.TabIndex = 2;
            this.btnBelep.Text = "BELÉPÉS";
            this.btnBelep.UseVisualStyleBackColor = false;
            this.btnBelep.Click += new System.EventHandler(this.btnBelep_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Teal;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 57);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(32, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "BEJELENTKEZÉS";
            // 
            // btnKilep
            // 
            this.btnKilep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnKilep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKilep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKilep.Location = new System.Drawing.Point(12, 211);
            this.btnKilep.Name = "btnKilep";
            this.btnKilep.Size = new System.Drawing.Size(235, 28);
            this.btnKilep.TabIndex = 5;
            this.btnKilep.Text = "KILÉPÉS";
            this.btnKilep.UseVisualStyleBackColor = false;
            this.btnKilep.Click += new System.EventHandler(this.btnKilep_Click);
            // 
            // formBelepes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(259, 251);
            this.Controls.Add(this.btnKilep);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnBelep);
            this.Controls.Add(this.txtJelszo);
            this.Controls.Add(this.txtNev);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formBelepes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Belépés";
            this.Load += new System.EventHandler(this.formBelepes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNev;
        private System.Windows.Forms.TextBox txtJelszo;
        private System.Windows.Forms.Button btnBelep;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKilep;
    }
}