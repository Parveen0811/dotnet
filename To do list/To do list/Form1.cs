using System.Data;

namespace To_do_list
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable todolist = new DataTable();
        bool isediting = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            todolist.Columns.Add("Title");
            dataGridView.DataSource = todolist;
        }

        private void newbutton_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
        }

        private void editbutton_Click(object sender, EventArgs e)
        {
            isediting = true;
            textBox.Text = todolist.Rows[dataGridView.CurrentCell.RowIndex].ItemArray[0].ToString();

        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                todolist.Rows[dataGridView.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
            }
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            if (isediting)
            {
                todolist.Rows[dataGridView.CurrentCell.RowIndex]["Title"] = textBox.Text;
            }
            else
            {
                todolist.Rows.Add(textBox.Text);
            }
            textBox.Text = "";
            isediting = false;
        }
    }
}
