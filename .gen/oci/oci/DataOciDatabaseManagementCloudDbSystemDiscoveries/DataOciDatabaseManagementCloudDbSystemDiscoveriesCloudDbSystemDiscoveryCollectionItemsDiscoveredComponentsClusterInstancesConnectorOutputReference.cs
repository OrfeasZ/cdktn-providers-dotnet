using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseManagementCloudDbSystemDiscoveries
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseManagementCloudDbSystemDiscoveries.DataOciDatabaseManagementCloudDbSystemDiscoveriesCloudDbSystemDiscoveryCollectionItemsDiscoveredComponentsClusterInstancesConnectorOutputReference), fullyQualifiedName: "oci.dataOciDatabaseManagementCloudDbSystemDiscoveries.DataOciDatabaseManagementCloudDbSystemDiscoveriesCloudDbSystemDiscoveryCollectionItemsDiscoveredComponentsClusterInstancesConnectorOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseManagementCloudDbSystemDiscoveriesCloudDbSystemDiscoveryCollectionItemsDiscoveredComponentsClusterInstancesConnectorOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseManagementCloudDbSystemDiscoveriesCloudDbSystemDiscoveryCollectionItemsDiscoveredComponentsClusterInstancesConnectorOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseManagementCloudDbSystemDiscoveriesCloudDbSystemDiscoveryCollectionItemsDiscoveredComponentsClusterInstancesConnectorOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseManagementCloudDbSystemDiscoveriesCloudDbSystemDiscoveryCollectionItemsDiscoveredComponentsClusterInstancesConnectorOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "agentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AgentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "connectionFailureMessage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectionFailureMessage
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "connectionInfo", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementCloudDbSystemDiscoveries.DataOciDatabaseManagementCloudDbSystemDiscoveriesCloudDbSystemDiscoveryCollectionItemsDiscoveredComponentsClusterInstancesConnectorConnectionInfoList\"}")]
        public virtual oci.DataOciDatabaseManagementCloudDbSystemDiscoveries.DataOciDatabaseManagementCloudDbSystemDiscoveriesCloudDbSystemDiscoveryCollectionItemsDiscoveredComponentsClusterInstancesConnectorConnectionInfoList ConnectionInfo
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementCloudDbSystemDiscoveries.DataOciDatabaseManagementCloudDbSystemDiscoveriesCloudDbSystemDiscoveryCollectionItemsDiscoveredComponentsClusterInstancesConnectorConnectionInfoList>()!;
        }

        [JsiiProperty(name: "connectionStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectionStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "connectorType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectorType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeConnectionStatusLastUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeConnectionStatusLastUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementCloudDbSystemDiscoveries.DataOciDatabaseManagementCloudDbSystemDiscoveriesCloudDbSystemDiscoveryCollectionItemsDiscoveredComponentsClusterInstancesConnector\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseManagementCloudDbSystemDiscoveries.IDataOciDatabaseManagementCloudDbSystemDiscoveriesCloudDbSystemDiscoveryCollectionItemsDiscoveredComponentsClusterInstancesConnector? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementCloudDbSystemDiscoveries.IDataOciDatabaseManagementCloudDbSystemDiscoveriesCloudDbSystemDiscoveryCollectionItemsDiscoveredComponentsClusterInstancesConnector?>();
            set => SetInstanceProperty(value);
        }
    }
}
