using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainSysInfoSmbiosProcessor")]
    public class DomainSysInfoSmbiosProcessor : libvirt.Domain.IDomainSysInfoSmbiosProcessor
    {
        private object? _entry;

        /// <summary>Defines a single SMBIOS processor field override, identified by its required name and a user-provided value or file-backed value (for example, customizing processor version or manufacturer).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#smbios-system-information">https://libvirt.org/formatdomain.html#smbios-system-information</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#entry Domain#entry}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "entry", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainSysInfoSmbiosProcessorEntry\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainSysInfoSmbiosProcessorEntry[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainSysInfoSmbiosProcessorEntry).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _entry = value;
            }
        }
    }
}
