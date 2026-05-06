using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseManagementCloudDbSystemDiscoveries
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseManagementCloudDbSystemDiscoveries.DataOciDatabaseManagementCloudDbSystemDiscoveriesCloudDbSystemDiscoveryCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDatabaseManagementCloudDbSystemDiscoveries.DataOciDatabaseManagementCloudDbSystemDiscoveriesCloudDbSystemDiscoveryCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseManagementCloudDbSystemDiscoveriesCloudDbSystemDiscoveryCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseManagementCloudDbSystemDiscoveriesCloudDbSystemDiscoveryCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseManagementCloudDbSystemDiscoveriesCloudDbSystemDiscoveryCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseManagementCloudDbSystemDiscoveriesCloudDbSystemDiscoveryCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "agentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AgentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cloudDbSystemDiscoveryId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloudDbSystemDiscoveryId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbaasParentInfrastructureId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbaasParentInfrastructureId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "deploymentType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeploymentType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "discoveredComponents", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementCloudDbSystemDiscoveries.DataOciDatabaseManagementCloudDbSystemDiscoveriesCloudDbSystemDiscoveryCollectionItemsDiscoveredComponentsList\"}")]
        public virtual oci.DataOciDatabaseManagementCloudDbSystemDiscoveries.DataOciDatabaseManagementCloudDbSystemDiscoveriesCloudDbSystemDiscoveryCollectionItemsDiscoveredComponentsList DiscoveredComponents
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementCloudDbSystemDiscoveries.DataOciDatabaseManagementCloudDbSystemDiscoveriesCloudDbSystemDiscoveryCollectionItemsDiscoveredComponentsList>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "gridHome", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GridHome
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "patchOperations", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementCloudDbSystemDiscoveries.DataOciDatabaseManagementCloudDbSystemDiscoveriesCloudDbSystemDiscoveryCollectionItemsPatchOperationsList\"}")]
        public virtual oci.DataOciDatabaseManagementCloudDbSystemDiscoveries.DataOciDatabaseManagementCloudDbSystemDiscoveriesCloudDbSystemDiscoveryCollectionItemsPatchOperationsList PatchOperations
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementCloudDbSystemDiscoveries.DataOciDatabaseManagementCloudDbSystemDiscoveriesCloudDbSystemDiscoveryCollectionItemsPatchOperationsList>()!;
        }

        [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementCloudDbSystemDiscoveries.DataOciDatabaseManagementCloudDbSystemDiscoveriesCloudDbSystemDiscoveryCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseManagementCloudDbSystemDiscoveries.IDataOciDatabaseManagementCloudDbSystemDiscoveriesCloudDbSystemDiscoveryCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementCloudDbSystemDiscoveries.IDataOciDatabaseManagementCloudDbSystemDiscoveriesCloudDbSystemDiscoveryCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
