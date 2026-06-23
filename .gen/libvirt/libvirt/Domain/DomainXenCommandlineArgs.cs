using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainXenCommandlineArgs")]
    public class DomainXenCommandlineArgs : libvirt.Domain.IDomainXenCommandlineArgs
    {
        /// <summary>Sets one additional argument token passed to the Xen qemu device model.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/drvxen.html">https://libvirt.org/drvxen.html</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#value Domain#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
