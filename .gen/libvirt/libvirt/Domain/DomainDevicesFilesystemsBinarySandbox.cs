using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesFilesystemsBinarySandbox")]
    public class DomainDevicesFilesystemsBinarySandbox : libvirt.Domain.IDomainDevicesFilesystemsBinarySandbox
    {
        /// <summary>Sets the sandbox mode for the filesystem helper binary;</summary>
        /// <remarks>
        /// value is user-provided and should match one of libvirt's supported sandbox modes for this backend. For example, a mode could indicate "chroot" or "none" depending on driver support.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#mode Domain#mode}
        /// </remarks>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        public string Mode
        {
            get;
            set;
        }
    }
}
