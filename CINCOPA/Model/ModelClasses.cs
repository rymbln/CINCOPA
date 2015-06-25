using CINCOPA.Common;
using System;
using System.Collections.Generic;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Text;

namespace CINCOPA.Model
{

    public partial class CRF : EntityObject
    {
        public string WARD_NAME
        {
            get { return WARD == null ? "---" : WARD.NAME; }
        }

        public string ShortString
        {
            get
            {
                return DataManager.Instance.NullToString(WARD.NAME)
                    + DataManager.Instance.NullToString(NAME)
                    + DataManager.Instance.NullToString(NUMBER )
                    + DataManager.Instance.NullToString(DATE_BIRTH )
                    + DataManager.Instance.NullToString(DATE_HOSPITALISATION )
                    + DataManager.Instance.NullToString(DATE_DISCHARGE )
                    + DataManager.Instance.NullToString(AE_LOGIC);
            }
        }
    }

    public partial class VISIT_ONE : EntityObject
    {
        public string ShortString
        {
            get { return DataManager.Instance.NullToString(DATE_VISIT); }
        }
    }

    public partial class BASE_LIVE_INDICATORS_VISIT_1 : EntityObject
    {
        public string ShortString

        {
            get
            {
                return DataManager.Instance.NullToString(BLOOD_PRESSURE_LEFT_HAND)
                       + DataManager.Instance.NullToString(BLOOD_PRESSURE_RIGHT_HAND)
                       + DataManager.Instance.NullToString(HEART_RATE)
                       + DataManager.Instance.NullToString(RESPIRATORY_RATE)
                       + DataManager.Instance.NullToString(TEMPERATURE)
                       + DataManager.Instance.NullToString(HEAVY_TYPE)
                       + DataManager.Instance.NullToString(OXYGEN_THERAPY_NEEDED)
                       + DataManager.Instance.NullToString(DECOMPENSATION_SIGNS);
            }
        }
    }

    public partial class ANAMNESTIC_DATA_VISIT_1 : EntityObject
    {
        public string ShortString
        {
            get
            {
                return DataManager.Instance.NullToString(DATE_SYMPTOM) 
                    + DataManager.Instance.NullToString(DATE_DIAGNOSIS)
                       + DataManager.Instance.NullToString(NUMBER_EPISODES)
                       + DataManager.Instance.NullToString(NUMBER_EPISODES_NODATA)
                       + DataManager.Instance.NullToString(FUNCTION_CLASS)
                       + DataManager.Instance.NullToString(OTHER_EPISODES)
                       + DataManager.Instance.NullToString(SMOKE_STATUS)
                       + DataManager.Instance.NullToString(SMOKE_AVERAGE)
                       + DataManager.Instance.NullToString(SMOKE_YEARS)
                       + DataManager.Instance.NullToString(SMOKE_PACK_YEARS);


            }
        }
    }

    public partial class EVALUATION_OF_SYMPTOMS_VISIT_1 : EntityObject
    {
        public string ShortString
        {
            get
            {
                return DataManager.Instance.NullToString(DYSPNEA)
                    + DataManager.Instance.NullToString(COUGH )
                    + DataManager.Instance.NullToString(SPUTUM )
                    + DataManager.Instance.NullToString(SPUTUM_TYPE )
                    + DataManager.Instance.NullToString(TEMPERATURE_INCREASE )
                    + DataManager.Instance.NullToString(COLD_SYMPTOM )
                    + DataManager.Instance.NullToString(SHORTERING_OF_PERCUSSION_SOUNDS )
                    + DataManager.Instance.NullToString(MOIST_RALES_SOUNDS )
                    +DataManager.Instance.NullToString( CREPITUS )
                    + DataManager.Instance.NullToString(PLEURAL_FRICTION_NOISE)
                    + DataManager.Instance.NullToString(DRY_RALES )
                    + DataManager.Instance.NullToString(PRESENCE_OF_EDEMA )
                    + DataManager.Instance.NullToString(INCIDENCE_OF_EDEMA);
            }
        }
    }

