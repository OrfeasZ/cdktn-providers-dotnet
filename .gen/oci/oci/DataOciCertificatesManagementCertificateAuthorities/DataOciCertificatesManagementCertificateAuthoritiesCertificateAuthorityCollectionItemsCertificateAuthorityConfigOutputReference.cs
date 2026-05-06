using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCertificatesManagementCertificateAuthorities
{
    [JsiiClass(nativeType: typeof(oci.DataOciCertificatesManagementCertificateAuthorities.DataOciCertificatesManagementCertificateAuthoritiesCertificateAuthorityCollectionItemsCertificateAuthorityConfigOutputReference), fullyQualifiedName: "oci.dataOciCertificatesManagementCertificateAuthorities.DataOciCertificatesManagementCertificateAuthoritiesCertificateAuthorityCollectionItemsCertificateAuthorityConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciCertificatesManagementCertificateAuthoritiesCertificateAuthorityCollectionItemsCertificateAuthorityConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciCertificatesManagementCertificateAuthoritiesCertificateAuthorityCollectionItemsCertificateAuthorityConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciCertificatesManagementCertificateAuthoritiesCertificateAuthorityCollectionItemsCertificateAuthorityConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCertificatesManagementCertificateAuthoritiesCertificateAuthorityCollectionItemsCertificateAuthorityConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "configType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "issuerCertificateAuthorityId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IssuerCertificateAuthorityId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "signingAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SigningAlgorithm
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subject", typeJson: "{\"fqn\":\"oci.dataOciCertificatesManagementCertificateAuthorities.DataOciCertificatesManagementCertificateAuthoritiesCertificateAuthorityCollectionItemsCertificateAuthorityConfigSubjectList\"}")]
        public virtual oci.DataOciCertificatesManagementCertificateAuthorities.DataOciCertificatesManagementCertificateAuthoritiesCertificateAuthorityCollectionItemsCertificateAuthorityConfigSubjectList Subject
        {
            get => GetInstanceProperty<oci.DataOciCertificatesManagementCertificateAuthorities.DataOciCertificatesManagementCertificateAuthoritiesCertificateAuthorityCollectionItemsCertificateAuthorityConfigSubjectList>()!;
        }

        [JsiiProperty(name: "validity", typeJson: "{\"fqn\":\"oci.dataOciCertificatesManagementCertificateAuthorities.DataOciCertificatesManagementCertificateAuthoritiesCertificateAuthorityCollectionItemsCertificateAuthorityConfigValidityList\"}")]
        public virtual oci.DataOciCertificatesManagementCertificateAuthorities.DataOciCertificatesManagementCertificateAuthoritiesCertificateAuthorityCollectionItemsCertificateAuthorityConfigValidityList Validity
        {
            get => GetInstanceProperty<oci.DataOciCertificatesManagementCertificateAuthorities.DataOciCertificatesManagementCertificateAuthoritiesCertificateAuthorityCollectionItemsCertificateAuthorityConfigValidityList>()!;
        }

        [JsiiProperty(name: "versionName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VersionName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciCertificatesManagementCertificateAuthorities.DataOciCertificatesManagementCertificateAuthoritiesCertificateAuthorityCollectionItemsCertificateAuthorityConfig\"}", isOptional: true)]
        public virtual oci.DataOciCertificatesManagementCertificateAuthorities.IDataOciCertificatesManagementCertificateAuthoritiesCertificateAuthorityCollectionItemsCertificateAuthorityConfig? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciCertificatesManagementCertificateAuthorities.IDataOciCertificatesManagementCertificateAuthoritiesCertificateAuthorityCollectionItemsCertificateAuthorityConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
