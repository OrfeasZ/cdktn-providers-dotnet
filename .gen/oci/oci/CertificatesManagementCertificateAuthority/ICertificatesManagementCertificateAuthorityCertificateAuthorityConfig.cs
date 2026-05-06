using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CertificatesManagementCertificateAuthority
{
    [JsiiInterface(nativeType: typeof(ICertificatesManagementCertificateAuthorityCertificateAuthorityConfig), fullyQualifiedName: "oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityConfig")]
    public interface ICertificatesManagementCertificateAuthorityCertificateAuthorityConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#config_type CertificatesManagementCertificateAuthority#config_type}.</summary>
        [JsiiProperty(name: "configType", typeJson: "{\"primitive\":\"string\"}")]
        string ConfigType
        {
            get;
        }

        /// <summary>subject block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#subject CertificatesManagementCertificateAuthority#subject}
        /// </remarks>
        [JsiiProperty(name: "subject", typeJson: "{\"fqn\":\"oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityConfigSubject\"}")]
        oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateAuthorityConfigSubject Subject
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#issuer_certificate_authority_id CertificatesManagementCertificateAuthority#issuer_certificate_authority_id}.</summary>
        [JsiiProperty(name: "issuerCertificateAuthorityId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IssuerCertificateAuthorityId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#signing_algorithm CertificatesManagementCertificateAuthority#signing_algorithm}.</summary>
        [JsiiProperty(name: "signingAlgorithm", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SigningAlgorithm
        {
            get
            {
                return null;
            }
        }

        /// <summary>validity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#validity CertificatesManagementCertificateAuthority#validity}
        /// </remarks>
        [JsiiProperty(name: "validity", typeJson: "{\"fqn\":\"oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityConfigValidity\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateAuthorityConfigValidity? Validity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#version_name CertificatesManagementCertificateAuthority#version_name}.</summary>
        [JsiiProperty(name: "versionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VersionName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICertificatesManagementCertificateAuthorityCertificateAuthorityConfig), fullyQualifiedName: "oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityConfig")]
        internal sealed class _Proxy : DeputyBase, oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateAuthorityConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#config_type CertificatesManagementCertificateAuthority#config_type}.</summary>
            [JsiiProperty(name: "configType", typeJson: "{\"primitive\":\"string\"}")]
            public string ConfigType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>subject block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#subject CertificatesManagementCertificateAuthority#subject}
            /// </remarks>
            [JsiiProperty(name: "subject", typeJson: "{\"fqn\":\"oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityConfigSubject\"}")]
            public oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateAuthorityConfigSubject Subject
            {
                get => GetInstanceProperty<oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateAuthorityConfigSubject>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#issuer_certificate_authority_id CertificatesManagementCertificateAuthority#issuer_certificate_authority_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "issuerCertificateAuthorityId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IssuerCertificateAuthorityId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#signing_algorithm CertificatesManagementCertificateAuthority#signing_algorithm}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "signingAlgorithm", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SigningAlgorithm
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>validity block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#validity CertificatesManagementCertificateAuthority#validity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "validity", typeJson: "{\"fqn\":\"oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityConfigValidity\"}", isOptional: true)]
            public oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateAuthorityConfigValidity? Validity
            {
                get => GetInstanceProperty<oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateAuthorityConfigValidity?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/certificates_management_certificate_authority#version_name CertificatesManagementCertificateAuthority#version_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "versionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VersionName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
