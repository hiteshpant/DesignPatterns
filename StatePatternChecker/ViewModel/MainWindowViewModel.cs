using Prism.Commands;
using StatePattern;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StatePatternChecker.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private string _Message;
        private string _Name;

        private string _Description;

        private WorkItem _SelectedWorkItem;
        private readonly Repository<WorkItem> _Repository;


        public MainWindowViewModel()
        {
            AddWorkItemCommand = new DelegateCommand(OnAddWorkItem);
            EditWorkItemCommand = new DelegateCommand(OnEditWorkItemCommand);
            _Repository = new Repository<WorkItem>();            
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public System.Windows.Input.ICommand AddWorkItemCommand { get; }
        public System.Windows.Input.ICommand EditWorkItemCommand { get; }
        public WorkItem SelectedWorkItem
        {
            get
            {
                return _SelectedWorkItem;
            }

            set
            {
                _SelectedWorkItem = value;
                Message = string.Empty;
                NotifyUI();
                Name = SelectedWorkItem.Name;
                Description = SelectedWorkItem.Description;
            }
        }

        private void OnEditWorkItemCommand()
        {
           Message= _SelectedWorkItem.Edit(Name, Description);          
           
        }   
        
        private void NotifyUI()
        {
            OnPropertyChanged("SelectedWorkItem");
            OnPropertyChanged("SelectedState");
            OnPropertyChanged("Description");
            OnPropertyChanged("Name");
        }

        public List<string> States
        {
            get
            {
                return StateFactory.GetAllState();
            }
        }

        public string SelectedState
        {
            get
            {
                return GetState();
            }
            set
            {
                Message = string.Empty;
                _SelectedWorkItem.SetState(value);
                if (_SelectedWorkItem.State.GetType().Name != value)
                {
                    Message = "State Cannot be changed";
                }
                OnPropertyChanged("SelectedState");
            }
        }

        private string GetState()
        {
            return _SelectedWorkItem != null ? States?.FirstOrDefault(x => x == _SelectedWorkItem.State.GetType().Name) :
                States?.FirstOrDefault(x => x == "Proposed");
        }
               

        public string Description
        {
            get
            {
                return _Description;
            }
            set
            {
                _Description = value;
                OnPropertyChanged("Description");
            }
        }

        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
                OnPropertyChanged("Name");
            }
        }


        public string Message
        {
            get
            {
                return _Message;
            }

            set
            {
                _Message = value;
                OnPropertyChanged("Message");
            }
        }

        public List<WorkItem> WorkItems
        {
            get
            {
                return _Repository.Items.ToList();
            }
        }

        private void OnAddWorkItem()
        {
            _Repository.Add(new WorkItem());
            SelectedWorkItem = WorkItems[WorkItems.Count - 1];          
            OnPropertyChanged("WorkItems");
        }

        public void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
