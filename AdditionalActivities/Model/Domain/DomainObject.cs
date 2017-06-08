using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalActivities.Model.Domain
{
    public abstract class DomainObject
    {
        public DomainObject Copy()
        {
            return (DomainObject)MemberwiseClone();
        }
    }
}
