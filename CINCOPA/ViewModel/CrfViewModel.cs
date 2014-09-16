using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CINCOPA.Model;

namespace CINCOPA.ViewModel
{
    public class CrfViewModel: ViewModelBase
    {
        private CRF Model;

        public CrfViewModel(CRF obj)
        {
            if (obj != null)
            {
                Model = obj;
            }


        }
    }
}
