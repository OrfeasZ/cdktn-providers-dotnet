using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesGraphicsSpice")]
    public class DomainDevicesGraphicsSpice : libvirt.Domain.IDomainDevicesGraphicsSpice
    {
        private object? _autoPort;

        /// <summary>Controls whether libvirt automatically selects the SPICE TCP port;</summary>
        /// <remarks>
        /// this is a yes/no flag encoded as "yes" for true and "no" for false.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#auto_port Domain#auto_port}
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

        private object? _channel;

        /// <summary>Defines an individual SPICE channel (such as "main" or "cursor") and its connection mode.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#channel Domain#channel}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesGraphicsSpiceChannel" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "channel", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpiceChannel\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Channel
        {
            get => _channel;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainDevicesGraphicsSpiceChannel[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesGraphicsSpiceChannel).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _channel = value;
            }
        }

        /// <summary>Enables configuration of clipboard sharing behavior between the SPICE client and the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#clip_board Domain#clip_board}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clipBoard", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpiceClipBoard\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesGraphicsSpiceClipBoard? ClipBoard
        {
            get;
            set;
        }

        /// <summary>Sets whether clients are allowed to connect at VM startup ("yes") or only later ("no"); accepts "yes" or "no".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#connected Domain#connected}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connected", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Connected
        {
            get;
            set;
        }

        /// <summary>Specifies the default connection mode for SPICE (for example, "any", "secure", or "insecure");</summary>
        /// <remarks>
        /// the value is user-provided but must be a mode supported by SPICE.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#default_mode Domain#default_mode}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "defaultMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultMode
        {
            get;
            set;
        }

        /// <summary>Enables configuration of file transfer support between the SPICE client and the guest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#file_transfer Domain#file_transfer}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fileTransfer", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpiceFileTransfer\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesGraphicsSpiceFileTransfer? FileTransfer
        {
            get;
            set;
        }

        /// <summary>Enables configuration of OpenGL/3D rendering for the SPICE graphics backend.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#gl Domain#gl}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "gl", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpiceGl\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesGraphicsSpiceGl? Gl
        {
            get;
            set;
        }

        /// <summary>Enables configuration of SPICE image encoding options;</summary>
        /// <remarks>
        /// presence of this block allows tuning of how screen images are compressed before being sent to the client.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#image Domain#image}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "image", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpiceImage\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesGraphicsSpiceImage? Image
        {
            get;
            set;
        }

        /// <summary>Enables configuration of SPICE JPEG encoding behavior;</summary>
        /// <remarks>
        /// presence of this block allows controlling whether and how JPEG compression is used for images.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#jpeg Domain#jpeg}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "jpeg", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpiceJpeg\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesGraphicsSpiceJpeg? Jpeg
        {
            get;
            set;
        }

        /// <summary>Sets the keyboard layout name SPICE reports to the guest, such as `en-us` or `de`, to control key mapping behavior (value is user-provided).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#keymap Domain#keymap}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "keymap", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Keymap
        {
            get;
            set;
        }

        /// <summary>Sets a legacy listen address for the SPICE server;</summary>
        /// <remarks>
        /// use of this attribute is generally superseded by the more detailed <c>listeners</c> configuration (value is user-provided IP/host or <c>0.0.0.0</c>).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#listen Domain#listen}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "listen", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Listen
        {
            get;
            set;
        }

        private object? _listeners;

        /// <summary>Configures one or more SPICE listen endpoints (TCP address, libvirt network, or UNIX socket) through nested listener blocks.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#listeners Domain#listeners}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesGraphicsSpiceListeners" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "listeners", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpiceListeners\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainDevicesGraphicsSpiceListeners[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesGraphicsSpiceListeners).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _listeners = value;
            }
        }

        /// <summary>Enables configuration of SPICE mouse handling behavior; presence of this block allows setting the mouse mode.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#mouse Domain#mouse}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mouse", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpiceMouse\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesGraphicsSpiceMouse? Mouse
        {
            get;
            set;
        }

        /// <summary>Sets a simple password string required for SPICE client connections to this guest (value is user-provided and should follow your security policies).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#passwd Domain#passwd}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "passwd", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Passwd
        {
            get;
            set;
        }

        /// <summary>Sets an expiration timestamp for the SPICE password, using a libvirt-supported date/time format (for example `2010-04-19T12:00:00`).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#passwd_valid_to Domain#passwd_valid_to}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "passwdValidTo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PasswdValidTo
        {
            get;
            set;
        }

        /// <summary>Enables configuration of SPICE audio playback behavior;</summary>
        /// <remarks>
        /// presence of this block allows controlling whether audio output to the client is enabled or tuned.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#playback Domain#playback}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "playback", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpicePlayback\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesGraphicsSpicePlayback? Playback
        {
            get;
            set;
        }

        /// <summary>Sets the TCP port on which the SPICE server listens for unencrypted connections;</summary>
        /// <remarks>
        /// value is a user-provided integer in the valid TCP port range.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#port Domain#port}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Port
        {
            get;
            set;
        }

        /// <summary>Enables SPICE streaming configuration, allowing control of how guest display frames are streamed to the client.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#streaming Domain#streaming}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "streaming", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpiceStreaming\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesGraphicsSpiceStreaming? Streaming
        {
            get;
            set;
        }

        /// <summary>Sets the TCP port on which the SPICE server listens for TLS-encrypted connections;</summary>
        /// <remarks>
        /// value is a user-provided integer in the valid TCP port range.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#graphical-framebuffers">https://libvirt.org/formatdomain.html#graphical-framebuffers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#tls_port Domain#tls_port}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tlsPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TlsPort
        {
            get;
            set;
        }

        /// <summary>Enables separate configuration of SPICE image compression using zlib for the display channel.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#zlib Domain#zlib}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "zlib", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesGraphicsSpiceZlib\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesGraphicsSpiceZlib? Zlib
        {
            get;
            set;
        }
    }
}
