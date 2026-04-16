using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsDynamodbBackups
{
    [JsiiClass(nativeType: typeof(aws.DataAwsDynamodbBackups.DataAwsDynamodbBackupsBackupSummariesOutputReference), fullyQualifiedName: "aws.dataAwsDynamodbBackups.DataAwsDynamodbBackupsBackupSummariesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsDynamodbBackupsBackupSummariesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsDynamodbBackupsBackupSummariesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsDynamodbBackupsBackupSummariesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsDynamodbBackupsBackupSummariesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "backupArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackupArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "backupCreationDateTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackupCreationDateTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "backupExpiryDateTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackupExpiryDateTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "backupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackupName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "backupSizeBytes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BackupSizeBytes
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "backupStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackupStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "backupType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackupType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tableArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TableArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tableId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TableId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TableName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsDynamodbBackups.DataAwsDynamodbBackupsBackupSummaries\"}", isOptional: true)]
        public virtual aws.DataAwsDynamodbBackups.IDataAwsDynamodbBackupsBackupSummaries? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsDynamodbBackups.IDataAwsDynamodbBackupsBackupSummaries?>();
            set => SetInstanceProperty(value);
        }
    }
}
