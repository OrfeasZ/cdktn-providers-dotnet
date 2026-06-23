using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainOsFirmwareInfoFeatures")]
    public class DomainOsFirmwareInfoFeatures : libvirt.Domain.IDomainOsFirmwareInfoFeatures
    {
        /// <summary>Sets whether the given firmware feature entry is enabled, typically as a boolean-like flag (for example "yes"/"no" or "on"/"off") as required by the firmware.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#operating-system-booting">https://libvirt.org/formatdomain.html#operating-system-booting</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#enabled Domain#enabled}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Enabled
        {
            get;
            set;
        }

        /// <summary>Specifies the name/identifier of the firmware feature to control (value is user-provided and must match a feature understood by the chosen firmware).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#operating-system-booting">https://libvirt.org/formatdomain.html#operating-system-booting</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#name Domain#name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }
    }
}
