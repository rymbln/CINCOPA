using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using CINCOPA.Common;
using CINCOPA.Model;

namespace CINCOPA.ViewModel
{
    public class ABTherapyViewModel:ViewModelBase
    {
        public AB_THERAPY Model;

        public ABTherapyViewModel(AB_THERAPY obj)
        {
            if (obj != null)
            {
                Model = obj;
            }
            SelectDrugCommand = new DelegateCommand(o => SelectDrug());
        }

        public ICommand SelectDrugCommand { get; private set; }
        public ICommand SelectRouteCommand { get; private set; }

        public DRUG AB_DRUG
        {
            get { return Model.DRUG; }
            set
            {
                Model.DRUG = value;
                OnPropertyChanged("AB_DRUG");
            }
        }

        public ROUTE AB_ROUTE
        {
            get { return Model.ROUTE; }
            set
            {
                Model.ROUTE = value;
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

        public List<DRUG> DrugLookup
        {
            get { return DataManager.Instance.DrugLookup; }
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
    }
}
