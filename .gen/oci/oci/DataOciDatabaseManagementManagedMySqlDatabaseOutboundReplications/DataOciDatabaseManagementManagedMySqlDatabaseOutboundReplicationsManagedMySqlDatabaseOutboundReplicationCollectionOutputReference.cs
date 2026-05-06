using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseManagementManagedMySqlDatabaseOutboundReplications
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseManagementManagedMySqlDatabaseOutboundReplications.DataOciDatabaseManagementManagedMySqlDatabaseOutboundReplicationsManagedMySqlDatabaseOutboundReplicationCollectionOutputReference), fullyQualifiedName: "oci.dataOciDatabaseManagementManagedMySqlDatabaseOutboundReplications.DataOciDatabaseManagementManagedMySqlDatabaseOutboundReplicationsManagedMySqlDatabaseOutboundReplicationCollectionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseManagementManagedMySqlDatabaseOutboundReplicationsManagedMySqlDatabaseOutboundReplicationCollectionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseManagementManagedMySqlDatabaseOutboundReplicationsManagedMySqlDatabaseOutboundReplicationCollectionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseManagementManagedMySqlDatabaseOutboundReplicationsManagedMySqlDatabaseOutboundReplicationCollectionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseManagementManagedMySqlDatabaseOutboundReplicationsManagedMySqlDatabaseOutboundReplicationCollectionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "items", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementManagedMySqlDatabaseOutboundReplications.DataOciDatabaseManagementManagedMySqlDatabaseOutboundReplicationsManagedMySqlDatabaseOutboundReplicationCollectionItemsList\"}")]
        public virtual oci.DataOciDatabaseManagementManagedMySqlDatabaseOutboundReplications.DataOciDatabaseManagementManagedMySqlDatabaseOutboundReplicationsManagedMySqlDatabaseOutboundReplicationCollectionItemsList Items
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementManagedMySqlDatabaseOutboundReplications.DataOciDatabaseManagementManagedMySqlDatabaseOutboundReplicationsManagedMySqlDatabaseOutboundReplicationCollectionItemsList>()!;
        }

        [JsiiProperty(name: "outboundReplicationsCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double OutboundReplicationsCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementManagedMySqlDatabaseOutboundReplications.DataOciDatabaseManagementManagedMySqlDatabaseOutboundReplicationsManagedMySqlDatabaseOutboundReplicationCollection\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseManagementManagedMySqlDatabaseOutboundReplications.IDataOciDatabaseManagementManagedMySqlDatabaseOutboundReplicationsManagedMySqlDatabaseOutboundReplicationCollection? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementManagedMySqlDatabaseOutboundReplications.IDataOciDatabaseManagementManagedMySqlDatabaseOutboundReplicationsManagedMySqlDatabaseOutboundReplicationCollection?>();
            set => SetInstanceProperty(value);
        }
    }
}
