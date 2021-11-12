using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace izvp_04_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Student> list = new List<Student>();
       
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("students.txt");
            foreach (string line in lines)
            {
                string[] col = line.Split('|');
                Console.WriteLine(col[0]);
                list.Add(new Student(col[0],Convert.ToInt32(col[1]), Convert.ToInt32(col[2]), Convert.ToInt32(col[3]), Convert.ToInt32(col[4]), Convert.ToInt32(col[5]), Convert.ToInt32(col[6]), Convert.ToDouble(col[7]) ));
            }
            /*list.Add(new Student("Sihov D. Y.", 2003, 81, 5, 5, 5, 5, 5));
            list.Add(new Student("Valera V.V.", 2004, 89, 3, 4, 5, 4, 4));
            list.Add(new Student("Sihov2 D. Y.", 2003, 81, 3, 4, 4, 4, 3.75));
            list.Add(new Student("Valera2 V.V.", 2004, 89, 5, 4, 5, 4, 4.5));*/
            
            foreach (Student s in list)
            {
                
                dataGridView1.Rows.Add(s.Name, s.Year, s.GroupNumber, s.Physics, s.Math, s.Inf, s.Chemistry, s.Avg);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            string group = textBox1.Text;
            foreach(Student s in list)
            {
                if(s.GroupNumber.ToString() == group && s.isTopStudent())
                {
                    dataGridView2.Rows.Add(s.Name,s.Year,s.GroupNumber,s.Physics,s.Math,s.Inf,s.Chemistry,s.Avg);
                }
            }
        }
    }
}
