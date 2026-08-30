using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesDisksSourceNetworkReconnect), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksSourceNetworkReconnect")]
    public interface IDomainDevicesDisksSourceNetworkReconnect
    {
        /// <summary>Sets the reconnection delay (in seconds) before retrying a failed connection to the mirrored network backing store;</summary>
        /// <remarks>
        /// value is a required user-provided non-negative integer.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#delay Domain#delay}
        /// </remarks>
        [JsiiProperty(name: "delay", typeJson: "{\"primitive\":\"string\"}")]
        string Delay
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesDisksSourceNetworkReconnect), fullyQualifiedName: "libvirt.domain.DomainDevicesDisksSourceNetworkReconnect")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesDisksSourceNetworkReconnect
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the reconnection delay (in seconds) before retrying a failed connection to the mirrored network backing store;</summary>
            /// <remarks>
            /// value is a required user-provided non-negative integer.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms">https://libvirt.org/formatdomain.html#hard-drives-floppy-disks-cdroms</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#delay Domain#delay}
            /// </remarks>
            [JsiiProperty(name: "delay", typeJson: "{\"primitive\":\"string\"}")]
            public string Delay
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
