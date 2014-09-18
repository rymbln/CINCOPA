using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows.Input;
using CINCOPA.Common;
using CINCOPA.Model;
using CINCOPA.Views;

namespace CINCOPA.ViewModel
{
    public class SelectOrganismViewModel : ViewModelBase
    {
        private SelectWindowView v;
        private bool dialogResult;
        private string searchString = "";
        private object currentItem;
        private string newItem;


        public SelectOrganismViewModel()
        {
            AddNewCommand = new DelegateCommand(o=>AddNew(),o=> NewItem.Trim().Length > 0);
            OkCommand = new DelegateCommand(o => OkHandler());
            Refresh();

        }

        public ICommand OkCommand { get; set; }
        public ICommand AddNewCommand { get; set; }

        public ObservableCollection<ORGANISM> AllItems { get; private set; }
        public ObservableCollection<ORGANISM> AllItemsDB { get; private set; }

        public bool ShowDialog()
        {
            v = new SelectWindowView { DataContext = this };
            v.ShowDialog();
            return dialogResult;
        }
        private void OkHandler()
        {
            dialogResult = true;
            v.Close();
        }

        private void AddNew()
        {
            DataManager.Instance.AddOrganism(NewItem);
            Refresh();
        }
        public bool DialogResult
        {
            get { return this.dialogResult; }
            set
            {
                this.dialogResult = value;
                OnPropertyChanged("DialogResult");
            }
        }

        public object CurrentItem
        {
            get { return currentItem; }
            set
            {
                currentItem = value;
                OnPropertyChanged("CurrentItem");
            }
        }

        public string NewItem
        {
            get { return newItem; }
            set
            {
                newItem = value;
                OnPropertyChanged("NewItem");
            }
        }

        public string SearchString
        {
            get { return searchString; }
            set
            {
                searchString = value.Trim();
                OnPropertyChanged("SearchString");
                if (searchString.Equals(""))
                {
                    Refresh();
                }
                else
                {
                    Filter();
                }
            }
        }

        private void Filter()
        {
            AllItems = new ObservableCollection<ORGANISM>(AllItemsDB.Where(o => o.NAME.ToUpper().Contains(SearchString.ToUpper())));
            OnPropertyChanged("AllItems");
            CurrentItem = AllItems.Count > 0 ? AllItems[0] : null;
        }

        private void Refresh()
        {
            searchString = "";
            OnPropertyChanged("SearchString");
            AllItemsDB = new ObservableCollection<ORGANISM>(DataManager.Instance.GetAllOrganisms());
            AllItems = AllItemsDB;
            OnPropertyChanged("AllItems");
            CurrentItem = AllItems.Count > 0 ? AllItems[0] : null;
        }
    }
}
