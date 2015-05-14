using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data.Entity.Core.Objects;

using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security;
using System.Text;
using System.Windows;
using System.Windows.Media.Media3D;
using CINCOPA.Model;



using System.Data;


using System.Transactions;

namespace CINCOPA.Common
{
    public class DataManager
    {
        private static DataManager instance;
        private static List<WARD> wardLookup;
        private static List<ORGANISM> organismLookup;
        private static List<ROUTE> routeLookup;
        private static List<DRUG> drugLookup;
        private static readonly List<string> fkLookup = new List<string>();
        private static readonly List<string> logic3Lookup = new List<string>();
        private static readonly List<string> logic3Type2Lookup = new List<string>();
        private static readonly List<string> logic2Lookup = new List<string>();
        private static readonly List<string> smokeStatusLookup = new List<string>();
        private static readonly List<string> heavyLookup = new List<string>();
        private static readonly List<string> sputumTypeLookup = new List<string>();
        private static readonly List<string> incidenceEdemaLookup = new List<string>();
        private static readonly List<string> dinamicLookup = new List<string>();
        private static readonly List<string> efficiencyLookup = new List<string>();
        private static readonly List<string> resultLookup = new List<string>();
        private static readonly List<string> aeHeavyLookup = new List<string>();
        private static readonly List<string> aeResultLookup = new List<string>();
        private static readonly List<string> aeRelationLookup = new List<string>();
        private static readonly List<string> aeActionsLookup = new List<string>();


