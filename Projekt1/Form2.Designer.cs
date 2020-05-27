namespace Projekt1 {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.sliderHours = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelDataNow = new System.Windows.Forms.Label();
            this.labelTimeIn = new System.Windows.Forms.Label();
            this.buttonGo = new System.Windows.Forms.Button();
            this.eventlog = new System.Windows.Forms.ListView();
            this.label13 = new System.Windows.Forms.Label();
            this.Log = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderHours)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imię:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwisko:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pozycja Y:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Pozycja X:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.labelY);
            this.groupBox1.Controls.Add(this.labelSurname);
            this.groupBox1.Controls.Add(this.labelX);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacje o użytkowniku";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(83, 14);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "label5";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(83, 74);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(35, 13);
            this.labelY.TabIndex = 7;
            this.labelY.Text = "label6";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(83, 34);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(35, 13);
            this.labelSurname.TabIndex = 5;
            this.labelSurname.Text = "label7";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(83, 54);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(35, 13);
            this.labelX.TabIndex = 6;
            this.labelX.Text = "label8";
            // 
            // sliderHours
            // 
            this.sliderHours.Location = new System.Drawing.Point(49, 232);
            this.sliderHours.Maximum = 9;
            this.sliderHours.Minimum = 1;
            this.sliderHours.Name = "sliderHours";
            this.sliderHours.Size = new System.Drawing.Size(104, 45);
            this.sliderHours.TabIndex = 5;
            this.sliderHours.Value = 1;
            this.sliderHours.Scroll += new System.EventHandler(this.sliderHours_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Data";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Sprawdź warunki za:";
            // 
            // labelDataNow
            // 
            this.labelDataNow.AutoSize = true;
            this.labelDataNow.Location = new System.Drawing.Point(95, 163);
            this.labelDataNow.Name = "labelDataNow";
            this.labelDataNow.Size = new System.Drawing.Size(91, 13);
            this.labelDataNow.TabIndex = 8;
            this.labelDataNow.Text = "2019-12-31 23:00";
            this.labelDataNow.Click += new System.EventHandler(this.labelDataNow_Click);
            // 
            // labelTimeIn
            // 
            this.labelTimeIn.AutoSize = true;
            this.labelTimeIn.Location = new System.Drawing.Point(112, 197);
            this.labelTimeIn.Name = "labelTimeIn";
            this.labelTimeIn.Size = new System.Drawing.Size(13, 13);
            this.labelTimeIn.TabIndex = 9;
            this.labelTimeIn.Text = "5";
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(49, 274);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonGo.Size = new System.Drawing.Size(104, 47);
            this.buttonGo.TabIndex = 10;
            this.buttonGo.Text = "Sprawdź";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // eventlog
            // 
            this.eventlog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Log});
            this.eventlog.HideSelection = false;
            this.eventlog.Location = new System.Drawing.Point(218, 12);
            this.eventlog.Name = "eventlog";
            this.eventlog.Size = new System.Drawing.Size(570, 426);
            this.eventlog.TabIndex = 11;
            this.eventlog.UseCompatibleStateImageBehavior = false;
            this.eventlog.View = System.Windows.Forms.View.Details;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(123, 197);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "godzin.";
            // 
            // Log
            // 
            this.Log.Text = "Log:";
            this.Log.Width = 617;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.eventlog);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.labelTimeIn);
            this.Controls.Add(this.labelDataNow);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.sliderHours);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.TrackBar sliderHours;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelDataNow;
        private System.Windows.Forms.Label labelTimeIn;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.ListView eventlog;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ColumnHeader Log;
    }
}