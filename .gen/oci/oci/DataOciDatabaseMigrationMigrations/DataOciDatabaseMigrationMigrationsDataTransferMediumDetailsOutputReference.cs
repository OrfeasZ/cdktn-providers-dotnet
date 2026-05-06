using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseMigrationMigrations
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseMigrationMigrations.DataOciDatabaseMigrationMigrationsDataTransferMediumDetailsOutputReference), fullyQualifiedName: "oci.dataOciDatabaseMigrationMigrations.DataOciDatabaseMigrationMigrationsDataTransferMediumDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseMigrationMigrationsDataTransferMediumDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseMigrationMigrationsDataTransferMediumDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseMigrationMigrationsDataTransferMediumDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseMigrationMigrationsDataTransferMediumDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "accessKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccessKeyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "objectStorageBucket", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationMigrations.DataOciDatabaseMigrationMigrationsDataTransferMediumDetailsObjectStorageBucketList\"}")]
        public virtual oci.DataOciDatabaseMigrationMigrations.DataOciDatabaseMigrationMigrationsDataTransferMediumDetailsObjectStorageBucketList ObjectStorageBucket
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationMigrations.DataOciDatabaseMigrationMigrationsDataTransferMediumDetailsObjectStorageBucketList>()!;
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secretAccessKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecretAccessKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sharedStorageMountTargetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SharedStorageMountTargetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationMigrations.DataOciDatabaseMigrationMigrationsDataTransferMediumDetailsSourceList\"}")]
        public virtual oci.DataOciDatabaseMigrationMigrations.DataOciDatabaseMigrationMigrationsDataTransferMediumDetailsSourceList Source
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationMigrations.DataOciDatabaseMigrationMigrationsDataTransferMediumDetailsSourceList>()!;
        }

        [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationMigrations.DataOciDatabaseMigrationMigrationsDataTransferMediumDetailsTargetList\"}")]
        public virtual oci.DataOciDatabaseMigrationMigrations.DataOciDatabaseMigrationMigrationsDataTransferMediumDetailsTargetList Target
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationMigrations.DataOciDatabaseMigrationMigrationsDataTransferMediumDetailsTargetList>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMigrationMigrations.DataOciDatabaseMigrationMigrationsDataTransferMediumDetails\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseMigrationMigrations.IDataOciDatabaseMigrationMigrationsDataTransferMediumDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMigrationMigrations.IDataOciDatabaseMigrationMigrationsDataTransferMediumDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
