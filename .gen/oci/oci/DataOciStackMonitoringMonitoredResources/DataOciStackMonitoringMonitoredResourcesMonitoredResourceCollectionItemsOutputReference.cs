using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciStackMonitoringMonitoredResources
{
    [JsiiClass(nativeType: typeof(oci.DataOciStackMonitoringMonitoredResources.DataOciStackMonitoringMonitoredResourcesMonitoredResourceCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciStackMonitoringMonitoredResources.DataOciStackMonitoringMonitoredResourcesMonitoredResourceCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciStackMonitoringMonitoredResourcesMonitoredResourceCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciStackMonitoringMonitoredResourcesMonitoredResourceCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciStackMonitoringMonitoredResourcesMonitoredResourceCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciStackMonitoringMonitoredResourcesMonitoredResourceCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "additionalAliases", typeJson: "{\"fqn\":\"oci.dataOciStackMonitoringMonitoredResources.DataOciStackMonitoringMonitoredResourcesMonitoredResourceCollectionItemsAdditionalAliasesList\"}")]
        public virtual oci.DataOciStackMonitoringMonitoredResources.DataOciStackMonitoringMonitoredResourcesMonitoredResourceCollectionItemsAdditionalAliasesList AdditionalAliases
        {
            get => GetInstanceProperty<oci.DataOciStackMonitoringMonitoredResources.DataOciStackMonitoringMonitoredResourcesMonitoredResourceCollectionItemsAdditionalAliasesList>()!;
        }

        [JsiiProperty(name: "additionalCredentials", typeJson: "{\"fqn\":\"oci.dataOciStackMonitoringMonitoredResources.DataOciStackMonitoringMonitoredResourcesMonitoredResourceCollectionItemsAdditionalCredentialsList\"}")]
        public virtual oci.DataOciStackMonitoringMonitoredResources.DataOciStackMonitoringMonitoredResourcesMonitoredResourceCollectionItemsAdditionalCredentialsList AdditionalCredentials
        {
            get => GetInstanceProperty<oci.DataOciStackMonitoringMonitoredResources.DataOciStackMonitoringMonitoredResourcesMonitoredResourceCollectionItemsAdditionalCredentialsList>()!;
        }

        [JsiiProperty(name: "aliases", typeJson: "{\"fqn\":\"oci.dataOciStackMonitoringMonitoredResources.DataOciStackMonitoringMonitoredResourcesMonitoredResourceCollectionItemsAliasesList\"}")]
        public virtual oci.DataOciStackMonitoringMonitoredResources.DataOciStackMonitoringMonitoredResourcesMonitoredResourceCollectionItemsAliasesList Aliases
        {
            get => GetInstanceProperty<oci.DataOciStackMonitoringMonitoredResources.DataOciStackMonitoringMonitoredResourcesMonitoredResourceCollectionItemsAliasesList>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "credentials", typeJson: "{\"fqn\":\"oci.dataOciStackMonitoringMonitoredResources.DataOciStackMonitoringMonitoredResourcesMonitoredResourceCollectionItemsCredentialsList\"}")]
        public virtual oci.DataOciStackMonitoringMonitoredResources.DataOciStackMonitoringMonitoredResourcesMonitoredResourceCollectionItemsCredentialsList Credentials
        {
            get => GetInstanceProperty<oci.DataOciStackMonitoringMonitoredResources.DataOciStackMonitoringMonitoredResourcesMonitoredResourceCollectionItemsCredentialsList>()!;
        }

        [JsiiProperty(name: "databaseConnectionDetails", typeJson: "{\"fqn\":\"oci.dataOciStackMonitoringMonitoredResources.DataOciStackMonitoringMonitoredResourcesMonitoredResourceCollectionItemsDatabaseConnectionDetailsList\"}")]
        public virtual oci.DataOciStackMonitoringMonitoredResources.DataOciStackMonitoringMonitoredResourcesMonitoredResourceCollectionItemsDatabaseConnectionDetailsList DatabaseConnectionDetails
        {
            get => GetInstanceProperty<oci.DataOciStackMonitoringMonitoredResources.DataOciStackMonitoringMonitoredResourcesMonitoredResourceCollectionItemsDatabaseConnectionDetailsList>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExternalId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "externalResourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExternalResourceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "hostName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "license", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string License
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "managementAgentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagementAgentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "properties", typeJson: "{\"fqn\":\"oci.dataOciStackMonitoringMonitoredResources.DataOciStackMonitoringMonitoredResourcesMonitoredResourceCollectionItemsPropertiesList\"}")]
        public virtual oci.DataOciStackMonitoringMonitoredResources.DataOciStackMonitoringMonitoredResourcesMonitoredResourceCollectionItemsPropertiesList Properties
        {
            get => GetInstanceProperty<oci.DataOciStackMonitoringMonitoredResources.DataOciStackMonitoringMonitoredResourcesMonitoredResourceCollectionItemsPropertiesList>()!;
        }

        [JsiiProperty(name: "resourceCategory", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceCategory
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourceTimeZone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceTimeZone
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceType
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

        [JsiiProperty(name: "tenantId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenantId
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciStackMonitoringMonitoredResources.DataOciStackMonitoringMonitoredResourcesMonitoredResourceCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciStackMonitoringMonitoredResources.IDataOciStackMonitoringMonitoredResourcesMonitoredResourceCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciStackMonitoringMonitoredResources.IDataOciStackMonitoringMonitoredResourcesMonitoredResourceCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
