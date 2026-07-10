using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.MoqRelay
{
    [JsiiByValue(fqn: "cloudflare.moqRelay.MoqRelayConfigA")]
    public class MoqRelayConfigA : cloudflare.MoqRelay.IMoqRelayConfigA
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/moq_relay#lingering_subscribe MoqRelay#lingering_subscribe}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lingeringSubscribe", typeJson: "{\"fqn\":\"cloudflare.moqRelay.MoqRelayConfigLingeringSubscribe\"}", isOptional: true)]
        public cloudflare.MoqRelay.IMoqRelayConfigLingeringSubscribe? LingeringSubscribe
        {
            get;
            set;
        }

        /// <summary>Upstreams are external MOQT server publishers that a relay falls back to when it has no local publisher for a requested namespace/track.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/moq_relay#upstreams MoqRelay#upstreams}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "upstreams", typeJson: "{\"fqn\":\"cloudflare.moqRelay.MoqRelayConfigUpstreams\"}", isOptional: true)]
        public cloudflare.MoqRelay.IMoqRelayConfigUpstreams? Upstreams
        {
            get;
            set;
        }
    }
}
