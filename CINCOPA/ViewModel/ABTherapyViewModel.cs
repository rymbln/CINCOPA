using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using CINCOPA.Common;
using CINCOPA.Model;
using System.Windows;

namespace CINCOPA.ViewModel
{
    public class ABTherapyViewModel : ViewModelBase
    {
        public AB_THERAPY Model;

        public ABTherapyViewModel(AB_THERAPY obj)
        {
            if (obj != null)
            {
                Model = obj;
            }
            SelectDrugCommand = new DelegateCommand(o => SelectDrug());
            SelectRouteCommand = new DelegateCommand(o => SelectRoute());
            LostFocusAbDrugCommand = new DelegateCommand(o => LostFocusAbDrug());
            LostFocusAbRouteCommand = new DelegateCommand(o => LostFocusAbRoute());
        }

        public ICommand SelectDrugCommand { get; private set; }
        public ICommand SelectRouteCommand { get; private set; }
        public ICommand LostFocusAbDrugCommand { get; private set; }
        public ICommand LostFocusAbRouteCommand { get; private set; }

        public DRUG AB_DRUG
        {
            get { return Model.DRUG; }
            set
            {
                if (value == null)
                {
                    Model.DRUG = DataManager.Instance.GetDefaultDrug();
                }
                else
                {
                    Model.DRUG = value;
                }

                OnPropertyChanged("AB_DRUG");
            }
        }

        public ROUTE AB_ROUTE
        {
            get { return Model.ROUTE; }
            set
            {
                if (value == null)
                {
                    Model.ROUTE = DataManager.Instance.GetDefaultRoute();
                }
                else
                {
                    Model.ROUTE = value;

                }

                OnPropertyChanged("AB_ROUTE");
            }

        }

        public string AB_SINGLE_DOSE
        {
            get { return Model.SINGLE_DOSE; }
            set
            {
                Model.SINGLE_DOSE = value;
                OnPropertyChanged("AB_SINGLE_DOSE");
            }
        }

        public string AB_FREQUENCY
        {
            get { return Model.FREQUENCY; }
            set
            {
                Model.FREQUENCY = value;
                OnPropertyChanged("AB_FREQUENCY");
            }
        }

        public DateTime? AB_DATE_START
        {
            get { return Model.DATE_START; }
            set
            {
                Model.DATE_START = value;
                OnPropertyChanged("AB_DATE_START");
            }
        }

        public DateTime? AB_DATE_END
        {
            get { return Model.DATE_END; }
            set
            {
                Model.DATE_END = value;
                OnPropertyChanged("AB_DATE_END");
            }
        }

        public ObservableCollection<DRUG> DrugLookup
        {
            get { return new ObservableCollection<DRUG>(DataManager.Instance.DrugLookup); }
        }

        public List<ROUTE> RouteLookup
        {
            get { return DataManager.Instance.RouteLookup; }
        }


        private void SelectDrug()
        {
            var vm = new SelectDrugViewModel();
            vm.ShowDialog();
            if (vm.DialogResult)
            {

                OnPropertyChanged("DrugLookup");
                AB_DRUG = vm.CurrentItem;
            }
        }


        private void SelectRoute()
        {
            var vm = new SelectRouteViewModel();
            vm.ShowDialog();
            if (vm.DialogResult)
            {

                OnPropertyChanged("RouteLookup");
                AB_ROUTE = vm.CurrentItem;
            }
        }

        private string _typedTextAbDrug;
        private string _typedTextAbRoute;

        public string TypedTextAbDrug
        {
            get
            {
                if (string.IsNullOrEmpty(_typedTextAbDrug))
                {
                    return AB_DRUG.NAME;
                }
                else
                {
                    return _typedTextAbDrug;
                };
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _typedTextAbDrug = "---";
                }
                else
                {
                    _typedTextAbDrug = value;
                }
                OnPropertyChanged("TypedTextAbDrug");

            }
        }
        public string TypedTextAbRoute
        {
            get
            {
                if (string.IsNullOrEmpty(_typedTextAbRoute))
                {
                    return AB_ROUTE.NAME;
                }
                else
                {
                    return _typedTextAbRoute;
                };
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _typedTextAbRoute = "---";
                }
                else
                {
                    _typedTextAbRoute = value;
                }
                OnPropertyChanged("TypedTextAbRoute");

            }
        }

        private void LostFocusAbDrug()
        {
            //check if the typed text is contained in the items source list
                var searchedItem = DrugLookup.Select(o => o.NAME).FirstOrDefault(item => item.Contains(TypedTextAbDrug));
            if (searchedItem == null)
            {
                MessageBoxResult result = MessageBox.Show("Препарат отсутствует в списке. Добавить?", "Препарат не найден", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    DataManager.Instance.AddDrug(_typedTextAbDrug);
                    OnPropertyChanged("DrugLookup");
                    var dr = DrugLookup.Where(item => item.NAME.Equals(TypedTextAbDrug)).FirstOrDefault();
                    AB_DRUG = dr;
                }
            }
            else
            {
                //do something else
            }
        }
        private void LostFocusAbRoute()
        {
            //check if the typed text is contained in the items source list
            var searchedItem = RouteLookup.Select(o => o.NAME).FirstOrDefault(item => item.Contains(TypedTextAbRoute));
            if (searchedItem == null)
            {
                MessageBoxResult result = MessageBox.Show("Путь введения отсутствует в списке. Добавить?", "Препарат не найден", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    DataManager.Instance.AddRoute(_typedTextAbRoute);
                    OnPropertyChanged("DrugLookup");
                    var dr = RouteLookup.Where(item => item.NAME.Equals(TypedTextAbRoute)).FirstOrDefault();
                    AB_ROUTE = dr;
                }
            }
            else
            {
                //do something else
            }
        }
    }
}
