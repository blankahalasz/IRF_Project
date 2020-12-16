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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.listBoxEdzok = new System.Windows.Forms.ListBox();
            this.listBoxSportolok = new System.Windows.Forms.ListBox();
            this.labelEdzok = new System.Windows.Forms.Label();
            this.buttonUjEredemeny = new System.Windows.Forms.Button();
            this.textBoxEdzok = new System.Windows.Forms.TextBox();
            this.buttonChart = new System.Windows.Forms.Button();
            this.chartEredmenyek = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listBoxEredmenyek = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.labelTabla = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartEredmenyek)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxEdzok
            // 
            this.listBoxEdzok.BackColor = System.Drawing.Color.FloralWhite;
            this.listBoxEdzok.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxEdzok.ForeColor = System.Drawing.Color.SaddleBrown;
            this.listBoxEdzok.FormattingEnabled = true;
            this.listBoxEdzok.ItemHeight = 18;
            this.listBoxEdzok.Location = new System.Drawing.Point(35, 155);
            this.listBoxEdzok.Name = "listBoxEdzok";
            this.listBoxEdzok.Size = new System.Drawing.Size(157, 76);
            this.listBoxEdzok.TabIndex = 0;
            this.listBoxEdzok.SelectedIndexChanged += new System.EventHandler(this.ListBoxEdzok_SelectedIndexChanged);
            // 
            // listBoxSportolok
            // 
            this.listBoxSportolok.BackColor = System.Drawing.Color.FloralWhite;
            this.listBoxSportolok.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxSportolok.ForeColor = System.Drawing.Color.SaddleBrown;
            this.listBoxSportolok.FormattingEnabled = true;
            this.listBoxSportolok.ItemHeight = 18;
            this.listBoxSportolok.Location = new System.Drawing.Point(243, 113);
            this.listBoxSportolok.Name = "listBoxSportolok";
            this.listBoxSportolok.Size = new System.Drawing.Size(182, 76);
            this.listBoxSportolok.TabIndex = 1;
            this.listBoxSportolok.SelectedIndexChanged += new System.EventHandler(this.ListBoxSportolok_SelectedIndexChanged);
            // 
            // labelEdzok
            // 
            this.labelEdzok.AutoSize = true;
            this.labelEdzok.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEdzok.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labelEdzok.Location = new System.Drawing.Point(33, 87);
            this.labelEdzok.Name = "labelEdzok";
            this.labelEdzok.Size = new System.Drawing.Size(159, 21);
            this.labelEdzok.TabIndex = 3;
            this.labelEdzok.Text = "Válassza ki az edzőt!";
            // 
            // buttonUjEredemeny
            // 
            this.buttonUjEredemeny.BackColor = System.Drawing.Color.Tan;
            this.buttonUjEredemeny.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUjEredemeny.ForeColor = System.Drawing.Color.SeaShell;
            this.buttonUjEredemeny.Location = new System.Drawing.Point(979, 454);
            this.buttonUjEredemeny.Name = "buttonUjEredemeny";
            this.buttonUjEredemeny.Size = new System.Drawing.Size(175, 59);
            this.buttonUjEredemeny.TabIndex = 5;
            this.buttonUjEredemeny.Text = "Új eredmény hozzáadása";
            this.buttonUjEredemeny.UseVisualStyleBackColor = false;
            this.buttonUjEredemeny.Click += new System.EventHandler(this.ButtonUjEredemeny_Click);
            // 
            // textBoxEdzok
            // 
            this.textBoxEdzok.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxEdzok.Location = new System.Drawing.Point(35, 111);
            this.textBoxEdzok.Name = "textBoxEdzok";
            this.textBoxEdzok.Size = new System.Drawing.Size(154, 26);
            this.textBoxEdzok.TabIndex = 6;
            this.textBoxEdzok.TextChanged += new System.EventHandler(this.TextBoxEdzok_TextChanged);
            // 
            // buttonChart
            // 
            this.buttonChart.BackColor = System.Drawing.Color.Tan;
            this.buttonChart.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonChart.ForeColor = System.Drawing.Color.Snow;
            this.buttonChart.Location = new System.Drawing.Point(518, 224);
            this.buttonChart.Name = "buttonChart";
            this.buttonChart.Size = new System.Drawing.Size(131, 68);
            this.buttonChart.TabIndex = 7;
            this.buttonChart.Text = "Eredmények megjelenítése diagrammon";
            this.buttonChart.UseVisualStyleBackColor = false;
            this.buttonChart.Click += new System.EventHandler(this.ButtonChart_Click);
            // 
            // chartEredmenyek
            // 
            this.chartEredmenyek.BackColor = System.Drawing.Color.NavajoWhite;
            this.chartEredmenyek.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            chartArea2.Name = "ChartArea1";
            this.chartEredmenyek.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartEredmenyek.Legends.Add(legend2);
            this.chartEredmenyek.Location = new System.Drawing.Point(758, 47);
            this.chartEredmenyek.Name = "chartEredmenyek";
            series2.BackSecondaryColor = System.Drawing.Color.White;
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Maroon;
            series2.Font = new System.Drawing.Font("Constantia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            series2.LabelForeColor = System.Drawing.Color.SaddleBrown;
            series2.Legend = "Legend1";
            series2.MarkerColor = System.Drawing.Color.Maroon;
            series2.Name = "Pontok";
            this.chartEredmenyek.Series.Add(series2);
            this.chartEredmenyek.Size = new System.Drawing.Size(396, 387);
            this.chartEredmenyek.TabIndex = 2;
            this.chartEredmenyek.Text = "chart1";
            // 
            // listBoxEredmenyek
            // 
            this.listBoxEredmenyek.BackColor = System.Drawing.Color.FloralWhite;
            this.listBoxEredmenyek.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxEredmenyek.ForeColor = System.Drawing.Color.SaddleBrown;
            this.listBoxEredmenyek.FormattingEnabled = true;
            this.listBoxEredmenyek.ItemHeight = 18;
            this.listBoxEredmenyek.Location = new System.Drawing.Point(494, 113);
            this.listBoxEredmenyek.Name = "listBoxEredmenyek";
            this.listBoxEredmenyek.Size = new System.Drawing.Size(155, 58);
            this.listBoxEredmenyek.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panel1.Location = new System.Drawing.Point(27, 352);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 161);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.CreateTimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.ConveyorTimer_Tick);
            // 
            // labelTabla
            // 
            this.labelTabla.AutoSize = true;
            this.labelTabla.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.labelTabla.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTabla.ForeColor = System.Drawing.Color.Maroon;
            this.labelTabla.Location = new System.Drawing.Point(654, 329);
            this.labelTabla.Name = "labelTabla";
            this.labelTabla.Size = new System.Drawing.Size(71, 21);
            this.labelTabla.TabIndex = 10;
            this.labelTabla.Text = "Lőtábla";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(32, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(21, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 35);
            this.label3.TabIndex = 12;
            this.label3.Text = "Lövészet SE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(239, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Válassza ki az sportolót!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(490, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Pontok edzésenként";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1166, 516);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTabla);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBoxEredmenyek);
            this.Controls.Add(this.chartEredmenyek);
            this.Controls.Add(this.buttonChart);
            this.Controls.Add(this.textBoxEdzok);
            this.Controls.Add(this.buttonUjEredemeny);
            this.Controls.Add(this.labelEdzok);
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
        private System.Windows.Forms.Label labelEdzok;
        private System.Windows.Forms.Button buttonUjEredemeny;
        private System.Windows.Forms.TextBox textBoxEdzok;
        private System.Windows.Forms.Button buttonChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEredmenyek;
        private System.Windows.Forms.ListBox listBoxEredmenyek;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Label labelTabla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}

