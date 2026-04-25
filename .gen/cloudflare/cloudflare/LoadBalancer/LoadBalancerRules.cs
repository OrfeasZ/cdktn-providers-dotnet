using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.LoadBalancer
{
    [JsiiByValue(fqn: "cloudflare.loadBalancer.LoadBalancerRules")]
    public class LoadBalancerRules : cloudflare.LoadBalancer.ILoadBalancerRules
    {
        /// <summary>The condition expressions to evaluate.</summary>
        /// <remarks>
        /// If the condition evaluates to true, the overrides or fixed_response in this rule will be applied. An empty condition is always true. For more details on condition expressions, please see https://developers.cloudflare.com/load-balancing/understand-basics/load-balancing-rules/expressions.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/load_balancer#condition LoadBalancer#condition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "condition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Condition
        {
            get;
            set;
        }

        private object? _disabled;

        /// <summary>Disable this specific rule. It will no longer be evaluated by this load balancer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/load_balancer#disabled LoadBalancer#disabled}
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

        /// <summary>A collection of fields used to directly respond to the eyeball instead of routing to a pool.</summary>
        /// <remarks>
        /// If a fixed_response is supplied the rule will be marked as terminates.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/load_balancer#fixed_response LoadBalancer#fixed_response}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fixedResponse", typeJson: "{\"fqn\":\"cloudflare.loadBalancer.LoadBalancerRulesFixedResponse\"}", isOptional: true)]
        public cloudflare.LoadBalancer.ILoadBalancerRulesFixedResponse? FixedResponse
        {
            get;
            set;
        }

        /// <summary>Name of this rule. Only used for human readability.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/load_balancer#name LoadBalancer#name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>A collection of overrides to apply to the load balancer when this rule's condition is true.</summary>
        /// <remarks>
        /// All fields are optional.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/load_balancer#overrides LoadBalancer#overrides}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "overrides", typeJson: "{\"fqn\":\"cloudflare.loadBalancer.LoadBalancerRulesOverrides\"}", isOptional: true)]
        public cloudflare.LoadBalancer.ILoadBalancerRulesOverrides? Overrides
        {
            get;
            set;
        }

        /// <summary>The order in which rules should be executed in relation to each other.</summary>
        /// <remarks>
        /// Lower values are executed first. Values do not need to be sequential. If no value is provided for any rule the array order of the rules field will be used to assign a priority.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/load_balancer#priority LoadBalancer#priority}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Priority
        {
            get;
            set;
        }

        private object? _terminates;

        /// <summary>If this rule's condition is true, this causes rule evaluation to stop after processing this rule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/load_balancer#terminates LoadBalancer#terminates}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "terminates", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Terminates
        {
            get => _terminates;
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
                _terminates = value;
            }
        }
    }
}
