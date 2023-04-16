using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Nager.Date;

namespace BetterLimited
{
    public partial class Interface_ScheduleDutyList_Delivery : Form
    {
        public static Interface_ScheduleDutyList_Delivery instance;
        public Label lab1;
        public Interface_ScheduleDutyList_Delivery()
        {


            InitializeComponent();
            instance = this;
            lab1 = label2;

        }
        betterlimitedEntities_Test1 db = new betterlimitedEntities_Test1();
        MySqlConnection Conn = new MySqlConnection(@"datasource=localhost;port=3306;username=root;password=");
        void add2Time()
        {
            string command_query = "SELECT SessionTime FROM betterlimited.session";
            MySqlCommand cmd = new MySqlCommand(command_query, Conn);
            MySqlDataReader mydr;
            try
            {
                Conn.Open();
                mydr = cmd.ExecuteReader();
                while (mydr.Read())
                {
                    string subj = mydr.GetString("SessionTime");
                    cb_session.Items.Add(subj);

                }
                Conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Session Error");

            }

        }
        //cb_dworkers
        void add2DID()
        {
            string command_query = "SELECT FirstName FROM betterlimited.staff WHERE DepartmentID=11";
            MySqlCommand cmd = new MySqlCommand(command_query, Conn);
            MySqlDataReader mydr;
            try
            {
                Conn.Open();
                mydr = cmd.ExecuteReader();
                while (mydr.Read())
                {
                    string subj = mydr.GetString("FirstName");
                    cb_dworkers.Items.Add(subj);

                }
                Conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Staff Error");

            }

        }

