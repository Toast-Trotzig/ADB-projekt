using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADB_projekt
{
    public partial class Form1 : Form
    {
        Errorhandler eh = new Errorhandler();
        Dal dal = new Dal();
        Controller controller = new Controller();
        public Form1()
        {
            InitializeComponent();
            dal.FindAllCars(dataGridView1);
        }

        private void Book_btn_Click(object sender, EventArgs e)
        {
            try
            {  
                if (Name_Box.Text.Equals("") || Pnr_Box.Text.Equals("") || Email_Box.Text.Equals("") || Phone_box.Text.Equals(""))
                {
                    throw new MandatoryFieldException();
                }
                Customer cust = new Customer(int.Parse(Pnr_Box.Text), Name_Box.Text, Email_Box.Text, Phone_box.Text);
                Dictionary<string, object> entity = Utensils.Utils.GetParameters(cust);

                controller.HandleEnitity("CustomerCRUD", entity, "Insert");

                String str = CarModelsView.SelectedRows[0].Cells["RegNr"].Value.ToString();
                Book booking = new Book(int.Parse(Pnr_Box.Text), str, BookDateCalendar.SelectionStart);
            }
            catch(Exception ex)
            {
                Response_lbl.Text = eh.HandleException(ex);
            }


        }

        private void comboBox_class_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.FindCarModels(comboBox_class.SelectedItem.ToString(), CarModelsView);
        }
    }
}
