using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainKeyWrapCiphers")]
    public class DomainKeyWrapCiphers : libvirt.Domain.IDomainKeyWrapCiphers
    {
        /// <summary>Sets the cipher name used for s390 key-wrapping, typically “aes” or “dea”;</summary>
        /// <remarks>
        /// the value is required and must match a cipher supported by the host/firmware.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#key-wrap">https://libvirt.org/formatdomain.html#key-wrap</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#name Domain#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Sets whether the given key-wrap cipher is enabled or disabled, using the required values "on" or "off".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#key-wrap">https://libvirt.org/formatdomain.html#key-wrap</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#state Domain#state}
        /// </remarks>
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public string State
        {
            get;
            set;
        }
    }
}
