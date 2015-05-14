using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Windows.Navigation;
using CINCOPA.Common;
using CINCOPA.Model;
using System.Windows;

namespace CINCOPA.ViewModel
{
    public class CrfViewModel : ViewModelBase
    {
        private CRF Model;
        private ABTherapyViewModel currentABTherapy;
        private AEViewModel currentAE;
        private MicrobiologySputumViewModel currentMBSputum;
        private MicrobiologyBloodViewModel currentMBBlood;

        public CrfViewModel(CRF obj)
        {
            if (obj != null)
            {
                Model = obj;

                AllAE = new ObservableCollection<AEViewModel>();
                foreach (var adverseEvent in Model.ADVERSE_EVENT)
                {
                    AllAE.Add(new AEViewModel(adverseEvent));
                }
                AllAE.CollectionChanged += (sender, e) =>
                {
                    CurrentAE = AllAE.FirstOrDefault();
                };

                AllABTherapy = new ObservableCollection<ABTherapyViewModel>();
                foreach (var abTherapy in Model.AB_THERAPY)
                {
                    AllABTherapy.Add(new ABTherapyViewModel(abTherapy));
                }
                AllABTherapy.CollectionChanged += (sender, e) =>
                {
                    CurrentABTherapy = AllABTherapy.FirstOrDefault();
                };
                AllMicrobiologyBlood = new ObservableCollection<MicrobiologyBloodViewModel>();
                foreach (var microbiologyBlood in Model.MICROBIOLOGY_BLOOD)
                {
                    AllMicrobiologyBlood.Add(new MicrobiologyBloodViewModel(microbiologyBlood));
                }
                AllMicrobiologyBlood.CollectionChanged += (sender, e) =>
                {
                    CurrentMBBlood = AllMicrobiologyBlood.FirstOrDefault();
                };
                AllMicrobiologySputum = new ObservableCollection<MicrobiologySputumViewModel>();
                foreach (var microbiologySputum in Model.MICROBIOLOGY_SPUTUM)
                {
                    AllMicrobiologySputum.Add(new MicrobiologySputumViewModel(microbiologySputum));
                }
                AllMicrobiologySputum.CollectionChanged += (sender, e) =>
                {
                    CurrentMBSputum = AllMicrobiologySputum.FirstOrDefault();
                };

                SaveCommand = new DelegateCommand(o => Save());
                CheckCommand = new DelegateCommand(o => Check());
                CancelCommand = new DelegateCommand(o => Cancel());
                AddABTherapyCommand = new DelegateCommand(o => AddAbTherapy());
                DeleteABTherapyCommand = new DelegateCommand(o => DeleteABTherapy(), o=> CurrentABTherapy !=null);
          
             
                AddMBSputumCommand = new DelegateCommand(o => AddMBSputum());
                DeleteMBSputumCommand = new DelegateCommand(o => DeleteMBSputum(), o=> CurrentMBSputum != null);
             
                AddMBBloodCommand = new DelegateCommand(o => AddMBBlood());
                DeleteMBBloodCommand = new DelegateCommand(o => DeleteMBBlood(), o=> CurrentMBBlood != null);
                AddAECommand = new DelegateCommand(o => AddAE());
                DeleteAECommand = new DelegateCommand(o => DeleteAE(), o => CurrentAE != null);

            }
        }

        public ObservableCollection<ABTherapyViewModel> AllABTherapy { get; private set; }
        public ObservableCollection<AEViewModel> AllAE { get; private set; } 
        public ObservableCollection<MicrobiologySputumViewModel> AllMicrobiologySputum { get; private set; }
        public ObservableCollection<MicrobiologyBloodViewModel> AllMicrobiologyBlood { get; private set; }

        public AEViewModel CurrentAE
        {
            get { return currentAE; }
            set
            {
                currentAE = value;
                OnPropertyChanged("CurrentAE");
            }
        }
        public ABTherapyViewModel CurrentABTherapy
        {
            get { return currentABTherapy; }
            set
            {
                currentABTherapy = value;
                OnPropertyChanged("CurrentABTherapy");
            }
        }

        public MicrobiologySputumViewModel CurrentMBSputum
        {
            get { return currentMBSputum; }
            set
            {
                currentMBSputum = value;
                OnPropertyChanged("CurrentMBSputum");
            }
        }

        public MicrobiologyBloodViewModel CurrentMBBlood
        {
            get { return currentMBBlood; }
            set
            {
                currentMBBlood = value;
                OnPropertyChanged("CurrentMBBlood");
            }
        }



        public ICommand SaveCommand { get; private set; }
        private void Save()
        {
            DataManager.Instance.Save();
        }
        public ICommand CheckCommand { get; private set; }
        private void Check()
        {

        }
        public ICommand CancelCommand { get; private set; }
        private void Cancel()
        {
        }
        public ICommand AddABTherapyCommand { get; private set; }
        private void AddAbTherapy()
        {
            var obj = DataManager.Instance.CreateABforCRF(Model);
            var vm = new ABTherapyViewModel(obj);
            AllABTherapy.Add(vm);
            Model.AB_THERAPY.Add(obj);
            OnPropertyChanged("AllABTherapy");
            CurrentABTherapy = AllABTherapy.LastOrDefault();
        }
        public ICommand DeleteABTherapyCommand { get; private set; }
        private void DeleteABTherapy()
        {
            Model.AB_THERAPY.Remove(CurrentABTherapy.Model);
            DataManager.Instance.DeleteABTherapy(CurrentABTherapy.Model);
            AllABTherapy.Remove(CurrentABTherapy);

            OnPropertyChanged("AllABTherapy");
            CurrentABTherapy = AllABTherapy.FirstOrDefault();
        }
    
  
        public ICommand AddMBSputumCommand { get; private set; }
        private void AddMBSputum()
        {
            var obj = DataManager.Instance.CreateMicrobiologySputumForCRF(Model);
            var vm = new MicrobiologySputumViewModel(obj);
            AllMicrobiologySputum.Add(vm);
            Model.MICROBIOLOGY_SPUTUM.Add(obj);
            OnPropertyChanged("AllMicrobiologySputum");
            CurrentMBSputum = AllMicrobiologySputum.LastOrDefault();
        }
        public ICommand DeleteMBSputumCommand { get; private set; }
        private void DeleteMBSputum()
        {
            //DataManager.Instance.RemoveAEforCRF(CurrentAE.Model);
            Model.MICROBIOLOGY_SPUTUM.Remove(CurrentMBSputum.Model);
            DataManager.Instance.DeleteMBSputum(CurrentMBSputum.Model);
            AllMicrobiologySputum.Remove(CurrentMBSputum);

            OnPropertyChanged("AllMicrobiologySputum");
            CurrentMBSputum = AllMicrobiologySputum.FirstOrDefault();
        }
        public ICommand SelectOrganismForSputumCommand { get; private set; }
       public ICommand AddMBBloodCommand { get; private set; }
        private void AddMBBlood()
        {
            var obj = DataManager.Instance.CreateMicrobiologyBloodForCRF(Model);
            var vm = new MicrobiologyBloodViewModel(obj);
            AllMicrobiologyBlood.Add(vm);
            Model.MICROBIOLOGY_BLOOD.Add(obj);
            OnPropertyChanged("AllMicrobiologyBlood");
            CurrentMBBlood = AllMicrobiologyBlood.LastOrDefault();
        }
        public ICommand DeleteMBBloodCommand { get; private set; }
        private void DeleteMBBlood()
        {
            //DataManager.Instance.RemoveAEforCRF(CurrentAE.Model);
            Model.MICROBIOLOGY_BLOOD.Remove(CurrentMBBlood.Model);
            DataManager.Instance.DeleteMBBlood(CurrentMBBlood.Model);
            AllMicrobiologyBlood.Remove(CurrentMBBlood);

            OnPropertyChanged("AllMicrobiologyBlood");
            CurrentMBBlood = AllMicrobiologyBlood.FirstOrDefault();
        }
        public ICommand AddAECommand { get; private set; }
        private void AddAE()
        {
            var obj = DataManager.Instance.CreateAEforCRF(Model);
            var vm = new AEViewModel(obj);
            AllAE.Add(vm);
            Model.ADVERSE_EVENT.Add(obj);
            OnPropertyChanged("AllAE");
            CurrentAE = AllAE.LastOrDefault();
        }
        public ICommand DeleteAECommand { get; private set; }
        private void DeleteAE()
        {
            //DataManager.Instance.RemoveAEforCRF(CurrentAE.Model);
            Model.ADVERSE_EVENT.Remove(CurrentAE.Model);
            DataManager.Instance.DeleteAE(CurrentAE.Model);
            AllAE.Remove(CurrentAE);
        
            OnPropertyChanged("AllAE");
            CurrentAE = AllAE.FirstOrDefault();
        }
     

        #region ComboBox Sources
        public List<string> AEHeavyLookup
        {
            get { return DataManager.Instance.AEHeavyLookup; }

        }
        public List<string> AEResultLookup
        {
            get { return DataManager.Instance.AEResultLookup; }

        }
        public List<string> AERelationLookup
        {
            get { return DataManager.Instance.AERelationLookup; }

        }
        public List<string> AEActionsLookup
        {
            get { return DataManager.Instance.AEActionsLookup; }

        }
        public List<string> ResultLookup
        {
            get { return DataManager.Instance.ResultLookup; }

        }
        public List<string> EfficiencyLookup
        {
            get { return DataManager.Instance.EfficiencyLookup; }
        }
        public List<string> DinamicLookup
        {
            get { return DataManager.Instance.DinamicLookup; }
        }
        public List<string> IncidenceEdemaLookup
        {
            get { return DataManager.Instance.IncidenceEdemaLookup; }
        }
        public List<string> SputumTypeLookup
        {
            get { return DataManager.Instance.SputumTypeLookup; }
        }
        public List<string> HeavyLookup
        {
            get { return DataManager.Instance.HeavyLookup; }
        }
        public List<string> SmokeStatusLookup
        {
            get { return DataManager.Instance.SmokeStatusLookup; }
        }
        public List<string> Logic3Lookup
        {
            get { return DataManager.Instance.Logic3Lookup; }
        }
        public List<string> Logic3Type2Lookup
        {
            get { return DataManager.Instance.Logic3Type2Lookup; }
        }
        public List<string> Logic2Lookup
        {
            get { return DataManager.Instance.Logic2Lookup; }
        }
        public List<WARD> WardLookup
        {
            get { return DataManager.Instance.WardLookup; }
        }
        public List<DRUG> DrugLookup
        {
            get { return DataManager.Instance.DrugLookup; }
        }
        public List<ROUTE> RouteLookup
        {
            get { return DataManager.Instance.RouteLookup; }
        }
        public List<ORGANISM> OrganismLookup
        {
            get { return DataManager.Instance.OrganismLookup; }
        }
        public List<string> FkLookup
        {
            get { return DataManager.Instance.FkLookup; }
        }
        #endregion

        #region CRF FIELDS

        public int NUMBER
        {
            get { return Model.NUMBER; }
            set
            {
               Model.NUMBER = value;
                OnPropertyChanged("NUMBER");
            }
        }

        public WARD WARD
        {
            get { return Model.WARD; }
            set
            {
                Model.WARD = value;
                OnPropertyChanged("WARD");
            }
        }

        public string NAME
        {
            get { return Model.NAME; }
            set
            {
                Model.NAME = value;
                OnPropertyChanged("NAME");
            }
        }

        public DateTime? DATE_BIRTH
        {
            get { return Model.DATE_BIRTH; }
            set
            {
                    Model.DATE_BIRTH = value;
                    OnPropertyChanged("DATE_BIRTH");
            }
        }

        public DateTime? DATE_HOSPITALIZATION
        {
            get { return Model.DATE_HOSPITALISATION; }
            set
            {
                Model.DATE_HOSPITALISATION = value;
                OnPropertyChanged("DATE_HOSPITALIZATION");
            }
        }

        public DateTime? DATE_DISCHARGE
        {
            get { return Model.DATE_DISCHARGE; }
            set
            {
                Model.DATE_DISCHARGE = value;
                OnPropertyChanged("DATE_DISCHARGE");
            }
        }

        public string AE_LOGIC
        {
            get { return Model.AE_LOGIC; }
            set
            {
                Model.AE_LOGIC = value;
                OnPropertyChanged("AE_LOGIC");
            }
        }

        #endregion

        #region VISIT ONE

        public DateTime? DATE_VISIT_ONE
        {
            get { return Model.VISIT_ONE.DATE_VISIT; }
            set
            {
                Model.VISIT_ONE.DATE_VISIT = value;
                OnPropertyChanged("DATE_VISIT_ONE");
            }
        }

