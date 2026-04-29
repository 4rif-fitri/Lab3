using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbRed_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRed.Checked){
                //this.BackColor = Color.Red;
                laColor.BackColor = Color.Red;
            }
        }

        private void rbGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGreen.Checked)
            {
                //this.BackColor = Color.Green;
                laColor.BackColor = Color.Green;

            }
        }

        private void rbBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBlue.Checked)
            {
                //this.BackColor = Color.Blue;
                laColor.BackColor = Color.Blue;

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Kucing":
                    pictureBox1.Image = Properties.Resources.kucing;
                    break;

                case "Burung":
                    pictureBox1.Image = Properties.Resources.burung;
                    break;
            }
        }

        private void btnTotalDays_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpDateStart.Value;
            DateTime endDate = dtpDateEnd.Value;
        
            TimeSpan t = endDate - startDate;

            double dt = t.TotalDays;
            int totalDays = Convert.ToInt32(dt);

            totalDaysBox.Text = totalDays.ToString();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void totalTime_Click(object sender, EventArgs e)
        {
            DateTime startTime = startTimeee.Value;
            DateTime endTime = endTimeee.Value;
            TimeSpan t = endTime - startTime;
            double dt = t.Hours;
            int totalTime = Convert.ToInt32(dt);
            labelTime.Text = totalTime.ToString();

        }

        private void labelTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Hide();
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        //
        bool isShow = false;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked){
                label5.Show();
            }
            else
            {
                label5.Hide();
            }
        }
    }
}
