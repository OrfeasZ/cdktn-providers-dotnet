using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DomainRecord
{
    [JsiiInterface(nativeType: typeof(IDomainRecordGeoIpMatches), fullyQualifiedName: "scaleway.domainRecord.DomainRecordGeoIpMatches")]
    public interface IDomainRecordGeoIpMatches
    {
        /// <summary>The data of the match result.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_record#data DomainRecord#data}
        /// </remarks>
        [JsiiProperty(name: "data", typeJson: "{\"primitive\":\"string\"}")]
        string Data
        {
            get;
        }

        /// <summary>List of continents (eg: EU for Europe, NA for North America, AS for Asia...). List of all continents code: https://api.scaleway.com/domain-private/v2beta1/continents.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_record#continents DomainRecord#continents}
        /// </remarks>
        [JsiiProperty(name: "continents", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Continents
        {
            get
            {
                return null;
            }
        }

        /// <summary>List of countries (eg: FR for France, US for the United States, GB for Great Britain...). List of all countries code: https://api.scaleway.com/domain-private/v2beta1/countries.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_record#countries DomainRecord#countries}
        /// </remarks>
        [JsiiProperty(name: "countries", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Countries
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainRecordGeoIpMatches), fullyQualifiedName: "scaleway.domainRecord.DomainRecordGeoIpMatches")]
        internal sealed class _Proxy : DeputyBase, scaleway.DomainRecord.IDomainRecordGeoIpMatches
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The data of the match result.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_record#data DomainRecord#data}
            /// </remarks>
            [JsiiProperty(name: "data", typeJson: "{\"primitive\":\"string\"}")]
            public string Data
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>List of continents (eg: EU for Europe, NA for North America, AS for Asia...). List of all continents code: https://api.scaleway.com/domain-private/v2beta1/continents.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_record#continents DomainRecord#continents}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "continents", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Continents
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>List of countries (eg: FR for France, US for the United States, GB for Great Britain...). List of all countries code: https://api.scaleway.com/domain-private/v2beta1/countries.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/domain_record#countries DomainRecord#countries}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "countries", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Countries
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
