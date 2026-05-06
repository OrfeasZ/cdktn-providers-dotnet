using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CertificatesManagementCertificateAuthority
{
    [JsiiClass(nativeType: typeof(oci.CertificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityConfigOutputReference), fullyQualifiedName: "oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CertificatesManagementCertificateAuthorityCertificateAuthorityConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CertificatesManagementCertificateAuthorityCertificateAuthorityConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CertificatesManagementCertificateAuthorityCertificateAuthorityConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CertificatesManagementCertificateAuthorityCertificateAuthorityConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putSubject", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityConfigSubject\"}}]")]
        public virtual void PutSubject(oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateAuthorityConfigSubject @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateAuthorityConfigSubject)}, new object[]{@value});
        }

        [JsiiMethod(name: "putValidity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityConfigValidity\"}}]")]
        public virtual void PutValidity(oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateAuthorityConfigValidity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateAuthorityConfigValidity)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetIssuerCertificateAuthorityId")]
        public virtual void ResetIssuerCertificateAuthorityId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSigningAlgorithm")]
        public virtual void ResetSigningAlgorithm()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetValidity")]
        public virtual void ResetValidity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVersionName")]
        public virtual void ResetVersionName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "subject", typeJson: "{\"fqn\":\"oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityConfigSubjectOutputReference\"}")]
        public virtual oci.CertificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityConfigSubjectOutputReference Subject
        {
            get => GetInstanceProperty<oci.CertificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityConfigSubjectOutputReference>()!;
        }

        [JsiiProperty(name: "validity", typeJson: "{\"fqn\":\"oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityConfigValidityOutputReference\"}")]
        public virtual oci.CertificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityConfigValidityOutputReference Validity
        {
            get => GetInstanceProperty<oci.CertificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityConfigValidityOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "configTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConfigTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "issuerCertificateAuthorityIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IssuerCertificateAuthorityIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "signingAlgorithmInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SigningAlgorithmInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subjectInput", typeJson: "{\"fqn\":\"oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityConfigSubject\"}", isOptional: true)]
        public virtual oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateAuthorityConfigSubject? SubjectInput
        {
            get => GetInstanceProperty<oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateAuthorityConfigSubject?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "validityInput", typeJson: "{\"fqn\":\"oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityConfigValidity\"}", isOptional: true)]
        public virtual oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateAuthorityConfigValidity? ValidityInput
        {
            get => GetInstanceProperty<oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateAuthorityConfigValidity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VersionNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "configType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "issuerCertificateAuthorityId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IssuerCertificateAuthorityId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "signingAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SigningAlgorithm
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "versionName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VersionName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityConfig\"}", isOptional: true)]
        public virtual oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateAuthorityConfig? InternalValue
        {
            get => GetInstanceProperty<oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateAuthorityConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
