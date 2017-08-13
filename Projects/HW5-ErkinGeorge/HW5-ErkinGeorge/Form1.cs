using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HW5_ErkinGeorge
{
    public partial class bagelForm : Form
    {
        public bagelForm()
        {
            InitializeComponent();
        }

        //event handler for when the exit tool strip menu is clicked
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(bagelListBox.Items.Count > 0)//checks if the list is empty and exits if this is the case
            {
                //Temporary variable to handle data of user input
                var confirmationThing = MessageBox.Show("Do you want to save?", "Exit Screen", MessageBoxButtons.YesNo);
                //If user input is yes, data is saved via private method
                if (confirmationThing == DialogResult.Yes)
                {
                    saveData();
                }
                else if (confirmationThing == DialogResult.No) //if the user says no, the program exits
                    this.Close();
            }
            this.Close();
        }
        //private method to save data so as to not use an event handler from within another one
        private void saveData()
        {
            //Temp variables to manage data
            StreamWriter saveBagelStream;
            int i;
            //sets the save filters
            saveFile.Filter = "Text Files (*.txt)|.*txt|All files (*.)|*.*";
            saveFile.InitialDirectory = "C:\\Program Files";
            saveFile.Title = "Select File to continue";
            //try catch statement to save the data
            try
            {
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    saveBagelStream = File.CreateText(saveFile.FileName + ".txt");
                }
                else
                {
                    return;
                }
                //add if statement here that will take care of empty files
                for (i = 0; i < bagelListBox.Items.Count; ++i)
                {
                    saveBagelStream.WriteLine(bagelListBox.Items[i]);
                }
                saveBagelStream.Close();
            }
            catch (Exception fileEx)
            {
                MessageBox.Show(openAndLoad.FileName, fileEx.Message, MessageBoxButtons.OK);
            }
        }

        //Private class to open and load in files, not allowing for duplicate strings
        private void openAndLoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            //Stream item
            StreamReader bagelStream;
            //String to manage data
            String fileData;

            //Preps the opening
            openAndLoad.Filter = "Text Files (*.txt)|*.txt|All files(*.)|*.*";
            openAndLoad.InitialDirectory = "C:\\Program Files";
            openAndLoad.Title = "Select File to Open";
            //Try catch statement to make sure the program doesn't crash
            try
            {
                //If the user clicks the ok button
                if(openAndLoad.ShowDialog() == DialogResult.OK)
                {
                    bagelStream = File.OpenText(openAndLoad.FileName);//Loads the appropriate file
                }
                else
                {
                    return;
                }

                //Assumes opening file was success, clears out old data
                bagelListBox.Items.Clear();
                while (bagelStream.EndOfStream == false)
                {
                    fileData = bagelStream.ReadLine();
                    //Makes sure to not add duplicates
                    if (!bagelListBox.Items.Contains(fileData))
                    {
                        bagelListBox.Items.Add(fileData);
                    }
                }
                //Sets focuus to first item
                bagelListBox.Focus();
                if(bagelListBox.Items.Count > 0)
                bagelListBox.SelectedIndex = 0;
            }
            catch//Catch statement to prevent errors
            {
                MessageBox.Show("Error, please make sure you are opening a .txt file with appropriate data.");
            }

        }
        //Event handler for addbagel 
        private void addBagelTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //deal with duplicates
            if (!bagelListBox.Items.Contains(bagelTextBox.Text) && bagelTextBox.Text != "")
            {
                bagelListBox.Items.Add(bagelTextBox.Text); //Adds the item
                bagelTextBox.Clear();
            }
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Temporary variables to manage data
            StreamWriter saveBagelStream;
            int i;
            //Sets the saving filters
            saveFile.Filter = "Text Files (*.txt)|.*txt|All files (*.)|*.*";
            saveFile.InitialDirectory = "C:\\Program Files";
            saveFile.Title = "Select File to continue";
            //try catch statement to safely run code
            try
            {
                if(saveFile.ShowDialog() == DialogResult.OK)//detects user input
                {
                    saveBagelStream = File.CreateText(saveFile.FileName + ".txt");
                }
                else
                {
                    return;
                }
                //add if statement here that will take care of empty files
                for(i = 0; i < bagelListBox.Items.Count; ++i)
                {
                    saveBagelStream.WriteLine(bagelListBox.Items[i]);   
                }
                saveBagelStream.Close();
            } 
            catch(Exception fileEx)
            {
                MessageBox.Show(openAndLoad.FileName, fileEx.Message, MessageBoxButtons.OK);
            }
        }

        //event handler for removing bagels via the stripmenu
        private void removeBagelTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {   //does not remove bagels if there are none
                if (bagelListBox.Items.Count <= 0)
                {
                    MessageBox.Show("You cannot remove items from a box with no items.","Empty");
                }
                else if (bagelListBox.SelectedItem == null)//requires the user to select an item to remove
                {
                    MessageBox.Show("Please select an item in the list to remove");
                }             
                else
                {
                    bagelListBox.Items.RemoveAt(bagelListBox.SelectedIndex);//removes selected item
                    if (bagelListBox.Items.Count > 0)
                    {
                        bagelListBox.SetSelected(0, true);//sets the focus to the first item
                    }
                    else
                        MessageBox.Show("The list of bagels is empty.","Empty");
                }
            }
            catch
            {
                MessageBox.Show("Please selecte an item to remove");
            }
        }

        //event handler to clear away the list
        private void clearListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var clickResult = MessageBox.Show("Are you sure you want to clear the list?", "Clear list", MessageBoxButtons.OKCancel); //checks if clearing the list is ok with the user
            if (clickResult == DialogResult.OK)
            {
                bagelListBox.Items.Clear();//Doesn't matter if the list is empty, this operation runs anyway
                bagelTextBox.Clear();
            }
            else
                return;
        }

        //event handler to count bagels 
        private void countBagelTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int numberOfBagels; //int to keep track of number of bagels
            string howMany = ""; //string for output data
            numberOfBagels = bagelListBox.Items.Count; //counts the number of bagels
            howMany = "There are " + numberOfBagels.ToString() + " bagels in the list";//formatting string
            MessageBox.Show(howMany,"How many bagles");//outputs data       
        }

        //event handler for about button 
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutBagels showAbout = new aboutBagels();//creates about object for display
            showAbout.Show();
        }

        //event handler for the add bagel menustrip
        private void openAndAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Stream item
            StreamReader bagelStream;
            //String to manage data
            String fileData;

            //Preps the opening
            openAndLoad.Filter = "Text Files (*.txt)|*.txt|All files(*.)|*.*";
            openAndLoad.InitialDirectory = "C:\\Program Files";
            openAndLoad.Title = "Select File to Open";
            //try catch statement to run code safely 
            try
            {
                if (openAndLoad.ShowDialog() == DialogResult.OK)//checks the button clicked
                {
                    bagelStream = File.OpenText(openAndLoad.FileName);
                }
                else
                {
                    return;
                }

                //Assumes opening file was success
                while (bagelStream.EndOfStream == false)
                {
                    fileData = bagelStream.ReadLine();
                    //Makes sure to not add duplicates
                    if (!bagelListBox.Items.Contains(fileData))
                    {
                        bagelListBox.Items.Add(fileData);
                    }
                }
                //Sets focuus to first item
                bagelListBox.Focus();
                bagelListBox.SelectedIndex = 0;
            }
            catch//make sure the catch errors are comprehesive
            {
                MessageBox.Show("Please make sure the file contains at least one item.");
            }
        }
    }
}
