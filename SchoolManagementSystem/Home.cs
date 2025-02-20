﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace SchoolManagementSystem
{
    public partial class Home : mainWindows
    {
        private int loggedId = MainClass.ROLEID;
        MainClass main = MainClass.getInstance();
        schoolDBDataContext obj = new schoolDBDataContext();
        string url = "https://www.jmc.lk/branch/havelock-town";
        public Home()
        {
            InitializeComponent();
        }

        private void stdBtn_Click(object sender, EventArgs e)
        {
            Students students = new Students();
            MainClass.setCurrentForm(students);
            logoPanel.Visible = false;
            MainClass.showWindow(students, this, MDI.ActiveForm);
        }

        private void staffBtn_Click(object sender, EventArgs e)
        {
            MainClass.showWindow(new Staff(), this, MDI.ActiveForm);
        }

        private void classesBtn_Click(object sender, EventArgs e)
        {

        }

        private void coursesBtn_Click(object sender, EventArgs e)
        {

        }

        private void libraryBtn_Click(object sender, EventArgs e)
        {
            MainClass.showWindow(new LibraryManagementSystem(), this, MDI.ActiveForm);
        }

        private void eventsBtn_Click(object sender, EventArgs e)
        {
            Events events = new Events();
            MainClass.setCurrentForm(new Students());
            MainClass.showWindow(events, this, MDI.ActiveForm);
        }

        private void paymentsBtn_Click(object sender, EventArgs e)
        {
            MainClass.showWindow(new paymentSub_window(), this, MDI.ActiveForm);
        }

        private void timeTablesBtn_Click(object sender, EventArgs e)
        {
            MainClass.showWindow(new Timetable(), this, MDI.ActiveForm);
        }

        private void examBtn_Click(object sender, EventArgs e)
        {
            MainClass.showWindow(new Results(), this, MDI.ActiveForm);
        }

        private void inventoryBtn_Click(object sender, EventArgs e)
        {
           

        }

        private void rolesBtn_Click(object sender, EventArgs e)
        {
            Roles role = new Roles();
            MainClass.setCurrentForm(role);
            MainClass.showWindow(role, this, MDI.ActiveForm);
        }

        private void usersBtn_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            MainClass.setCurrentForm(user);
            MainClass.showWindow(user, this, MDI.ActiveForm);
        }

        private void Home_Load(object sender, EventArgs e)
        {
            setPrivilleges();
            MainClass.mdi.topic.Text = "HOME";
        }

        private void setPrivilleges() {

            var privileges = obj.privileges_HomePrivileges(loggedId);

            foreach (var item in privileges)
            {
                if (item.student == 0)
                    MainClass.disableButtons(stdBtn);

                if (item.staff == 0)
                    MainClass.disableButtons(staffBtn);

                if (item.classes == 0)
                    MainClass.disableButtons(classesBtn);

                if (item.courses == 0)
                    MainClass.disableButtons(coursesBtn);
                
                if (item.library == 0)
                    MainClass.disableButtons(libraryBtn);

                if (item.events == 0)
                    MainClass.disableButtons(eventsBtn);

                if (item.payments == 0)
                    MainClass.disableButtons(paymentsBtn);

                if (item.timetables == 0)
                    MainClass.disableButtons(timeTablesBtn);

                if (item.examinations == 0)
                    MainClass.disableButtons(examBtn);

                if (item.inventory == 0)
                    MainClass.disableButtons(inventoryBtn);

                if (item.roles == 0)
                    MainClass.disableButtons(rolesBtn);
                if (item.users == 0)
                    MainClass.disableButtons(usersBtn);

            }
        }

        private void siteLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(url);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
