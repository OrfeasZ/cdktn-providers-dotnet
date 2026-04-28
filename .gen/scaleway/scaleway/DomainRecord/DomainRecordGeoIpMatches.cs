using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DomainRecord
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.domainRecord.DomainRecordGeoIpMatches")]
    public class DomainRecordGeoIpMatches : scaleway.DomainRecord.IDomainRecordGeoIpMatches
    {
        /// <summary>The data of the match result.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/domain_record#data DomainRecord#data}
        /// </remarks>
        [JsiiProperty(name: "data", typeJson: "{\"primitive\":\"string\"}")]
        public string Data
        {
            get;
            set;
        }

        /// <summary>List of continents (eg: EU for Europe, NA for North America, AS for Asia...). List of all continents code: https://api.scaleway.com/domain-private/v2beta1/continents.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/domain_record#continents DomainRecord#continents}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "continents", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Continents
        {
            get;
            set;
        }

        /// <summary>List of countries (eg: FR for France, US for the United States, GB for Great Britain...). List of all countries code: https://api.scaleway.com/domain-private/v2beta1/countries.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/domain_record#countries DomainRecord#countries}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "countries", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Countries
        {
            get;
            set;
        }
    }
}
