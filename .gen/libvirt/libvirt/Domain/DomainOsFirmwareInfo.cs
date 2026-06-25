using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainOsFirmwareInfo")]
    public class DomainOsFirmwareInfo : libvirt.Domain.IDomainOsFirmwareInfo
    {
        private object? _features;

        /// <summary>Configures one or more firmware features to be exposed to the guest firmware/boot environment;</summary>
        /// <remarks>
        /// each entry corresponds to a single feature toggle, with semantics defined by the underlying firmware implementation.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#operating-system-booting">https://libvirt.org/formatdomain.html#operating-system-booting</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#features Domain#features}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainOsFirmwareInfoFeatures" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "features", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainOsFirmwareInfoFeatures\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Features
        {
            get => _features;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainOsFirmwareInfoFeatures[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainOsFirmwareInfoFeatures).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _features = value;
            }
        }
    }
}
