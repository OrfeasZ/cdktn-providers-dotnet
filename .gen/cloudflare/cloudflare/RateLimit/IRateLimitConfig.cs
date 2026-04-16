using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.RateLimit
{
    [JsiiInterface(nativeType: typeof(IRateLimitConfig), fullyQualifiedName: "cloudflare.rateLimit.RateLimitConfig")]
    public interface IRateLimitConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The action to perform when the threshold of matched traffic within the configured period is exceeded.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/rate_limit#action RateLimit#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"cloudflare.rateLimit.RateLimitAction\"}")]
        cloudflare.RateLimit.IRateLimitAction Action
        {
            get;
        }

        /// <summary>Determines which traffic the rate limit counts towards the threshold.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/rate_limit#match RateLimit#match}
        /// </remarks>
        [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"cloudflare.rateLimit.RateLimitMatch\"}")]
        cloudflare.RateLimit.IRateLimitMatch Match
        {
            get;
        }

        /// <summary>The time in seconds (an integer value) to count matching traffic.</summary>
        /// <remarks>
        /// If the count exceeds the configured threshold within this period, Cloudflare will perform the configured action.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/rate_limit#period RateLimit#period}
        /// </remarks>
        [JsiiProperty(name: "period", typeJson: "{\"primitive\":\"number\"}")]
        double Period
        {
            get;
        }

        /// <summary>The threshold that will trigger the configured mitigation action.</summary>
        /// <remarks>
        /// Configure this value along with the <c>period</c> property to establish a threshold per period.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/rate_limit#threshold RateLimit#threshold}
        /// </remarks>
        [JsiiProperty(name: "threshold", typeJson: "{\"primitive\":\"number\"}")]
        double Threshold
        {
            get;
        }

        /// <summary>Defines an identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/rate_limit#zone_id RateLimit#zone_id}
        /// </remarks>
        [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
        string ZoneId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IRateLimitConfig), fullyQualifiedName: "cloudflare.rateLimit.RateLimitConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.RateLimit.IRateLimitConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The action to perform when the threshold of matched traffic within the configured period is exceeded.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/rate_limit#action RateLimit#action}
            /// </remarks>
            [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"cloudflare.rateLimit.RateLimitAction\"}")]
            public cloudflare.RateLimit.IRateLimitAction Action
            {
                get => GetInstanceProperty<cloudflare.RateLimit.IRateLimitAction>()!;
            }

            /// <summary>Determines which traffic the rate limit counts towards the threshold.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/rate_limit#match RateLimit#match}
            /// </remarks>
            [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"cloudflare.rateLimit.RateLimitMatch\"}")]
            public cloudflare.RateLimit.IRateLimitMatch Match
            {
                get => GetInstanceProperty<cloudflare.RateLimit.IRateLimitMatch>()!;
            }

            /// <summary>The time in seconds (an integer value) to count matching traffic.</summary>
            /// <remarks>
            /// If the count exceeds the configured threshold within this period, Cloudflare will perform the configured action.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/rate_limit#period RateLimit#period}
            /// </remarks>
            [JsiiProperty(name: "period", typeJson: "{\"primitive\":\"number\"}")]
            public double Period
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>The threshold that will trigger the configured mitigation action.</summary>
            /// <remarks>
            /// Configure this value along with the <c>period</c> property to establish a threshold per period.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/rate_limit#threshold RateLimit#threshold}
            /// </remarks>
            [JsiiProperty(name: "threshold", typeJson: "{\"primitive\":\"number\"}")]
            public double Threshold
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Defines an identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/rate_limit#zone_id RateLimit#zone_id}
            /// </remarks>
            [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
            public string ZoneId
            {
                get => GetInstanceProperty<string>()!;
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
