using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsApp
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderAppUserAssertionAttributes")]
    public class IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderAppUserAssertionAttributes : oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderAppUserAssertionAttributes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#name IdentityDomainsApp#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#user_store_attribute_name IdentityDomainsApp#user_store_attribute_name}.</summary>
        [JsiiProperty(name: "userStoreAttributeName", typeJson: "{\"primitive\":\"string\"}")]
        public string UserStoreAttributeName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#format IdentityDomainsApp#format}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Format
        {
            get;
            set;
        }
    }
}
