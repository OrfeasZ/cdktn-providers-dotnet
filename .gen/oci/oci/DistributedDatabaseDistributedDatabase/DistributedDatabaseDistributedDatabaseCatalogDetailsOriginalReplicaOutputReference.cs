using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedDatabase
{
    [JsiiClass(nativeType: typeof(oci.DistributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCatalogDetailsOriginalReplicaOutputReference), fullyQualifiedName: "oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCatalogDetailsOriginalReplicaOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DistributedDatabaseDistributedDatabaseCatalogDetailsOriginalReplicaOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DistributedDatabaseDistributedDatabaseCatalogDetailsOriginalReplicaOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DistributedDatabaseDistributedDatabaseCatalogDetailsOriginalReplicaOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DistributedDatabaseDistributedDatabaseCatalogDetailsOriginalReplicaOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDatabase", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCatalogDetailsOriginalReplicaDatabase\"}}]")]
        public virtual void PutDatabase(oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseCatalogDetailsOriginalReplicaDatabase @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseCatalogDetailsOriginalReplicaDatabase)}, new object[]{@value});
        }

        [JsiiProperty(name: "database", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCatalogDetailsOriginalReplicaDatabaseOutputReference\"}")]
        public virtual oci.DistributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCatalogDetailsOriginalReplicaDatabaseOutputReference Database
        {
            get => GetInstanceProperty<oci.DistributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCatalogDetailsOriginalReplicaDatabaseOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseInput", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCatalogDetailsOriginalReplicaDatabase\"}", isOptional: true)]
        public virtual oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseCatalogDetailsOriginalReplicaDatabase? DatabaseInput
        {
            get => GetInstanceProperty<oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseCatalogDetailsOriginalReplicaDatabase?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseCatalogDetailsOriginalReplica\"}", isOptional: true)]
        public virtual oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseCatalogDetailsOriginalReplica? InternalValue
        {
            get => GetInstanceProperty<oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseCatalogDetailsOriginalReplica?>();
            set => SetInstanceProperty(value);
        }
    }
}