        public List<string> AEHeavyLookup
        {
            get
            {
                if (aeHeavyLookup.Count == 0)
                {
                    aeHeavyLookup.Add("---");
                    aeHeavyLookup.Add("1 - Легкая");
                    aeHeavyLookup.Add("2 - Средняя");
                    aeHeavyLookup.Add("3 - Тяжелая");
                }
                return aeHeavyLookup;
            }

        }
        public List<string> AEResultLookup
        {
            get
            {
                if (aeResultLookup.Count == 0)
                {
                    aeResultLookup.Add("---");
                    aeResultLookup.Add("1 - Выздоровление");
                    aeResultLookup.Add("2 - Улучшение");
                    aeResultLookup.Add("3 - Без изменений");
                    aeResultLookup.Add("4 - Ухудшение");
                }
                return aeResultLookup;
            }

        }
        public List<string> AERelationLookup
        {
            get
            {
                if (aeRelationLookup.Count == 0)
                {
                    aeRelationLookup.Add("---");
                    aeRelationLookup.Add("1 - Нет");
                    aeRelationLookup.Add("2 - Неизвестно");
                    aeRelationLookup.Add("3 - Сомнительная");
                    aeRelationLookup.Add("4 - Возможная");
                    aeRelationLookup.Add("5 - Вероятная");
                }
                return aeRelationLookup;
            }

        }
        public List<string> AEActionsLookup
        {
            get
            {
                if (aeActionsLookup.Count == 0)
                {
                    aeActionsLookup.Add("---");
                    aeActionsLookup.Add("1 - Нет");
                    aeActionsLookup.Add("2 - Уменьшение дозы");
                    aeActionsLookup.Add("3 - Временная отмена препарата");
                    aeActionsLookup.Add("4 - Выведение из исследования");
                    aeActionsLookup.Add("5 - Корригирующая терапия");
                }
                return aeActionsLookup;
            }

        }
        public List<string> ResultLookup
        {
            get
            {
                if (resultLookup.Count == 0)
                {
                    resultLookup.Add("---");
                    resultLookup.Add("1 - Положительный");
                    resultLookup.Add("2 - Отрицательный");
                }
                return resultLookup;
            }

        }
        public List<string> EfficiencyLookup
        {
            get
            {
                if (efficiencyLookup.Count == 0)
                {
                    efficiencyLookup.Add("---");
                    efficiencyLookup.Add("1 - Выздоровление");
                    efficiencyLookup.Add("2 - Улучшение");
                    efficiencyLookup.Add("3 - Ухудшение");
                    efficiencyLookup.Add("4 - Рецидив");
                }
                return efficiencyLookup;
            }
        }
        public List<string> DinamicLookup
        {
            get
            {
                if (dinamicLookup.Count == 0)
                {
                    dinamicLookup.Add("---");
                    dinamicLookup.Add("1 - Разрешение");
                    dinamicLookup.Add("2 - Улучшение");
                    dinamicLookup.Add("3 - Ухудшение");
                    dinamicLookup.Add("4 - Без Изменений");
                    dinamicLookup.Add("5 - Новый симптом");
                }
                return dinamicLookup;
            }
        }
        public List<string> IncidenceEdemaLookup
        {
            get
            {
                if (incidenceEdemaLookup.Count == 0)
                {
                    incidenceEdemaLookup.Add("---");
                    incidenceEdemaLookup.Add("1 - Только стопы");
                    incidenceEdemaLookup.Add("2 - Стопы и голени");
                    incidenceEdemaLookup.Add("3 - Анасарка");
                    incidenceEdemaLookup.Add("4 - Не применимо");
                }
                return incidenceEdemaLookup;
            }
        }
        public List<string> SputumTypeLookup
        {
            get
            {
                if (sputumTypeLookup.Count == 0)
                {
                    sputumTypeLookup.Add("---");
                    sputumTypeLookup.Add("1 - Слизистая");
                    sputumTypeLookup.Add("2 - Слизисто-гнойная");
                    sputumTypeLookup.Add("3 - Гнойная");
                }
                return sputumTypeLookup;
            }
        }
        public List<string> HeavyLookup
        {
            get
            {
                if (heavyLookup.Count == 0)
                {
                    heavyLookup.Add("---");
                    heavyLookup.Add("1 - Нетяжелая");
                    heavyLookup.Add("2 - Тяжелая");
                }
                return heavyLookup;
            }
        }
        public List<string> SmokeStatusLookup
        {
            get
            {
                if (smokeStatusLookup.Count == 0)
                {
                    smokeStatusLookup.Add("---");
                    smokeStatusLookup.Add("1 - Курящий");
                    smokeStatusLookup.Add("2 - Ранее куривший");
                    smokeStatusLookup.Add("3 - Никогда не куривший");
                }
                return smokeStatusLookup;
            }
        }
        public List<string> Logic3Lookup
        {
            get
            {
                if (logic3Lookup.Count == 0)
                {
                    logic3Lookup.Add("---");
                    logic3Lookup.Add("1 - Да");
                    logic3Lookup.Add("2 - Нет");
                    logic3Lookup.Add("3 - Нет данных");
                }
                return logic3Lookup;
            }
        }
        public List<string> Logic3Type2Lookup
        {
            get
            {
                if (logic3Type2Lookup.Count == 0)
                {
                    logic3Type2Lookup.Add("---");
                    logic3Type2Lookup.Add("1 - Да");
                    logic3Type2Lookup.Add("2 - Нет");
                    logic3Type2Lookup.Add("3 - Неприменимо");
                }
                return logic3Type2Lookup;
            }
        }
        public List<string> Logic2Lookup
        {
            get
            {
                if (logic2Lookup.Count == 0)
                {
                    logic2Lookup.Add("---");
                    logic2Lookup.Add("1 - Да");
                    logic2Lookup.Add("2 - Нет");
                }
                return logic2Lookup;
            }
        }
        public List<WARD> WardLookup
        {
            get
            {
                if (wardLookup == null)
                {
                    wardLookup = underlyingContext.Wards.OrderBy(o => o.NAME).ToList();
                }
                return wardLookup;
            }
        }
        public List<DRUG> DrugLookup
        {
            get
            {
                return drugLookup = underlyingContext.Drugs.OrderBy(o => o.NAME).ToList();

            }
        }
        public List<ROUTE> RouteLookup
        {
            get
            {
                return routeLookup = underlyingContext.Routes.OrderBy(o => o.NAME).ToList();

            }
        }
        public List<ORGANISM> OrganismLookup
        {
            get
            {
                organismLookup = underlyingContext.Organisms.OrderBy(o => o.NAME).ToList();
                return organismLookup;
            }
        }
        public List<string> FkLookup
        {
            get
            {
                if (fkLookup.Count == 0)
                {
                    fkLookup.Add("---");
                    fkLookup.Add("1 - I");
                    fkLookup.Add("2 - II");
                    fkLookup.Add("3 - III");
                    fkLookup.Add("4 - IV");
                }
                return fkLookup;
            }
        }




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
            //using (var transaction = new TransactionScope())
            //{
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
                // transaction.Complete();
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
            obj.VISIT_ONE_LEUKOCYTOSIS_YOUNG_FORMS = null;
            obj.VISIT_ONE_OTHERS = "---";
            obj.VISIT_ONE_SIGNIFICANT_CHANGES = "---";
            obj.VISIT_TWO_LEUKOCYTOSIS = null;
            obj.VISIT_TWO_LEUKOCYTOSIS_YOUNG_FORMS = null;
            obj.VISIT_TWO_OTHERS = "---";
            obj.VISIT_TWO_SIGNIFICANT_CHANGES = "---";

