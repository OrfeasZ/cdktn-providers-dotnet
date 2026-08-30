using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainOsAcpi")]
    public class DomainOsAcpi : libvirt.Domain.IDomainOsAcpi
    {
        private object? _tables;

        /// <summary>Declares one or more custom ACPI tables to load into the guest, each with a required type and path specifying the table file.</summary>
        /// <remarks>
        /// Multiple entries are allowed.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#common-os-element-configuration">https://libvirt.org/formatdomain.html#common-os-element-configuration</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#tables Domain#tables}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainOsAcpiTables" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tables", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainOsAcpiTables\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Tables
        {
            get => _tables;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainOsAcpiTables[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainOsAcpiTables).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _tables = value;
            }
        }
    }
}
