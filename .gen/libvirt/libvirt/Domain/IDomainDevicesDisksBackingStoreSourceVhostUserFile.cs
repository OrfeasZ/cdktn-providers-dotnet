using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesDisksBackingStoreSourceVhostUserFile), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksBackingStoreSourceVhostUserFile")]
    public interface IDomainDevicesDisksBackingStoreSourceVhostUserFile
    {
        /// <summary>Sets the filesystem path of the host file used as the EGD entropy source or sink (for example, /var/run/egd.sock or a regular file); this attribute is required when using a file source.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#random-number-generator-device">https://libvirt.org/formatdomain.html#random-number-generator-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#path Domain#path}
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        string Path
        {
            get;
        }

        /// <summary>Controls whether data is appended to the file used by the EGD entropy source instead of truncating it;</summary>
        /// <remarks>
        /// accepts "on"/"off" or "yes"/"no" style values depending on libvirt/qemu expectations.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#device-logfile">https://libvirt.org/formatdomain.html#device-logfile</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#append Domain#append}
        /// </remarks>
        [JsiiProperty(name: "append", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Append
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures an optional security label for the file used by the EGD entropy source, controlling how host security drivers label or constrain access to that file.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#security-label">https://libvirt.org/formatdomain.html#security-label</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#sec_label Domain#sec_label}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesDisksBackingStoreSourceVhostUserFileSecLabel" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "secLabel", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreSourceVhostUserFileSecLabel\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SecLabel
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesDisksBackingStoreSourceVhostUserFile), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksBackingStoreSourceVhostUserFile")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesDisksBackingStoreSourceVhostUserFile
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the filesystem path of the host file used as the EGD entropy source or sink (for example, /var/run/egd.sock or a regular file); this attribute is required when using a file source.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#random-number-generator-device">https://libvirt.org/formatdomain.html#random-number-generator-device</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#path Domain#path}
            /// </remarks>
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
            public string Path
            {
                get => GetInstanceProperty<string>()!;
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
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Configures an optional security label for the file used by the EGD entropy source, controlling how host security drivers label or constrain access to that file.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#security-label">https://libvirt.org/formatdomain.html#security-label</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#sec_label Domain#sec_label}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesDisksBackingStoreSourceVhostUserFileSecLabel" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "secLabel", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksBackingStoreSourceVhostUserFileSecLabel\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SecLabel
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
