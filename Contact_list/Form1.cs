using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_list
{
    public partial class Form1 : Form
    {
        DataTable table;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //set columns name and value types
            table = new DataTable();
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Phone", typeof(int));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("Type", typeof(string));



            contacts_data.DataSource = table;

            //default values
            table.Rows.Add("Pedro", 9558447, "pedro@as.com", "Friend");
            table.Rows.Add("Rafa", 9447, "pedro@as.com", "Work");
            table.Rows.Add("Pedro", 9547, "pedro@as.com", "Family");
            table.Rows.Add("Pedro", 9687, "pedro@as.com", "Friend");

        }

        private void Add_contact_Click(object sender, EventArgs e)
        {
            table.Rows.Add(Name_text.Text, Phone_text.Text, Email_text.Text, Type_menu.Text);
            Name_text.Clear();
            Phone_text.Clear();
            Email_text.Clear();
        }

        private void Clear_Text_Click(object sender, EventArgs e)
        {
            Clear_Text.Text = "Clear";
            Name_text.Clear();
            Phone_text.Clear();
            Email_text.Clear();
            Name_text.ReadOnly = false;
            Phone_text.ReadOnly = false;
            Email_text.ReadOnly = false;
        }

        private void Show_contact_Click(object sender, EventArgs e)
        {
            Clear_Text.Text = "New contact";
            

            //know index of selected row
            int index = contacts_data.CurrentCell.RowIndex;
            if (index > -1)
            {
                Name_text.Text = table.Rows[index]["Name"].ToString();
                Phone_text.Text = table.Rows[index]["Phone"].ToString();
                Email_text.Text = table.Rows[index]["Email"].ToString();
                Type_menu.Text = table.Rows[index]["Type"].ToString();

            }
        }

        private void Delete_contact_Click(object sender, EventArgs e)
        {
            //know index of selected row
            int index = contacts_data.CurrentCell.RowIndex;
            if (index > -1)
            {
                table.Rows[index].Delete();

            }
        }

        private void Edit_contact_Click(object sender, EventArgs e)
        {
            
            //know index of selected row
            int index = contacts_data.CurrentCell.RowIndex;
            if (index > -1)
            {
                table.Rows[index]["Name"] = Name_text.Text;
                table.Rows[index]["Phone"] = Phone_text.Text;
                table.Rows[index]["Email"] = Email_text.Text;
                table.Rows[index]["Type"] = Type_menu.Text;


            }
        }
        
    }
}
