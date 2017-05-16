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
        public Property Property { get; protected set; }

        public abstract string ToPersistentCriteria();//TODO: Define Regex/Query builders in each subclass
    }

    //TODO: Create Date and Boolean FilterCriteriaTypes

    public class NumericFilterCriteriaType : FilterOrderCriteria
    {
        NumericFilterCriteria criteria;
        decimal parameter;

        public NumericFilterCriteriaType(Property property, NumericFilterCriteria criteria, decimal parameter)
        {
            Property = property;
            this.criteria = criteria;
            this.parameter = parameter;
        }

        public override string ToPersistentCriteria()
        {
            //TODO: Build criteria
            throw new NotImplementedException();
        }

        public enum NumericFilterCriteria
        {
            Greater,//>
            Lesser,//<
            Equal,//=
            Different//NOT =
        }
    }

    public class TextualFilterCriteriaType : FilterOrderCriteria
    {
        TextualFilterCriteria criteria;
        string parameter;

        public TextualFilterCriteriaType(Property property, TextualFilterCriteria criteria, string parameter)
        {
            Property = property;
            this.criteria = criteria;
            this.parameter = parameter;
        }

        public override string ToPersistentCriteria()
        {
            //SELECT <...> FROM <...> WHERE <...> LIKE <...>;
            //build "like" string in switch case
            //TODO: Build criteria
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
            Property = property;
            this.criteria = criteria;
        }

        public override string ToPersistentCriteria()
        {
            //TODO: Build criteria
            throw new NotImplementedException();
        }

        public enum OrderCriteria
        {
            Ascending,
            Descending
        }
    }
}
