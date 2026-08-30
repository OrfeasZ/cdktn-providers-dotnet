using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainSysInfoSmbiosProcessorEntry), fullyQualifiedName: "libvirt.domain.DomainSysInfoSmbiosProcessorEntry")]
    public interface IDomainSysInfoSmbiosProcessorEntry
    {
        /// <summary>Sets the fw_cfg key name used to identify this entry to the guest/firmware;</summary>
        /// <remarks>
        /// the string is user-provided and typically follows firmware-expected naming (for example, "opt/org.example/config").
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#smbios-system-information">https://libvirt.org/formatdomain.html#smbios-system-information</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#name Domain#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Sets the literal string value for this fw_cfg entry when no file is specified, providing small configuration blobs directly to the guest.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#smbios-system-information">https://libvirt.org/formatdomain.html#smbios-system-information</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#value Domain#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        /// <summary>Sets the host file path whose contents should be provided to the guest via this fw_cfg entry instead of an inline value;</summary>
        /// <remarks>
        /// the path is user-provided and must be readable by the hypervisor.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#smbios-system-information">https://libvirt.org/formatdomain.html#smbios-system-information</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#file Domain#file}
        /// </remarks>
        [JsiiProperty(name: "file", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? File
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainSysInfoSmbiosProcessorEntry), fullyQualifiedName: "libvirt.domain.DomainSysInfoSmbiosProcessorEntry")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainSysInfoSmbiosProcessorEntry
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the fw_cfg key name used to identify this entry to the guest/firmware;</summary>
            /// <remarks>
            /// the string is user-provided and typically follows firmware-expected naming (for example, "opt/org.example/config").
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#smbios-system-information">https://libvirt.org/formatdomain.html#smbios-system-information</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#name Domain#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Sets the literal string value for this fw_cfg entry when no file is specified, providing small configuration blobs directly to the guest.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#smbios-system-information">https://libvirt.org/formatdomain.html#smbios-system-information</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#value Domain#value}
            /// </remarks>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Sets the host file path whose contents should be provided to the guest via this fw_cfg entry instead of an inline value;</summary>
            /// <remarks>
            /// the path is user-provided and must be readable by the hypervisor.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#smbios-system-information">https://libvirt.org/formatdomain.html#smbios-system-information</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#file Domain#file}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "file", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? File
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
