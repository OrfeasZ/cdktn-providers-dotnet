using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.LoadBalancerPool
{
    [JsiiInterface(nativeType: typeof(ILoadBalancerPoolOrigins), fullyQualifiedName: "cloudflare.loadBalancerPool.LoadBalancerPoolOrigins")]
    public interface ILoadBalancerPoolOrigins
    {
        /// <summary>The IP address (IPv4 or IPv6) of the origin, or its publicly addressable hostname.</summary>
        /// <remarks>
        /// Hostnames entered here should resolve directly to the origin, and not be a hostname proxied by Cloudflare. To set an internal/reserved address, virtual_network_id must also be set.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#address LoadBalancerPool#address}
        /// </remarks>
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Address
        {
            get
            {
                return null;
            }
        }

        /// <summary>This field shows up only if the origin is disabled.</summary>
        /// <remarks>
        /// This field is set with the time the origin was disabled.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#disabled_at LoadBalancerPool#disabled_at}
        /// </remarks>
        [JsiiProperty(name: "disabledAt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisabledAt
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether to enable (the default) this origin within the pool.</summary>
        /// <remarks>
        /// Disabled origins will not receive traffic and are excluded from health checks. The origin will only be disabled for the current pool.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#enabled LoadBalancerPool#enabled}
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>The request header is used to pass additional information with an HTTP request. Currently supported header is 'Host'.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#header LoadBalancerPool#header}
        /// </remarks>
        [JsiiProperty(name: "header", typeJson: "{\"fqn\":\"cloudflare.loadBalancerPool.LoadBalancerPoolOriginsHeader\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.LoadBalancerPool.ILoadBalancerPoolOriginsHeader? Header
        {
            get
            {
                return null;
            }
        }

        /// <summary>A human-identifiable name for the origin.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#name LoadBalancerPool#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>The port for upstream connections. A value of 0 means the default port for the protocol will be used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#port LoadBalancerPool#port}
        /// </remarks>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Port
        {
            get
            {
                return null;
            }
        }

        /// <summary>The virtual network subnet ID the origin belongs in. Virtual network must also belong to the account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#virtual_network_id LoadBalancerPool#virtual_network_id}
        /// </remarks>
        [JsiiProperty(name: "virtualNetworkId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VirtualNetworkId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The weight of this origin relative to other origins in the pool.</summary>
        /// <remarks>
        /// Based on the configured weight the total traffic is distributed among origins within the pool.
        ///
        /// <list type="bullet">
        /// <description><c>origin_steering.policy="least_outstanding_requests"</c>: Use weight to scale the origin's outstanding requests.</description>
        /// <description><c>origin_steering.policy="least_connections"</c>: Use weight to scale the origin's open connections.</description>
        /// </list>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#weight LoadBalancerPool#weight}
        /// </remarks>
        [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Weight
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILoadBalancerPoolOrigins), fullyQualifiedName: "cloudflare.loadBalancerPool.LoadBalancerPoolOrigins")]
        internal sealed class _Proxy : DeputyBase, cloudflare.LoadBalancerPool.ILoadBalancerPoolOrigins
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The IP address (IPv4 or IPv6) of the origin, or its publicly addressable hostname.</summary>
            /// <remarks>
            /// Hostnames entered here should resolve directly to the origin, and not be a hostname proxied by Cloudflare. To set an internal/reserved address, virtual_network_id must also be set.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#address LoadBalancerPool#address}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Address
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>This field shows up only if the origin is disabled.</summary>
            /// <remarks>
            /// This field is set with the time the origin was disabled.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#disabled_at LoadBalancerPool#disabled_at}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "disabledAt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisabledAt
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Whether to enable (the default) this origin within the pool.</summary>
            /// <remarks>
            /// Disabled origins will not receive traffic and are excluded from health checks. The origin will only be disabled for the current pool.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#enabled LoadBalancerPool#enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The request header is used to pass additional information with an HTTP request. Currently supported header is 'Host'.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#header LoadBalancerPool#header}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "header", typeJson: "{\"fqn\":\"cloudflare.loadBalancerPool.LoadBalancerPoolOriginsHeader\"}", isOptional: true)]
            public cloudflare.LoadBalancerPool.ILoadBalancerPoolOriginsHeader? Header
            {
                get => GetInstanceProperty<cloudflare.LoadBalancerPool.ILoadBalancerPoolOriginsHeader?>();
            }

            /// <summary>A human-identifiable name for the origin.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#name LoadBalancerPool#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The port for upstream connections. A value of 0 means the default port for the protocol will be used.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#port LoadBalancerPool#port}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Port
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The virtual network subnet ID the origin belongs in. Virtual network must also belong to the account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#virtual_network_id LoadBalancerPool#virtual_network_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "virtualNetworkId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VirtualNetworkId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The weight of this origin relative to other origins in the pool.</summary>
            /// <remarks>
            /// Based on the configured weight the total traffic is distributed among origins within the pool.
            ///
            /// <list type="bullet">
            /// <description><c>origin_steering.policy="least_outstanding_requests"</c>: Use weight to scale the origin's outstanding requests.</description>
            /// <description><c>origin_steering.policy="least_connections"</c>: Use weight to scale the origin's open connections.</description>
            /// </list>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#weight LoadBalancerPool#weight}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Weight
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
