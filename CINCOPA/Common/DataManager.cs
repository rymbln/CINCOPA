using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Objects;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Windows;
using System.Windows.Media.Media3D;
using CINCOPA.Model;



using System.Linq;
using System.Data;
using System.Data.Objects;
using System.Transactions;

namespace CINCOPA.Common
{
    public class DataManager
    {
        private static DataManager instance;


        public static DataManager Instance
        {
            get { return instance ?? (instance = new DataManager(new CINCOPAEntities())); }
        }

        /// <summary>
        /// The underlying context tracking changes
        /// </summary>
        private readonly ICINCOPAContext underlyingContext;


        public void Save()
        {
            underlyingContext.Save();
        }

        /// <summary>
        /// Initializes a new instance of the DataManager class.
        /// Changes registered in the DataManager are recorded in the supplied context
        /// </summary>
        /// <param name="context">The underlying context for this DataManager</param>
        ///   public DataManager(IEmployeeContext context)
        private DataManager(CINCOPAEntities context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }

            underlyingContext = context;
        }


        public USER GetUser(string name)
        {
            return this.underlyingContext.Users.FirstOrDefault(o => o.NAME == name);
        }


        public IEnumerable<USER> GetUsers()
        {
            return this.underlyingContext.Users.ToList();
        }


        public USER GetUser(string name, string pass)
        {
            return underlyingContext.Users.FirstOrDefault(o => o.NAME == name && o.PASSWORD == pass);
        }



