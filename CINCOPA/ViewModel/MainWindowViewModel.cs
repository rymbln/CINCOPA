using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using CINCOPA.Common;
using CINCOPA.Model;
using CINCOPA.Views;

namespace CINCOPA.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        private CRF currentCrf { get; set; }
        private ObservableCollection<CRF> allCrf { get; set; }
        private string totalCards { get; set; }

        public MainWindowViewModel()
        {
            AllCrf = new ObservableCollection<CRF>();

            AllCrf = new ObservableCollection<CRF>(DataManager.Instance.GetCrfForCurrentUser());

            OpenCrfCommand = new DelegateCommand(o => OpenCrf(), o=> CurrentCrf != null);
            AddCrfCommand = new DelegateCommand(o => AddCrf());
            DeleteCrfCommand = new DelegateCommand(o => DeleteCrf(), o => CurrentCrf != null);
            CheckCrfCommand = new DelegateCommand(o => CheckCrf());
            RefreshCommand = new DelegateCommand(o => Refresh());
        }

       public ObservableCollection<CRF> AllCrf
        {
            get { return allCrf; }
            set
            {
                allCrf = value;
                CurrentCrf = AllCrf.FirstOrDefault();
                TotalCards = "Пользователем " + Authentification.GetCurrentUser().NAME + " введено " + AllCrf.Count +
                             " карт.";

                OnPropertyChanged("AllCrf");
            }
        }
        
        public ICommand OpenCrfCommand { get; private set; }
        public ICommand AddCrfCommand { get; private set; }
        public ICommand DeleteCrfCommand { get; private set; }
        public ICommand CheckCrfCommand { get; private set; }
        public ICommand RefreshCommand { get; private set; }

        private void OpenCrf()
        {
            var vm = new CrfViewModel(CurrentCrf);
            var v = new CrfView { DataContext = vm };
            v.Show();
        }

        private void AddCrf()
        {
            var vm = new CrfViewModel(DataManager.Instance.CreateCrf());
            var v = new CrfView {DataContext = vm};
            v.Show();
        }

        private void DeleteCrf()
        {
         //Todo
   
        }

        private void CheckCrf()
        {
            //Todo
        }

        private void Refresh()
        {
            AllCrf = new ObservableCollection<CRF>(DataManager.Instance.GetCrfForCurrentUser());
          OnPropertyChanged("AllCrf");
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
