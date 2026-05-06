using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AccountDnsSettings
{
    [JsiiInterface(nativeType: typeof(IAccountDnsSettingsZoneDefaultsNameservers), fullyQualifiedName: "cloudflare.accountDnsSettings.AccountDnsSettingsZoneDefaultsNameservers")]
    public interface IAccountDnsSettingsZoneDefaultsNameservers
    {
        /// <summary>Nameserver type Available values: "cloudflare.standard", "cloudflare.standard.random", "custom.account", "custom.tenant".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/account_dns_settings#type AccountDnsSettings#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAccountDnsSettingsZoneDefaultsNameservers), fullyQualifiedName: "cloudflare.accountDnsSettings.AccountDnsSettingsZoneDefaultsNameservers")]
        internal sealed class _Proxy : DeputyBase, cloudflare.AccountDnsSettings.IAccountDnsSettingsZoneDefaultsNameservers
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Nameserver type Available values: "cloudflare.standard", "cloudflare.standard.random", "custom.account", "custom.tenant".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/account_dns_settings#type AccountDnsSettings#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
