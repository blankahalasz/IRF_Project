namespace IRF_beadando
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.listBoxEdzok = new System.Windows.Forms.ListBox();
            this.listBoxSportolok = new System.Windows.Forms.ListBox();
            this.chartEredmenyek = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelEdzok = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonUjEredemeny = new System.Windows.Forms.Button();
            this.textBoxEdzok = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartEredmenyek)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxEdzok
            // 
            this.listBoxEdzok.FormattingEnabled = true;
            this.listBoxEdzok.ItemHeight = 16;
            this.listBoxEdzok.Location = new System.Drawing.Point(38, 128);
            this.listBoxEdzok.Name = "listBoxEdzok";
            this.listBoxEdzok.Size = new System.Drawing.Size(214, 84);
            this.listBoxEdzok.TabIndex = 0;
            this.listBoxEdzok.SelectedIndexChanged += new System.EventHandler(this.ListBoxEdzok_SelectedIndexChanged);
            // 
            // listBoxSportolok
            // 
            this.listBoxSportolok.FormattingEnabled = true;
            this.listBoxSportolok.ItemHeight = 16;
            this.listBoxSportolok.Location = new System.Drawing.Point(326, 84);
            this.listBoxSportolok.Name = "listBoxSportolok";
            this.listBoxSportolok.Size = new System.Drawing.Size(167, 84);
            this.listBoxSportolok.TabIndex = 1;
            // 
            // chartEredmenyek
            // 
            chartArea1.Name = "ChartArea1";
            this.chartEredmenyek.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartEredmenyek.Legends.Add(legend1);
            this.chartEredmenyek.Location = new System.Drawing.Point(517, 52);
            this.chartEredmenyek.Name = "chartEredmenyek";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartEredmenyek.Series.Add(series1);
            this.chartEredmenyek.Size = new System.Drawing.Size(396, 387);
            this.chartEredmenyek.TabIndex = 2;
            this.chartEredmenyek.Text = "chart1";
            // 
            // labelEdzok
            // 
            this.labelEdzok.AutoSize = true;
            this.labelEdzok.Location = new System.Drawing.Point(35, 52);
            this.labelEdzok.Name = "labelEdzok";
            this.labelEdzok.Size = new System.Drawing.Size(140, 17);
            this.labelEdzok.TabIndex = 3;
            this.labelEdzok.Text = "Válassza ki az edzőt!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Válassza ki a sportolót!";
            // 
            // buttonUjEredemeny
            // 
            this.buttonUjEredemeny.Location = new System.Drawing.Point(38, 238);
            this.buttonUjEredemeny.Name = "buttonUjEredemeny";
            this.buttonUjEredemeny.Size = new System.Drawing.Size(175, 59);
            this.buttonUjEredemeny.TabIndex = 5;
            this.buttonUjEredemeny.Text = "Új eredmény hozzáadása";
            this.buttonUjEredemeny.UseVisualStyleBackColor = true;
            // 
            // textBoxEdzok
            // 
            this.textBoxEdzok.Location = new System.Drawing.Point(38, 84);
            this.textBoxEdzok.Name = "textBoxEdzok";
            this.textBoxEdzok.Size = new System.Drawing.Size(100, 22);
            this.textBoxEdzok.TabIndex = 6;
            this.textBoxEdzok.TextChanged += new System.EventHandler(this.TextBoxEdzok_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 527);
            this.Controls.Add(this.textBoxEdzok);
            this.Controls.Add(this.buttonUjEredemeny);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelEdzok);
            this.Controls.Add(this.chartEredmenyek);
            this.Controls.Add(this.listBoxSportolok);
            this.Controls.Add(this.listBoxEdzok);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chartEredmenyek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxEdzok;
        private System.Windows.Forms.ListBox listBoxSportolok;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEredmenyek;
        private System.Windows.Forms.Label labelEdzok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonUjEredemeny;
        private System.Windows.Forms.TextBox textBoxEdzok;
    }
}

