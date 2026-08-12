using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CertificatesManagementCertificateAuthority
{
    [JsiiByValue(fqn: "oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityRulesNameConstraint")]
    public class CertificatesManagementCertificateAuthorityCertificateAuthorityRulesNameConstraint : oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateAuthorityRulesNameConstraint
    {
        private object? _excludedSubtree;

        /// <summary>excluded_subtree block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/certificates_management_certificate_authority#excluded_subtree CertificatesManagementCertificateAuthority#excluded_subtree}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateAuthorityRulesNameConstraintExcludedSubtree" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "excludedSubtree", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityRulesNameConstraintExcludedSubtree\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ExcludedSubtree
        {
            get => _excludedSubtree;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateAuthorityRulesNameConstraintExcludedSubtree[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateAuthorityRulesNameConstraintExcludedSubtree).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _excludedSubtree = value;
            }
        }

        private object? _permittedSubtree;

        /// <summary>permitted_subtree block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/certificates_management_certificate_authority#permitted_subtree CertificatesManagementCertificateAuthority#permitted_subtree}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateAuthorityRulesNameConstraintPermittedSubtree" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "permittedSubtree", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityRulesNameConstraintPermittedSubtree\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? PermittedSubtree
        {
            get => _permittedSubtree;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateAuthorityRulesNameConstraintPermittedSubtree[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateAuthorityRulesNameConstraintPermittedSubtree).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _permittedSubtree = value;
            }
        }
    }
}
