using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AccountDnsSettings
{
    [JsiiInterface(nativeType: typeof(IAccountDnsSettingsZoneDefaultsInternalDns), fullyQualifiedName: "cloudflare.accountDnsSettings.AccountDnsSettingsZoneDefaultsInternalDns")]
    public interface IAccountDnsSettingsZoneDefaultsInternalDns
    {
        /// <summary>The ID of the zone to fallback to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/account_dns_settings#reference_zone_id AccountDnsSettings#reference_zone_id}
        /// </remarks>
        [JsiiProperty(name: "referenceZoneId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReferenceZoneId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAccountDnsSettingsZoneDefaultsInternalDns), fullyQualifiedName: "cloudflare.accountDnsSettings.AccountDnsSettingsZoneDefaultsInternalDns")]
        internal sealed class _Proxy : DeputyBase, cloudflare.AccountDnsSettings.IAccountDnsSettingsZoneDefaultsInternalDns
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The ID of the zone to fallback to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/account_dns_settings#reference_zone_id AccountDnsSettings#reference_zone_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "referenceZoneId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReferenceZoneId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
