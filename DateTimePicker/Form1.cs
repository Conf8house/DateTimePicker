using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Tool of peek date";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "ddd, dd MMM, yyyy";
            button1.Text = "Peek a date:";
            label1.Text = string.Format("Tomorrow: {0}", dateTimePicker1.Text);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //Обработка события изменения даты
            label1.Text = string.Format("Peeked data: {0}", dateTimePicker1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Обработка события "Щелчок на кнопке":
            //Передаем фокус на элемент управления dateTimePicker1:
            dateTimePicker1.Focus();
            //Имитируем нажатие клавиши <F4>
            SendKeys.Send("{F4}"); 
        }
    }
}
