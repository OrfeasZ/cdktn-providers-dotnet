using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustOrganization
{
    [JsiiInterface(nativeType: typeof(IZeroTrustOrganizationServiceTokenInactivity), fullyQualifiedName: "cloudflare.zeroTrustOrganization.ZeroTrustOrganizationServiceTokenInactivity")]
    public interface IZeroTrustOrganizationServiceTokenInactivity
    {
        /// <summary>The action applied to an inactive service token. Available values: "disable", "delete".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/zero_trust_organization#action ZeroTrustOrganization#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        string Action
        {
            get;
        }

        /// <summary>Whether automatic enforcement for inactive service tokens is enabled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/zero_trust_organization#enabled ZeroTrustOrganization#enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>The number of days a service token must be inactive before the configured action is applied.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/zero_trust_organization#inactivity_threshold_days ZeroTrustOrganization#inactivity_threshold_days}
        /// </remarks>
        [JsiiProperty(name: "inactivityThresholdDays", typeJson: "{\"primitive\":\"number\"}")]
        double InactivityThresholdDays
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustOrganizationServiceTokenInactivity), fullyQualifiedName: "cloudflare.zeroTrustOrganization.ZeroTrustOrganizationServiceTokenInactivity")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustOrganization.IZeroTrustOrganizationServiceTokenInactivity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The action applied to an inactive service token. Available values: "disable", "delete".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/zero_trust_organization#action ZeroTrustOrganization#action}
            /// </remarks>
            [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
            public string Action
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Whether automatic enforcement for inactive service tokens is enabled.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/zero_trust_organization#enabled ZeroTrustOrganization#enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>The number of days a service token must be inactive before the configured action is applied.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/zero_trust_organization#inactivity_threshold_days ZeroTrustOrganization#inactivity_threshold_days}
            /// </remarks>
            [JsiiProperty(name: "inactivityThresholdDays", typeJson: "{\"primitive\":\"number\"}")]
            public double InactivityThresholdDays
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
