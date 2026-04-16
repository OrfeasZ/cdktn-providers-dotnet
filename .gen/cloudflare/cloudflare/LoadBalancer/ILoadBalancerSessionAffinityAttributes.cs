using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.LoadBalancer
{
    [JsiiInterface(nativeType: typeof(ILoadBalancerSessionAffinityAttributes), fullyQualifiedName: "cloudflare.loadBalancer.LoadBalancerSessionAffinityAttributes")]
    public interface ILoadBalancerSessionAffinityAttributes
    {
        /// <summary>Configures the drain duration in seconds.</summary>
        /// <remarks>
        /// This field is only used when session affinity is enabled on the load balancer.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer#drain_duration LoadBalancer#drain_duration}
        /// </remarks>
        [JsiiProperty(name: "drainDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DrainDuration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures the names of HTTP headers to base session affinity on when header `session_affinity` is enabled.</summary>
        /// <remarks>
        /// At least one HTTP header name must be provided. To specify the exact cookies to be used, include an item in the following format: <c>"cookie:&lt;cookie-name-1&gt;,&lt;cookie-name-2&gt;"</c> (example) where everything after the colon is a comma-separated list of cookie names. Providing only <c>"cookie"</c> will result in all cookies being used. The default max number of HTTP header names that can be provided depends on your plan: 5 for Enterprise, 1 for all other plans.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer#headers LoadBalancer#headers}
        /// </remarks>
        [JsiiProperty(name: "headers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Headers
        {
            get
            {
                return null;
            }
        }

        /// <summary>When header `session_affinity` is enabled, this option can be used to specify how HTTP headers on load balancing requests will be used.</summary>
        /// <remarks>
        /// The supported values are: - <c>"true"</c>: Load balancing requests must contain <em>all</em> of the HTTP headers specified by the <c>headers</c> session affinity attribute, otherwise sessions aren't created. - <c>"false"</c>: Load balancing requests must contain <em>at least one</em> of the HTTP headers specified by the <c>headers</c> session affinity attribute, otherwise sessions aren't created.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer#require_all_headers LoadBalancer#require_all_headers}
        /// </remarks>
        [JsiiProperty(name: "requireAllHeaders", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequireAllHeaders
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures the SameSite attribute on session affinity cookie.</summary>
        /// <remarks>
        /// Value "Auto" will be translated to "Lax" or "None" depending if Always Use HTTPS is enabled. Note: when using value "None", the secure attribute can not be set to "Never".
        /// Available values: "Auto", "Lax", "None", "Strict".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer#samesite LoadBalancer#samesite}
        /// </remarks>
        [JsiiProperty(name: "samesite", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Samesite
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures the Secure attribute on session affinity cookie.</summary>
        /// <remarks>
        /// Value "Always" indicates the Secure attribute will be set in the Set-Cookie header, "Never" indicates the Secure attribute will not be set, and "Auto" will set the Secure attribute depending if Always Use HTTPS is enabled.
        /// Available values: "Auto", "Always", "Never".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer#secure LoadBalancer#secure}
        /// </remarks>
        [JsiiProperty(name: "secure", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Secure
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures the zero-downtime failover between origins within a pool when session affinity is enabled.</summary>
        /// <remarks>
        /// This feature is currently incompatible with Argo, Tiered Cache, and Bandwidth Alliance. The supported values are: - <c>"none"</c>: No failover takes place for sessions pinned to the origin (default). - <c>"temporary"</c>: Traffic will be sent to another other healthy origin until the originally pinned origin is available; note that this can potentially result in heavy origin flapping. - <c>"sticky"</c>: The session affinity cookie is updated and subsequent requests are sent to the new origin. Note: Zero-downtime failover with sticky sessions is currently not supported for session affinity by header.
        /// Available values: "none", "temporary", "sticky".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer#zero_downtime_failover LoadBalancer#zero_downtime_failover}
        /// </remarks>
        [JsiiProperty(name: "zeroDowntimeFailover", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ZeroDowntimeFailover
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILoadBalancerSessionAffinityAttributes), fullyQualifiedName: "cloudflare.loadBalancer.LoadBalancerSessionAffinityAttributes")]
        internal sealed class _Proxy : DeputyBase, cloudflare.LoadBalancer.ILoadBalancerSessionAffinityAttributes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Configures the drain duration in seconds.</summary>
            /// <remarks>
            /// This field is only used when session affinity is enabled on the load balancer.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer#drain_duration LoadBalancer#drain_duration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "drainDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DrainDuration
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Configures the names of HTTP headers to base session affinity on when header `session_affinity` is enabled.</summary>
            /// <remarks>
            /// At least one HTTP header name must be provided. To specify the exact cookies to be used, include an item in the following format: <c>"cookie:&lt;cookie-name-1&gt;,&lt;cookie-name-2&gt;"</c> (example) where everything after the colon is a comma-separated list of cookie names. Providing only <c>"cookie"</c> will result in all cookies being used. The default max number of HTTP header names that can be provided depends on your plan: 5 for Enterprise, 1 for all other plans.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer#headers LoadBalancer#headers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "headers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Headers
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>When header `session_affinity` is enabled, this option can be used to specify how HTTP headers on load balancing requests will be used.</summary>
            /// <remarks>
            /// The supported values are: - <c>"true"</c>: Load balancing requests must contain <em>all</em> of the HTTP headers specified by the <c>headers</c> session affinity attribute, otherwise sessions aren't created. - <c>"false"</c>: Load balancing requests must contain <em>at least one</em> of the HTTP headers specified by the <c>headers</c> session affinity attribute, otherwise sessions aren't created.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer#require_all_headers LoadBalancer#require_all_headers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requireAllHeaders", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? RequireAllHeaders
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Configures the SameSite attribute on session affinity cookie.</summary>
            /// <remarks>
            /// Value "Auto" will be translated to "Lax" or "None" depending if Always Use HTTPS is enabled. Note: when using value "None", the secure attribute can not be set to "Never".
            /// Available values: "Auto", "Lax", "None", "Strict".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer#samesite LoadBalancer#samesite}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "samesite", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Samesite
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Configures the Secure attribute on session affinity cookie.</summary>
            /// <remarks>
            /// Value "Always" indicates the Secure attribute will be set in the Set-Cookie header, "Never" indicates the Secure attribute will not be set, and "Auto" will set the Secure attribute depending if Always Use HTTPS is enabled.
            /// Available values: "Auto", "Always", "Never".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer#secure LoadBalancer#secure}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "secure", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Secure
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Configures the zero-downtime failover between origins within a pool when session affinity is enabled.</summary>
            /// <remarks>
            /// This feature is currently incompatible with Argo, Tiered Cache, and Bandwidth Alliance. The supported values are: - <c>"none"</c>: No failover takes place for sessions pinned to the origin (default). - <c>"temporary"</c>: Traffic will be sent to another other healthy origin until the originally pinned origin is available; note that this can potentially result in heavy origin flapping. - <c>"sticky"</c>: The session affinity cookie is updated and subsequent requests are sent to the new origin. Note: Zero-downtime failover with sticky sessions is currently not supported for session affinity by header.
            /// Available values: "none", "temporary", "sticky".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer#zero_downtime_failover LoadBalancer#zero_downtime_failover}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "zeroDowntimeFailover", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ZeroDowntimeFailover
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
