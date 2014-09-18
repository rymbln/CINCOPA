using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CINCOPA.Common;
using CINCOPA.Model;

namespace CINCOPA.ViewModel
{
   public class AEViewModel: ViewModelBase
   {
       public ADVERSE_EVENT Model;
       public AEViewModel(ADVERSE_EVENT obj)
       {
           if (obj != null)
           {
               Model = obj;
           }
       }

       public string AE_NAME
       {
           get { return Model.NAME; }
           set
           {
               Model.NAME = value;
               OnPropertyChanged("NAME");
           }
       }

       public DateTime? AE_DATE_START
       {
           get { return Model.DATE_START; }
           set
           {
               Model.DATE_START = value;
               OnPropertyChanged("DATE_START");
           }
       }

       public DateTime? AE_DATE_END
       {
           get { return Model.DATE_END; }
           set
           {
               Model.DATE_END = value;
               OnPropertyChanged("DATE_END");
           }
       }

       public string AE_HEAVY
       {
           get { return Model.HEAVY; }
           set
           {
               Model.HEAVY = value;
               OnPropertyChanged("HEAVY");
           }
       }

       public string AE_RESULT
       {
           get { return Model.RESULT; }
           set
           {
               Model.RESULT = value;
               OnPropertyChanged("RESULT");
           }
       }

       public string AE_RELATION
       {
           get { return Model.RELATION; }
           set
           {
               Model.RELATION = value;
               OnPropertyChanged("RELATION");
           }
       }

       public string AE_ACTIONS
       {
           get { return Model.ACTIONS; }
           set
           {
               Model.ACTIONS = value;
               OnPropertyChanged("ACTIONS");
           }
       }

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
    }
}