        public CRF CreateCrf()
        {
            bool success = false;
            CRF obj = null;
            using (var transaction = new TransactionScope())
            {
                try
                {
                    obj = underlyingContext.CreateObject<CRF>();

                    obj.Id = GuidComb.Generate();
                    obj.CreatedBy = Authentification.GetCurrentUser().NAME;
                    obj.CreatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);
                    obj.UpdatedBy = Authentification.GetCurrentUser().NAME;
                    obj.UpdatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);
                    obj.StateCode = "---";

                    obj.NAME = "---";
                    obj.NUMBER = -100;
                    obj.DATE_BIRTH = null;
                    obj.DATE_HOSPITALISATION = null;
                    obj.DATE_DISCHARGE = null;
                    obj.AE_LOGIC = "2 - Нет";
                    obj.WARD = GetDefaultWard();


                    obj.TEST_FOR_PNEUMOCOCCAL = CreateTestForPneumococcal();
                    obj.BLOOD_CHEMISTRY = CreateBloodChemistry();
                    obj.BLOOD_CLINICAL_ANALYSIS = CreateBloodClinicalAnalysis();

                    obj.BLOOD_TESTS_FOR_MARKERS_OF_CARDIAC_DYSFUNCTION =
                        CreateBloodTestsForMarkersOfCardiacDysfunction();
                    obj.BLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATION = CreateTestsForMarkersOfInflammation();


                    obj.VISIT_ONE = CreateVisitOne();
                    obj.VISIT_ONE_ONE = CreateVisitOneOne();
                    obj.VISIT_TWO = CreateVisitTwo();
                    obj.VISIT_THREE = CreateVisitThree();

                    underlyingContext.CRFs.AddObject(obj);
                    Save();


                    // Mark the transaction as complete.
                    transaction.Complete();
                    success = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Операция не может быть выполнена. Ошибка: "
                                           + ex.Message);
                }

                if (success)
                {
                    underlyingContext.AcceptChanges();
                }
                else
                {
                    underlyingContext.RollbackChanges();
                    MessageBox.Show(@"Транзакция прервана!");

                }

                return obj;
            }
        }




        private BLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATION CreateTestsForMarkersOfInflammation()
        {
            var obj = underlyingContext.CreateObject<BLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATION>();
            obj.Id = GuidComb.Generate();
            obj.CreatedBy = Authentification.GetCurrentUser().NAME;
            obj.CreatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture); ;
            obj.UpdatedBy = Authentification.GetCurrentUser().NAME;
            obj.UpdatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture); ;

            obj.VISIT_ONE_C_REACTIVE_PROTEIN = null;
            obj.VISIT_ONE_FNO = null;
            obj.VISIT_ONE_IL6 = null;
            obj.VISIT_ONE_PROCALCITONIN = null;
            obj.VISIT_TWO_C_REACTIVE_PROTEIN = null;
            obj.VISIT_TWO_FNO = null;
            obj.VISIT_TWO_IL6 = null;
            obj.VISIT_TWO_PROCALCITONIN = null;
            obj.VISIT_THREE_C_REACTIVE_PROTEIN = null;
            obj.VISIT_THREE_FNO = null;
            obj.VISIT_THREE_IL6 = null;
            obj.VISIT_THREE_PROCALCITONIN = null;

            //     underlyingContext.BloodTestsForMarkersOfInflammations.AddObject(obj);

            //Save();

            return obj;
        }

        private BLOOD_TESTS_FOR_MARKERS_OF_CARDIAC_DYSFUNCTION CreateBloodTestsForMarkersOfCardiacDysfunction()
        {
            var obj = underlyingContext.CreateObject<BLOOD_TESTS_FOR_MARKERS_OF_CARDIAC_DYSFUNCTION>();

            obj.Id = GuidComb.Generate();
            obj.CreatedBy = Authentification.GetCurrentUser().NAME;
            obj.CreatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture); ;
            obj.UpdatedBy = Authentification.GetCurrentUser().NAME;
            obj.UpdatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture); ;
            obj.VISIT_ONE_BRAIN_NATRIURETIC_PEPTIDE = null;
            obj.VISIT_ONE_KOPEPTIN = null;
            obj.VISIT_ONE_PROADRENOMEDULLIN = null;
            obj.VISIT_TWO_BRAIN_NATRIURETIC_PEPTIDE = null;
            obj.VISIT_TWO_KOPEPTIN = null;
            obj.VISIT_TWO_PROADRENOMEDULLIN = null;
            obj.VISIT_THREE_BRAIN_NATRIURETIC_PEPTIDE = null;
            obj.VISIT_THREE_KOPEPTIN = null;
            obj.VISIT_THREE_PROADRENOMEDULLIN = null;

            //   underlyingContext.BloodTestsForMarkersOfCardiacDysfunctions.AddObject(obj);

            //Save(); 

            return obj;
        }

        private BLOOD_CLINICAL_ANALYSIS CreateBloodClinicalAnalysis()
        {
            var obj = underlyingContext.CreateObject<BLOOD_CLINICAL_ANALYSIS>();
            obj.Id = GuidComb.Generate();
            obj.CreatedBy = Authentification.GetCurrentUser().NAME;
            obj.CreatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture); ;
            obj.UpdatedBy = Authentification.GetCurrentUser().NAME;
            obj.UpdatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture); ;
            obj.VISIT_ONE_LEUKOCYTOSIS = null;
            obj.VISIT_ONE_LUKOCYTOSIS_YOUNG_FORMS = null;
            obj.VISIT_ONE_OTHERS = "---";
            obj.VISIT_ONE_SIGNIFICANT_CHANGES = "---";
            obj.VISIT_TWO_LEUKOCYTOSIS = null;
            obj.VISIT_TWO_LUKOCYTOSIS_YOUNG_FORMS = null;
            obj.VISIT_TWO_OTHERS = "---";
            obj.VISIT_TWO_SIGNIFICANT_CHANGES = "---";

            underlyingContext.BloodClinicalAnalyses.AddObject(obj);

            Save();

            return obj;
        }

        private BLOOD_CHEMISTRY CreateBloodChemistry()
        {
            var obj = underlyingContext.CreateObject<BLOOD_CHEMISTRY>();
            obj.Id = GuidComb.Generate();
            obj.CreatedBy = Authentification.GetCurrentUser().NAME;
            obj.CreatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);
            obj.UpdatedBy = Authentification.GetCurrentUser().NAME;
            obj.UpdatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);
            obj.VISIT_ONE_SIGNIFICANT_CHANGES = "---";
            obj.VISIT_ONE_CHANGES = "---";
            obj.VISIT_TWO_CHANGES = "---";
            obj.VISIT_TWO_SIGNIFICANT_CHANGES = "---";

            underlyingContext.BloodChemistrys.AddObject(obj);

            Save();

            return obj;
        }

        private TEST_FOR_PNEUMOCOCCAL CreateTestForPneumococcal()
        {
            var obj = underlyingContext.CreateObject<TEST_FOR_PNEUMOCOCCAL>();
            obj.Id = GuidComb.Generate();
            obj.CreatedBy = Authentification.GetCurrentUser().NAME;
            obj.CreatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);
            obj.UpdatedBy = Authentification.GetCurrentUser().NAME;
            obj.UpdatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);
            obj.LOGIC = "2 - Нет";
            obj.RESULT = "---";

            underlyingContext.TestForPneumococcals.AddObject(obj);

            Save();

            return obj;
        }

        private WARD GetDefaultWard()
        {
            if (!underlyingContext.Wards.Any())
            {
                underlyingContext.Wards.AddObject(new WARD
                {
                    CreatedBy = Authentification.GetCurrentUser().NAME,
                    CreatedByDate = DateTime.Now.ToString(),
                    UpdatedBy = Authentification.GetCurrentUser().NAME,
                    UpdatedByDate = DateTime.Now.ToString(),
                    NAME = "---",
                    NUMBER = 0,
                    Id = GuidComb.Generate()
                });

            }
            return underlyingContext.Wards.OrderBy(o => o.NUMBER).FirstOrDefault();
        }

        private ORGANISM GetDefaultOrganism()
        {
            if (!underlyingContext.Organisms.Any())
            {
                underlyingContext.Organisms.AddObject(new ORGANISM
                {
                    CreatedBy = Authentification.GetCurrentUser().NAME,
                    CreatedByDate = DateTime.Now.ToString(),
                    UpdatedBy = Authentification.GetCurrentUser().NAME,
                    UpdatedByDate = DateTime.Now.ToString(),
                    NAME = "---",
                    CODE = "---",
                    Id = GuidComb.Generate()
                });

            }
            return underlyingContext.Organisms.OrderBy(o => o.NAME).FirstOrDefault();
        }

        private DRUG GetDefaultDrug()
        {
            if (!underlyingContext.Drugs.Any())
            {
                underlyingContext.Drugs.AddObject(new DRUG
                {
                    CreatedBy = Authentification.GetCurrentUser().NAME,
                    CreatedByDate = DateTime.Now.ToString(),
                    UpdatedBy = Authentification.GetCurrentUser().NAME,
                    UpdatedByDate = DateTime.Now.ToString(),
                    NAME = "---",
                    MNN = "---",
                    GROUP = "---",
                    CODE = "0",
                    Id = GuidComb.Generate()
                })
                ;



            }
            return underlyingContext.Drugs.OrderBy(o => o.CODE).FirstOrDefault();
        }


        private ROUTE GetDefaultRoute()
        {
            if (!underlyingContext.Routes.Any())
            {
                underlyingContext.Routes.AddObject(new ROUTE
                {
                    CreatedBy = Authentification.GetCurrentUser().NAME,
                    CreatedByDate = DateTime.Now.ToString(),
                    UpdatedBy = Authentification.GetCurrentUser().NAME,
                    UpdatedByDate = DateTime.Now.ToString(),
                    NAME = "---",

                    CODE = "0",
                    Id = GuidComb.Generate()
                });

            }
            return underlyingContext.Routes.OrderBy(o => o.CODE).FirstOrDefault();
        }

        private VISIT_ONE CreateVisitOne()
        {
            var obj = underlyingContext.CreateObject<VISIT_ONE>();
            obj.CreatedBy = Authentification.GetCurrentUser().NAME;
            obj.CreatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);
            obj.UpdatedBy = Authentification.GetCurrentUser().NAME;
            obj.UpdatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);
            obj.StateCode = "---";

            obj.Id = GuidComb.Generate();
            obj.DATE_VISIT = null;

            //underlyingContext.VisitOnes.AddObject(obj);

            obj.ANAMNESTIC_DATA = CreateAnamnesticDataVisit1();
            obj.BASE_LIVE_INDICATORS_VISIT_1 = CreateBaseLiveIndicatorsVisit1();
            obj.COMPUTED_TOMOGRAPHY_CHEST_VISIT_1 = CreateComputedTomographyChestVisit1();
            obj.ECHOCARDIOGRAPHY_VISIT_1 = CreateEchocardiographyVisit1();
            obj.ELECTROCARDIOGRAPHY_VISIT_1 = CreateElectrocardiographyVisit1();
            obj.EVALUATION_OF_SYMPTOMS_VISIT_1 = CreateEvaluationOfSymptomsVisit1();
            obj.XRAY_CHEST_VISIT_1 = CreateXrayChestVisit1();


            //Save(); 

            return obj;
        }

        private XRAY_CHEST_VISIT_1 CreateXrayChestVisit1()
        {
            var obj = underlyingContext.CreateObject<XRAY_CHEST_VISIT_1>();
            obj.Id = GuidComb.Generate();
            obj.CreatedBy = Authentification.GetCurrentUser().NAME;
            obj.CreatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);
            obj.UpdatedBy = Authentification.GetCurrentUser().NAME;
            obj.UpdatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);

            obj.DATE_PROCEDURE = null;
            obj.PNEUMONIA_SIGNS = "---";
            obj.ALVEOLAR_INFILTRATION_LEFT_BOTTOM = null;
            obj.ALVEOLAR_INFILTRATION_LEFT_TOP = null;
            obj.ALVEOLAR_INFILTRATION_RIGHT_BOTTOM = null;
            obj.ALVEOLAR_INFILTRATION_RIGHT_MIDDLE = null;
            obj.ALVEOLAR_INFILTRATION_RIGHT_TOP = null;
            obj.INTERSTITIAL_INFILTRATION_LEFT_BOTTOM = null;
            obj.INTERSTITIAL_INFILTRATION_LEFT_TOP = null;
            obj.INTERSTITIAL_INFILTRATION_RIGHT_BOTTOM = null;
            obj.INTERSTITIAL_INFILTRATION_RIGHT_MIDDLE = null;
            obj.INTERSTITIAL_INFILTRATION_RIGHT_TOP = null;
            obj.PLEURAL_EFFUSION_DOUBLE = null;
            obj.PLEURAL_EFFUSION_LEFT = null;
            obj.PLEURAL_EFFUSION_NONE = null;
            obj.PLEURAL_EFFUSION_RIGHT = null;
            obj.OTHER = "---";

            //underlyingContext.XrayChestVisit1Set.AddObject(obj);

            //Save();

            return obj;
        }

        private ELECTROCARDIOGRAPHY_VISIT_1 CreateElectrocardiographyVisit1()
        {
            var obj = underlyingContext.CreateObject<ELECTROCARDIOGRAPHY_VISIT_1>();
            obj.Id = GuidComb.Generate();
            obj.CreatedBy = Authentification.GetCurrentUser().NAME;
            obj.CreatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);
            obj.UpdatedBy = Authentification.GetCurrentUser().NAME;
            obj.UpdatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);

            obj.DATE_PROCEDURE = null;
            obj.SINUS_RHYTHM = null;
            obj.ATRIAL_FIBRILLATION = null;
            obj.ARRYTHMIA_SUPRAVENTRICULAR = null;
            obj.ARRYTHMIA_VENTRICULAR_PREMATURE_BEATS = null;
            obj.HEART_RATE = null;
            obj.SIGNIFICANT_CHANGES = "---";

            //      underlyingContext.ElectrocardiographyVisit1Set.AddObject(obj);

            //Save();

            return obj;
        }

        private ECHOCARDIOGRAPHY_VISIT_1 CreateEchocardiographyVisit1()
        {
            var obj = underlyingContext.CreateObject<ECHOCARDIOGRAPHY_VISIT_1>();
            obj.Id = GuidComb.Generate();
            obj.CreatedBy = Authentification.GetCurrentUser().NAME;
            obj.CreatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);
            obj.UpdatedBy = Authentification.GetCurrentUser().NAME;
            obj.UpdatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);

            obj.DATE_PROCEDURE = null;
            obj.AMOUNT_OF_PERICARDIAL_EFFUSION = 0;
            obj.FV_PERCENT = null;
            obj.EA_LJ = null;
            obj.EA_RJ = null;
            obj.SDLA = null;
            obj.COMMENTS = "---";

            //underlyingContext.EchocardiographyVisit1Set.AddObject(obj);

            //Save();

            return obj;
        }



        private COMPUTED_TOMOGRAPHY_CHEST_VISIT_1 CreateComputedTomographyChestVisit1()
        {
            var obj = underlyingContext.CreateObject<COMPUTED_TOMOGRAPHY_CHEST_VISIT_1>();
            obj.Id = GuidComb.Generate();
            obj.CreatedBy = Authentification.GetCurrentUser().NAME;
            obj.CreatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);
            obj.UpdatedBy = Authentification.GetCurrentUser().NAME;
            obj.UpdatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);

            obj.DATE_PROCEDURE = null;
            obj.PNEUMONIA_SIGNS = "---";
            obj.ALVEOLAR_INFILTRATION_LEFT_BOTTOM = null;
            obj.ALVEOLAR_INFILTRATION_LEFT_TOP = null;
            obj.ALVEOLAR_INFILTRATION_RIGHT_BOTTOM = null;
            obj.ALVEOLAR_INFILTRATION_RIGHT_MIDDLE = null;
            obj.ALVEOLAR_INFILTRATION_RIGHT_TOP = null;
            obj.INTERSTITIAL_INFILTRATION_LEFT_BOTTOM = null;
            obj.INTERSTITIAL_INFILTRATION_LEFT_TOP = null;
            obj.INTERSTITIAL_INFILTRATION_RIGHT_BOTTOM = null;
            obj.INTERSTITIAL_INFILTRATION_RIGHT_MIDDLE = null;
            obj.INTERSTITIAL_INFILTRATION_RIGHT_TOP = null;
            obj.PLEURAL_EFFUSION_DOUBLE = null;
            obj.PLEURAL_EFFUSION_LEFT = null;
            obj.PLEURAL_EFFUSION_NONE = null;
            obj.PLEURAL_EFFUSION_RIGHT = null;
            obj.OTHER = "---";


            //underlyingContext.ComputedTomographyChestVisit1Set.AddObject(obj);

            //Save(); 

            return obj;
        }

        private BASE_LIVE_INDICATORS_VISIT_1 CreateBaseLiveIndicatorsVisit1()
        {
            var obj = underlyingContext.CreateObject<BASE_LIVE_INDICATORS_VISIT_1>();
            obj.Id = GuidComb.Generate();
            obj.CreatedBy = Authentification.GetCurrentUser().NAME;
            obj.CreatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);
            obj.UpdatedBy = Authentification.GetCurrentUser().NAME;
            obj.UpdatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);

            obj.BLOOD_PRESSURE_LEFT_HAND = null;
            obj.BLOOD_PRESSURE_RIGHT_HAND = null;
            obj.HEART_RATE = null;
            obj.RESPIRATORY_RATE = null;
            obj.TEMPERATURE = null;
            obj.HEAVY_TYPE = "---";
            obj.OXYGEN_THERAPY_NEEDED = "---";
            obj.DECOMPENSATION_SIGNS = "---";

            //      underlyingContext.BaseLiveIndicatorsVisit1Set.AddObject(obj);

            //Save();

            return obj;

        }

        private EVALUATION_OF_SYMPTOMS_VISIT_1 CreateEvaluationOfSymptomsVisit1()
        {
            var obj = underlyingContext.CreateObject<EVALUATION_OF_SYMPTOMS_VISIT_1>();

            obj.Id = GuidComb.Generate();
            obj.CreatedBy = Authentification.GetCurrentUser().NAME;
            obj.CreatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);
            obj.UpdatedBy = Authentification.GetCurrentUser().NAME;
            obj.UpdatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);

            obj.DYSPNEA = "---";
            obj.COUGH = "---";
            obj.SPUTUM = "---";
            obj.SPUTUM_TYPE = "---";
            obj.TEMPERATURE_INCREASE = "---";
            obj.COLD_SYMPTOM = "---";
            obj.SHORTERING_OF_PERCUSSION_SOUNDS = "---";
            obj.MOIST_RALES_SOUNDS = "---";
            obj.CREPITUS = "---";
            obj.PLEURAL_FRICTION_NOISE = "---";
            obj.DRY_RALES = "---";
            obj.PRESENCE_OF_EDEMA = "---";
            obj.INCIDENCE_OF_EDEMA = "---";

            //      underlyingContext.EvaluationOfSymptomsVisit1Set.AddObject(obj);

            //Save();

            return obj;
        }

        private ANAMNESTIC_DATA_VISIT_1 CreateAnamnesticDataVisit1()
        {
            var obj = underlyingContext.CreateObject<ANAMNESTIC_DATA_VISIT_1>();
            obj.Id = GuidComb.Generate();
            obj.CreatedBy = Authentification.GetCurrentUser().NAME;
            obj.CreatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);
            obj.UpdatedBy = Authentification.GetCurrentUser().NAME;
            obj.UpdatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);

            obj.DATE_SYMPTOM = null;
            obj.DATE_DIAGNOSIS = null;
            obj.NUMBER_EPISODES = null;
            obj.NUMBER_EPISODES_NODATA = true;
            obj.FUNCTION_CLASS = null;
            obj.OTHER_EPISODES = "---";
            obj.SMOKE_AVERAGE = null;
            obj.SMOKE_PACK_YEARS = null;
            obj.SMOKE_STATUS = "---";
            obj.SMOKE_YEARS = null;

            //     underlyingContext.AnamnesticDataVisit1Set.AddObject(obj);

            //Save();

            return obj;

        }

        private VISIT_ONE_ONE CreateVisitOneOne()
        {
            var obj = underlyingContext.CreateObject<VISIT_ONE_ONE>();
            obj.CreatedBy = Authentification.GetCurrentUser().NAME;
            obj.CreatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);
            obj.UpdatedBy = Authentification.GetCurrentUser().NAME;
            obj.UpdatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);

            obj.DATE_VISIT = null;

            //underlyingContext.VisitOneOnes.AddObject(obj);

            obj.EVALUATION_OF_SYMPTOMS_VISIT_11 = CreateEvaluationOfSymptomsVisit11();

            //   

            //Save(); 

            return obj;
        }

        private EVALUATION_OF_SYMPTOMS_VISIT_11 CreateEvaluationOfSymptomsVisit11()
        {
            var obj = underlyingContext.CreateObject<EVALUATION_OF_SYMPTOMS_VISIT_11>();

            obj.Id = GuidComb.Generate();
            obj.CreatedBy = Authentification.GetCurrentUser().NAME;
            obj.CreatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);
            obj.UpdatedBy = Authentification.GetCurrentUser().NAME;
            obj.UpdatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);

            obj.DYSPNEA = "---";
            obj.COUGH = "---";
            obj.SPUTUM = "---";
            obj.SPUTUM_TYPE = "---";
            obj.TEMPERATURE_INCREASE = "---";
            obj.COLD_SYMPTOM = "---";
            obj.SHORTERING_OF_PERCUSSION_SOUNDS = "---";
            obj.MOIST_RALES_SOUNDS = "---";
            obj.CREPITUS = "---";
            obj.PLEURAL_FRICTION_NOISE = "---";
            obj.DRY_RALES = "---";
            obj.PRESENCE_OF_EDEMA = "---";
            obj.INCIDENCE_OF_EDEMA = "---";
            obj.THERAPY_EFFICIENCY = "---";

            //      underlyingContext.EvaluationOfSymptomsVisit11Set.AddObject(obj);

            //Save();

            return obj;
        }
        private VISIT_TWO CreateVisitTwo()
        {
            var obj = underlyingContext.CreateObject<VISIT_TWO>();
            obj.CreatedBy = Authentification.GetCurrentUser().NAME;
            obj.CreatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);
            obj.UpdatedBy = Authentification.GetCurrentUser().NAME;
            obj.UpdatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);

            obj.DATE_VISIT = null;

            // underlyingContext.VisitTwoes.AddObject(obj);

            obj.BASE_LIVE_INDICATORS_VISIT_2 = CreateBaseLiveIndicatorsVisit2();
            obj.EVALUATION_OF_SYMPTOMS_VISIT_2 = CreateEvaluationOfSymptomsVisit2();



            //Save(); 

            return obj;
        }

        private EVALUATION_OF_SYMPTOMS_VISIT_2 CreateEvaluationOfSymptomsVisit2()
        {
            var obj = underlyingContext.CreateObject<EVALUATION_OF_SYMPTOMS_VISIT_2>();

            obj.Id = GuidComb.Generate();
            obj.CreatedBy = Authentification.GetCurrentUser().NAME;
            obj.CreatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);
            obj.UpdatedBy = Authentification.GetCurrentUser().NAME;
            obj.UpdatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);

            obj.DYSPNEA = "---";
            obj.COUGH = "---";
            obj.SPUTUM = "---";
            obj.SPUTUM_TYPE = "---";
            obj.TEMPERATURE_INCREASE = "---";
            obj.COLD_SYMPTOM = "---";
            obj.SHORTERING_OF_PERCUSSION_SOUNDS = "---";
            obj.MOIST_RALES_SOUNDS = "---";
            obj.CREPITUS = "---";
            obj.PLEURAL_FRICTION_NOISE = "---";
            obj.DRY_RALES = "---";
            obj.PRESENCE_OF_EDEMA = "---";
            obj.INCIDENCE_OF_EDEMA = "---";
            obj.THERAPY_EFFICIENCY = "---";

            //     underlyingContext.EvaluationOfSymptomsVisit2Set.AddObject(obj);

            //Save();

            return obj;
        }

        private BASE_LIVE_INDICATORS_VISIT_2 CreateBaseLiveIndicatorsVisit2()
        {
            var obj = underlyingContext.CreateObject<BASE_LIVE_INDICATORS_VISIT_2>();
            obj.Id = GuidComb.Generate();
            obj.CreatedBy = Authentification.GetCurrentUser().NAME;
            obj.CreatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);
            obj.UpdatedBy = Authentification.GetCurrentUser().NAME;
            obj.UpdatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);

            obj.BLOOD_PRESSURE_LEFT_HAND = null;
            obj.BLOOD_PRESSURE_RIGHT_HAND = null;
            obj.HEART_RATE = null;
            obj.RESPIRATORY_RATE = null;
            obj.TEMPERATURE = null;

            //     underlyingContext.BaseLiveIndicatorsVisit2Set.AddObject(obj);

            //Save(); 

            return obj;
        }
        private VISIT_THREE CreateVisitThree()
        {
            var obj = underlyingContext.CreateObject<VISIT_THREE>();
            obj.CreatedBy = Authentification.GetCurrentUser().NAME;
            obj.CreatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);
            obj.UpdatedBy = Authentification.GetCurrentUser().NAME;
            obj.UpdatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);

            obj.DATE_VISIT = null;

            //underlyingContext.VisitThrees.AddObject(obj);

            obj.ECHOCARDIOGRAPHY_VISIT_3 = CreateEchocardiographyVisit3();

            //   

            //Save(); 

            return obj;
        }

        private ECHOCARDIOGRAPHY_VISIT_3 CreateEchocardiographyVisit3()
        {
            var obj = underlyingContext.CreateObject<ECHOCARDIOGRAPHY_VISIT_3>();
            obj.Id = GuidComb.Generate();
            obj.CreatedBy = Authentification.GetCurrentUser().NAME;
            obj.CreatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);
            obj.UpdatedBy = Authentification.GetCurrentUser().NAME;
            obj.UpdatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);

            obj.DATE_PROCEDURE = null;
            obj.AMOUNT_OF_PERICARDIAL_EFFUSION = 0;
            obj.FV_PERCENT = null;
            obj.EA_LJ = null;
            obj.EA_RJ = null;
            obj.SDLA = null;
            obj.COMMENTS = "---";

            //     underlyingContext.EchocardiographyVisit3Set.AddObject(obj);

            //Save();

            return obj;
        }

        public ADVERSE_EVENT CreateAdverseEvent(CRF crf)
        {
            ADVERSE_EVENT obj = null;
            try
            {
                obj = underlyingContext.CreateObject<ADVERSE_EVENT>();
                obj.Id = GuidComb.Generate();
                obj.CreatedBy = Authentification.GetCurrentUser().NAME;
                obj.CreatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);
                obj.UpdatedBy = Authentification.GetCurrentUser().NAME;
                obj.UpdatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);
                obj.CRF = crf;
                obj.NAME = "---";
                obj.DATE_START = null;
                obj.DATE_END = null;
                obj.HEAVY = "---";
                obj.RESULT = "---";
                obj.RELATION = "---";
                obj.ACTIONS = "---";
                underlyingContext.AEs.AddObject(obj);
                Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Не удалось создать Нежелательное явление" + ex.Message);
            }
            return obj;
        }

        public AB_THERAPY CreateABTherapy(CRF crf)
        {
            AB_THERAPY obj = null;
            try
            {
                obj = underlyingContext.CreateObject<AB_THERAPY>();
                obj.Id = GuidComb.Generate();
                obj.CreatedBy = Authentification.GetCurrentUser().NAME;
                obj.CreatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);
                obj.UpdatedBy = Authentification.GetCurrentUser().NAME;
                obj.UpdatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);
                obj.CRF = crf;
                obj.DRUG = GetDefaultDrug();
                obj.ROUTE = GetDefaultRoute();
                obj.SINGLE_DOSE = "---";
                obj.FREQUENCY = "---";
                obj.DATE_START = null;
                obj.DATE_END = null;

                underlyingContext.AbTherapys.AddObject(obj);
                Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Не удалось создать Терапия" + ex.Message);
            }
            return obj;
        }

        public MICROBIOLOGY_SPUTUM CreateMicrobiologySputum(CRF crf)
        {
            MICROBIOLOGY_SPUTUM obj = null;
            try
            {
                obj = underlyingContext.CreateObject<MICROBIOLOGY_SPUTUM>();
                obj.Id = GuidComb.Generate();
                obj.CreatedBy = Authentification.GetCurrentUser().NAME;
                obj.CreatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);
                obj.UpdatedBy = Authentification.GetCurrentUser().NAME;
                obj.UpdatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);
                obj.CRF = crf;
                obj.ORGANISM = GetDefaultOrganism();
                obj.DATE_CAPTURE = null;
                obj.LAB_NUMBER = "---";
                obj.QUALITY_EPITHELIAL = "---";
                obj.QUALITY_LEUKOCYTES = "---";
                obj.NOT_REPRESENTATIVE = null;
                obj.GROWTH_PATHOGENS = "---";
                obj.BETA = "---";
                obj.MRSA = "---";
                underlyingContext.MicrobiologySputums.AddObject(obj);
                Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Не удалось создать Терапия" + ex.Message);
            }
            return obj;
        }

        public MICROBIOLOGY_BLOOD CreateMicrobiologyBlood(CRF crf)
        {
            MICROBIOLOGY_BLOOD obj = null;
            try
            {
                obj = underlyingContext.CreateObject<MICROBIOLOGY_BLOOD>();
                obj.Id = GuidComb.Generate();
                obj.CreatedBy = Authentification.GetCurrentUser().NAME;
                obj.CreatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);
                obj.UpdatedBy = Authentification.GetCurrentUser().NAME;
                obj.UpdatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);
                obj.CRF = crf;
                obj.ORGANISM = GetDefaultOrganism();
                obj.DATE_CAPTURE = null;
                obj.LAB_NUMBER = "---";
                obj.GROWTH_PATHOGENS = "---";
                obj.BETA = "---";
                obj.MRSA = "---";
                underlyingContext.MicrobiologyBloods.AddObject(obj);
                Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Не удалось создать Терапия" + ex.Message);
            }
            return obj;
        }

    }
}
