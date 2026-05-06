using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsSetting
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsSettingPurgeConfigs), fullyQualifiedName: "oci.identityDomainsSetting.IdentityDomainsSettingPurgeConfigs")]
    public interface IIdentityDomainsSettingPurgeConfigs
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_setting#resource_name IdentityDomainsSetting#resource_name}.</summary>
        [JsiiProperty(name: "resourceName", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_setting#retention_period IdentityDomainsSetting#retention_period}.</summary>
        [JsiiProperty(name: "retentionPeriod", typeJson: "{\"primitive\":\"number\"}")]
        double RetentionPeriod
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsSettingPurgeConfigs), fullyQualifiedName: "oci.identityDomainsSetting.IdentityDomainsSettingPurgeConfigs")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsSetting.IIdentityDomainsSettingPurgeConfigs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_setting#resource_name IdentityDomainsSetting#resource_name}.</summary>
            [JsiiProperty(name: "resourceName", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_setting#retention_period IdentityDomainsSetting#retention_period}.</summary>
            [JsiiProperty(name: "retentionPeriod", typeJson: "{\"primitive\":\"number\"}")]
            public double RetentionPeriod
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
