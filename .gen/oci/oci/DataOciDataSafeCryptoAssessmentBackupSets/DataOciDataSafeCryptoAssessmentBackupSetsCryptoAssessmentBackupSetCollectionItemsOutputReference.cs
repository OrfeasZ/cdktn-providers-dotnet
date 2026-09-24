using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeCryptoAssessmentBackupSets
{
    [JsiiClass(nativeType: typeof(oci.DataOciDataSafeCryptoAssessmentBackupSets.DataOciDataSafeCryptoAssessmentBackupSetsCryptoAssessmentBackupSetCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDataSafeCryptoAssessmentBackupSets.DataOciDataSafeCryptoAssessmentBackupSetsCryptoAssessmentBackupSetCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDataSafeCryptoAssessmentBackupSetsCryptoAssessmentBackupSetCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDataSafeCryptoAssessmentBackupSetsCryptoAssessmentBackupSetCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDataSafeCryptoAssessmentBackupSetsCryptoAssessmentBackupSetCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeCryptoAssessmentBackupSetsCryptoAssessmentBackupSetCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "algorithmObserved", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AlgorithmObserved
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "assessmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssessmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "backupPieces", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BackupPieces
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "backupSetKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackupSetKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "backupType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackupType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cipherModeObserved", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CipherModeObserved
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isCompressed", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsCompressed
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isEncrypted", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsEncrypted
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "setStamp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SetStamp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SizeInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeLastAssessed", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLastAssessed
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDataSafeCryptoAssessmentBackupSets.DataOciDataSafeCryptoAssessmentBackupSetsCryptoAssessmentBackupSetCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDataSafeCryptoAssessmentBackupSets.IDataOciDataSafeCryptoAssessmentBackupSetsCryptoAssessmentBackupSetCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDataSafeCryptoAssessmentBackupSets.IDataOciDataSafeCryptoAssessmentBackupSetsCryptoAssessmentBackupSetCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
