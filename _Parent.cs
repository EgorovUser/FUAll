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
    public partial class _Parent : Form
    {
        public _Parent()//запускаем главное меню
        {
            InitializeComponent();
            MainMenu();
        }
        //
        // ПРИМЕР ЗАПУСКА ФУНКЦИЙ ИЗ ДРУГИХ ФОРМ СМОТРИТЕ В _MainMenu.cs
        //
        private void Parent_Load(object sender, EventArgs e) 
        {
            Application.Exit();
        }
        //
        // ВЫВОД ЭТИХ ОКОН
        //
        public void MainMenu()
        {
            _MainMenu tempDialog = new _MainMenu(this);
            tempDialog.ShowDialog();
        }
        public void Settings()
        {
            _Settings tempDialog = new _Settings(this);
            tempDialog.ShowDialog();
        }
        public void Statistic()
        {
            _Statistic tempDialog = new _Statistic(this);
            tempDialog.ShowDialog();
        }
        public void Rules()
        {
            _Rules tempDialog = new _Rules(this);
            tempDialog.ShowDialog();
        }
        public void About()
        {
            _About tempDialog = new _About(this);
            tempDialog.Show();
        }
        public void Game()
        {
            _Game tempDialog = new _Game(this);
            tempDialog.Show();
        }
        //
        // ДАЛЬШЕ ПИШЕМ ФУНКЦИИ !!! СЮДА, А НЕ В ФОРМЫ !!! ИЗ ФОРМ ТОЛЬКО ЗАПУСК
        //
        public void msgame()
        {
            MessageBox.Show("Пишов нахуй");
        }
    }
}
