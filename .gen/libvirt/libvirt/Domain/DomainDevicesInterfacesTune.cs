using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesInterfacesTune")]
    public class DomainDevicesInterfacesTune : libvirt.Domain.IDomainDevicesInterfacesTune
    {
        /// <summary>Sets the send buffer (sndbuf) size, in bytes, for the interface backend;</summary>
        /// <remarks>
        /// value is a user-provided non-negative integer (for example, 1048576).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#setting-network-backend-specific-options">https://libvirt.org/formatdomain.html#setting-network-backend-specific-options</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#snd_buf Domain#snd_buf}
        /// </remarks>
        [JsiiProperty(name: "sndBuf", typeJson: "{\"primitive\":\"number\"}")]
        public double SndBuf
        {
            get;
            set;
        }
    }
}
