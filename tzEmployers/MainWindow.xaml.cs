using System.Windows;
using tzEmployers.Models;
using tzEmployers.ViewModels;

namespace tzEmployers
{

    public partial class MainWindow : Window
    {
        public MainWindow() { }
        EmployerContext db;
        public MainWindow(EmployerContext context)
        {
            InitializeComponent();
            this.db = context;
            StartData.Initialize(db);
            DataContext = new EmployerViewModel(db);          
            
        }

        
    }
}
