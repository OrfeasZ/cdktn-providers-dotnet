using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCertificatesManagementCertificate
{
    [JsiiClass(nativeType: typeof(oci.DataOciCertificatesManagementCertificate.DataOciCertificatesManagementCertificateCurrentVersionOutputReference), fullyQualifiedName: "oci.dataOciCertificatesManagementCertificate.DataOciCertificatesManagementCertificateCurrentVersionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciCertificatesManagementCertificateCurrentVersionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciCertificatesManagementCertificateCurrentVersionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciCertificatesManagementCertificateCurrentVersionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCertificatesManagementCertificateCurrentVersionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "certificateId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "issuerCaVersionNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IssuerCaVersionNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "revocationStatus", typeJson: "{\"fqn\":\"oci.dataOciCertificatesManagementCertificate.DataOciCertificatesManagementCertificateCurrentVersionRevocationStatusList\"}")]
        public virtual oci.DataOciCertificatesManagementCertificate.DataOciCertificatesManagementCertificateCurrentVersionRevocationStatusList RevocationStatus
        {
            get => GetInstanceProperty<oci.DataOciCertificatesManagementCertificate.DataOciCertificatesManagementCertificateCurrentVersionRevocationStatusList>()!;
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

        [JsiiProperty(name: "subjectAlternativeNames", typeJson: "{\"fqn\":\"oci.dataOciCertificatesManagementCertificate.DataOciCertificatesManagementCertificateCurrentVersionSubjectAlternativeNamesList\"}")]
        public virtual oci.DataOciCertificatesManagementCertificate.DataOciCertificatesManagementCertificateCurrentVersionSubjectAlternativeNamesList SubjectAlternativeNames
        {
            get => GetInstanceProperty<oci.DataOciCertificatesManagementCertificate.DataOciCertificatesManagementCertificateCurrentVersionSubjectAlternativeNamesList>()!;
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

        [JsiiProperty(name: "validity", typeJson: "{\"fqn\":\"oci.dataOciCertificatesManagementCertificate.DataOciCertificatesManagementCertificateCurrentVersionValidityList\"}")]
        public virtual oci.DataOciCertificatesManagementCertificate.DataOciCertificatesManagementCertificateCurrentVersionValidityList Validity
        {
            get => GetInstanceProperty<oci.DataOciCertificatesManagementCertificate.DataOciCertificatesManagementCertificateCurrentVersionValidityList>()!;
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciCertificatesManagementCertificate.DataOciCertificatesManagementCertificateCurrentVersion\"}", isOptional: true)]
        public virtual oci.DataOciCertificatesManagementCertificate.IDataOciCertificatesManagementCertificateCurrentVersion? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciCertificatesManagementCertificate.IDataOciCertificatesManagementCertificateCurrentVersion?>();
            set => SetInstanceProperty(value);
        }
    }
}
