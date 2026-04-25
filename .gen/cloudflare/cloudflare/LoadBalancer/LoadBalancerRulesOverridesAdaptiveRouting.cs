using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.LoadBalancer
{
    [JsiiByValue(fqn: "cloudflare.loadBalancer.LoadBalancerRulesOverridesAdaptiveRouting")]
    public class LoadBalancerRulesOverridesAdaptiveRouting : cloudflare.LoadBalancer.ILoadBalancerRulesOverridesAdaptiveRouting
    {
        private object? _failoverAcrossPools;

        /// <summary>Extends zero-downtime failover of requests to healthy origins from alternate pools, when no healthy alternate exists in the same pool, according to the failover order defined by traffic and origin steering.</summary>
        /// <remarks>
        /// When set false (the default) zero-downtime failover will only occur between origins within the same pool. See <c>session_affinity_attributes</c> for control over when sessions are broken or reassigned.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/load_balancer#failover_across_pools LoadBalancer#failover_across_pools}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "failoverAcrossPools", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? FailoverAcrossPools
        {
            get => _failoverAcrossPools;
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
                _failoverAcrossPools = value;
            }
        }
    }
}
