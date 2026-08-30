using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainQemuOverrideDevices")]
    public class DomainQemuOverrideDevices : libvirt.Domain.IDomainQemuOverrideDevices
    {
        /// <summary>Sets the libvirt device alias identifying which frontend device the override applies to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#alias Domain#alias}
        /// </remarks>
        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}")]
        public string Alias
        {
            get;
            set;
        }

        /// <summary>Configures frontend property overrides for the selected QEMU device.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#frontend Domain#frontend}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "frontend", typeJson: "{\"fqn\":\"libvirt.domain.DomainQemuOverrideDevicesFrontend\"}", isOptional: true)]
        public libvirt.Domain.IDomainQemuOverrideDevicesFrontend? Frontend
        {
            get;
            set;
        }
    }
}
