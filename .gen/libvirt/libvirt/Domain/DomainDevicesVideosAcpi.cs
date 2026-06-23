using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesVideosAcpi")]
    public class DomainDevicesVideosAcpi : libvirt.Domain.IDomainDevicesVideosAcpi
    {
        /// <summary>Sets the ACPI ERST record index used by this pstore device; the value is a user-provided non-negative integer.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#pstore">https://libvirt.org/formatdomain.html#pstore</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#index Domain#index}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "index", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Index
        {
            get;
            set;
        }
    }
}
