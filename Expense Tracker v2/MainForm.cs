using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expense_Tracker_v2
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            initilizeHover();

            dashboardv21.Visible = true;
            expenseModal1.Visible = false;
            incomeModal1.Visible = false;
            categoryyyForm1.Visible = false;
            incomeForm1.Visible = false;
            expensesForm1.Visible = false;
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Loginn login = new Loginn();
                login.Show();

                this.Hide();
            }
        }

        private void bunifuFormControlBox2_MouseHover(object sender, EventArgs e)
        {

        }
        void initilizeHover()
        {
            button1.MouseEnter += button1_MouseEnter;
            button1.MouseLeave += button1_MouseLeave;

            button2.MouseEnter += button2_MouseEnter;
            button2.MouseLeave += button2_MouseLeave;

            button3.MouseEnter += button3_MouseEnter;
            button3.MouseLeave += button3_MouseLeave;

            logout_btn.MouseEnter += button4_MouseEnter;
            logout_btn.MouseLeave += button4_MouseLeave;

            button5.MouseEnter += button5_MouseEnter;
            button5.MouseLeave += button5_MouseLeave;
        }
        private void button4_MouseEnter(object sender, EventArgs e)
        {
            logout_btn.BackColor = Color.White;
            logout_btn.ForeColor = Color.FromArgb(76, 175, 80);
            logout_btn.Image = Image.FromFile(@"C:\CODING\OOP\Expense Tracker v2\Assets\logout_green.png");
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            logout_btn.BackColor = Color.FromArgb(76, 175, 80);
            logout_btn.ForeColor = Color.Transparent; // Or any other default color
            logout_btn.Image = Image.FromFile(@"C:\CODING\OOP\Expense Tracker v2\Assets\logout.png");
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button1.ForeColor = Color.FromArgb(76, 175, 80);
            button1.Image = Image.FromFile(@"C:\CODING\OOP\Expense Tracker v2\Assets\Dashboard.png");
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(76, 175, 80);
            button1.ForeColor = Color.Transparent; // Or any other default color
            button1.Image = Image.FromFile(@"C:\CODING\OOP\Expense Tracker v2\Assets\Dashboard1.png");
        }
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
            button2.ForeColor = Color.FromArgb(76, 175, 80);
            button2.Image = Image.FromFile(@"C:\CODING\OOP\Expense Tracker v2\Assets\category_green.png");
            
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(76, 175, 80);
            button2.ForeColor = Color.Transparent; // Or any other default color
            button2.Image = Image.FromFile(@"C:\CODING\OOP\Expense Tracker v2\Assets\category.png");

        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.White;
            button3.ForeColor = Color.FromArgb(76, 175, 80);
            button3.Image = Image.FromFile(@"C:\CODING\OOP\Expense Tracker v2\Assets\income_green.png");
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(76, 175, 80);
            button3.ForeColor = Color.Transparent; // Or any other default color
            button3.Image = Image.FromFile(@"C:\CODING\OOP\Expense Tracker v2\Assets\income.png");
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackColor = Color.White;
            button5.ForeColor = Color.FromArgb(76, 175, 80);
            button5.Image = Image.FromFile(@"C:\CODING\OOP\Expense Tracker v2\Assets\expenses_green.png");
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.FromArgb(76, 175, 80);
            button5.ForeColor = Color.Transparent; // Or any other default color
            button5.Image = Image.FromFile(@"C:\CODING\OOP\Expense Tracker v2\Assets\expenses.png");
            
        }

        private void bunifuChartCanvas1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            dashboardv21.Visible = true;
            categoryyyForm1.Visible = false;
            incomeForm1.Visible = false;
            expensesForm1.Visible = false;

            Dashboardv2 dashboard = dashboardv21 as Dashboardv2;
            
            if(dashboard != null)
            {
                dashboard.refreshData();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            dashboardv21.Visible = false;
            categoryyyForm1.Visible = true;
            incomeForm1.Visible = false;
            expensesForm1.Visible = false;

            CategoryyyForm categoryyy = categoryyyForm1 as CategoryyyForm;
            if (categoryyy != null)
            {
                categoryyy.refreshData();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            dashboardv21.Visible = false;
            categoryyyForm1.Visible = false;
            incomeForm1.Visible = true;
            expensesForm1.Visible = false;

            IncomeForm incomeF = incomeForm1 as IncomeForm;
            if (incomeF != null)
            {
                incomeF.refreshData();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            dashboardv21.Visible = false;
            categoryyyForm1.Visible = false;
            incomeForm1.Visible = false;
            expensesForm1.Visible = true;

            ExpensesForm expensesF = expensesForm1 as ExpensesForm;
            if (expensesF != null)
            {
                expensesF.refreshData();
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Confirm user wants to close
            switch (MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    break;
            }
        }

        

        
    }
}