        private void Interface_ProvideSchedule_Load(object sender, EventArgs e)
        {
            try
            {
                label3.Visible = false;
                cb_dworkers.Visible = false;
                using (var content = new betterlimitedEntities_Test1())
                {
                    int staffID = int.Parse(lab1.Text);
                    staff staffs = content.staffs.First(i => i.StaffID == staffID);
                   
                    if (staffs != null)
                    {
                        txt_DID.Text = staffs.DepartmentID.ToString();

                    }
                }
                if (int.Parse(txt_DID.Text) == 9)
                {
                    label3.Visible = true;
                    cb_dworkers.Visible = true;
                    add2DID();
                }

                cb_session.DropDownStyle = ComboBoxStyle.DropDownList;
                cb_dworkers.DropDownStyle = ComboBoxStyle.DropDownList;
                cb_session.DropDownStyle = ComboBoxStyle.DropDownList;
                using (var content = new betterlimitedEntities_Test1())
                {

                    DateTime todaydate = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));

                    DateTime lastDate = new DateTime(todaydate.Year, todaydate.Month, 1).AddMonths(1).AddDays(-1);

                    {

                        var emp = (from list in content.schedules
                                   where list.dateofservice >= todaydate && list.dateofservice <= lastDate
                                   select list);



                        foreach (var emp2 in emp.ToList())
                        {
                            session sessions = content.sessions.First(i => i.Session1 == emp2.SessionID);
                            staff staffs = content.staffs.First(i => i.StaffID == emp2.D_staffID);
                            if (sessions != null && staffs != null)
                            {

                                dataGridView1.Rows.Add(emp2.dateofservice, sessions.SessionTime, staffs.Firstname);
                            }
                        }
                    }


                }
            }
            catch (System.FormatException) { MessageBox.Show("Bugs Existed"); }

        }

        private void cb_session_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_time_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          

            
          
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (cb_dworkers.Items.Count > 0)
            {
                using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                {
                    staff staffs = content.staffs.First(i => i.Firstname == cb_dworkers.SelectedItem.ToString());
                    if (staffs != null)
                    {
                        txt_staffID.Text = staffs.StaffID.ToString();

                    }

                }
            }

                try
            {
                DateTime dateod = DateTime.Parse(monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd"));
                DateSystem.LicenseKey = "LostTimeIsNeverFoundAgain";
                if (DateSystem.IsPublicHoliday(dateod, CountryCode.CN) || DateSystem.IsPublicHoliday(dateod, CountryCode.GB))
                {
                    throw new FieldAccessException();
                }
                if (dateod.DayOfWeek == DayOfWeek.Sunday)
                {
                    throw new InvalidExpressionException();
                }

                using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                {
                    
                    if (cb_session.SelectedItem.ToString() == "Morning")

                    {

                        int staffID = int.Parse(lab1.Text);
                        int session = 1;


                        schedule schedules = content.schedules.First(i => i.SessionID == session && i.dateofservice == dateod);
                        int did = int.Parse(txt_DID.Text);
                        if (schedules != null)
                        {

                            if (schedules.D_staffID == 0 && did == 11)
                            {
                                schedules.D_staffID = staffID;
                                radioButton2.Checked = true;
                            }
                            else if (did == 9)
                            {
                                schedules.D_staffID = int.Parse(txt_staffID.Text);
                                radioButton2.Checked = true;
                            }
                            else { throw new KeyNotFoundException(); }


                        }
                        content.SaveChanges();
                        if (int.Parse(txt_DID.Text) == 11)
                        {
                            MessageBox.Show("You Apply For the Time:    " + dateod + cb_session.SelectedItem.ToString());
                        }
                        if (int.Parse(txt_DID.Text) == 9) {
                            MessageBox.Show("The Delivery Worker"+cb_dworkers.SelectedItem.ToString()+" Has Arrange to" + dateod + cb_session.SelectedItem.ToString());
                        }

                    }
                    else if (cb_session.SelectedItem.ToString() == "Afternoon")
                    {
                        //int staffID = 1; //Change it
                        int staffID = int.Parse(lab1.Text);
                        int session = 2;
                        //  DateTime dateod = DateTime.Parse(monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd"));

                        schedule schedules = content.schedules.First(i => i.SessionID == session && i.dateofservice == dateod);
                        int did = int.Parse(txt_DID.Text);
                        if (schedules != null)
                        {
                            if (schedules.D_staffID == 0 && did == 11)
                            {
                                schedules.D_staffID = staffID;
                                radioButton2.Checked = true;
                            }
                            else if (did == 9) {
                                schedules.D_staffID = int.Parse(txt_staffID.Text);
                                radioButton2.Checked = true;
                            }
                            else { throw new KeyNotFoundException(); }

                        }
                        content.SaveChanges();
                        MessageBox.Show("You Apply For the Time:    " + dateod + cb_session.SelectedItem.ToString());
                    }
                    else if (cb_session.SelectedItem.ToString() == "Evening")
                    {
                        //   int staffID = 1; //Change it
                        int staffID = int.Parse(lab1.Text);
                        int session = 3;
                        // DateTime dateod = DateTime.Parse(monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd"));

                        schedule schedules = content.schedules.First(i => i.SessionID == session && i.dateofservice == dateod);
                        int did = int.Parse(txt_DID.Text);
                        if (schedules != null)
                        {
                            if (schedules.D_staffID == 0 && did == 11)
                            {
                                schedules.D_staffID = staffID;
                                radioButton2.Checked = true;

                            }
                            else if (did == 9)
                            {
                                schedules.D_staffID = int.Parse(txt_staffID.Text);
                                radioButton2.Checked = true;
                            }
                            else { throw new KeyNotFoundException(); }


                        }
                        content.SaveChanges();
                        MessageBox.Show("You Apply For the Time:    " + dateod.ToString("yyyy-MM-dd") + cb_session.SelectedItem.ToString());
                    }
                }
                if (radioButton1.Checked)
                {
                    dataGridView1.Rows.Clear();
                    using (var content = new betterlimitedEntities_Test1())
                    {
                        {

                            DateTime todaydate = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));

                            while (todaydate.DayOfWeek != DayOfWeek.Monday)
                            {
                                todaydate = todaydate.AddDays(-1);
                            }

                            DateTime startDate = todaydate;
                            DateTime endDate = todaydate.AddDays(7);


                            //DateTime lastDate = new DateTime(todaydate.Year, todaydate.Month, 1).AddMonths(1).AddDays(-1);

                            var emp = (from list in content.schedules
                                       where list.dateofservice >= todaydate && list.dateofservice <= endDate
                                       select list);



                            foreach (var emp2 in emp.ToList())
                            {
                                session sessions = content.sessions.First(i => i.Session1 == emp2.SessionID);
                                staff staffs = content.staffs.First(i => i.StaffID == emp2.D_staffID);

                                if (sessions != null && staffs != null)
                                {


                                    dataGridView1.Rows.Add(emp2.dateofservice, sessions.SessionTime, staffs.Firstname);
                                }
                            }
                        }


                    }


                }
                else if (radioButton2.Checked)
                {
                    dataGridView1.Rows.Clear();
                    using (var content = new betterlimitedEntities_Test1())
                    {

                        DateTime todaydate = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));

                        DateTime lastDate = new DateTime(todaydate.Year, todaydate.Month, 1).AddMonths(1).AddDays(-1);

                        {

                            var emp = (from list in content.schedules
                                       where list.dateofservice >= todaydate && list.dateofservice <= lastDate
                                       select list);



                            foreach (var emp2 in emp.ToList())
                            {
                                session sessions = content.sessions.First(i => i.Session1 == emp2.SessionID);
                                staff staffs = content.staffs.First(i => i.StaffID == emp2.D_staffID);

                                if (sessions != null && staffs != null)
                                {


                                    dataGridView1.Rows.Add(emp2.dateofservice, sessions.SessionTime, staffs.Firstname);
                                }
                            }
                        }


                    }

                }

            }
            catch (InvalidExpressionException) { MessageBox.Show("We Do Not Provide Delivery Services On Sunday."); }
            catch (FieldAccessException) { MessageBox.Show("We Do Not Have Delivery Services On Public Holiday."); }
            catch (KeyNotFoundException) { MessageBox.Show("There is already has Staff on duty"); }
            catch (System.InvalidOperationException) { MessageBox.Show("The Schedule Is Not Available Now"); }
        }


    

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            DateTime todaydate = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));
            while (todaydate.DayOfWeek != DayOfWeek.Monday)
            {
                todaydate = todaydate.AddDays(-1);
            }

            DateTime startDate = todaydate;
            DateTime endDate = todaydate.AddDays(7);
            if (radioButton1.Checked)
            {
                monthCalendar1.MinDate = DateTime.Now;
                monthCalendar1.MaxDate = endDate;
                dataGridView1.Rows.Clear();
                using (var content = new betterlimitedEntities_Test1())
                {
                    {





                        //DateTime lastDate = new DateTime(todaydate.Year, todaydate.Month, 1).AddMonths(1).AddDays(-1);

                        var emp = (from list in content.schedules
                                   where list.dateofservice >= todaydate && list.dateofservice <= endDate
                                   select list);



                        foreach (var emp2 in emp.ToList())
                        {
                            session sessions = content.sessions.First(i => i.Session1 == emp2.SessionID);
                            staff staffs = content.staffs.First(i => i.StaffID == emp2.D_staffID);

                            if (sessions != null && staffs != null)
                            {


                                dataGridView1.Rows.Add(emp2.dateofservice, sessions.SessionTime, staffs.Firstname);
                            }
                        }
                    }


                }


            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                DateTime todaydate = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));

                DateTime lastDate = new DateTime(todaydate.Year, todaydate.Month, 1).AddMonths(1).AddDays(-1);
                monthCalendar1.MinDate = DateTime.Now;
                monthCalendar1.MaxDate = lastDate;
                dataGridView1.Rows.Clear();
                using (var content = new betterlimitedEntities_Test1())
                {



                    {

                        var emp = (from list in content.schedules
                                   where list.dateofservice >= todaydate && list.dateofservice <= lastDate
                                   select list);



                        foreach (var emp2 in emp.ToList())
                        {
                            session sessions = content.sessions.First(i => i.Session1 == emp2.SessionID);
                            staff staffs = content.staffs.First(i => i.StaffID == emp2.D_staffID);

                            if (sessions != null && staffs != null)
                            {


                                dataGridView1.Rows.Add(emp2.dateofservice, sessions.SessionTime, staffs.Firstname);
                            }
                        }
                    }


                }
            }
            }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cb_dworkers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

    


