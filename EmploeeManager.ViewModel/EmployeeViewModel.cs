using EmployeeManager.Common.DataProvider;
using EmployeeManager.Common.Model;
using EmployeeManager.ViewModel.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager.ViewModel
{
    public class EmployeeViewModel : ViewModelBase
    {
        private readonly Employee employee;
        private readonly IEmployeeDataProvider employeeDataProvider;

        public EmployeeViewModel(Employee employee, IEmployeeDataProvider employeeDataProvider)
        {
            this.employee = employee;
            this.employeeDataProvider = employeeDataProvider;
            SaveCommand = new DelegateCommand(Save, () => CanSave);
        }

        public DelegateCommand SaveCommand { get; }

        public string FirstName
        {
            get { return employee.FirstName; }
            set
            {
                if (employee.FirstName != value)
                {
                    employee.FirstName = value;
                    RaisePropertyChanged();
                    RaisePropertyChanged(nameof(CanSave));
                    SaveCommand.RaiseCanExecuteChanged();
                }
            }
        }

        public DateTimeOffset EntryDate
        {
            get { return employee.EntryDate; }
            set
            {
                if (employee.EntryDate != value)
                {
                    employee.EntryDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        public DateTime EntryDateTime
        {
            get { return employee.EntryDate.DateTime; }
            set
            {
                if (employee.EntryDate != value)
                {
                    employee.EntryDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        public int JobRoleId
        {
            get { return employee.JobRoleId; }
            set
            {
                if (employee.JobRoleId != value)
                {
                    employee.JobRoleId = value;
                    RaisePropertyChanged();
                }
            }
        }

        public bool IsCoffeeDrinker
        {
            get { return employee.IsCoffeeDrinker; }
            set
            {
                if (employee.IsCoffeeDrinker != value)
                {
                    employee.IsCoffeeDrinker = value;
                    RaisePropertyChanged();
                }
            }
        }

        public bool CanSave => !string.IsNullOrEmpty(FirstName);

        public void Save()
        {
            employeeDataProvider.SaveEmployee(employee);
        }
    }
}
