using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesDisksMirrorBackingStoreSourceReservations), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceReservations")]
    public interface IDomainDevicesDisksMirrorBackingStoreSourceReservations
    {
        /// <summary>Controls whether persistent reservations are enabled for the mirrored disk’s backing-store source;</summary>
        /// <remarks>
        /// value is user-provided and typically expects "yes" or "no" semantics per libvirt.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#enabled Domain#enabled}
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Indicates whether reservations are managed by libvirt ("yes") or externally ("no");</summary>
        /// <remarks>
        /// value is provided as a string and translated to a boolean, with "yes" meaning true and "no" meaning false.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#managed Domain#managed}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "managed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Managed
        {
            get
            {
                return null;
            }
        }

        /// <summary>Selects the mechanism used to provide reservation control for the mirrored backing-store source, such as a D-Bus service or a device/file endpoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#source Domain#source}
        /// </remarks>
        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceReservationsSource? Source
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesDisksMirrorBackingStoreSourceReservations), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceReservations")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceReservations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Controls whether persistent reservations are enabled for the mirrored disk’s backing-store source;</summary>
            /// <remarks>
            /// value is user-provided and typically expects "yes" or "no" semantics per libvirt.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#enabled Domain#enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Enabled
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Indicates whether reservations are managed by libvirt ("yes") or externally ("no");</summary>
            /// <remarks>
            /// value is provided as a string and translated to a boolean, with "yes" meaning true and "no" meaning false.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#managed Domain#managed}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "managed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Managed
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Selects the mechanism used to provide reservation control for the mirrored backing-store source, such as a D-Bus service or a device/file endpoint.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#source Domain#source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSource\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceReservationsSource? Source
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceReservationsSource?>();
            }
        }
    }
}