    public partial class ELECTROCARDIOGRAPHY_VISIT_1 : EntityObject
    {
        public string ShortString
        {
            get
            {
                return DataManager.Instance.NullToString(DATE_PROCEDURE)
                    + DataManager.Instance.NullToString(SINUS_RHYTHM )
                    + DataManager.Instance.NullToString(ATRIAL_FIBRILLATION )
                    + DataManager.Instance.NullToString(ARRYTHMIA_SUPRAVENTRICULAR )
                    +
                       DataManager.Instance.NullToString(ARRYTHMIA_VENTRICULAR_PREMATURE_BEATS )
                       + DataManager.Instance.NullToString(HEART_RATE )
                       + DataManager.Instance.NullToString(SIGNIFICANT_CHANGES);
            }
        }
    }

    public partial class ECHOCARDIOGRAPHY_VISIT_1 : EntityObject
    {
        public string ShortString
        {
            get
            {
                return DataManager.Instance.NullToString(DATE_PROCEDURE)
                    + DataManager.Instance.NullToString(FV_PERCENT )
                    + DataManager.Instance.NullToString(EA_LJ )
                    + DataManager.Instance.NullToString(EA_RJ )
                    + DataManager.Instance.NullToString(SDLA )
                    + DataManager.Instance.NullToString(AMOUNT_OF_PERICARDIAL_EFFUSION )
                    +
                       DataManager.Instance.NullToString(COMMENTS);
            }
        }
    }

    public partial class XRAY_CHEST_VISIT_1 : EntityObject
    {
        public string ShortString
        {
            get
            {
                return DataManager.Instance.NullToString(DATE_PROCEDURE) 
                    + DataManager.Instance.NullToString(PNEUMONIA_SIGNS )
                    + DataManager.Instance.NullToString(ALVEOLAR_INFILTRATION_LEFT_BOTTOM )
                    +
                       DataManager.Instance.NullToString(ALVEOLAR_INFILTRATION_LEFT_TOP )
                       + DataManager.Instance.NullToString(ALVEOLAR_INFILTRATION_RIGHT_BOTTOM )
                       +
                       DataManager.Instance.NullToString(ALVEOLAR_INFILTRATION_RIGHT_MIDDLE )
                       + DataManager.Instance.NullToString(ALVEOLAR_INFILTRATION_RIGHT_TOP) +
                       DataManager.Instance.NullToString(INTERSTITIAL_INFILTRATION_LEFT_BOTTOM )
                       + DataManager.Instance.NullToString(INTERSTITIAL_INFILTRATION_LEFT_TOP) +
                       DataManager.Instance.NullToString(INTERSTITIAL_INFILTRATION_RIGHT_BOTTOM )
                       + DataManager.Instance.NullToString(INTERSTITIAL_INFILTRATION_RIGHT_MIDDLE )+
                       DataManager.Instance.NullToString(INTERSTITIAL_INFILTRATION_RIGHT_TOP )
                       + DataManager.Instance.NullToString(PLEURAL_EFFUSION_DOUBLE )
                       +DataManager.Instance.NullToString( PLEURAL_EFFUSION_LEFT )
                       +
                       DataManager.Instance.NullToString(PLEURAL_EFFUSION_NONE )
                       + DataManager.Instance.NullToString(PLEURAL_EFFUSION_RIGHT)
                       + DataManager.Instance.NullToString(OTHER);
            }
        }
    }

