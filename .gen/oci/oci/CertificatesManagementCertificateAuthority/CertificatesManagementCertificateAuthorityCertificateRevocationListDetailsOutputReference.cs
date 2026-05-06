using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CertificatesManagementCertificateAuthority
{
    [JsiiClass(nativeType: typeof(oci.CertificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateRevocationListDetailsOutputReference), fullyQualifiedName: "oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateRevocationListDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CertificatesManagementCertificateAuthorityCertificateRevocationListDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CertificatesManagementCertificateAuthorityCertificateRevocationListDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CertificatesManagementCertificateAuthorityCertificateRevocationListDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CertificatesManagementCertificateAuthorityCertificateRevocationListDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putObjectStorageConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateRevocationListDetailsObjectStorageConfig\"}}]")]
        public virtual void PutObjectStorageConfig(oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateRevocationListDetailsObjectStorageConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateRevocationListDetailsObjectStorageConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCustomFormattedUrls")]
        public virtual void ResetCustomFormattedUrls()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "objectStorageConfig", typeJson: "{\"fqn\":\"oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateRevocationListDetailsObjectStorageConfigOutputReference\"}")]
        public virtual oci.CertificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateRevocationListDetailsObjectStorageConfigOutputReference ObjectStorageConfig
        {
            get => GetInstanceProperty<oci.CertificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateRevocationListDetailsObjectStorageConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "customFormattedUrlsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? CustomFormattedUrlsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "objectStorageConfigInput", typeJson: "{\"fqn\":\"oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateRevocationListDetailsObjectStorageConfig\"}", isOptional: true)]
        public virtual oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateRevocationListDetailsObjectStorageConfig? ObjectStorageConfigInput
        {
            get => GetInstanceProperty<oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateRevocationListDetailsObjectStorageConfig?>();
        }

        [JsiiProperty(name: "customFormattedUrls", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] CustomFormattedUrls
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateRevocationListDetails\"}", isOptional: true)]
        public virtual oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateRevocationListDetails? InternalValue
        {
            get => GetInstanceProperty<oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateRevocationListDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
