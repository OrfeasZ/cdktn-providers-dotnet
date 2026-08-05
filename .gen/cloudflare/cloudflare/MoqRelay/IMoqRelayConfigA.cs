using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.MoqRelay
{
    [JsiiInterface(nativeType: typeof(IMoqRelayConfigA), fullyQualifiedName: "cloudflare.moqRelay.MoqRelayConfigA")]
    public interface IMoqRelayConfigA
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/moq_relay#lingering_subscribe MoqRelay#lingering_subscribe}.</summary>
        [JsiiProperty(name: "lingeringSubscribe", typeJson: "{\"fqn\":\"cloudflare.moqRelay.MoqRelayConfigLingeringSubscribe\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.MoqRelay.IMoqRelayConfigLingeringSubscribe? LingeringSubscribe
        {
            get
            {
                return null;
            }
        }

        /// <summary>Upstreams are external MOQT server publishers that a relay falls back to when it has no local publisher for a requested namespace/track.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/moq_relay#upstreams MoqRelay#upstreams}
        /// </remarks>
        [JsiiProperty(name: "upstreams", typeJson: "{\"fqn\":\"cloudflare.moqRelay.MoqRelayConfigUpstreams\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.MoqRelay.IMoqRelayConfigUpstreams? Upstreams
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMoqRelayConfigA), fullyQualifiedName: "cloudflare.moqRelay.MoqRelayConfigA")]
        internal sealed class _Proxy : DeputyBase, cloudflare.MoqRelay.IMoqRelayConfigA
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/moq_relay#lingering_subscribe MoqRelay#lingering_subscribe}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lingeringSubscribe", typeJson: "{\"fqn\":\"cloudflare.moqRelay.MoqRelayConfigLingeringSubscribe\"}", isOptional: true)]
            public cloudflare.MoqRelay.IMoqRelayConfigLingeringSubscribe? LingeringSubscribe
            {
                get => GetInstanceProperty<cloudflare.MoqRelay.IMoqRelayConfigLingeringSubscribe?>();
            }

            /// <summary>Upstreams are external MOQT server publishers that a relay falls back to when it has no local publisher for a requested namespace/track.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/moq_relay#upstreams MoqRelay#upstreams}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "upstreams", typeJson: "{\"fqn\":\"cloudflare.moqRelay.MoqRelayConfigUpstreams\"}", isOptional: true)]
            public cloudflare.MoqRelay.IMoqRelayConfigUpstreams? Upstreams
            {
                get => GetInstanceProperty<cloudflare.MoqRelay.IMoqRelayConfigUpstreams?>();
            }
        }
    }
}
