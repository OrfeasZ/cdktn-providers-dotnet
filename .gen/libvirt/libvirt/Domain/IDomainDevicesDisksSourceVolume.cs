using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesDisksSourceVolume), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksSourceVolume")]
    public interface IDomainDevicesDisksSourceVolume
    {
        /// <summary>Sets the access mode with which the storage volume is used as the backingStore source (for example, "readOnly" or "readWrite" depending on driver support);</summary>
        /// <remarks>
        /// the value is user-provided.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#mode Domain#mode}
        /// </remarks>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Mode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Names the storage pool that contains the backing storage volume used as the mirror backingStore source;</summary>
        /// <remarks>
        /// must match an existing libvirt storage pool name.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#pool Domain#pool}
        /// </remarks>
        [JsiiProperty(name: "pool", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Pool
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures an optional security label override applied to the backing storage volume used as the mirror backingStore source.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#security-label">https://libvirt.org/formatdomain.html#security-label</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#sec_label Domain#sec_label}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesDisksSourceVolumeSecLabel" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "secLabel", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceVolumeSecLabel\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SecLabel
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the name of the storage volume within the specified pool that is used as the backingStore source for the mirrored disk.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#volume Domain#volume}
        /// </remarks>
        [JsiiProperty(name: "volume", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Volume
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesDisksSourceVolume), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksSourceVolume")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesDisksSourceVolume
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the access mode with which the storage volume is used as the backingStore source (for example, "readOnly" or "readWrite" depending on driver support);</summary>
            /// <remarks>
            /// the value is user-provided.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#mode Domain#mode}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Mode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Names the storage pool that contains the backing storage volume used as the mirror backingStore source;</summary>
            /// <remarks>
            /// must match an existing libvirt storage pool name.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#pool Domain#pool}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pool", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Pool
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Configures an optional security label override applied to the backing storage volume used as the mirror backingStore source.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#security-label">https://libvirt.org/formatdomain.html#security-label</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#sec_label Domain#sec_label}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesDisksSourceVolumeSecLabel" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "secLabel", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesDisksSourceVolumeSecLabel\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SecLabel
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Sets the name of the storage volume within the specified pool that is used as the backingStore source for the mirrored disk.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#volume Domain#volume}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "volume", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Volume
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
