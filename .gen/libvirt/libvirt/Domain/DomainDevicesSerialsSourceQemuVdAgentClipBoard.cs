using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesSerialsSourceQemuVdAgentClipBoard")]
    public class DomainDevicesSerialsSourceQemuVdAgentClipBoard : libvirt.Domain.IDomainDevicesSerialsSourceQemuVdAgentClipBoard
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#copy_paste Domain#copy_paste}.</summary>
        [JsiiProperty(name: "copyPaste", typeJson: "{\"primitive\":\"string\"}")]
        public string CopyPaste
        {
            get;
            set;
        }
    }
}