        #endregion
        #region VISIT ONE ANAMNESTIC

        public DateTime? VISIT_ONE_ANAMNESTIC_DATE_SYMPTOM
        {
            get { return Model.VISIT_ONE.ANAMNESTIC_DATA.DATE_SYMPTOM; }
            set
            {
                Model.VISIT_ONE.ANAMNESTIC_DATA.DATE_SYMPTOM = value;
                OnPropertyChanged("VISIT_ONE_ANAMNESTIC_DATE_SYMPTOM");
            }
        }

        public DateTime? VISIT_ONE_ANAMNESTIC_DATE_DIAGNOSIS
        {
            get { return Model.VISIT_ONE.ANAMNESTIC_DATA.DATE_DIAGNOSIS; }
            set
            {
                Model.VISIT_ONE.ANAMNESTIC_DATA.DATE_DIAGNOSIS = value;
                OnPropertyChanged("VISIT_ONE_ANAMNESTIC_DATE_DIAGNOSIS");
            }
        }

        public int? VISIT_ONE_ANAMNESTIC_NUMBER_EPISODES
        {
            get { return Model.VISIT_ONE.ANAMNESTIC_DATA.NUMBER_EPISODES; }
            set
            {
                Model.VISIT_ONE.ANAMNESTIC_DATA.NUMBER_EPISODES = value;
                OnPropertyChanged("VISIT_ONE_ANAMNESTIC_NUMBER_EPISODES");
            }
        }

        public bool? VISIT_ONE_ANAMNESTIC_NUMBER_EPISODES_NODATA
        {
            get
            {
                if (Model.VISIT_ONE.ANAMNESTIC_DATA.NUMBER_EPISODES_NODATA == null)
                {
                    return false;
                }
                else
                {
                    return Model.VISIT_ONE.ANAMNESTIC_DATA.NUMBER_EPISODES_NODATA;
                }
            }
            set
            {
                Model.VISIT_ONE.ANAMNESTIC_DATA.NUMBER_EPISODES_NODATA = value;
                if (value == true)
                {
                    VISIT_ONE_ANAMNESTIC_NUMBER_EPISODES = null;
                }
                OnPropertyChanged("VISIT_ONE_ANAMNESTIC_NUMBER_EPISODES_NODATA");
            }
        }

        public string VISIT_ONE_ANAMNESTIC_FUNCTION_CLASS
        {
            get { return Model.VISIT_ONE.ANAMNESTIC_DATA.FUNCTION_CLASS; }
            set
            {
                Model.VISIT_ONE.ANAMNESTIC_DATA.FUNCTION_CLASS = value;
                OnPropertyChanged("VISIT_ONE_ANAMNESTIC_FUNCTION_CLASS");
            }
        }

        public string VISIT_ONE_ANAMNESTIC_OTHER_EPISODES
        {
            get { return Model.VISIT_ONE.ANAMNESTIC_DATA.OTHER_EPISODES; }
            set
            {
                Model.VISIT_ONE.ANAMNESTIC_DATA.OTHER_EPISODES = value;
                OnPropertyChanged("VISIT_ONE_ANAMNESTIC_OTHER_EPISODES");
            }
        }

        public string VISIT_ONE_ANAMNESTIC_SMOKE_STATUS
        {
            get { return Model.VISIT_ONE.ANAMNESTIC_DATA.SMOKE_STATUS; }
            set
            {
                Model.VISIT_ONE.ANAMNESTIC_DATA.SMOKE_STATUS = value;
                OnPropertyChanged("VISIT_ONE_ANAMNESTIC_SMOKE_STATUS");
            }
        }

        public int? VISIT_ONE_ANAMNESTIC_SMOKE_AVERAGE
        {
            get { return Model.VISIT_ONE.ANAMNESTIC_DATA.SMOKE_AVERAGE; }
            set
            {
                Model.VISIT_ONE.ANAMNESTIC_DATA.SMOKE_AVERAGE = value;
                OnPropertyChanged("VISIT_ONE_ANAMNESTIC_SMOKE_AVERAGE");
            }
        }

        public int? VISIT_ONE_ANAMNESTIC_SMOKE_YEARS
        {
            get { return Model.VISIT_ONE.ANAMNESTIC_DATA.SMOKE_YEARS; }
            set
            {
                Model.VISIT_ONE.ANAMNESTIC_DATA.SMOKE_YEARS = value;
                OnPropertyChanged("VISIT_ONE_ANAMNESTIC_SMOKE_YEARS");
            }
        }

        public decimal? VISIT_ONE_ANAMNESTIC_SMOKE_PACK_YEARS
        {
            get { return Model.VISIT_ONE.ANAMNESTIC_DATA.SMOKE_PACK_YEARS; }
            set
            {
                Model.VISIT_ONE.ANAMNESTIC_DATA.SMOKE_PACK_YEARS = value;
                OnPropertyChanged("VISIT_ONE_ANAMNESTIC_SMOKE_PACK_YEARS");
            }
        }
        #endregion
        #region VISIT ONE BASE LIVE INDICATIONS

        public int? VISIT_ONE_BLOOD_PRESSURE_RIGHT_HAND
        {
            get { return Model.VISIT_ONE.BASE_LIVE_INDICATORS_VISIT_1.BLOOD_PRESSURE_RIGHT_HAND; }
            set
            {
                Model.VISIT_ONE.BASE_LIVE_INDICATORS_VISIT_1.BLOOD_PRESSURE_RIGHT_HAND = value;
                OnPropertyChanged("VISIT_ONE_BLOOD_PRESSURE_RIGHT_HAND");
            }
        }

        public int? VISIT_ONE_BLOOD_PRESSURE_LEFT_HAND
        {
            get { return Model.VISIT_ONE.BASE_LIVE_INDICATORS_VISIT_1.BLOOD_PRESSURE_LEFT_HAND; }
            set
            {
                Model.VISIT_ONE.BASE_LIVE_INDICATORS_VISIT_1.BLOOD_PRESSURE_LEFT_HAND = value;
                OnPropertyChanged("VISIT_ONE_BLOOD_PRESSURE_LEFT_HAND");
            }
        }
        public int? VISIT_ONE_HEART_RATE
        {
            get { return Model.VISIT_ONE.BASE_LIVE_INDICATORS_VISIT_1.HEART_RATE; }
            set
            {
                Model.VISIT_ONE.BASE_LIVE_INDICATORS_VISIT_1.HEART_RATE = value;
                OnPropertyChanged("VISIT_ONE_HEART_RATE");
            }
        }
        public int? VISIT_ONE_RESPIRATORY_RATE
        {
            get { return Model.VISIT_ONE.BASE_LIVE_INDICATORS_VISIT_1.RESPIRATORY_RATE; }
            set
            {
                Model.VISIT_ONE.BASE_LIVE_INDICATORS_VISIT_1.RESPIRATORY_RATE = value;
                OnPropertyChanged("VISIT_ONE_RESPIRATORY_RATE");
            }
        }

        public decimal? VISIT_ONE_TEMPERATURE
        {
            get { return Model.VISIT_ONE.BASE_LIVE_INDICATORS_VISIT_1.TEMPERATURE; }
            set
            {
                Model.VISIT_ONE.BASE_LIVE_INDICATORS_VISIT_1.TEMPERATURE = value;
                OnPropertyChanged("VISIT_ONE_TEMPERATURE");
            }
        }

        public string VISIT_ONE_HEAVY_TYPE
        {
            get { return Model.VISIT_ONE.BASE_LIVE_INDICATORS_VISIT_1.HEAVY_TYPE; }
            set
            {
                Model.VISIT_ONE.BASE_LIVE_INDICATORS_VISIT_1.HEAVY_TYPE = value;
                OnPropertyChanged("VISIT_ONE_HEAVY_TYPE");
            }
        }

        public string VISIT_ONE_OXYGEN_THERAPY_NEEDED
        {
            get { return Model.VISIT_ONE.BASE_LIVE_INDICATORS_VISIT_1.OXYGEN_THERAPY_NEEDED; }
            set
            {
                Model.VISIT_ONE.BASE_LIVE_INDICATORS_VISIT_1.OXYGEN_THERAPY_NEEDED = value;
                OnPropertyChanged("VISIT_ONE_OXYGEN_THERAPY_NEEDED");
            }
        }

        public string VISIT_ONE_DECOMPENSATION_SIGNS
        {
            get { return Model.VISIT_ONE.BASE_LIVE_INDICATORS_VISIT_1.DECOMPENSATION_SIGNS; }
            set
            {
                Model.VISIT_ONE.BASE_LIVE_INDICATORS_VISIT_1.DECOMPENSATION_SIGNS = value;
                OnPropertyChanged("VISIT_ONE_DECOMPENSATION_SIGNS");
            }
        }

        #endregion
        #region VISIT ONE EVALUATION SYMPTOM

        public string VISIT_ONE_SYMPTOMS_DYSPNEA
        {
            get { return Model.VISIT_ONE.EVALUATION_OF_SYMPTOMS_VISIT_1.DYSPNEA; }
            set
            {
                Model.VISIT_ONE.EVALUATION_OF_SYMPTOMS_VISIT_1.DYSPNEA = value;
                OnPropertyChanged("VISIT_ONE_SYMPTOMS_DYSPNEA");
            }
        }
        public string VISIT_ONE_SYMPTOMS_COUGH
        {
            get { return Model.VISIT_ONE.EVALUATION_OF_SYMPTOMS_VISIT_1.COUGH; }
            set
            {
                Model.VISIT_ONE.EVALUATION_OF_SYMPTOMS_VISIT_1.COUGH = value;
                OnPropertyChanged("VISIT_ONE_SYMPTOMS_COUGH");
            }
        }
        public string VISIT_ONE_SYMPTOMS_SPUTUM
        {
            get { return Model.VISIT_ONE.EVALUATION_OF_SYMPTOMS_VISIT_1.SPUTUM; }
            set
            {
                Model.VISIT_ONE.EVALUATION_OF_SYMPTOMS_VISIT_1.SPUTUM = value;
                OnPropertyChanged("VISIT_ONE_SYMPTOMS_SPUTUM");
            }
        }
        public string VISIT_ONE_SYMPTOMS_SPUTUM_TYPE
        {
            get { return Model.VISIT_ONE.EVALUATION_OF_SYMPTOMS_VISIT_1.SPUTUM_TYPE; }
            set
            {
                Model.VISIT_ONE.EVALUATION_OF_SYMPTOMS_VISIT_1.SPUTUM_TYPE = value;
                OnPropertyChanged("VISIT_ONE_SYMPTOMS_SPUTUM_TYPE");
            }
        }
        public string VISIT_ONE_SYMPTOMS_TEMPERATURE_INCREASE
        {
            get { return Model.VISIT_ONE.EVALUATION_OF_SYMPTOMS_VISIT_1.TEMPERATURE_INCREASE; }
            set
            {
                Model.VISIT_ONE.EVALUATION_OF_SYMPTOMS_VISIT_1.TEMPERATURE_INCREASE = value;
                OnPropertyChanged("VISIT_ONE_SYMPTOMS_TEMPERATURE_INCREASE");
            }
        }
        public string VISIT_ONE_SYMPTOMS_COLD_SYMPTOM
        {
            get { return Model.VISIT_ONE.EVALUATION_OF_SYMPTOMS_VISIT_1.COLD_SYMPTOM; }
            set
            {
                Model.VISIT_ONE.EVALUATION_OF_SYMPTOMS_VISIT_1.COLD_SYMPTOM = value;
                OnPropertyChanged("VISIT_ONE_SYMPTOMS_COLD_SYMPTOM");
            }
        }
        public string VISIT_ONE_SYMPTOMS_SHORTERING_OF_PERCUSSION_SOUNDS
        {
            get { return Model.VISIT_ONE.EVALUATION_OF_SYMPTOMS_VISIT_1.SHORTERING_OF_PERCUSSION_SOUNDS; }
            set
            {
                Model.VISIT_ONE.EVALUATION_OF_SYMPTOMS_VISIT_1.SHORTERING_OF_PERCUSSION_SOUNDS = value;
                OnPropertyChanged("VISIT_ONE_SYMPTOMS_SHORTERING_OF_PERCUSSION_SOUNDS");
            }
        }
        public string VISIT_ONE_SYMPTOMS_MOIST_RALES_SOUNDS
        {
            get { return Model.VISIT_ONE.EVALUATION_OF_SYMPTOMS_VISIT_1.MOIST_RALES_SOUNDS; }
            set
            {
                Model.VISIT_ONE.EVALUATION_OF_SYMPTOMS_VISIT_1.MOIST_RALES_SOUNDS = value;
                OnPropertyChanged("VISIT_ONE_SYMPTOMS_MOIST_RALES_SOUNDS");
            }
        }
        public string VISIT_ONE_SYMPTOMS_CREPITUS
        {
            get { return Model.VISIT_ONE.EVALUATION_OF_SYMPTOMS_VISIT_1.CREPITUS; }
            set
            {
                Model.VISIT_ONE.EVALUATION_OF_SYMPTOMS_VISIT_1.CREPITUS = value;
                OnPropertyChanged("VISIT_ONE_SYMPTOMS_CREPITUS");
            }
        }
        public string VISIT_ONE_SYMPTOMS_PLEURAL_FRICTION_NOISE
        {
            get { return Model.VISIT_ONE.EVALUATION_OF_SYMPTOMS_VISIT_1.PLEURAL_FRICTION_NOISE; }
            set
            {
                Model.VISIT_ONE.EVALUATION_OF_SYMPTOMS_VISIT_1.PLEURAL_FRICTION_NOISE = value;
                OnPropertyChanged("VISIT_ONE_SYMPTOMS_PLEURAL_FRICTION_NOISE");
            }
        }

