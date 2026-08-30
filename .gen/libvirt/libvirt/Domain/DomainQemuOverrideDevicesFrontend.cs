using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainQemuOverrideDevicesFrontend")]
    public class DomainQemuOverrideDevicesFrontend : libvirt.Domain.IDomainQemuOverrideDevicesFrontend
    {
        private object? _properties;

        /// <summary>Lists individual QEMU frontend properties to override on the selected device.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#properties Domain#properties}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainQemuOverrideDevicesFrontendProperties" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "properties", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainQemuOverrideDevicesFrontendProperties\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Properties
        {
            get => _properties;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainQemuOverrideDevicesFrontendProperties[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainQemuOverrideDevicesFrontendProperties).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _properties = value;
            }
        }
    }
}
