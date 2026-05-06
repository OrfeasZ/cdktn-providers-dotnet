using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseManagementManagedMySqlDatabaseInboundReplications
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseManagementManagedMySqlDatabaseInboundReplications.DataOciDatabaseManagementManagedMySqlDatabaseInboundReplicationsManagedMySqlDatabaseInboundReplicationCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDatabaseManagementManagedMySqlDatabaseInboundReplications.DataOciDatabaseManagementManagedMySqlDatabaseInboundReplicationsManagedMySqlDatabaseInboundReplicationCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseManagementManagedMySqlDatabaseInboundReplicationsManagedMySqlDatabaseInboundReplicationCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseManagementManagedMySqlDatabaseInboundReplicationsManagedMySqlDatabaseInboundReplicationCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseManagementManagedMySqlDatabaseInboundReplicationsManagedMySqlDatabaseInboundReplicationCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseManagementManagedMySqlDatabaseInboundReplicationsManagedMySqlDatabaseInboundReplicationCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "applierFilters", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementManagedMySqlDatabaseInboundReplications.DataOciDatabaseManagementManagedMySqlDatabaseInboundReplicationsManagedMySqlDatabaseInboundReplicationCollectionItemsApplierFiltersList\"}")]
        public virtual oci.DataOciDatabaseManagementManagedMySqlDatabaseInboundReplications.DataOciDatabaseManagementManagedMySqlDatabaseInboundReplicationsManagedMySqlDatabaseInboundReplicationCollectionItemsApplierFiltersList ApplierFilters
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementManagedMySqlDatabaseInboundReplications.DataOciDatabaseManagementManagedMySqlDatabaseInboundReplicationsManagedMySqlDatabaseInboundReplicationCollectionItemsApplierFiltersList>()!;
        }

        [JsiiProperty(name: "applyDelay", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ApplyDelay
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "applyError", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementManagedMySqlDatabaseInboundReplications.DataOciDatabaseManagementManagedMySqlDatabaseInboundReplicationsManagedMySqlDatabaseInboundReplicationCollectionItemsApplyErrorList\"}")]
        public virtual oci.DataOciDatabaseManagementManagedMySqlDatabaseInboundReplications.DataOciDatabaseManagementManagedMySqlDatabaseInboundReplicationsManagedMySqlDatabaseInboundReplicationCollectionItemsApplyErrorList ApplyError
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementManagedMySqlDatabaseInboundReplications.DataOciDatabaseManagementManagedMySqlDatabaseInboundReplicationsManagedMySqlDatabaseInboundReplicationCollectionItemsApplyErrorList>()!;
        }

        [JsiiProperty(name: "applyStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplyStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "busyWorkers", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BusyWorkers
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "channelName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ChannelName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "desiredDelaySeconds", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DesiredDelaySeconds
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fetchError", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementManagedMySqlDatabaseInboundReplications.DataOciDatabaseManagementManagedMySqlDatabaseInboundReplicationsManagedMySqlDatabaseInboundReplicationCollectionItemsFetchErrorList\"}")]
        public virtual oci.DataOciDatabaseManagementManagedMySqlDatabaseInboundReplications.DataOciDatabaseManagementManagedMySqlDatabaseInboundReplicationsManagedMySqlDatabaseInboundReplicationCollectionItemsFetchErrorList FetchError
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementManagedMySqlDatabaseInboundReplications.DataOciDatabaseManagementManagedMySqlDatabaseInboundReplicationsManagedMySqlDatabaseInboundReplicationCollectionItemsFetchErrorList>()!;
        }

        [JsiiProperty(name: "fetchStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FetchStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "gtidAssignment", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GtidAssignment
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "relayLogStorageSpaceUsed", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RelayLogStorageSpaceUsed
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "remainingDelaySeconds", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RemainingDelaySeconds
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "retrievedGtidSet", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RetrievedGtidSet
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondsBehindSource", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondsBehindSource
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceHost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceHost
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourcePort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SourcePort
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "sourceServerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceServerId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceUuid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceUuid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "transactionsReceived", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TransactionsReceived
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementManagedMySqlDatabaseInboundReplications.DataOciDatabaseManagementManagedMySqlDatabaseInboundReplicationsManagedMySqlDatabaseInboundReplicationCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseManagementManagedMySqlDatabaseInboundReplications.IDataOciDatabaseManagementManagedMySqlDatabaseInboundReplicationsManagedMySqlDatabaseInboundReplicationCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementManagedMySqlDatabaseInboundReplications.IDataOciDatabaseManagementManagedMySqlDatabaseInboundReplicationsManagedMySqlDatabaseInboundReplicationCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
