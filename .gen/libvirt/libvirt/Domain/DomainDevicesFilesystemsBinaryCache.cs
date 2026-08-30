using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesFilesystemsBinaryCache")]
    public class DomainDevicesFilesystemsBinaryCache : libvirt.Domain.IDomainDevicesFilesystemsBinaryCache
    {
        /// <summary>Sets the cache mode policy for the filesystem helper binary;</summary>
        /// <remarks>
        /// value is user-provided and should match libvirt's supported cache modes (for example, "always", "none", or similar driver-specific values).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#mode Domain#mode}
        /// </remarks>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        public string Mode
        {
            get;
            set;
        }
    }
}
