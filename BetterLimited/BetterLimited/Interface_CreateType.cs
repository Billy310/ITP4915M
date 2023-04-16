using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterLimited
{
    public partial class Interface_CreateType : Form
    {
        public Interface_CreateType()
        {
            InitializeComponent();
        }

        private void CreateType_Load(object sender, EventArgs e)
        {

        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
           // try
           // {
                if (txt_Typename.Text != "")
                {
                    using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                    {
                        type types = new type
                        {
                            TypeName = txt_Typename.Text
                            //LowStockLevel = int.Parse(lowstocklevel_count.Value.ToString())



                        };
                        content.types.Add(types);
                        content.SaveChanges();
                        MessageBox.Show("TypeName   " + types.TypeName + "  Is Added");
                    }
                }
                else { throw new FormatException(); }
            //}
            //catch (FormatException) { MessageBox.Show("The Type Cannot be Space"); }
            //catch (System.Data.Entity.Infrastructure.DbUpdateException) { MessageBox.Show("There is Already Has the Typename:" + txt_Typename.Text + "  Please Check The type is New or already Existed"); }
        }

    }
}
