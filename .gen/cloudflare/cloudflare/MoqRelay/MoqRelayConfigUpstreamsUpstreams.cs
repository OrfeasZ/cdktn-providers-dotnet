using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.MoqRelay
{
    [JsiiByValue(fqn: "cloudflare.moqRelay.MoqRelayConfigUpstreamsUpstreams")]
    public class MoqRelayConfigUpstreamsUpstreams : cloudflare.MoqRelay.IMoqRelayConfigUpstreamsUpstreams
    {
        /// <summary>Upstream MOQT server publisher URL.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/moq_relay#url MoqRelay#url}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Url
        {
            get;
            set;
        }
    }
}
