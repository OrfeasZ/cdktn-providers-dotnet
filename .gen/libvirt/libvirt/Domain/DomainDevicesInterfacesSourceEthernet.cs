using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesInterfacesSourceEthernet")]
    public class DomainDevicesInterfacesSourceEthernet : libvirt.Domain.IDomainDevicesInterfacesSourceEthernet
    {
        private object? _ip;

        /// <summary>Configures an IP address to assign inside the guest for this ethernet interface, including address, family, prefix, and optional peer.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#ip-configuration">https://libvirt.org/formatdomain.html#ip-configuration</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#ip Domain#ip}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesInterfacesSourceEthernetIp" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ip", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceEthernetIp\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Ip
        {
            get => _ip;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainDevicesInterfacesSourceEthernetIp[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesInterfacesSourceEthernetIp).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ip = value;
            }
        }

        private object? _route;

        /// <summary>Defines a static route associated with this ethernet interface inside the guest, including destination, gateway, and optional metric or netmask/prefix.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#ip-configuration">https://libvirt.org/formatdomain.html#ip-configuration</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#route Domain#route}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesInterfacesSourceEthernetRoute" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "route", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceEthernetRoute\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Route
        {
            get => _route;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainDevicesInterfacesSourceEthernetRoute[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesInterfacesSourceEthernetRoute).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _route = value;
            }
        }
    }
}
