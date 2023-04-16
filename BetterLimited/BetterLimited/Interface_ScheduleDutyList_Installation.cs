using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nager.Date;

namespace BetterLimited
{
    public partial class Interface_ScheduleDutyList_Installation : Form
    {
        public static Interface_ScheduleDutyList_Installation instance;
        public Label lab1;
        public Interface_ScheduleDutyList_Installation()
        {
            InitializeComponent();
            instance = this;
            lab1 = label2;
        }

        private void Interface_ScheduleDutyList_Installation_Load(object sender, EventArgs e)
        {
            try
            {

                using (var content = new betterlimitedEntities_Test1())
                {
                    int staffID = int.Parse(lab1.Text);
                    staff staffs = content.staffs.First(i => i.StaffID == staffID);
                    //  department departments = content.departments.First(i => i.DepartmentID == emp2.DepartmentID);
                    if (staffs != null)
                    {
                        txt_DID.Text = staffs.DepartmentID.ToString();
                        if (staffs.DepartmentID == 15)
                        {

                            label3.Visible = true;
                            cb_iworkers.Visible = true;
                        }

                    }
                }
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
                            staff staffs = content.staffs.First(i => i.StaffID == emp2.I_staffID);
                            if (sessions != null && staffs != null)
                            {

                                dataGridView1.Rows.Add(emp2.dateofservice, sessions.SessionTime, staffs.Firstname);
                            }
                        }
                    }
                    {

                        var emp = (from list in content.staffs
                                   where list.DepartmentID == 12
                                   select list);



                        foreach (var emp2 in emp.ToList())
                        {


                            dataGridView_staff.Rows.Add(emp2.Firstname);
                        }
                        for (int x = 0; x < dataGridView_staff.RowCount; x++)
                        {



                            cb_iworkers.Items.Add(dataGridView_staff.Rows[x].Cells[0].Value.ToString());
                        }
                    }


                }
            }
            catch (System.FormatException) { MessageBox.Show("The Page Should Be Started From MainPage Of The Staff"); }

        }

        private void button1_Click(object sender, EventArgs e)
        {
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
                        if (schedules != null)
                        {
                            if (int.Parse(txt_DID.Text) == 15)
                            {
                                if (MessageBox.Show("The Installation Worker Will Be Change To Your Selected Staff", "Change Staff", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    string staffFirstname = cb_iworkers.SelectedItem.ToString();
                                    staff staffs = content.staffs.First(i => i.Firstname == staffFirstname);
                                    {
                                        schedules.I_staffID = staffs.StaffID;
                                        MessageBox.Show("You Apply For the Time:    " + dateod.ToString("yyyy-MM-dd") + cb_session.SelectedItem.ToString());
                                    }
                                }

                            }
                          else if (schedules.I_staffID == 0 && int.Parse(txt_DID.Text) == 12)
                            {
                                schedules.I_staffID = staffID;
                                MessageBox.Show("You Apply For the Time:    " + dateod.ToString("yyyy-MM-dd") + cb_session.SelectedItem.ToString());
                            }
                            else if (schedules.I_staffID != 0 && int.Parse(txt_DID.Text) == 12)
                            {
                                throw new KeyNotFoundException();
                            }
                            else if (schedules.I_staffID == 0 && int.Parse(txt_DID.Text) != 15) { throw new KeyNotFoundException(); }


                        }
                        content.SaveChanges();
                  

                    }
                    else if (cb_session.SelectedItem.ToString() == "Afternoon")
                    {
                        //int staffID = 1; //Change it
                        int staffID = int.Parse(lab1.Text);
                        int session = 2;
                        //  DateTime dateod = DateTime.Parse(monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd"));

                        schedule schedules = content.schedules.First(i => i.SessionID == session && i.dateofservice == dateod);
                        if (schedules != null)
                        {
                            if (int.Parse(txt_DID.Text) == 15)
                            {
                                if (MessageBox.Show("The Installation Worker Will Be Change To Your Selected Staff", "Change Staff", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    string staffFirstname = cb_iworkers.SelectedItem.ToString();
                                    staff staffs = content.staffs.First(i => i.Firstname == staffFirstname);
                                    {
                                        schedules.I_staffID = staffs.StaffID;
                                    }
                                    MessageBox.Show("You Apply For the Time:    " + dateod.ToString("yyyy-MM-dd") + cb_session.SelectedItem.ToString());
                                }

                            }
                           else if (schedules.I_staffID == 0 && int.Parse(txt_DID.Text) == 12)
                            {
                                schedules.I_staffID = staffID;
                                MessageBox.Show("You Apply For the Time:    " + dateod.ToString("yyyy-MM-dd") + cb_session.SelectedItem.ToString());
                            }
                            else if (schedules.I_staffID != 0 && int.Parse(txt_DID.Text) == 12)
                            {
                                throw new KeyNotFoundException();
                            }

                            else if (schedules.I_staffID == 0 && int.Parse(txt_DID.Text) != 15) { throw new KeyNotFoundException(); }

                        }
                        content.SaveChanges();
              
                    }
                    else if (cb_session.SelectedItem.ToString() == "Evening")
                    {
                        //   int staffID = 1; //Change it
                        int staffID = int.Parse(lab1.Text);
                        int session = 3;
                        // DateTime dateod = DateTime.Parse(monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd"));

                        schedule schedules = content.schedules.First(i => i.SessionID == session && i.dateofservice == dateod);
                        if (schedules != null)
                        {
                            if (int.Parse(txt_DID.Text) == 15)
                            {
                                if (MessageBox.Show("The Installation Worker Will Be Change To Your Selected Staff", "Change Staff", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    string staffFirstname = cb_iworkers.SelectedItem.ToString();
                                    staff staffs = content.staffs.First(i => i.Firstname == staffFirstname);
                                    {
                                        schedules.I_staffID = staffs.StaffID;
                                    }
                                    MessageBox.Show("You Apply For the Time:    " + dateod.ToString("yyyy-MM-dd") + cb_session.SelectedItem.ToString());
                                }

                            }
                            else if (schedules.I_staffID == 0 && int.Parse(txt_DID.Text) == 12) {
                                schedules.I_staffID =staffID;
                                MessageBox.Show("You Apply For the Time:    " + dateod.ToString("yyyy-MM-dd") + cb_session.SelectedItem.ToString());
                            }
                            else if (schedules.I_staffID != 0 && int.Parse(txt_DID.Text) == 12)
                            {
                                throw new KeyNotFoundException();
                            }
                            else if(schedules.I_staffID == 0&& int.Parse(txt_DID.Text) != 15) { throw new KeyNotFoundException(); }


                        }
                        content.SaveChanges();
                      
                    }
                }
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
                            staff staffs = content.staffs.First(i => i.StaffID == emp2.I_staffID);

                            if (sessions != null && staffs != null)
                            {


                                dataGridView1.Rows.Add(emp2.dateofservice, sessions.SessionTime, staffs.Firstname);
                            }
                        }
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
                                staff staffs = content.staffs.First(i => i.StaffID == emp2.I_staffID);

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
                                staff staffs = content.staffs.First(i => i.StaffID == emp2.I_staffID);

                                if (sessions != null && staffs != null)
                                {


                                    dataGridView1.Rows.Add(emp2.dateofservice, sessions.SessionTime, staffs.Firstname);
                                }
                            }
                        }


                    }

                }

            }
            catch (InvalidExpressionException) { MessageBox.Show("We Do Not Provide Installation Services On Sunday."); }
            catch (FieldAccessException) { MessageBox.Show("We Do Not Have Installation Services On Public Holiday."); }
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
            if (radioButton1.Checked) {
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
                            staff staffs = content.staffs.First(i => i.StaffID == emp2.I_staffID);
                            
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
            if (radioButton2.Checked) {
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
                            staff staffs = content.staffs.First(i => i.StaffID == emp2.I_staffID);
                           
                            if (sessions != null && staffs != null)
                            {
                                

                                dataGridView1.Rows.Add(emp2.dateofservice, sessions.SessionTime, staffs.Firstname);
                            }
                        }
                    }


                }

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cb_iworkers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
    


