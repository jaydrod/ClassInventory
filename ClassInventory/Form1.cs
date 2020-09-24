using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassInventory
{
    public partial class Form1 : Form
    {
        // TODO - create a List to store all inventory objects
        List<Players> players = new List<Players>(); 
        List<string> name = new List<string>();
        List<int> age = new List<int>();
        List<string> team = new List<string>();
        List<string> position = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // TODO - gather all information from screen and display 

            string name = playernameinput.Text;
            int age = Convert.ToInt16(ageInput.Text);
            string team = teamInput.Text;
            string position = positionInput.Text;

            Players a = new Players(name, age, team, position);
            players.Add(a);

            outputlable.Text = "";


        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            // This is to be completed in Part II. You will use 
            // Lambda Expressions.
            //---------------------------
            // TODO - if object is in list remove it
            // TODO - display message to indicate deletion made
            
            


        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // This is to be completed in Part II. You will use 
            // Lambda Expressions.
            //---------------------------
            // TODO - if object entered exists in list show it
            // TODO - else show not found message


        }

        private void showButton_Click(object sender, EventArgs e)
        {
            // This is to be completed in Part II. You will use 
            // Lambda Expressions.
            //---------------------------
            // TODO - show all objects in list


            foreach (Players b in players)
            {
                outputlable.Text += b.name + "\n";
                outputlable.Text += b.age + "\n";
                outputlable.Text += b.team + "\n";
                outputlable.Text += b.position + "\n";
            }


        }
    }
}
