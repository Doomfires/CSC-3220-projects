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
            currentDataName.Text = DateTime.Today.ToString("D");
        }

        //Movement of event handler code into functions to be called by the menu and tool strip menu
        private void exitFunct()
        {
            if (bagelListBox.Items.Count > 0)//checks if the list is empty and exits if this is the case
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


        private void addBagelFunct()
        {
            //deal with duplicates
            if (!bagelListBox.Items.Contains(bagelTextBox.Text) && bagelTextBox.Text != "")
            {
                bagelListBox.Items.Add(bagelTextBox.Text); //Adds the item
                bagelTextBox.Clear();
            }
        }


        private void openAndLoadFunct()
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
                if (openAndLoad.ShowDialog() == DialogResult.OK)
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
                if (bagelListBox.Items.Count > 0)
                    bagelListBox.SelectedIndex = 0;
            }
            catch//Catch statement to prevent errors
            {
                MessageBox.Show("Error, please make sure you are opening a .txt file with appropriate data.");
            }

            recentFileName.Text = openAndLoad.FileName;
        }

        private void saveFileFunct()
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
                if (saveFile.ShowDialog() == DialogResult.OK)//detects user input
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

            recentFileName.Text = openAndLoad.FileName;
        }

        private void removeBagelFunct()
        {
            try
            {   //does not remove bagels if there are none
                if (bagelListBox.Items.Count <= 0)
                {
                    MessageBox.Show("You cannot remove items from a box with no items.", "Empty");
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
                        MessageBox.Show("The list of bagels is empty.", "Empty");
                }
            }
            catch
            {
                MessageBox.Show("Please selecte an item to remove");
            }
        }


        private void clearListFunct()
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



        private void countBagelFunct()
        {
            int numberOfBagels; //int to keep track of number of bagels
            string howMany = ""; //string for output data
            numberOfBagels = bagelListBox.Items.Count; //counts the number of bagels
            howMany = "There are " + numberOfBagels.ToString() + " bagels in the list";//formatting string
            MessageBox.Show(howMany, "How many bagles");//outputs data
        }

        private void aboutFunct()
        {
            aboutBagels showAbout = new aboutBagels();//creates about object for display
            showAbout.Show();
        }


        private void openAndAddFunct()
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

            recentFileName.Text = openAndLoad.FileName;
        }

        //--------------------------------------------------------------------------------------------------------------------------------
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

        //---------------------------------------------------------------------------------------------------------

        //event handler for when the exit tool strip menu is clicked
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exitFunct();
        }

        //Private class to open and load in files, not allowing for duplicate strings
        private void openAndLoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openAndLoadFunct();
        }
        //Event handler for addbagel 
        private void addBagelTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addBagelFunct();
        }
        //event handler for savefile
        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

            saveFileFunct();  
        }

        //event handler for removing bagels via the stripmenu
        private void removeBagelTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeBagelFunct();
        }

        //event handler to clear away the list
        private void clearListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearListFunct();
        }

        //event handler to count bagels 
        private void countBagelTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            countBagelFunct();
        }

        //event handler for about button 
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutFunct();
        }

        //event handler for the add bagel menustrip
        private void openAndAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openAndAddFunct();
        }
        //event handler for open and load button
        private void openLoadStripButton_Click(object sender, EventArgs e)
        {
            openAndLoadFunct();
        }
        //event handler for open and add button
        private void openAddStripButton_Click(object sender, EventArgs e)
        {
            openAndAddFunct();
        }
        //event handler for save file 
        private void saveFileButton_Click(object sender, EventArgs e)
        {
            saveFileFunct();
        }
        //event handler for add bagel button
        private void addBagelButton_Click(object sender, EventArgs e)
        {
            addBagelFunct();
        }
        //event handler for remove bagel button
        private void removeBagelButton_Click(object sender, EventArgs e)
        {
            removeBagelFunct();
        }
        //event handler for count bagel button
        private void countBagelButton_Click(object sender, EventArgs e)
        {
            countBagelFunct();
        }
        //event handler for clear button list
        private void clearListButton_Click(object sender, EventArgs e)
        {
            clearListFunct();
        }
        //event handler for about button click
        private void aboutButton_Click(object sender, EventArgs e)
        {
            aboutFunct();
        }
        //event handler for right click 
        private void listFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bagelFontDialogue.ShowApply = true;
            bagelFontDialogue.MinSize = 10;
            bagelFontDialogue.MaxSize = 48;
            bagelFontDialogue.ShowEffects = true;

            DialogResult temp = bagelFontDialogue.ShowDialog();
                    

            if ( temp == DialogResult.OK)
            {
                bagelListBox.Font = bagelFontDialogue.Font;
                bagelListBox.ForeColor = bagelFontDialogue.Color;
            }
            else if( temp == DialogResult.Cancel)
            {
                bagelFontDialogue.Reset();
                bagelListBox.Font = bagelFontDialogue.Font;
            }
            
        }
        //event handler for right click
        private void listBackgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bagelColorDialogue.AllowFullOpen = false;
            bagelColorDialogue.AnyColor = false;
            bagelColorDialogue.FullOpen = false;

            bagelColorDialogue.ShowDialog();
            bagelListBox.BackColor = bagelColorDialogue.Color;
        }
        //event handler for right click
        private void listTextColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bagelColorDialogue.AllowFullOpen = true;
            bagelColorDialogue.AnyColor = true;
            bagelColorDialogue.FullOpen = true;

            bagelColorDialogue.ShowDialog();
            bagelListBox.ForeColor = bagelColorDialogue.Color;

        }

        private void bagelFontDialogue_Apply(object sender, EventArgs e)
        {
            bagelListBox.Font = bagelFontDialogue.Font;
            
            
        }

        private void formBackgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bagelColorDialogue.AllowFullOpen = false;
            bagelColorDialogue.AnyColor = false;
            bagelColorDialogue.FullOpen = true;

            bagelColorDialogue.ShowDialog();
            this.BackColor = bagelColorDialogue.Color;
        }

    }
}
