﻿namespace IRF_beadando
{
    partial class Form2
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
            this.textBoxFelhnev = new System.Windows.Forms.TextBox();
            this.textBoxJelszo = new System.Windows.Forms.TextBox();
            this.buttonBelep = new System.Windows.Forms.Button();
            this.labelFelhnev = new System.Windows.Forms.Label();
            this.labelJelszo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxFelhnev
            // 
            this.textBoxFelhnev.BackColor = System.Drawing.Color.SeaShell;
            this.textBoxFelhnev.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxFelhnev.ForeColor = System.Drawing.Color.Black;
            this.textBoxFelhnev.Location = new System.Drawing.Point(93, 63);
            this.textBoxFelhnev.Name = "textBoxFelhnev";
            this.textBoxFelhnev.Size = new System.Drawing.Size(186, 26);
            this.textBoxFelhnev.TabIndex = 0;
            // 
            // textBoxJelszo
            // 
            this.textBoxJelszo.BackColor = System.Drawing.Color.SeaShell;
            this.textBoxJelszo.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxJelszo.ForeColor = System.Drawing.Color.Black;
            this.textBoxJelszo.Location = new System.Drawing.Point(93, 133);
            this.textBoxJelszo.Name = "textBoxJelszo";
            this.textBoxJelszo.Size = new System.Drawing.Size(186, 26);
            this.textBoxJelszo.TabIndex = 1;
            // 
            // buttonBelep
            // 
            this.buttonBelep.BackColor = System.Drawing.Color.Maroon;
            this.buttonBelep.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBelep.ForeColor = System.Drawing.Color.Bisque;
            this.buttonBelep.Location = new System.Drawing.Point(350, 128);
            this.buttonBelep.Name = "buttonBelep";
            this.buttonBelep.Size = new System.Drawing.Size(95, 32);
            this.buttonBelep.TabIndex = 2;
            this.buttonBelep.Text = "Belépés";
            this.buttonBelep.UseVisualStyleBackColor = false;
            this.buttonBelep.Click += new System.EventHandler(this.ButtonBelep_Click);
            // 
            // labelFelhnev
            // 
            this.labelFelhnev.AutoSize = true;
            this.labelFelhnev.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFelhnev.ForeColor = System.Drawing.Color.Maroon;
            this.labelFelhnev.Location = new System.Drawing.Point(92, 38);
            this.labelFelhnev.Name = "labelFelhnev";
            this.labelFelhnev.Size = new System.Drawing.Size(148, 23);
            this.labelFelhnev.TabIndex = 3;
            this.labelFelhnev.Text = "Felhasználónév";
            // 
            // labelJelszo
            // 
            this.labelJelszo.AutoSize = true;
            this.labelJelszo.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJelszo.ForeColor = System.Drawing.Color.Maroon;
            this.labelJelszo.Location = new System.Drawing.Point(92, 107);
            this.labelJelszo.Name = "labelJelszo";
            this.labelJelszo.Size = new System.Drawing.Size(63, 23);
            this.labelJelszo.TabIndex = 4;
            this.labelJelszo.Text = "Jelszó";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(499, 233);
            this.Controls.Add(this.labelJelszo);
            this.Controls.Add(this.labelFelhnev);
            this.Controls.Add(this.buttonBelep);
            this.Controls.Add(this.textBoxJelszo);
            this.Controls.Add(this.textBoxFelhnev);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFelhnev;
        private System.Windows.Forms.TextBox textBoxJelszo;
        private System.Windows.Forms.Button buttonBelep;
        private System.Windows.Forms.Label labelFelhnev;
        private System.Windows.Forms.Label labelJelszo;
    }
}