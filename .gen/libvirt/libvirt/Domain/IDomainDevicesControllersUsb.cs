using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesControllersUsb), fullyQualifiedName: "libvirt.domain.DomainDevicesControllersUsb")]
    public interface IDomainDevicesControllersUsb
    {
        /// <summary>Configures the master USB controller relationship, defining how this USB controller is chained or grouped with others.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#master Domain#master}
        /// </remarks>
        [JsiiProperty(name: "master", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesControllersUsbMaster\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesControllersUsbMaster? Master
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the total number of USB ports exposed by this controller; value is a user-provided positive integer.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#controllers">https://libvirt.org/formatdomain.html#controllers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#port Domain#port}
        /// </remarks>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Port
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesControllersUsb), fullyQualifiedName: "libvirt.domain.DomainDevicesControllersUsb")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesControllersUsb
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Configures the master USB controller relationship, defining how this USB controller is chained or grouped with others.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#master Domain#master}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "master", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesControllersUsbMaster\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesControllersUsbMaster? Master
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesControllersUsbMaster?>();
            }

            /// <summary>Sets the total number of USB ports exposed by this controller; value is a user-provided positive integer.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#controllers">https://libvirt.org/formatdomain.html#controllers</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#port Domain#port}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Port
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
