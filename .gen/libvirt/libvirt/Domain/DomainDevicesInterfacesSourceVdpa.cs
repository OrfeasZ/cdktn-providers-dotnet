using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesInterfacesSourceVdpa")]
    public class DomainDevicesInterfacesSourceVdpa : libvirt.Domain.IDomainDevicesInterfacesSourceVdpa
    {
        /// <summary>Sets the path or name of the vDPA device (e.g. "/dev/vhost-vdpaX") used as the source for the interface; value is user-provided.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#vdpa-devices">https://libvirt.org/formatdomain.html#vdpa-devices</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#device Domain#device}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "device", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Device
        {
            get;
            set;
        }
    }
}
