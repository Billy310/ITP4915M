using MySql.Data.MySqlClient;
using Nager.Date;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BetterLimited
{
    public partial class Interface_CreateDeliveryOrder : Form
    {
        betterlimitedEntities_Test1 db = new betterlimitedEntities_Test1();
        MySqlConnection Conn = new MySqlConnection(@"datasource=42.2.204.164;port=3306;username=Test;password=");
        public Interface_CreateDeliveryOrder()
        {
            InitializeComponent();
        }
        void datecount1()
        {
            DateTime dateod = DateTime.Parse(date_delivery.SelectionRange.Start.ToString("yyyy-MM-dd"));

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
                    cb_count.Items.Add(subj);

                }
                Conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Erroe");

            }
        }
        void datecount2()
        {
            DateTime dateod = DateTime.Parse(date_delivery.SelectionRange.Start.ToString("yyyy-MM-dd"));

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
                    cb_count.Items.Add(subj);

                }
                Conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Erroe");

            }
        }

        void datecount3()
        {
            DateTime dateod = DateTime.Parse(date_delivery.SelectionRange.Start.ToString("yyyy-MM-dd"));

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
                    cb_count.Items.Add(subj);

                }
                Conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Erroe");

            }
        }


  
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
                    //  cb_session.Items.Add(subj);

                }
                Conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Session Error");

            }

        }
        void add2Store()
        {
            string command_query = "SELECT StoreName FROM betterlimited.store ";
            MySqlCommand cmd = new MySqlCommand(command_query, Conn);
            MySqlDataReader mydr;
            try
            {
                Conn.Open();
                mydr = cmd.ExecuteReader();
                while (mydr.Read())
                {
                    string subj = mydr.GetString("StoreName");
                    cb_StoreName.Items.Add(subj);

                }
                Conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Store Error");

            }

        }
        void addSession()
        {

            string command_query = "SELECT SessionTime  FROM betterlimited.session";
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
                MessageBox.Show("Order Error");

            }

        }
        //DateTime x = DateTime.Parse(date_delivery.SelectionRange.Start.ToString("yyyy-MM-dd"));
        //TimeSpan t = TimeSpan.Parse(cb_time.SelectedItem.ToString());
        void time()
        {
            cb_countorder.Items.Clear();
            DateTime x = DateTime.Parse(date_delivery.SelectionRange.Start.ToString("yyyy-MM-dd"));
            TimeSpan t = TimeSpan.Parse(cb_time.SelectedItem.ToString());
            string command_query = "SELECT Count(timeofDelivery)  FROM betterlimited.deliveryorder WHERE DeliveryDate=@dateofstart &&  	timeofDelivery=@timeofd";
            MySqlCommand cmd = new MySqlCommand(command_query, Conn);
            cmd.Parameters.AddWithValue("@dateofstart", x);
            cmd.Parameters.AddWithValue("@timeofd", t);
            MySqlDataReader mydr;
            try
            {
                Conn.Open();
                mydr = cmd.ExecuteReader();
                while (mydr.Read())
                {
                    string subj = mydr.GetString("Count(timeofDelivery)");
                    cb_countorder.Items.Add(subj);

                }
                Conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Time and Date Error");

            }

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
                try
                {
                if (MessageBox.Show("All Unsaved Information Will Be Lost", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                
                    lb_orderItem.Items.Clear();
                    lb_DeliverItems.Items.Clear();
                    lb_qty.Items.Clear();
                    cb_CountSametime.Items.Clear();



                    using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())

                    {

                        int saleorderID = int.Parse(cb_order.SelectedItem.ToString());
                        saleorder s = content.saleorders.First(i => i.orderID == saleorderID);
                        if (s != null)
                        {
                            product1.Text = s.Product1_ID.ToString();
                            product2.Text = s.Product2_ID.ToString();
                            product3.Text = s.Product3_ID.ToString();
                            product4.Text = s.Product4_ID.ToString();
                            product5.Text = s.Product5_ID.ToString();
                            product6.Text = s.Product6_ID.ToString();
                            product7.Text = s.Product7_ID.ToString();
                            product8.Text = s.Product8_ID.ToString();
                            product9.Text = s.Product9_ID.ToString();
                            product10.Text = s.Product10_ID.ToString();
                            product1_qty.Text = s.Product1_Qty.ToString();
                            product2_qty.Text = s.Product2_Qty.ToString();
                            product3_qty.Text = s.Product3_Qty.ToString();
                            product4_qty.Text = s.Product4_Qty.ToString();
                            product5_qty.Text = s.Product5_Qty.ToString();
                            product6_qty.Text = s.Product6_Qty.ToString();
                            product7_qty.Text = s.Product7_Qty.ToString();
                            product8_qty.Text = s.Product8_Qty.ToString();
                            product9_qty.Text = s.Product9_Qty.ToString();
                            product10_qty.Text = s.Product10_Qty.ToString();
                        }
                        int product1_int = int.Parse(product1.Text);
                        int product2_int = int.Parse(product2.Text);
                        int product3_int = int.Parse(product3.Text);
                        int product4_int = int.Parse(product4.Text);
                        int product5_int = int.Parse(product5.Text);
                        int product6_int = int.Parse(product6.Text);
                        int product7_int = int.Parse(product7.Text);
                        int product8_int = int.Parse(product8.Text);
                        int product9_int = int.Parse(product9.Text);
                        int product10_int = int.Parse(product10.Text);
                        product p1 = content.products.First(i => i.ProductID == product1_int);
                        if (p1 != null)
                        {
                            if (p1.ProductName != "")
                            {
                                lb_orderItem.Items.Add(p1.ProductName);
                            }
                        }
                        product p2 = content.products.First(i => i.ProductID == product2_int);
                        if (p2 != null)
                        {
                            if (p2.ProductName != "")
                            {
                                lb_orderItem.Items.Add(p2.ProductName);
                            }
                        }
                        product p3 = content.products.First(i => i.ProductID == product3_int);
                        if (p3 != null)
                        {
                            if (p3.ProductName != "")
                            {
                                lb_orderItem.Items.Add(p3.ProductName);
                            }
                        }
                        product p4 = content.products.First(i => i.ProductID == product4_int);
                        if (p4 != null)
                        {
                            if (p4.ProductName != "")
                            {
                                lb_orderItem.Items.Add(p4.ProductName);
                            }
                        }
                        product p5 = content.products.First(i => i.ProductID == product5_int);
                        if (p5 != null)
                        {
                            if (p5.ProductName != "")
                            {
                                lb_orderItem.Items.Add(p5.ProductName);
                            }
                        }
                        product p6 = content.products.First(i => i.ProductID == product6_int);
                        if (p6 != null)
                        {
                            if (p6.ProductName != "")
                            {
                                lb_orderItem.Items.Add(p6.ProductName);
                            }
                        }
                        product p7 = content.products.First(i => i.ProductID == product7_int);
                        if (p7 != null)
                        {
                            if (p7.ProductName != "")
                            {
                                lb_orderItem.Items.Add(p7.ProductName);
                            }
                        }
                        product p8 = content.products.First(i => i.ProductID == product8_int);
                        if (p8 != null)
                        {
                            if (p8.ProductName != "")
                            {
                                lb_orderItem.Items.Add(p8.ProductName);
                            }
                        }
                        product p9 = content.products.First(i => i.ProductID == product9_int);
                        if (p9 != null)
                        {
                            if (p9.ProductName != "")
                            {
                                lb_orderItem.Items.Add(p9.ProductName);
                            }
                        }
                        product p10 = content.products.First(i => i.ProductID == product10_int);
                        if (p10 != null)
                        {
                            if (p10.ProductName != "")
                            {
                                lb_orderItem.Items.Add(p10.ProductName);
                            }
                        }
                        if (s != null)
                        {
                            if (s.Product1_ID != 0)
                            {
                                product1.Text = s.Product1_ID.ToString();
                                if (s.Product1_Qty != 0)
                                {
                                    lb_qty.Items.Add(s.Product1_Qty.ToString());
                                }


                            }
                            if (s.Product2_ID != 0)
                            {
                                product2.Text = s.Product2_ID.ToString();
                                if (s.Product2_Qty != 0)
                                {
                                    lb_qty.Items.Add(s.Product2_Qty.ToString());
                                }


                            }
                            if (s.Product3_ID != 0)
                            {
                                product3.Text = s.Product3_ID.ToString();
                                if (s.Product3_Qty != 0)
                                {
                                    lb_qty.Items.Add(s.Product3_Qty.ToString());
                                }

                            }
                            if (s.Product4_ID != 0)
                            {
                                product4.Text = s.Product4_ID.ToString();
                                if (s.Product4_Qty != 0)
                                {
                                    lb_qty.Items.Add(s.Product4_Qty.ToString());
                                }

                            }
                            if (s.Product5_ID != 0)
                            {
                                product5.Text = s.Product5_ID.ToString();
                                if (s.Product5_Qty != 0)
                                {
                                    lb_qty.Items.Add(s.Product5_Qty.ToString());
                                }

                            }
                            if (s.Product6_ID != 0)
                            {
                                product6.Text = s.Product6_ID.ToString();
                                if (s.Product6_Qty != 0)
                                {
                                    lb_qty.Items.Add(s.Product6_Qty.ToString());
                                }

                            }
                            if (s.Product7_ID != 0)
                            {
                                product7.Text = s.Product7_ID.ToString();
                                if (s.Product7_Qty != 0)
                                {
                                    lb_qty.Items.Add(s.Product7_Qty.ToString());
                                }

                            }
                            if (s.Product8_ID != 0)
                            {
                                product8.Text = s.Product8_ID.ToString();
                                if (s.Product8_Qty != 0)
                                {
                                    lb_qty.Items.Add(s.Product8_Qty.ToString());
                                }

                            }
                            if (s.Product9_ID != 0)
                            {
                                product9.Text = s.Product9_ID.ToString();
                                if (s.Product9_Qty != 0)
                                {
                                    lb_qty.Items.Add(s.Product9_Qty.ToString());
                                }

                            }
                            if (s.Product10_ID != 0)
                            {
                                product9.Text = s.Product10_ID.ToString();
                                if (s.Product10_Qty != 0)
                                {
                                    lb_qty.Items.Add(s.Product10_Qty.ToString());
                                }
                            }



                        }

                    }
                }
                }
                catch (System.NullReferenceException) { MessageBox.Show("The Sale Order Can not be Blank"); }
            
        }
        


            private void btn_CreateDelivery_Click(object sender, EventArgs e)
            {

                try
                {

                if (lb_DeliverItems.Items.Count < 1)
                {
                    throw new NoNullAllowedException();
                }


                DateTimePicker d = new DateTimePicker();






                    //  TimeSpan ts_time=TimeSpan.Parse(timeofdelivery.Value.ToString("HH:mm"));

                    //DateTime dateod = DateTime.Parse(date_delivery.Value.ToString("yyyy-MM-dd"));
                    DateTime dateod = DateTime.Parse(date_delivery.SelectionRange.Start.ToString("yyyy-MM-dd"));
                    if (cb_session.SelectedItem.ToString() == "Morning")
                    {
                        txt_SessionID.Text = "1";
                    }
                    if (cb_session.SelectedItem.ToString() == "Afternoon")
                    {
                        txt_SessionID.Text = "2";
                    }
                    if (cb_session.SelectedItem.ToString() == "Evening")
                    {
                        txt_SessionID.Text = "3";
                    }




                    {








                        using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())

                        {
                            string productIID1;
                            string productIID2;
                            string productIID3;
                            string productIID4;
                            string productIID5;
                            string productIID6;
                            string productIID7;
                            string productIID8;
                            string productIID9;
                            string productIID10;
                            productIID1 = "";
                            productIID2 = "";
                            productIID3 = "";
                            productIID4 = "";
                            productIID5 = "";
                            productIID6 = "";
                            productIID7 = "";
                            productIID8 = "";
                            productIID9 = "";
                            productIID10 = "";

                            if (lb_DeliverItems.Items.Count == 1)
                            {
                                productIID1 = lb_DeliverItems.Items[0].ToString();
                            }

                            if (lb_DeliverItems.Items.Count == 2)
                            {
                                productIID1 = lb_DeliverItems.Items[0].ToString();
                                productIID2 = lb_DeliverItems.Items[1].ToString();

                            }

                            if (lb_DeliverItems.Items.Count == 3)
                            {
                                productIID1 = lb_DeliverItems.Items[0].ToString();
                                productIID2 = lb_DeliverItems.Items[1].ToString();
                                productIID3 = lb_DeliverItems.Items[2].ToString();
                            }


                            if (lb_DeliverItems.Items.Count == 4)
                            {
                                productIID1 = lb_DeliverItems.Items[0].ToString();
                                productIID2 = lb_DeliverItems.Items[1].ToString();
                                productIID3 = lb_DeliverItems.Items[2].ToString();
                                productIID4 = lb_DeliverItems.Items[3].ToString();
                            }

                            if (lb_DeliverItems.Items.Count == 5)
                            {
                                productIID1 = lb_DeliverItems.Items[0].ToString();
                                productIID2 = lb_DeliverItems.Items[1].ToString();
                                productIID3 = lb_DeliverItems.Items[2].ToString();
                                productIID4 = lb_DeliverItems.Items[3].ToString();
                                productIID5 = lb_DeliverItems.Items[4].ToString();
                            }

                            if (lb_DeliverItems.Items.Count == 6)
                            {
                                productIID1 = lb_DeliverItems.Items[0].ToString();
                                productIID2 = lb_DeliverItems.Items[1].ToString();
                                productIID3 = lb_DeliverItems.Items[2].ToString();
                                productIID4 = lb_DeliverItems.Items[3].ToString();
                                productIID5 = lb_DeliverItems.Items[4].ToString();
                                productIID6 = lb_DeliverItems.Items[5].ToString();
                            }

                            if (lb_DeliverItems.Items.Count == 7)
                            {
                                productIID1 = lb_DeliverItems.Items[0].ToString();
                                productIID2 = lb_DeliverItems.Items[1].ToString();
                                productIID3 = lb_DeliverItems.Items[2].ToString();
                                productIID4 = lb_DeliverItems.Items[3].ToString();
                                productIID5 = lb_DeliverItems.Items[4].ToString();
                                productIID6 = lb_DeliverItems.Items[5].ToString();
                                productIID7 = lb_DeliverItems.Items[6].ToString();
                            }

                            if (lb_DeliverItems.Items.Count == 8)
                            {
                                productIID1 = lb_DeliverItems.Items[0].ToString();
                                productIID2 = lb_DeliverItems.Items[1].ToString();
                                productIID3 = lb_DeliverItems.Items[2].ToString();
                                productIID4 = lb_DeliverItems.Items[3].ToString();
                                productIID5 = lb_DeliverItems.Items[4].ToString();
                                productIID6 = lb_DeliverItems.Items[5].ToString();
                                productIID7 = lb_DeliverItems.Items[6].ToString();
                                productIID8 = lb_DeliverItems.Items[7].ToString();
                            }

                            if (lb_DeliverItems.Items.Count == 9)
                            {
                                productIID1 = lb_DeliverItems.Items[0].ToString();
                                productIID2 = lb_DeliverItems.Items[1].ToString();
                                productIID3 = lb_DeliverItems.Items[2].ToString();
                                productIID4 = lb_DeliverItems.Items[3].ToString();
                                productIID5 = lb_DeliverItems.Items[4].ToString();
                                productIID6 = lb_DeliverItems.Items[5].ToString();
                                productIID7 = lb_DeliverItems.Items[6].ToString();
                                productIID8 = lb_DeliverItems.Items[7].ToString();
                                productIID9 = lb_DeliverItems.Items[8].ToString();
                            }

                            if (lb_DeliverItems.Items.Count == 10)
                            {
                                productIID1 = lb_DeliverItems.Items[0].ToString();
                                productIID2 = lb_DeliverItems.Items[1].ToString();
                                productIID3 = lb_DeliverItems.Items[2].ToString();
                                productIID4 = lb_DeliverItems.Items[3].ToString();
                                productIID5 = lb_DeliverItems.Items[4].ToString();
                                productIID6 = lb_DeliverItems.Items[5].ToString();
                                productIID7 = lb_DeliverItems.Items[6].ToString();
                                productIID8 = lb_DeliverItems.Items[7].ToString();
                                productIID9 = lb_DeliverItems.Items[8].ToString();
                                productIID10 = lb_DeliverItems.Items[9].ToString();
                            }





                            if (productIID1 != "")


                            {

                                product p1 = content.products.First(i => i.ProductName == productIID1);

                                if (p1 != null)
                                {
                                    int Deliver1_int = p1.ProductID;
                                    Deliver1.Text = Deliver1_int.ToString();

                                }
                            }
                            if (productIID2 != "")


                            {

                                product p1 = content.products.First(i => i.ProductName == productIID1);

                                if (p1 != null)
                                {
                                    int Deliver1_int = p1.ProductID;
                                    Deliver1.Text = Deliver1_int.ToString();

                                }
                                product p2 = content.products.First(i => i.ProductName == productIID2);
                                if (p2 != null)
                                {
                                    int Deliver2_int = p2.ProductID;
                                    Deliver2.Text = Deliver2_int.ToString();

                                }
                            }
                            if (productIID3 != "")


                            {


                                product p1 = content.products.First(i => i.ProductName == productIID1);

                                if (p1 != null)
                                {
                                    int Deliver1_int = p1.ProductID;
                                    Deliver1.Text = Deliver1_int.ToString();

                                }
                                product p2 = content.products.First(i => i.ProductName == productIID2);
                                if (p2 != null)
                                {
                                    int Deliver2_int = p2.ProductID;
                                    Deliver2.Text = Deliver2_int.ToString();

                                }
                                product p3 = content.products.First(i => i.ProductName == productIID3);
                                if (p3 != null)
                                {
                                    int Deliver3_int = p3.ProductID;
                                    Deliver3.Text = Deliver3_int.ToString();

                                }

                            }
                            if (productIID4 != "")


                            {


                                product p1 = content.products.First(i => i.ProductName == productIID1);

                                if (p1 != null)
                                {
                                    int Deliver1_int = p1.ProductID;
                                    Deliver1.Text = Deliver1_int.ToString();

                                }
                                product p2 = content.products.First(i => i.ProductName == productIID2);
                                if (p2 != null)
                                {
                                    int Deliver2_int = p2.ProductID;
                                    Deliver2.Text = Deliver2_int.ToString();

                                }
                                product p3 = content.products.First(i => i.ProductName == productIID3);
                                if (p3 != null)
                                {
                                    int Deliver3_int = p3.ProductID;
                                    Deliver3.Text = Deliver3_int.ToString();

                                }
                                product p4 = content.products.First(i => i.ProductName == productIID4);
                                if (p4 != null)
                                {
                                    int Deliver4_int = p4.ProductID;
                                    Deliver4.Text = Deliver4_int.ToString();

                                }





                            }
                            if (productIID5 != "")


                            {


                                product p1 = content.products.First(i => i.ProductName == productIID1);

                                if (p1 != null)
                                {
                                    int Deliver1_int = p1.ProductID;
                                    Deliver1.Text = Deliver1_int.ToString();

                                }
                                product p2 = content.products.First(i => i.ProductName == productIID2);
                                if (p2 != null)
                                {
                                    int Deliver2_int = p2.ProductID;
                                    Deliver2.Text = Deliver2_int.ToString();

                                }
                                product p3 = content.products.First(i => i.ProductName == productIID3);
                                if (p3 != null)
                                {
                                    int Deliver3_int = p3.ProductID;
                                    Deliver3.Text = Deliver3_int.ToString();

                                }
                                product p4 = content.products.First(i => i.ProductName == productIID4);
                                if (p4 != null)
                                {
                                    int Deliver4_int = p4.ProductID;
                                    Deliver4.Text = Deliver4_int.ToString();

                                }
                                product p5 = content.products.First(i => i.ProductName == productIID5);
                                if (p5 != null)
                                {
                                    int Deliver5_int = p5.ProductID;
                                    Deliver5.Text = Deliver5_int.ToString();

                                }


                            }
                            if (productIID6 != "")


                            {


                                product p1 = content.products.First(i => i.ProductName == productIID1);

                                if (p1 != null)
                                {
                                    int Deliver1_int = p1.ProductID;
                                    Deliver1.Text = Deliver1_int.ToString();

                                }
                                product p2 = content.products.First(i => i.ProductName == productIID2);
                                if (p2 != null)
                                {
                                    int Deliver2_int = p2.ProductID;
                                    Deliver2.Text = Deliver2_int.ToString();

                                }
                                product p3 = content.products.First(i => i.ProductName == productIID3);
                                if (p3 != null)
                                {
                                    int Deliver3_int = p3.ProductID;
                                    Deliver3.Text = Deliver3_int.ToString();

                                }
                                product p4 = content.products.First(i => i.ProductName == productIID4);
                                if (p4 != null)
                                {
                                    int Deliver4_int = p4.ProductID;
                                    Deliver4.Text = Deliver4_int.ToString();

                                }
                                product p5 = content.products.First(i => i.ProductName == productIID5);
                                if (p5 != null)
                                {
                                    int Deliver5_int = p5.ProductID;
                                    Deliver5.Text = Deliver5_int.ToString();

                                }
                                product p6 = content.products.First(i => i.ProductName == productIID6);
                                if (p6 != null)
                                {
                                    int Deliver6_int = p6.ProductID;
                                    Deliver6.Text = Deliver6_int.ToString();

                                }

                            }
                            if (productIID7 != "")


                            {


                                product p1 = content.products.First(i => i.ProductName == productIID1);

                                if (p1 != null)
                                {
                                    int Deliver1_int = p1.ProductID;
                                    Deliver1.Text = Deliver1_int.ToString();

                                }
                                product p2 = content.products.First(i => i.ProductName == productIID2);
                                if (p2 != null)
                                {
                                    int Deliver2_int = p2.ProductID;
                                    Deliver2.Text = Deliver2_int.ToString();

                                }
                                product p3 = content.products.First(i => i.ProductName == productIID3);
                                if (p3 != null)
                                {
                                    int Deliver3_int = p3.ProductID;
                                    Deliver3.Text = Deliver3_int.ToString();

                                }
                                product p4 = content.products.First(i => i.ProductName == productIID4);
                                if (p4 != null)
                                {
                                    int Deliver4_int = p4.ProductID;
                                    Deliver4.Text = Deliver4_int.ToString();

                                }
                                product p5 = content.products.First(i => i.ProductName == productIID5);
                                if (p5 != null)
                                {
                                    int Deliver5_int = p5.ProductID;
                                    Deliver5.Text = Deliver5_int.ToString();

                                }
                                product p6 = content.products.First(i => i.ProductName == productIID6);
                                if (p6 != null)
                                {
                                    int Deliver6_int = p6.ProductID;
                                    Deliver6.Text = Deliver6_int.ToString();

                                }
                                product p7 = content.products.First(i => i.ProductName == productIID7);
                                if (p7 != null)
                                {
                                    int Deliver7_int = p7.ProductID;
                                    Deliver7.Text = Deliver7_int.ToString();

                                }

                            }
                            if (productIID8 != "")


                            {


                                product p1 = content.products.First(i => i.ProductName == productIID1);

                                if (p1 != null)
                                {
                                    int Deliver1_int = p1.ProductID;
                                    Deliver1.Text = Deliver1_int.ToString();

                                }
                                product p2 = content.products.First(i => i.ProductName == productIID2);
                                if (p2 != null)
                                {
                                    int Deliver2_int = p2.ProductID;
                                    Deliver2.Text = Deliver2_int.ToString();

                                }
                                product p3 = content.products.First(i => i.ProductName == productIID3);
                                if (p3 != null)
                                {
                                    int Deliver3_int = p3.ProductID;
                                    Deliver3.Text = Deliver3_int.ToString();

                                }
                                product p4 = content.products.First(i => i.ProductName == productIID4);
                                if (p4 != null)
                                {
                                    int Deliver4_int = p4.ProductID;
                                    Deliver4.Text = Deliver4_int.ToString();

                                }
                                product p5 = content.products.First(i => i.ProductName == productIID5);
                                if (p5 != null)
                                {
                                    int Deliver5_int = p5.ProductID;
                                    Deliver5.Text = Deliver5_int.ToString();

                                }
                                product p6 = content.products.First(i => i.ProductName == productIID6);
                                if (p6 != null)
                                {
                                    int Deliver6_int = p6.ProductID;
                                    Deliver6.Text = Deliver6_int.ToString();

                                }
                                product p7 = content.products.First(i => i.ProductName == productIID7);
                                if (p7 != null)
                                {
                                    int Deliver7_int = p7.ProductID;
                                    Deliver7.Text = Deliver7_int.ToString();

                                }
                                product p8 = content.products.First(i => i.ProductName == productIID8);
                                if (p8 != null)
                                {
                                    int Deliver8_int = p8.ProductID;
                                    Deliver8.Text = Deliver8_int.ToString();

                                }

                            }
                            if (productIID9 != "")


                            {


                                product p1 = content.products.First(i => i.ProductName == productIID1);

                                if (p1 != null)
                                {
                                    int Deliver1_int = p1.ProductID;
                                    Deliver1.Text = Deliver1_int.ToString();

                                }
                                product p2 = content.products.First(i => i.ProductName == productIID2);
                                if (p2 != null)
                                {
                                    int Deliver2_int = p2.ProductID;
                                    Deliver2.Text = Deliver2_int.ToString();

                                }
                                product p3 = content.products.First(i => i.ProductName == productIID3);
                                if (p3 != null)
                                {
                                    int Deliver3_int = p3.ProductID;
                                    Deliver3.Text = Deliver3_int.ToString();

                                }
                                product p4 = content.products.First(i => i.ProductName == productIID4);
                                if (p4 != null)
                                {
                                    int Deliver4_int = p4.ProductID;
                                    Deliver4.Text = Deliver4_int.ToString();

                                }
                                product p5 = content.products.First(i => i.ProductName == productIID5);
                                if (p5 != null)
                                {
                                    int Deliver5_int = p5.ProductID;
                                    Deliver5.Text = Deliver5_int.ToString();

                                }
                                product p6 = content.products.First(i => i.ProductName == productIID6);
                                if (p6 != null)
                                {
                                    int Deliver6_int = p6.ProductID;
                                    Deliver6.Text = Deliver6_int.ToString();

                                }
                                product p7 = content.products.First(i => i.ProductName == productIID7);
                                if (p7 != null)
                                {
                                    int Deliver7_int = p7.ProductID;
                                    Deliver7.Text = Deliver7_int.ToString();

                                }
                                product p8 = content.products.First(i => i.ProductName == productIID8);
                                if (p8 != null)
                                {
                                    int Deliver8_int = p8.ProductID;
                                    Deliver8.Text = Deliver8_int.ToString();

                                }
                                product p9 = content.products.First(i => i.ProductName == productIID9);
                                if (p9 != null)
                                {
                                    int Deliver9_int = p9.ProductID;
                                    Deliver9.Text = Deliver9_int.ToString();

                                }

                            }
                            if (productIID10 != "")


                            {


                                product p1 = content.products.First(i => i.ProductName == productIID1);

                                if (p1 != null)
                                {
                                    int Deliver1_int = p1.ProductID;
                                    Deliver1.Text = Deliver1_int.ToString();

                                }
                                product p2 = content.products.First(i => i.ProductName == productIID2);
                                if (p2 != null)
                                {
                                    int Deliver2_int = p2.ProductID;
                                    Deliver2.Text = Deliver2_int.ToString();

                                }
                                product p3 = content.products.First(i => i.ProductName == productIID3);
                                if (p3 != null)
                                {
                                    int Deliver3_int = p3.ProductID;
                                    Deliver3.Text = Deliver3_int.ToString();

                                }
                                product p4 = content.products.First(i => i.ProductName == productIID4);
                                if (p4 != null)
                                {
                                    int Deliver4_int = p4.ProductID;
                                    Deliver4.Text = Deliver4_int.ToString();

                                }
                                product p5 = content.products.First(i => i.ProductName == productIID5);
                                if (p5 != null)
                                {
                                    int Deliver5_int = p5.ProductID;
                                    Deliver5.Text = Deliver5_int.ToString();

                                }
                                product p6 = content.products.First(i => i.ProductName == productIID6);
                                if (p6 != null)
                                {
                                    int Deliver6_int = p6.ProductID;
                                    Deliver6.Text = Deliver6_int.ToString();

                                }
                                product p7 = content.products.First(i => i.ProductName == productIID7);
                                if (p7 != null)
                                {
                                    int Deliver7_int = p7.ProductID;
                                    Deliver7.Text = Deliver7_int.ToString();

                                }
                                product p8 = content.products.First(i => i.ProductName == productIID8);
                                if (p8 != null)
                                {
                                    int Deliver8_int = p8.ProductID;
                                    Deliver8.Text = Deliver8_int.ToString();

                                }
                                product p9 = content.products.First(i => i.ProductName == productIID9);
                                if (p9 != null)
                                {
                                    int Deliver9_int = p9.ProductID;
                                    Deliver9.Text = Deliver9_int.ToString();

                                }
                                product p10 = content.products.First(i => i.ProductName == productIID10);
                                if (p10 != null)
                                {
                                    int Deliver1_int = p10.ProductID;
                                    Deliver10.Text = Deliver1_int.ToString();

                                }

                            }
                            if (Deliver1.Text == "")
                            {
                                Deliver1.Text = "0";

                            }
                            if (Deliver2.Text == "")
                            {
                                Deliver2.Text = "0";

                            }
                            if (Deliver3.Text == "")
                            {
                                Deliver3.Text = "0";

                            }
                            if (Deliver4.Text == "")
                            {
                                Deliver4.Text = "0";

                            }
                            if (Deliver5.Text == "")
                            {
                                Deliver5.Text = "0";

                            }
                            if (Deliver6.Text == "")
                            {
                                Deliver6.Text = "0";

                            }
                            if (Deliver7.Text == "")
                            {
                                Deliver7.Text = "0";

                            }
                            if (Deliver8.Text == "")
                            {
                                Deliver8.Text = "0";

                            }
                            if (Deliver9.Text == "")
                            {
                                Deliver9.Text = "0";

                            }
                            if (Deliver10.Text == "")
                            {
                                Deliver10.Text = "0";

                            }
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



                            if (int.Parse(cb_count.Items[0].ToString()) >= 5)
                            {
                                //MessageBox.Show("The Time is Not Available");
                                cb_count.Items.Clear();
                                throw new IndexOutOfRangeException();

                            }
                            else if (int.Parse(cb_count.Items[0].ToString()) <= 4)
                            {
                                //  MessageBox.Show("The Time is Available");
                                cb_count.Items.Clear();
                            }
                            if (dateod.DayOfWeek == DayOfWeek.Sunday)
                            {
                                throw new KeyNotFoundException();

                            }
                            DateSystem.LicenseKey = "LostTimeIsNeverFoundAgain";
                            // var publicHolidays = DateSystem.GetPublicHolidays(2022, CountryCode.HK);
                            if (DateSystem.IsPublicHoliday(dateod, CountryCode.GB))
                            {
                                throw new InvalidCastException();

                            }
                            if (DateSystem.IsPublicHoliday(dateod, CountryCode.CN))
                            {
                                throw new InvalidCastException();

                            }
                            {
                                DateTime x = DateTime.Parse(date_delivery.SelectionRange.Start.ToString("yyyy-MM-dd"));
                                TimeSpan t = TimeSpan.Parse(cb_time.SelectedItem.ToString());

                                //deliveryorder deliveryorders = content.deliveryorders.First(i => i.DeliveryDate == x && i.timeofDelivery == t);
                                //  if (deliveryorders != null)
                                // {
                                //    txt_havesametime.Text = deliveryorders.DeliveryOrderID.ToString();


                                //}



                                //   if (cb_count.Text != "")
                                // {
                                //      if (int.Parse(cb_count.Text) >= 1)
                                //     {
                                //         throw new NotSupportedException();

                                //     }
                                // }
                                int sessionID = int.Parse(txt_SessionID.Text);
                                schedule schedules = content.schedules.First(i => i.dateofservice == dateod && i.SessionID == sessionID);
                                if (schedules != null)
                                {
                                    txt_DworkerID.Text = schedules.D_staffID.ToString();

                                }
                                time();
                                if (int.Parse(cb_countorder.Items[0].ToString()) != 0)
                                {
                                    throw new EvaluateException();
                                }


                                if (txt_havesametime.Text != "")
                                {

                                    throw new InsufficientExecutionStackException();

                                }
                                if (cb_CountSametime.Items.Count == 1)
                                {
                                    p1qty.Text = cb_CountSametime.Items[0].ToString();


                                }
                                if (cb_CountSametime.Items.Count == 2)
                                {
                                    p1qty.Text = cb_CountSametime.Items[0].ToString();
                                    p2qty.Text = cb_CountSametime.Items[1].ToString();

                                }
                                if (cb_CountSametime.Items.Count == 3)
                                {
                                    p1qty.Text = cb_CountSametime.Items[0].ToString();
                                    p2qty.Text = cb_CountSametime.Items[1].ToString();
                                    p3qty.Text = cb_CountSametime.Items[2].ToString();

                                }
                                if (cb_CountSametime.Items.Count == 4)
                                {
                                    p1qty.Text = cb_CountSametime.Items[0].ToString();
                                    p2qty.Text = cb_CountSametime.Items[1].ToString();
                                    p3qty.Text = cb_CountSametime.Items[2].ToString();
                                    p4qty.Text = cb_CountSametime.Items[3].ToString();

                                }
                                if (cb_CountSametime.Items.Count == 5)
                                {
                                    p1qty.Text = cb_CountSametime.Items[0].ToString();
                                    p2qty.Text = cb_CountSametime.Items[1].ToString();
                                    p3qty.Text = cb_CountSametime.Items[2].ToString();
                                    p4qty.Text = cb_CountSametime.Items[3].ToString();
                                    p5qty.Text = cb_CountSametime.Items[4].ToString();

                                }
                                if (cb_CountSametime.Items.Count == 6)
                                {
                                    p1qty.Text = cb_CountSametime.Items[0].ToString();
                                    p2qty.Text = cb_CountSametime.Items[1].ToString();
                                    p3qty.Text = cb_CountSametime.Items[2].ToString();
                                    p4qty.Text = cb_CountSametime.Items[3].ToString();
                                    p5qty.Text = cb_CountSametime.Items[4].ToString();
                                    p6qty.Text = cb_CountSametime.Items[5].ToString();

                                }
                                if (cb_CountSametime.Items.Count == 7)
                                {
                                    p1qty.Text = cb_CountSametime.Items[0].ToString();
                                    p2qty.Text = cb_CountSametime.Items[1].ToString();
                                    p3qty.Text = cb_CountSametime.Items[2].ToString();
                                    p4qty.Text = cb_CountSametime.Items[3].ToString();
                                    p5qty.Text = cb_CountSametime.Items[4].ToString();
                                    p6qty.Text = cb_CountSametime.Items[5].ToString();
                                    p7qty.Text = cb_CountSametime.Items[6].ToString();


                                }
                                if (cb_CountSametime.Items.Count == 8)
                                {
                                    p1qty.Text = cb_CountSametime.Items[0].ToString();
                                    p2qty.Text = cb_CountSametime.Items[1].ToString();
                                    p3qty.Text = cb_CountSametime.Items[2].ToString();
                                    p4qty.Text = cb_CountSametime.Items[3].ToString();
                                    p5qty.Text = cb_CountSametime.Items[4].ToString();
                                    p6qty.Text = cb_CountSametime.Items[5].ToString();
                                    p7qty.Text = cb_CountSametime.Items[6].ToString();
                                    p8qty.Text = cb_CountSametime.Items[7].ToString();


                                }
                                if (cb_CountSametime.Items.Count == 9)
                                {
                                    p1qty.Text = cb_CountSametime.Items[0].ToString();
                                    p2qty.Text = cb_CountSametime.Items[1].ToString();
                                    p3qty.Text = cb_CountSametime.Items[2].ToString();
                                    p4qty.Text = cb_CountSametime.Items[3].ToString();
                                    p5qty.Text = cb_CountSametime.Items[4].ToString();
                                    p6qty.Text = cb_CountSametime.Items[5].ToString();
                                    p7qty.Text = cb_CountSametime.Items[6].ToString();
                                    p8qty.Text = cb_CountSametime.Items[7].ToString();
                                    p9qty.Text = cb_CountSametime.Items[8].ToString();

                                }
                                if (cb_CountSametime.Items.Count == 10)
                                {
                                    p1qty.Text = cb_CountSametime.Items[0].ToString();
                                    p2qty.Text = cb_CountSametime.Items[1].ToString();
                                    p3qty.Text = cb_CountSametime.Items[2].ToString();
                                    p4qty.Text = cb_CountSametime.Items[3].ToString();
                                    p5qty.Text = cb_CountSametime.Items[4].ToString();
                                    p6qty.Text = cb_CountSametime.Items[5].ToString();
                                    p7qty.Text = cb_CountSametime.Items[6].ToString();
                                    p8qty.Text = cb_CountSametime.Items[7].ToString();
                                    p9qty.Text = cb_CountSametime.Items[8].ToString();
                                    p10qty.Text = cb_CountSametime.Items[9].ToString();
                                }
                                if (p1qty.Text == "")
                                {
                                    p1qty.Text = "0";

                                }
                                if (p2qty.Text == "")
                                {
                                    p2qty.Text = "0";

                                }
                                if (p3qty.Text == "")
                                {
                                    p3qty.Text = "0";

                                }
                                if (p4qty.Text == "")
                                {
                                    p4qty.Text = "0";

                                }
                                if (p5qty.Text == "")
                                {
                                    p5qty.Text = "0";

                                }
                                if (p6qty.Text == "")
                                {
                                    p6qty.Text = "0";

                                }
                                if (p7qty.Text == "")
                                {
                                    p7qty.Text = "0";

                                }
                                if (p8qty.Text == "")
                                {
                                    p8qty.Text = "0";

                                }
                                if (p9qty.Text == "")
                                {
                                    p9qty.Text = "0";

                                }
                                if (p10qty.Text == "")
                                {
                                    p10qty.Text = "0";

                                }





                                {
                                    deliveryorder delivers = new deliveryorder
                                    {

                                        DeliveryDate = dateod,
                                        DeliveryProductID_1 = int.Parse(Deliver1.Text),
                                        DeliveryProductID_2 = int.Parse(Deliver2.Text),
                                        DeliveryProductID_3 = int.Parse(Deliver3.Text),
                                        DeliveryProductID_4 = int.Parse(Deliver4.Text),
                                        DeliveryProductID_5 = int.Parse(Deliver5.Text),
                                        DeliveryProductID_6 = int.Parse(Deliver6.Text),
                                        DeliveryProductID_7 = int.Parse(Deliver7.Text),
                                        DeliveryProductID_8 = int.Parse(Deliver8.Text),
                                        DeliveryProductID_9 = int.Parse(Deliver9.Text),
                                        DeliveryProductID_10 = int.Parse(Deliver10.Text),
                                        DeliveryProductID_1qty = int.Parse(p1qty.Text),
                                        DeliveryProductID_2qty = int.Parse(p2qty.Text),
                                        DeliveryProductID_3qty = int.Parse(p3qty.Text),
                                        DeliveryProductID_4qty = int.Parse(p4qty.Text),
                                        DeliveryProductID_5qty = int.Parse(p5qty.Text),
                                        DeliveryProductID_6qty = int.Parse(p6qty.Text),
                                        DeliveryProductID_7qty = int.Parse(p7qty.Text),
                                        DeliveryProductID_8qty = int.Parse(p8qty.Text),
                                        DeliveryProductID_9qty = int.Parse(p9qty.Text),
                                        DeliveryProductID_10qty = int.Parse(p10qty.Text),
                                        timeofDelivery = TimeSpan.Parse(cb_time.SelectedItem.ToString()),
                                        SessionID = int.Parse(txt_SessionID.Text),
                                        D_Status = "Not Delivered",
                                        DWorkerID = int.Parse(txt_DworkerID.Text),
                                        OrderID = int.Parse(cb_order.SelectedItem.ToString())


                                    };




                                    content.deliveryorders.Add(delivers);
                                    content.SaveChanges();
                                    MessageBox.Show("Delivery Order Created");
                                    MessageBox.Show("Delivery Order" + delivers.DeliveryOrderID);
                                    txt_deliveryorder.Text = delivers.DeliveryOrderID.ToString();
                                    //   txt_date.Text = dateod.ToString();




                                }
                                {

                                    int sorder;
                                    sorder = int.Parse(cb_order.SelectedItem.ToString());
                                    int dorder;
                                    dorder = int.Parse(txt_deliveryorder.Text);


                                    {
                                        saleorder s = content.saleorders.First(i => i.orderID == sorder);
                                        if (s != null)
                                        {
                                            s.DeliveryOrderID = dorder;
                                        }
                                        content.SaveChanges();

                                    }

                                }
                                cb_order.Items.Clear();
                               
                            }
                        }
                    }
                    if (MessageBox.Show("Do Custumer Need Installation Service.", "Installation Service", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Interface_CreateInstallationOrder s = new Interface_CreateInstallationOrder();
                        //CreateDeliveryOrder.instance.lab1.Text = lab1.Text;
                        s.Show();

                    }
                }
           catch (NoNullAllowedException)
            {
                MessageBox.Show("Please Add At least One Item in the Delivery List");
            }
            catch (InvalidCastException) { MessageBox.Show("The Delivery Date Can not be Public Holiday Please Try Again"); }
                catch (EvaluateException) { MessageBox.Show("The Delivery Time already selected by others. Please Choose other Time and Try Again."); }
                catch (System.FormatException) { MessageBox.Show("The Order Can Not Be Null and Contain Any Special Characters Letter"); }
                catch (IndexOutOfRangeException) { MessageBox.Show("The Time is Unavailable. Please Select Again"); }
                catch (System.NullReferenceException) { MessageBox.Show("Please Select the Session and Time"); }
                catch (KeyNotFoundException) { MessageBox.Show("Sorry!The Day Can not be Sunday. Please Try Again."); }
                catch (NotSupportedException) { MessageBox.Show("The Time:" + cb_time.SelectedItem.ToString() + "    Is Already Been Selected. Please Try Again!"); }
            }
        






        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (lb_orderItem.Items.Count < 1)
                {
                    btn_add.Enabled = false;

                }
                else
                {
                    btn_add.Enabled = true;
                }
                if (lb_DeliverItems.Items.Count < 1)
                {
                    btn_remove.Enabled = false;

                }
                else
                {
                    btn_remove.Enabled = true;
                }

                if (lb_orderItem.Items.Count == 1)
                {
                    if (lb_orderItem.SelectedItem.ToString() == lb_orderItem.Items[0].ToString())
                    {
                        lb_DeliverItems.Items.Add(lb_orderItem.Items[0].ToString());
                        cb_CountSametime.Items.Add(lb_qty.Items[0].ToString());
                        lb_orderItem.Items.Remove(lb_orderItem.Items[0].ToString());
                        lb_qty.Items.Remove(lb_qty.Items[0].ToString());
                    }

                }
                if (lb_orderItem.Items.Count == 2)
                {
                    if (lb_orderItem.SelectedItem.ToString() == lb_orderItem.Items[0].ToString())
                    {
                        lb_DeliverItems.Items.Add(lb_orderItem.Items[0].ToString());
                        cb_CountSametime.Items.Add(lb_qty.Items[0].ToString());
                        lb_orderItem.Items.Remove(lb_orderItem.Items[0].ToString());
                        lb_qty.Items.Remove(lb_qty.Items[0].ToString());
                    }
                    else if (lb_orderItem.SelectedItem.ToString() == lb_orderItem.Items[1].ToString())
                    {
                        lb_DeliverItems.Items.Add(lb_orderItem.Items[1].ToString());
                        cb_CountSametime.Items.Add(lb_qty.Items[1].ToString());
                        lb_orderItem.Items.Remove(lb_orderItem.Items[1].ToString());
                        lb_qty.Items.Remove(lb_qty.Items[1].ToString());
                    }
                }
                if (lb_orderItem.Items.Count == 3)
                {
                    if (lb_orderItem.SelectedItem.ToString() == lb_orderItem.Items[0].ToString())
                    {
                        lb_DeliverItems.Items.Add(lb_orderItem.Items[0].ToString());
                        cb_CountSametime.Items.Add(lb_qty.Items[0].ToString());
                        lb_orderItem.Items.Remove(lb_orderItem.Items[0].ToString());
                        lb_qty.Items.Remove(lb_qty.Items[0].ToString());
                    }
                    else if (lb_orderItem.SelectedItem.ToString() == lb_orderItem.Items[1].ToString())
                    {
                        lb_DeliverItems.Items.Add(lb_orderItem.Items[1].ToString());
                        cb_CountSametime.Items.Add(lb_qty.Items[1].ToString());
                        lb_orderItem.Items.Remove(lb_orderItem.Items[1].ToString());
                        lb_qty.Items.Remove(lb_qty.Items[1].ToString());
                    }
                    else if (lb_orderItem.SelectedItem.ToString() == lb_orderItem.Items[2].ToString())
                    {
                        lb_DeliverItems.Items.Add(lb_orderItem.Items[2].ToString());
                        cb_CountSametime.Items.Add(lb_qty.Items[2].ToString());
                        lb_orderItem.Items.Remove(lb_orderItem.Items[2].ToString());
                        lb_qty.Items.Remove(lb_qty.Items[2].ToString());
                    }
                }
                if (lb_orderItem.Items.Count == 4)
                {
                    if (lb_orderItem.SelectedItem.ToString() == lb_orderItem.Items[0].ToString())
                    {
                        lb_DeliverItems.Items.Add(lb_orderItem.Items[0].ToString());
                        cb_CountSametime.Items.Add(lb_qty.Items[0].ToString());
                        lb_orderItem.Items.Remove(lb_orderItem.Items[0].ToString());
                        lb_qty.Items.Remove(lb_qty.Items[0].ToString());
                    }
                    else if (lb_orderItem.SelectedItem.ToString() == lb_orderItem.Items[1].ToString())
                    {
                        lb_DeliverItems.Items.Add(lb_orderItem.Items[1].ToString());
                        cb_CountSametime.Items.Add(lb_qty.Items[1].ToString());
                        lb_orderItem.Items.Remove(lb_orderItem.Items[1].ToString());
                        lb_qty.Items.Remove(lb_qty.Items[1].ToString());
                    }
                    else if (lb_orderItem.SelectedItem.ToString() == lb_orderItem.Items[2].ToString())
                    {
                        lb_DeliverItems.Items.Add(lb_orderItem.Items[2].ToString());
                        cb_CountSametime.Items.Add(lb_qty.Items[2].ToString());
                        lb_orderItem.Items.Remove(lb_orderItem.Items[2].ToString());
                        lb_qty.Items.Remove(lb_qty.Items[2].ToString());
                    }
                    else if (lb_orderItem.SelectedItem.ToString() == lb_orderItem.Items[3].ToString())
                    {
                        lb_DeliverItems.Items.Add(lb_orderItem.Items[3].ToString());
                        cb_CountSametime.Items.Add(lb_qty.Items[3].ToString());
                        lb_orderItem.Items.Remove(lb_orderItem.Items[3].ToString());
                        lb_qty.Items.Remove(lb_qty.Items[3].ToString());
                    }
                }
                if (lb_orderItem.Items.Count == 5)
                {
                    if (lb_orderItem.SelectedItem.ToString() == lb_orderItem.Items[0].ToString())
                    {
                        lb_DeliverItems.Items.Add(lb_orderItem.Items[0].ToString());
                        cb_CountSametime.Items.Add(lb_qty.Items[0].ToString());
                        lb_orderItem.Items.Remove(lb_orderItem.Items[0].ToString());
                        lb_qty.Items.Remove(lb_qty.Items[0].ToString());
                    }
                    else if (lb_orderItem.SelectedItem.ToString() == lb_orderItem.Items[1].ToString())
                    {
                        lb_DeliverItems.Items.Add(lb_orderItem.Items[1].ToString());
                        cb_CountSametime.Items.Add(lb_qty.Items[1].ToString());
                        lb_orderItem.Items.Remove(lb_orderItem.Items[1].ToString());
                        lb_qty.Items.Remove(lb_qty.Items[1].ToString());
                    }
                    else if (lb_orderItem.SelectedItem.ToString() == lb_orderItem.Items[2].ToString())
                    {
                        lb_DeliverItems.Items.Add(lb_orderItem.Items[2].ToString());
                        cb_CountSametime.Items.Add(lb_qty.Items[2].ToString());
                        lb_orderItem.Items.Remove(lb_orderItem.Items[2].ToString());
                        lb_qty.Items.Remove(lb_qty.Items[2].ToString());
                    }
                    else if (lb_orderItem.SelectedItem.ToString() == lb_orderItem.Items[3].ToString())
                    {
                        lb_DeliverItems.Items.Add(lb_orderItem.Items[3].ToString());
                        cb_CountSametime.Items.Add(lb_qty.Items[3].ToString());
                        lb_orderItem.Items.Remove(lb_orderItem.Items[3].ToString());
                        lb_qty.Items.Remove(lb_qty.Items[3].ToString());
                    }
                    else if (lb_orderItem.SelectedItem.ToString() == lb_orderItem.Items[4].ToString())
                    {
                        lb_DeliverItems.Items.Add(lb_orderItem.Items[4].ToString());
                        cb_CountSametime.Items.Add(lb_qty.Items[4].ToString());
                        lb_orderItem.Items.Remove(lb_orderItem.Items[4].ToString());
                        lb_qty.Items.Remove(lb_qty.Items[4].ToString());
                    }
                }
                if (lb_orderItem.Items.Count == 6)
                {
                    if (lb_orderItem.SelectedItem.ToString() == lb_orderItem.Items[0].ToString())
                    {
                        lb_DeliverItems.Items.Add(lb_orderItem.Items[0].ToString());
                        cb_CountSametime.Items.Add(lb_qty.Items[0].ToString());
                        lb_orderItem.Items.Remove(lb_orderItem.Items[0].ToString());
                        lb_qty.Items.Remove(lb_qty.Items[0].ToString());
                    }
                    else if (lb_orderItem.SelectedItem.ToString() == lb_orderItem.Items[1].ToString())
                    {
                        lb_DeliverItems.Items.Add(lb_orderItem.Items[1].ToString());
                        cb_CountSametime.Items.Add(lb_qty.Items[1].ToString());
                        lb_orderItem.Items.Remove(lb_orderItem.Items[1].ToString());
                        lb_qty.Items.Remove(lb_qty.Items[1].ToString());
                    }
                    else if (lb_orderItem.SelectedItem.ToString() == lb_orderItem.Items[2].ToString())
                    {
                        lb_DeliverItems.Items.Add(lb_orderItem.Items[2].ToString());
                        cb_CountSametime.Items.Add(lb_qty.Items[2].ToString());
                        lb_orderItem.Items.Remove(lb_orderItem.Items[2].ToString());
                        lb_qty.Items.Remove(lb_qty.Items[2].ToString());
                    }
                    else if (lb_orderItem.SelectedItem.ToString() == lb_orderItem.Items[3].ToString())
                    {
                        lb_DeliverItems.Items.Add(lb_orderItem.Items[3].ToString());
                        cb_CountSametime.Items.Add(lb_qty.Items[3].ToString());
                        lb_orderItem.Items.Remove(lb_orderItem.Items[3].ToString());
                        lb_qty.Items.Remove(lb_qty.Items[3].ToString());
                    }
                    else if (lb_orderItem.SelectedItem.ToString() == lb_orderItem.Items[4].ToString())
                    {
                        lb_DeliverItems.Items.Add(lb_orderItem.Items[4].ToString());
                        cb_CountSametime.Items.Add(lb_qty.Items[4].ToString());
                        lb_orderItem.Items.Remove(lb_orderItem.Items[4].ToString());
                        lb_qty.Items.Remove(lb_qty.Items[4].ToString());
                    }
                    else if (lb_orderItem.SelectedItem.ToString() == lb_orderItem.Items[5].ToString())
                    {
                        lb_DeliverItems.Items.Add(lb_orderItem.Items[5].ToString());
                        cb_CountSametime.Items.Add(lb_qty.Items[5].ToString());
                        lb_orderItem.Items.Remove(lb_orderItem.Items[5].ToString());
                        lb_qty.Items.Remove(lb_qty.Items[5].ToString());
                    }

                }
                if (lb_orderItem.Items.Count == 7)
                {
                    if (lb_orderItem.SelectedItem.ToString() == lb_orderItem.Items[0].ToString())
                    {
                        lb_DeliverItems.Items.Add(lb_orderItem.Items[0].ToString());
                        cb_CountSametime.Items.Add(lb_qty.Items[0].ToString());
                        lb_orderItem.Items.Remove(lb_orderItem.Items[0].ToString());
                        lb_qty.Items.Remove(lb_qty.Items[0].ToString());
                    }
                    else if (lb_orderItem.SelectedItem.ToString() == lb_orderItem.Items[1].ToString())
                    {
                        lb_DeliverItems.Items.Add(lb_orderItem.Items[1].ToString());
                        cb_CountSametime.Items.Add(lb_qty.Items[1].ToString());
                        lb_orderItem.Items.Remove(lb_orderItem.Items[1].ToString());
                        lb_qty.Items.Remove(lb_qty.Items[1].ToString());
                    }
                    else if (lb_orderItem.SelectedItem.ToString() == lb_orderItem.Items[2].ToString())
                    {
                        lb_DeliverItems.Items.Add(lb_orderItem.Items[2].ToString());
                        cb_CountSametime.Items.Add(lb_qty.Items[2].ToString());
                        lb_orderItem.Items.Remove(lb_orderItem.Items[2].ToString());
                        lb_qty.Items.Remove(lb_qty.Items[2].ToString());
                    }
                    else if (lb_orderItem.SelectedItem.ToString() == lb_orderItem.Items[3].ToString())
                    {
                        lb_DeliverItems.Items.Add(lb_orderItem.Items[3].ToString());
                        cb_CountSametime.Items.Add(lb_qty.Items[3].ToString());
                        lb_orderItem.Items.Remove(lb_orderItem.Items[3].ToString());
                        lb_qty.Items.Remove(lb_qty.Items[3].ToString());
                    }
                    else if (lb_orderItem.SelectedItem.ToString() == lb_orderItem.Items[4].ToString())
                    {
                        lb_DeliverItems.Items.Add(lb_orderItem.Items[4].ToString());
                        cb_CountSametime.Items.Add(lb_qty.Items[4].ToString());
                        lb_orderItem.Items.Remove(lb_orderItem.Items[4].ToString());
                        lb_qty.Items.Remove(lb_qty.Items[4].ToString());
                    }
                    else if (lb_orderItem.SelectedItem.ToString() == lb_orderItem.Items[5].ToString())
                    {
                        lb_DeliverItems.Items.Add(lb_orderItem.Items[5].ToString());
                        cb_CountSametime.Items.Add(lb_qty.Items[5].ToString());
                        lb_orderItem.Items.Remove(lb_orderItem.Items[5].ToString());
                        lb_qty.Items.Remove(lb_qty.Items[5].ToString());
                    }
                    else if (lb_orderItem.SelectedItem.ToString() == lb_orderItem.Items[6].ToString())
                    {
                        lb_DeliverItems.Items.Add(lb_orderItem.Items[6].ToString());
                        cb_CountSametime.Items.Add(lb_qty.Items[6].ToString());
                        lb_orderItem.Items.Remove(lb_orderItem.Items[6].ToString());
                        lb_qty.Items.Remove(lb_qty.Items[6].ToString());
                    }
                }
                if (lb_orderItem.Items.Count == 8)
                {
                    if (lb_orderItem.SelectedItem.ToString() == lb_orderItem.Items[0].ToString())
                    {
                        lb_DeliverItems.Items.Add(lb_orderItem.Items[0].ToString());
                        cb_CountSametime.Items.Add(lb_qty.Items[0].ToString());
                        lb_orderItem.Items.Remove(lb_orderItem.Items[0].ToString());
                        lb_qty.Items.Remove(lb_qty.Items[0].ToString());
                    }
                    else if (lb_orderItem.SelectedItem.ToString() == lb_orderItem.Items[1].ToString())
                    {
                        lb_DeliverItems.Items.Add(lb_orderItem.Items[1].ToString());
                        cb_CountSametime.Items.Add(lb_qty.Items[1].ToString());
                        lb_orderItem.Items.Remove(lb_orderItem.Items[1].ToString());
                        lb_qty.Items.Remove(lb_qty.Items[1].ToString());
                    }
                    else if (lb_orderItem.SelectedItem.ToString() == lb_orderItem.Items[2].ToString())
                    {
                        lb_DeliverItems.Items.Add(lb_orderItem.Items[2].ToString());
                        cb_CountSametime.Items.Add(lb_qty.Items[2].ToString());
                        lb_orderItem.Items.Remove(lb_orderItem.Items[2].ToString());
                        lb_qty.Items.Remove(lb_qty.Items[2].ToString());
                    }
                    else if (lb_orderItem.SelectedItem.ToString() == lb_orderItem.Items[3].ToString())
                    {
                        lb_DeliverItems.Items.Add(lb_orderItem.Items[3].ToString());
                        cb_CountSametime.Items.Add(lb_qty.Items[3].ToString());
                        lb_orderItem.Items.Remove(lb_orderItem.Items[3].ToString());
                        lb_qty.Items.Remove(lb_qty.Items[3].ToString());
                    }
                    else if (lb_orderItem.SelectedItem.ToString() == lb_orderItem.Items[4].ToString())
                    {
                        lb_DeliverItems.Items.Add(lb_orderItem.Items[4].ToString());
                        cb_CountSametime.Items.Add(lb_qty.Items[4].ToString());
                        lb_orderItem.Items.Remove(lb_orderItem.Items[4].ToString());
                        lb_qty.Items.Remove(lb_qty.Items[4].ToString());
                    }
                    else if (lb_orderItem.SelectedItem.ToString() == lb_orderItem.Items[5].ToString())
                    {
                        lb_DeliverItems.Items.Add(lb_orderItem.Items[5].ToString());
                        cb_CountSametime.Items.Add(lb_qty.Items[5].ToString());
                        lb_orderItem.Items.Remove(lb_orderItem.Items[5].ToString());
                        lb_qty.Items.Remove(lb_qty.Items[5].ToString());
                    }
                    else if (lb_orderItem.SelectedItem.ToString() == lb_orderItem.Items[6].ToString())
                    {
                        lb_DeliverItems.Items.Add(lb_orderItem.Items[6].ToString());
                        cb_CountSametime.Items.Add(lb_qty.Items[6].ToString());
                        lb_orderItem.Items.Remove(lb_orderItem.Items[6].ToString());
                        lb_qty.Items.Remove(lb_qty.Items[6].ToString());
                    }
                    else if (lb_orderItem.SelectedItem.ToString() == lb_orderItem.Items[7].ToString())
                    {
                        lb_DeliverItems.Items.Add(lb_orderItem.Items[7].ToString());
                        cb_CountSametime.Items.Add(lb_qty.Items[7].ToString());
                        lb_orderItem.Items.Remove(lb_orderItem.Items[7].ToString());
                        lb_qty.Items.Remove(lb_qty.Items[7].ToString());
                    }
                }
                if (lb_orderItem.Items.Count == 9)
                {
                    if (lb_orderItem.SelectedItem.ToString() == lb_orderItem.Items[0].ToString())
                    {
                        lb_DeliverItems.Items.Add(lb_orderItem.Items[0].ToString());
                        cb_CountSametime.Items.Add(lb_qty.Items[0].ToString());
                        lb_orderItem.Items.Remove(lb_orderItem.Items[0].ToString());
                        lb_qty.Items.Remove(lb_qty.Items[0].ToString());
                    }
                    else if (lb_orderItem.SelectedItem.ToString() == lb_orderItem.Items[1].ToString())
                    {
                        lb_DeliverItems.Items.Add(lb_orderItem.Items[1].ToString());
                        cb_CountSametime.Items.Add(lb_qty.Items[1].ToString());
                        lb_orderItem.Items.Remove(lb_orderItem.Items[1].ToString());
                        lb_qty.Items.Remove(lb_qty.Items[1].ToString());
                    }
                    else if (lb_orderItem.SelectedItem.ToString() == lb_orderItem.Items[2].ToString())
                    {
                        lb_DeliverItems.Items.Add(lb_orderItem.Items[2].ToString());
                        cb_CountSametime.Items.Add(lb_qty.Items[2].ToString());
                        lb_orderItem.Items.Remove(lb_orderItem.Items[2].ToString());
                        lb_qty.Items.Remove(lb_qty.Items[2].ToString());
                    }
                    else if (lb_orderItem.SelectedItem.ToString() == lb_orderItem.Items[3].ToString())
                    {
                        lb_DeliverItems.Items.Add(lb_orderItem.Items[3].ToString());
                        cb_CountSametime.Items.Add(lb_qty.Items[3].ToString());
                        lb_orderItem.Items.Remove(lb_orderItem.Items[3].ToString());
                        lb_qty.Items.Remove(lb_qty.Items[3].ToString());
                    }
                    else if (lb_orderItem.SelectedItem.ToString() == lb_orderItem.Items[4].ToString())
                    {
                        lb_DeliverItems.Items.Add(lb_orderItem.Items[4].ToString());
                        cb_CountSametime.Items.Add(lb_qty.Items[4].ToString());
                        lb_orderItem.Items.Remove(lb_orderItem.Items[4].ToString());
                        lb_qty.Items.Remove(lb_qty.Items[4].ToString());
                    }
                    else if (lb_orderItem.SelectedItem.ToString() == lb_orderItem.Items[5].ToString())
                    {
                        lb_DeliverItems.Items.Add(lb_orderItem.Items[5].ToString());
                        cb_CountSametime.Items.Add(lb_qty.Items[5].ToString());
                        lb_orderItem.Items.Remove(lb_orderItem.Items[5].ToString());
                        lb_qty.Items.Remove(lb_qty.Items[5].ToString());
                    }
                    else if (lb_orderItem.SelectedItem.ToString() == lb_orderItem.Items[6].ToString())
                    {
                        lb_DeliverItems.Items.Add(lb_orderItem.Items[6].ToString());
                        cb_CountSametime.Items.Add(lb_qty.Items[6].ToString());
                        lb_orderItem.Items.Remove(lb_orderItem.Items[6].ToString());
                        lb_qty.Items.Remove(lb_qty.Items[6].ToString());
                    }
                    else if (lb_orderItem.SelectedItem.ToString() == lb_orderItem.Items[7].ToString())
                    {
                        lb_DeliverItems.Items.Add(lb_orderItem.Items[7].ToString());
                        cb_CountSametime.Items.Add(lb_qty.Items[7].ToString());
                        lb_orderItem.Items.Remove(lb_orderItem.Items[7].ToString());
                        lb_qty.Items.Remove(lb_qty.Items[7].ToString());
                    }
                    else if (lb_orderItem.SelectedItem.ToString() == lb_orderItem.Items[8].ToString())
                    {
                        lb_DeliverItems.Items.Add(lb_orderItem.Items[8].ToString());
                        cb_CountSametime.Items.Add(lb_qty.Items[8].ToString());
                        lb_orderItem.Items.Remove(lb_orderItem.Items[8].ToString());
                        lb_qty.Items.Remove(lb_qty.Items[8].ToString());
                    }
                }
                if (lb_orderItem.Items.Count == 10)
                {
                    if (lb_orderItem.SelectedItem.ToString() == lb_orderItem.Items[0].ToString())
                    {
                        lb_DeliverItems.Items.Add(lb_orderItem.Items[0].ToString());
                        cb_CountSametime.Items.Add(lb_qty.Items[0].ToString());
                        lb_orderItem.Items.Remove(lb_orderItem.Items[0].ToString());
                        lb_qty.Items.Remove(lb_qty.Items[0].ToString());
                    }
                    else if (lb_orderItem.SelectedItem.ToString() == lb_orderItem.Items[1].ToString())
                    {
                        lb_DeliverItems.Items.Add(lb_orderItem.Items[1].ToString());
                        cb_CountSametime.Items.Add(lb_qty.Items[1].ToString());
                        lb_orderItem.Items.Remove(lb_orderItem.Items[1].ToString());
                        lb_qty.Items.Remove(lb_qty.Items[1].ToString());
                    }
                    else if (lb_orderItem.SelectedItem.ToString() == lb_orderItem.Items[2].ToString())
                    {
                        lb_DeliverItems.Items.Add(lb_orderItem.Items[2].ToString());
                        cb_CountSametime.Items.Add(lb_qty.Items[2].ToString());
                        lb_orderItem.Items.Remove(lb_orderItem.Items[2].ToString());
                        lb_qty.Items.Remove(lb_qty.Items[2].ToString());
                    }
                    else if (lb_orderItem.SelectedItem.ToString() == lb_orderItem.Items[3].ToString())
                    {
                        lb_DeliverItems.Items.Add(lb_orderItem.Items[3].ToString());
                        cb_CountSametime.Items.Add(lb_qty.Items[3].ToString());
                        lb_orderItem.Items.Remove(lb_orderItem.Items[3].ToString());
                        lb_qty.Items.Remove(lb_qty.Items[3].ToString());
                    }
                    else if (lb_orderItem.SelectedItem.ToString() == lb_orderItem.Items[4].ToString())
                    {
                        lb_DeliverItems.Items.Add(lb_orderItem.Items[4].ToString());
                        cb_CountSametime.Items.Add(lb_qty.Items[4].ToString());
                        lb_orderItem.Items.Remove(lb_orderItem.Items[4].ToString());
                        lb_qty.Items.Remove(lb_qty.Items[4].ToString());
                    }
                    else if (lb_orderItem.SelectedItem.ToString() == lb_orderItem.Items[5].ToString())
                    {
                        lb_DeliverItems.Items.Add(lb_orderItem.Items[5].ToString());
                        cb_CountSametime.Items.Add(lb_qty.Items[5].ToString());
                        lb_orderItem.Items.Remove(lb_orderItem.Items[5].ToString());
                        lb_qty.Items.Remove(lb_qty.Items[5].ToString());
                    }
                    else if (lb_orderItem.SelectedItem.ToString() == lb_orderItem.Items[6].ToString())
                    {
                        lb_DeliverItems.Items.Add(lb_orderItem.Items[6].ToString());
                        cb_CountSametime.Items.Add(lb_qty.Items[6].ToString());
                        lb_orderItem.Items.Remove(lb_orderItem.Items[6].ToString());
                        lb_qty.Items.Remove(lb_qty.Items[6].ToString());
                    }
                    else if (lb_orderItem.SelectedItem.ToString() == lb_orderItem.Items[7].ToString())
                    {
                        lb_DeliverItems.Items.Add(lb_orderItem.Items[7].ToString());
                        cb_CountSametime.Items.Add(lb_qty.Items[7].ToString());
                        lb_orderItem.Items.Remove(lb_orderItem.Items[7].ToString());
                        lb_qty.Items.Remove(lb_qty.Items[7].ToString());
                    }
                    else if (lb_orderItem.SelectedItem.ToString() == lb_orderItem.Items[8].ToString())
                    {
                        lb_DeliverItems.Items.Add(lb_orderItem.Items[8].ToString());
                        cb_CountSametime.Items.Add(lb_qty.Items[8].ToString());
                        lb_orderItem.Items.Remove(lb_orderItem.Items[8].ToString());
                        lb_qty.Items.Remove(lb_qty.Items[8].ToString());
                    }
                    else if (lb_orderItem.SelectedItem.ToString() == lb_orderItem.Items[9].ToString())
                    {
                        lb_DeliverItems.Items.Add(lb_orderItem.Items[9].ToString());
                        cb_CountSametime.Items.Add(lb_qty.Items[9].ToString());
                        lb_orderItem.Items.Remove(lb_orderItem.Items[9].ToString());
                        lb_qty.Items.Remove(lb_qty.Items[9].ToString());
                    }
                }
            }
            catch (NullReferenceException) {
                MessageBox.Show("Not Selected Any Product");
            }


        }



        private void date_delivery_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            txt_DworkerID.Panels[0].Text = DateTime.Now.ToString("hh:mm:tt");
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_SaleOrder_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_test_Click(object sender, EventArgs e)
        {


        }

        private void cb_order_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Create_delivery_Load(object sender, EventArgs e)
        {
            lb_qty.Enabled = false;
            date_delivery.MinDate = DateTime.Now;
            date_delivery.MaxDate = DateTime.Now.AddDays(7);
            add2Store();
            // TODO: This line of code loads data into the 'betterlimitedDataSet5.saleorder' table. You can move, or remove it, as needed.
          //  this.saleorderTableAdapter.Fill(this.betterlimitedDataSet5.saleorder);
            //  comboBox_deliverytime.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Regionp.DropDownStyle = ComboBoxStyle.DropDownList;

            //  comboBox_deliverytime.Enabled = false;
            txt_PhoneNumber.Enabled = false;
            txt_cname.Enabled = false;
            cb_StoreName.Enabled = false;
            add2Time();
            // DateTime startdate = new DateTime(DateTime.Now);
            //DateTime enddate = new DateTime(2022,05,30);
            // date_delivery.SelectionRange
            cb_order.DropDownStyle = ComboBoxStyle.DropDownList;
          
        }

        private void lb_DeliveryOrderItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                cb_Regionp.Enabled = false;
                txt_cname.Enabled = true;
                txt_PhoneNumber.Enabled = false;
                cb_StoreName.Enabled = false;
            }
            else
            {


            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {

                using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())

                {
                    int cid;
                    customer customers = content.customers.First(i => i.FirstName == txt_cname.Text);
                    if (customers != null)
                    {

                        cid = customers.CustomerID;
                        txt_cid.Text = cid.ToString();

                    }
                    int cid_int = int.Parse(txt_cid.Text);
                    dataGridView1.DataSource = db.saleorders.Where(x => x.CustomerID == cid_int).ToList();
                }



            }
            if (radioButton2.Checked)
            {
                using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                {
                    string phonenumber = txt_PhoneNumber.Text;
                    customer customers = content.customers.First(i => i.Phone1 == phonenumber || i.Phone2 == phonenumber);
                    int cid;
                    if (customers != null)
                    {

                        cid = customers.CustomerID;
                        txt_cid.Text = cid.ToString();

                    }
                    int cid_int = int.Parse(txt_cid.Text);
                    dataGridView1.DataSource = db.saleorders.Where(x => x.CustomerID == cid_int).ToList();
                }




            }
            if (radioButton3.Checked)
            {
                using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                {
                    string storename = cb_StoreName.SelectedItem.ToString();
                    store stores = content.stores.First(i => i.StoreName == storename);
                    if (stores != null)
                    {
                        int sid = stores.StoreID;
                        txt_storeID.Text = sid.ToString();

                    }
                    int storeID = int.Parse(txt_storeID.Text);
                    dataGridView1.DataSource = db.saleorders.Where(x => x.storeID == storeID).ToList();


                }


            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                txt_cname.Enabled = false;
                txt_PhoneNumber.Enabled = true;


            }
            else
            {
                cb_StoreName.Enabled = false;
                txt_PhoneNumber.Enabled = false;


            }



        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                cb_StoreName.Enabled = true;
                txt_cname.Enabled = false;
                txt_PhoneNumber.Enabled = false;


            }
            else
            {
                txt_cname.Enabled = false;
                txt_PhoneNumber.Enabled = false;


            }

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }




        private void date_delivery_DateChanged(object sender, DateRangeEventArgs e)
        {
            // date_delivery.d
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                cb_Regionp.Enabled = true;
                txt_cname.Enabled = false;
                txt_PhoneNumber.Enabled = true;
                cb_StoreName.Enabled = false;


            }
            else
            {


            }

        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                cb_Regionp.Enabled = false;
                cb_StoreName.Enabled = true;
                txt_cname.Enabled = false;
                txt_PhoneNumber.Enabled = false;


            }
            else
            {



            }

        }

        private void CreateDeliveryOrder_Load(object sender, EventArgs e)
        {
            try {
                using (var content = new betterlimitedEntities_Test1())
                {
                    {

                        var emp = (from list in content.saleorders
                                   where list.DeliveryOrderID == null
                                   select list);



                        foreach (var emp2 in emp.ToList())
                        {
                            customer customers = content.customers.First(i => i.CustomerID == emp2.CustomerID);
                            if (customers != null)
                            {

                                dataGridView1.Rows.Add(emp2.orderID, emp2.Date_Of_Purchase, emp2.TotalCharge, customers.FirstName, customers.Phone1);
                            }

                        }
                        for (int x = 0; x < dataGridView1.RowCount; x++) {
                            cb_order.Items.Add(dataGridView1.Rows[x].Cells[0].Value.ToString());
                        }
                    



                    }

                }





                if (lb_orderItem.Items.Count < 1)
                {
                    btn_add.Enabled = false;

                }
                else
                {
                    btn_add.Enabled = true;
                }
                if (lb_DeliverItems.Items.Count < 1)
                {
                    btn_remove.Enabled = false;

                }
                else
                {
                    btn_remove.Enabled = true;
                }
                cb_Regionp.DropDownStyle = ComboBoxStyle.DropDownList;
                lb_qty.Enabled = false;

                DateTime lastDay = new DateTime(DateTime.Now.Year, 12, 31);
                date_delivery.MinDate = DateTime.Now;
                date_delivery.MaxDate = lastDay;
                add2Store();
                // TODO: This line of code loads data into the 'betterlimitedDataSet5.saleorder' table. You can move, or remove it, as needed.
                //this.saleorderTableAdapter.Fill(this.betterlimitedDataSet5.saleorder);
                // comboBox_deliverytime.DropDownStyle = ComboBoxStyle.DropDownList;
                cb_StoreName.DropDownStyle = ComboBoxStyle.DropDownList;
                cb_session.DropDownStyle = ComboBoxStyle.DropDownList;
                cb_time.DropDownStyle = ComboBoxStyle.DropDownList;
                // comboBox_deliverytime.Enabled = false;
                txt_PhoneNumber.Enabled = false;
                txt_cname.Enabled = false;
                cb_StoreName.Enabled = false;
                add2Time();
                // DateTime startdate = new DateTime(DateTime.Now);
                //DateTime enddate = new DateTime(2022,05,30);
                // date_delivery.SelectionRange
                cb_order.DropDownStyle = ComboBoxStyle.DropDownList;
               
                addSession();
            }
            catch (System.InvalidOperationException) { }
            }
            
            

        private void btn_remove_Click(object sender, EventArgs e)

        {
            if (lb_orderItem.Items.Count < 1)
            {
                btn_add.Enabled = false;

            }
            else
            {
                btn_add.Enabled = true;
            }
            if (lb_DeliverItems.Items.Count < 1)
            {
                btn_remove.Enabled = false;

            }
            else
            {
                btn_remove.Enabled = true;
            }

            try
            {
                if (lb_DeliverItems.Items.Count == 1)
                {
                    if (lb_DeliverItems.SelectedItem.ToString() == lb_DeliverItems.Items[0].ToString())
                    {
                        lb_orderItem.Items.Add(lb_DeliverItems.Items[0].ToString());
                        lb_qty.Items.Add(cb_CountSametime.Items[0].ToString());
                        lb_DeliverItems.Items.Remove(lb_DeliverItems.Items[0].ToString());
                        cb_CountSametime.Items.Remove(cb_CountSametime.Items[0].ToString());
                    }

                }
                if (lb_DeliverItems.Items.Count == 2)
                {
                    for (int x = 0; x <= 1; x++)
                    {
                        if (lb_DeliverItems.SelectedItem.ToString() == lb_DeliverItems.Items[x].ToString())
                        {
                            lb_orderItem.Items.Add(lb_DeliverItems.Items[x].ToString());
                            lb_qty.Items.Add(cb_CountSametime.Items[x].ToString());
                            lb_DeliverItems.Items.Remove(lb_DeliverItems.Items[x].ToString());
                            cb_CountSametime.Items.Remove(cb_CountSametime.Items[x].ToString());
                        }
                    }
                }
                if (lb_DeliverItems.Items.Count == 3)
                {
                    for (int x = 0; x <= 2; x++)
                    {
                        if (lb_DeliverItems.SelectedItem.ToString() == lb_DeliverItems.Items[x].ToString())
                        {
                            lb_orderItem.Items.Add(lb_DeliverItems.Items[x].ToString());
                            lb_qty.Items.Add(cb_CountSametime.Items[x].ToString());
                            lb_DeliverItems.Items.Remove(lb_DeliverItems.Items[x].ToString());
                            cb_CountSametime.Items.Remove(cb_CountSametime.Items[x].ToString());
                        }
                    }
                }
                if (lb_DeliverItems.Items.Count == 4)
                {
                    for (int x = 0; x <= 3; x++)
                    {
                        if (lb_DeliverItems.SelectedItem.ToString() == lb_DeliverItems.Items[x].ToString())
                        {
                            lb_orderItem.Items.Add(lb_DeliverItems.Items[x].ToString());
                            lb_qty.Items.Add(cb_CountSametime.Items[x].ToString());
                            lb_DeliverItems.Items.Remove(lb_DeliverItems.Items[x].ToString());
                            cb_CountSametime.Items.Remove(cb_CountSametime.Items[x].ToString());
                        }
                    }
                }
                if (lb_DeliverItems.Items.Count == 5)
                {
                    for (int x = 0; x <= 4; x++)
                    {
                        if (lb_DeliverItems.SelectedItem.ToString() == lb_DeliverItems.Items[x].ToString())
                        {
                            lb_orderItem.Items.Add(lb_DeliverItems.Items[x].ToString());
                            lb_qty.Items.Add(cb_CountSametime.Items[x].ToString());
                            lb_DeliverItems.Items.Remove(lb_DeliverItems.Items[x].ToString());
                            cb_CountSametime.Items.Remove(cb_CountSametime.Items[x].ToString());
                        }
                    }
                }
                if (lb_DeliverItems.Items.Count == 6)
                {
                    for (int x = 0; x <= 5; x++)
                    {
                        if (lb_DeliverItems.SelectedItem.ToString() == lb_DeliverItems.Items[x].ToString())
                        {
                            lb_orderItem.Items.Add(lb_DeliverItems.Items[x].ToString());
                            lb_qty.Items.Add(cb_CountSametime.Items[x].ToString());
                            lb_DeliverItems.Items.Remove(lb_DeliverItems.Items[x].ToString());
                            cb_CountSametime.Items.Remove(cb_CountSametime.Items[x].ToString());
                        }
                    }
                }
                if (lb_DeliverItems.Items.Count == 7)
                {
                    for (int x = 0; x <= 6; x++)
                    {
                        if (lb_DeliverItems.SelectedItem.ToString() == lb_DeliverItems.Items[x].ToString())
                        {
                            lb_orderItem.Items.Add(lb_DeliverItems.Items[x].ToString());
                            lb_qty.Items.Add(cb_CountSametime.Items[x].ToString());
                            lb_DeliverItems.Items.Remove(lb_DeliverItems.Items[x].ToString());
                            cb_CountSametime.Items.Remove(cb_CountSametime.Items[x].ToString());
                        }
                    }
                }
                if (lb_DeliverItems.Items.Count == 8)
                {
                    for (int x = 0; x <= 7; x++)
                    {
                        if (lb_DeliverItems.SelectedItem.ToString() == lb_DeliverItems.Items[x].ToString())
                        {
                            lb_orderItem.Items.Add(lb_DeliverItems.Items[x].ToString());
                            lb_qty.Items.Add(cb_CountSametime.Items[x].ToString());
                            lb_DeliverItems.Items.Remove(lb_DeliverItems.Items[x].ToString());
                            cb_CountSametime.Items.Remove(cb_CountSametime.Items[x].ToString());
                        }
                    }
                }
                if (lb_DeliverItems.Items.Count == 9)
                {
                    for (int x = 0; x <= 8; x++)
                    {
                        if (lb_DeliverItems.SelectedItem.ToString() == lb_DeliverItems.Items[x].ToString())
                        {
                            lb_orderItem.Items.Add(lb_DeliverItems.Items[x].ToString());
                            lb_qty.Items.Add(cb_CountSametime.Items[x].ToString());
                            lb_DeliverItems.Items.Remove(lb_DeliverItems.Items[x].ToString());
                            cb_CountSametime.Items.Remove(cb_CountSametime.Items[x].ToString());
                        }
                    }
                }
                if (lb_DeliverItems.Items.Count == 10)
                {
                    for (int x = 0; x <= 9; x++)
                    {
                        if (lb_DeliverItems.SelectedItem.ToString() == lb_DeliverItems.Items[x].ToString())
                        {
                            lb_orderItem.Items.Add(lb_DeliverItems.Items[x].ToString());
                            lb_qty.Items.Add(cb_CountSametime.Items[x].ToString());
                            lb_DeliverItems.Items.Remove(lb_DeliverItems.Items[x].ToString());
                            cb_CountSametime.Items.Remove(cb_CountSametime.Items[x].ToString());
                        }
                    }

                }
            }
            catch (NullReferenceException) { }








        }

        private void lb_orderItem_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lb_orderItem.Items.Count < 1)
            {
                btn_add.Enabled = false;

            }
            else
            {
                btn_add.Enabled = true;
            }
            if (lb_DeliverItems.Items.Count < 1)
            {
                btn_remove.Enabled = false;

            }
            else
            {
                btn_remove.Enabled = true;
            }
        }

        private void btn_searchorder_Click(object sender, EventArgs e)
        {
                try
                {
                if (MessageBox.Show("All Unsaved Information Will Be Lost", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    lb_orderItem.Items.Clear();
                    lb_DeliverItems.Items.Clear();
                    lb_qty.Items.Clear();
                    cb_CountSametime.Items.Clear();
                    if (radioButton1.Checked)
                    {
                        string cname = txt_cname.Text;
                        dataGridView1.Rows.Clear();
                        cb_order.Items.Clear();
                        using (var content = new betterlimitedEntities_Test1())
                        {
                            {

                                var emp = (from list in content.saleorders
                                           where list.DeliveryOrderID == null
                                           select list);



                                foreach (var emp2 in emp.ToList())
                                {

                                    customer customers = content.customers.First(i => i.FirstName == cname);
                                    if (customers != null)
                                    {

                                        dataGridView1.Rows.Add(emp2.orderID, emp2.Date_Of_Purchase, emp2.TotalCharge, customers.FirstName, customers.Phone1);
                                    }
                                    for (int x = 0; x < dataGridView1.RowCount; x++)
                                    {
                                        cb_order.Items.Add(dataGridView1.Rows[x].Cells[0].Value.ToString());
                                    }

                                }
                            }


                        }
                    }


                    if (radioButton2.Checked)
                    {
                        dataGridView1.Rows.Clear();
                        using (var content = new betterlimitedEntities_Test1())
                        {
                            string phone = cb_Regionp.SelectedItem.ToString() + txt_PhoneNumber.Text;
                            {

                                var emp = (from list in content.saleorders
                                           where list.DeliveryOrderID == null
                                           select list);



                                foreach (var emp2 in emp.ToList())
                                {

                                    customer customers = content.customers.First(i => i.Phone1 == phone || i.Phone2 == phone);
                                    if (customers != null)
                                    {

                                        dataGridView1.Rows.Add(emp2.orderID, emp2.Date_Of_Purchase, emp2.TotalCharge, customers.FirstName, customers.Phone1);
                                    }
                                }
                            }


                        }
                    }
                    if (radioButton3.Checked)

                    {
                        dataGridView1.Rows.Clear();
                        using (var content = new betterlimitedEntities_Test1())
                        {
                            string storename = cb_StoreName.SelectedItem.ToString();
                            store stores = content.stores.First(i => i.StoreName == storename);
                            if (stores != null)
                            {
                                txt_storeID.Text = stores.StoreID.ToString();



                            }
                            {
                                int storeID = int.Parse(txt_storeID.Text);

                                var emp = (from list in content.saleorders
                                           where list.DeliveryOrderID == null && list.storeID == storeID
                                           select list);



                                foreach (var emp2 in emp.ToList())
                                {

                                    customer customers = content.customers.First(i => i.CustomerID == emp2.CustomerID);
                                    if (customers != null)
                                    {

                                        dataGridView1.Rows.Add(emp2.orderID, emp2.Date_Of_Purchase, emp2.TotalCharge, customers.FirstName, customers.Phone1);
                                    }
                                }
                            }


                        }



                    }
                }
                }
                
            catch (System.NullReferenceException) { MessageBox.Show("Please Fill in The Searching Target That You Want to Search"); }
            catch (System.InvalidOperationException)
            {

                MessageBox.Show("There is No Result With The Information That You Provided");
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
            {
                store stores = content.stores.First(i => i.StoreID == 1);
                if (stores != null)
                {
                    string storename = stores.StoreName;
                }
            }

        }

        private void cb_Regionp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_PhoneNumber_TextChanged(object sender, EventArgs e)
        {
       
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void dateTimePicker_d_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            cb_count.Items.Clear();
            DateTime dateod = DateTime.Parse(date_delivery.SelectionRange.Start.ToString("yyyy-MM-dd"));
            if (cb_session.SelectedItem.ToString() == "Morning")
            {
                txt_SessionID.Text = "1";
            }
            if (cb_session.SelectedItem.ToString() == "Afternoon")
            {
                txt_SessionID.Text = "2";
            }
            if (cb_session.SelectedItem.ToString() == "Evening")
            {
                txt_SessionID.Text = "3";
            }



            if (int.Parse(cb_count.Items[0].ToString()) >= 5)
            {
                MessageBox.Show("The Time is Not Available");
            }
            else if (int.Parse(cb_count.Items[0].ToString()) <= 4)
            {
                MessageBox.Show("The Time is Available");
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txt_havesametime_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_Regionp_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cb_Regionp.SelectedItem.ToString() == "+852")
            {
                txt_PhoneNumber.MaxLength = 8;


            }
            else if (cb_Regionp.SelectedItem.ToString() == "+86") {

                txt_PhoneNumber.MaxLength = 11;
            }
        }

        private void txt_phonenum_keypress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cb_order_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}










