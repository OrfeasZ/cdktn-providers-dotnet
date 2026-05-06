using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseManagementExternalDbSystemDiscoveries
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseManagementExternalDbSystemDiscoveries.DataOciDatabaseManagementExternalDbSystemDiscoveriesExternalDbSystemDiscoveryCollectionItemsDiscoveredComponentsClusterInstancesConnectorConnectionInfoOutputReference), fullyQualifiedName: "oci.dataOciDatabaseManagementExternalDbSystemDiscoveries.DataOciDatabaseManagementExternalDbSystemDiscoveriesExternalDbSystemDiscoveryCollectionItemsDiscoveredComponentsClusterInstancesConnectorConnectionInfoOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseManagementExternalDbSystemDiscoveriesExternalDbSystemDiscoveryCollectionItemsDiscoveredComponentsClusterInstancesConnectorConnectionInfoOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseManagementExternalDbSystemDiscoveriesExternalDbSystemDiscoveryCollectionItemsDiscoveredComponentsClusterInstancesConnectorConnectionInfoOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseManagementExternalDbSystemDiscoveriesExternalDbSystemDiscoveryCollectionItemsDiscoveredComponentsClusterInstancesConnectorConnectionInfoOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseManagementExternalDbSystemDiscoveriesExternalDbSystemDiscoveryCollectionItemsDiscoveredComponentsClusterInstancesConnectorConnectionInfoOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "componentType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComponentType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "connectionCredentials", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementExternalDbSystemDiscoveries.DataOciDatabaseManagementExternalDbSystemDiscoveriesExternalDbSystemDiscoveryCollectionItemsDiscoveredComponentsClusterInstancesConnectorConnectionInfoConnectionCredentialsList\"}")]
        public virtual oci.DataOciDatabaseManagementExternalDbSystemDiscoveries.DataOciDatabaseManagementExternalDbSystemDiscoveriesExternalDbSystemDiscoveryCollectionItemsDiscoveredComponentsClusterInstancesConnectorConnectionInfoConnectionCredentialsList ConnectionCredentials
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementExternalDbSystemDiscoveries.DataOciDatabaseManagementExternalDbSystemDiscoveriesExternalDbSystemDiscoveryCollectionItemsDiscoveredComponentsClusterInstancesConnectorConnectionInfoConnectionCredentialsList>()!;
        }

        [JsiiProperty(name: "connectionString", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementExternalDbSystemDiscoveries.DataOciDatabaseManagementExternalDbSystemDiscoveriesExternalDbSystemDiscoveryCollectionItemsDiscoveredComponentsClusterInstancesConnectorConnectionInfoConnectionStringList\"}")]
        public virtual oci.DataOciDatabaseManagementExternalDbSystemDiscoveries.DataOciDatabaseManagementExternalDbSystemDiscoveriesExternalDbSystemDiscoveryCollectionItemsDiscoveredComponentsClusterInstancesConnectorConnectionInfoConnectionStringList ConnectionString
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementExternalDbSystemDiscoveries.DataOciDatabaseManagementExternalDbSystemDiscoveriesExternalDbSystemDiscoveryCollectionItemsDiscoveredComponentsClusterInstancesConnectorConnectionInfoConnectionStringList>()!;
        }

        [JsiiProperty(name: "databaseCredential", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementExternalDbSystemDiscoveries.DataOciDatabaseManagementExternalDbSystemDiscoveriesExternalDbSystemDiscoveryCollectionItemsDiscoveredComponentsClusterInstancesConnectorConnectionInfoDatabaseCredentialList\"}")]
        public virtual oci.DataOciDatabaseManagementExternalDbSystemDiscoveries.DataOciDatabaseManagementExternalDbSystemDiscoveriesExternalDbSystemDiscoveryCollectionItemsDiscoveredComponentsClusterInstancesConnectorConnectionInfoDatabaseCredentialList DatabaseCredential
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementExternalDbSystemDiscoveries.DataOciDatabaseManagementExternalDbSystemDiscoveriesExternalDbSystemDiscoveryCollectionItemsDiscoveredComponentsClusterInstancesConnectorConnectionInfoDatabaseCredentialList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementExternalDbSystemDiscoveries.DataOciDatabaseManagementExternalDbSystemDiscoveriesExternalDbSystemDiscoveryCollectionItemsDiscoveredComponentsClusterInstancesConnectorConnectionInfo\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseManagementExternalDbSystemDiscoveries.IDataOciDatabaseManagementExternalDbSystemDiscoveriesExternalDbSystemDiscoveryCollectionItemsDiscoveredComponentsClusterInstancesConnectorConnectionInfo? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementExternalDbSystemDiscoveries.IDataOciDatabaseManagementExternalDbSystemDiscoveriesExternalDbSystemDiscoveryCollectionItemsDiscoveredComponentsClusterInstancesConnectorConnectionInfo?>();
            set => SetInstanceProperty(value);
        }
    }
}
