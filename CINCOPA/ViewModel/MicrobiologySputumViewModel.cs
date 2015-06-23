using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using CINCOPA.Common;
using CINCOPA.Model;
using System.Windows;

namespace CINCOPA.ViewModel
{
    public class MicrobiologySputumViewModel: ViewModelBase
    {
        public MICROBIOLOGY_SPUTUM Model;

        public MicrobiologySputumViewModel(MICROBIOLOGY_SPUTUM obj)
        {
            if (obj != null)
            {
                Model = obj;
            }
            SelectOrganismCommand = new DelegateCommand(o=>SelectOrganism());
            LostFocusMbOrgCommand = new DelegateCommand(o => LostFocusMbOrg());
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
                MB_SPUTUM_ORGANISM = vm.CurrentItem;
            }
        }

        public DateTime? MB_SPUTUM_DATE_CAPTURE
        {
            get { return Model.DATE_CAPTURE; }
            set
            {
                Model.DATE_CAPTURE = value;
                OnPropertyChanged("MB_SPUTUM_DATE_CAPTURE");
            }
        }

        public string MB_SPUTUM_LAB_NUMBER
        {
            get { return Model.LAB_NUMBER; }
            set
            {
                Model.LAB_NUMBER = value;
                OnPropertyChanged("MB_SPUTUM_LAB_NUMBER");
            }
        }

        public string MB_SPUTUM_QUALITY_LEUKOCYTES
        {
            get { return Model.QUALITY_LEUKOCYTES; }
            set
            {
                Model.QUALITY_LEUKOCYTES = value;
                OnPropertyChanged("MB_SPUTUM_QUALITY_LEUKOCYTES");
            }
        }

        public string MB_SPUTUM_QUALITY_EPITHELIAL
        {
            get { return Model.QUALITY_EPITHELIAL; }
            set
            {
                Model.QUALITY_EPITHELIAL = value;
                OnPropertyChanged("MB_SPUTUM_QUALITY_EPITHELIAL");
            }
        }

        public bool? MB_SPUTUM_NOT_REPRESENTATIVE
        {
            get { return Model.NOT_REPRESENTATIVE; }
            set
            {
                Model.NOT_REPRESENTATIVE = value;
                OnPropertyChanged("MB_SPUTUM_NOT_REPRESENTATIVE");
            }
        }

        public string MB_SPUTUM_GROWTH_PATHOGENS
        {
            get { return Model.GROWTH_PATHOGENS; }
            set
            {
                Model.GROWTH_PATHOGENS = value;
                OnPropertyChanged("MB_SPUTUM_GROWTH_PATHOGENS");
            }
        }

        public ORGANISM MB_SPUTUM_ORGANISM
        {
            get { return Model.ORGANISM; }
            set
            {
                if (value == null)
                {
                    Model.ORGANISM = DataManager.Instance.GetDefaultOrganism();
                }
                else
                {
                    Model.ORGANISM = value;
                }
                OnPropertyChanged("MB_SPUTUM_ORGANISM");
            }
        }

        public string MB_SPUTUM_BETA
        {
            get { return Model.BETA; }
            set
            {
                Model.BETA = value;
                OnPropertyChanged("MB_SPUTUM_BETA");
            }
        }

        public string MB_SPUTUM_MRSA
        {
            get { return Model.MRSA; }
            set
            {
                Model.MRSA = value;
                OnPropertyChanged("MB_SPUTUM_MRSA");
            }
        }

        private string _typedTextMbOrg;
        public string TypedTextMbOrg
        {
            get
            {
                if (string.IsNullOrEmpty(_typedTextMbOrg))
                {
                    return MB_SPUTUM_ORGANISM.NAME;
                }
                else
                {
                    return _typedTextMbOrg;
                };
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _typedTextMbOrg = "---";
                }
                else
                {
                    _typedTextMbOrg = value;
                }
                OnPropertyChanged("TypedTextMbOrg");

            }
        }
        public ICommand LostFocusMbOrgCommand { get; set; }
        private void LostFocusMbOrg()
        {
            //check if the typed text is contained in the items source list
            var searchedItem = OrganismLookup.Select(o => o.NAME).FirstOrDefault(item => item.Contains(TypedTextMbOrg));
            if (searchedItem == null)
            {
                MessageBoxResult result = MessageBox.Show("Организм отсутствует в списке. Добавить?", "Организм не найден", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    DataManager.Instance.AddDrug(TypedTextMbOrg);
                    OnPropertyChanged("OrganismLookup");
                    var dr = OrganismLookup.Where(item => item.NAME.Equals(TypedTextMbOrg)).FirstOrDefault();
                    MB_SPUTUM_ORGANISM = dr;
                }
            }
            else
            {
                //do something else
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
        public List<string> Logic3Type2Lookup
        {
            get { return DataManager.Instance.Logic3Type2Lookup; }
        }
    }
}
