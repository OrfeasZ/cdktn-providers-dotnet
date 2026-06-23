using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesControllersUsb")]
    public class DomainDevicesControllersUsb : libvirt.Domain.IDomainDevicesControllersUsb
    {
        /// <summary>Configures the master USB controller relationship, defining how this USB controller is chained or grouped with others.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#master Domain#master}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "master", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesControllersUsbMaster\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesControllersUsbMaster? Master
        {
            get;
            set;
        }

        /// <summary>Sets the total number of USB ports exposed by this controller; value is a user-provided positive integer.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#controllers">https://libvirt.org/formatdomain.html#controllers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#port Domain#port}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Port
        {
            get;
            set;
        }
    }
}