        public string VISIT_ONE_ONE_SYMPTOMS_THERAPY_EFFICIENCY
        {
            get { return Model.VISIT_ONE_ONE.EVALUATION_OF_SYMPTOMS_VISIT_11.THERAPY_EFFICIENCY; }
            set
            {
                Model.VISIT_ONE_ONE.EVALUATION_OF_SYMPTOMS_VISIT_11.THERAPY_EFFICIENCY = value;
                OnPropertyChanged("VISIT_ONE_ONE_SYMPTOMS_THERAPY_EFFICIENCY");
            }
        }
        public string VISIT_ONE_SYMPTOMS_DRY_RALES
        {
            get { return Model.VISIT_ONE.EVALUATION_OF_SYMPTOMS_VISIT_1.DRY_RALES; }
            set
            {
                Model.VISIT_ONE.EVALUATION_OF_SYMPTOMS_VISIT_1.DRY_RALES = value;
                OnPropertyChanged("VISIT_ONE_SYMPTOMS_DRY_RALES");
            }
        }
        public string VISIT_ONE_SYMPTOMS_PRESENCE_OF_EDEMA
        {
            get { return Model.VISIT_ONE.EVALUATION_OF_SYMPTOMS_VISIT_1.PRESENCE_OF_EDEMA; }
            set
            {
                Model.VISIT_ONE.EVALUATION_OF_SYMPTOMS_VISIT_1.PRESENCE_OF_EDEMA = value;
                OnPropertyChanged("VISIT_ONE_SYMPTOMS_PRESENCE_OF_EDEMA");
            }
        }
        public string VISIT_ONE_SYMPTOMS_INCIDENCE_OF_EDEMA
        {
            get { return Model.VISIT_ONE.EVALUATION_OF_SYMPTOMS_VISIT_1.INCIDENCE_OF_EDEMA; }
            set
            {
                Model.VISIT_ONE.EVALUATION_OF_SYMPTOMS_VISIT_1.INCIDENCE_OF_EDEMA = value;
                OnPropertyChanged("VISIT_ONE_SYMPTOMS_INCIDENCE_OF_EDEMA");
            }
        }
        #endregion
        #region VISIT ONE_ONE EVALUATION SYMPTOM

        public string VISIT_ONE_ONE_SYMPTOMS_DYSPNEA
        {
            get { return Model.VISIT_ONE_ONE.EVALUATION_OF_SYMPTOMS_VISIT_11.DYSPNEA; }
            set
            {
                Model.VISIT_ONE_ONE.EVALUATION_OF_SYMPTOMS_VISIT_11.DYSPNEA = value;
                OnPropertyChanged("VISIT_ONE_ONE_SYMPTOMS_DYSPNEA");
            }
        }
        public string VISIT_ONE_ONE_SYMPTOMS_COUGH
        {
            get { return Model.VISIT_ONE_ONE.EVALUATION_OF_SYMPTOMS_VISIT_11.COUGH; }
            set
            {
                Model.VISIT_ONE_ONE.EVALUATION_OF_SYMPTOMS_VISIT_11.COUGH = value;
                OnPropertyChanged("VISIT_ONE_ONE_SYMPTOMS_COUGH");
            }
        }
        public string VISIT_ONE_ONE_SYMPTOMS_SPUTUM
        {
            get { return Model.VISIT_ONE_ONE.EVALUATION_OF_SYMPTOMS_VISIT_11.SPUTUM; }
            set
            {
                Model.VISIT_ONE_ONE.EVALUATION_OF_SYMPTOMS_VISIT_11.SPUTUM = value;
                OnPropertyChanged("VISIT_ONE_ONE_SYMPTOMS_SPUTUM");
            }
        }
        public string VISIT_ONE_ONE_SYMPTOMS_SPUTUM_TYPE
        {
            get { return Model.VISIT_ONE_ONE.EVALUATION_OF_SYMPTOMS_VISIT_11.SPUTUM_TYPE; }
            set
            {
                Model.VISIT_ONE_ONE.EVALUATION_OF_SYMPTOMS_VISIT_11.SPUTUM_TYPE = value;
                OnPropertyChanged("VISIT_ONE_ONE_SYMPTOMS_SPUTUM_TYPE");
            }
        }
        public string VISIT_ONE_ONE_SYMPTOMS_TEMPERATURE_INCREASE
        {
            get { return Model.VISIT_ONE_ONE.EVALUATION_OF_SYMPTOMS_VISIT_11.TEMPERATURE_INCREASE; }
            set
            {
                Model.VISIT_ONE_ONE.EVALUATION_OF_SYMPTOMS_VISIT_11.TEMPERATURE_INCREASE = value;
                OnPropertyChanged("VISIT_ONE_ONE_SYMPTOMS_TEMPERATURE_INCREASE");
            }
        }
        public string VISIT_ONE_ONE_SYMPTOMS_COLD_SYMPTOM
        {
            get { return Model.VISIT_ONE_ONE.EVALUATION_OF_SYMPTOMS_VISIT_11.COLD_SYMPTOM; }
            set
            {
                Model.VISIT_ONE_ONE.EVALUATION_OF_SYMPTOMS_VISIT_11.COLD_SYMPTOM = value;
                OnPropertyChanged("VISIT_ONE_ONE_SYMPTOMS_COLD_SYMPTOM");
            }
        }
        public string VISIT_ONE_ONE_SYMPTOMS_SHORTERING_OF_PERCUSSION_SOUNDS
        {
            get { return Model.VISIT_ONE_ONE.EVALUATION_OF_SYMPTOMS_VISIT_11.SHORTERING_OF_PERCUSSION_SOUNDS; }
            set
            {
                Model.VISIT_ONE_ONE.EVALUATION_OF_SYMPTOMS_VISIT_11.SHORTERING_OF_PERCUSSION_SOUNDS = value;
                OnPropertyChanged("VISIT_ONE_ONE_SYMPTOMS_SHORTERING_OF_PERCUSSION_SOUNDS");
            }
        }
        public string VISIT_ONE_ONE_SYMPTOMS_MOIST_RALES_SOUNDS
        {
            get { return Model.VISIT_ONE_ONE.EVALUATION_OF_SYMPTOMS_VISIT_11.MOIST_RALES_SOUNDS; }
            set
            {
                Model.VISIT_ONE_ONE.EVALUATION_OF_SYMPTOMS_VISIT_11.MOIST_RALES_SOUNDS = value;
                OnPropertyChanged("VISIT_ONE_ONE_SYMPTOMS_MOIST_RALES_SOUNDS");
            }
        }
        public string VISIT_ONE_ONE_SYMPTOMS_CREPITUS
        {
            get { return Model.VISIT_ONE_ONE.EVALUATION_OF_SYMPTOMS_VISIT_11.CREPITUS; }
            set
            {
                Model.VISIT_ONE_ONE.EVALUATION_OF_SYMPTOMS_VISIT_11.CREPITUS = value;
                OnPropertyChanged("VISIT_ONE_ONE_SYMPTOMS_CREPITUS");
            }
        }
        public string VISIT_ONE_ONE_SYMPTOMS_PLEURAL_FRICTION_NOISE
        {
            get { return Model.VISIT_ONE_ONE.EVALUATION_OF_SYMPTOMS_VISIT_11.PLEURAL_FRICTION_NOISE; }
            set
            {
                Model.VISIT_ONE_ONE.EVALUATION_OF_SYMPTOMS_VISIT_11.PLEURAL_FRICTION_NOISE = value;
                OnPropertyChanged("VISIT_ONE_ONE_SYMPTOMS_PLEURAL_FRICTION_NOISE");
            }
        }
        public string VISIT_ONE_ONE_SYMPTOMS_DRY_RALES
        {
            get { return Model.VISIT_ONE_ONE.EVALUATION_OF_SYMPTOMS_VISIT_11.DRY_RALES; }
            set
            {
                Model.VISIT_ONE_ONE.EVALUATION_OF_SYMPTOMS_VISIT_11.DRY_RALES = value;
                OnPropertyChanged("VISIT_ONE_ONE_SYMPTOMS_DRY_RALES");
            }
        }
        public string VISIT_ONE_ONE_SYMPTOMS_PRESENCE_OF_EDEMA
        {
            get { return Model.VISIT_ONE_ONE.EVALUATION_OF_SYMPTOMS_VISIT_11.PRESENCE_OF_EDEMA; }
            set
            {
                Model.VISIT_ONE_ONE.EVALUATION_OF_SYMPTOMS_VISIT_11.PRESENCE_OF_EDEMA = value;
                OnPropertyChanged("VISIT_ONE_ONE_SYMPTOMS_PRESENCE_OF_EDEMA");
            }
        }
        public string VISIT_ONE_ONE_SYMPTOMS_INCIDENCE_OF_EDEMA
        {
            get { return Model.VISIT_ONE_ONE.EVALUATION_OF_SYMPTOMS_VISIT_11.INCIDENCE_OF_EDEMA; }
            set
            {
                Model.VISIT_ONE_ONE.EVALUATION_OF_SYMPTOMS_VISIT_11.INCIDENCE_OF_EDEMA = value;
                OnPropertyChanged("VISIT_ONE_ONE_SYMPTOMS_INCIDENCE_OF_EDEMA");
            }
        }
        #endregion
        #region VISIT ONE XRAY

        public DateTime? XRAY_DATE_PROCEDURE
        {
            get { return Model.VISIT_ONE.XRAY_CHEST_VISIT_1.DATE_PROCEDURE; }
            set
            {
                Model.VISIT_ONE.XRAY_CHEST_VISIT_1.DATE_PROCEDURE = value;
                OnPropertyChanged("XRAY_DATE_PROCEDURE");
            }
        }

        public string XRAY_PNEUMONIA_SIGNS
        {
            get { return Model.VISIT_ONE.XRAY_CHEST_VISIT_1.PNEUMONIA_SIGNS; }
            set
            {
                Model.VISIT_ONE.XRAY_CHEST_VISIT_1.PNEUMONIA_SIGNS = value;
                OnPropertyChanged("XRAY_PNEUMONIA_SIGNS");
            }
        }

