using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesTpmsBackendEmulator), fullyQualifiedName: "libvirt.domain.DomainDevicesTpmsBackendEmulator")]
    public interface IDomainDevicesTpmsBackendEmulator
    {
        /// <summary>Defines which PCR banks are active in the emulated TPM backend by enabling specific hash algorithms as child elements.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#active_pcr_banks Domain#active_pcr_banks}
        /// </remarks>
        [JsiiProperty(name: "activePcrBanks", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendEmulatorActivePcrBanks\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesTpmsBackendEmulatorActivePcrBanks? ActivePcrBanks
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables or configures debug output for the emulated TPM backend;</summary>
        /// <remarks>
        /// accepts a backend-specific value such as a boolean-like flag or debug level.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#tpm-device">https://libvirt.org/formatdomain.html#tpm-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#debug Domain#debug}
        /// </remarks>
        [JsiiProperty(name: "debug", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Debug
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables encrypted state storage for the emulated TPM and points to the secret that protects the TPM state at rest.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#encryption Domain#encryption}
        /// </remarks>
        [JsiiProperty(name: "encryption", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendEmulatorEncryption\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesTpmsBackendEmulatorEncryption? Encryption
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether the emulated TPM keeps its state persistently across guest reboots; accepts a boolean-like value (for example, "yes"/"no").</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#tpm-device">https://libvirt.org/formatdomain.html#tpm-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#persistent_state Domain#persistent_state}
        /// </remarks>
        [JsiiProperty(name: "persistentState", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PersistentState
        {
            get
            {
                return null;
            }
        }

        /// <summary>Selects the TPM profile or version used by the emulator (for example, "1.2" or "2.0"), with allowed values depending on the emulator implementation.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#profile Domain#profile}
        /// </remarks>
        [JsiiProperty(name: "profile", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendEmulatorProfile\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesTpmsBackendEmulatorProfile? Profile
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures the source location for the TPM emulator state, using either a directory or file sub-block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#source Domain#source}
        /// </remarks>
        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendEmulatorSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesTpmsBackendEmulatorSource? Source
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the TPM version that the emulator exposes to the guest; valid values are "1.2" or "2.0".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#tpm-device">https://libvirt.org/formatdomain.html#tpm-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#version Domain#version}
        /// </remarks>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Version
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesTpmsBackendEmulator), fullyQualifiedName: "libvirt.domain.DomainDevicesTpmsBackendEmulator")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesTpmsBackendEmulator
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Defines which PCR banks are active in the emulated TPM backend by enabling specific hash algorithms as child elements.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#active_pcr_banks Domain#active_pcr_banks}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "activePcrBanks", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendEmulatorActivePcrBanks\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesTpmsBackendEmulatorActivePcrBanks? ActivePcrBanks
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesTpmsBackendEmulatorActivePcrBanks?>();
            }

            /// <summary>Enables or configures debug output for the emulated TPM backend;</summary>
            /// <remarks>
            /// accepts a backend-specific value such as a boolean-like flag or debug level.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#tpm-device">https://libvirt.org/formatdomain.html#tpm-device</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#debug Domain#debug}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "debug", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Debug
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Enables encrypted state storage for the emulated TPM and points to the secret that protects the TPM state at rest.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#encryption Domain#encryption}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "encryption", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendEmulatorEncryption\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesTpmsBackendEmulatorEncryption? Encryption
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesTpmsBackendEmulatorEncryption?>();
            }

            /// <summary>Controls whether the emulated TPM keeps its state persistently across guest reboots; accepts a boolean-like value (for example, "yes"/"no").</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#tpm-device">https://libvirt.org/formatdomain.html#tpm-device</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#persistent_state Domain#persistent_state}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "persistentState", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PersistentState
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Selects the TPM profile or version used by the emulator (for example, "1.2" or "2.0"), with allowed values depending on the emulator implementation.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#profile Domain#profile}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "profile", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendEmulatorProfile\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesTpmsBackendEmulatorProfile? Profile
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesTpmsBackendEmulatorProfile?>();
            }

            /// <summary>Configures the source location for the TPM emulator state, using either a directory or file sub-block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#source Domain#source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendEmulatorSource\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesTpmsBackendEmulatorSource? Source
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesTpmsBackendEmulatorSource?>();
            }

            /// <summary>Sets the TPM version that the emulator exposes to the guest; valid values are "1.2" or "2.0".</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#tpm-device">https://libvirt.org/formatdomain.html#tpm-device</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#version Domain#version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Version
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
