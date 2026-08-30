using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesIommUsAcpi")]
    public class DomainDevicesIommUsAcpi : libvirt.Domain.IDomainDevicesIommUsAcpi
    {
        /// <summary>Sets the ACPI ERST record index used by this pstore device; the value is a user-provided non-negative integer.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#pstore">https://libvirt.org/formatdomain.html#pstore</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#index Domain#index}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "index", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Index
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#nodeset Domain#nodeset}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nodeset", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Nodeset
        {
            get;
            set;
        }
    }
}
