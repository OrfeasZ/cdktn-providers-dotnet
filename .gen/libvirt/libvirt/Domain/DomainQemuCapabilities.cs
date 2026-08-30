using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainQemuCapabilities")]
    public class DomainQemuCapabilities : libvirt.Domain.IDomainQemuCapabilities
    {
        private object? _add;

        /// <summary>Lists QEMU capabilities to add explicitly for this domain.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#add Domain#add}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainQemuCapabilitiesAdd" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "add", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainQemuCapabilitiesAdd\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Add
        {
            get => _add;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainQemuCapabilitiesAdd[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainQemuCapabilitiesAdd).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _add = value;
            }
        }

        private object? _del;

        /// <summary>Lists QEMU capabilities to remove explicitly for this domain.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#del Domain#del}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainQemuCapabilitiesDel" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "del", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainQemuCapabilitiesDel\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Del
        {
            get => _del;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainQemuCapabilitiesDel[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainQemuCapabilitiesDel).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _del = value;
            }
        }
    }
}
