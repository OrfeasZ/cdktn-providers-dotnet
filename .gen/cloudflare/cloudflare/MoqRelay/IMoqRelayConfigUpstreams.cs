using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.MoqRelay
{
    [JsiiInterface(nativeType: typeof(IMoqRelayConfigUpstreams), fullyQualifiedName: "cloudflare.moqRelay.MoqRelayConfigUpstreams")]
    public interface IMoqRelayConfigUpstreams
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/moq_relay#enabled MoqRelay#enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
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

        /// <summary>Ordered list of upstream MOQT server publishers.</summary>
        /// <remarks>
        /// Each entry is an
        /// object (not a bare string) so per-upstream configuration can be
        /// added in the future without another breaking change.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/moq_relay#upstreams MoqRelay#upstreams}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="cloudflare.MoqRelay.IMoqRelayConfigUpstreamsUpstreams" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "upstreams", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.moqRelay.MoqRelayConfigUpstreamsUpstreams\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Upstreams
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMoqRelayConfigUpstreams), fullyQualifiedName: "cloudflare.moqRelay.MoqRelayConfigUpstreams")]
        internal sealed class _Proxy : DeputyBase, cloudflare.MoqRelay.IMoqRelayConfigUpstreams
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/moq_relay#enabled MoqRelay#enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Ordered list of upstream MOQT server publishers.</summary>
            /// <remarks>
            /// Each entry is an
            /// object (not a bare string) so per-upstream configuration can be
            /// added in the future without another breaking change.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/moq_relay#upstreams MoqRelay#upstreams}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="cloudflare.MoqRelay.IMoqRelayConfigUpstreamsUpstreams" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "upstreams", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.moqRelay.MoqRelayConfigUpstreamsUpstreams\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Upstreams
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
