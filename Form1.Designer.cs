namespace WindowsFormsApp2
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
            this.rbRed = new System.Windows.Forms.RadioButton();
            this.rbGreen = new System.Windows.Forms.RadioButton();
            this.rbBlue = new System.Windows.Forms.RadioButton();
            this.gpColor = new System.Windows.Forms.GroupBox();
            this.laColor = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtpDateStart = new System.Windows.Forms.DateTimePicker();
            this.dtpDateEnd = new System.Windows.Forms.DateTimePicker();
            this.btnTotalDays = new System.Windows.Forms.Button();
            this.totalDaysBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.endTimeee = new System.Windows.Forms.DateTimePicker();
            this.labelTime = new System.Windows.Forms.TextBox();
            this.btntotalTime = new System.Windows.Forms.Button();
            this.startTimeee = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gpColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbRed
            // 
            this.rbRed.AutoSize = true;
            this.rbRed.Location = new System.Drawing.Point(27, 31);
            this.rbRed.Name = "rbRed";
            this.rbRed.Size = new System.Drawing.Size(69, 29);
            this.rbRed.TabIndex = 0;
            this.rbRed.TabStop = true;
            this.rbRed.Text = "Red";
            this.rbRed.UseVisualStyleBackColor = true;
            this.rbRed.CheckedChanged += new System.EventHandler(this.rbRed_CheckedChanged);
            // 
            // rbGreen
            // 
            this.rbGreen.AutoSize = true;
            this.rbGreen.Location = new System.Drawing.Point(27, 66);
            this.rbGreen.Name = "rbGreen";
            this.rbGreen.Size = new System.Drawing.Size(89, 29);
            this.rbGreen.TabIndex = 1;
            this.rbGreen.TabStop = true;
            this.rbGreen.Text = "Green";
            this.rbGreen.UseVisualStyleBackColor = true;
            this.rbGreen.CheckedChanged += new System.EventHandler(this.rbGreen_CheckedChanged);
            // 
            // rbBlue
            // 
            this.rbBlue.AutoSize = true;
            this.rbBlue.Location = new System.Drawing.Point(27, 101);
            this.rbBlue.Name = "rbBlue";
            this.rbBlue.Size = new System.Drawing.Size(73, 29);
            this.rbBlue.TabIndex = 2;
            this.rbBlue.TabStop = true;
            this.rbBlue.Text = "Blue";
            this.rbBlue.UseVisualStyleBackColor = true;
            this.rbBlue.CheckedChanged += new System.EventHandler(this.rbBlue_CheckedChanged);
            // 
            // gpColor
            // 
            this.gpColor.Controls.Add(this.rbBlue);
            this.gpColor.Controls.Add(this.rbGreen);
            this.gpColor.Controls.Add(this.rbRed);
            this.gpColor.Location = new System.Drawing.Point(2, 12);
            this.gpColor.Name = "gpColor";
            this.gpColor.Size = new System.Drawing.Size(125, 144);
            this.gpColor.TabIndex = 3;
            this.gpColor.TabStop = false;
            this.gpColor.Text = "Color";
            // 
            // laColor
            // 
            this.laColor.Location = new System.Drawing.Point(7, 159);
            this.laColor.Name = "laColor";
            this.laColor.Size = new System.Drawing.Size(359, 77);
            this.laColor.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Kucing",
            "Burung"});
            this.comboBox1.Location = new System.Drawing.Point(401, 246);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(369, 33);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(401, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // dtpDateStart
            // 
            this.dtpDateStart.Location = new System.Drawing.Point(2, 310);
            this.dtpDateStart.Name = "dtpDateStart";
            this.dtpDateStart.Size = new System.Drawing.Size(367, 31);
            this.dtpDateStart.TabIndex = 7;
            // 
            // dtpDateEnd
            // 
            this.dtpDateEnd.Location = new System.Drawing.Point(417, 310);
            this.dtpDateEnd.Name = "dtpDateEnd";
            this.dtpDateEnd.Size = new System.Drawing.Size(367, 31);
            this.dtpDateEnd.TabIndex = 8;
            // 
            // btnTotalDays
            // 
            this.btnTotalDays.Location = new System.Drawing.Point(824, 262);
            this.btnTotalDays.Name = "btnTotalDays";
            this.btnTotalDays.Size = new System.Drawing.Size(156, 42);
            this.btnTotalDays.TabIndex = 9;
            this.btnTotalDays.Text = "Total Days";
            this.btnTotalDays.UseVisualStyleBackColor = true;
            this.btnTotalDays.Click += new System.EventHandler(this.btnTotalDays_Click);
            // 
            // totalDaysBox
            // 
            this.totalDaysBox.Location = new System.Drawing.Point(824, 310);
            this.totalDaysBox.Name = "totalDaysBox";
            this.totalDaysBox.Size = new System.Drawing.Size(195, 31);
            this.totalDaysBox.TabIndex = 10;
            this.totalDaysBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Date Start";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Date End";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Time Start";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(412, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Time End";
            // 
            // endTimeee
            // 
            this.endTimeee.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.endTimeee.Location = new System.Drawing.Point(413, 421);
            this.endTimeee.Name = "endTimeee";
            this.endTimeee.Size = new System.Drawing.Size(357, 31);
            this.endTimeee.TabIndex = 17;
            // 
            // labelTime
            // 
            this.labelTime.Location = new System.Drawing.Point(824, 421);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(195, 31);
            this.labelTime.TabIndex = 18;
            this.labelTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.labelTime.TextChanged += new System.EventHandler(this.labelTime_TextChanged);
            // 
            // btntotalTime
            // 
            this.btntotalTime.Location = new System.Drawing.Point(824, 373);
            this.btntotalTime.Name = "btntotalTime";
            this.btntotalTime.Size = new System.Drawing.Size(156, 42);
            this.btntotalTime.TabIndex = 19;
            this.btntotalTime.Text = "Total Time";
            this.btntotalTime.UseVisualStyleBackColor = true;
            this.btntotalTime.Click += new System.EventHandler(this.totalTime_Click);
            // 
            // startTimeee
            // 
            this.startTimeee.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startTimeee.Location = new System.Drawing.Point(2, 421);
            this.startTimeee.Name = "startTimeee";
            this.startTimeee.Size = new System.Drawing.Size(364, 31);
            this.startTimeee.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 39);
            this.button1.TabIndex = 21;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(882, 34);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(137, 29);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(992, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "C#";
            this.label5.Visible = false;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 504);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.startTimeee);
            this.Controls.Add(this.btntotalTime);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.endTimeee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalDaysBox);
            this.Controls.Add(this.btnTotalDays);
            this.Controls.Add(this.dtpDateEnd);
            this.Controls.Add(this.dtpDateStart);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.laColor);
            this.Controls.Add(this.gpColor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Lab2 GUI Control_1";
            this.gpColor.ResumeLayout(false);
            this.gpColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbRed;
        private System.Windows.Forms.RadioButton rbGreen;
        private System.Windows.Forms.RadioButton rbBlue;
        private System.Windows.Forms.GroupBox gpColor;
        private System.Windows.Forms.Label laColor;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtpDateStart;
        private System.Windows.Forms.DateTimePicker dtpDateEnd;
        private System.Windows.Forms.Button btnTotalDays;
        private System.Windows.Forms.TextBox totalDaysBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker endTimeee;
        private System.Windows.Forms.TextBox labelTime;
        private System.Windows.Forms.Button btntotalTime;
        private System.Windows.Forms.DateTimePicker startTimeee;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label5;
    }
}

