using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using CINCOPA.Common;
using CINCOPA.Model;

namespace CINCOPA.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        private CRF currentCrf { get; set; }
        private string totalCards { get; set; }

        public MainWindowViewModel()
        {
            AllCrf = new ObservableCollection<CRF>();

            AllCrf = new ObservableCollection<CRF>(DataManager.Instance.GetCrfForCurrentUser());
            AllCrf.CollectionChanged += AllCrf_CollectionChanged;

            OpenCrfCommand = new DelegateCommand(o => OpenCrf(), o=> CurrentCrf != null);
            AddCrfCommand = new DelegateCommand(o => AddCrf());
            DeleteCrfCommand = new DelegateCommand(o => DeleteCrf(), o => CurrentCrf != null);
            CheckCrfCommand = new DelegateCommand(o => CheckCrf());
        }

        void AllCrf_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            AllCrf = new ObservableCollection<CRF>(DataManager.Instance.GetCrfForCurrentUser());
            CurrentCrf = AllCrf.FirstOrDefault();
            TotalCards = "Пользователем " + Authentification.GetCurrentUser().NAME + " введено " + AllCrf.Count +
                         " карт.";
        }

        public ObservableCollection<CRF>  AllCrf { get; private set; }
        
        public ICommand OpenCrfCommand { get; private set; }
        public ICommand AddCrfCommand { get; private set; }
        public ICommand DeleteCrfCommand { get; private set; }
        public ICommand CheckCrfCommand { get; private set; }

        public void OpenCrf()
        {
            //Todo
        }

        public void AddCrf()
        {
            //Todo   
        }

        public void DeleteCrf()
        {
         //Todo
   
        }

        public void CheckCrf()
        {
            //Todo
        }

        public string TotalCards
        {
            get { return totalCards; }
            set
            {
                totalCards = value;
                OnPropertyChanged("TotalCards");
            }
        }

        public CRF CurrentCrf
        {
            get { return currentCrf; }
            set
            {
                currentCrf = value;
                OnPropertyChanged("CurrentCrf");
            }
        }
    }
}
