using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAutonomousContainerDatabase
{
    [JsiiClass(nativeType: typeof(oci.DatabaseAutonomousContainerDatabase.DatabaseAutonomousContainerDatabaseBackupConfigOutputReference), fullyQualifiedName: "oci.databaseAutonomousContainerDatabase.DatabaseAutonomousContainerDatabaseBackupConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatabaseAutonomousContainerDatabaseBackupConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatabaseAutonomousContainerDatabaseBackupConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseAutonomousContainerDatabaseBackupConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseAutonomousContainerDatabaseBackupConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putBackupDestinationDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseAutonomousContainerDatabase.DatabaseAutonomousContainerDatabaseBackupConfigBackupDestinationDetails\"}}]")]
        public virtual void PutBackupDestinationDetails(oci.DatabaseAutonomousContainerDatabase.IDatabaseAutonomousContainerDatabaseBackupConfigBackupDestinationDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseAutonomousContainerDatabase.IDatabaseAutonomousContainerDatabaseBackupConfigBackupDestinationDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBackupDestinationDetails")]
        public virtual void ResetBackupDestinationDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRecoveryWindowInDays")]
        public virtual void ResetRecoveryWindowInDays()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "backupDestinationDetails", typeJson: "{\"fqn\":\"oci.databaseAutonomousContainerDatabase.DatabaseAutonomousContainerDatabaseBackupConfigBackupDestinationDetailsOutputReference\"}")]
        public virtual oci.DatabaseAutonomousContainerDatabase.DatabaseAutonomousContainerDatabaseBackupConfigBackupDestinationDetailsOutputReference BackupDestinationDetails
        {
            get => GetInstanceProperty<oci.DatabaseAutonomousContainerDatabase.DatabaseAutonomousContainerDatabaseBackupConfigBackupDestinationDetailsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "backupDestinationDetailsInput", typeJson: "{\"fqn\":\"oci.databaseAutonomousContainerDatabase.DatabaseAutonomousContainerDatabaseBackupConfigBackupDestinationDetails\"}", isOptional: true)]
        public virtual oci.DatabaseAutonomousContainerDatabase.IDatabaseAutonomousContainerDatabaseBackupConfigBackupDestinationDetails? BackupDestinationDetailsInput
        {
            get => GetInstanceProperty<oci.DatabaseAutonomousContainerDatabase.IDatabaseAutonomousContainerDatabaseBackupConfigBackupDestinationDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "recoveryWindowInDaysInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? RecoveryWindowInDaysInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "recoveryWindowInDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RecoveryWindowInDays
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.databaseAutonomousContainerDatabase.DatabaseAutonomousContainerDatabaseBackupConfig\"}", isOptional: true)]
        public virtual oci.DatabaseAutonomousContainerDatabase.IDatabaseAutonomousContainerDatabaseBackupConfig? InternalValue
        {
            get => GetInstanceProperty<oci.DatabaseAutonomousContainerDatabase.IDatabaseAutonomousContainerDatabaseBackupConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
