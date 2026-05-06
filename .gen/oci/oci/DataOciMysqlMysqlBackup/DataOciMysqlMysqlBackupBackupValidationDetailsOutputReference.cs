using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciMysqlMysqlBackup
{
    [JsiiClass(nativeType: typeof(oci.DataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupBackupValidationDetailsOutputReference), fullyQualifiedName: "oci.dataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupBackupValidationDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciMysqlMysqlBackupBackupValidationDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciMysqlMysqlBackupBackupValidationDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciMysqlMysqlBackupBackupValidationDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciMysqlMysqlBackupBackupValidationDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "backupPreparationStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackupPreparationStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "errorMessage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ErrorMessage
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "estimatedRestoreDuration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EstimatedRestoreDuration
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "preparedBackupDetails", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupBackupValidationDetailsPreparedBackupDetailsList\"}")]
        public virtual oci.DataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupBackupValidationDetailsPreparedBackupDetailsList PreparedBackupDetails
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupBackupValidationDetailsPreparedBackupDetailsList>()!;
        }

        [JsiiProperty(name: "timeLastValidated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLastValidated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "validationStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ValidationStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlBackup.DataOciMysqlMysqlBackupBackupValidationDetails\"}", isOptional: true)]
        public virtual oci.DataOciMysqlMysqlBackup.IDataOciMysqlMysqlBackupBackupValidationDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlBackup.IDataOciMysqlMysqlBackupBackupValidationDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
