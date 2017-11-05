using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FUAll
{
    public partial class _MainMenu : Form
    {
        public _Parent m_parent;
        public _MainMenu(_Parent main)
        {
            InitializeComponent();
            m_parent = main;
            this.ControlBox = false;
        }

        private void _MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            m_parent.msgame(); //ПРИМЕР ЗАПУСКА ФУНКЦИИ ИЗ ГЛАВНОЙ ФОРМЫ
        }
    }
}
