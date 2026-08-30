using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesControllersVirtIoSerial), fullyQualifiedName: "libvirt.domain.DomainDevicesControllersVirtIoSerial")]
    public interface IDomainDevicesControllersVirtIoSerial
    {
        /// <summary>Sets the maximum number of virtio-serial ports that this controller can provide; value is a user-provided positive integer.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#controllers">https://libvirt.org/formatdomain.html#controllers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#ports Domain#ports}
        /// </remarks>
        [JsiiProperty(name: "ports", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Ports
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the number of MSI/MSI‑X vectors used by the virtio-serial controller for interrupts; value is a user-provided positive integer.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#controllers">https://libvirt.org/formatdomain.html#controllers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#vectors Domain#vectors}
        /// </remarks>
        [JsiiProperty(name: "vectors", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Vectors
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesControllersVirtIoSerial), fullyQualifiedName: "libvirt.domain.DomainDevicesControllersVirtIoSerial")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesControllersVirtIoSerial
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the maximum number of virtio-serial ports that this controller can provide; value is a user-provided positive integer.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#controllers">https://libvirt.org/formatdomain.html#controllers</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#ports Domain#ports}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ports", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Ports
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the number of MSI/MSI‑X vectors used by the virtio-serial controller for interrupts; value is a user-provided positive integer.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#controllers">https://libvirt.org/formatdomain.html#controllers</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#vectors Domain#vectors}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vectors", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Vectors
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
