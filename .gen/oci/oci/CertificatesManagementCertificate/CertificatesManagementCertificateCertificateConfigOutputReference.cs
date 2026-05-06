using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CertificatesManagementCertificate
{
    [JsiiClass(nativeType: typeof(oci.CertificatesManagementCertificate.CertificatesManagementCertificateCertificateConfigOutputReference), fullyQualifiedName: "oci.certificatesManagementCertificate.CertificatesManagementCertificateCertificateConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CertificatesManagementCertificateCertificateConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CertificatesManagementCertificateCertificateConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CertificatesManagementCertificateCertificateConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CertificatesManagementCertificateCertificateConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putSubject", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.certificatesManagementCertificate.CertificatesManagementCertificateCertificateConfigSubject\"}}]")]
        public virtual void PutSubject(oci.CertificatesManagementCertificate.ICertificatesManagementCertificateCertificateConfigSubject @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CertificatesManagementCertificate.ICertificatesManagementCertificateCertificateConfigSubject)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSubjectAlternativeNames", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.certificatesManagementCertificate.CertificatesManagementCertificateCertificateConfigSubjectAlternativeNames\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSubjectAlternativeNames(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.CertificatesManagementCertificate.ICertificatesManagementCertificateCertificateConfigSubjectAlternativeNames[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CertificatesManagementCertificate.ICertificatesManagementCertificateCertificateConfigSubjectAlternativeNames).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CertificatesManagementCertificate.ICertificatesManagementCertificateCertificateConfigSubjectAlternativeNames).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putValidity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.certificatesManagementCertificate.CertificatesManagementCertificateCertificateConfigValidity\"}}]")]
        public virtual void PutValidity(oci.CertificatesManagementCertificate.ICertificatesManagementCertificateCertificateConfigValidity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CertificatesManagementCertificate.ICertificatesManagementCertificateCertificateConfigValidity)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCertificateProfileType")]
        public virtual void ResetCertificateProfileType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCsrPem")]
        public virtual void ResetCsrPem()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIssuerCertificateAuthorityId")]
        public virtual void ResetIssuerCertificateAuthorityId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKeyAlgorithm")]
        public virtual void ResetKeyAlgorithm()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSignatureAlgorithm")]
        public virtual void ResetSignatureAlgorithm()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubject")]
        public virtual void ResetSubject()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubjectAlternativeNames")]
        public virtual void ResetSubjectAlternativeNames()
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

        [JsiiProperty(name: "subject", typeJson: "{\"fqn\":\"oci.certificatesManagementCertificate.CertificatesManagementCertificateCertificateConfigSubjectOutputReference\"}")]
        public virtual oci.CertificatesManagementCertificate.CertificatesManagementCertificateCertificateConfigSubjectOutputReference Subject
        {
            get => GetInstanceProperty<oci.CertificatesManagementCertificate.CertificatesManagementCertificateCertificateConfigSubjectOutputReference>()!;
        }

        [JsiiProperty(name: "subjectAlternativeNames", typeJson: "{\"fqn\":\"oci.certificatesManagementCertificate.CertificatesManagementCertificateCertificateConfigSubjectAlternativeNamesList\"}")]
        public virtual oci.CertificatesManagementCertificate.CertificatesManagementCertificateCertificateConfigSubjectAlternativeNamesList SubjectAlternativeNames
        {
            get => GetInstanceProperty<oci.CertificatesManagementCertificate.CertificatesManagementCertificateCertificateConfigSubjectAlternativeNamesList>()!;
        }

        [JsiiProperty(name: "validity", typeJson: "{\"fqn\":\"oci.certificatesManagementCertificate.CertificatesManagementCertificateCertificateConfigValidityOutputReference\"}")]
        public virtual oci.CertificatesManagementCertificate.CertificatesManagementCertificateCertificateConfigValidityOutputReference Validity
        {
            get => GetInstanceProperty<oci.CertificatesManagementCertificate.CertificatesManagementCertificateCertificateConfigValidityOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateProfileTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CertificateProfileTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "configTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConfigTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "csrPemInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CsrPemInput
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
        [JsiiProperty(name: "keyAlgorithmInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KeyAlgorithmInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "signatureAlgorithmInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SignatureAlgorithmInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subjectAlternativeNamesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.certificatesManagementCertificate.CertificatesManagementCertificateCertificateConfigSubjectAlternativeNames\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SubjectAlternativeNamesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subjectInput", typeJson: "{\"fqn\":\"oci.certificatesManagementCertificate.CertificatesManagementCertificateCertificateConfigSubject\"}", isOptional: true)]
        public virtual oci.CertificatesManagementCertificate.ICertificatesManagementCertificateCertificateConfigSubject? SubjectInput
        {
            get => GetInstanceProperty<oci.CertificatesManagementCertificate.ICertificatesManagementCertificateCertificateConfigSubject?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "validityInput", typeJson: "{\"fqn\":\"oci.certificatesManagementCertificate.CertificatesManagementCertificateCertificateConfigValidity\"}", isOptional: true)]
        public virtual oci.CertificatesManagementCertificate.ICertificatesManagementCertificateCertificateConfigValidity? ValidityInput
        {
            get => GetInstanceProperty<oci.CertificatesManagementCertificate.ICertificatesManagementCertificateCertificateConfigValidity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VersionNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "certificateProfileType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateProfileType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "configType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "csrPem", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CsrPem
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

        [JsiiProperty(name: "keyAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyAlgorithm
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "signatureAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SignatureAlgorithm
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.certificatesManagementCertificate.CertificatesManagementCertificateCertificateConfig\"}", isOptional: true)]
        public virtual oci.CertificatesManagementCertificate.ICertificatesManagementCertificateCertificateConfig? InternalValue
        {
            get => GetInstanceProperty<oci.CertificatesManagementCertificate.ICertificatesManagementCertificateCertificateConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
