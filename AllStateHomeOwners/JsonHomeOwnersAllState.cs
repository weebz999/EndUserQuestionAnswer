using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace AllStateHomeOwners
{
    class JsonHomeOwnersAllState
    {
        public class Name
        {
            public string FirstName { get; set; }
            public string MiddleName { get; set; }
            public string LastName { get; set; }
            public object Title { get; set; }
        }

        public class NamedInsured
        {
            public IList<Name> Name { get; set; }
        }

        public class MailingAddress
        {
            public string AddressLine1 { get; set; }
            public object AddressLine2 { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string ZipCode { get; set; }
            public string FullAddress { get; set; }
        }

        public class Period
        {
            public string From { get; set; }
            public string To { get; set; }
        }

        public class PolicyPeriod
        {
            public Period Period { get; set; }
        }

        public class Premiumperiod
        {
            public Period period1 { get; set; }
    }

    public class Discount
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class LocationOfPropertyInsured
    {
        public string AddressLine1 { get; set; }
        public object AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string FullAddress { get; set; }
    }

    public class PolicyEffectiveDate
    {
        public Period policyEffectiveDate { get; set; }
}

public class InsuredPropertyDetail
{
    public string Name { get; set; }
    public string Value { get; set; }
}

public class CoverageDetail
{
    public string Coverage { get; set; }
    public string LimitsOfLiability { get; set; }
    public string ApplicableDeductibles { get; set; }
}

public class Form
{
    public string Form1 { get; set; }
    public string Form2 { get; set; }
}

public class AgencyAddress
{
    public string AddressLine1 { get; set; }
    public object AddressLine2 { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    public string FullAddress { get; set; }
}

public class AgencyData
{
    public string text { get; set; }
        public string Agency_Name { get; set; }
    public AgencyAddress Agency_Address { get; set; }
    public string Agency_Email { get; set; }
    public string Agency_Contact { get; set; }
}

public class HomeOwners
{
    public string CompanyName { get; set; }
    public string FormName { get; set; }
    public NamedInsured NamedInsured { get; set; }
    public MailingAddress MailingAddress { get; set; }
    public string PolicyNumber { get; set; }
    public string ProviderEntityName { get; set; }
    public PolicyPeriod PolicyPeriod { get; set; }
    public string TotalPremium { get; set; }
    public Premiumperiod Premiumperiod { get; set; }
    public IList<Discount> Discounts { get; set; }
    public LocationOfPropertyInsured LocationOfPropertyInsured { get; set; }
    public PolicyEffectiveDate PolicyEffectiveDate { get; set; }
    public IList<InsuredPropertyDetail> InsuredPropertyDetails { get; set; }
    public IList<CoverageDetail> CoverageDetails { get; set; }
    public IList<string> Mortgagee { get; set; }
    public IList<Form> Forms { get; set; }
    public string FormIdentifier { get; set; }
    public string AdditionalInterestedParty { get; set; }
    public string CustomerServiceNumber { get; set; }
    public string TotalDiscounts { get; set; }
    public AgencyData Agency_Data { get; set; }
}


    }
}
