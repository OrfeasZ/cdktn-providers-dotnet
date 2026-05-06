using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseManagementExternalDbSystemDiscoveries
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseManagementExternalDbSystemDiscoveries.DataOciDatabaseManagementExternalDbSystemDiscoveriesExternalDbSystemDiscoveryCollectionItemsDiscoveredComponentsPluggableDatabasesOutputReference), fullyQualifiedName: "oci.dataOciDatabaseManagementExternalDbSystemDiscoveries.DataOciDatabaseManagementExternalDbSystemDiscoveriesExternalDbSystemDiscoveryCollectionItemsDiscoveredComponentsPluggableDatabasesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseManagementExternalDbSystemDiscoveriesExternalDbSystemDiscoveryCollectionItemsDiscoveredComponentsPluggableDatabasesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseManagementExternalDbSystemDiscoveriesExternalDbSystemDiscoveryCollectionItemsDiscoveredComponentsPluggableDatabasesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseManagementExternalDbSystemDiscoveriesExternalDbSystemDiscoveryCollectionItemsDiscoveredComponentsPluggableDatabasesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseManagementExternalDbSystemDiscoveriesExternalDbSystemDiscoveryCollectionItemsDiscoveredComponentsPluggableDatabasesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "connector", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementExternalDbSystemDiscoveries.DataOciDatabaseManagementExternalDbSystemDiscoveriesExternalDbSystemDiscoveryCollectionItemsDiscoveredComponentsPluggableDatabasesConnectorList\"}")]
        public virtual oci.DataOciDatabaseManagementExternalDbSystemDiscoveries.DataOciDatabaseManagementExternalDbSystemDiscoveriesExternalDbSystemDiscoveryCollectionItemsDiscoveredComponentsPluggableDatabasesConnectorList Connector
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementExternalDbSystemDiscoveries.DataOciDatabaseManagementExternalDbSystemDiscoveriesExternalDbSystemDiscoveryCollectionItemsDiscoveredComponentsPluggableDatabasesConnectorList>()!;
        }

        [JsiiProperty(name: "containerDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContainerDatabaseId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "guid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Guid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementExternalDbSystemDiscoveries.DataOciDatabaseManagementExternalDbSystemDiscoveriesExternalDbSystemDiscoveryCollectionItemsDiscoveredComponentsPluggableDatabases\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseManagementExternalDbSystemDiscoveries.IDataOciDatabaseManagementExternalDbSystemDiscoveriesExternalDbSystemDiscoveryCollectionItemsDiscoveredComponentsPluggableDatabases? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementExternalDbSystemDiscoveries.IDataOciDatabaseManagementExternalDbSystemDiscoveriesExternalDbSystemDiscoveryCollectionItemsDiscoveredComponentsPluggableDatabases?>();
            set => SetInstanceProperty(value);
        }
    }
}
