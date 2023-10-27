using System;
using lib6;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections;

namespace пр6_Головиной
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        //вызов класса как рандом
        Car calc = new Car();

        //увеличить мощность 1
        private void power1_Click(object sender, RoutedEventArgs e)
        {

        }

        //увеличить мощность 2
        private void power2_Click(object sender, RoutedEventArgs e)
        {

        }

        //какая машина круче
        private void think_Click(object sender, RoutedEventArgs e)
        {

        }

        //сохранить значения обеих машин
        private void save_Click(object sender, RoutedEventArgs e)
        {
            //параметры машины
            int st1 = Convert.ToInt32(stamp1.Text);
            int cy1 = Convert.ToInt32(cylinders1.Text);
            int po1 = Convert.ToInt32(power1.Text);
            int st2 = Convert.ToInt32(stamp2.Text);
            int cy2 = Convert.ToInt32(cylinders2.Text);
            int po2 = Convert.ToInt32(power2.Text);

            calc.SetParams(st1, cy1, po1, st2, cy2, po2);
        }

        //открыть их благодаря методам
        private void open_Click(object sender, RoutedEventArgs e)
        {
            //параметры машины
            int st1;
            int cy1;
            int po1;
            int st2;
            int cy2;
            int po2;

            calc.GetParams(out st1, out cy1, out po1, out st2, out cy2, out po2);
            stamp1.Text = st1.ToString();
            cylinders1.Text = cy1.ToString();
            power1.Text = po1.ToString();
            stamp2.Text = st2.ToString();
            cylinders2.Text = cy2.ToString();
            power2.Text = po2.ToString();
        }
    }
}