        public bool? XRAY_ALVEOLAR_INFILTRATION_RIGHT_TOP
        {
            get
            {
                if (Model.VISIT_ONE.XRAY_CHEST_VISIT_1.ALVEOLAR_INFILTRATION_RIGHT_TOP == null)
                {
                    return false;
                }
                else
                {
                    return Model.VISIT_ONE.XRAY_CHEST_VISIT_1.ALVEOLAR_INFILTRATION_RIGHT_TOP;
                }
            }
            set
            {
                Model.VISIT_ONE.XRAY_CHEST_VISIT_1.ALVEOLAR_INFILTRATION_RIGHT_TOP = value;
                OnPropertyChanged("XRAY_ALVEOLAR_INFILTRATION_RIGHT_TOP");
            }
        }
        public bool? XRAY_ALVEOLAR_INFILTRATION_RIGHT_MIDDLE
        {
            get
            {
                if (Model.VISIT_ONE.XRAY_CHEST_VISIT_1.ALVEOLAR_INFILTRATION_RIGHT_MIDDLE == null)
                {
                    return false;
                }
                else
                {
                    return Model.VISIT_ONE.XRAY_CHEST_VISIT_1.ALVEOLAR_INFILTRATION_RIGHT_MIDDLE;
                }
            }
            set
            {
                Model.VISIT_ONE.XRAY_CHEST_VISIT_1.ALVEOLAR_INFILTRATION_RIGHT_MIDDLE = value;
                OnPropertyChanged("XRAY_ALVEOLAR_INFILTRATION_RIGHT_MIDDLE");
            }
        }
        public bool? XRAY_ALVEOLAR_INFILTRATION_RIGHT_BOTTOM
        {
            get
            {
                if (Model.VISIT_ONE.XRAY_CHEST_VISIT_1.ALVEOLAR_INFILTRATION_RIGHT_BOTTOM == null)
                {
                    return false;
                }
                else
                {
                    return Model.VISIT_ONE.XRAY_CHEST_VISIT_1.ALVEOLAR_INFILTRATION_RIGHT_BOTTOM;
                }
            }
            set
            {
                Model.VISIT_ONE.XRAY_CHEST_VISIT_1.ALVEOLAR_INFILTRATION_RIGHT_BOTTOM = value;
                OnPropertyChanged("XRAY_ALVEOLAR_INFILTRATION_RIGHT_BOTTOM");
            }
        }
        public bool? XRAY_ALVEOLAR_INFILTRATION_LEFT_TOP
        {
            get
            {
                if (Model.VISIT_ONE.XRAY_CHEST_VISIT_1.ALVEOLAR_INFILTRATION_LEFT_TOP == null)
                {
                    return false;
                }
                else
                {
                    return Model.VISIT_ONE.XRAY_CHEST_VISIT_1.ALVEOLAR_INFILTRATION_LEFT_TOP;
                }
            }
            set
            {
                Model.VISIT_ONE.XRAY_CHEST_VISIT_1.ALVEOLAR_INFILTRATION_LEFT_TOP = value;
                OnPropertyChanged("XRAY_ALVEOLAR_INFILTRATION_LEFT_TOP");
            }
        }
        public bool? XRAY_ALVEOLAR_INFILTRATION_LEFT_BOTTOM
        {
            get
            {
                if (Model.VISIT_ONE.XRAY_CHEST_VISIT_1.ALVEOLAR_INFILTRATION_LEFT_BOTTOM == null)
                {
                    return false;
                }
                else
                {
                    return Model.VISIT_ONE.XRAY_CHEST_VISIT_1.ALVEOLAR_INFILTRATION_LEFT_BOTTOM;
                }
            }
            set
            {
                Model.VISIT_ONE.XRAY_CHEST_VISIT_1.ALVEOLAR_INFILTRATION_LEFT_BOTTOM = value;
                OnPropertyChanged("XRAY_ALVEOLAR_INFILTRATION_LEFT_BOTTOM");
            }
        }
        public bool? XRAY_INTERSTITIAL_INFILTRATION_RIGHT_TOP
        {
            get
            {
                if (Model.VISIT_ONE.XRAY_CHEST_VISIT_1.INTERSTITIAL_INFILTRATION_RIGHT_TOP == null)
                {
                    return false;
                }
                else
                {
                    return Model.VISIT_ONE.XRAY_CHEST_VISIT_1.INTERSTITIAL_INFILTRATION_RIGHT_TOP;
                }
            }
            set
            {
                Model.VISIT_ONE.XRAY_CHEST_VISIT_1.INTERSTITIAL_INFILTRATION_RIGHT_TOP = value;
                OnPropertyChanged("XRAY_INTERSTITIAL_INFILTRATION_RIGHT_TOP");
            }
        }
        public bool? XRAY_INTERSTITIAL_INFILTRATION_RIGHT_MIDDLE
        {
            get
            {
                if (Model.VISIT_ONE.XRAY_CHEST_VISIT_1.INTERSTITIAL_INFILTRATION_RIGHT_MIDDLE == null)
                {
                    return false;
                }
                else
                {
                    return Model.VISIT_ONE.XRAY_CHEST_VISIT_1.INTERSTITIAL_INFILTRATION_RIGHT_MIDDLE;
                }
            }
            set
            {
                Model.VISIT_ONE.XRAY_CHEST_VISIT_1.INTERSTITIAL_INFILTRATION_RIGHT_MIDDLE = value;
                OnPropertyChanged("XRAY_INTERSTITIAL_INFILTRATION_RIGHT_MIDDLE");
            }
        }
        public bool? XRAY_INTERSTITIAL_INFILTRATION_RIGHT_BOTTOM
        {
            get
            {
                if (Model.VISIT_ONE.XRAY_CHEST_VISIT_1.INTERSTITIAL_INFILTRATION_RIGHT_BOTTOM == null)
                {
                    return false;
                }
                else
                {
                    return Model.VISIT_ONE.XRAY_CHEST_VISIT_1.INTERSTITIAL_INFILTRATION_RIGHT_BOTTOM;
                }
            }
            set
            {
                Model.VISIT_ONE.XRAY_CHEST_VISIT_1.INTERSTITIAL_INFILTRATION_RIGHT_BOTTOM = value;
                OnPropertyChanged("XRAY_INTERSTITIAL_INFILTRATION_RIGHT_BOTTOM");
            }
        }
        public bool? XRAY_INTERSTITIAL_INFILTRATION_LEFT_TOP
        {
            get
            {
                if (Model.VISIT_ONE.XRAY_CHEST_VISIT_1.INTERSTITIAL_INFILTRATION_LEFT_TOP == null)
                {
                    return false;
                }
                else
                {
                    return Model.VISIT_ONE.XRAY_CHEST_VISIT_1.INTERSTITIAL_INFILTRATION_LEFT_TOP;
                }
            }
            set
            {
                Model.VISIT_ONE.XRAY_CHEST_VISIT_1.INTERSTITIAL_INFILTRATION_LEFT_TOP = value;
                OnPropertyChanged("XRAY_INTERSTITIAL_INFILTRATION_LEFT_TOP");
            }
        }
        public bool? XRAY_INTERSTITIAL_INFILTRATION_LEFT_BOTTOM
        {
            get
            {
                if (Model.VISIT_ONE.XRAY_CHEST_VISIT_1.INTERSTITIAL_INFILTRATION_LEFT_BOTTOM == null)
                {
                    return false;
                }
                else
                {
                    return Model.VISIT_ONE.XRAY_CHEST_VISIT_1.INTERSTITIAL_INFILTRATION_LEFT_BOTTOM;
                }
            }
            set
            {
                Model.VISIT_ONE.XRAY_CHEST_VISIT_1.INTERSTITIAL_INFILTRATION_LEFT_BOTTOM = value;
                OnPropertyChanged("XRAY_INTERSTITIAL_INFILTRATION_LEFT_BOTTOM");
            }
        }
        public bool? XRAY_PLEURAL_EFFUSION_NONE
        {
            get
            {
                if (Model.VISIT_ONE.XRAY_CHEST_VISIT_1.PLEURAL_EFFUSION_NONE == null)
                {
                    return false;
                }
                else
                {
                    return Model.VISIT_ONE.XRAY_CHEST_VISIT_1.PLEURAL_EFFUSION_NONE;
                }
            }
            set
            {
                Model.VISIT_ONE.XRAY_CHEST_VISIT_1.PLEURAL_EFFUSION_NONE = value;
                OnPropertyChanged("XRAY_PLEURAL_EFFUSION_NONE");
            }
        }
        public bool? XRAY_PLEURAL_EFFUSION_RIGHT
        {
            get
            {
                if (Model.VISIT_ONE.XRAY_CHEST_VISIT_1.PLEURAL_EFFUSION_RIGHT == null)
                {
                    return false;
                }
                else
                {
                    return Model.VISIT_ONE.XRAY_CHEST_VISIT_1.PLEURAL_EFFUSION_RIGHT;
                }
            }
            set
            {
                Model.VISIT_ONE.XRAY_CHEST_VISIT_1.PLEURAL_EFFUSION_RIGHT = value;
                OnPropertyChanged("XRAY_PLEURAL_EFFUSION_RIGHT");
            }
        }
        public bool? XRAY_PLEURAL_EFFUSION_LEFT
        {
            get
            {
                if (Model.VISIT_ONE.XRAY_CHEST_VISIT_1.PLEURAL_EFFUSION_LEFT == null)
                {
                    return false;
                }
                else
                {
                    return Model.VISIT_ONE.XRAY_CHEST_VISIT_1.PLEURAL_EFFUSION_LEFT;
                }
            }
            set
            {
                Model.VISIT_ONE.XRAY_CHEST_VISIT_1.PLEURAL_EFFUSION_LEFT = value;
                OnPropertyChanged("XRAY_PLEURAL_EFFUSION_LEFT");
            }
        }
        public bool? XRAY_PLEURAL_EFFUSION_DOUBLE
        {
            get
            {
                if (Model.VISIT_ONE.XRAY_CHEST_VISIT_1.PLEURAL_EFFUSION_DOUBLE == null)
                {
                    return false;
                }
                else
                {
                    return Model.VISIT_ONE.XRAY_CHEST_VISIT_1.PLEURAL_EFFUSION_DOUBLE;
                }
            }
            set
            {
                Model.VISIT_ONE.XRAY_CHEST_VISIT_1.PLEURAL_EFFUSION_DOUBLE = value;
                OnPropertyChanged("XRAY_PLEURAL_EFFUSION_DOUBLE");
            }
        }

        public string XRAY_OTHER
        {
            get { return Model.VISIT_ONE.XRAY_CHEST_VISIT_1.OTHER; }
            set
            {
                Model.VISIT_ONE.XRAY_CHEST_VISIT_1.OTHER = value;
                OnPropertyChanged("XRAY_OTHER");
            }
        }

        #endregion
        #region VISIT ONE COMP TOMOGRAPHY


        public DateTime? COMPUTED_TOMOGRAPHY_DATE_PROCEDURE
        {
            get { return Model.VISIT_ONE.COMPUTED_TOMOGRAPHY_CHEST_VISIT_1.DATE_PROCEDURE; }
            set
            {
                Model.VISIT_ONE.COMPUTED_TOMOGRAPHY_CHEST_VISIT_1.DATE_PROCEDURE = value;
                OnPropertyChanged("COMPUTED_TOMOGRAPHY_DATE_PROCEDURE");
            }
        }

        public string COMPUTED_TOMOGRAPHY_PNEUMONIA_SIGNS
        {
            get { return Model.VISIT_ONE.COMPUTED_TOMOGRAPHY_CHEST_VISIT_1.PNEUMONIA_SIGNS; }
            set
            {
                Model.VISIT_ONE.COMPUTED_TOMOGRAPHY_CHEST_VISIT_1.PNEUMONIA_SIGNS = value;
                OnPropertyChanged("COMPUTED_TOMOGRAPHY_PNEUMONIA_SIGNS");
            }
        }

