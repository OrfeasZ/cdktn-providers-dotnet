using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsMyCustomerSecretKey
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsMyCustomerSecretKey.IdentityDomainsMyCustomerSecretKeyTags")]
    public class IdentityDomainsMyCustomerSecretKeyTags : oci.IdentityDomainsMyCustomerSecretKey.IIdentityDomainsMyCustomerSecretKeyTags
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_my_customer_secret_key#key IdentityDomainsMyCustomerSecretKey#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_my_customer_secret_key#value IdentityDomainsMyCustomerSecretKey#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
