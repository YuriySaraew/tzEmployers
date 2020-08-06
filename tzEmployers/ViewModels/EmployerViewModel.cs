using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using tzEmployers.Models;

namespace tzEmployers.ViewModels
{
    public class EmployerViewModel : INotifyPropertyChanged
    {

        public ObservableCollection<Employer> Employers { get; set; }
        public ObservableCollection<Department> Departments { get; set; }
        public ObservableCollection<Order> Orders { get; set; }

        public EmployerViewModel() { }
        public EmployerViewModel(EmployerContext context)
        {
            Employers = new ObservableCollection<Employer>(context.Employers.ToList());
        }
        

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
