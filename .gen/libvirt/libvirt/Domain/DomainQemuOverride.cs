using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainQemuOverride")]
    public class DomainQemuOverride : libvirt.Domain.IDomainQemuOverride
    {
        private object? _devices;

        /// <summary>Lists device-specific QEMU overrides, each matched by device alias and carrying frontend property overrides.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#devices Domain#devices}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainQemuOverrideDevices" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "devices", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainQemuOverrideDevices\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Devices
        {
            get => _devices;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainQemuOverrideDevices[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainQemuOverrideDevices).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _devices = value;
            }
        }
    }
}
