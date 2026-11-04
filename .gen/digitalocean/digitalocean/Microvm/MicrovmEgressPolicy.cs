using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.Microvm
{
    [JsiiByValue(fqn: "digitalocean.microvm.MicrovmEgressPolicy")]
    public class MicrovmEgressPolicy : digitalocean.Microvm.IMicrovmEgressPolicy
    {
        /// <summary>What to do with a destination no rule matches: 'deny' or 'allow'. Defaults to 'deny'.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/microvm#default_action Microvm#default_action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "defaultAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultAction
        {
            get;
            set;
        }

        private object? _rule;

        /// <summary>rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/microvm#rule Microvm#rule}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.Microvm.IMicrovmEgressPolicyRule" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.microvm.MicrovmEgressPolicyRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Rule
        {
            get => _rule;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case digitalocean.Microvm.IMicrovmEgressPolicyRule[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.Microvm.IMicrovmEgressPolicyRule).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _rule = value;
            }
        }
    }
}
