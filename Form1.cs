/* Created by Bryan Le
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BLeHW6._1
{
    public partial class Form1 : Form
    {
        private List<Employee> Roster = new List<Employee>();
        public Form1 ( )
        {
            InitializeComponent();
        }

        private void submitButton_Click ( object sender, EventArgs e )
        {
            //Declarations 
            String name;
            int hoursWorked;
            decimal salary;
            Employee newEmployee;

            //Inputs

            name = textBox1.Text;
            salary = decimal.Parse(textBox2.Text);
            hoursWorked = int.Parse(textBox3.Text);

            //Instantiation
            newEmployee = new Employee(name, hoursWorked, salary);

            //add to list
            Roster.Add(newEmployee);

            //Outputs
            textBox4.AppendText(newEmployee.ToString() + "\n");

            //Get Ready For New Input
            GetReadyForNewInput();

        }

        private void GetReadyForNewInput ( )
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }

        private void summaryButton_Click ( object sender, EventArgs e )
        {
            textBox4.AppendText(Employee.Summary() + "\n");
        }

        private void resetButton_Click ( object sender, EventArgs e )
        {
            ResetForm();
            Roster.Clear();
            Employee.Reset();
        }

        private void exitButton_Click ( object sender, EventArgs e )
        {
            Application.Exit();
            Roster.Clear();
        }


        private void ResetForm ( )
        {
            textBox4.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();

        }

        private void displayButton_Click ( object sender, EventArgs e )
        {
            textBox4.AppendText("\n");
            textBox4.AppendText("_____________________");
            textBox4.AppendText("\n");

            foreach (Employee pupil in Roster)
            { //repeating actions
                textBox4.AppendText(pupil.Display() + "\n");
            }
            textBox4.AppendText("\n");
            textBox4.AppendText("_____________________");
            textBox4.AppendText("\n");
        }
        
    }
}
