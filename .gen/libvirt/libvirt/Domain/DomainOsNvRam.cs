using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainOsNvRam")]
    public class DomainOsNvRam : libvirt.Domain.IDomainOsNvRam
    {
        /// <summary>Sets the path or identifier of the NVRAM storage used by the guest firmware to persist UEFI/firmware variables.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#bios-bootloader">https://libvirt.org/formatdomain.html#bios-bootloader</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#nv_ram Domain#nv_ram}
        /// </remarks>
        [JsiiProperty(name: "nvRam", typeJson: "{\"primitive\":\"string\"}")]
        public string NvRam
        {
            get;
            set;
        }

        /// <summary>Sets the on-disk format of the NVRAM file backing the guest firmware state;</summary>
        /// <remarks>
        /// the value is user-provided (for example, matching the firmware’s expected format).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#bios-bootloader">https://libvirt.org/formatdomain.html#bios-bootloader</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#format Domain#format}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Format
        {
            get;
            set;
        }

        /// <summary>Defines the data source for the mirror backing store, such as a block device or file path.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#source Domain#source}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsNvRamSource\"}", isOptional: true)]
        public libvirt.Domain.IDomainOsNvRamSource? Source
        {
            get;
            set;
        }

        /// <summary>Sets the path or volume name of the NVRAM template image from which the guest’s NVRAM is initially created;</summary>
        /// <remarks>
        /// the value is user-provided (for example, pointing to an OVMF_VARS template).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#operating-system-booting">https://libvirt.org/formatdomain.html#operating-system-booting</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#template Domain#template}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "template", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Template
        {
            get;
            set;
        }

        /// <summary>Sets the storage format of the NVRAM template (for example, raw or qcow2), controlling how the hypervisor interprets the template backing store.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#operating-system-booting">https://libvirt.org/formatdomain.html#operating-system-booting</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#template_format Domain#template_format}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "templateFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TemplateFormat
        {
            get;
            set;
        }
    }
}
