using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZoneSubscription
{
    [JsiiInterface(nativeType: typeof(IZoneSubscriptionConfig), fullyQualifiedName: "cloudflare.zoneSubscription.ZoneSubscriptionConfig")]
    public interface IZoneSubscriptionConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_subscription#zone_id ZoneSubscription#zone_id}
        /// </remarks>
        [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
        string ZoneId
        {
            get;
        }

        /// <summary>How often the subscription is renewed automatically.</summary>
        /// <remarks>
        /// Available values: "weekly", "monthly", "quarterly", "yearly".
        /// Note: Some plans may not support frequency configuration and will return "not-applicable".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_subscription#frequency ZoneSubscription#frequency}
        /// </remarks>
        [JsiiProperty(name: "frequency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Frequency
        {
            get
            {
                return null;
            }
        }

        /// <summary>The rate plan applied to the subscription.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_subscription#rate_plan ZoneSubscription#rate_plan}
        /// </remarks>
        [JsiiProperty(name: "ratePlan", typeJson: "{\"fqn\":\"cloudflare.zoneSubscription.ZoneSubscriptionRatePlan\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZoneSubscription.IZoneSubscriptionRatePlan? RatePlan
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZoneSubscriptionConfig), fullyQualifiedName: "cloudflare.zoneSubscription.ZoneSubscriptionConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZoneSubscription.IZoneSubscriptionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_subscription#zone_id ZoneSubscription#zone_id}
            /// </remarks>
            [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
            public string ZoneId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>How often the subscription is renewed automatically.</summary>
            /// <remarks>
            /// Available values: "weekly", "monthly", "quarterly", "yearly".
            /// Note: Some plans may not support frequency configuration and will return "not-applicable".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_subscription#frequency ZoneSubscription#frequency}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "frequency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Frequency
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The rate plan applied to the subscription.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_subscription#rate_plan ZoneSubscription#rate_plan}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ratePlan", typeJson: "{\"fqn\":\"cloudflare.zoneSubscription.ZoneSubscriptionRatePlan\"}", isOptional: true)]
            public cloudflare.ZoneSubscription.IZoneSubscriptionRatePlan? RatePlan
            {
                get => GetInstanceProperty<cloudflare.ZoneSubscription.IZoneSubscriptionRatePlan?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
