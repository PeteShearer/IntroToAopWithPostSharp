using System;
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

namespace IntroToAop3
{
    public partial class MainWindow : Window
    {
        protected LongRunningClass _longRunningClass;
        public MainWindow()
        {
            InitializeComponent();
            _longRunningClass = new LongRunningClass();
        }

        private void btnBreakIt_Click(object sender, RoutedEventArgs e)
        {
            _longRunningClass.LongRunningOperationBlocking();
            MessageBox.Show(txtBreakIt.Text);
        }

        private void btnDontBreakIt_Click(object sender, RoutedEventArgs e)
        {
            _longRunningClass.LongRunningOperationBackground();
            MessageBox.Show(txtDontBreakIt.Text);
        }
    }
}
