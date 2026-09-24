using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeCryptoAssessmentCertificates
{
    [JsiiClass(nativeType: typeof(oci.DataOciDataSafeCryptoAssessmentCertificates.DataOciDataSafeCryptoAssessmentCertificatesCryptoAssessmentCertificateCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDataSafeCryptoAssessmentCertificates.DataOciDataSafeCryptoAssessmentCertificatesCryptoAssessmentCertificateCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDataSafeCryptoAssessmentCertificatesCryptoAssessmentCertificateCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDataSafeCryptoAssessmentCertificatesCryptoAssessmentCertificateCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDataSafeCryptoAssessmentCertificatesCryptoAssessmentCertificateCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeCryptoAssessmentCertificatesCryptoAssessmentCertificateCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "age", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Age
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "assessmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssessmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "assessmentType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssessmentType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "certificateType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "daysToExpiry", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DaysToExpiry
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "expiryBucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExpiryBucket
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Issuer
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "publicKeyType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublicKeyType
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subject", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Subject
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeLastAssessed", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLastAssessed
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeValidFrom", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeValidFrom
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeValidUntil", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeValidUntil
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "walletLocation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WalletLocation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDataSafeCryptoAssessmentCertificates.DataOciDataSafeCryptoAssessmentCertificatesCryptoAssessmentCertificateCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDataSafeCryptoAssessmentCertificates.IDataOciDataSafeCryptoAssessmentCertificatesCryptoAssessmentCertificateCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDataSafeCryptoAssessmentCertificates.IDataOciDataSafeCryptoAssessmentCertificatesCryptoAssessmentCertificateCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
