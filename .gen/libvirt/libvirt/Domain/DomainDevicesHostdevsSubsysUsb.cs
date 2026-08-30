using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesHostdevsSubsysUsb")]
    public class DomainDevicesHostdevsSubsysUsb : libvirt.Domain.IDomainDevicesHostdevsSubsysUsb
    {
        /// <summary>Sets how the USB host device is identified for passthrough, either by topology (bus/port) or by vendor/product IDs and related options.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#source Domain#source}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsSubsysUsbSource\"}", isOptional: true)]
        public libvirt.Domain.IDomainDevicesHostdevsSubsysUsbSource? Source
        {
            get;
            set;
        }
    }
}
