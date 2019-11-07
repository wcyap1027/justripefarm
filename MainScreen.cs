using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Multi_Form_and_Panel
{
    public partial class MainScreen : Form
    {
       

        public MainScreen()
        {
            InitializeComponent();
        }

        

        private void MainScreen_Load(object sender, EventArgs e)
        {
            btnShopWholesale.Text = "Shop / " + Environment.NewLine + "Wholesale";

            panel3.Hide();
            panel1.Hide();
            panel2.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();

            panel3.Width = 852;
            panel3.Height = 386;
            panel3.Location = new Point(2, 134);
            panel1.Width = 852;
            panel1.Height = 386;
            panel1.Location = new Point(2, 134);
            panel2.Width = 852;
            panel2.Height = 386;
            panel2.Location = new Point(2, 134);
            panel4.Width = 852;
            panel4.Height = 386;
            panel4.Location = new Point(2, 134);
            panel5.Width = 852;
            panel5.Height = 386;
            panel5.Location = new Point(2, 134);
            panel6.Width = 852;
            panel6.Height = 386;
            panel6.Location = new Point(2, 134);

        }

        private void btnNewJob_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
        }

        private void btnStocks_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Show();
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
        }
        private void btnFarm_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            panel3.Show();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
        }

        private void btnLabourer_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Show();
            panel5.Hide();
            panel6.Hide();
            DBConnector dBConn = new DBConnector();
            dBConn.connect();
            LabourerHandler labHnd = new LabourerHandler();
            //labourerGridView.DataSource = labHnd.BindSource();
            labourerGridView.DataSource = labHnd.getAllLabourer(dBConn.getConn());
            
        }

        private void btnMachines_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            panel5.Show();
            panel6.Hide();
        }

        private void btnShopWholesale_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Show();
        }

        private void addLabourerBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(labourerNameTextBox.Text))
            {
                MessageBox.Show("Please enter the name of labourer");
                return;
            }

            if (String.IsNullOrEmpty(ageTextBox.Text))
            {
                MessageBox.Show("Please enter the age of labourer");
                return;
            }

            if(genderComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select the gender");
                return;
            }

            if (String.IsNullOrEmpty(startWorkDate.Text))
            {
                MessageBox.Show("Please select Start Work Date");
                return;
            }

            if (String.IsNullOrEmpty(endWorkDate.Text))
            {
                MessageBox.Show("Please select End Work Date");
                return;
            }

            DBConnector dBConn = new DBConnector();
            dBConn.connect();

            Labourer labr = new Labourer();
            labr.Name = labourerNameTextBox.Text;
            labr.Age = int.Parse(ageTextBox.Text);
            labr.Gender = genderComboBox.SelectedItem.ToString();
            labr.StartDate = startWorkDate.Text;
            labr.EndDate = endWorkDate.Text;

            LabourerHandler labHnd = new LabourerHandler();
            int recordCnt = labHnd.addNewLabourer(dBConn.getConn(), labr);
            MessageBox.Show(recordCnt + "record has been inserted!!");
            labourerGridView.DataSource = labHnd.getAllLabourer(dBConn.getConn());

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            labourerNameTextBox.Text = "";
            ageTextBox.Text = "";
            genderComboBox.Text = "";
        }


        private void ageTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
                MessageBox.Show("Only accept number");
            }
        }
    }
}
