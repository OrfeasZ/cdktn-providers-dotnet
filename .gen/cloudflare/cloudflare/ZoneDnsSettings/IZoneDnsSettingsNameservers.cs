using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZoneDnsSettings
{
    [JsiiInterface(nativeType: typeof(IZoneDnsSettingsNameservers), fullyQualifiedName: "cloudflare.zoneDnsSettings.ZoneDnsSettingsNameservers")]
    public interface IZoneDnsSettingsNameservers
    {
        /// <summary>Nameserver type. Available values: "cloudflare.standard", "cloudflare.advanced", "custom.account", "custom.tenant", "custom.zone", "custom".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zone_dns_settings#type ZoneDnsSettings#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Identifier of the account-owned Custom Nameserver Set to use for this zone.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zone_dns_settings#nameserver_set_id ZoneDnsSettings#nameserver_set_id}
        /// </remarks>
        [JsiiProperty(name: "nameserverSetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NameserverSetId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configured nameserver set number to use for this zone.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zone_dns_settings#ns_set ZoneDnsSettings#ns_set}
        /// </remarks>
        [JsiiProperty(name: "nsSet", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? NsSet
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZoneDnsSettingsNameservers), fullyQualifiedName: "cloudflare.zoneDnsSettings.ZoneDnsSettingsNameservers")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZoneDnsSettings.IZoneDnsSettingsNameservers
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Nameserver type. Available values: "cloudflare.standard", "cloudflare.advanced", "custom.account", "custom.tenant", "custom.zone", "custom".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zone_dns_settings#type ZoneDnsSettings#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Identifier of the account-owned Custom Nameserver Set to use for this zone.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zone_dns_settings#nameserver_set_id ZoneDnsSettings#nameserver_set_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nameserverSetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NameserverSetId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Configured nameserver set number to use for this zone.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.27.0/docs/resources/zone_dns_settings#ns_set ZoneDnsSettings#ns_set}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nsSet", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? NsSet
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
