using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using CINCOPA.Common;
using CINCOPA.Model;
using CINCOPA.Views;

namespace CINCOPA.ViewModel
{
   public class SelectRouteViewModel: ViewModelBase
    {
             private SelectWindowView v;
        private bool dialogResult;
        private string searchString = "";
        private ROUTE currentItem;
        private string newItem;


        public SelectRouteViewModel()
        {
            AddNewCommand = new DelegateCommand(o=>AddNew());
            OkCommand = new DelegateCommand(o => OkHandler());
            Refresh();

        }

        public ICommand OkCommand { get; set; }
        public ICommand AddNewCommand { get; set; }

        public ObservableCollection<ROUTE> AllItems { get;  set; }
        public ObservableCollection<ROUTE> AllItemsDB { get;  set; }

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
            DataManager.Instance.AddRoute(NewItem);
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

        public ROUTE CurrentItem
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
            AllItems = new ObservableCollection<ROUTE>(AllItemsDB.Where(o => o.NAME.ToUpper().Contains(SearchString.ToUpper())));
            OnPropertyChanged("AllItems");
            CurrentItem = AllItems.Count > 0 ? AllItems[0] : null;
        }

        private void Refresh()
        {
            searchString = "";
            OnPropertyChanged("SearchString");
            AllItemsDB = new ObservableCollection<ROUTE>(DataManager.Instance.GetAllRoutes());
            AllItems = AllItemsDB;
            OnPropertyChanged("AllItems");
            CurrentItem = AllItems.Count > 0 ? AllItems[0] : null;
        }
    }
}
