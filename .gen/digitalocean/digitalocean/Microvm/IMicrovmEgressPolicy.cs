using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.Microvm
{
    [JsiiInterface(nativeType: typeof(IMicrovmEgressPolicy), fullyQualifiedName: "digitalocean.microvm.MicrovmEgressPolicy")]
    public interface IMicrovmEgressPolicy
    {
        /// <summary>What to do with a destination no rule matches: 'deny' or 'allow'. Defaults to 'deny'.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/microvm#default_action Microvm#default_action}
        /// </remarks>
        [JsiiProperty(name: "defaultAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultAction
        {
            get
            {
                return null;
            }
        }

        /// <summary>rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/microvm#rule Microvm#rule}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.Microvm.IMicrovmEgressPolicyRule" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "rule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.microvm.MicrovmEgressPolicyRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Rule
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMicrovmEgressPolicy), fullyQualifiedName: "digitalocean.microvm.MicrovmEgressPolicy")]
        internal sealed class _Proxy : DeputyBase, digitalocean.Microvm.IMicrovmEgressPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>What to do with a destination no rule matches: 'deny' or 'allow'. Defaults to 'deny'.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/microvm#default_action Microvm#default_action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultAction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>rule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/microvm#rule Microvm#rule}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.Microvm.IMicrovmEgressPolicyRule" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.microvm.MicrovmEgressPolicyRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Rule
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