            underlyingContext.BloodClinicalAnalyses.AddObject(obj);

            // Save();

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

            //Save();

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

            //   Save();

            return obj;
        }

        private WARD GetDefaultWard()
        {
            //if (!underlyingContext.Wards.Any())
            //{
            //    underlyingContext.Wards.AddObject(new WARD
            //    {
            //        CreatedBy = Authentification.GetCurrentUser().NAME,
            //        CreatedByDate = DateTime.Now.ToString(),
            //        UpdatedBy = Authentification.GetCurrentUser().NAME,
            //        UpdatedByDate = DateTime.Now.ToString(),
            //        NAME = "---",
            //        NUMBER = 0,
            //        Id = GuidComb.Generate()
            //    });
            //    Save();
            //}
            var obj = underlyingContext.Wards.OrderBy(o => o.NUMBER).FirstOrDefault();
            return obj;
        }

        private ORGANISM GetDefaultOrganism()
        {
            //if (!underlyingContext.Organisms.Any())
            //{
            //    underlyingContext.Organisms.AddObject(new ORGANISM
            //    {
            //        CreatedBy = Authentification.GetCurrentUser().NAME,
            //        CreatedByDate = DateTime.Now.ToString(),
            //        UpdatedBy = Authentification.GetCurrentUser().NAME,
            //        UpdatedByDate = DateTime.Now.ToString(),
            //        NAME = "---",
            //        CODE = "---",
            //        Id = GuidComb.Generate()
            //    });

            //}
            return underlyingContext.Organisms.OrderBy(o => o.NAME).FirstOrDefault();
        }

        private DRUG GetDefaultDrug()
        {
            //if (!underlyingContext.Drugs.Any())
            //{
            //    underlyingContext.Drugs.AddObject(new DRUG
            //    {
            //        CreatedBy = Authentification.GetCurrentUser().NAME,
            //        CreatedByDate = DateTime.Now.ToString(),
            //        UpdatedBy = Authentification.GetCurrentUser().NAME,
            //        UpdatedByDate = DateTime.Now.ToString(),
            //        NAME = "---",
            //        MNN = "---",
            //        GROUP = "---",
            //        CODE = "0",
            //        Id = GuidComb.Generate()
            //    })
            //    ;



            //}
            return underlyingContext.Drugs.OrderBy(o => o.CODE).FirstOrDefault();
        }


