using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCertificatesManagementCertificate
{
    [JsiiClass(nativeType: typeof(oci.DataOciCertificatesManagementCertificate.DataOciCertificatesManagementCertificateCertificateConfigSubjectOutputReference), fullyQualifiedName: "oci.dataOciCertificatesManagementCertificate.DataOciCertificatesManagementCertificateCertificateConfigSubjectOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciCertificatesManagementCertificateCertificateConfigSubjectOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciCertificatesManagementCertificateCertificateConfigSubjectOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciCertificatesManagementCertificateCertificateConfigSubjectOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCertificatesManagementCertificateCertificateConfigSubjectOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "commonName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CommonName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "country", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Country
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "distinguishedNameQualifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DistinguishedNameQualifier
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "domainComponent", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainComponent
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "generationQualifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GenerationQualifier
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "givenName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GivenName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "initials", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Initials
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "localityName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LocalityName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "organization", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Organization
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "organizationalUnit", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OrganizationalUnit
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "pseudonym", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Pseudonym
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serialNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SerialNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "stateOrProvinceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StateOrProvinceName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "street", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Street
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "surname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Surname
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "title", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Title
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciCertificatesManagementCertificate.DataOciCertificatesManagementCertificateCertificateConfigSubject\"}", isOptional: true)]
        public virtual oci.DataOciCertificatesManagementCertificate.IDataOciCertificatesManagementCertificateCertificateConfigSubject? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciCertificatesManagementCertificate.IDataOciCertificatesManagementCertificateCertificateConfigSubject?>();
            set => SetInstanceProperty(value);
        }
    }
}