    public partial class COMPUTED_TOMOGRAPHY_CHEST_VISIT_1
    {
        public string ShortString
        {
            get
            {
                return DataManager.Instance.NullToString(DATE_PROCEDURE)
                    + DataManager.Instance.NullToString(PNEUMONIA_SIGNS )
                    + DataManager.Instance.NullToString(ALVEOLAR_INFILTRATION_LEFT_BOTTOM)
                    +
                       DataManager.Instance.NullToString(ALVEOLAR_INFILTRATION_LEFT_TOP) 
                       + DataManager.Instance.NullToString(ALVEOLAR_INFILTRATION_RIGHT_BOTTOM) +
                       DataManager.Instance.NullToString(ALVEOLAR_INFILTRATION_RIGHT_MIDDLE )
                       + DataManager.Instance.NullToString(ALVEOLAR_INFILTRATION_RIGHT_TOP) +
                       DataManager.Instance.NullToString(INTERSTITIAL_INFILTRATION_LEFT_BOTTOM )
                       + DataManager.Instance.NullToString(INTERSTITIAL_INFILTRATION_LEFT_TOP )+
                       DataManager.Instance.NullToString(INTERSTITIAL_INFILTRATION_RIGHT_BOTTOM )
                       +DataManager.Instance.NullToString( INTERSTITIAL_INFILTRATION_RIGHT_MIDDLE )
                       +
                      DataManager.Instance.NullToString( INTERSTITIAL_INFILTRATION_RIGHT_TOP )
                       + DataManager.Instance.NullToString(PLEURAL_EFFUSION_DOUBLE )
                       + DataManager.Instance.NullToString(PLEURAL_EFFUSION_LEFT) +
                      DataManager.Instance.NullToString( PLEURAL_EFFUSION_NONE)
                       +DataManager.Instance.NullToString( PLEURAL_EFFUSION_RIGHT )
                       + DataManager.Instance.NullToString(OTHER);
            }
        }
    }

    public partial class VISIT_ONE_ONE : EntityObject
    {
        public string ShortString
        {
            get { return DataManager.Instance.NullToString(DATE_VISIT); }
        }
    }

    public partial class EVALUATION_OF_SYMPTOMS_VISIT_11
    {
        public string ShortString
        {
            get
            {
                return DataManager.Instance.NullToString(DYSPNEA)
                    + DataManager.Instance.NullToString(COUGH )
                    + DataManager.Instance.NullToString(SPUTUM )
                    + DataManager.Instance.NullToString(SPUTUM_TYPE )
                    + DataManager.Instance.NullToString(TEMPERATURE_INCREASE)
                    + DataManager.Instance.NullToString(COLD_SYMPTOM )
                    +
                      DataManager.Instance.NullToString( SHORTERING_OF_PERCUSSION_SOUNDS )
                       +DataManager.Instance.NullToString( MOIST_RALES_SOUNDS )
                       + DataManager.Instance.NullToString(CREPITUS )
                       + DataManager.Instance.NullToString(PLEURAL_FRICTION_NOISE )+
                       DataManager.Instance.NullToString(DRY_RALES )
                       + DataManager.Instance.NullToString(PRESENCE_OF_EDEMA)
                       + DataManager.Instance.NullToString(INCIDENCE_OF_EDEMA )
                       + DataManager.Instance.NullToString(THERAPY_EFFICIENCY);
            }
        }
    }

    public partial class VISIT_TWO : EntityObject
    {
        public string ShortString
        {
            get { return DataManager.Instance.NullToString(DATE_VISIT); }
        }
    }

    public partial class VISIT_THREE : EntityObject
    {
        public string ShortString
        {
            get { return DataManager.Instance.NullToString(DATE_VISIT); }
        }
    }

    public partial class BASE_LIVE_INDICATORS_VISIT_2
    {
        public string ShortString
        {
            get
            {
                return DataManager.Instance.NullToString(BLOOD_PRESSURE_LEFT_HAND)
                       + DataManager.Instance.NullToString(BLOOD_PRESSURE_RIGHT_HAND)
                       + DataManager.Instance.NullToString(HEART_RATE)
                       + DataManager.Instance.NullToString(RESPIRATORY_RATE)
                       + DataManager.Instance.NullToString(TEMPERATURE);
            }
        }
    }

