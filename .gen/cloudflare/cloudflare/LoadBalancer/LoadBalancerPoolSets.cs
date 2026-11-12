using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.LoadBalancer
{
    [JsiiByValue(fqn: "cloudflare.loadBalancer.LoadBalancerPoolSets")]
    public class LoadBalancerPoolSets : cloudflare.LoadBalancer.ILoadBalancerPoolSets
    {
        private object? _disabled;

        /// <summary>Disable this specific pool set. It will no longer be evaluated.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/load_balancer#disabled LoadBalancer#disabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "disabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Disabled
        {
            get => _disabled;
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
                _disabled = value;
            }
        }

        /// <summary>A collection of fields used to directly respond to the client instead of routing to a pool.</summary>
        /// <remarks>
        /// When supplied on a rule, that rule stops further rule evaluation.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/load_balancer#fixed_response LoadBalancer#fixed_response}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fixedResponse", typeJson: "{\"fqn\":\"cloudflare.loadBalancer.LoadBalancerPoolSetsFixedResponse\"}", isOptional: true)]
        public cloudflare.LoadBalancer.ILoadBalancerPoolSetsFixedResponse? FixedResponse
        {
            get;
            set;
        }

        /// <summary>Determines which requests a pool set applies to.</summary>
        /// <remarks>
        /// Set <c>topology</c> to match by location or <c>default: true</c> to match all requests; the two are mutually exclusive. A pool set with no <c>match</c> matches all requests.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/load_balancer#match LoadBalancer#match}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"cloudflare.loadBalancer.LoadBalancerPoolSetsMatch\"}", isOptional: true)]
        public cloudflare.LoadBalancer.ILoadBalancerPoolSetsMatch? Match
        {
            get;
            set;
        }

        /// <summary>A human-readable name for this pool set.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/load_balancer#name LoadBalancer#name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>The behavior a pool set applies when its `match` succeeds.</summary>
        /// <remarks>
        /// A strict subset of a rule's <c>overrides</c>: a pool set replaces the topology wholesale with a flat pool list (<c>pools</c>), so only the declarative pool-routing fields plus <c>fallback_pool</c> and <c>steering_policy</c> are settable. All fields are optional.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/load_balancer#overrides LoadBalancer#overrides}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "overrides", typeJson: "{\"fqn\":\"cloudflare.loadBalancer.LoadBalancerPoolSetsOverrides\"}", isOptional: true)]
        public cloudflare.LoadBalancer.ILoadBalancerPoolSetsOverrides? Overrides
        {
            get;
            set;
        }
    }
}
