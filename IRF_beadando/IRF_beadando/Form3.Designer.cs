namespace IRF_beadando
{
    partial class Form3
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
            this.buttonMentes = new System.Windows.Forms.Button();
            this.dataGridViewEredmeny = new System.Windows.Forms.DataGridView();
            this.eREDMENYIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sFELHNEVFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDZOFELHNEVFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pONTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edzoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sportoloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eredmenyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxSFelhnev = new System.Windows.Forms.TextBox();
            this.textBoxFelhnev = new System.Windows.Forms.TextBox();
            this.textBoxDatum = new System.Windows.Forms.TextBox();
            this.textBoxPont = new System.Windows.Forms.TextBox();
            this.labelSFelhnev = new System.Windows.Forms.Label();
            this.labelFelhnev = new System.Windows.Forms.Label();
            this.labelDatum = new System.Windows.Forms.Label();
            this.labelPont = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEredmeny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eredmenyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonMentes
            // 
            this.buttonMentes.Location = new System.Drawing.Point(32, 358);
            this.buttonMentes.Name = "buttonMentes";
            this.buttonMentes.Size = new System.Drawing.Size(156, 43);
            this.buttonMentes.TabIndex = 3;
            this.buttonMentes.Text = "Eredmények mentése";
            this.buttonMentes.UseVisualStyleBackColor = true;
            this.buttonMentes.Click += new System.EventHandler(this.ButtonMentes_Click);
            // 
            // dataGridViewEredmeny
            // 
            this.dataGridViewEredmeny.AutoGenerateColumns = false;
            this.dataGridViewEredmeny.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEredmeny.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eREDMENYIDDataGridViewTextBoxColumn,
            this.sFELHNEVFKDataGridViewTextBoxColumn,
            this.eDZOFELHNEVFKDataGridViewTextBoxColumn,
            this.dATUMDataGridViewTextBoxColumn,
            this.pONTDataGridViewTextBoxColumn,
            this.edzoDataGridViewTextBoxColumn,
            this.sportoloDataGridViewTextBoxColumn});
            this.dataGridViewEredmeny.DataSource = this.eredmenyBindingSource;
            this.dataGridViewEredmeny.Location = new System.Drawing.Point(429, 53);
            this.dataGridViewEredmeny.Name = "dataGridViewEredmeny";
            this.dataGridViewEredmeny.RowHeadersWidth = 51;
            this.dataGridViewEredmeny.RowTemplate.Height = 24;
            this.dataGridViewEredmeny.Size = new System.Drawing.Size(983, 150);
            this.dataGridViewEredmeny.TabIndex = 4;
            // 
            // eREDMENYIDDataGridViewTextBoxColumn
            // 
            this.eREDMENYIDDataGridViewTextBoxColumn.DataPropertyName = "EREDMENY_ID";
            this.eREDMENYIDDataGridViewTextBoxColumn.HeaderText = "EREDMENY_ID";
            this.eREDMENYIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eREDMENYIDDataGridViewTextBoxColumn.Name = "eREDMENYIDDataGridViewTextBoxColumn";
            this.eREDMENYIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // sFELHNEVFKDataGridViewTextBoxColumn
            // 
            this.sFELHNEVFKDataGridViewTextBoxColumn.DataPropertyName = "SFELH_NEV_FK";
            this.sFELHNEVFKDataGridViewTextBoxColumn.HeaderText = "SFELH_NEV_FK";
            this.sFELHNEVFKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sFELHNEVFKDataGridViewTextBoxColumn.Name = "sFELHNEVFKDataGridViewTextBoxColumn";
            this.sFELHNEVFKDataGridViewTextBoxColumn.Width = 125;
            // 
            // eDZOFELHNEVFKDataGridViewTextBoxColumn
            // 
            this.eDZOFELHNEVFKDataGridViewTextBoxColumn.DataPropertyName = "EDZO_FELH_NEV_FK";
            this.eDZOFELHNEVFKDataGridViewTextBoxColumn.HeaderText = "EDZO_FELH_NEV_FK";
            this.eDZOFELHNEVFKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eDZOFELHNEVFKDataGridViewTextBoxColumn.Name = "eDZOFELHNEVFKDataGridViewTextBoxColumn";
            this.eDZOFELHNEVFKDataGridViewTextBoxColumn.Width = 125;
            // 
            // dATUMDataGridViewTextBoxColumn
            // 
            this.dATUMDataGridViewTextBoxColumn.DataPropertyName = "DATUM";
            this.dATUMDataGridViewTextBoxColumn.HeaderText = "DATUM";
            this.dATUMDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dATUMDataGridViewTextBoxColumn.Name = "dATUMDataGridViewTextBoxColumn";
            this.dATUMDataGridViewTextBoxColumn.Width = 125;
            // 
            // pONTDataGridViewTextBoxColumn
            // 
            this.pONTDataGridViewTextBoxColumn.DataPropertyName = "PONT";
            this.pONTDataGridViewTextBoxColumn.HeaderText = "PONT";
            this.pONTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pONTDataGridViewTextBoxColumn.Name = "pONTDataGridViewTextBoxColumn";
            this.pONTDataGridViewTextBoxColumn.Width = 125;
            // 
            // edzoDataGridViewTextBoxColumn
            // 
            this.edzoDataGridViewTextBoxColumn.DataPropertyName = "Edzo";
            this.edzoDataGridViewTextBoxColumn.HeaderText = "Edzo";
            this.edzoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.edzoDataGridViewTextBoxColumn.Name = "edzoDataGridViewTextBoxColumn";
            this.edzoDataGridViewTextBoxColumn.Width = 125;
            // 
            // sportoloDataGridViewTextBoxColumn
            // 
            this.sportoloDataGridViewTextBoxColumn.DataPropertyName = "Sportolo";
            this.sportoloDataGridViewTextBoxColumn.HeaderText = "Sportolo";
            this.sportoloDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sportoloDataGridViewTextBoxColumn.Name = "sportoloDataGridViewTextBoxColumn";
            this.sportoloDataGridViewTextBoxColumn.Width = 125;
            // 
            // eredmenyBindingSource
            // 
            this.eredmenyBindingSource.DataSource = typeof(IRF_beadando.Eredmeny);
            // 
            // textBoxSFelhnev
            // 
            this.textBoxSFelhnev.Location = new System.Drawing.Point(182, 53);
            this.textBoxSFelhnev.Name = "textBoxSFelhnev";
            this.textBoxSFelhnev.Size = new System.Drawing.Size(192, 22);
            this.textBoxSFelhnev.TabIndex = 5;
            // 
            // textBoxFelhnev
            // 
            this.textBoxFelhnev.Location = new System.Drawing.Point(182, 104);
            this.textBoxFelhnev.Name = "textBoxFelhnev";
            this.textBoxFelhnev.Size = new System.Drawing.Size(192, 22);
            this.textBoxFelhnev.TabIndex = 6;
            // 
            // textBoxDatum
            // 
            this.textBoxDatum.Location = new System.Drawing.Point(182, 161);
            this.textBoxDatum.Name = "textBoxDatum";
            this.textBoxDatum.Size = new System.Drawing.Size(192, 22);
            this.textBoxDatum.TabIndex = 7;
            // 
            // textBoxPont
            // 
            this.textBoxPont.Location = new System.Drawing.Point(182, 223);
            this.textBoxPont.Name = "textBoxPont";
            this.textBoxPont.Size = new System.Drawing.Size(192, 22);
            this.textBoxPont.TabIndex = 8;
            // 
            // labelSFelhnev
            // 
            this.labelSFelhnev.AutoSize = true;
            this.labelSFelhnev.Location = new System.Drawing.Point(8, 53);
            this.labelSFelhnev.Name = "labelSFelhnev";
            this.labelSFelhnev.Size = new System.Drawing.Size(168, 17);
            this.labelSFelhnev.TabIndex = 9;
            this.labelSFelhnev.Text = "Sportoló felhasználóneve";
            // 
            // labelFelhnev
            // 
            this.labelFelhnev.AutoSize = true;
            this.labelFelhnev.Location = new System.Drawing.Point(8, 104);
            this.labelFelhnev.Name = "labelFelhnev";
            this.labelFelhnev.Size = new System.Drawing.Size(147, 17);
            this.labelFelhnev.TabIndex = 10;
            this.labelFelhnev.Text = "Edző felhasználóneve";
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.Location = new System.Drawing.Point(8, 161);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(98, 17);
            this.labelDatum.TabIndex = 11;
            this.labelDatum.Text = "Edzés dátuma";
            // 
            // labelPont
            // 
            this.labelPont.AutoSize = true;
            this.labelPont.Location = new System.Drawing.Point(8, 223);
            this.labelPont.Name = "labelPont";
            this.labelPont.Size = new System.Drawing.Size(102, 17);
            this.labelPont.TabIndex = 12;
            this.labelPont.Text = "Elért pontszám";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 450);
            this.Controls.Add(this.labelPont);
            this.Controls.Add(this.labelDatum);
            this.Controls.Add(this.labelFelhnev);
            this.Controls.Add(this.labelSFelhnev);
            this.Controls.Add(this.textBoxPont);
            this.Controls.Add(this.textBoxDatum);
            this.Controls.Add(this.textBoxFelhnev);
            this.Controls.Add(this.textBoxSFelhnev);
            this.Controls.Add(this.dataGridViewEredmeny);
            this.Controls.Add(this.buttonMentes);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEredmeny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eredmenyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonMentes;
        private System.Windows.Forms.DataGridView dataGridViewEredmeny;
        private System.Windows.Forms.TextBox textBoxSFelhnev;
        private System.Windows.Forms.TextBox textBoxFelhnev;
        private System.Windows.Forms.TextBox textBoxDatum;
        private System.Windows.Forms.TextBox textBoxPont;
        private System.Windows.Forms.Label labelSFelhnev;
        private System.Windows.Forms.Label labelFelhnev;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.Label labelPont;
        private System.Windows.Forms.DataGridViewTextBoxColumn eREDMENYIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sFELHNEVFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eDZOFELHNEVFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pONTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edzoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sportoloDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource eredmenyBindingSource;
    }
}