using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCertificatesManagementCertificates
{
    [JsiiClass(nativeType: typeof(oci.DataOciCertificatesManagementCertificates.DataOciCertificatesManagementCertificatesCertificateCollectionItemsCertificateConfigOutputReference), fullyQualifiedName: "oci.dataOciCertificatesManagementCertificates.DataOciCertificatesManagementCertificatesCertificateCollectionItemsCertificateConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciCertificatesManagementCertificatesCertificateCollectionItemsCertificateConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciCertificatesManagementCertificatesCertificateCollectionItemsCertificateConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCertificatesManagementCertificatesCertificateCollectionItemsCertificateConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCertificatesManagementCertificatesCertificateCollectionItemsCertificateConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "certificateProfileType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateProfileType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "configType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "csrPem", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CsrPem
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "issuerCertificateAuthorityId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IssuerCertificateAuthorityId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "keyAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyAlgorithm
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "signatureAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SignatureAlgorithm
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subject", typeJson: "{\"fqn\":\"oci.dataOciCertificatesManagementCertificates.DataOciCertificatesManagementCertificatesCertificateCollectionItemsCertificateConfigSubjectList\"}")]
        public virtual oci.DataOciCertificatesManagementCertificates.DataOciCertificatesManagementCertificatesCertificateCollectionItemsCertificateConfigSubjectList Subject
        {
            get => GetInstanceProperty<oci.DataOciCertificatesManagementCertificates.DataOciCertificatesManagementCertificatesCertificateCollectionItemsCertificateConfigSubjectList>()!;
        }

        [JsiiProperty(name: "subjectAlternativeNames", typeJson: "{\"fqn\":\"oci.dataOciCertificatesManagementCertificates.DataOciCertificatesManagementCertificatesCertificateCollectionItemsCertificateConfigSubjectAlternativeNamesList\"}")]
        public virtual oci.DataOciCertificatesManagementCertificates.DataOciCertificatesManagementCertificatesCertificateCollectionItemsCertificateConfigSubjectAlternativeNamesList SubjectAlternativeNames
        {
            get => GetInstanceProperty<oci.DataOciCertificatesManagementCertificates.DataOciCertificatesManagementCertificatesCertificateCollectionItemsCertificateConfigSubjectAlternativeNamesList>()!;
        }

        [JsiiProperty(name: "validity", typeJson: "{\"fqn\":\"oci.dataOciCertificatesManagementCertificates.DataOciCertificatesManagementCertificatesCertificateCollectionItemsCertificateConfigValidityList\"}")]
        public virtual oci.DataOciCertificatesManagementCertificates.DataOciCertificatesManagementCertificatesCertificateCollectionItemsCertificateConfigValidityList Validity
        {
            get => GetInstanceProperty<oci.DataOciCertificatesManagementCertificates.DataOciCertificatesManagementCertificatesCertificateCollectionItemsCertificateConfigValidityList>()!;
        }

        [JsiiProperty(name: "versionName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VersionName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciCertificatesManagementCertificates.DataOciCertificatesManagementCertificatesCertificateCollectionItemsCertificateConfig\"}", isOptional: true)]
        public virtual oci.DataOciCertificatesManagementCertificates.IDataOciCertificatesManagementCertificatesCertificateCollectionItemsCertificateConfig? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciCertificatesManagementCertificates.IDataOciCertificatesManagementCertificatesCertificateCollectionItemsCertificateConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
