using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainBlockIoTune")]
    public class DomainBlockIoTune : libvirt.Domain.IDomainBlockIoTune
    {
        private object? _device;

        /// <summary>Defines per-block-device I/O tuning parameters, each entry targeting a specific backing device by path.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#device Domain#device}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainBlockIoTuneDevice" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "device", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainBlockIoTuneDevice\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Device
        {
            get => _device;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainBlockIoTuneDevice[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainBlockIoTuneDevice).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _device = value;
            }
        }

        /// <summary>Sets the global blkio weight for the domain’s I/O, as an integer in the valid blkio weight range (typically 100–1000), affecting its proportional share relative to other domains.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#weight Domain#weight}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Weight
        {
            get;
            set;
        }
    }
}
