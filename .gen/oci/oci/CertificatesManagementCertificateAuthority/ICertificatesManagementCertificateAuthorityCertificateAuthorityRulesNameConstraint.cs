using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CertificatesManagementCertificateAuthority
{
    [JsiiInterface(nativeType: typeof(ICertificatesManagementCertificateAuthorityCertificateAuthorityRulesNameConstraint), fullyQualifiedName: "oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityRulesNameConstraint")]
    public interface ICertificatesManagementCertificateAuthorityCertificateAuthorityRulesNameConstraint
    {
        /// <summary>excluded_subtree block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/certificates_management_certificate_authority#excluded_subtree CertificatesManagementCertificateAuthority#excluded_subtree}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateAuthorityRulesNameConstraintExcludedSubtree" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "excludedSubtree", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityRulesNameConstraintExcludedSubtree\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ExcludedSubtree
        {
            get
            {
                return null;
            }
        }

        /// <summary>permitted_subtree block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/certificates_management_certificate_authority#permitted_subtree CertificatesManagementCertificateAuthority#permitted_subtree}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateAuthorityRulesNameConstraintPermittedSubtree" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "permittedSubtree", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityRulesNameConstraintPermittedSubtree\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PermittedSubtree
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICertificatesManagementCertificateAuthorityCertificateAuthorityRulesNameConstraint), fullyQualifiedName: "oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityRulesNameConstraint")]
        internal sealed class _Proxy : DeputyBase, oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateAuthorityRulesNameConstraint
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>excluded_subtree block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/certificates_management_certificate_authority#excluded_subtree CertificatesManagementCertificateAuthority#excluded_subtree}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateAuthorityRulesNameConstraintExcludedSubtree" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "excludedSubtree", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityRulesNameConstraintExcludedSubtree\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ExcludedSubtree
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>permitted_subtree block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/certificates_management_certificate_authority#permitted_subtree CertificatesManagementCertificateAuthority#permitted_subtree}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateAuthorityRulesNameConstraintPermittedSubtree" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "permittedSubtree", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityRulesNameConstraintPermittedSubtree\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PermittedSubtree
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
