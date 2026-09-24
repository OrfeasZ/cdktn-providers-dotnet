using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeCryptoAssessment
{
    [JsiiClass(nativeType: typeof(oci.DataSafeCryptoAssessment.DataSafeCryptoAssessmentCryptoPostureTdeOutputReference), fullyQualifiedName: "oci.dataSafeCryptoAssessment.DataSafeCryptoAssessmentCryptoPostureTdeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataSafeCryptoAssessmentCryptoPostureTdeOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataSafeCryptoAssessmentCryptoPostureTdeOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataSafeCryptoAssessmentCryptoPostureTdeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataSafeCryptoAssessmentCryptoPostureTdeOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "dbCredentialsEncryptionObserved", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbCredentialsEncryptionObserved
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "encryptedTablespacesCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EncryptedTablespacesCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "encryptionConfigured", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] EncryptionConfigured
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "fipsModeConfigured", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FipsModeConfigured
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "integrityConfigured", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IntegrityConfigured
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "keyCacheStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyCacheStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "keyStoreType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyStoreType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "masterKeyEncryptionAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MasterKeyEncryptionAlgorithm
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "masterKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MasterKeyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "quantumReadiness", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string QuantumReadiness
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "redoEncryptionObserved", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RedoEncryptionObserved
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeMasterKeyLastRotation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeMasterKeyLastRotation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "unencryptedTablespacesCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double UnencryptedTablespacesCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "walletLocation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WalletLocation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataSafeCryptoAssessment.DataSafeCryptoAssessmentCryptoPostureTde\"}", isOptional: true)]
        public virtual oci.DataSafeCryptoAssessment.IDataSafeCryptoAssessmentCryptoPostureTde? InternalValue
        {
            get => GetInstanceProperty<oci.DataSafeCryptoAssessment.IDataSafeCryptoAssessmentCryptoPostureTde?>();
            set => SetInstanceProperty(value);
        }
    }
}
