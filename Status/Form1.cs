using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Status
{
    public partial class StudentStatus : Form
    {
        public StudentStatus()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnWhatStatus_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(txtCredits.Text, out double credits)) 
            { 
                
                // TODo figure out the status here
                if (credits >=12)
                {
                    lblStatus.Text = "Full time";
                }

                else if (credits >= 6)
                {
                    lblStatus.Text = "Half time";
                }

                else if (credits >= 0)
                {
                    lblStatus.Text = "Less than half time";
                }

                else
                {
                    MessageBox.Show("Enter a positive number", "Error");
                }



            }

            else
            {
                MessageBox.Show("Enter a number", "Error");
            }
        }

        
        

        

    }
}
