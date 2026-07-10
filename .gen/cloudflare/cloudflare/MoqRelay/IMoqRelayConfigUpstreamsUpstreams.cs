using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.MoqRelay
{
    [JsiiInterface(nativeType: typeof(IMoqRelayConfigUpstreamsUpstreams), fullyQualifiedName: "cloudflare.moqRelay.MoqRelayConfigUpstreamsUpstreams")]
    public interface IMoqRelayConfigUpstreamsUpstreams
    {
        /// <summary>Upstream MOQT server publisher URL.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/moq_relay#url MoqRelay#url}
        /// </remarks>
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Url
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMoqRelayConfigUpstreamsUpstreams), fullyQualifiedName: "cloudflare.moqRelay.MoqRelayConfigUpstreamsUpstreams")]
        internal sealed class _Proxy : DeputyBase, cloudflare.MoqRelay.IMoqRelayConfigUpstreamsUpstreams
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Upstream MOQT server publisher URL.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/moq_relay#url MoqRelay#url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Url
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
