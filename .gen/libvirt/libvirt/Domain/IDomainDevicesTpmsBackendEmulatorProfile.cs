using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesTpmsBackendEmulatorProfile), fullyQualifiedName: "libvirt.domain.DomainDevicesTpmsBackendEmulatorProfile")]
    public interface IDomainDevicesTpmsBackendEmulatorProfile
    {
        /// <summary>Sets the name of the swtpm emulator profile to apply, selecting a specific preconfigured TPM profile;</summary>
        /// <remarks>
        /// the value is user-provided (for example, "qemu").
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#tpm-device">https://libvirt.org/formatdomain.html#tpm-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#name Domain#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets whether disabled PCR banks are removed from the TPM profile presented to the guest; accepts "yes" or "no".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#tpm-device">https://libvirt.org/formatdomain.html#tpm-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#remove_disabled Domain#remove_disabled}
        /// </remarks>
        [JsiiProperty(name: "removeDisabled", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RemoveDisabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets an optional identifier of the profile source for the TPM emulator profile (for example, a configuration database or profile namespace);</summary>
        /// <remarks>
        /// the value is user-provided.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#tpm-device">https://libvirt.org/formatdomain.html#tpm-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#source Domain#source}
        /// </remarks>
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Source
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesTpmsBackendEmulatorProfile), fullyQualifiedName: "libvirt.domain.DomainDevicesTpmsBackendEmulatorProfile")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesTpmsBackendEmulatorProfile
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the name of the swtpm emulator profile to apply, selecting a specific preconfigured TPM profile;</summary>
            /// <remarks>
            /// the value is user-provided (for example, "qemu").
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#tpm-device">https://libvirt.org/formatdomain.html#tpm-device</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#name Domain#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets whether disabled PCR banks are removed from the TPM profile presented to the guest; accepts "yes" or "no".</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#tpm-device">https://libvirt.org/formatdomain.html#tpm-device</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#remove_disabled Domain#remove_disabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "removeDisabled", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RemoveDisabled
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets an optional identifier of the profile source for the TPM emulator profile (for example, a configuration database or profile namespace);</summary>
            /// <remarks>
            /// the value is user-provided.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#tpm-device">https://libvirt.org/formatdomain.html#tpm-device</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#source Domain#source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Source
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
