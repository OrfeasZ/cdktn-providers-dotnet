using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainSysInfoSmbiosBaseBoard")]
    public class DomainSysInfoSmbiosBaseBoard : libvirt.Domain.IDomainSysInfoSmbiosBaseBoard
    {
        private object? _entry;

        /// <summary>Defines one SMBIOS base board field/value pair (for example, product name or serial) that will be visible to the guest via tools like dmidecode.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#smbios-system-information">https://libvirt.org/formatdomain.html#smbios-system-information</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#entry Domain#entry}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainSysInfoSmbiosBaseBoardEntry" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "entry", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainSysInfoSmbiosBaseBoardEntry\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainSysInfoSmbiosBaseBoardEntry[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainSysInfoSmbiosBaseBoardEntry).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _entry = value;
            }
        }
    }
}
