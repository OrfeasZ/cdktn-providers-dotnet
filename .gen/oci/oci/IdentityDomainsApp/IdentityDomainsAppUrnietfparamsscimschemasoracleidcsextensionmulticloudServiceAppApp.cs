using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsApp
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmulticloudServiceAppApp")]
    public class IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmulticloudServiceAppApp : oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmulticloudServiceAppApp
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#multicloud_service_type IdentityDomainsApp#multicloud_service_type}.</summary>
        [JsiiProperty(name: "multicloudServiceType", typeJson: "{\"primitive\":\"string\"}")]
        public string MulticloudServiceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#multicloud_platform_url IdentityDomainsApp#multicloud_platform_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "multicloudPlatformUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MulticloudPlatformUrl
        {
            get;
            set;
        }
    }
}
