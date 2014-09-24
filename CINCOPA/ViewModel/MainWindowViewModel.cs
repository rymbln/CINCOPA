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
        private ModelClasses currentCrf { get; set; }
        private ObservableCollection<ModelClasses> allCrf { get; set; }
        private string totalCards { get; set; }

        public MainWindowViewModel()
        {
            AllCrf = new ObservableCollection<ModelClasses>();

            AllCrf = new ObservableCollection<ModelClasses>(DataManager.Instance.GetCrfForCurrentUser());

            OpenCrfCommand = new DelegateCommand(o => OpenCrf(), o=> CurrentCrf != null);
            AddCrfCommand = new DelegateCommand(o => AddCrf());
            DeleteCrfCommand = new DelegateCommand(o => DeleteCrf(), o => CurrentCrf != null);
            CheckCrfCommand = new DelegateCommand(o => CheckCrf());
            RefreshCommand = new DelegateCommand(o => Refresh());
        }

       public ObservableCollection<ModelClasses> AllCrf
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
            AllCrf = new ObservableCollection<ModelClasses>(DataManager.Instance.GetCrfForCurrentUser());
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

        public ModelClasses CurrentCrf
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
