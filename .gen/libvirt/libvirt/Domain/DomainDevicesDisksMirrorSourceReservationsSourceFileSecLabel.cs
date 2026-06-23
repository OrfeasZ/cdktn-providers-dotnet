using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesDisksMirrorSourceReservationsSourceFileSecLabel")]
    public class DomainDevicesDisksMirrorSourceReservationsSourceFileSecLabel : libvirt.Domain.IDomainDevicesDisksMirrorSourceReservationsSourceFileSecLabel
    {
        /// <summary>Sets the explicit security label to apply to the UNIX socket for the EGD RNG backend;</summary>
        /// <remarks>
        /// the value is user-provided (for example, an SELinux context string).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#security-label">https://libvirt.org/formatdomain.html#security-label</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#label Domain#label}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Label
        {
            get;
            set;
        }

        /// <summary>Controls whether application of the security label is skipped for the UNIX socket, using a "yes"/"no" flag equivalent to the seclabel labelskip attribute.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#security-label">https://libvirt.org/formatdomain.html#security-label</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#label_skip Domain#label_skip}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "labelSkip", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LabelSkip
        {
            get;
            set;
        }

        /// <summary>Selects the security labeling model used for the UNIX socket backing the EGD RNG backend (for example "selinux" or "dac");</summary>
        /// <remarks>
        /// the value is user-provided but should match a supported security driver.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#security-label">https://libvirt.org/formatdomain.html#security-label</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#model Domain#model}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "model", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Model
        {
            get;
            set;
        }

        /// <summary>Controls whether the security driver is allowed to change (relabel) the UNIX socket for the EGD RNG backend, using a "yes"/"no" flag.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#security-label">https://libvirt.org/formatdomain.html#security-label</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#relabel Domain#relabel}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "relabel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Relabel
        {
            get;
            set;
        }
    }
}
