using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsMappedAttribute
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsMappedAttribute.IdentityDomainsMappedAttributeTags")]
    public class IdentityDomainsMappedAttributeTags : oci.IdentityDomainsMappedAttribute.IIdentityDomainsMappedAttributeTags
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/identity_domains_mapped_attribute#key IdentityDomainsMappedAttribute#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/identity_domains_mapped_attribute#value IdentityDomainsMappedAttribute#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
