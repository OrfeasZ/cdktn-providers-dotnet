using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesRedirDevsSourceFile")]
    public class DomainDevicesRedirDevsSourceFile : libvirt.Domain.IDomainDevicesRedirDevsSourceFile
    {
        /// <summary>Sets the filesystem path of the host file used as the EGD entropy source or sink (for example, /var/run/egd.sock or a regular file); this attribute is required when using a file source.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#random-number-generator-device">https://libvirt.org/formatdomain.html#random-number-generator-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#path Domain#path}
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public string Path
        {
            get;
            set;
        }

        /// <summary>Controls whether data is appended to the file used by the EGD entropy source instead of truncating it;</summary>
        /// <remarks>
        /// accepts "on"/"off" or "yes"/"no" style values depending on libvirt/qemu expectations.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#device-logfile">https://libvirt.org/formatdomain.html#device-logfile</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#append Domain#append}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "append", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Append
        {
            get;
            set;
        }

        private object? _secLabel;

        /// <summary>Configures an optional security label for the file used by the EGD entropy source, controlling how host security drivers label or constrain access to that file.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#security-label">https://libvirt.org/formatdomain.html#security-label</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#sec_label Domain#sec_label}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secLabel", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesRedirDevsSourceFileSecLabel\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SecLabel
        {
            get => _secLabel;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainDevicesRedirDevsSourceFileSecLabel[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesRedirDevsSourceFileSecLabel).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _secLabel = value;
            }
        }
    }
}
