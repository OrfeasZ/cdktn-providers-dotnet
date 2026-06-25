using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesDisksSourceVhostUserDev), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksSourceVhostUserDev")]
    public interface IDomainDevicesDisksSourceVhostUserDev
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
        string Path
        {
            get;
        }

        /// <summary>Configures an optional security label for the device-based EGD entropy source, controlling how host security drivers (e.g. SELinux, DAC) label or treat the device.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#security-label">https://libvirt.org/formatdomain.html#security-label</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#sec_label Domain#sec_label}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesDisksSourceVhostUserDevSecLabel" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "secLabel", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceVhostUserDevSecLabel\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SecLabel
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesDisksSourceVhostUserDev), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksSourceVhostUserDev")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesDisksSourceVhostUserDev
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

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
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Configures an optional security label for the device-based EGD entropy source, controlling how host security drivers (e.g. SELinux, DAC) label or treat the device.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#security-label">https://libvirt.org/formatdomain.html#security-label</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#sec_label Domain#sec_label}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesDisksSourceVhostUserDevSecLabel" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "secLabel", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceVhostUserDevSecLabel\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SecLabel
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
