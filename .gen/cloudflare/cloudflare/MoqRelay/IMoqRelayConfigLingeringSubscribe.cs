using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.MoqRelay
{
    [JsiiInterface(nativeType: typeof(IMoqRelayConfigLingeringSubscribe), fullyQualifiedName: "cloudflare.moqRelay.MoqRelayConfigLingeringSubscribe")]
    public interface IMoqRelayConfigLingeringSubscribe
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/moq_relay#enabled MoqRelay#enabled}.</summary>
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

        /// <summary>Relay-level ceiling on lingering subscribe timeout (ms). Default 30000.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/moq_relay#max_timeout_ms MoqRelay#max_timeout_ms}
        /// </remarks>
        [JsiiProperty(name: "maxTimeoutMs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxTimeoutMs
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMoqRelayConfigLingeringSubscribe), fullyQualifiedName: "cloudflare.moqRelay.MoqRelayConfigLingeringSubscribe")]
        internal sealed class _Proxy : DeputyBase, cloudflare.MoqRelay.IMoqRelayConfigLingeringSubscribe
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/moq_relay#enabled MoqRelay#enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Relay-level ceiling on lingering subscribe timeout (ms). Default 30000.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/moq_relay#max_timeout_ms MoqRelay#max_timeout_ms}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxTimeoutMs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxTimeoutMs
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
