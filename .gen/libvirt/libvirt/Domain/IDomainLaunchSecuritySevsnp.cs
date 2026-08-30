using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainLaunchSecuritySevsnp), fullyQualifiedName: "libvirt.domain.DomainLaunchSecuritySevsnp")]
    public interface IDomainLaunchSecuritySevsnp
    {
        /// <summary>Sets the SEV-SNP author key blob used to validate the guest’s identity when SEV-SNP launch security is enabled;</summary>
        /// <remarks>
        /// the value is user-provided binary data (typically base64-encoded).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#launch-security">https://libvirt.org/formatdomain.html#launch-security</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#author_key Domain#author_key}
        /// </remarks>
        [JsiiProperty(name: "authorKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AuthorKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the SEV-SNP C-bit position (cbitpos) indicating which guest-physical address bit marks encrypted memory;</summary>
        /// <remarks>
        /// value is user-provided and must match the host SEV-SNP configuration.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#launch-security">https://libvirt.org/formatdomain.html#launch-security</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#cbit_pos Domain#cbit_pos}
        /// </remarks>
        [JsiiProperty(name: "cbitPos", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CbitPos
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the SEV-SNP guestVisibleWorkarounds flag or bitmap controlling which SEV-SNP hardware or microcode workarounds are exposed to the guest;</summary>
        /// <remarks>
        /// value is user-provided.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#launch-security">https://libvirt.org/formatdomain.html#launch-security</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#guest_visible_workarounds Domain#guest_visible_workarounds}
        /// </remarks>
        [JsiiProperty(name: "guestVisibleWorkarounds", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GuestVisibleWorkarounds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Provides an optional SEV-SNP hostData blob passed into the SEV-SNP launch flow for attestation purposes;</summary>
        /// <remarks>
        /// the value is user-provided binary data (commonly base64-encoded).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#launch-security">https://libvirt.org/formatdomain.html#launch-security</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#host_data Domain#host_data}
        /// </remarks>
        [JsiiProperty(name: "hostData", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HostData
        {
            get
            {
                return null;
            }
        }

        /// <summary>Supplies the SEV-SNP idAuth structure used to authenticate the guest’s identity as part of the SEV-SNP launch;</summary>
        /// <remarks>
        /// value is user-provided binary data from the SEV tooling.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#launch-security">https://libvirt.org/formatdomain.html#launch-security</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#id_auth Domain#id_auth}
        /// </remarks>
        [JsiiProperty(name: "idAuth", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IdAuth
        {
            get
            {
                return null;
            }
        }

        /// <summary>Supplies the SEV-SNP idBlock structure defining the guest identity and policy for SEV-SNP launch;</summary>
        /// <remarks>
        /// value is user-provided binary data from the SEV tooling.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#launch-security">https://libvirt.org/formatdomain.html#launch-security</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#id_block Domain#id_block}
        /// </remarks>
        [JsiiProperty(name: "idBlock", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IdBlock
        {
            get
            {
                return null;
            }
        }

        /// <summary>Points to a file containing kernel hash metadata for SEV-SNP attestation when SEV-SNP launch security is enabled;</summary>
        /// <remarks>
        /// value is a user-provided path string.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#launch-security">https://libvirt.org/formatdomain.html#launch-security</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#kernel_hashes Domain#kernel_hashes}
        /// </remarks>
        [JsiiProperty(name: "kernelHashes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KernelHashes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the SEV-SNP guest policy value (bitfield) governing allowed debug, migration, and other behaviors;</summary>
        /// <remarks>
        /// value is user-provided, commonly expressed as an integer or hex string.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#launch-security">https://libvirt.org/formatdomain.html#launch-security</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#policy Domain#policy}
        /// </remarks>
        [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Policy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the number of reduced physical address bits (reducedPhysBits) for SEV-SNP, matching the host configuration;</summary>
        /// <remarks>
        /// value is a user-provided non-negative integer.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#launch-security">https://libvirt.org/formatdomain.html#launch-security</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#reduced_phys_bits Domain#reduced_phys_bits}
        /// </remarks>
        [JsiiProperty(name: "reducedPhysBits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ReducedPhysBits
        {
            get
            {
                return null;
            }
        }

        /// <summary>Points to a file with the SEV-SNP VCEK (Versioned Chip Endorsement Key) certificate used for attestation;</summary>
        /// <remarks>
        /// value is a user-provided path string.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#launch-security">https://libvirt.org/formatdomain.html#launch-security</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#vcek Domain#vcek}
        /// </remarks>
        [JsiiProperty(name: "vcek", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Vcek
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainLaunchSecuritySevsnp), fullyQualifiedName: "libvirt.domain.DomainLaunchSecuritySevsnp")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainLaunchSecuritySevsnp
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the SEV-SNP author key blob used to validate the guest’s identity when SEV-SNP launch security is enabled;</summary>
            /// <remarks>
            /// the value is user-provided binary data (typically base64-encoded).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#launch-security">https://libvirt.org/formatdomain.html#launch-security</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#author_key Domain#author_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "authorKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AuthorKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the SEV-SNP C-bit position (cbitpos) indicating which guest-physical address bit marks encrypted memory;</summary>
            /// <remarks>
            /// value is user-provided and must match the host SEV-SNP configuration.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#launch-security">https://libvirt.org/formatdomain.html#launch-security</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#cbit_pos Domain#cbit_pos}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cbitPos", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CbitPos
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the SEV-SNP guestVisibleWorkarounds flag or bitmap controlling which SEV-SNP hardware or microcode workarounds are exposed to the guest;</summary>
            /// <remarks>
            /// value is user-provided.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#launch-security">https://libvirt.org/formatdomain.html#launch-security</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#guest_visible_workarounds Domain#guest_visible_workarounds}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "guestVisibleWorkarounds", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GuestVisibleWorkarounds
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Provides an optional SEV-SNP hostData blob passed into the SEV-SNP launch flow for attestation purposes;</summary>
            /// <remarks>
            /// the value is user-provided binary data (commonly base64-encoded).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#launch-security">https://libvirt.org/formatdomain.html#launch-security</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#host_data Domain#host_data}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hostData", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HostData
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Supplies the SEV-SNP idAuth structure used to authenticate the guest’s identity as part of the SEV-SNP launch;</summary>
            /// <remarks>
            /// value is user-provided binary data from the SEV tooling.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#launch-security">https://libvirt.org/formatdomain.html#launch-security</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#id_auth Domain#id_auth}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "idAuth", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IdAuth
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Supplies the SEV-SNP idBlock structure defining the guest identity and policy for SEV-SNP launch;</summary>
            /// <remarks>
            /// value is user-provided binary data from the SEV tooling.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#launch-security">https://libvirt.org/formatdomain.html#launch-security</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#id_block Domain#id_block}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "idBlock", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IdBlock
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Points to a file containing kernel hash metadata for SEV-SNP attestation when SEV-SNP launch security is enabled;</summary>
            /// <remarks>
            /// value is a user-provided path string.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#launch-security">https://libvirt.org/formatdomain.html#launch-security</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#kernel_hashes Domain#kernel_hashes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kernelHashes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KernelHashes
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the SEV-SNP guest policy value (bitfield) governing allowed debug, migration, and other behaviors;</summary>
            /// <remarks>
            /// value is user-provided, commonly expressed as an integer or hex string.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#launch-security">https://libvirt.org/formatdomain.html#launch-security</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#policy Domain#policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Policy
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the number of reduced physical address bits (reducedPhysBits) for SEV-SNP, matching the host configuration;</summary>
            /// <remarks>
            /// value is a user-provided non-negative integer.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#launch-security">https://libvirt.org/formatdomain.html#launch-security</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#reduced_phys_bits Domain#reduced_phys_bits}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "reducedPhysBits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ReducedPhysBits
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Points to a file with the SEV-SNP VCEK (Versioned Chip Endorsement Key) certificate used for attestation;</summary>
            /// <remarks>
            /// value is a user-provided path string.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#launch-security">https://libvirt.org/formatdomain.html#launch-security</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#vcek Domain#vcek}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vcek", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Vcek
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
