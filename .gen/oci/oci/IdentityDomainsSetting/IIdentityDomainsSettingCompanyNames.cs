using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsSetting
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsSettingCompanyNames), fullyQualifiedName: "oci.identityDomainsSetting.IdentityDomainsSettingCompanyNames")]
    public interface IIdentityDomainsSettingCompanyNames
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_setting#locale IdentityDomainsSetting#locale}.</summary>
        [JsiiProperty(name: "locale", typeJson: "{\"primitive\":\"string\"}")]
        string Locale
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_setting#value IdentityDomainsSetting#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsSettingCompanyNames), fullyQualifiedName: "oci.identityDomainsSetting.IdentityDomainsSettingCompanyNames")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsSetting.IIdentityDomainsSettingCompanyNames
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_setting#locale IdentityDomainsSetting#locale}.</summary>
            [JsiiProperty(name: "locale", typeJson: "{\"primitive\":\"string\"}")]
            public string Locale
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_setting#value IdentityDomainsSetting#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