        private ROUTE GetDefaultRoute()
        {
            //if (!underlyingContext.Routes.Any())
            //{
            //    underlyingContext.Routes.AddObject(new ROUTE
            //    {
            //        CreatedBy = Authentification.GetCurrentUser().NAME,
            //        CreatedByDate = DateTime.Now.ToString(),
            //        UpdatedBy = Authentification.GetCurrentUser().NAME,
            //        UpdatedByDate = DateTime.Now.ToString(),
            //        NAME = "---",

            //        CODE = "0",
            //        Id = GuidComb.Generate()
            //    });

            //}
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

            obj.Id = GuidComb.Generate();
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

            obj.Id = GuidComb.Generate();
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

            obj.Id = GuidComb.Generate();
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
                //  Save();
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
                //  Save();
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
                // Save();
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
                // Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Не удалось создать Терапия" + ex.Message);
            }
            return obj;
        }


        public List<CRF> GetCrfForCurrentUser()
        {
            try
            {
                var str = Authentification.GetCurrentUser().NAME;
                return underlyingContext.CRFs.Where(o => o.CreatedBy == str).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось получить список карт.", ex.Message);
                return null;
            }

        }

        public IEnumerable<ORGANISM> GetAllOrganisms()
        {
            return underlyingContext.Organisms.OrderBy(o => o.NAME);
        }

        public IEnumerable<ROUTE> GetAllRoutes()
        {
            return underlyingContext.Routes.OrderBy(o => o.NAME);
        }

        public IEnumerable<DRUG> GetAllDrugs()
        {
            return underlyingContext.Drugs.OrderBy(o => o.NAME);
        }

        public ORGANISM AddOrganism(string NewItem)
        {
            try
            {
                var obj = underlyingContext.CreateObject<ORGANISM>();
                obj.Id = GuidComb.Generate();
                obj.CreatedBy = Authentification.GetCurrentUser().NAME;
                obj.CreatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);
                obj.UpdatedBy = Authentification.GetCurrentUser().NAME;
                obj.UpdatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);
                obj.NAME = NewItem;
                obj.CODE = "NEED_CODE";
                underlyingContext.Organisms.AddObject(obj);
                Save();
                return obj;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось добавить организм! Ошибка: " + ex.Message);
                return null;
            }
        }

        public ADVERSE_EVENT CreateAEforCRF(CRF Model)
        {
            try
            {
                var obj = underlyingContext.CreateObject<ADVERSE_EVENT>();
                obj.Id = GuidComb.Generate();
                obj.CreatedBy = Authentification.GetCurrentUser().NAME;
                obj.CreatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);
                obj.UpdatedBy = Authentification.GetCurrentUser().NAME;
                obj.UpdatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);

                obj.CRFId = Model.Id;
                obj.ACTIONS = "---";
                obj.HEAVY = "---";
                obj.NAME = "---";
                obj.RELATION = "---";
                obj.RESULT = "---";

                return obj;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        public void DeleteAE(ADVERSE_EVENT obj)
        {
            underlyingContext.AEs.DeleteObject(obj);

        }

        public AB_THERAPY CreateABforCRF(CRF Model)
        {
            try
            {
                var obj = underlyingContext.CreateObject<AB_THERAPY>();
                obj.Id = GuidComb.Generate();
                obj.CreatedBy = Authentification.GetCurrentUser().NAME;
                obj.CreatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);
                obj.UpdatedBy = Authentification.GetCurrentUser().NAME;
                obj.UpdatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);

                obj.CRFId = Model.Id;
                obj.DRUG = GetDefaultDrug();
                obj.ROUTE = GetDefaultRoute();
                obj.SINGLE_DOSE = "---";
                obj.FREQUENCY = "---";
                obj.DATE_START = null;
                obj.DATE_END = null;

                return obj;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public void DeleteABTherapy(AB_THERAPY aB_THERAPY)
        {
            underlyingContext.AbTherapys.DeleteObject(aB_THERAPY);
        }

        public DRUG AddDrug(string NewItem)
        {
            try
            {
                var obj = underlyingContext.CreateObject<DRUG>();
                obj.Id = GuidComb.Generate();
                obj.CreatedBy = Authentification.GetCurrentUser().NAME;
                obj.CreatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);
                obj.UpdatedBy = Authentification.GetCurrentUser().NAME;
                obj.UpdatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);
                obj.NAME = NewItem;
                obj.CODE = "NEED_CODE";
                underlyingContext.Drugs.AddObject(obj);
                Save();
                return obj;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось добавить препарат! Ошибка: " + ex.Message);
                return null;
            }
        }

        public ROUTE AddRoute(string NewItem)
        {
            try
            {
                var obj = underlyingContext.CreateObject<ROUTE>();
                obj.Id = GuidComb.Generate();
                obj.CreatedBy = Authentification.GetCurrentUser().NAME;
                obj.CreatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);
                obj.UpdatedBy = Authentification.GetCurrentUser().NAME;
                obj.UpdatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);
                obj.NAME = NewItem;
                obj.CODE = "NEED_CODE";
                underlyingContext.Routes.AddObject(obj);
                Save();
                return obj;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось добавить препарат! Ошибка: " + ex.Message);
                return null;
            }
        }

        public MICROBIOLOGY_SPUTUM CreateMicrobiologySputumForCRF(CRF Model)
        {
            try
            {
                var obj = underlyingContext.CreateObject<MICROBIOLOGY_SPUTUM>();
                obj.Id = GuidComb.Generate();
                obj.CreatedBy = Authentification.GetCurrentUser().NAME;
                obj.CreatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);
                obj.UpdatedBy = Authentification.GetCurrentUser().NAME;
                obj.UpdatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);

                obj.CRFId = Model.Id;
                obj.BETA = "---";
                obj.DATE_CAPTURE = null;
                obj.GROWTH_PATHOGENS = "---";
                obj.LAB_NUMBER = "---";
                obj.QUALITY_LEUKOCYTES = "---";
                obj.QUALITY_EPITHELIAL = "---";
                obj.NOT_REPRESENTATIVE = null;
                obj.ORGANISM = GetDefaultOrganism();
                obj.MRSA = "---";

                return obj;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public MICROBIOLOGY_BLOOD CreateMicrobiologyBloodForCRF(CRF Model)
        {
            try
            {
                var obj = underlyingContext.CreateObject<MICROBIOLOGY_BLOOD>();
                obj.Id = GuidComb.Generate();
                obj.CreatedBy = Authentification.GetCurrentUser().NAME;
                obj.CreatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);
                obj.UpdatedBy = Authentification.GetCurrentUser().NAME;
                obj.UpdatedByDate = DateTime.Now.ToString(CultureInfo.CurrentUICulture);

                obj.CRFId = Model.Id;
                obj.BETA = "---";
                obj.DATE_CAPTURE = null;
                obj.GROWTH_PATHOGENS = "---";
                obj.LAB_NUMBER = "---";
                obj.ORGANISM = GetDefaultOrganism();
                obj.MRSA = "---";

                return obj;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public void DeleteMBSputum(MICROBIOLOGY_SPUTUM mICROBIOLOGY_SPUTUM)
        {
           underlyingContext.MicrobiologySputums.DeleteObject(mICROBIOLOGY_SPUTUM);
        }



        public void DeleteMBBlood(MICROBIOLOGY_BLOOD mICROBIOLOGY_BLOOD)
        {
            underlyingContext.MicrobiologyBloods.DeleteObject(mICROBIOLOGY_BLOOD);
        }

        public List<CRF> GetCrfForOtherUser()
        {
            try
            {
                var str = Authentification.GetCurrentUser().NAME;
                return underlyingContext.CRFs.Where(o => o.CreatedBy != str).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось получить список карт.", ex.Message);
                return null;
            }
        }
    }
}

