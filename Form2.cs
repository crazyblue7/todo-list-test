using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Todo_list
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadTasks();
        }
        private void SaveTasks()
        {
            // Replace "textbox1", "textbox2", and "textbox3" with your actual textbox names
            File.WriteAllText("urgent.txt", urgent.Text);
            File.WriteAllText("important.txt", important.Text);
            File.WriteAllText("nextWeek.txt", week.Text);
        }
        private void LoadTasks()
        {
            if (File.Exists("urgent.txt"))
                urgent.Text = File.ReadAllText("urgent.txt");

            if (File.Exists("important.txt"))
                important.Text = File.ReadAllText("important.txt");

            if (File.Exists("nextWeek.txt"))
                week.Text = File.ReadAllText("nextWeek.txt");
        }

        private void save_Click(object sender, EventArgs e)
        {
            SaveTasks();
        }
    }
}
