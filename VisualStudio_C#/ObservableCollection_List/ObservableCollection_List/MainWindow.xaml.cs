using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ObservableCollection_List
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       // List<person> players = new List<person>();
        ObservableCollection<person> players = new ObservableCollection<person>();
        public MainWindow()
        {
            InitializeComponent();

            DataContext = this.GetPlayer(); 
        }

        public ObservableCollection<person> GetPlayer()
        {
            players.Add(new person() { ID = 1, Name = "Raj" });
            players.Add(new person() { ID = 2, Name = "Rahul" });
            players.Add(new person() { ID = 3, Name = "Arjun" });

            return players;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            players.Add(new person() { ID = 9, Name = "Jake" });
        }
         
    }
}
