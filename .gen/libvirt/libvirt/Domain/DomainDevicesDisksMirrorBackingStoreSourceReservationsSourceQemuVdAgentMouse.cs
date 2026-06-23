using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesDisksMirrorBackingStoreSourceReservationsSourceQemuVdAgentMouse")]
    public class DomainDevicesDisksMirrorBackingStoreSourceReservationsSourceQemuVdAgentMouse : libvirt.Domain.IDomainDevicesDisksMirrorBackingStoreSourceReservationsSourceQemuVdAgentMouse
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#mode Domain#mode}.</summary>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        public string Mode
        {
            get;
            set;
        }
    }
}
