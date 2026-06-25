using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesSmartcards")]
    public class DomainDevicesSmartcards : libvirt.Domain.IDomainDevicesSmartcards
    {
        /// <summary>Configures ACPI Error Record Serialization Table (ERST) parameters associated with the pstore device for recording crash logs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#acpi Domain#acpi}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "acpi", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesSmartcardsAcpi\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesSmartcardsAcpi? Acpi
        {
            get;
            set;
        }

        /// <summary>Specifies the guest bus address at which the pstore device is attached (bus/slot/function details), if the hypervisor allows explicit placement.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#address Domain#address}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesSmartcardsAddress\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesSmartcardsAddress? Address
        {
            get;
            set;
        }

        /// <summary>Assigns an internal alias object to the pstore device, which can be used by management tooling to reference the device.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#alias Domain#alias}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "alias", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesSmartcardsAlias\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesSmartcardsAlias? Alias
        {
            get;
            set;
        }

        /// <summary>Sets the NSS database directory used for the smartcard’s certificate store; value is a user-provided path such as `/etc/pki/nssdb`.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#smartcard-devices">https://libvirt.org/formatdomain.html#smartcard-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#database Domain#database}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "database", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Database
        {
            get;
            set;
        }

        private object? _host;

        /// <summary>Enables the host-certificates smartcard mode when set (element is present), so the guest uses certificates from the host’s smartcard database.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#smartcard-devices">https://libvirt.org/formatdomain.html#smartcard-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#host Domain#host}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "host", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Host
        {
            get => _host;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _host = value;
            }
        }

        private object? _hostCerts;

        /// <summary>Lists one or more certificate files that should be exposed to the guest when using host-certificates smartcard mode.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#smartcard-devices">https://libvirt.org/formatdomain.html#smartcard-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#host_certs Domain#host_certs}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesSmartcardsHostCerts" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hostCerts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesSmartcardsHostCerts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? HostCerts
        {
            get => _hostCerts;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainDevicesSmartcardsHostCerts[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesSmartcardsHostCerts).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _hostCerts = value;
            }
        }

        /// <summary>Defines the source endpoint for the EGD backend, such as a socket path or network address, depending on the chosen protocol.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#passthrough Domain#passthrough}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "passthrough", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesSmartcardsPassthrough\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesSmartcardsPassthrough? Passthrough
        {
            get;
            set;
        }

        /// <summary>Configures the transport protocol used by the EGD backend connection.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#protocol Domain#protocol}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "protocol", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesSmartcardsProtocol\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesSmartcardsProtocol? Protocol
        {
            get;
            set;
        }
    }
}
