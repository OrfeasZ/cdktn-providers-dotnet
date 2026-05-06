using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsMyRequest
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsMyRequest.IdentityDomainsMyRequestRequesting")]
    public class IdentityDomainsMyRequestRequesting : oci.IdentityDomainsMyRequest.IIdentityDomainsMyRequestRequesting
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_my_request#type IdentityDomainsMyRequest#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
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
