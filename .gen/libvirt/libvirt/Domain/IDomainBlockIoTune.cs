using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainBlockIoTune), fullyQualifiedName: "libvirt.domain.DomainBlockIoTune")]
    public interface IDomainBlockIoTune
    {
        /// <summary>Defines per-block-device I/O tuning parameters, each entry targeting a specific backing device by path.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#device Domain#device}
        /// </remarks>
        [JsiiProperty(name: "device", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainBlockIoTuneDevice\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Device
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the global blkio weight for the domain’s I/O, as an integer in the valid blkio weight range (typically 100–1000), affecting its proportional share relative to other domains.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#weight Domain#weight}
        /// </remarks>
        [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Weight
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainBlockIoTune), fullyQualifiedName: "libvirt.domain.DomainBlockIoTune")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainBlockIoTune
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Defines per-block-device I/O tuning parameters, each entry targeting a specific backing device by path.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#device Domain#device}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "device", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainBlockIoTuneDevice\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Device
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Sets the global blkio weight for the domain’s I/O, as an integer in the valid blkio weight range (typically 100–1000), affecting its proportional share relative to other domains.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#block-i-o-tuning">https://libvirt.org/formatdomain.html#block-i-o-tuning</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#weight Domain#weight}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Weight
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
