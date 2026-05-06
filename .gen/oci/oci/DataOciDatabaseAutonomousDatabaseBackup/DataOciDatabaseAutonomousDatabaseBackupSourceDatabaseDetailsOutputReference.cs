using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseAutonomousDatabaseBackup
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseAutonomousDatabaseBackup.DataOciDatabaseAutonomousDatabaseBackupSourceDatabaseDetailsOutputReference), fullyQualifiedName: "oci.dataOciDatabaseAutonomousDatabaseBackup.DataOciDatabaseAutonomousDatabaseBackupSourceDatabaseDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseAutonomousDatabaseBackupSourceDatabaseDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseAutonomousDatabaseBackupSourceDatabaseDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseAutonomousDatabaseBackupSourceDatabaseDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseAutonomousDatabaseBackupSourceDatabaseDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "autonomousContainerDatabaseCustomerContacts", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousDatabaseBackup.DataOciDatabaseAutonomousDatabaseBackupSourceDatabaseDetailsAutonomousContainerDatabaseCustomerContactsList\"}")]
        public virtual oci.DataOciDatabaseAutonomousDatabaseBackup.DataOciDatabaseAutonomousDatabaseBackupSourceDatabaseDetailsAutonomousContainerDatabaseCustomerContactsList AutonomousContainerDatabaseCustomerContacts
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousDatabaseBackup.DataOciDatabaseAutonomousDatabaseBackupSourceDatabaseDetailsAutonomousContainerDatabaseCustomerContactsList>()!;
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

        [JsiiProperty(name: "autonomousDatabaseCustomerContacts", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousDatabaseBackup.DataOciDatabaseAutonomousDatabaseBackupSourceDatabaseDetailsAutonomousDatabaseCustomerContactsList\"}")]
        public virtual oci.DataOciDatabaseAutonomousDatabaseBackup.DataOciDatabaseAutonomousDatabaseBackupSourceDatabaseDetailsAutonomousDatabaseCustomerContactsList AutonomousDatabaseCustomerContacts
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousDatabaseBackup.DataOciDatabaseAutonomousDatabaseBackupSourceDatabaseDetailsAutonomousDatabaseCustomerContactsList>()!;
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousDatabaseBackup.DataOciDatabaseAutonomousDatabaseBackupSourceDatabaseDetails\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseAutonomousDatabaseBackup.IDataOciDatabaseAutonomousDatabaseBackupSourceDatabaseDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousDatabaseBackup.IDataOciDatabaseAutonomousDatabaseBackupSourceDatabaseDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
