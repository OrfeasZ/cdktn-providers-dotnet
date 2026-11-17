using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.ActionGatewayEndpoint
{
    [JsiiByValue(fqn: "digitalocean.actionGatewayEndpoint.ActionGatewayEndpointVersionPolicy")]
    public class ActionGatewayEndpointVersionPolicy : digitalocean.ActionGatewayEndpoint.IActionGatewayEndpointVersionPolicy
    {
        /// <summary>Action for calls no rule matches: allow, ask, or deny. Empty means ask.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.108.0/docs/resources/action_gateway_endpoint#default_action ActionGatewayEndpoint#default_action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "defaultAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultAction
        {
            get;
            set;
        }

        private object? _rules;

        /// <summary>rules block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.108.0/docs/resources/action_gateway_endpoint#rules ActionGatewayEndpoint#rules}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.ActionGatewayEndpoint.IActionGatewayEndpointVersionPolicyRules" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.actionGatewayEndpoint.ActionGatewayEndpointVersionPolicyRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Rules
        {
            get => _rules;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case digitalocean.ActionGatewayEndpoint.IActionGatewayEndpointVersionPolicyRules[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.ActionGatewayEndpoint.IActionGatewayEndpointVersionPolicyRules).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _rules = value;
            }
        }
    }
}
