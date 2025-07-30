using BLL;
using Entities1;
using System.Windows;

namespace SchoolApp
{
    /// <summary>
    /// Interaction logic for TeachersWindow.xaml
    /// </summary>
    public partial class TeachersWindow : Window
    {
        private Functions bl; // Declare the BLL field with the correct type

        public TeachersWindow()
        {
            DataContext = this;
            bl = new Functions(); // Instantiate the BLL class
            Teachers = bl.LoadTeachersDetails(); // Use the correct method name
            InitializeComponent();
        }
        public List<Teachers> Teachers { get; set; } // Use the correct type name
    }
}
