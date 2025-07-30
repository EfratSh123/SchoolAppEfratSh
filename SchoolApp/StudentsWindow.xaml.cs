using BLL;
using Entities1;
using System.Windows;

namespace SchoolApp
{
    public partial class StudentsWindow : Window
    {
        private Functions bl; // Declare the field with the correct type

        public StudentsWindow()
        {
            DataContext = this;
            bl = new Functions(); // Instantiate the BLL class
            Students = bl.LoadStudentsDetails(); // Use the correct method name
            InitializeComponent();
        }
        public List<Students> Students { get; set; }
    }
}
