using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.MoqRelay
{
    [JsiiByValue(fqn: "cloudflare.moqRelay.MoqRelayConfigUpstreams")]
    public class MoqRelayConfigUpstreams : cloudflare.MoqRelay.IMoqRelayConfigUpstreams
    {
        private object? _enabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/moq_relay#enabled MoqRelay#enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Enabled
        {
            get => _enabled;
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
                _enabled = value;
            }
        }

        private object? _upstreams;

        /// <summary>Ordered list of upstream MOQT server publishers.</summary>
        /// <remarks>
        /// Each entry is an
        /// object (not a bare string) so per-upstream configuration can be
        /// added in the future without another breaking change.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/moq_relay#upstreams MoqRelay#upstreams}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="cloudflare.MoqRelay.IMoqRelayConfigUpstreamsUpstreams" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "upstreams", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.moqRelay.MoqRelayConfigUpstreamsUpstreams\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Upstreams
        {
            get => _upstreams;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.MoqRelay.IMoqRelayConfigUpstreamsUpstreams[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.MoqRelay.IMoqRelayConfigUpstreamsUpstreams).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _upstreams = value;
            }
        }
    }
}
