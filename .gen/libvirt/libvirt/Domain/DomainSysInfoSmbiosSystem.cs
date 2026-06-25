using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainSysInfoSmbiosSystem")]
    public class DomainSysInfoSmbiosSystem : libvirt.Domain.IDomainSysInfoSmbiosSystem
    {
        private object? _entry;

        /// <summary>Defines one custom SMBIOS “system” field entry;</summary>
        /// <remarks>
        /// each entry specifies a field <c>name</c> and either an inline <c>value</c> or a <c>file</c> to read the value from.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#smbios-system-information">https://libvirt.org/formatdomain.html#smbios-system-information</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#entry Domain#entry}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainSysInfoSmbiosSystemEntry" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "entry", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainSysInfoSmbiosSystemEntry\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Entry
        {
            get => _entry;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainSysInfoSmbiosSystemEntry[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainSysInfoSmbiosSystemEntry).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _entry = value;
            }
        }
    }
}
