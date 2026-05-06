using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseDbHomes
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseDbHomes.DataOciDatabaseDbHomesDbHomesDatabaseDbBackupConfigBackupDestinationDetailsOutputReference), fullyQualifiedName: "oci.dataOciDatabaseDbHomes.DataOciDatabaseDbHomesDbHomesDatabaseDbBackupConfigBackupDestinationDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseDbHomesDbHomesDatabaseDbBackupConfigBackupDestinationDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseDbHomesDbHomesDatabaseDbBackupConfigBackupDestinationDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseDbHomesDbHomesDatabaseDbBackupConfigBackupDestinationDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseDbHomesDbHomesDatabaseDbBackupConfigBackupDestinationDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "backupRetentionPolicyOnTerminate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackupRetentionPolicyOnTerminate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbrsPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbrsPolicyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isRemote", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsRemote
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isRetentionLockEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsRetentionLockEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "remoteRegion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RemoteRegion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vpcPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VpcPassword
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vpcUser", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VpcUser
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseDbHomes.DataOciDatabaseDbHomesDbHomesDatabaseDbBackupConfigBackupDestinationDetails\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseDbHomes.IDataOciDatabaseDbHomesDbHomesDatabaseDbBackupConfigBackupDestinationDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseDbHomes.IDataOciDatabaseDbHomesDbHomesDatabaseDbBackupConfigBackupDestinationDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
