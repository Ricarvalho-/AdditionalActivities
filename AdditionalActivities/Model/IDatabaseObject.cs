using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalActivities.Model
{
    interface IDatabaseObject
    {
        IDatabaseObject Create();

        IDatabaseObject Fetch();

        void Save();

        void Delete();
    }
}
