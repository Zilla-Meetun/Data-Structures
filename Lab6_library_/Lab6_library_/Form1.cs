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

namespace Lab6_library_
{
    public partial class Form1 : Form
    {
        Dictionary<string, Book> librarydic = new Dictionary<string, Book>();

        public Form1()
        {
            InitializeComponent();

            checkedListBox1.CheckOnClick = true;

            Book book1 = new Book("1234BN", "Moby Dicks");
            Book book2 = new Book("5647BN", "Ullysses");
            librarydic[book1.ISBN] = book1;
            librarydic[book2.ISBN] = book2;
            
            foreach (var item in librarydic )
            {
                checkedListBox1.Items.Add(item.Value.ISBN);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox1.CheckedItems)
            {
                if (checkedListBox1.Text == 
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox1.CheckedItems)
            {
                checkedListBox1.Items.Remove(item);
            }
        }
    }
}
