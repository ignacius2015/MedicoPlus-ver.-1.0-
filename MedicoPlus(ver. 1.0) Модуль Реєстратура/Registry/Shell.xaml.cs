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
using System.Windows.Shapes;

namespace MedicoPlus_ver._1._0__Модуль_Реєстратура.Registry
{
    /// <summary>
    /// Interaction logic for Shell.xaml
    /// </summary>
    public partial class Shell : Window
    {
        public Shell()
        {
            InitializeComponent();
        }

        private void CreateCard_Click(object sender, RoutedEventArgs e)
        {
            CreateCard create= new CreateCard();
            create.Show();
        }

        private void CreateStac_Click(object sender, RoutedEventArgs e)
        {
            CreateStc createStc=new CreateStc();
            createStc.Show();
        }

        private void journal_Click(object sender, RoutedEventArgs e)
        {
            JournalGosp journalGosp=new JournalGosp();
            journalGosp.Show();
        }

        private void journal2_Click(object sender, RoutedEventArgs e)
        {
            JournalVidm journalVidm=new JournalVidm();
            journalVidm.Show();
        }

        private void journal3_Click(object sender, RoutedEventArgs e)
        {
            JournalVidp journalVidp=new JournalVidp();
            journalVidp.Show();
        }

        private void journal4_Click(object sender, RoutedEventArgs e)
        {
            JournalDom journalDom=new JournalDom();
            journalDom.Show();
        }

        private void SearchCard_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
