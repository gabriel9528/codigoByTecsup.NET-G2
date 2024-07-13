using System.ComponentModel;

namespace NotifyPropertyChangedd
{
    public partial class Form1 : Form
    {
        public BindingList<Customer> CustomerList { get; set; }

        public Form1()
        {
            InitializeComponent();
            CustomerList = new BindingList<Customer>
            {
                new Customer { Name = "Gabriel Retamozo", Age = 42 },
                new Customer { Name = "Jorge Manrique", Age = 19 },
            };

            dataGridView1.DataSource = CustomerList;

            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            if(CustomerList.Count > 0)
            {
                textBox1.DataBindings.Add("Text", CustomerList, "Name");
                textBox2.DataBindings.Add("Text", CustomerList, "Age");
            }

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow != null)
            {
                Customer customer = (Customer)dataGridView1.CurrentRow.DataBoundItem as Customer;
                textBox1.DataBindings.Clear();
                textBox2.DataBindings.Clear();

                textBox1.DataBindings.Add("Text", customer, "Name");
                textBox2.DataBindings.Add("Text", customer, "Age");
            }
        }
    }
}
