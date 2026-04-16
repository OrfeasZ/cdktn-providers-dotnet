using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZoneDnsSettings
{
    [JsiiInterface(nativeType: typeof(IZoneDnsSettingsInternalDns), fullyQualifiedName: "cloudflare.zoneDnsSettings.ZoneDnsSettingsInternalDns")]
    public interface IZoneDnsSettingsInternalDns
    {
        /// <summary>The ID of the zone to fallback to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_dns_settings#reference_zone_id ZoneDnsSettings#reference_zone_id}
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

        [JsiiTypeProxy(nativeType: typeof(IZoneDnsSettingsInternalDns), fullyQualifiedName: "cloudflare.zoneDnsSettings.ZoneDnsSettingsInternalDns")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZoneDnsSettings.IZoneDnsSettingsInternalDns
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The ID of the zone to fallback to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_dns_settings#reference_zone_id ZoneDnsSettings#reference_zone_id}
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
