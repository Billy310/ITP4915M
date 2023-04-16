﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Nager.Date;

namespace BetterLimited
{
    public partial class Interface_UpdateDeliveryOrderStatus : Form
    {
        public static Interface_UpdateDeliveryOrderStatus instance;
        public Label lab1;

        public Interface_UpdateDeliveryOrderStatus()
        {
            InitializeComponent();
            instance = this;
            lab1 = label1;
        }
        void datecount1()
        {
            DateTime dateod = DateTime.Parse(monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd"));

            // int sessionid = int.Parse(txt_SessionID.Text);
            MySqlConnection Conn = new MySqlConnection(@"datasource=localhost;port=3306;username=root;password=");
            string command_query = "SELECT Count(SessionID) FROM betterlimited.deliveryorder WHERE SessionID=1 && DeliveryDate=@dateofdelivery;";

            MySqlCommand cmd = new MySqlCommand(command_query, Conn);
            //cmd.Parameters.AddWithValue(" @sessionid", sessionid);
            cmd.Parameters.AddWithValue("@dateofdelivery", dateod);
            MySqlDataReader mydr;
            try
            {
                Conn.Open();
                mydr = cmd.ExecuteReader();
                while (mydr.Read())
                {

                    string subj = mydr.GetString("Count(SessionID)");
                    //cb_StaffID.Items.Add(subj);
                    cb_countsession.Items.Clear();
                    cb_countsession.Items.Add(subj);

                }
                Conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Error1");

            }
        }
        void datecount2()
        {
            DateTime dateod = DateTime.Parse(monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd"));

            // int sessionid = int.Parse(txt_SessionID.Text);
            MySqlConnection Conn = new MySqlConnection(@"datasource=localhost;port=3306;username=root;password=");
            string command_query = "SELECT Count(SessionID) FROM betterlimited.deliveryorder WHERE SessionID=2 && DeliveryDate=@dateofdelivery;";

            MySqlCommand cmd = new MySqlCommand(command_query, Conn);
            //cmd.Parameters.AddWithValue(" @sessionid", sessionid);
            cmd.Parameters.AddWithValue("@dateofdelivery", dateod);
            MySqlDataReader mydr;
            try
            {
                Conn.Open();
                mydr = cmd.ExecuteReader();
                while (mydr.Read())
                {

                    string subj = mydr.GetString("Count(SessionID)");
                    //cb_StaffID.Items.Add(subj);
                    cb_countsession.Items.Clear();
                    cb_countsession.Items.Add(subj);

                }
                Conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Error2");

            }
        }
        void datecount3()
        {
            DateTime dateod = DateTime.Parse(monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd"));

            // int sessionid = int.Parse(txt_SessionID.Text);
            MySqlConnection Conn = new MySqlConnection(@"datasource=localhost;port=3306;username=root;password=");
            string command_query = "SELECT Count(SessionID) FROM betterlimited.deliveryorder WHERE SessionID=3 && DeliveryDate=@dateofdelivery;";

            MySqlCommand cmd = new MySqlCommand(command_query, Conn);
            //cmd.Parameters.AddWithValue(" @sessionid", sessionid);
            cmd.Parameters.AddWithValue("@dateofdelivery", dateod);
            MySqlDataReader mydr;
            try
            {
                Conn.Open();
                mydr = cmd.ExecuteReader();
                while (mydr.Read())
                {

                    string subj = mydr.GetString("Count(SessionID)");
                    //cb_StaffID.Items.Add(subj);
                    cb_countsession.Items.Clear();
                    cb_countsession.Items.Add(subj);

                }
                Conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Error3");

            }
        }
        private void Interface_UpdateOrderStatus_Load(object sender, EventArgs e)
        {
            try
            {
                cb_time.DropDownStyle = ComboBoxStyle.DropDownList;
                cb_session.DropDownStyle = ComboBoxStyle.DropDownList;
                txt_date.Enabled = false;
                txt_Time.Enabled = false;
                txt_cfullname.Enabled = false;
                using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                {

                    int orderID = int.Parse(label1.Text);
                    deliveryorder deliveryorders = content.deliveryorders.First(i => i.DeliveryOrderID == orderID);
                    if (deliveryorders != null)
                    {

                        p1.Text = deliveryorders.DeliveryProductID_1.ToString();
                        p2.Text = deliveryorders.DeliveryProductID_2.ToString();
                        p3.Text = deliveryorders.DeliveryProductID_3.ToString();
                        p4.Text = deliveryorders.DeliveryProductID_4.ToString();
                        p5.Text = deliveryorders.DeliveryProductID_5.ToString();
                        p6.Text = deliveryorders.DeliveryProductID_6.ToString();
                        p7.Text = deliveryorders.DeliveryProductID_7.ToString();
                        p8.Text = deliveryorders.DeliveryProductID_8.ToString();
                        p9.Text = deliveryorders.DeliveryProductID_9.ToString();
                        p10.Text = deliveryorders.DeliveryProductID_10.ToString();
                        q1.Text = deliveryorders.DeliveryProductID_1qty.ToString();
                        q2.Text = deliveryorders.DeliveryProductID_2qty.ToString();
                        q3.Text = deliveryorders.DeliveryProductID_3qty.ToString();
                        q4.Text = deliveryorders.DeliveryProductID_4qty.ToString();
                        q5.Text = deliveryorders.DeliveryProductID_5qty.ToString();
                        q6.Text = deliveryorders.DeliveryProductID_6qty.ToString();
                        q7.Text = deliveryorders.DeliveryProductID_7qty.ToString();
                        q8.Text = deliveryorders.DeliveryProductID_8qty.ToString();
                        q9.Text = deliveryorders.DeliveryProductID_9qty.ToString();
                        q10.Text = deliveryorders.DeliveryProductID_10qty.ToString();
                        txt_SorderID.Text = deliveryorders.OrderID.ToString();
                        DateTime ddate = DateTime.Parse(deliveryorders.DeliveryDate.ToString());
                        DateTime full = DateTime.Parse(ddate.ToString("yyyy-MM-dd"));
                        txt_date.Text = full.ToString();
                        TimeSpan dtime = TimeSpan.Parse(deliveryorders.timeofDelivery.ToString());
                        txt_Time.Text = dtime.ToString();
                        monthCalendar1.MinDate = DateTime.Parse(deliveryorders.DeliveryDate.ToString());
                        //DateTime todaydate = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));
                        //DateTime lastDate = new DateTime(todaydate.Year, todaydate.Month, 1).AddMonths(1).AddDays(-1);
                        monthCalendar1.MaxDate = monthCalendar1.MinDate.AddDays(14);





                    }
                    string[] productlist = { p1.Text, p2.Text, p3.Text, p4.Text, p5.Text, p6.Text, p7.Text, p8.Text, p9.Text, p10.Text };
                    for (int x = 0; x < 10; x++)
                    {
                        int pid = int.Parse(productlist[x]);

                        product products = content.products.First(i => i.ProductID == pid);
                        if (products != null)
                        {
                            lb_productname.Items.Add(products.ProductName);
                        }
                    }
                    int sorderID = int.Parse(txt_SorderID.Text);

                    saleorder saleorders = content.saleorders.First(i => i.orderID == sorderID);
                    if (saleorders != null)
                    {

                        txt_cid.Text = saleorders.CustomerID.ToString();

                    }
                    string[] qtylist = { q1.Text, q2.Text, q3.Text, q4.Text, q5.Text, q6.Text, q7.Text, q8.Text, q9.Text, q10.Text };
                    for (int x = 0; x < 10; x++)
                    {
                        int qid = int.Parse(qtylist[x]);
                        if (qid == 0)
                        {
                            lb_qty.Items.Add("");

                        }
                        else if (qid != 0)
                        {
                            lb_qty.Items.Add(qtylist[x]);

                        }
                    }

                    int customerID = int.Parse(txt_cid.Text);
                    customer customers = content.customers.First(i => i.CustomerID == customerID);
                    if (customers != null)
                    {
                        txt_cfullname.Text = customers.LastName + "  " + customers.FirstName;


                    }

                }
            }
            catch (System.FormatException) { MessageBox.Show("Select The Delivery Order First"); }
        }

        private void p1_TextChanged(object sender, EventArgs e)
        {

        }

        private void p2_TextChanged(object sender, EventArgs e)
        {

        }

        private void p3_TextChanged(object sender, EventArgs e)
        {

        }

        private void p4_TextChanged(object sender, EventArgs e)
        {

        }

        private void p5_TextChanged(object sender, EventArgs e)
        {

        }

        private void p6_TextChanged(object sender, EventArgs e)
        {

        }

        private void p7_TextChanged(object sender, EventArgs e)
        {

        }

        private void p8_TextChanged(object sender, EventArgs e)
        {

        }

        private void p9_TextChanged(object sender, EventArgs e)
        {

        }

        private void p10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dateod= DateTime.Parse(monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd"));
                if (cb_session.SelectedItem.ToString() == "Morning")
                {
                    txt_SessionID.Text = "1";
                    datecount1();
                }
                if (cb_session.SelectedItem.ToString() == "Afternoon")
                {
                    txt_SessionID.Text = "2";
                    datecount2();
                }
                if (cb_session.SelectedItem.ToString() == "Evening")
                {
                    txt_SessionID.Text = "3";
                    datecount3();
                }
                if (int.Parse(cb_countsession.Items[0].ToString()) >= 5)
                {
               
                    cb_countsession.Items.Clear();
                    throw new IndexOutOfRangeException();

                }
                DateSystem.LicenseKey = "LostTimeIsNeverFoundAgain";
                if (DateSystem.IsPublicHoliday(dateod, CountryCode.GB))
                {
                    throw new InvalidCastException();

                }
                if (DateSystem.IsPublicHoliday(dateod, CountryCode.CN))
                {
                    throw new InvalidCastException();

                }

                using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                {
                    int DorderID = int.Parse(label1.Text);
                    deliveryorder deliveryorders = content.deliveryorders.First(i => i.DeliveryOrderID == DorderID);
                    if (deliveryorders != null)
                    {
                        deliveryorders.DeliveryDate= DateTime.Parse(monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd"));
                        deliveryorders.SessionID = int.Parse(txt_SessionID.Text);
                        deliveryorders.timeofDelivery = TimeSpan.Parse(cb_time.SelectedItem.ToString());




                    }
                    content.SaveChanges();
                    schedule schedules = content.schedules.First(i => i.dateofservice == deliveryorders.DeliveryDate&& i.SessionID== deliveryorders.SessionID);
                    if (schedules != null) {
                        deliveryorders.DWorkerID = schedules.D_staffID;


                    }


                    content.SaveChanges();
                    MessageBox.Show("Update Successful");
                }

            }
            catch (InvalidCastException) { MessageBox.Show("The Delivery Date Can not be Public Holiday Please Try Again"); }
            catch (EvaluateException) { MessageBox.Show("The Delivery Time already selected by others. Please Choose other Time and Try Again."); }
            catch (IndexOutOfRangeException) { MessageBox.Show("The Time is Unavailable. Please Select Again"); }
        }

        private void cb_session_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_session.SelectedItem.ToString() == "Morning")
            {
                cb_time.Text = "";
                cb_time.Items.Clear();
                cb_time.Items.Add("9:00");
                cb_time.Items.Add("10:00");
                cb_time.Items.Add("11:00");
                cb_time.Items.Add("12:00");
            }
            if (cb_session.SelectedItem.ToString() == "Afternoon")
            {
                cb_time.Text = "";
                cb_time.Items.Clear();
                cb_time.Items.Add("13:00");
                cb_time.Items.Add("14:00");
                cb_time.Items.Add("15:00");
                cb_time.Items.Add("16:00");
                cb_time.Items.Add("17:00");
            }
            if (cb_session.SelectedItem.ToString() == "Evening")
            {
                cb_time.Text = "";
                cb_time.Items.Clear();
                cb_time.Items.Add("18:00");
                cb_time.Items.Add("19:00");
                cb_time.Items.Add("20:00");
                cb_time.Items.Add("21:00");
                cb_time.Items.Add("22:00");
            }
        }

        private void btn_updates_Click(object sender, EventArgs e)
        {
            using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
            {
                int DorderID = int.Parse(label1.Text);
                deliveryorder deliveryorders = content.deliveryorders.First(i => i.DeliveryOrderID == DorderID);
                if (deliveryorders != null)
                {
                    deliveryorders.D_Status = "Delivery Successful!";




                }
                content.SaveChanges();
                MessageBox.Show("Update Successful");
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
    }

