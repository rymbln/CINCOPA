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
                return NullToString(WARD.NAME + NullToString(NAME + NullToString(NUMBER + NullToString(DATE_BIRTH + NullToString(DATE_HOSPITALISATION +
                       NullToString(DATE_DISCHARGE + NullToString(AE_LOGIC;
            }
        }
    }

    public partial class VISIT_ONE : EntityObject
    {
        public string? ShortString
        {
            get { return NullToString(DATE_VISIT); }
        }
    }

    public partial class BASE_LIVE_INDICATORS_VISIT_1 : EntityObject
    {
        public string ShortString

        {
            get
            {
                return BLOOD_PRESSURE_LEFT_HAND
                       + BLOOD_PRESSURE_RIGHT_HAND
                       + HEART_RATE
                       + RESPIRATORY_RATE
                       + TEMPERATURE
                       + HEAVY_TYPE
                       + OXYGEN_THERAPY_NEEDED
                       + DECOMPENSATION_SIGNS;
            }
        }
    }

    public partial class ANAMNESTIC_DATA_VISIT_1 : EntityObject
    {
        public string ShortString
        {
            get
            {
                return DATE_SYMPTOM) + NullToString( + DATE_DIAGNOSIS) + NullToString(
                       + NUMBER_EPISODES
                       + NUMBER_EPISODES_NODATA
                       + FUNCTION_CLASS
                       + OTHER_EPISODES
                       + SMOKE_STATUS
                       + SMOKE_AVERAGE
                       + SMOKE_YEARS
                       + SMOKE_PACK_YEARS;


            }
        }
    }

    public partial class EVALUATION_OF_SYMPTOMS_VISIT_1 : EntityObject
    {
        public string ShortString
        {
            get
            {
                return DYSPNEA + COUGH + SPUTUM + SPUTUM_TYPE + TEMPERATURE_INCREASE + COLD_SYMPTOM +
                       SHORTERING_OF_PERCUSSION_SOUNDS + MOIST_RALES_SOUNDS + CREPITUS + PLEURAL_FRICTION_NOISE +
                       DRY_RALES + PRESENCE_OF_EDEMA + INCIDENCE_OF_EDEMA;
            }
        }
    }

    public partial class ELECTROCARDIOGRAPHY_VISIT_1 : EntityObject
    {
        public string ShortString
        {
            get
            {
                return DATE_PROCEDURE) + NullToString( + SINUS_RHYTHM + ATRIAL_FIBRILLATION + ARRYTHMIA_SUPRAVENTRICULAR +
                       ARRYTHMIA_VENTRICULAR_PREMATURE_BEATS + HEART_RATE + SIGNIFICANT_CHANGES;
            }
        }
    }

    public partial class ECHOCARDIOGRAPHY_VISIT_1 : EntityObject
    {
        public string ShortString
        {
            get
            {
                return DATE_PROCEDURE) + NullToString( + FV_PERCENT + EA_LJ + EA_RJ + SDLA + AMOUNT_OF_PERICARDIAL_EFFUSION +
                       COMMENTS;
            }
        }
    }

    public partial class XRAY_CHEST_VISIT_1 : EntityObject
    {
        public string ShortString
        {
            get
            {
                return DATE_PROCEDURE) + NullToString( + PNEUMONIA_SIGNS + ALVEOLAR_INFILTRATION_LEFT_BOTTOM +
                       ALVEOLAR_INFILTRATION_LEFT_TOP + ALVEOLAR_INFILTRATION_RIGHT_BOTTOM +
                       ALVEOLAR_INFILTRATION_RIGHT_MIDDLE + ALVEOLAR_INFILTRATION_RIGHT_TOP +
                       INTERSTITIAL_INFILTRATION_LEFT_BOTTOM + INTERSTITIAL_INFILTRATION_LEFT_TOP +
                       INTERSTITIAL_INFILTRATION_RIGHT_BOTTOM + INTERSTITIAL_INFILTRATION_RIGHT_MIDDLE +
                       INTERSTITIAL_INFILTRATION_RIGHT_TOP + PLEURAL_EFFUSION_DOUBLE + PLEURAL_EFFUSION_LEFT +
                       PLEURAL_EFFUSION_NONE + PLEURAL_EFFUSION_RIGHT + OTHER;
            }
        }
    }

    public partial class COMPUTED_TOMOGRAPHY_CHEST_VISIT_1
    {
        public string ShortString
        {
            get
            {
                return DATE_PROCEDURE) + NullToString( + PNEUMONIA_SIGNS + ALVEOLAR_INFILTRATION_LEFT_BOTTOM +
                       ALVEOLAR_INFILTRATION_LEFT_TOP + ALVEOLAR_INFILTRATION_RIGHT_BOTTOM +
                       ALVEOLAR_INFILTRATION_RIGHT_MIDDLE + ALVEOLAR_INFILTRATION_RIGHT_TOP +
                       INTERSTITIAL_INFILTRATION_LEFT_BOTTOM + INTERSTITIAL_INFILTRATION_LEFT_TOP +
                       INTERSTITIAL_INFILTRATION_RIGHT_BOTTOM + INTERSTITIAL_INFILTRATION_RIGHT_MIDDLE +
                       INTERSTITIAL_INFILTRATION_RIGHT_TOP + PLEURAL_EFFUSION_DOUBLE + PLEURAL_EFFUSION_LEFT +
                       PLEURAL_EFFUSION_NONE + PLEURAL_EFFUSION_RIGHT + OTHER;
            }
        }
    }

    public partial class VISIT_ONE_ONE : EntityObject
    {
        public string ShortString
        {
            get { return DATE_VISIT) + NullToString(; }
        }
    }

    public partial class EVALUATION_OF_SYMPTOMS_VISIT_11
    {
        public string ShortString
        {
            get
            {
                return DYSPNEA + COUGH + SPUTUM + SPUTUM_TYPE + TEMPERATURE_INCREASE + COLD_SYMPTOM +
                       SHORTERING_OF_PERCUSSION_SOUNDS + MOIST_RALES_SOUNDS + CREPITUS + PLEURAL_FRICTION_NOISE +
                       DRY_RALES + PRESENCE_OF_EDEMA + INCIDENCE_OF_EDEMA + THERAPY_EFFICIENCY;
            }
        }
    }

    public partial class VISIT_TWO : EntityObject
    {
        public string ShortString
        {
            get { return DATE_VISIT) + NullToString(; }
        }
    }

    public partial class VISIT_THREE : EntityObject
    {
        public string ShortString
        {
            get { return DATE_VISIT) + NullToString(; }
        }
    }

    public partial class BASE_LIVE_INDICATORS_VISIT_2
    {
        public string ShortString
        {
            get
            {`
                return BLOOD_PRESSURE_LEFT_HAND) + NullToString(
                       + BLOOD_PRESSURE_RIGHT_HAND) + NullToString(
                       + HEART_RATE) + NullToString(
                       + RESPIRATORY_RATE) + NullToString(
                       + TEMPERATURE) + NullToString(;
            }
        }
    }

    public partial class EVALUATION_OF_SYMPTOMS_VISIT_2
    {
        public string ShortString
        {
            get
            {
                return DYSPNEA + COUGH + SPUTUM + SPUTUM_TYPE + TEMPERATURE_INCREASE + COLD_SYMPTOM +
                       SHORTERING_OF_PERCUSSION_SOUNDS + MOIST_RALES_SOUNDS + CREPITUS + PLEURAL_FRICTION_NOISE +
                       DRY_RALES + PRESENCE_OF_EDEMA + INCIDENCE_OF_EDEMA + THERAPY_EFFICIENCY;
            }
        }
    }

    public partial class ECHOCARDIOGRAPHY_VISIT_3
    {
        public string ShortString
        {
            get
            {
                return DATE_PROCEDURE) + NullToString( + FV_PERCENT + EA_LJ + EA_RJ + SDLA + AMOUNT_OF_PERICARDIAL_EFFUSION +
                       COMMENTS;
            }
        }
    }

    public partial class ADVERSE_EVENT
    {
        public string ShortString
        {
            get { return NAME + DATE_START + DATE_END + HEAVY + RESULT + RELATION + ACTIONS; }
        }
    }

    public partial class BLOOD_CLINICAL_ANALYSIS
    {
        public string ShortString
        {
            get
            {
                return VISIT_ONE_SIGNIFICANT_CHANGES + VISIT_ONE_LEUKOCYTOSIS + VISIT_ONE_LEUKOCYTOSIS_YOUNG_FORMS +
                       VISIT_ONE_OTHERS + VISIT_TWO_SIGNIFICANT_CHANGES + VISIT_TWO_LEUKOCYTOSIS +
                       VISIT_TWO_LEUKOCYTOSIS_YOUNG_FORMS + VISIT_TWO_OTHERS;
            }
        }
    }

    public partial class BLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATION
    {
        public string ShortString
        {
            get
            {
                return VISIT_ONE_C_REACTIVE_PROTEIN + VISIT_ONE_PROCALCITONIN + VISIT_ONE_IL6 + VISIT_ONE_FNO +
                       VISIT_TWO_C_REACTIVE_PROTEIN + VISIT_TWO_PROCALCITONIN + VISIT_TWO_FNO + VISIT_THREE_IL6 +
                       VISIT_THREE_C_REACTIVE_PROTEIN + VISIT_THREE_PROCALCITONIN + VISIT_THREE_IL6 + VISIT_THREE_FNO;
            }
        }
    }

    public partial class BLOOD_TESTS_FOR_MARKERS_OF_CARDIAC_DYSFUNCTION
    {
        public string ShortString
        {
            get
            {
                return VISIT_ONE_BRAIN_NATRIURETIC_PEPTIDE + VISIT_ONE_KOPEPTIN + VISIT_ONE_PROADRENOMEDULLIN +
                       VISIT_TWO_BRAIN_NATRIURETIC_PEPTIDE + VISIT_TWO_KOPEPTIN + VISIT_TWO_PROADRENOMEDULLIN +
                       VISIT_THREE_BRAIN_NATRIURETIC_PEPTIDE + VISIT_THREE_KOPEPTIN + VISIT_THREE_PROADRENOMEDULLIN;
            }
        }
    }

    public partial class BLOOD_CHEMISTRY
    {
        public string ShortString
        {
            get
            {
                return VISIT_ONE_SIGNIFICANT_CHANGES + VISIT_ONE_CHANGES + VISIT_TWO_SIGNIFICANT_CHANGES +
                       VISIT_TWO_CHANGES;
            }
        }
    }


    public partial class AB_THERAPY
    {
        public string ShortString
        {
            get { return DRUG.NAME + ROUTE.NAME + SINGLE_DOSE + FREQUENCY + DATE_START + DATE_END; }
        }
    }

    public partial class TEST_FOR_PNEUMOCOCCAL
    {
        public string ShortString
        {
            get { return LOGIC + RESULT; }
        }
    }

    public partial class MICROBIOLOGY_SPUTUM
    {
        public string ShortString
        {
            get
            {
                return DATE_CAPTURE) + NullToString( + LAB_NUMBER) + NullToString( + QUALITY_LEUKOCYTES) + NullToString( + QUALITY_EPITHELIAL) + NullToString( 
                    + NOT_REPRESENTATIVE!=null ? NOT_REPRESENTATIVE) + NullToString( : "---" 
                    +GROWTH_PATHOGENS != null ? GROWTH_PATHOGENS) + NullToString( : "---" 
                     + ORGANISM.NAME) + NullToString(
                    + BETA != null ? BETA) + NullToString( : "---"

                    + MRSA != null ? MRSA) + NullToString( : "---" 
                       ;
            }
        }
    }

    public partial class MICROBIOLOGY_BLOOD
    {
        public string ShortString
        {
            get
            {
                return DATE_CAPTURE) + NullToString( + LAB_NUMBER) + NullToString( 
                    + GROWTH_PATHOGENS != null ? GROWTH_PATHOGENS) + NullToString( : "---"
                     + ORGANISM.NAME) + NullToString(
                    + BETA != null ? BETA) + NullToString( : "---"

                    + MRSA != null ? MRSA) + NullToString( : "---"
                       ;
            }
        }
    }
}
