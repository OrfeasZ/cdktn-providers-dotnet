using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesSmartcardsPassthroughDev")]
    public class DomainDevicesSmartcardsPassthroughDev : libvirt.Domain.IDomainDevicesSmartcardsPassthroughDev
    {
        /// <summary>Sets the path to the host character device file used as the EGD entropy source (for example, /dev/urandom);</summary>
        /// <remarks>
        /// this attribute is required when using a dev source.
        ///
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

        private object? _secLabel;

        /// <summary>Configures an optional security label for the device-based EGD entropy source, controlling how host security drivers (e.g. SELinux, DAC) label or treat the device.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#security-label">https://libvirt.org/formatdomain.html#security-label</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#sec_label Domain#sec_label}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesSmartcardsPassthroughDevSecLabel" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secLabel", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesSmartcardsPassthroughDevSecLabel\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainDevicesSmartcardsPassthroughDevSecLabel[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesSmartcardsPassthroughDevSecLabel).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _secLabel = value;
            }
        }
    }
}
