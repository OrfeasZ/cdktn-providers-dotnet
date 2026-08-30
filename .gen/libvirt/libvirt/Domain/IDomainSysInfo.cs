using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainSysInfo), fullyQualifiedName: "libvirt.domain.DomainSysInfo")]
    public interface IDomainSysInfo
    {
        /// <summary>Configures a set of fw_cfg entries that firmware or the guest can read, used to inject arbitrary configuration data or files into the guest at boot.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#fw_cfg Domain#fw_cfg}
        /// </remarks>
        [JsiiProperty(name: "fwCfg", typeJson: "{\"fqn\":\"libvirt.domain.DomainSysInfoFwCfg\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainSysInfoFwCfg? FwCfg
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures SMBIOS-related system information blocks that the hypervisor exposes to the guest (system, base board, chassis, etc.).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#smbios Domain#smbios}
        /// </remarks>
        [JsiiProperty(name: "smbios", typeJson: "{\"fqn\":\"libvirt.domain.DomainSysInfoSmbios\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainSysInfoSmbios? Smbios
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainSysInfo), fullyQualifiedName: "libvirt.domain.DomainSysInfo")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainSysInfo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Configures a set of fw_cfg entries that firmware or the guest can read, used to inject arbitrary configuration data or files into the guest at boot.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#fw_cfg Domain#fw_cfg}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fwCfg", typeJson: "{\"fqn\":\"libvirt.domain.DomainSysInfoFwCfg\"}", isOptional: true)]
            public libvirt.Domain.IDomainSysInfoFwCfg? FwCfg
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainSysInfoFwCfg?>();
            }

            /// <summary>Configures SMBIOS-related system information blocks that the hypervisor exposes to the guest (system, base board, chassis, etc.).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#smbios Domain#smbios}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "smbios", typeJson: "{\"fqn\":\"libvirt.domain.DomainSysInfoSmbios\"}", isOptional: true)]
            public libvirt.Domain.IDomainSysInfoSmbios? Smbios
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainSysInfoSmbios?>();
            }
        }
    }
}
