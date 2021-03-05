﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Time_table_Management_System
{

    public partial class Advanced : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );


        public Advanced()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            panel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(10, 10, Width, Height, 40, 40));
        }






        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //dashboard panel main
        }


        private void label1_Click(object sender, EventArgs e)
        {
            //label home
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            //form
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //picturebox panel
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            //panel dashboard
        }










        //--------------Header icons------------------//
        private void btn_home_header(object sender, EventArgs e)
        {

        }

        private void btn_sessions_header(object sender, EventArgs e)
        {

        }

        private void btn_rooms_header(object sender, EventArgs e)
        {

        }

        private void btn_advanced_header(object sender, EventArgs e)
        {

            Advanced f2 = new Advanced();
            f2.Show();
        }

        private void btn_genarate_header(object sender, EventArgs e)
        {

        }









        //------------------Slide navbar icons....................//
        private void btn_days_nav(object sender, EventArgs e)
        {

        }

        private void btn_lectures_nav(object sender, EventArgs e)
        {

        }

        private void btn_subjects_nav(object sender, EventArgs e)
        {

        }

        private void btn_students_nav(object sender, EventArgs e)
        {

        }

        private void btn_tags_nav(object sender, EventArgs e)
        {

        }

        private void btn_locations_nav(object sender, EventArgs e)
        {

        }

        private void btn_statics_nav(object sender, EventArgs e)
        {

        }





        //------------closed,minimized,maximized,buttons---------------//

        private void button14_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;


        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }











        //consective sessions ---Advanced-----//


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //consective sessions
        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //consective sessions
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //consective sessions
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //consective sessions
        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {
            //consective sessions
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            //consective sessions
        }

        private void metroComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //consective sessions
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //consective sessions
        }


        private void label2_Click(object sender, EventArgs e)
        {
            //consective sessions ---label
        }








        //Parellel Sessions ---Advancedd---//

        private void metroComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Parellel Sessions
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Parellel Sessions
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //Parellel Sessions
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //Parellel Sessions
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //Parellel Sessions
        }

        private void metroComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Parellel Sessions
        }

        private void metroComboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Parellel Sessions
        }

        private void metroComboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Parellel Sessions
        }

        private void metroComboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Parellel Sessions

        }

        private void metroComboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Parellel Sessions

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //Parellel Sessions

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            //Parellel Sessions

        }
        private void button17_Click(object sender, EventArgs e)
        {
            //Parellel Sessions
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //Parellel Sessions

        }













        // not overlap Sessions---Advanced//
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
             // not overlap Sessions-
        }

        private void metroComboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            // not overlap Sessions-
        }

        private void metroComboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            // not overlap Sessions-
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            // not overlap Sessions-
        }

        private void metroComboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {

            // not overlap Sessions-

        }

        private void metroComboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            // not overlap Sessions-
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            // not overlap Sessions-
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            // not overlap Sessions-
        }

        private void metroComboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            // not overlap Sessions-
        }

        private void metroComboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            // not overlap Sessions-
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            // not overlap Sessions-
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            // not overlap Sessions-
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            // not overlap Sessions-
        }

     
    }
}
