using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesControllersDriverIoThreadsIoThreadQueues")]
    public class DomainDevicesControllersDriverIoThreadsIoThreadQueues : libvirt.Domain.IDomainDevicesControllersDriverIoThreadsIoThreadQueues
    {
        /// <summary>Identifies a specific queue assigned to this IOThread;</summary>
        /// <remarks>
        /// when omitted libvirt computes/assigns the id, and when set it must reference a valid queue index for the controller.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#controllers">https://libvirt.org/formatdomain.html#controllers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#id Domain#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"number\"}")]
        public double Id
        {
            get;
            set;
        }
    }
}
