using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciWaasCertificates
{
    [JsiiClass(nativeType: typeof(oci.DataOciWaasCertificates.DataOciWaasCertificatesCertificatesOutputReference), fullyQualifiedName: "oci.dataOciWaasCertificates.DataOciWaasCertificatesCertificatesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciWaasCertificatesCertificatesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciWaasCertificatesCertificatesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciWaasCertificatesCertificatesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciWaasCertificatesCertificatesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "certificateData", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateData
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "extensions", typeJson: "{\"fqn\":\"oci.dataOciWaasCertificates.DataOciWaasCertificatesCertificatesExtensionsList\"}")]
        public virtual oci.DataOciWaasCertificates.DataOciWaasCertificatesCertificatesExtensionsList Extensions
        {
            get => GetInstanceProperty<oci.DataOciWaasCertificates.DataOciWaasCertificatesCertificatesExtensionsList>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "issuedBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IssuedBy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "issuerName", typeJson: "{\"fqn\":\"oci.dataOciWaasCertificates.DataOciWaasCertificatesCertificatesIssuerNameList\"}")]
        public virtual oci.DataOciWaasCertificates.DataOciWaasCertificatesCertificatesIssuerNameList IssuerName
        {
            get => GetInstanceProperty<oci.DataOciWaasCertificates.DataOciWaasCertificatesCertificatesIssuerNameList>()!;
        }

        [JsiiProperty(name: "isTrustVerificationDisabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsTrustVerificationDisabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "privateKeyData", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateKeyData
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "publicKeyInfo", typeJson: "{\"fqn\":\"oci.dataOciWaasCertificates.DataOciWaasCertificatesCertificatesPublicKeyInfoList\"}")]
        public virtual oci.DataOciWaasCertificates.DataOciWaasCertificatesCertificatesPublicKeyInfoList PublicKeyInfo
        {
            get => GetInstanceProperty<oci.DataOciWaasCertificates.DataOciWaasCertificatesCertificatesPublicKeyInfoList>()!;
        }

        [JsiiProperty(name: "serialNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SerialNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "signatureAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SignatureAlgorithm
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subjectName", typeJson: "{\"fqn\":\"oci.dataOciWaasCertificates.DataOciWaasCertificatesCertificatesSubjectNameList\"}")]
        public virtual oci.DataOciWaasCertificates.DataOciWaasCertificatesCertificatesSubjectNameList SubjectName
        {
            get => GetInstanceProperty<oci.DataOciWaasCertificates.DataOciWaasCertificatesCertificatesSubjectNameList>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeNotValidAfter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeNotValidAfter
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeNotValidBefore", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeNotValidBefore
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Version
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciWaasCertificates.DataOciWaasCertificatesCertificates\"}", isOptional: true)]
        public virtual oci.DataOciWaasCertificates.IDataOciWaasCertificatesCertificates? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciWaasCertificates.IDataOciWaasCertificatesCertificates?>();
            set => SetInstanceProperty(value);
        }
    }
}
