using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainLaunchSecuritySev), fullyQualifiedName: "libvirt.domain.DomainLaunchSecuritySev")]
    public interface IDomainLaunchSecuritySev
    {
        /// <summary>Provides the required Diffie–Hellman certificate blob for establishing an SEV launch session;</summary>
        /// <remarks>
        /// the value is user‑provided (e.g., base64 or binary content as required by the SEV tooling).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#launch-security">https://libvirt.org/formatdomain.html#launch-security</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#dh_cert Domain#dh_cert}
        /// </remarks>
        [JsiiProperty(name: "dhCert", typeJson: "{\"primitive\":\"string\"}")]
        string DhCert
        {
            get;
        }

        /// <summary>Provides the required SEV session blob (e.g., launch session parameters or ticket) used to establish a protected guest; the value is user‑provided according to SEV tooling.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#launch-security">https://libvirt.org/formatdomain.html#launch-security</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#session Domain#session}
        /// </remarks>
        [JsiiProperty(name: "session", typeJson: "{\"primitive\":\"string\"}")]
        string Session
        {
            get;
        }

        /// <summary>Sets the C‑bit position for AMD SEV, indicating which guest-physical address bit marks encrypted memory;</summary>
        /// <remarks>
        /// the value is user‑provided (typically an integer matching host configuration).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#launch-security">https://libvirt.org/formatdomain.html#launch-security</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#cbit_pos Domain#cbit_pos}
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

        /// <summary>Enables or disables validation of kernel hashes for SEV by specifying a kernelHashes attribute value;</summary>
        /// <remarks>
        /// the value is user‑provided (commonly "yes"/"no" or an implementation-defined flag).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#launch-security">https://libvirt.org/formatdomain.html#launch-security</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#kernel_hashes Domain#kernel_hashes}
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

        /// <summary>Sets the SEV policy value controlling allowed guest behaviors (e.g., debugging, migration); the value is user‑provided, often as a bitmask or integer from SEV documentation.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#launch-security">https://libvirt.org/formatdomain.html#launch-security</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#policy Domain#policy}
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

        /// <summary>Sets the number of reduced physical address bits for SEV, aligning guest addressing with host SEV constraints;</summary>
        /// <remarks>
        /// the value is user‑provided (typically an integer).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#launch-security">https://libvirt.org/formatdomain.html#launch-security</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#reduced_phys_bits Domain#reduced_phys_bits}
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

        [JsiiTypeProxy(nativeType: typeof(IDomainLaunchSecuritySev), fullyQualifiedName: "libvirt.domain.DomainLaunchSecuritySev")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainLaunchSecuritySev
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Provides the required Diffie–Hellman certificate blob for establishing an SEV launch session;</summary>
            /// <remarks>
            /// the value is user‑provided (e.g., base64 or binary content as required by the SEV tooling).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#launch-security">https://libvirt.org/formatdomain.html#launch-security</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#dh_cert Domain#dh_cert}
            /// </remarks>
            [JsiiProperty(name: "dhCert", typeJson: "{\"primitive\":\"string\"}")]
            public string DhCert
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Provides the required SEV session blob (e.g., launch session parameters or ticket) used to establish a protected guest; the value is user‑provided according to SEV tooling.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#launch-security">https://libvirt.org/formatdomain.html#launch-security</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#session Domain#session}
            /// </remarks>
            [JsiiProperty(name: "session", typeJson: "{\"primitive\":\"string\"}")]
            public string Session
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Sets the C‑bit position for AMD SEV, indicating which guest-physical address bit marks encrypted memory;</summary>
            /// <remarks>
            /// the value is user‑provided (typically an integer matching host configuration).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#launch-security">https://libvirt.org/formatdomain.html#launch-security</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#cbit_pos Domain#cbit_pos}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cbitPos", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CbitPos
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Enables or disables validation of kernel hashes for SEV by specifying a kernelHashes attribute value;</summary>
            /// <remarks>
            /// the value is user‑provided (commonly "yes"/"no" or an implementation-defined flag).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#launch-security">https://libvirt.org/formatdomain.html#launch-security</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#kernel_hashes Domain#kernel_hashes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kernelHashes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KernelHashes
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the SEV policy value controlling allowed guest behaviors (e.g., debugging, migration); the value is user‑provided, often as a bitmask or integer from SEV documentation.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#launch-security">https://libvirt.org/formatdomain.html#launch-security</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#policy Domain#policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Policy
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the number of reduced physical address bits for SEV, aligning guest addressing with host SEV constraints;</summary>
            /// <remarks>
            /// the value is user‑provided (typically an integer).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#launch-security">https://libvirt.org/formatdomain.html#launch-security</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#reduced_phys_bits Domain#reduced_phys_bits}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "reducedPhysBits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ReducedPhysBits
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
