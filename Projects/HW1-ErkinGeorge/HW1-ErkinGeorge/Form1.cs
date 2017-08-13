using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW1_ErkinGeorge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chefButton_Click(object sender, EventArgs e)
        {
            //Sets the spaghetti lable and box to visible
            foodLabel.Text = "Today's special is Spaghetti, for $5.99";
            foodLabel.Visible = true;
            specialPic.Visible = true;

            //Sets the fish lable and box to not visible
            pictureFish.Visible = false;

            //Sets the soup lable and box to not visible
            pictureSoup.Visible = false;

        }

        private void fishButton_Click(object sender, EventArgs e)
        {
            //Sets the Spaghetti lable and box to not visible
            specialPic.Visible = false;

            //Sets the fish lable and box to visible
            foodLabel.Text = "Today's special is Fish, for $9.99";
            foodLabel.Visible = true;
            pictureFish.Visible = true;

            //Sets the soup lable and box to not visible
            pictureSoup.Visible = false;
        }

        private void soupButton_Click(object sender, EventArgs e)
        {
            //Sets the spaghetti lable and box to not visible
            specialPic.Visible = false;

            //Sets the fish lable and box to not visible
            pictureFish.Visible = false;

            //Sets the soup lable and box to visible
            foodLabel.Text = "Today's special is Lentil Soup, for $6.99";
            foodLabel.Visible = true;
            pictureSoup.Visible = true;
        }
    }
}
