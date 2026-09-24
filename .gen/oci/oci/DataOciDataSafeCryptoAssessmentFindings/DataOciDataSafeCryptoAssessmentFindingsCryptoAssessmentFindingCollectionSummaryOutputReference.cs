using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeCryptoAssessmentFindings
{
    [JsiiClass(nativeType: typeof(oci.DataOciDataSafeCryptoAssessmentFindings.DataOciDataSafeCryptoAssessmentFindingsCryptoAssessmentFindingCollectionSummaryOutputReference), fullyQualifiedName: "oci.dataOciDataSafeCryptoAssessmentFindings.DataOciDataSafeCryptoAssessmentFindingsCryptoAssessmentFindingCollectionSummaryOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDataSafeCryptoAssessmentFindingsCryptoAssessmentFindingCollectionSummaryOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDataSafeCryptoAssessmentFindingsCryptoAssessmentFindingCollectionSummaryOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDataSafeCryptoAssessmentFindingsCryptoAssessmentFindingCollectionSummaryOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeCryptoAssessmentFindingsCryptoAssessmentFindingCollectionSummaryOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "backupStatus", typeJson: "{\"fqn\":\"oci.dataOciDataSafeCryptoAssessmentFindings.DataOciDataSafeCryptoAssessmentFindingsCryptoAssessmentFindingCollectionSummaryBackupStatusList\"}")]
        public virtual oci.DataOciDataSafeCryptoAssessmentFindings.DataOciDataSafeCryptoAssessmentFindingsCryptoAssessmentFindingCollectionSummaryBackupStatusList BackupStatus
        {
            get => GetInstanceProperty<oci.DataOciDataSafeCryptoAssessmentFindings.DataOciDataSafeCryptoAssessmentFindingsCryptoAssessmentFindingCollectionSummaryBackupStatusList>()!;
        }

        [JsiiProperty(name: "critical", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Critical
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "dataEncryptionStatus", typeJson: "{\"fqn\":\"oci.dataOciDataSafeCryptoAssessmentFindings.DataOciDataSafeCryptoAssessmentFindingsCryptoAssessmentFindingCollectionSummaryDataEncryptionStatusList\"}")]
        public virtual oci.DataOciDataSafeCryptoAssessmentFindings.DataOciDataSafeCryptoAssessmentFindingsCryptoAssessmentFindingCollectionSummaryDataEncryptionStatusList DataEncryptionStatus
        {
            get => GetInstanceProperty<oci.DataOciDataSafeCryptoAssessmentFindings.DataOciDataSafeCryptoAssessmentFindingsCryptoAssessmentFindingCollectionSummaryDataEncryptionStatusList>()!;
        }

        [JsiiProperty(name: "high", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double High
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "low", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Low
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "med", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Med
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "networkEncryptionStatus", typeJson: "{\"fqn\":\"oci.dataOciDataSafeCryptoAssessmentFindings.DataOciDataSafeCryptoAssessmentFindingsCryptoAssessmentFindingCollectionSummaryNetworkEncryptionStatusList\"}")]
        public virtual oci.DataOciDataSafeCryptoAssessmentFindings.DataOciDataSafeCryptoAssessmentFindingsCryptoAssessmentFindingCollectionSummaryNetworkEncryptionStatusList NetworkEncryptionStatus
        {
            get => GetInstanceProperty<oci.DataOciDataSafeCryptoAssessmentFindings.DataOciDataSafeCryptoAssessmentFindingsCryptoAssessmentFindingCollectionSummaryNetworkEncryptionStatusList>()!;
        }

        [JsiiProperty(name: "statusCounts", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap StatusCounts
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "totalChecks", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalChecks
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "totalFindings", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalFindings
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "walletStatus", typeJson: "{\"fqn\":\"oci.dataOciDataSafeCryptoAssessmentFindings.DataOciDataSafeCryptoAssessmentFindingsCryptoAssessmentFindingCollectionSummaryWalletStatusList\"}")]
        public virtual oci.DataOciDataSafeCryptoAssessmentFindings.DataOciDataSafeCryptoAssessmentFindingsCryptoAssessmentFindingCollectionSummaryWalletStatusList WalletStatus
        {
            get => GetInstanceProperty<oci.DataOciDataSafeCryptoAssessmentFindings.DataOciDataSafeCryptoAssessmentFindingsCryptoAssessmentFindingCollectionSummaryWalletStatusList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDataSafeCryptoAssessmentFindings.DataOciDataSafeCryptoAssessmentFindingsCryptoAssessmentFindingCollectionSummary\"}", isOptional: true)]
        public virtual oci.DataOciDataSafeCryptoAssessmentFindings.IDataOciDataSafeCryptoAssessmentFindingsCryptoAssessmentFindingCollectionSummary? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDataSafeCryptoAssessmentFindings.IDataOciDataSafeCryptoAssessmentFindingsCryptoAssessmentFindingCollectionSummary?>();
            set => SetInstanceProperty(value);
        }
    }
}