    public partial class EVALUATION_OF_SYMPTOMS_VISIT_2
    {
        public string ShortString
        {
            get
            {
                return DataManager.Instance.NullToString( DYSPNEA )
                    + DataManager.Instance.NullToString(COUGH )
                    + DataManager.Instance.NullToString(SPUTUM )
                    + DataManager.Instance.NullToString(SPUTUM_TYPE )
                    + DataManager.Instance.NullToString(TEMPERATURE_INCREASE )
                    +DataManager.Instance.NullToString(COLD_SYMPTOM )
                    +
                       DataManager.Instance.NullToString(SHORTERING_OF_PERCUSSION_SOUNDS )
                       +DataManager.Instance.NullToString( MOIST_RALES_SOUNDS )
                       + DataManager.Instance.NullToString(CREPITUS )
                       
                       +DataManager.Instance.NullToString( PLEURAL_FRICTION_NOISE )+
                       DataManager.Instance.NullToString(DRY_RALES )
                       + DataManager.Instance.NullToString(PRESENCE_OF_EDEMA )
                       + DataManager.Instance.NullToString(INCIDENCE_OF_EDEMA )
                       + DataManager.Instance.NullToString(THERAPY_EFFICIENCY);
            }
        }
    }

    public partial class ECHOCARDIOGRAPHY_VISIT_3
    {
        public string ShortString
        {
            get
            {
                return DataManager.Instance.NullToString(DATE_PROCEDURE)
                    + DataManager.Instance.NullToString(FV_PERCENT )
                    + 
                    DataManager.Instance.NullToString(EA_RJ )
                    +DataManager.Instance.NullToString( SDLA )
                    + DataManager.Instance.NullToString(AMOUNT_OF_PERICARDIAL_EFFUSION )
                    +
                      DataManager.Instance.NullToString( COMMENTS);
            }
        }
    }

    public partial class ADVERSE_EVENT
    {
        public string ShortString
        {
            get { return DataManager.Instance.NullToString(NAME )
                + DataManager.Instance.NullToString(DATE_START )
                + DataManager.Instance.NullToString(DATE_END )
                + DataManager.Instance.NullToString(HEAVY )
                + DataManager.Instance.NullToString(RESULT)
                + DataManager.Instance.NullToString(RELATION)
                + DataManager.Instance.NullToString(ACTIONS);
            }
        }
    }

    public partial class BLOOD_CLINICAL_ANALYSIS
    {
        public string ShortString
        {
            get
            {
                return DataManager.Instance.NullToString(VISIT_ONE_SIGNIFICANT_CHANGES )
                    + DataManager.Instance.NullToString(VISIT_ONE_LEUKOCYTOSIS )
                    + DataManager.Instance.NullToString(VISIT_ONE_LEUKOCYTOSIS_YOUNG_FORMS)
                    +
                       DataManager.Instance.NullToString(VISIT_ONE_OTHERS )
                       +DataManager.Instance.NullToString( VISIT_TWO_SIGNIFICANT_CHANGES )
                       +DataManager.Instance.NullToString( VISIT_TWO_LEUKOCYTOSIS )+
                       DataManager.Instance.NullToString(VISIT_TWO_LEUKOCYTOSIS_YOUNG_FORMS)
                       + DataManager.Instance.NullToString(VISIT_TWO_OTHERS);
            }
        }
    }

    public partial class BLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATION
    {
        public string ShortString
        {
            get
            {
                return DataManager.Instance.NullToString( VISIT_ONE_C_REACTIVE_PROTEIN )
                    + DataManager.Instance.NullToString(VISIT_ONE_PROCALCITONIN )
                    + DataManager.Instance.NullToString(VISIT_ONE_IL6 )
                    + DataManager.Instance.NullToString(VISIT_ONE_FNO )+
                       DataManager.Instance.NullToString(VISIT_TWO_C_REACTIVE_PROTEIN )
                       + DataManager.Instance.NullToString(VISIT_TWO_PROCALCITONIN )
                       + DataManager.Instance.NullToString(VISIT_TWO_FNO )
                       + DataManager.Instance.NullToString(VISIT_THREE_IL6) +
                       DataManager.Instance.NullToString(VISIT_THREE_C_REACTIVE_PROTEIN )
                       + DataManager.Instance.NullToString(VISIT_THREE_PROCALCITONIN)
                       + DataManager.Instance.NullToString(VISIT_THREE_IL6 )
                       + DataManager.Instance.NullToString(VISIT_THREE_FNO);
            }
        }
    }

