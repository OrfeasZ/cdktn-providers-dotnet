using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.LoadBalancerPool
{
    [JsiiInterface(nativeType: typeof(ILoadBalancerPoolLoadShedding), fullyQualifiedName: "cloudflare.loadBalancerPool.LoadBalancerPoolLoadShedding")]
    public interface ILoadBalancerPoolLoadShedding
    {
        /// <summary>The percent of traffic to shed from the pool, according to the default policy.</summary>
        /// <remarks>
        /// Applies to new sessions and traffic without session affinity.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/load_balancer_pool#default_percent LoadBalancerPool#default_percent}
        /// </remarks>
        [JsiiProperty(name: "defaultPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DefaultPercent
        {
            get
            {
                return null;
            }
        }

        /// <summary>The default policy to use when load shedding.</summary>
        /// <remarks>
        /// A random policy randomly sheds a given percent of requests. A hash policy computes a hash over the CF-Connecting-IP address and sheds all requests originating from a percent of IPs.
        /// Available values: "random", "hash".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/load_balancer_pool#default_policy LoadBalancerPool#default_policy}
        /// </remarks>
        [JsiiProperty(name: "defaultPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>The percent of existing sessions to shed from the pool, according to the session policy.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/load_balancer_pool#session_percent LoadBalancerPool#session_percent}
        /// </remarks>
        [JsiiProperty(name: "sessionPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SessionPercent
        {
            get
            {
                return null;
            }
        }

        /// <summary>Only the hash policy is supported for existing sessions (to avoid exponential decay). Available values: "hash".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/load_balancer_pool#session_policy LoadBalancerPool#session_policy}
        /// </remarks>
        [JsiiProperty(name: "sessionPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SessionPolicy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILoadBalancerPoolLoadShedding), fullyQualifiedName: "cloudflare.loadBalancerPool.LoadBalancerPoolLoadShedding")]
        internal sealed class _Proxy : DeputyBase, cloudflare.LoadBalancerPool.ILoadBalancerPoolLoadShedding
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The percent of traffic to shed from the pool, according to the default policy.</summary>
            /// <remarks>
            /// Applies to new sessions and traffic without session affinity.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/load_balancer_pool#default_percent LoadBalancerPool#default_percent}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DefaultPercent
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The default policy to use when load shedding.</summary>
            /// <remarks>
            /// A random policy randomly sheds a given percent of requests. A hash policy computes a hash over the CF-Connecting-IP address and sheds all requests originating from a percent of IPs.
            /// Available values: "random", "hash".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/load_balancer_pool#default_policy LoadBalancerPool#default_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultPolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The percent of existing sessions to shed from the pool, according to the session policy.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/load_balancer_pool#session_percent LoadBalancerPool#session_percent}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sessionPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SessionPercent
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Only the hash policy is supported for existing sessions (to avoid exponential decay). Available values: "hash".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/load_balancer_pool#session_policy LoadBalancerPool#session_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sessionPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SessionPolicy
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
