using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesControllersXenBus")]
    public class DomainDevicesControllersXenBus : libvirt.Domain.IDomainDevicesControllersXenBus
    {
        /// <summary>Sets the maximum number of Xen event channels available via this Xen bus controller;</summary>
        /// <remarks>
        /// value is a user-provided positive integer.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#controllers">https://libvirt.org/formatdomain.html#controllers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#max_event_channels Domain#max_event_channels}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maxEventChannels", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxEventChannels
        {
            get;
            set;
        }

        /// <summary>Sets the maximum number of grant frames for shared memory operations on this Xen bus controller;</summary>
        /// <remarks>
        /// value is a user-provided positive integer.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#controllers">https://libvirt.org/formatdomain.html#controllers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#max_grant_frames Domain#max_grant_frames}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maxGrantFrames", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxGrantFrames
        {
            get;
            set;
        }
    }
}
