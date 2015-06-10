using CINCOPA.Common;
using CINCOPA.Model;
using CINCOPA.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace CINCOPA.ViewModel
{
   public class SelectLpuViewModel:ViewModelBase
    {
        private SelectWindowView v;
        private bool dialogResult;
        private string searchString = "";
        private WARD currentItem;
        private string newItem;

       public SelectLpuViewModel()
        {
            AddNewCommand = new DelegateCommand(o => AddNew());
            OkCommand = new DelegateCommand(o => OkHandler());
            Refresh();
        }

       public ICommand OkCommand { get; set; }
       public ICommand AddNewCommand { get; set; }

       public ObservableCollection<WARD> AllItems { get; set; }
       public ObservableCollection<WARD> AllItemsDB { get; set; }

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
           DataManager.Instance.AddWard(NewItem);
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

       public WARD CurrentItem
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
           AllItems = new ObservableCollection<WARD>(AllItemsDB.Where(o => o.NAME.ToUpper().Contains(SearchString.ToUpper())));
           OnPropertyChanged("AllItems");
           CurrentItem = AllItems.Count > 0 ? AllItems[0] : null;
       }

       private void Refresh()
       {
           searchString = "";
           OnPropertyChanged("SearchString");
           AllItemsDB = new ObservableCollection<WARD>(DataManager.Instance.GetAllWards());
           AllItems = AllItemsDB;
           OnPropertyChanged("AllItems");
           CurrentItem = AllItems.Count > 0 ? AllItems[0] : null;
       }
    }
}
