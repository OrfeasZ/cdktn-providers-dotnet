using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainSysInfoSmbiosOemStrings")]
    public class DomainSysInfoSmbiosOemStrings : libvirt.Domain.IDomainSysInfoSmbiosOemStrings
    {
        /// <summary>Defines a single OEM string entry, each being an arbitrary user-provided string (for example, "Cluster=prod" or "Owner=teamX").</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#smbios-system-information">https://libvirt.org/formatdomain.html#smbios-system-information</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#entry Domain#entry}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "entry", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Entry
        {
            get;
            set;
        }
    }
}
