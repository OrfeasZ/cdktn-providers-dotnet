using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsAccountRecoverySetting
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsAccountRecoverySettingTags), fullyQualifiedName: "oci.identityDomainsAccountRecoverySetting.IdentityDomainsAccountRecoverySettingTags")]
    public interface IIdentityDomainsAccountRecoverySettingTags
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_account_recovery_setting#key IdentityDomainsAccountRecoverySetting#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_account_recovery_setting#value IdentityDomainsAccountRecoverySetting#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsAccountRecoverySettingTags), fullyQualifiedName: "oci.identityDomainsAccountRecoverySetting.IdentityDomainsAccountRecoverySettingTags")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsAccountRecoverySetting.IIdentityDomainsAccountRecoverySettingTags
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_account_recovery_setting#key IdentityDomainsAccountRecoverySetting#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_account_recovery_setting#value IdentityDomainsAccountRecoverySetting#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