        public bool? COMPUTED_TOMOGRAPHY_ALVEOLAR_INFILTRATION_RIGHT_TOP
        {
            get
            {
                if (Model.VISIT_ONE.COMPUTED_TOMOGRAPHY_CHEST_VISIT_1.ALVEOLAR_INFILTRATION_RIGHT_TOP == null)
                {
                    return false;
                }
                else
                {
                    return Model.VISIT_ONE.COMPUTED_TOMOGRAPHY_CHEST_VISIT_1.ALVEOLAR_INFILTRATION_RIGHT_TOP;
                }
            }
            set
            {
                Model.VISIT_ONE.COMPUTED_TOMOGRAPHY_CHEST_VISIT_1.ALVEOLAR_INFILTRATION_RIGHT_TOP = value;
                OnPropertyChanged("COMPUTED_TOMOGRAPHY_ALVEOLAR_INFILTRATION_RIGHT_TOP");
            }
        }
        public bool? COMPUTED_TOMOGRAPHY_ALVEOLAR_INFILTRATION_RIGHT_MIDDLE
        {
            get
            {
                if (Model.VISIT_ONE.COMPUTED_TOMOGRAPHY_CHEST_VISIT_1.ALVEOLAR_INFILTRATION_RIGHT_MIDDLE == null)
                {
                    return false;
                }
                else
                {
                    return Model.VISIT_ONE.COMPUTED_TOMOGRAPHY_CHEST_VISIT_1.ALVEOLAR_INFILTRATION_RIGHT_MIDDLE;
                }
            }
            set
            {
                Model.VISIT_ONE.COMPUTED_TOMOGRAPHY_CHEST_VISIT_1.ALVEOLAR_INFILTRATION_RIGHT_MIDDLE = value;
                OnPropertyChanged("COMPUTED_TOMOGRAPHY_ALVEOLAR_INFILTRATION_RIGHT_MIDDLE");
            }
        }
        public bool? COMPUTED_TOMOGRAPHY_ALVEOLAR_INFILTRATION_RIGHT_BOTTOM
        {
            get
            {
                if (Model.VISIT_ONE.COMPUTED_TOMOGRAPHY_CHEST_VISIT_1.ALVEOLAR_INFILTRATION_RIGHT_BOTTOM == null)
                {
                    return false;
                }
                else
                {
                    return Model.VISIT_ONE.COMPUTED_TOMOGRAPHY_CHEST_VISIT_1.ALVEOLAR_INFILTRATION_RIGHT_BOTTOM;
                }
            }
            set
            {
                Model.VISIT_ONE.COMPUTED_TOMOGRAPHY_CHEST_VISIT_1.ALVEOLAR_INFILTRATION_RIGHT_BOTTOM = value;
                OnPropertyChanged("COMPUTED_TOMOGRAPHY_ALVEOLAR_INFILTRATION_RIGHT_BOTTOM");
            }
        }
        public bool? COMPUTED_TOMOGRAPHY_ALVEOLAR_INFILTRATION_LEFT_TOP
        {
            get
            {
                if (Model.VISIT_ONE.COMPUTED_TOMOGRAPHY_CHEST_VISIT_1.ALVEOLAR_INFILTRATION_LEFT_TOP == null)
                {
                    return false;
                }
                else
                {
                    return Model.VISIT_ONE.COMPUTED_TOMOGRAPHY_CHEST_VISIT_1.ALVEOLAR_INFILTRATION_LEFT_TOP;
                }
            }
            set
            {
                Model.VISIT_ONE.COMPUTED_TOMOGRAPHY_CHEST_VISIT_1.ALVEOLAR_INFILTRATION_LEFT_TOP = value;
                OnPropertyChanged("COMPUTED_TOMOGRAPHY_ALVEOLAR_INFILTRATION_LEFT_TOP");
            }
        }
        public bool? COMPUTED_TOMOGRAPHY_ALVEOLAR_INFILTRATION_LEFT_BOTTOM
        {
            get
            {
                if (Model.VISIT_ONE.COMPUTED_TOMOGRAPHY_CHEST_VISIT_1.ALVEOLAR_INFILTRATION_LEFT_BOTTOM == null)
                {
                    return false;
                }
                else
                {
                    return Model.VISIT_ONE.COMPUTED_TOMOGRAPHY_CHEST_VISIT_1.ALVEOLAR_INFILTRATION_LEFT_BOTTOM;
                }
            }
            set
            {
                Model.VISIT_ONE.COMPUTED_TOMOGRAPHY_CHEST_VISIT_1.ALVEOLAR_INFILTRATION_LEFT_BOTTOM = value;
                OnPropertyChanged("COMPUTED_TOMOGRAPHY_ALVEOLAR_INFILTRATION_LEFT_BOTTOM");
            }
        }
        public bool? COMPUTED_TOMOGRAPHY_INTERSTITIAL_INFILTRATION_RIGHT_TOP
        {
            get
            {
                if (Model.VISIT_ONE.COMPUTED_TOMOGRAPHY_CHEST_VISIT_1.INTERSTITIAL_INFILTRATION_RIGHT_TOP == null)
                {
                    return false;
                }
                else
                {
                    return Model.VISIT_ONE.COMPUTED_TOMOGRAPHY_CHEST_VISIT_1.INTERSTITIAL_INFILTRATION_RIGHT_TOP;
                }
            }
            set
            {
                Model.VISIT_ONE.COMPUTED_TOMOGRAPHY_CHEST_VISIT_1.INTERSTITIAL_INFILTRATION_RIGHT_TOP = value;
                OnPropertyChanged("COMPUTED_TOMOGRAPHY_INTERSTITIAL_INFILTRATION_RIGHT_TOP");
            }
        }
        public bool? COMPUTED_TOMOGRAPHY_INTERSTITIAL_INFILTRATION_RIGHT_MIDDLE
        {
            get
            {
                if (Model.VISIT_ONE.COMPUTED_TOMOGRAPHY_CHEST_VISIT_1.INTERSTITIAL_INFILTRATION_RIGHT_MIDDLE == null)
                {
                    return false;
                }
                else
                {
                    return Model.VISIT_ONE.COMPUTED_TOMOGRAPHY_CHEST_VISIT_1.INTERSTITIAL_INFILTRATION_RIGHT_MIDDLE;
                }
            }
            set
            {
                Model.VISIT_ONE.COMPUTED_TOMOGRAPHY_CHEST_VISIT_1.INTERSTITIAL_INFILTRATION_RIGHT_MIDDLE = value;
                OnPropertyChanged("COMPUTED_TOMOGRAPHY_INTERSTITIAL_INFILTRATION_RIGHT_MIDDLE");
            }
        }
        public bool? COMPUTED_TOMOGRAPHY_INTERSTITIAL_INFILTRATION_RIGHT_BOTTOM
        {
            get
            {
                if (Model.VISIT_ONE.COMPUTED_TOMOGRAPHY_CHEST_VISIT_1.INTERSTITIAL_INFILTRATION_RIGHT_BOTTOM == null)
                {
                    return false;
                }
                else
                {
                    return Model.VISIT_ONE.COMPUTED_TOMOGRAPHY_CHEST_VISIT_1.INTERSTITIAL_INFILTRATION_RIGHT_BOTTOM;
                }
            }
            set
            {
                Model.VISIT_ONE.COMPUTED_TOMOGRAPHY_CHEST_VISIT_1.INTERSTITIAL_INFILTRATION_RIGHT_BOTTOM = value;
                OnPropertyChanged("COMPUTED_TOMOGRAPHY_INTERSTITIAL_INFILTRATION_RIGHT_BOTTOM");
            }
        }
        public bool? COMPUTED_TOMOGRAPHY_INTERSTITIAL_INFILTRATION_LEFT_TOP
        {
            get
            {
                if (Model.VISIT_ONE.COMPUTED_TOMOGRAPHY_CHEST_VISIT_1.INTERSTITIAL_INFILTRATION_LEFT_TOP == null)
                {
                    return false;
                }
                else
                {
                    return Model.VISIT_ONE.COMPUTED_TOMOGRAPHY_CHEST_VISIT_1.INTERSTITIAL_INFILTRATION_LEFT_TOP;
                }
            }
            set
            {
                Model.VISIT_ONE.COMPUTED_TOMOGRAPHY_CHEST_VISIT_1.INTERSTITIAL_INFILTRATION_LEFT_TOP = value;
                OnPropertyChanged("COMPUTED_TOMOGRAPHY_INTERSTITIAL_INFILTRATION_LEFT_TOP");
            }
        }
        public bool? COMPUTED_TOMOGRAPHY_INTERSTITIAL_INFILTRATION_LEFT_BOTTOM
        {
            get
            {
                if (Model.VISIT_ONE.COMPUTED_TOMOGRAPHY_CHEST_VISIT_1.INTERSTITIAL_INFILTRATION_LEFT_BOTTOM == null)
                {
                    return false;
                }
                else
                {
                    return Model.VISIT_ONE.COMPUTED_TOMOGRAPHY_CHEST_VISIT_1.INTERSTITIAL_INFILTRATION_LEFT_BOTTOM;
                }
            }
            set
            {
                Model.VISIT_ONE.COMPUTED_TOMOGRAPHY_CHEST_VISIT_1.INTERSTITIAL_INFILTRATION_LEFT_BOTTOM = value;
                OnPropertyChanged("COMPUTED_TOMOGRAPHY_INTERSTITIAL_INFILTRATION_LEFT_BOTTOM");
            }
        }
        public bool? COMPUTED_TOMOGRAPHY_PLEURAL_EFFUSION_NONE
        {
            get
            {
                if (Model.VISIT_ONE.COMPUTED_TOMOGRAPHY_CHEST_VISIT_1.PLEURAL_EFFUSION_NONE == null)
                {
                    return false;
                }
                else
                {
                    return Model.VISIT_ONE.COMPUTED_TOMOGRAPHY_CHEST_VISIT_1.PLEURAL_EFFUSION_NONE;
                }
            }
            set
            {
                Model.VISIT_ONE.COMPUTED_TOMOGRAPHY_CHEST_VISIT_1.PLEURAL_EFFUSION_NONE = value;
                OnPropertyChanged("COMPUTED_TOMOGRAPHY_PLEURAL_EFFUSION_NONE");
            }
        }
        public bool? COMPUTED_TOMOGRAPHY_PLEURAL_EFFUSION_RIGHT
        {
            get
            {
                if (Model.VISIT_ONE.COMPUTED_TOMOGRAPHY_CHEST_VISIT_1.PLEURAL_EFFUSION_RIGHT == null)
                {
                    return false;
                }
                else
                {
                    return Model.VISIT_ONE.COMPUTED_TOMOGRAPHY_CHEST_VISIT_1.PLEURAL_EFFUSION_RIGHT;
                }
            }
            set
            {
                Model.VISIT_ONE.COMPUTED_TOMOGRAPHY_CHEST_VISIT_1.PLEURAL_EFFUSION_RIGHT = value;
                OnPropertyChanged("COMPUTED_TOMOGRAPHY_PLEURAL_EFFUSION_RIGHT");
            }
        }
        public bool? COMPUTED_TOMOGRAPHY_PLEURAL_EFFUSION_LEFT
        {
            get
            {
                if (Model.VISIT_ONE.COMPUTED_TOMOGRAPHY_CHEST_VISIT_1.PLEURAL_EFFUSION_LEFT == null)
                {
                    return false;
                }
                else
                {
                    return Model.VISIT_ONE.COMPUTED_TOMOGRAPHY_CHEST_VISIT_1.PLEURAL_EFFUSION_LEFT;
                }
            }
            set
            {
                Model.VISIT_ONE.COMPUTED_TOMOGRAPHY_CHEST_VISIT_1.PLEURAL_EFFUSION_LEFT = value;
                OnPropertyChanged("COMPUTED_TOMOGRAPHY_PLEURAL_EFFUSION_LEFT");
            }
        }
        public bool? COMPUTED_TOMOGRAPHY_PLEURAL_EFFUSION_DOUBLE
        {
            get
            {
                if (Model.VISIT_ONE.COMPUTED_TOMOGRAPHY_CHEST_VISIT_1.PLEURAL_EFFUSION_DOUBLE == null)
                {
                    return false;
                }
                else
                {
                    return Model.VISIT_ONE.COMPUTED_TOMOGRAPHY_CHEST_VISIT_1.PLEURAL_EFFUSION_DOUBLE;
                }
            }
            set
            {
                Model.VISIT_ONE.COMPUTED_TOMOGRAPHY_CHEST_VISIT_1.PLEURAL_EFFUSION_DOUBLE = value;
                OnPropertyChanged("COMPUTED_TOMOGRAPHY_PLEURAL_EFFUSION_DOUBLE");
            }
        }

        public string COMPUTED_TOMOGRAPHY_OTHER
        {
            get { return Model.VISIT_ONE.COMPUTED_TOMOGRAPHY_CHEST_VISIT_1.OTHER; }
            set
            {
                Model.VISIT_ONE.COMPUTED_TOMOGRAPHY_CHEST_VISIT_1.OTHER = value;
                OnPropertyChanged("COMPUTED_TOMOGRAPHY_OTHER");
            }
        }


        #endregion
        #region VISIT ONE ELECTROCARDIOGRAPHY

        public DateTime? VISIT_ONE_ELECTROCARDIOGRAPHY_DATE_PROCEDURE
        {
            get { return Model.VISIT_ONE.ELECTROCARDIOGRAPHY_VISIT_1.DATE_PROCEDURE; }
            set
            {
                Model.VISIT_ONE.ELECTROCARDIOGRAPHY_VISIT_1.DATE_PROCEDURE = value;
                OnPropertyChanged("VISIT_ONE_ELECTROCARDIOGRAPHY_DATE_PROCEDURE");
            }
        }

        public int? VISIT_ONE_ELECTROCARDIOGRAPHY_HEARTH_RATE
        {
            get { return Model.VISIT_ONE.ELECTROCARDIOGRAPHY_VISIT_1.HEART_RATE; }
            set
            {
                Model.VISIT_ONE.ELECTROCARDIOGRAPHY_VISIT_1.HEART_RATE = value;
                OnPropertyChanged("VISIT_ONE_ELECTROCARDIOGRAPHY_HEARTH_RATE");
            }
        }

