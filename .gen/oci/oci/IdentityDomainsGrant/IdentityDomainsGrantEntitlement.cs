using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsGrant
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsGrant.IdentityDomainsGrantEntitlement")]
    public class IdentityDomainsGrantEntitlement : oci.IdentityDomainsGrant.IIdentityDomainsGrantEntitlement
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_grant#attribute_name IdentityDomainsGrant#attribute_name}.</summary>
        [JsiiProperty(name: "attributeName", typeJson: "{\"primitive\":\"string\"}")]
        public string AttributeName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_grant#attribute_value IdentityDomainsGrant#attribute_value}.</summary>
        [JsiiProperty(name: "attributeValue", typeJson: "{\"primitive\":\"string\"}")]
        public string AttributeValue
        {
            get;
            set;
        }
    }
}
