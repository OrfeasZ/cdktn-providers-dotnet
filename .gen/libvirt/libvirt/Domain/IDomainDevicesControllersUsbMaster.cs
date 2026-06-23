using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesControllersUsbMaster), fullyQualifiedName: "libvirt.domain.DomainDevicesControllersUsbMaster")]
    public interface IDomainDevicesControllersUsbMaster
    {
        /// <summary>Sets the starting port number on the master USB controller that this controller manages;</summary>
        /// <remarks>
        /// value is a required non-negative integer.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#controllers">https://libvirt.org/formatdomain.html#controllers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#start_port Domain#start_port}
        /// </remarks>
        [JsiiProperty(name: "startPort", typeJson: "{\"primitive\":\"number\"}")]
        double StartPort
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesControllersUsbMaster), fullyQualifiedName: "libvirt.domain.DomainDevicesControllersUsbMaster")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesControllersUsbMaster
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the starting port number on the master USB controller that this controller manages;</summary>
            /// <remarks>
            /// value is a required non-negative integer.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#controllers">https://libvirt.org/formatdomain.html#controllers</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#start_port Domain#start_port}
            /// </remarks>
            [JsiiProperty(name: "startPort", typeJson: "{\"primitive\":\"number\"}")]
            public double StartPort
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