        public string VISIT_ONE_ELECTROCARDIOGRAPHY_SIGNIFICANT_CHANGES
        {
            get { return Model.VISIT_ONE.ELECTROCARDIOGRAPHY_VISIT_1.SIGNIFICANT_CHANGES; }
            set
            {
                Model.VISIT_ONE.ELECTROCARDIOGRAPHY_VISIT_1.SIGNIFICANT_CHANGES = value;
                OnPropertyChanged("VISIT_ONE_ELECTROCARDIOGRAPHY_SIGNIFICANT_CHANGES");
            }
        }

        public bool? VISIT_ONE_ELECTROCARDIOGRAPHY_SINUS_RHYTHM
        {
            get
            {
                if (Model.VISIT_ONE.ELECTROCARDIOGRAPHY_VISIT_1.SINUS_RHYTHM == null)
                {
                    return false;
                }
                else
                {
                    return Model.VISIT_ONE.ELECTROCARDIOGRAPHY_VISIT_1.SINUS_RHYTHM;
                }
            }
            set
            {
                Model.VISIT_ONE.ELECTROCARDIOGRAPHY_VISIT_1.SINUS_RHYTHM = value;
                OnPropertyChanged("VISIT_ONE_ELECTROCARDIOGRAPHY_SINUS_RHYTHM");
            }
        }
        public bool? VISIT_ONE_ELECTROCARDIOGRAPHY_ATRIAL_FIBRILLATION
        {
            get
            {
                if (Model.VISIT_ONE.ELECTROCARDIOGRAPHY_VISIT_1.ATRIAL_FIBRILLATION == null)
                {
                    return false;
                }
                else
                {
                    return Model.VISIT_ONE.ELECTROCARDIOGRAPHY_VISIT_1.ATRIAL_FIBRILLATION;
                }
            }
            set
            {
                Model.VISIT_ONE.ELECTROCARDIOGRAPHY_VISIT_1.ATRIAL_FIBRILLATION = value;
                OnPropertyChanged("VISIT_ONE_ELECTROCARDIOGRAPHY_ATRIAL_FIBRILLATION");
            }
        }
        public bool? VISIT_ONE_ELECTROCARDIOGRAPHY_ARRYTHMIA_SUPRAVENTRICULAR
        {
            get
            {
                if (Model.VISIT_ONE.ELECTROCARDIOGRAPHY_VISIT_1.ARRYTHMIA_SUPRAVENTRICULAR == null)
                {
                    return false;
                }
                else
                {
                    return Model.VISIT_ONE.ELECTROCARDIOGRAPHY_VISIT_1.ARRYTHMIA_SUPRAVENTRICULAR;
                }
            }
            set
            {
                Model.VISIT_ONE.ELECTROCARDIOGRAPHY_VISIT_1.ARRYTHMIA_SUPRAVENTRICULAR = value;
                OnPropertyChanged("VISIT_ONE_ELECTROCARDIOGRAPHY_ARRYTHMIA_SUPRAVENTRICULAR");
            }
        }
        public bool? VISIT_ONE_ELECTROCARDIOGRAPHY_ARRYTHMIA_VENTRICULAR_PREMATURE_BEATS
        {
            get
            {
                if (Model.VISIT_ONE.ELECTROCARDIOGRAPHY_VISIT_1.ARRYTHMIA_VENTRICULAR_PREMATURE_BEATS == null)
                {
                    return false;
                }
                else
                {
                    return Model.VISIT_ONE.ELECTROCARDIOGRAPHY_VISIT_1.ARRYTHMIA_VENTRICULAR_PREMATURE_BEATS;
                }
            }
            set
            {
                Model.VISIT_ONE.ELECTROCARDIOGRAPHY_VISIT_1.ARRYTHMIA_VENTRICULAR_PREMATURE_BEATS = value;
                OnPropertyChanged("VISIT_ONE_ELECTROCARDIOGRAPHY_ARRYTHMIA_VENTRICULAR_PREMATURE_BEATS");
            }
        }
        #endregion
        #region VISIT ONE ECHOCARDIOGRAPHY
        public DateTime? VISIT_ONE_ECHOCARDIOGRAPHY_DATE_PROCEDURE
        {
            get { return Model.VISIT_ONE.ECHOCARDIOGRAPHY_VISIT_1.DATE_PROCEDURE; }
            set
            {
                Model.VISIT_ONE.ECHOCARDIOGRAPHY_VISIT_1.DATE_PROCEDURE = value;
                OnPropertyChanged("VISIT_ONE_ECHOCARDIOGRAPHY_DATE_PROCEDURE");
            }
        }

        public decimal? VISIT_ONE_ECHOCARDIOGRAPHY_AMOUNT_OF_PERICARDIAL_EFFUSION
        {
            get { return Model.VISIT_ONE.ECHOCARDIOGRAPHY_VISIT_1.AMOUNT_OF_PERICARDIAL_EFFUSION; }
            set
            {
                Model.VISIT_ONE.ECHOCARDIOGRAPHY_VISIT_1.AMOUNT_OF_PERICARDIAL_EFFUSION = value;
                OnPropertyChanged("VISIT_ONE_ECHOCARDIOGRAPHY_AMOUNT_OF_PERICARDIAL_EFFUSION");
            }
        }

        public string VISIT_ONE_ECHOCARDIOGRAPHY_COMMENTS
        {
            get { return Model.VISIT_ONE.ECHOCARDIOGRAPHY_VISIT_1.COMMENTS; }
            set
            {
                Model.VISIT_ONE.ECHOCARDIOGRAPHY_VISIT_1.COMMENTS = value;
                OnPropertyChanged("VISIT_ONE_ECHOCARDIOGRAPHY_COMMENTS");
            }
        }

        public decimal? VISIT_ONE_ECHOCARDIOGRAPHY_FV_PERCENT
        {
            get { return Model.VISIT_ONE.ECHOCARDIOGRAPHY_VISIT_1.FV_PERCENT; }
            set
            {
                Model.VISIT_ONE.ECHOCARDIOGRAPHY_VISIT_1.FV_PERCENT = value;
                OnPropertyChanged("VISIT_ONE_ECHOCARDIOGRAPHY_FV_PERCENT");
            }
        }
        public decimal? VISIT_ONE_ECHOCARDIOGRAPHY_EA_LJ
        {
            get { return Model.VISIT_ONE.ECHOCARDIOGRAPHY_VISIT_1.EA_LJ; }
            set
            {
                Model.VISIT_ONE.ECHOCARDIOGRAPHY_VISIT_1.EA_LJ = value;
                OnPropertyChanged("VISIT_ONE_ECHOCARDIOGRAPHY_EA_LJ");
            }
        }
        public decimal? VISIT_ONE_ECHOCARDIOGRAPHY_EA_RJ
        {
            get { return Model.VISIT_ONE.ECHOCARDIOGRAPHY_VISIT_1.EA_RJ; }
            set
            {
                Model.VISIT_ONE.ECHOCARDIOGRAPHY_VISIT_1.EA_RJ = value;
                OnPropertyChanged("VISIT_ONE_ECHOCARDIOGRAPHY_EA_RJ");
            }
        }
        public decimal? VISIT_ONE_ECHOCARDIOGRAPHY_SDLA
        {
            get { return Model.VISIT_ONE.ECHOCARDIOGRAPHY_VISIT_1.SDLA; }
            set
            {
                Model.VISIT_ONE.ECHOCARDIOGRAPHY_VISIT_1.SDLA = value;
                OnPropertyChanged("VISIT_ONE_ECHOCARDIOGRAPHY_SDLA");
            }
        }
        #endregion

        #region VISIT TWO
        public DateTime? DATE_VISIT_TWO
        {
            get { return Model.VISIT_TWO.DATE_VISIT; }
            set
            {
                Model.VISIT_TWO.DATE_VISIT = value;
                OnPropertyChanged("DATE_VISIT_TWO");
            }
        }
        #endregion
        #region VISIT TWO BASE LIVE INDICATIONS
        public int? VISIT_TWO_BLOOD_PRESSURE_RIGHT_HAND
        {
            get { return Model.VISIT_TWO.BASE_LIVE_INDICATORS_VISIT_2.BLOOD_PRESSURE_RIGHT_HAND; }
            set
            {
                Model.VISIT_TWO.BASE_LIVE_INDICATORS_VISIT_2.BLOOD_PRESSURE_RIGHT_HAND = value;
                OnPropertyChanged("VISIT_TWO_BLOOD_PRESSURE_RIGHT_HAND");
            }
        }

        public int? VISIT_TWO_BLOOD_PRESSURE_LEFT_HAND
        {
            get { return Model.VISIT_TWO.BASE_LIVE_INDICATORS_VISIT_2.BLOOD_PRESSURE_LEFT_HAND; }
            set
            {
                Model.VISIT_TWO.BASE_LIVE_INDICATORS_VISIT_2.BLOOD_PRESSURE_LEFT_HAND = value;
                OnPropertyChanged("VISIT_TWO_BLOOD_PRESSURE_LEFT_HAND");
            }
        }
        public int? VISIT_TWO_HEART_RATE
        {
            get { return Model.VISIT_TWO.BASE_LIVE_INDICATORS_VISIT_2.HEART_RATE; }
            set
            {
                Model.VISIT_TWO.BASE_LIVE_INDICATORS_VISIT_2.HEART_RATE = value;
                OnPropertyChanged("VISIT_TWO_HEART_RATE");
            }
        }
        public int? VISIT_TWO_RESPIRATORY_RATE
        {
            get { return Model.VISIT_TWO.BASE_LIVE_INDICATORS_VISIT_2.RESPIRATORY_RATE; }
            set
            {
                Model.VISIT_TWO.BASE_LIVE_INDICATORS_VISIT_2.RESPIRATORY_RATE = value;
                OnPropertyChanged("VISIT_TWO_RESPIRATORY_RATE");
            }
        }

