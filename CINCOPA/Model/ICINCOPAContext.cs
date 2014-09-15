using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;

namespace CINCOPA.Model
{
    using System;
    using System.Data.Objects;
    using CINCOPA.Model;

    public interface ICINCOPAContext : IDisposable
    {
        ObjectSet<CRF> CRFs { get; }
        ObjectSet<USER> Users { get; }
        ObjectSet<WARD> Wards { get; }
        ObjectSet<ADVERSE_EVENT> AEs { get; }
        ObjectSet<VISIT_ONE> VisitOnes { get; }
        ObjectSet<VISIT_ONE_ONE> VisitOneOnes { get; }
        ObjectSet<VISIT_TWO> VisitTwoes { get; }
        ObjectSet<VISIT_THREE> VisitThrees { get; }
        ObjectSet<MICROBIOLOGY_BLOOD> MicrobiologyBloods { get; }
        ObjectSet<MICROBIOLOGY_SPUTUM> MicrobiologySputums { get; }
        ObjectSet<TEST_FOR_PNEUMOCOCCAL> TestForPneumococcals { get; }
        ObjectSet<ORGANISM> Organisms { get; }
        ObjectSet<AB_THERAPY> AbTherapys { get; }
        ObjectSet<ROUTE> Routes { get; }
        ObjectSet<DRUG> Drugs { get; }
        ObjectSet<BLOOD_CLINICAL_ANALYSIS> BloodClinicalAnalyses { get; }
        ObjectSet<BLOOD_TESTS_FOR_MARKERS_OF_INFLAMMATION> BloodTestsForMarkersOfInflammations { get; }
        ObjectSet<BLOOD_TESTS_FOR_MARKERS_OF_CARDIAC_DYSFUNCTION> BloodTestsForMarkersOfCardiacDysfunctions { get; }
        ObjectSet<BLOOD_CHEMISTRY> BloodChemistrys { get; }
        ObjectSet<ECHOCARDIOGRAPHY_VISIT_1> EchocardiographyVisit1Set { get; }
        ObjectSet<ECHOCARDIOGRAPHY_VISIT_3> EchocardiographyVisit3Set { get; }
        ObjectSet<EVALUATION_OF_SYMPTOMS_VISIT_1> EvaluationOfSymptomsVisit1Set { get; }
        ObjectSet<EVALUATION_OF_SYMPTOMS_VISIT_11> EvaluationOfSymptomsVisit11Set { get; }
        ObjectSet<EVALUATION_OF_SYMPTOMS_VISIT_2> EvaluationOfSymptomsVisit2Set { get; }
        ObjectSet<BASE_LIVE_INDICATORS_VISIT_1> BaseLiveIndicatorsVisit1Set { get; }
        ObjectSet<BASE_LIVE_INDICATORS_VISIT_2> BaseLiveIndicatorsVisit2Set { get; }
        ObjectSet<XRAY_CHEST_VISIT_1> XrayChestVisit1Set { get; }
        ObjectSet<COMPUTED_TOMOGRAPHY_CHEST_VISIT_1> ComputedTomographyChestVisit1Set { get; }
        ObjectSet<ANAMNESTIC_DATA_VISIT_1> AnamnesticDataVisit1Set { get; }
        ObjectSet<ELECTROCARDIOGRAPHY_VISIT_1> ElectrocardiographyVisit1Set { get; }

        void Save();

        T CreateObject<T>() where T : class;

        void RemoveObject<T>(T obj) where T : class;

        void AcceptChanges();

        void RollbackChanges();

    }
}
