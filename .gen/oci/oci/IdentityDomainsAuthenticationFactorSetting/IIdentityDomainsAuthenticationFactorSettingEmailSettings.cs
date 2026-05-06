using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsAuthenticationFactorSetting
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsAuthenticationFactorSettingEmailSettings), fullyQualifiedName: "oci.identityDomainsAuthenticationFactorSetting.IdentityDomainsAuthenticationFactorSettingEmailSettings")]
    public interface IIdentityDomainsAuthenticationFactorSettingEmailSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#email_link_enabled IdentityDomainsAuthenticationFactorSetting#email_link_enabled}.</summary>
        [JsiiProperty(name: "emailLinkEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object EmailLinkEnabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#email_link_custom_url IdentityDomainsAuthenticationFactorSetting#email_link_custom_url}.</summary>
        [JsiiProperty(name: "emailLinkCustomUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EmailLinkCustomUrl
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsAuthenticationFactorSettingEmailSettings), fullyQualifiedName: "oci.identityDomainsAuthenticationFactorSetting.IdentityDomainsAuthenticationFactorSettingEmailSettings")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsAuthenticationFactorSetting.IIdentityDomainsAuthenticationFactorSettingEmailSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#email_link_enabled IdentityDomainsAuthenticationFactorSetting#email_link_enabled}.</summary>
            [JsiiProperty(name: "emailLinkEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object EmailLinkEnabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#email_link_custom_url IdentityDomainsAuthenticationFactorSetting#email_link_custom_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "emailLinkCustomUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EmailLinkCustomUrl
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
