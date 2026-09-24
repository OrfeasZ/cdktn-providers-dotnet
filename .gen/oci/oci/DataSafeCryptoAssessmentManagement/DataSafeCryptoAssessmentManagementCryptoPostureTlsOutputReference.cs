using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeCryptoAssessmentManagement
{
    [JsiiClass(nativeType: typeof(oci.DataSafeCryptoAssessmentManagement.DataSafeCryptoAssessmentManagementCryptoPostureTlsOutputReference), fullyQualifiedName: "oci.dataSafeCryptoAssessmentManagement.DataSafeCryptoAssessmentManagementCryptoPostureTlsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataSafeCryptoAssessmentManagementCryptoPostureTlsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataSafeCryptoAssessmentManagementCryptoPostureTlsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataSafeCryptoAssessmentManagementCryptoPostureTlsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataSafeCryptoAssessmentManagementCryptoPostureTlsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "areWeakCipherSuitesAllowed", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AreWeakCipherSuitesAllowed
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cipherSuitesConfigured", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] CipherSuitesConfigured
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "fipsModeConfigured", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FipsModeConfigured
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isMtlsConfigured", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IsMtlsConfigured
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "quantumReadiness", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string QuantumReadiness
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "revocationMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RevocationMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "versions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Versions
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "walletLocation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WalletLocation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataSafeCryptoAssessmentManagement.DataSafeCryptoAssessmentManagementCryptoPostureTls\"}", isOptional: true)]
        public virtual oci.DataSafeCryptoAssessmentManagement.IDataSafeCryptoAssessmentManagementCryptoPostureTls? InternalValue
        {
            get => GetInstanceProperty<oci.DataSafeCryptoAssessmentManagement.IDataSafeCryptoAssessmentManagementCryptoPostureTls?>();
            set => SetInstanceProperty(value);
        }
    }
}
