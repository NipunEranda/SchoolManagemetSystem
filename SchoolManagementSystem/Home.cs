﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class Home : mainWindows
    {

        MainClass main = new MainClass();

        public Home()
        {
            InitializeComponent();
        }

        private void stdBtn_Click(object sender, EventArgs e)
        {
            Students students = new Students();
            main.showWindow(students, this, MDI.ActiveForm);
        }

        private void staffBtn_Click(object sender, EventArgs e)
        {

        }

        private void classesBtn_Click(object sender, EventArgs e)
        {

        }

        private void coursesBtn_Click(object sender, EventArgs e)
        {

        }

        private void libraryBtn_Click(object sender, EventArgs e)
        {

        }

        private void eventsBtn_Click(object sender, EventArgs e)
        {

        }

        private void paymentsBtn_Click(object sender, EventArgs e)
        {

        }

        private void timeTablesBtn_Click(object sender, EventArgs e)
        {

        }

        private void examBtn_Click(object sender, EventArgs e)
        {

        }

        private void inventoryBtn_Click(object sender, EventArgs e)
        {

        }
    }
}