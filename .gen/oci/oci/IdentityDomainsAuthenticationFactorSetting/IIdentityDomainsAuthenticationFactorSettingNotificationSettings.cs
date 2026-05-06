using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsAuthenticationFactorSetting
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsAuthenticationFactorSettingNotificationSettings), fullyQualifiedName: "oci.identityDomainsAuthenticationFactorSetting.IdentityDomainsAuthenticationFactorSettingNotificationSettings")]
    public interface IIdentityDomainsAuthenticationFactorSettingNotificationSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#pull_enabled IdentityDomainsAuthenticationFactorSetting#pull_enabled}.</summary>
        [JsiiProperty(name: "pullEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object PullEnabled
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsAuthenticationFactorSettingNotificationSettings), fullyQualifiedName: "oci.identityDomainsAuthenticationFactorSetting.IdentityDomainsAuthenticationFactorSettingNotificationSettings")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsAuthenticationFactorSetting.IIdentityDomainsAuthenticationFactorSettingNotificationSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#pull_enabled IdentityDomainsAuthenticationFactorSetting#pull_enabled}.</summary>
            [JsiiProperty(name: "pullEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object PullEnabled
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
