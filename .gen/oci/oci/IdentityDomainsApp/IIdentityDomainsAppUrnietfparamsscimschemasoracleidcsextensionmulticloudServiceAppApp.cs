using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsApp
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmulticloudServiceAppApp), fullyQualifiedName: "oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmulticloudServiceAppApp")]
    public interface IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmulticloudServiceAppApp
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#multicloud_service_type IdentityDomainsApp#multicloud_service_type}.</summary>
        [JsiiProperty(name: "multicloudServiceType", typeJson: "{\"primitive\":\"string\"}")]
        string MulticloudServiceType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#multicloud_platform_url IdentityDomainsApp#multicloud_platform_url}.</summary>
        [JsiiProperty(name: "multicloudPlatformUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MulticloudPlatformUrl
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmulticloudServiceAppApp), fullyQualifiedName: "oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmulticloudServiceAppApp")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmulticloudServiceAppApp
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#multicloud_service_type IdentityDomainsApp#multicloud_service_type}.</summary>
            [JsiiProperty(name: "multicloudServiceType", typeJson: "{\"primitive\":\"string\"}")]
            public string MulticloudServiceType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#multicloud_platform_url IdentityDomainsApp#multicloud_platform_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "multicloudPlatformUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MulticloudPlatformUrl
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
