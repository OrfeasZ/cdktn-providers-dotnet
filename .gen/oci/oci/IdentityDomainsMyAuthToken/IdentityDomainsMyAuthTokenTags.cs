using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsMyAuthToken
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsMyAuthToken.IdentityDomainsMyAuthTokenTags")]
    public class IdentityDomainsMyAuthTokenTags : oci.IdentityDomainsMyAuthToken.IIdentityDomainsMyAuthTokenTags
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_my_auth_token#key IdentityDomainsMyAuthToken#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_my_auth_token#value IdentityDomainsMyAuthToken#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
