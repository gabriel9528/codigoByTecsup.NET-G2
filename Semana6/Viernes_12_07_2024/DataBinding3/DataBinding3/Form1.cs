using System.Xml.Linq;

namespace DataBinding3
{
    public partial class Form1 : Form
    {
        public List<Customer> CustomerList;
        public Form1()
        {
            InitializeComponent();
            CustomerList = new List<Customer>
            {
                new Customer { Nombre = "Gabriel" , Edad = 25 },
                new Customer { Nombre = "Juan" , Edad = 30 },
            };

            dataGridView1.DataSource = CustomerList;

            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            if(CustomerList.Count > 0)
            {
                textBox1.DataBindings.Add("Text", CustomerList[0], "Nombre");
                textBox2.DataBindings.Add("Text", CustomerList[0], "Edad");
            }


        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow != null)
            {
                Customer selectedCustomer = dataGridView1.CurrentRow.DataBoundItem as Customer;

                textBox1.DataBindings.Clear();
                textBox2.DataBindings.Clear();

                textBox1.DataBindings.Add("Text", selectedCustomer, "Nombre");
                textBox2.DataBindings.Add("Text", selectedCustomer, "Edad");
            }
        }
    }
}
