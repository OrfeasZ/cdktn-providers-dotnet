using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.LoadBalancerPool
{
    [JsiiByValue(fqn: "cloudflare.loadBalancerPool.LoadBalancerPoolOrigins")]
    public class LoadBalancerPoolOrigins : cloudflare.LoadBalancerPool.ILoadBalancerPoolOrigins
    {
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
            get;
            set;
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
            get;
            set;
        }

        private object? _enabled;

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
            get => _enabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _enabled = value;
            }
        }

        /// <summary>The request header is used to pass additional information with an HTTP request. Currently supported header is 'Host'.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#header LoadBalancerPool#header}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "header", typeJson: "{\"fqn\":\"cloudflare.loadBalancerPool.LoadBalancerPoolOriginsHeader\"}", isOptional: true)]
        public cloudflare.LoadBalancerPool.ILoadBalancerPoolOriginsHeader? Header
        {
            get;
            set;
        }

        /// <summary>A human-identifiable name for the origin.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#name LoadBalancerPool#name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>The port for upstream connections. A value of 0 means the default port for the protocol will be used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#port LoadBalancerPool#port}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Port
        {
            get;
            set;
        }

        /// <summary>The virtual network subnet ID the origin belongs in. Virtual network must also belong to the account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/load_balancer_pool#virtual_network_id LoadBalancerPool#virtual_network_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "virtualNetworkId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VirtualNetworkId
        {
            get;
            set;
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
            get;
            set;
        }
    }
}
