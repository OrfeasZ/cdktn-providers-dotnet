using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeCryptoAssessment
{
    [JsiiClass(nativeType: typeof(oci.DataOciDataSafeCryptoAssessment.DataOciDataSafeCryptoAssessmentCryptoPostureOutputReference), fullyQualifiedName: "oci.dataOciDataSafeCryptoAssessment.DataOciDataSafeCryptoAssessmentCryptoPostureOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDataSafeCryptoAssessmentCryptoPostureOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDataSafeCryptoAssessmentCryptoPostureOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDataSafeCryptoAssessmentCryptoPostureOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeCryptoAssessmentCryptoPostureOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "backupStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackupStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "encryptedBackupPiecesCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EncryptedBackupPiecesCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "fipsModeConfigured", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FipsModeConfigured
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fipsStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FipsStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkEncryption", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NetworkEncryption
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "nne", typeJson: "{\"fqn\":\"oci.dataOciDataSafeCryptoAssessment.DataOciDataSafeCryptoAssessmentCryptoPostureNneList\"}")]
        public virtual oci.DataOciDataSafeCryptoAssessment.DataOciDataSafeCryptoAssessmentCryptoPostureNneList Nne
        {
            get => GetInstanceProperty<oci.DataOciDataSafeCryptoAssessment.DataOciDataSafeCryptoAssessmentCryptoPostureNneList>()!;
        }

        [JsiiProperty(name: "tde", typeJson: "{\"fqn\":\"oci.dataOciDataSafeCryptoAssessment.DataOciDataSafeCryptoAssessmentCryptoPostureTdeList\"}")]
        public virtual oci.DataOciDataSafeCryptoAssessment.DataOciDataSafeCryptoAssessmentCryptoPostureTdeList Tde
        {
            get => GetInstanceProperty<oci.DataOciDataSafeCryptoAssessment.DataOciDataSafeCryptoAssessmentCryptoPostureTdeList>()!;
        }

        [JsiiProperty(name: "tls", typeJson: "{\"fqn\":\"oci.dataOciDataSafeCryptoAssessment.DataOciDataSafeCryptoAssessmentCryptoPostureTlsList\"}")]
        public virtual oci.DataOciDataSafeCryptoAssessment.DataOciDataSafeCryptoAssessmentCryptoPostureTlsList Tls
        {
            get => GetInstanceProperty<oci.DataOciDataSafeCryptoAssessment.DataOciDataSafeCryptoAssessmentCryptoPostureTlsList>()!;
        }

        [JsiiProperty(name: "unencryptedBackupPiecesCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double UnencryptedBackupPiecesCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDataSafeCryptoAssessment.DataOciDataSafeCryptoAssessmentCryptoPosture\"}", isOptional: true)]
        public virtual oci.DataOciDataSafeCryptoAssessment.IDataOciDataSafeCryptoAssessmentCryptoPosture? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDataSafeCryptoAssessment.IDataOciDataSafeCryptoAssessmentCryptoPosture?>();
            set => SetInstanceProperty(value);
        }
    }
}
