using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainIdMapUiDs")]
    public class DomainIdMapUiDs : libvirt.Domain.IDomainIdMapUiDs
    {
        /// <summary>Sets the number of consecutive GIDs in this mapping range; must be a positive integer.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#container-boot">https://libvirt.org/formatdomain.html#container-boot</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#count Domain#count}
        /// </remarks>
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}")]
        public double Count
        {
            get;
            set;
        }

        /// <summary>Sets the starting guest GID for this mapping range; must be a non-negative integer.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#container-boot">https://libvirt.org/formatdomain.html#container-boot</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#start Domain#start}
        /// </remarks>
        [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"number\"}")]
        public double Start
        {
            get;
            set;
        }

        /// <summary>Sets the starting host GID that the guest GIDs in this range are mapped to;</summary>
        /// <remarks>
        /// must be a non-negative integer.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#container-boot">https://libvirt.org/formatdomain.html#container-boot</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#target Domain#target}
        /// </remarks>
        [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"number\"}")]
        public double Target
        {
            get;
            set;
        }
    }
}
