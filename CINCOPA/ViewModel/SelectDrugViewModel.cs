using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using CINCOPA.Common;
using CINCOPA.Model;
using CINCOPA.Views;

namespace CINCOPA.ViewModel
{
    public class SelectDrugViewModel:ViewModelBase
    {

        private SelectWindowView v;
        private bool dialogResult;
        private string searchString = "";
        private DRUG currentItem;
        private string newItem;


        public SelectDrugViewModel()
        {
            AddNewCommand = new DelegateCommand(o=>AddNew(),o=> NewItem.Trim().Length > 0);
            OkCommand = new DelegateCommand(o => OkHandler());
            Refresh();

        }

        public ICommand OkCommand { get; set; }
        public ICommand AddNewCommand { get; set; }

        public ObservableCollection<DRUG> AllItems { get; private set; }
        public ObservableCollection<DRUG> AllItemsDB { get; private set; }

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

        public DRUG CurrentItem
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
            AllItems = new ObservableCollection<DRUG>(AllItemsDB.Where(o => o.NAME.ToUpper().Contains(SearchString.ToUpper())));
            OnPropertyChanged("AllItems");
            CurrentItem = AllItems.Count > 0 ? AllItems[0] : null;
        }

        private void Refresh()
        {
            searchString = "";
            OnPropertyChanged("SearchString");
            AllItemsDB = new ObservableCollection<DRUG>(DataManager.Instance.GetAllDrugs());
            AllItems = AllItemsDB;
            OnPropertyChanged("AllItems");
            CurrentItem = AllItems.Count > 0 ? AllItems[0] : null;
        }
    }
}