        public decimal? VISIT_TWO_TEMPERATURE
        {
            get { return Model.VISIT_TWO.BASE_LIVE_INDICATORS_VISIT_2.TEMPERATURE; }
            set
            {
                Model.VISIT_TWO.BASE_LIVE_INDICATORS_VISIT_2.TEMPERATURE = value;
                OnPropertyChanged("VISIT_TWO_TEMPERATURE");
            }
        }
        #endregion
        #region VISIT TWO EVALUATION SYMPTOM
        public string VISIT_TWO_SYMPTOMS_DYSPNEA
        {
            get { return Model.VISIT_TWO.EVALUATION_OF_SYMPTOMS_VISIT_2.DYSPNEA; }
            set
            {
                Model.VISIT_TWO.EVALUATION_OF_SYMPTOMS_VISIT_2.DYSPNEA = value;
                OnPropertyChanged("VISIT_TWO_SYMPTOMS_DYSPNEA");
            }
        }
        public string VISIT_TWO_SYMPTOMS_COUGH
        {
            get { return Model.VISIT_TWO.EVALUATION_OF_SYMPTOMS_VISIT_2.COUGH; }
            set
            {
                Model.VISIT_TWO.EVALUATION_OF_SYMPTOMS_VISIT_2.COUGH = value;
                OnPropertyChanged("VISIT_TWO_SYMPTOMS_COUGH");
            }
        }
        public string VISIT_TWO_SYMPTOMS_SPUTUM
        {
            get { return Model.VISIT_TWO.EVALUATION_OF_SYMPTOMS_VISIT_2.SPUTUM; }
            set
            {
                Model.VISIT_TWO.EVALUATION_OF_SYMPTOMS_VISIT_2.SPUTUM = value;
                OnPropertyChanged("VISIT_TWO_SYMPTOMS_SPUTUM");
            }
        }
        public string VISIT_TWO_SYMPTOMS_SPUTUM_TYPE
        {
            get { return Model.VISIT_TWO.EVALUATION_OF_SYMPTOMS_VISIT_2.SPUTUM_TYPE; }
            set
            {
                Model.VISIT_TWO.EVALUATION_OF_SYMPTOMS_VISIT_2.SPUTUM_TYPE = value;
                OnPropertyChanged("VISIT_TWO_SYMPTOMS_SPUTUM_TYPE");
            }
        }
        public string VISIT_TWO_SYMPTOMS_TEMPERATURE_INCREASE
        {
            get { return Model.VISIT_TWO.EVALUATION_OF_SYMPTOMS_VISIT_2.TEMPERATURE_INCREASE; }
            set
            {
                Model.VISIT_TWO.EVALUATION_OF_SYMPTOMS_VISIT_2.TEMPERATURE_INCREASE = value;
                OnPropertyChanged("VISIT_TWO_SYMPTOMS_TEMPERATURE_INCREASE");
            }
        }
        public string VISIT_TWO_SYMPTOMS_COLD_SYMPTOM
        {
            get { return Model.VISIT_TWO.EVALUATION_OF_SYMPTOMS_VISIT_2.COLD_SYMPTOM; }
            set
            {
                Model.VISIT_TWO.EVALUATION_OF_SYMPTOMS_VISIT_2.COLD_SYMPTOM = value;
                OnPropertyChanged("VISIT_TWO_SYMPTOMS_COLD_SYMPTOM");
            }
        }
        public string VISIT_TWO_SYMPTOMS_SHORTERING_OF_PERCUSSION_SOUNDS
        {
            get { return Model.VISIT_TWO.EVALUATION_OF_SYMPTOMS_VISIT_2.SHORTERING_OF_PERCUSSION_SOUNDS; }
            set
            {
                Model.VISIT_TWO.EVALUATION_OF_SYMPTOMS_VISIT_2.SHORTERING_OF_PERCUSSION_SOUNDS = value;
                OnPropertyChanged("VISIT_TWO_SYMPTOMS_SHORTERING_OF_PERCUSSION_SOUNDS");
            }
        }
        public string VISIT_TWO_SYMPTOMS_MOIST_RALES_SOUNDS
        {
            get { return Model.VISIT_TWO.EVALUATION_OF_SYMPTOMS_VISIT_2.MOIST_RALES_SOUNDS; }
            set
            {
                Model.VISIT_TWO.EVALUATION_OF_SYMPTOMS_VISIT_2.MOIST_RALES_SOUNDS = value;
                OnPropertyChanged("VISIT_TWO_SYMPTOMS_MOIST_RALES_SOUNDS");
            }
        }
        public string VISIT_TWO_SYMPTOMS_CREPITUS
        {
            get { return Model.VISIT_TWO.EVALUATION_OF_SYMPTOMS_VISIT_2.CREPITUS; }
            set
            {
                Model.VISIT_TWO.EVALUATION_OF_SYMPTOMS_VISIT_2.CREPITUS = value;
                OnPropertyChanged("VISIT_TWO_SYMPTOMS_CREPITUS");
            }
        }
        public string VISIT_TWO_SYMPTOMS_PLEURAL_FRICTION_NOISE
        {
            get { return Model.VISIT_TWO.EVALUATION_OF_SYMPTOMS_VISIT_2.PLEURAL_FRICTION_NOISE; }
            set
            {
                Model.VISIT_TWO.EVALUATION_OF_SYMPTOMS_VISIT_2.PLEURAL_FRICTION_NOISE = value;
                OnPropertyChanged("VISIT_TWO_SYMPTOMS_PLEURAL_FRICTION_NOISE");
            }
        }
        public string VISIT_TWO_SYMPTOMS_DRY_RALES
        {
            get { return Model.VISIT_TWO.EVALUATION_OF_SYMPTOMS_VISIT_2.DRY_RALES; }
            set
            {
                Model.VISIT_TWO.EVALUATION_OF_SYMPTOMS_VISIT_2.DRY_RALES = value;
                OnPropertyChanged("VISIT_TWO_SYMPTOMS_DRY_RALES");
            }
        }
        public string VISIT_TWO_SYMPTOMS_PRESENCE_OF_EDEMA
        {
            get { return Model.VISIT_TWO.EVALUATION_OF_SYMPTOMS_VISIT_2.PRESENCE_OF_EDEMA; }
            set
            {
                Model.VISIT_TWO.EVALUATION_OF_SYMPTOMS_VISIT_2.PRESENCE_OF_EDEMA = value;
                OnPropertyChanged("VISIT_TWO_SYMPTOMS_PRESENCE_OF_EDEMA");
            }
        }
        public string VISIT_TWO_SYMPTOMS_INCIDENCE_OF_EDEMA
        {
            get { return Model.VISIT_TWO.EVALUATION_OF_SYMPTOMS_VISIT_2.INCIDENCE_OF_EDEMA; }
            set
            {
                Model.VISIT_TWO.EVALUATION_OF_SYMPTOMS_VISIT_2.INCIDENCE_OF_EDEMA = value;
                OnPropertyChanged("VISIT_TWO_SYMPTOMS_INCIDENCE_OF_EDEMA");
            }
        }

        public string VISIT_TWO_SYMPTOMS_THERAPY_EFFICIENCY
        {
            get { return Model.VISIT_TWO.EVALUATION_OF_SYMPTOMS_VISIT_2.THERAPY_EFFICIENCY; }
            set
            {
                Model.VISIT_TWO.EVALUATION_OF_SYMPTOMS_VISIT_2.THERAPY_EFFICIENCY = value;
                OnPropertyChanged("VISIT_TWO_SYMPTOMS_THERAPY_EFFICIENCY");
            }
        }
        #endregion

        #region VISIT THREE
        public DateTime? DATE_VISIT_THREE
        {
            get { return Model.VISIT_THREE.DATE_VISIT; }
            set
            {
                Model.VISIT_THREE.DATE_VISIT = value;
                OnPropertyChanged("DATE_VISIT_THREE");
            }
        }
        #endregion
        #region VISIT THREE ECHOCARDIOGRAPHY
        public DateTime? VISIT_THREE_ECHOCARDIOGRAPHY_DATE_PROCEDURE
        {
            get { return Model.VISIT_THREE.ECHOCARDIOGRAPHY_VISIT_3.DATE_PROCEDURE; }
            set
            {
                Model.VISIT_THREE.ECHOCARDIOGRAPHY_VISIT_3.DATE_PROCEDURE = value;
                OnPropertyChanged("VISIT_THREE_ECHOCARDIOGRAPHY_DATE_PROCEDURE");
            }
        }

        public decimal? VISIT_THREE_ECHOCARDIOGRAPHY_AMOUNT_OF_PERICARDIAL_EFFUSION
        {
            get { return Model.VISIT_THREE.ECHOCARDIOGRAPHY_VISIT_3.AMOUNT_OF_PERICARDIAL_EFFUSION; }
            set
            {
                Model.VISIT_THREE.ECHOCARDIOGRAPHY_VISIT_3.AMOUNT_OF_PERICARDIAL_EFFUSION = value;
                OnPropertyChanged("VISIT_THREE_ECHOCARDIOGRAPHY_AMOUNT_OF_PERICARDIAL_EFFUSION");
            }
        }

        public string VISIT_THREE_ECHOCARDIOGRAPHY_COMMENTS
        {
            get { return Model.VISIT_THREE.ECHOCARDIOGRAPHY_VISIT_3.COMMENTS; }
            set
            {
                Model.VISIT_THREE.ECHOCARDIOGRAPHY_VISIT_3.COMMENTS = value;
                OnPropertyChanged("VISIT_THREE_ECHOCARDIOGRAPHY_COMMENTS");
            }
        }

        public decimal? VISIT_THREE_ECHOCARDIOGRAPHY_FV_PERCENT
        {
            get { return Model.VISIT_THREE.ECHOCARDIOGRAPHY_VISIT_3.FV_PERCENT; }
            set
            {
                Model.VISIT_THREE.ECHOCARDIOGRAPHY_VISIT_3.FV_PERCENT = value;
                OnPropertyChanged("VISIT_THREE_ECHOCARDIOGRAPHY_FV_PERCENT");
            }
        }
        public decimal? VISIT_THREE_ECHOCARDIOGRAPHY_EA_LJ
        {
            get { return Model.VISIT_THREE.ECHOCARDIOGRAPHY_VISIT_3.EA_LJ; }
            set
            {
                Model.VISIT_THREE.ECHOCARDIOGRAPHY_VISIT_3.EA_LJ = value;
                OnPropertyChanged("VISIT_THREE_ECHOCARDIOGRAPHY_EA_LJ");
            }
        }
        public decimal? VISIT_THREE_ECHOCARDIOGRAPHY_EA_RJ
        {
            get { return Model.VISIT_THREE.ECHOCARDIOGRAPHY_VISIT_3.EA_RJ; }
            set
            {
                Model.VISIT_THREE.ECHOCARDIOGRAPHY_VISIT_3.EA_RJ = value;
                OnPropertyChanged("VISIT_THREE_ECHOCARDIOGRAPHY_EA_RJ");
            }
        }
        public decimal? VISIT_THREE_ECHOCARDIOGRAPHY_SDLA
        {
            get { return Model.VISIT_THREE.ECHOCARDIOGRAPHY_VISIT_3.SDLA; }
            set
            {
                Model.VISIT_THREE.ECHOCARDIOGRAPHY_VISIT_3.SDLA = value;
                OnPropertyChanged("VISIT_THREE_ECHOCARDIOGRAPHY_SDLA");
            }
        }
        #endregion

        #region BLOOD CLINICAL ANALYSIS
        public string BLOOD_CLINICAL_ANALYSIS_VISIT_ONE_SIGNIFICANT_CHANGES
        {
            get { return Model.BLOOD_CLINICAL_ANALYSIS.VISIT_ONE_SIGNIFICANT_CHANGES; }
            set
            {
                Model.BLOOD_CLINICAL_ANALYSIS.VISIT_ONE_SIGNIFICANT_CHANGES = value;
                OnPropertyChanged("BLOOD_CLINICAL_ANALYSIS_VISIT_ONE_SIGNIFICANT_CHANGES");
            }
        }

        public decimal? BLOOD_CLINICAL_ANALYSIS_VISIT_ONE_LEUKOCYTOSIS
        {
            get { return Model.BLOOD_CLINICAL_ANALYSIS.VISIT_ONE_LEUKOCYTOSIS; }
            set
            {
                Model.BLOOD_CLINICAL_ANALYSIS.VISIT_ONE_LEUKOCYTOSIS = value;
                OnPropertyChanged("BLOOD_CLINICAL_ANALYSIS_VISIT_ONE_LEUKOCYTOSIS");
            }
        }

        public decimal? BLOOD_CLINICAL_ANALYSIS_VISIT_ONE_LEUKOCYTOSIS_YOUNG_FORMS
        {
            get { return Model.BLOOD_CLINICAL_ANALYSIS.VISIT_ONE_LEUKOCYTOSIS_YOUNG_FORMS; }
            set
            {
                Model.BLOOD_CLINICAL_ANALYSIS.VISIT_ONE_LEUKOCYTOSIS_YOUNG_FORMS = value;
                OnPropertyChanged("BLOOD_CLINICAL_ANALYSIS_VISIT_ONE_LEUKOCYTOSIS_YOUNG_FORMS");
            }
        }

        public string BLOOD_CLINICAL_ANALYSIS_VISIT_ONE_OTHERS
        {
            get { return Model.BLOOD_CLINICAL_ANALYSIS.VISIT_ONE_OTHERS; }
            set
            {
                Model.BLOOD_CLINICAL_ANALYSIS.VISIT_ONE_OTHERS = value;
                OnPropertyChanged("BLOOD_CLINICAL_ANALYSIS_VISIT_ONE_OTHERS");
            }
        }
        public string BLOOD_CLINICAL_ANALYSIS_VISIT_TWO_SIGNIFICANT_CHANGES
        {
            get { return Model.BLOOD_CLINICAL_ANALYSIS.VISIT_TWO_SIGNIFICANT_CHANGES; }
            set
            {
                Model.BLOOD_CLINICAL_ANALYSIS.VISIT_TWO_SIGNIFICANT_CHANGES = value;
                OnPropertyChanged("BLOOD_CLINICAL_ANALYSIS_VISIT_TWO_SIGNIFICANT_CHANGES");
            }
        }

        public decimal? BLOOD_CLINICAL_ANALYSIS_VISIT_TWO_LEUKOCYTOSIS
        {
            get { return Model.BLOOD_CLINICAL_ANALYSIS.VISIT_TWO_LEUKOCYTOSIS; }
            set
            {
                Model.BLOOD_CLINICAL_ANALYSIS.VISIT_TWO_LEUKOCYTOSIS = value;
                OnPropertyChanged("BLOOD_CLINICAL_ANALYSIS_VISIT_TWO_LEUKOCYTOSIS");
            }
        }

        public decimal? BLOOD_CLINICAL_ANALYSIS_VISIT_TWO_LEUKOCYTOSIS_YOUNG_FORMS
        {
            get { return Model.BLOOD_CLINICAL_ANALYSIS.VISIT_TWO_LEUKOCYTOSIS_YOUNG_FORMS; }
            set
            {
                Model.BLOOD_CLINICAL_ANALYSIS.VISIT_TWO_LEUKOCYTOSIS_YOUNG_FORMS = value;
                OnPropertyChanged("BLOOD_CLINICAL_ANALYSIS_VISIT_TWO_LEUKOCYTOSIS_YOUNG_FORMS");
            }
        }

