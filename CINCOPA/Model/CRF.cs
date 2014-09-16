using System;
using System.Collections.Generic;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Text;

namespace CINCOPA.Model
{
    public partial class CRF: EntityObject
    {
        public string WARD_NAME 
        {
            get {
                return WARD == null ? "---" : WARD.NAME;
            }
        }
    }
}
