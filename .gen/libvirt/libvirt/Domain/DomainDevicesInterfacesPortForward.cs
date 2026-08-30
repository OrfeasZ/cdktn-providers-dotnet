using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesInterfacesPortForward")]
    public class DomainDevicesInterfacesPortForward : libvirt.Domain.IDomainDevicesInterfacesPortForward
    {
        /// <summary>Sets the IP protocol used for the forwarding rule, typically "tcp" or "udp"; value is required and user-provided.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#userspace-connection-using-passt">https://libvirt.org/formatdomain.html#userspace-connection-using-passt</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#proto Domain#proto}
        /// </remarks>
        [JsiiProperty(name: "proto", typeJson: "{\"primitive\":\"string\"}")]
        public string Proto
        {
            get;
            set;
        }

        /// <summary>Sets the host IP address to listen on for forwarded ports; value is user-provided IPv4 or IPv6 address.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#userspace-connection-using-passt">https://libvirt.org/formatdomain.html#userspace-connection-using-passt</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#address Domain#address}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Address
        {
            get;
            set;
        }

        /// <summary>Selects the host network device whose addresses are used as the source for forwarded connections;</summary>
        /// <remarks>
        /// value is a user-provided interface name (for example, "eth0").
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#userspace-connection-using-passt">https://libvirt.org/formatdomain.html#userspace-connection-using-passt</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#dev Domain#dev}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dev", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Dev
        {
            get;
            set;
        }

        private object? _ranges;

        /// <summary>Defines one or more port ranges to forward from host to guest for the selected protocol.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#userspace-connection-using-passt">https://libvirt.org/formatdomain.html#userspace-connection-using-passt</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#ranges Domain#ranges}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesInterfacesPortForwardRanges" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ranges", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesPortForwardRanges\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Ranges
        {
            get => _ranges;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainDevicesInterfacesPortForwardRanges[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesInterfacesPortForwardRanges).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ranges = value;
            }
        }
    }
}
