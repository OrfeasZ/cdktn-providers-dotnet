using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsApiKey
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsApiKey.IdentityDomainsApiKeyTags")]
    public class IdentityDomainsApiKeyTags : oci.IdentityDomainsApiKey.IIdentityDomainsApiKeyTags
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_api_key#key IdentityDomainsApiKey#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_api_key#value IdentityDomainsApiKey#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