        public string BLOOD_CLINICAL_ANALYSIS_VISIT_TWO_OTHERS
        {
            get { return Model.BLOOD_CLINICAL_ANALYSIS.VISIT_TWO_OTHERS; }
            set
            {
                Model.BLOOD_CLINICAL_ANALYSIS.VISIT_TWO_OTHERS = value;
                OnPropertyChanged("BLOOD_CLINICAL_ANALYSIS_VISIT_TWO_OTHERS");
            }
        }

        #endregion

        #region BLOOD CHEMISTRY

        public string BLOOD_CHEMISTRY_VISIT_ONE_SIGNIFICANT_CHANGES
        {
            get { return Model.BLOOD_CHEMISTRY.VISIT_ONE_SIGNIFICANT_CHANGES; }
            set
            {
                Model.BLOOD_CHEMISTRY.VISIT_ONE_SIGNIFICANT_CHANGES = value;
                OnPropertyChanged("BLOOD_CHEMISTRY_VISIT_ONE_SIGNIFICANT_CHANGES");
            }
        }

        public string BLOOD_CHEMISTRY_VISIT_ONE_CHANGES
        {
            get { return Model.BLOOD_CHEMISTRY.VISIT_ONE_CHANGES; }
            set
            {
                Model.BLOOD_CHEMISTRY.VISIT_ONE_CHANGES = value;
                OnPropertyChanged("BLOOD_CHEMISTRY_VISIT_ONE_CHANGES");
            }
        }
        public string BLOOD_CHEMISTRY_VISIT_TWO_SIGNIFICANT_CHANGES
        {
            get { return Model.BLOOD_CHEMISTRY.VISIT_TWO_SIGNIFICANT_CHANGES; }
            set
            {
                Model.BLOOD_CHEMISTRY.VISIT_TWO_SIGNIFICANT_CHANGES = value;
                OnPropertyChanged("BLOOD_CHEMISTRY_VISIT_TWO_SIGNIFICANT_CHANGES");
            }
        }

        public string BLOOD_CHEMISTRY_VISIT_TWO_CHANGES
        {
            get { return Model.BLOOD_CHEMISTRY.VISIT_TWO_CHANGES; }
            set
            {
                Model.BLOOD_CHEMISTRY.VISIT_TWO_CHANGES = value;
                OnPropertyChanged("BLOOD_CHEMISTRY_VISIT_TWO_CHANGES");
            }
        }
        #endregion

        #region BLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATION

        public string BLOOD_TEST_VISIT_ONE_C_REACTIVE_PROTEIN
        {
            get { return Model.BLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATION.VISIT_ONE_C_REACTIVE_PROTEIN; }
            set
            {
                Model.BLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATION.VISIT_ONE_C_REACTIVE_PROTEIN = value;
                OnPropertyChanged("BLOOD_TEST_VISIT_ONE_C_REACTIVE_PROTEIN");
            }

        }

        public string BLOOD_TEST_VISIT_ONE_PROCALCITONIN
        {
            get { return Model.BLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATION.VISIT_ONE_PROCALCITONIN; }
            set
            {
                Model.BLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATION.VISIT_ONE_PROCALCITONIN = value;
                OnPropertyChanged("BLOOD_TEST_VISIT_ONE_PROCALCITONIN");
            }
        }

        public string BLOOD_TEST_VISIT_ONE_IL6
        {
            get { return Model.BLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATION.VISIT_ONE_IL6; }
            set
            {
                Model.BLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATION.VISIT_ONE_IL6 = value;
                OnPropertyChanged("BLOOD_TEST_VISIT_ONE_IL6");
            }
        }

        public string BLOOD_TEST_VISIT_ONE_FNO
        {
            get { return Model.BLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATION.VISIT_ONE_FNO; }
            set
            {
                Model.BLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATION.VISIT_ONE_FNO = value;
                OnPropertyChanged("BLOOD_TEST_VISIT_ONE_FNO");
            }
        }

        public string BLOOD_TEST_VISIT_TWO_C_REACTIVE_PROTEIN
        {
            get { return Model.BLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATION.VISIT_TWO_C_REACTIVE_PROTEIN; }
            set
            {
                Model.BLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATION.VISIT_TWO_C_REACTIVE_PROTEIN = value;
                OnPropertyChanged("BLOOD_TEST_VISIT_TWO_C_REACTIVE_PROTEIN");
            }

        }

        public string BLOOD_TEST_VISIT_TWO_PROCALCITONIN
        {
            get { return Model.BLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATION.VISIT_TWO_PROCALCITONIN; }
            set
            {
                Model.BLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATION.VISIT_TWO_PROCALCITONIN = value;
                OnPropertyChanged("BLOOD_TEST_VISIT_TWO_PROCALCITONIN");
            }
        }

        public string BLOOD_TEST_VISIT_TWO_IL6
        {
            get { return Model.BLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATION.VISIT_TWO_IL6; }
            set
            {
                Model.BLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATION.VISIT_TWO_IL6 = value;
                OnPropertyChanged("BLOOD_TEST_VISIT_TWO_IL6");
            }
        }

        public string BLOOD_TEST_VISIT_TWO_FNO
        {
            get { return Model.BLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATION.VISIT_TWO_FNO; }
            set
            {
                Model.BLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATION.VISIT_TWO_FNO = value;
                OnPropertyChanged("BLOOD_TEST_VISIT_TWO_FNO");
            }
        }

        public string BLOOD_TEST_VISIT_THREE_C_REACTIVE_PROTEIN
        {
            get { return Model.BLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATION.VISIT_THREE_C_REACTIVE_PROTEIN; }
            set
            {
                Model.BLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATION.VISIT_THREE_C_REACTIVE_PROTEIN = value;
                OnPropertyChanged("BLOOD_TEST_VISIT_THREE_C_REACTIVE_PROTEIN");
            }

        }

        public string BLOOD_TEST_VISIT_THREE_PROCALCITONIN
        {
            get { return Model.BLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATION.VISIT_THREE_PROCALCITONIN; }
            set
            {
                Model.BLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATION.VISIT_THREE_PROCALCITONIN = value;
                OnPropertyChanged("BLOOD_TEST_VISIT_THREE_PROCALCITONIN");
            }
        }

        public string BLOOD_TEST_VISIT_THREE_IL6
        {
            get { return Model.BLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATION.VISIT_THREE_IL6; }
            set
            {
                Model.BLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATION.VISIT_THREE_IL6 = value;
                OnPropertyChanged("BLOOD_TEST_VISIT_THREE_IL6");
            }
        }

        public string BLOOD_TEST_VISIT_THREE_FNO
        {
            get { return Model.BLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATION.VISIT_THREE_FNO; }
            set
            {
                Model.BLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATION.VISIT_THREE_FNO = value;
                OnPropertyChanged("BLOOD_TEST_VISIT_THREE_FNO");
            }
        }
        #endregion

        #region BLOOD_TESTS_FOR_MARKERS_OF_CARDIAC_DYSFUNCTION

        public string BLOOD_TEST_VISIT_ONE_BRAIN_NATRIURETIC_PEPTIDE
        {
            get { return Model.BLOOD_TESTS_FOR_MARKERS_OF_CARDIAC_DYSFUNCTION.VISIT_ONE_BRAIN_NATRIURETIC_PEPTIDE; }
            set
            {
                Model.BLOOD_TESTS_FOR_MARKERS_OF_CARDIAC_DYSFUNCTION.VISIT_ONE_BRAIN_NATRIURETIC_PEPTIDE = value;
                OnPropertyChanged("BLOOD_TEST_VISIT_ONE_BRAIN_NATRIURETIC_PEPTIDE");
            }

        }

        public string BLOOD_TEST_VISIT_ONE_KOPEPTIN
        {
            get { return Model.BLOOD_TESTS_FOR_MARKERS_OF_CARDIAC_DYSFUNCTION.VISIT_ONE_KOPEPTIN; }
            set
            {
                Model.BLOOD_TESTS_FOR_MARKERS_OF_CARDIAC_DYSFUNCTION.VISIT_ONE_KOPEPTIN = value;
                OnPropertyChanged("BLOOD_TEST_VISIT_ONE_KOPEPTIN");
            }
        }

        public string BLOOD_TEST_VISIT_ONE_PROADRENOMEDULLIN
        {
            get { return Model.BLOOD_TESTS_FOR_MARKERS_OF_CARDIAC_DYSFUNCTION.VISIT_ONE_PROADRENOMEDULLIN; }
            set
            {
                Model.BLOOD_TESTS_FOR_MARKERS_OF_CARDIAC_DYSFUNCTION.VISIT_ONE_PROADRENOMEDULLIN = value;
                OnPropertyChanged("BLOOD_TEST_VISIT_ONE_PROADRENOMEDULLIN");
            }
        }

        public string BLOOD_TEST_VISIT_TWO_BRAIN_NATRIURETIC_PEPTIDE
        {
            get { return Model.BLOOD_TESTS_FOR_MARKERS_OF_CARDIAC_DYSFUNCTION.VISIT_TWO_BRAIN_NATRIURETIC_PEPTIDE; }
            set
            {
                Model.BLOOD_TESTS_FOR_MARKERS_OF_CARDIAC_DYSFUNCTION.VISIT_TWO_BRAIN_NATRIURETIC_PEPTIDE = value;
                OnPropertyChanged("BLOOD_TEST_VISIT_TWO_BRAIN_NATRIURETIC_PEPTIDE");
            }

        }

        public string BLOOD_TEST_VISIT_TWO_KOPEPTIN
        {
            get { return Model.BLOOD_TESTS_FOR_MARKERS_OF_CARDIAC_DYSFUNCTION.VISIT_TWO_KOPEPTIN; }
            set
            {
                Model.BLOOD_TESTS_FOR_MARKERS_OF_CARDIAC_DYSFUNCTION.VISIT_TWO_KOPEPTIN = value;
                OnPropertyChanged("BLOOD_TEST_VISIT_TWO_KOPEPTIN");
            }
        }

        public string BLOOD_TEST_VISIT_TWO_PROADRENOMEDULLIN
        {
            get { return Model.BLOOD_TESTS_FOR_MARKERS_OF_CARDIAC_DYSFUNCTION.VISIT_TWO_PROADRENOMEDULLIN; }
            set
            {
                Model.BLOOD_TESTS_FOR_MARKERS_OF_CARDIAC_DYSFUNCTION.VISIT_TWO_PROADRENOMEDULLIN = value;
                OnPropertyChanged("BLOOD_TEST_VISIT_TWO_PROADRENOMEDULLIN");
            }
        }
        public string BLOOD_TEST_VISIT_THREE_BRAIN_NATRIURETIC_PEPTIDE
        {
            get { return Model.BLOOD_TESTS_FOR_MARKERS_OF_CARDIAC_DYSFUNCTION.VISIT_THREE_BRAIN_NATRIURETIC_PEPTIDE; }
            set
            {
                Model.BLOOD_TESTS_FOR_MARKERS_OF_CARDIAC_DYSFUNCTION.VISIT_THREE_BRAIN_NATRIURETIC_PEPTIDE = value;
                OnPropertyChanged("BLOOD_TEST_VISIT_THREE_BRAIN_NATRIURETIC_PEPTIDE");
            }

        }

        public string BLOOD_TEST_VISIT_THREE_KOPEPTIN
        {
            get { return Model.BLOOD_TESTS_FOR_MARKERS_OF_CARDIAC_DYSFUNCTION.VISIT_THREE_KOPEPTIN; }
            set
            {
                Model.BLOOD_TESTS_FOR_MARKERS_OF_CARDIAC_DYSFUNCTION.VISIT_THREE_KOPEPTIN = value;
                OnPropertyChanged("BLOOD_TEST_VISIT_THREE_KOPEPTIN");
            }
        }

        public string BLOOD_TEST_VISIT_THREE_PROADRENOMEDULLIN
        {
            get { return Model.BLOOD_TESTS_FOR_MARKERS_OF_CARDIAC_DYSFUNCTION.VISIT_THREE_PROADRENOMEDULLIN; }
            set
            {
                Model.BLOOD_TESTS_FOR_MARKERS_OF_CARDIAC_DYSFUNCTION.VISIT_THREE_PROADRENOMEDULLIN = value;
                OnPropertyChanged("BLOOD_TEST_VISIT_THREE_PROADRENOMEDULLIN");
            }
        }

        #endregion
    }
}
