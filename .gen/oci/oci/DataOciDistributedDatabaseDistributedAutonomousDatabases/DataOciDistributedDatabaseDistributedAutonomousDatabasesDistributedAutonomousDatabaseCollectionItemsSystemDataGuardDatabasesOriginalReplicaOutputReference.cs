using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDistributedDatabaseDistributedAutonomousDatabases
{
    [JsiiClass(nativeType: typeof(oci.DataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsSystemDataGuardDatabasesOriginalReplicaOutputReference), fullyQualifiedName: "oci.dataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsSystemDataGuardDatabasesOriginalReplicaOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsSystemDataGuardDatabasesOriginalReplicaOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsSystemDataGuardDatabasesOriginalReplicaOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsSystemDataGuardDatabasesOriginalReplicaOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsSystemDataGuardDatabasesOriginalReplicaOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "databases", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsSystemDataGuardDatabasesOriginalReplicaDatabasesList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsSystemDataGuardDatabasesOriginalReplicaDatabasesList Databases
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsSystemDataGuardDatabasesOriginalReplicaDatabasesList>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsSystemDataGuardDatabasesOriginalReplica\"}", isOptional: true)]
        public virtual oci.DataOciDistributedDatabaseDistributedAutonomousDatabases.IDataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsSystemDataGuardDatabasesOriginalReplica? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedAutonomousDatabases.IDataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsSystemDataGuardDatabasesOriginalReplica?>();
            set => SetInstanceProperty(value);
        }
    }
}
