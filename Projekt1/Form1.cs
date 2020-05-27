using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt1 {
    public partial class Form1 : Form {


        public static string name;
        public static string surname;
        public static int location;

        public Form1() {
            
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) {
            name = nameBox.Text;
            surname = surnameBox.Text;

            Sql database = new Sql();
            location = database.getUserLocation(name, surname);

            
            if(location == 0) {
                //nie ma takiego, podaj ponownie
                MessageBox.Show("Nie ma takiego uzytkownika!");
            } else {
                
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
                
                
            }
            

            
                
            
        }


        private void button1_Click(object sender, EventArgs e) {
            nameBox.Text = "";
            surnameBox.Text = "";
        }


    }
}
