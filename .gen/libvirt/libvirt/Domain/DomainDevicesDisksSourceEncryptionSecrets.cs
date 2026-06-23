using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesDisksSourceEncryptionSecrets")]
    public class DomainDevicesDisksSourceEncryptionSecrets : libvirt.Domain.IDomainDevicesDisksSourceEncryptionSecrets
    {
        /// <summary>Sets how the referenced secret is identified;</summary>
        /// <remarks>
        /// typical values are user-provided strings such as "uuid" or "usage" depending on how the secret is looked up.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#host-device-assignment">https://libvirt.org/formatdomain.html#host-device-assignment</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#type Domain#type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }

        /// <summary>Sets the libvirt secret usage name when referencing the iSCSI auth secret by usage;</summary>
        /// <remarks>
        /// the value is a user-provided identifier such as an iSCSI target name.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#host-device-assignment">https://libvirt.org/formatdomain.html#host-device-assignment</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#usage Domain#usage}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "usage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Usage
        {
            get;
            set;
        }

        /// <summary>Exposes the UUID of the libvirt secret used for iSCSI authentication;</summary>
        /// <remarks>
        /// this is computed from the referenced secret rather than configured directly.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#host-device-assignment">https://libvirt.org/formatdomain.html#host-device-assignment</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#uuid Domain#uuid}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "uuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Uuid
        {
            get;
            set;
        }
    }
}
