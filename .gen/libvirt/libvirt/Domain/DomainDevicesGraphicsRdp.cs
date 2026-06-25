using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesGraphicsRdp")]
    public class DomainDevicesGraphicsRdp : libvirt.Domain.IDomainDevicesGraphicsRdp
    {
        private object? _autoPort;

        /// <summary>Controls whether the RDP server port is chosen automatically ("yes") or must be specified explicitly ("no");</summary>
        /// <remarks>
        /// this is a string-to-boolean flag.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#auto_port Domain#auto_port}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "autoPort", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? AutoPort
        {
            get => _autoPort;
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
                _autoPort = value;
            }
        }

        /// <summary>Sets a single listen address or special value (such as "0.0.0.0") for the RDP server; value is user-provided and used when listener sub-elements are not used.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#listen Domain#listen}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "listen", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Listen
        {
            get;
            set;
        }

        private object? _listeners;

        /// <summary>Defines one or more listener endpoints for the RDP server (by address, network, or UNIX socket), overriding the simple listen attribute when present.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#listeners Domain#listeners}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesGraphicsRdpListeners" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "listeners", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsRdpListeners\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Listeners
        {
            get => _listeners;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainDevicesGraphicsRdpListeners[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesGraphicsRdpListeners).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _listeners = value;
            }
        }

        /// <summary>Controls whether the RDP server allows multiple simultaneous clients ("yes") or restricts access to a single client ("no");</summary>
        /// <remarks>
        /// the value is user-provided as "yes"/"no".
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#multi_user Domain#multi_user}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "multiUser", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MultiUser
        {
            get;
            set;
        }

        /// <summary>Sets the password required to connect to the RDP server;</summary>
        /// <remarks>
        /// the value is user-provided and may be empty to allow passwordless access, depending on hypervisor policy.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#passwd Domain#passwd}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "passwd", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Passwd
        {
            get;
            set;
        }

        /// <summary>Sets the TCP port number on which the RDP server listens (for example, 3389);</summary>
        /// <remarks>
        /// must be a valid unused TCP port when auto_port is "no".
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#port Domain#port}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Port
        {
            get;
            set;
        }

        /// <summary>Controls whether a new RDP client connection replaces the currently connected user ("yes") or is refused when a client is already connected ("no");</summary>
        /// <remarks>
        /// value is user-provided as "yes"/"no".
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#replace_user Domain#replace_user}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "replaceUser", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReplaceUser
        {
            get;
            set;
        }

        /// <summary>Sets the username used by the RDP graphics backend for client authentication; the value is user-provided and backend-specific.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#username Domain#username}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Username
        {
            get;
            set;
        }
    }
}
