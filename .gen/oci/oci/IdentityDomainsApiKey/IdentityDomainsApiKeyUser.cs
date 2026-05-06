using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsApiKey
{
    [JsiiByValue(fqn: "oci.identityDomainsApiKey.IdentityDomainsApiKeyUser")]
    public class IdentityDomainsApiKeyUser : oci.IdentityDomainsApiKey.IIdentityDomainsApiKeyUser
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_api_key#ocid IdentityDomainsApiKey#ocid}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ocid
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_api_key#value IdentityDomainsApiKey#value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Value
        {
            get;
            set;
        }
    }
}
