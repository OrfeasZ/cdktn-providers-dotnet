using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAutonomousDatabaseBackup
{
    [JsiiClass(nativeType: typeof(oci.DatabaseAutonomousDatabaseBackup.DatabaseAutonomousDatabaseBackupSourceDatabaseDetailsOutputReference), fullyQualifiedName: "oci.databaseAutonomousDatabaseBackup.DatabaseAutonomousDatabaseBackupSourceDatabaseDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DatabaseAutonomousDatabaseBackupSourceDatabaseDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DatabaseAutonomousDatabaseBackupSourceDatabaseDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DatabaseAutonomousDatabaseBackupSourceDatabaseDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseAutonomousDatabaseBackupSourceDatabaseDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "autonomousContainerDatabaseCustomerContacts", typeJson: "{\"fqn\":\"oci.databaseAutonomousDatabaseBackup.DatabaseAutonomousDatabaseBackupSourceDatabaseDetailsAutonomousContainerDatabaseCustomerContactsList\"}")]
        public virtual oci.DatabaseAutonomousDatabaseBackup.DatabaseAutonomousDatabaseBackupSourceDatabaseDetailsAutonomousContainerDatabaseCustomerContactsList AutonomousContainerDatabaseCustomerContacts
        {
            get => GetInstanceProperty<oci.DatabaseAutonomousDatabaseBackup.DatabaseAutonomousDatabaseBackupSourceDatabaseDetailsAutonomousContainerDatabaseCustomerContactsList>()!;
        }

        [JsiiProperty(name: "autonomousContainerDatabaseDisplayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutonomousContainerDatabaseDisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "autonomousContainerDatabaseDstFileVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutonomousContainerDatabaseDstFileVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "autonomousContainerDatabaseName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutonomousContainerDatabaseName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "autonomousDatabaseCustomerContacts", typeJson: "{\"fqn\":\"oci.databaseAutonomousDatabaseBackup.DatabaseAutonomousDatabaseBackupSourceDatabaseDetailsAutonomousDatabaseCustomerContactsList\"}")]
        public virtual oci.DatabaseAutonomousDatabaseBackup.DatabaseAutonomousDatabaseBackupSourceDatabaseDetailsAutonomousDatabaseCustomerContactsList AutonomousDatabaseCustomerContacts
        {
            get => GetInstanceProperty<oci.DatabaseAutonomousDatabaseBackup.DatabaseAutonomousDatabaseBackupSourceDatabaseDetailsAutonomousDatabaseCustomerContactsList>()!;
        }

        [JsiiProperty(name: "autonomousDatabaseName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutonomousDatabaseName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "autonomousVmClusterDisplayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutonomousVmClusterDisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbWorkload", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbWorkload
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.databaseAutonomousDatabaseBackup.DatabaseAutonomousDatabaseBackupSourceDatabaseDetails\"}", isOptional: true)]
        public virtual oci.DatabaseAutonomousDatabaseBackup.IDatabaseAutonomousDatabaseBackupSourceDatabaseDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DatabaseAutonomousDatabaseBackup.IDatabaseAutonomousDatabaseBackupSourceDatabaseDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
