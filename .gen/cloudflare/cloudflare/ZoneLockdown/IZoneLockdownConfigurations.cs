using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZoneLockdown
{
    [JsiiInterface(nativeType: typeof(IZoneLockdownConfigurations), fullyQualifiedName: "cloudflare.zoneLockdown.ZoneLockdownConfigurations")]
    public interface IZoneLockdownConfigurations
    {
        /// <summary>The configuration target.</summary>
        /// <remarks>
        /// You must set the target to <c>ip</c> when specifying an IP address in the Zone Lockdown rule.
        /// Available values: "ip", "ip_range".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zone_lockdown#target ZoneLockdown#target}
        /// </remarks>
        [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Target
        {
            get
            {
                return null;
            }
        }

        /// <summary>The IP address to match. This address will be compared to the IP address of incoming requests.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zone_lockdown#value ZoneLockdown#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Value
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZoneLockdownConfigurations), fullyQualifiedName: "cloudflare.zoneLockdown.ZoneLockdownConfigurations")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZoneLockdown.IZoneLockdownConfigurations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The configuration target.</summary>
            /// <remarks>
            /// You must set the target to <c>ip</c> when specifying an IP address in the Zone Lockdown rule.
            /// Available values: "ip", "ip_range".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zone_lockdown#target ZoneLockdown#target}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Target
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The IP address to match. This address will be compared to the IP address of incoming requests.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zone_lockdown#value ZoneLockdown#value}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Value
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
