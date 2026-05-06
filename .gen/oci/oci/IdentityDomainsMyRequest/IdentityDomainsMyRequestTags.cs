using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsMyRequest
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsMyRequest.IdentityDomainsMyRequestTags")]
    public class IdentityDomainsMyRequestTags : oci.IdentityDomainsMyRequest.IIdentityDomainsMyRequestTags
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_my_request#key IdentityDomainsMyRequest#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_my_request#value IdentityDomainsMyRequest#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
