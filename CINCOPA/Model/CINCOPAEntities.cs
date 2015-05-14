using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;

using System.Linq;
using System.Text;

namespace CINCOPA.Model
{
    public partial class CINCOPAEntities : ObjectContext, ICINCOPAContext
    {
        public void Save()
        {
            this.SaveChanges();
        }
        public void RemoveObject<T>(T obj) where T : class
        {
            RemoveObject<T>(obj);
        }

        public void AcceptChanges()
        {
            AcceptAllChanges();
        }

        public void RollbackChanges()
        {
            RollbackChanges();
        }

    }
}