    public partial class BLOOD_TESTS_FOR_MARKERS_OF_CARDIAC_DYSFUNCTION
    {
        public string ShortString
        {
            get
            {
                return DataManager.Instance.NullToString(VISIT_ONE_BRAIN_NATRIURETIC_PEPTIDE)
                    + DataManager.Instance.NullToString(VISIT_ONE_KOPEPTIN )
                    + DataManager.Instance.NullToString(VISIT_ONE_PROADRENOMEDULLIN) +
                       DataManager.Instance.NullToString(VISIT_TWO_BRAIN_NATRIURETIC_PEPTIDE )
                       +DataManager.Instance.NullToString( VISIT_TWO_KOPEPTIN )
                       
                       + DataManager.Instance.NullToString(VISIT_TWO_PROADRENOMEDULLIN )+
                       DataManager.Instance.NullToString(VISIT_THREE_BRAIN_NATRIURETIC_PEPTIDE )
                       + DataManager.Instance.NullToString(VISIT_THREE_KOPEPTIN )
                       + DataManager.Instance.NullToString(VISIT_THREE_PROADRENOMEDULLIN);
            }
        }
    }

    public partial class BLOOD_CHEMISTRY
    {
        public string ShortString
        {
            get
            {
                return DataManager.Instance.NullToString(VISIT_ONE_SIGNIFICANT_CHANGES )
                    + DataManager.Instance.NullToString(VISIT_ONE_CHANGES )
                    +DataManager.Instance.NullToString( VISIT_TWO_SIGNIFICANT_CHANGES )
                    +
                       DataManager.Instance.NullToString(VISIT_TWO_CHANGES);
            }
        }
    }


    public partial class AB_THERAPY
    {
        public string ShortString
        {
            get
            {
                return DataManager.Instance.NullToString(DRUG.NAME)
                + DataManager.Instance.NullToString(ROUTE.NAME )
                + DataManager.Instance.NullToString(SINGLE_DOSE) 
                + DataManager.Instance.NullToString(FREQUENCY )
                + DataManager.Instance.NullToString(DATE_START)
                + DataManager.Instance.NullToString(DATE_END); }
        }
    }

    public partial class TEST_FOR_PNEUMOCOCCAL
    {
        public string ShortString
        {
            get { return DataManager.Instance.NullToString(LOGIC) + DataManager.Instance.NullToString(RESULT); }
        }
    }

    public partial class MICROBIOLOGY_SPUTUM
    {
        public string ShortString
        {
            get
            {
                return DataManager.Instance.NullToString(DATE_CAPTURE)
                    + DataManager.Instance.NullToString(LAB_NUMBER )
                    + DataManager.Instance.NullToString(QUALITY_LEUKOCYTES )
                    + DataManager.Instance.NullToString(QUALITY_EPITHELIAL )
                    + DataManager.Instance.NullToString(NOT_REPRESENTATIVE )+
                       DataManager.Instance.NullToString(GROWTH_PATHOGENS )
                       +DataManager.Instance.NullToString( ORGANISM != null ? ORGANISM.NAME : null )
                       + DataManager.Instance.NullToString(BETA )
                       + DataManager.Instance.NullToString(MRSA);
            }
        }
    }

    public partial class MICROBIOLOGY_BLOOD
    {
        public string ShortString
        {
            get
            {
                return DataManager.Instance.NullToString(DATE_CAPTURE)
                    + DataManager.Instance.NullToString(LAB_NUMBER) + 
                       DataManager.Instance.NullToString(GROWTH_PATHOGENS)
                       + DataManager.Instance.NullToString(ORGANISM != null ? ORGANISM.NAME : null)
                       + DataManager.Instance.NullToString(BETA )
                       + DataManager.Instance.NullToString(MRSA);
            }
        }
    }
}
