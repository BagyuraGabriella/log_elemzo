namespace LogElemzo
{
    partial class formBeolvas
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
            this.openFileDialogExcel = new System.Windows.Forms.OpenFileDialog();
            this.btnMegnyit = new System.Windows.Forms.Button();
            this.dgvLOG = new System.Windows.Forms.DataGridView();
            this.btnBezar = new System.Windows.Forms.Button();
            this.btnTovabb = new System.Windows.Forms.Button();
            this.cboxModszer = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLOG)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialogExcel
            // 
            this.openFileDialogExcel.FileName = "openFileDialogExcel";
            // 
            // btnMegnyit
            // 
            this.btnMegnyit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMegnyit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMegnyit.ForeColor = System.Drawing.Color.Black;
            this.btnMegnyit.Location = new System.Drawing.Point(12, 27);
            this.btnMegnyit.Name = "btnMegnyit";
            this.btnMegnyit.Size = new System.Drawing.Size(188, 28);
            this.btnMegnyit.TabIndex = 0;
            this.btnMegnyit.Text = "Fájl megnyitása";
            this.btnMegnyit.UseVisualStyleBackColor = false;
            this.btnMegnyit.Click += new System.EventHandler(this.btnMegnyit_Click);
            // 
            // dgvLOG
            // 
            this.dgvLOG.BackgroundColor = System.Drawing.Color.White;
            this.dgvLOG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLOG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLOG.Location = new System.Drawing.Point(13, 73);
            this.dgvLOG.Name = "dgvLOG";
            this.dgvLOG.Size = new System.Drawing.Size(816, 302);
            this.dgvLOG.TabIndex = 1;
            // 
            // btnBezar
            // 
            this.btnBezar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBezar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBezar.ForeColor = System.Drawing.Color.Black;
            this.btnBezar.Location = new System.Drawing.Point(746, 381);
            this.btnBezar.Name = "btnBezar";
            this.btnBezar.Size = new System.Drawing.Size(82, 28);
            this.btnBezar.TabIndex = 2;
            this.btnBezar.Text = "Bezárás";
            this.btnBezar.UseVisualStyleBackColor = false;
            this.btnBezar.Click += new System.EventHandler(this.btnBezar_Click);
            // 
            // btnTovabb
            // 
            this.btnTovabb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTovabb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTovabb.ForeColor = System.Drawing.Color.Black;
            this.btnTovabb.Location = new System.Drawing.Point(656, 381);
            this.btnTovabb.Name = "btnTovabb";
            this.btnTovabb.Size = new System.Drawing.Size(82, 28);
            this.btnTovabb.TabIndex = 3;
            this.btnTovabb.Text = "Tovább >>";
            this.btnTovabb.UseVisualStyleBackColor = false;
            this.btnTovabb.Click += new System.EventHandler(this.btnTovabb_Click);
            // 
            // cboxModszer
            // 
            this.cboxModszer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxModszer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboxModszer.FormattingEnabled = true;
            this.cboxModszer.Location = new System.Drawing.Point(220, 32);
            this.cboxModszer.Name = "cboxModszer";
            this.cboxModszer.Size = new System.Drawing.Size(279, 21);
            this.cboxModszer.TabIndex = 4;
            this.cboxModszer.SelectedIndexChanged += new System.EventHandler(this.cboxModszer_SelectedIndexChanged);
            // 
            // formBeolvas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 421);
            this.Controls.Add(this.cboxModszer);
            this.Controls.Add(this.btnTovabb);
            this.Controls.Add(this.btnBezar);
            this.Controls.Add(this.dgvLOG);
            this.Controls.Add(this.btnMegnyit);
            this.Name = "formBeolvas";
            this.Text = "formBeolvas";
            this.Load += new System.EventHandler(this.formBeolvas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLOG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialogExcel;
        private System.Windows.Forms.Button btnMegnyit;
        private System.Windows.Forms.DataGridView dgvLOG;
        private System.Windows.Forms.Button btnBezar;
        private System.Windows.Forms.Button btnTovabb;
        private System.Windows.Forms.ComboBox cboxModszer;
    }
}