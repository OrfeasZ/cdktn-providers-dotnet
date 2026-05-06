using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsApp
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppFlatFileConnectorBundle")]
    public class IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppFlatFileConnectorBundle : oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppFlatFileConnectorBundle
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#value IdentityDomainsApp#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#display IdentityDomainsApp#display}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "display", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Display
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#well_known_id IdentityDomainsApp#well_known_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "wellKnownId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WellKnownId
        {
            get;
            set;
        }
    }
}
