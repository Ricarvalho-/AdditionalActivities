using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdditionalActivities.Model.Persistent;

namespace AdditionalActivities.Model
{
    public abstract class FilterOrderCriteria
    {
        Property property;

        public Property Property
        {
            get
            {
                return property;
            }

            protected set
            {
                property = value;
            }
        }

        public abstract string ToPersistentCriteria();
    }

    public class NumericFilterCriteriaType : FilterOrderCriteria
    {
        NumericFilterCriteria criteria;
        decimal parameter;

        public NumericFilterCriteriaType(Property property, NumericFilterCriteria criteria, decimal parameter)
        {
            this.Property = property;
            this.criteria = criteria;
            this.parameter = parameter;
        }

        public override string ToPersistentCriteria()
        {
            throw new NotImplementedException();
        }

        public enum NumericFilterCriteria
        {
            Greater,
            Lesser,
            Equal,
            Different
        }
    }

    public class TextualFilterCriteriaType : FilterOrderCriteria
    {
        TextualFilterCriteria criteria;
        string parameter;

        public TextualFilterCriteriaType(Property property, TextualFilterCriteria criteria, string parameter)
        {
            this.Property = property;
            this.criteria = criteria;
            this.parameter = parameter;
        }

        public override string ToPersistentCriteria()
        {
            //SELECT <...> FROM <...> WHERE <...> LIKE <...>;
            //build "like" string in switch case
            throw new NotImplementedException();
        }

        public enum TextualFilterCriteria
        {
            Start,//LIKE(<...>%)
            End,//LIKE(%<...>)
            Contain,//LIKE(%<...>%)
            Equal,//LIKE(<...>)
            NotStart,//NOT LIKE(<...>%)
            NotEnd,//NOT LIKE(%<...>)
            NotContain,//NOT LIKE(%<...>%)
            NotEqual//NOT LIKE(<...>)
        }
}

    public class OrderCriteriaType : FilterOrderCriteria
    {
        OrderCriteria criteria;

        public OrderCriteriaType(Property property, OrderCriteria criteria)
        {
            this.Property = property;
            this.criteria = criteria;
        }

        public override string ToPersistentCriteria()
        {
            throw new NotImplementedException();
        }

        public enum OrderCriteria
        {
            Ascending,
            Descending
        }
    }
}
