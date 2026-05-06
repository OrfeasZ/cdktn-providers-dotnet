using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCertificatesManagementCertificateAuthority
{
    [JsiiClass(nativeType: typeof(oci.DataOciCertificatesManagementCertificateAuthority.DataOciCertificatesManagementCertificateAuthorityCurrentVersionOutputReference), fullyQualifiedName: "oci.dataOciCertificatesManagementCertificateAuthority.DataOciCertificatesManagementCertificateAuthorityCurrentVersionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciCertificatesManagementCertificateAuthorityCurrentVersionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciCertificatesManagementCertificateAuthorityCurrentVersionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciCertificatesManagementCertificateAuthorityCurrentVersionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCertificatesManagementCertificateAuthorityCurrentVersionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "certificateAuthorityId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateAuthorityId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "issuerCaVersionNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IssuerCaVersionNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "revocationStatus", typeJson: "{\"fqn\":\"oci.dataOciCertificatesManagementCertificateAuthority.DataOciCertificatesManagementCertificateAuthorityCurrentVersionRevocationStatusList\"}")]
        public virtual oci.DataOciCertificatesManagementCertificateAuthority.DataOciCertificatesManagementCertificateAuthorityCurrentVersionRevocationStatusList RevocationStatus
        {
            get => GetInstanceProperty<oci.DataOciCertificatesManagementCertificateAuthority.DataOciCertificatesManagementCertificateAuthorityCurrentVersionRevocationStatusList>()!;
        }

        [JsiiProperty(name: "serialNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SerialNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "stages", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Stages
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeOfDeletion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeOfDeletion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "validity", typeJson: "{\"fqn\":\"oci.dataOciCertificatesManagementCertificateAuthority.DataOciCertificatesManagementCertificateAuthorityCurrentVersionValidityList\"}")]
        public virtual oci.DataOciCertificatesManagementCertificateAuthority.DataOciCertificatesManagementCertificateAuthorityCurrentVersionValidityList Validity
        {
            get => GetInstanceProperty<oci.DataOciCertificatesManagementCertificateAuthority.DataOciCertificatesManagementCertificateAuthorityCurrentVersionValidityList>()!;
        }

        [JsiiProperty(name: "versionName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VersionName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "versionNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VersionNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciCertificatesManagementCertificateAuthority.DataOciCertificatesManagementCertificateAuthorityCurrentVersion\"}", isOptional: true)]
        public virtual oci.DataOciCertificatesManagementCertificateAuthority.IDataOciCertificatesManagementCertificateAuthorityCurrentVersion? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciCertificatesManagementCertificateAuthority.IDataOciCertificatesManagementCertificateAuthorityCurrentVersion?>();
            set => SetInstanceProperty(value);
        }
    }
}
