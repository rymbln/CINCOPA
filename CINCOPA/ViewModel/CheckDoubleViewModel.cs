using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using CINCOPA.Common;
using CINCOPA.Model;
using CINCOPA.Views;

namespace CINCOPA.ViewModel
{
    public class CRFCheckDouble
    {
        private CRF model;
        private string result;

        public CRFCheckDouble(CRF crf, string res)
        {
            model = crf;
            result = res;
        }

        public CRF Model
        {
            get { return model; }
        }

        public string Result
        {
            get { return result; }
        }
    }

    public class CheckDoubleViewModel : ViewModelBase
    {
        private CRFCheckDouble currentCrf { get; set; }
        public CheckDoubleViewModel()
        {

            CRFCheckDoubles = new ObservableCollection<CRFCheckDouble>();
            OpenCrfCommand = new DelegateCommand(o => OpenCrf(), o => CurrentCrf != null);

            var crfCurrentUser = DataManager.Instance.GetCrfForCurrentUser();
            var crfOtherUser = DataManager.Instance.GetCrfForOtherUser();

            foreach (var crf in crfCurrentUser)
            {
                var otherCrf = crfOtherUser.FirstOrDefault(o => o.NUMBER == crf.NUMBER);
                var result = "";
                if (otherCrf == null)
                {
                    result += "Отсутствует сопоставленная карта второго оператора;\r\n";
                }
                else
                {
                    if (!crf.ShortString.Equals(otherCrf.ShortString))
                    {
                        result += "Различия в данных карты;\r\n";
                    }
                    
                    if (!crf.VISIT_ONE.ShortString.Equals(otherCrf.VISIT_ONE.ShortString))
                    {
                        result += "Различия в дате визита 1;\r\n";
                    }
                    if (!crf.VISIT_ONE.ANAMNESTIC_DATA.ShortString.Equals(otherCrf.VISIT_ONE.ANAMNESTIC_DATA.ShortString))
                    {
                        result += "Различия в Визит 1 - Анамнестические Данные;\r\n";
                    }
                    if (!crf.VISIT_ONE.BASE_LIVE_INDICATORS_VISIT_1.ShortString.Equals(otherCrf.VISIT_ONE.BASE_LIVE_INDICATORS_VISIT_1.ShortString))
                    {
                        result += "Различия в Визит 1 - Основные показатели жизнедеятельности;\r\n";
                    }
                    if (!crf.VISIT_ONE.EVALUATION_OF_SYMPTOMS_VISIT_1.ShortString.Equals(otherCrf.VISIT_ONE.EVALUATION_OF_SYMPTOMS_VISIT_1.ShortString))
                    {
                        result += "Различия в Визит 1 - Оценка симптомов ВП и ХСН;\r\n";
                    }
                    if (!crf.VISIT_ONE.XRAY_CHEST_VISIT_1.ShortString.Equals(otherCrf.VISIT_ONE.XRAY_CHEST_VISIT_1.ShortString))
                    {
                        result += "Различия в Визит 1 - Рентгенография органов грудной клетки;\r\n";
                    }
                    if (!crf.VISIT_ONE.COMPUTED_TOMOGRAPHY_CHEST_VISIT_1.ShortString.Equals(otherCrf.VISIT_ONE.COMPUTED_TOMOGRAPHY_CHEST_VISIT_1.ShortString))
                    {
                        result += "Различия в Визит 1 - Компьютерная томография органов грудной клетки;\r\n";
                    }
                    if (!crf.VISIT_ONE.ELECTROCARDIOGRAPHY_VISIT_1.ShortString.Equals(otherCrf.VISIT_ONE.ELECTROCARDIOGRAPHY_VISIT_1.ShortString))
                    {
                        result += "Различия в Визит 1 - Электрокардиографическое исследование;\r\n";
                    }
                    if (!crf.VISIT_ONE.ECHOCARDIOGRAPHY_VISIT_1.ShortString.Equals(otherCrf.VISIT_ONE.ECHOCARDIOGRAPHY_VISIT_1.ShortString))
                    {
                        result += "Различия в Визит 1 - Эхокардиографическое исследование;\r\n";
                    }


                    if (!crf.VISIT_TWO.ShortString.Equals(otherCrf.VISIT_TWO.ShortString))
                    {
                        result += "Различия в дате визита 2;\r\n";
                    }
                    if (!crf.VISIT_TWO.BASE_LIVE_INDICATORS_VISIT_2.ShortString.Equals(otherCrf.VISIT_TWO.BASE_LIVE_INDICATORS_VISIT_2.ShortString))
                    {
                        result += "Различия в Визит 2 - Основные показатели жизнедеятельности;\r\n";
                    }
                    if (!crf.VISIT_TWO.EVALUATION_OF_SYMPTOMS_VISIT_2.ShortString.Equals(otherCrf.VISIT_TWO.EVALUATION_OF_SYMPTOMS_VISIT_2.ShortString))
                    {
                        result += "Различия в Визит 2 - Динамика симптомов ВП и ХСН;\r\n";
                    }
                    

        
                    if (!crf.VISIT_THREE.ShortString.Equals(otherCrf.VISIT_THREE.ShortString))
                    {
                        result += "Различия в дате визита 3;\r\n";
                    }
                    if (!crf.VISIT_THREE.ECHOCARDIOGRAPHY_VISIT_3.ShortString.Equals(otherCrf.VISIT_THREE.ECHOCARDIOGRAPHY_VISIT_3.ShortString))
                    {
                        result += "Различия в Визит 3 - Эхокардиографическое исследование;\r\n";
                    }

         
                    if (!crf.VISIT_ONE_ONE.EVALUATION_OF_SYMPTOMS_VISIT_11.ShortString.Equals(otherCrf.VISIT_ONE_ONE.EVALUATION_OF_SYMPTOMS_VISIT_11.ShortString))
                    {
                        result += "Различия в дате визита 1.1;\r\n";
                    }
                    if (!crf.VISIT_ONE_ONE.ShortString.Equals(otherCrf.VISIT_ONE_ONE.ShortString))
                    {
                        result += "Различия в Визит 1.1 - Динамика симптомов ВП и ХСН;\r\n";
                    }

                    if (!crf.BLOOD_CLINICAL_ANALYSIS.ShortString.Equals(otherCrf.BLOOD_CLINICAL_ANALYSIS.ShortString))
                    {
                        result += "Различия в Клиническом анализе крови;\r\n";
                    }

                    if (!crf.BLOOD_CHEMISTRY.ShortString.Equals(otherCrf.BLOOD_CHEMISTRY.ShortString))
                    {
                        result += "Различия в Биохимическом анализе крови;\r\n";
                    }

                    if (!crf.BLOOD_TESTS_FOR_MARKERS_OF_CARDIAC_DYSFUNCTION.ShortString.Equals(otherCrf.BLOOD_TESTS_FOR_MARKERS_OF_CARDIAC_DYSFUNCTION.ShortString))
                    {
                        result += "Различия в Анализе крови на маркеры кардиальной дисфункции;\r\n";
                    }

                    if (!crf.BLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATION.ShortString.Equals(otherCrf.BLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATION.ShortString))
                    {
                        result += "Различия в Анализе крови на маркеры воспаления;\r\n";
                    }

                    foreach (var therapy in crf.AB_THERAPY)
                    {
                        if (otherCrf.AB_THERAPY.FirstOrDefault(o => o.ShortString == therapy.ShortString) == null)
                        {
                            result += "Различия в Предшествующей и сопутствующей системной антимикробной терапии;\r\n";
                        }
                    }

                    foreach (var mb in crf.MICROBIOLOGY_SPUTUM)
                    {
                        if (otherCrf.MICROBIOLOGY_SPUTUM.FirstOrDefault(o => o.ShortString == mb.ShortString) == null)
                        {
                            result += "Различия в Микробиологическое исследование мокроты;\r\n";
                        }
                    }

                    foreach (var mb in crf.MICROBIOLOGY_BLOOD)
                    {
                        if (otherCrf.MICROBIOLOGY_BLOOD.FirstOrDefault(o => o.ShortString == mb.ShortString) == null)
                        {
                            result += "Различия в Микробиологическое исследование крови;\r\n";
                        }
                    }
                    foreach (var ae in crf.ADVERSE_EVENT)
                    {
                        if (otherCrf.ADVERSE_EVENT.FirstOrDefault(o => o.ShortString == ae.ShortString) == null)
                        {
                            result += "Различия в Нежелательные явления;\r\n";
                        }
                    }

                }
                if (result.Length > 0)
                {
                    CRFCheckDoubles.Add(new CRFCheckDouble(crf, result));
                }
            }

        }
        public ICommand OpenCrfCommand { get; set; }

        public void OpenCrf()
        {
            var vm = new CrfViewModel(CurrentCrf.Model);
            var v = new CrfView { DataContext = vm };
            v.Show();
        }

        public ObservableCollection<CRFCheckDouble> CRFCheckDoubles { get; set; }
        public CRFCheckDouble CurrentCrf { get { return currentCrf; } set { currentCrf = value; OnPropertyChanged("CurrentCrf"); } }
    }
}
