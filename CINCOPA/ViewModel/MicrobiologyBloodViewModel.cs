using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using CINCOPA.Common;
using CINCOPA.Model;

namespace CINCOPA.ViewModel
{
   public class MicrobiologyBloodViewModel: ViewModelBase
    {
          public MICROBIOLOGY_BLOOD Model;

        public MicrobiologyBloodViewModel(MICROBIOLOGY_BLOOD obj)
        {
            if (obj != null)
            {
                Model = obj;
            }
            SelectOrganismCommand = new DelegateCommand(o=>SelectOrganism());
        }

        public ICommand SelectOrganismCommand { get; private set; }

        public List<ORGANISM> OrganismLookup
        {
            get { return DataManager.Instance.OrganismLookup; }
        }

        public void SelectOrganism()
        {
            var vm = new SelectOrganismViewModel();
            vm.ShowDialog();
            if (vm.DialogResult)
            {
                OnPropertyChanged("OrganismLookup");
                MB_BLOOD_ORGANISM = vm.CurrentItem;
            }
        }

        public DateTime? MB_BLOOD_DATE_CAPTURE
        {
            get { return Model.DATE_CAPTURE; }
            set
            {
                Model.DATE_CAPTURE = value;
                OnPropertyChanged("MB_BLOOD_DATE_CAPTURE");
            }
        }

        public string MB_BLOOD_LAB_NUMBER
        {
            get { return Model.LAB_NUMBER; }
            set
            {
                Model.LAB_NUMBER = value;
                OnPropertyChanged("MB_BLOOD_LAB_NUMBER");
            }
        }

       
        public string MB_BLOOD_GROWTH_PATHOGENS
        {
            get { return Model.GROWTH_PATHOGENS; }
            set
            {
                Model.GROWTH_PATHOGENS = value;
                OnPropertyChanged("MB_BLOOD_GROWTH_PATHOGENS");
            }
        }

        public ORGANISM MB_BLOOD_ORGANISM
        {
            get { return Model.ORGANISM; }
            set
            {
                Model.ORGANISM = value;
                OnPropertyChanged("MB_BLOOD_ORGANISM");
            }
        }

        public string MB_BLOOD_BETA
        {
            get { return Model.BETA; }
            set
            {
                Model.BETA = value;
                OnPropertyChanged("MB_BLOOD_BETA");
            }
        }

        public string MB_BLOOD_MRSA
        {
            get { return Model.MRSA; }
            set
            {
                Model.MRSA = value;
                OnPropertyChanged("MB_BLOOD_MRSA");
            }
        }

        public List<string> Logic2Lookup
        {
            get { return DataManager.Instance.Logic2Lookup; }
        }

        public List<string> Logic3Lookup
        {
            get { return DataManager.Instance.Logic3Lookup; }
        }
    }
}
