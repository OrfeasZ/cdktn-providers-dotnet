using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOpsiDatabaseInsights
{
    [JsiiClass(nativeType: typeof(oci.DataOciOpsiDatabaseInsights.DataOciOpsiDatabaseInsightsDatabaseInsightsCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciOpsiDatabaseInsights.DataOciOpsiDatabaseInsightsDatabaseInsightsCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciOpsiDatabaseInsightsDatabaseInsightsCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciOpsiDatabaseInsightsDatabaseInsightsCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciOpsiDatabaseInsightsDatabaseInsightsCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOpsiDatabaseInsightsDatabaseInsightsCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "connectionCredentialDetails", typeJson: "{\"fqn\":\"oci.dataOciOpsiDatabaseInsights.DataOciOpsiDatabaseInsightsDatabaseInsightsCollectionItemsConnectionCredentialDetailsList\"}")]
        public virtual oci.DataOciOpsiDatabaseInsights.DataOciOpsiDatabaseInsightsDatabaseInsightsCollectionItemsConnectionCredentialDetailsList ConnectionCredentialDetails
        {
            get => GetInstanceProperty<oci.DataOciOpsiDatabaseInsights.DataOciOpsiDatabaseInsightsDatabaseInsightsCollectionItemsConnectionCredentialDetailsList>()!;
        }

        [JsiiProperty(name: "connectionDetails", typeJson: "{\"fqn\":\"oci.dataOciOpsiDatabaseInsights.DataOciOpsiDatabaseInsightsDatabaseInsightsCollectionItemsConnectionDetailsList\"}")]
        public virtual oci.DataOciOpsiDatabaseInsights.DataOciOpsiDatabaseInsightsDatabaseInsightsCollectionItemsConnectionDetailsList ConnectionDetails
        {
            get => GetInstanceProperty<oci.DataOciOpsiDatabaseInsights.DataOciOpsiDatabaseInsightsDatabaseInsightsCollectionItemsConnectionDetailsList>()!;
        }

        [JsiiProperty(name: "connectorId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectorId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "credentialDetails", typeJson: "{\"fqn\":\"oci.dataOciOpsiDatabaseInsights.DataOciOpsiDatabaseInsightsDatabaseInsightsCollectionItemsCredentialDetailsList\"}")]
        public virtual oci.DataOciOpsiDatabaseInsights.DataOciOpsiDatabaseInsightsDatabaseInsightsCollectionItemsCredentialDetailsList CredentialDetails
        {
            get => GetInstanceProperty<oci.DataOciOpsiDatabaseInsights.DataOciOpsiDatabaseInsightsDatabaseInsightsCollectionItemsCredentialDetailsList>()!;
        }

        [JsiiProperty(name: "databaseConnectionStatusDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseConnectionStatusDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseConnectorId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseConnectorId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseDisplayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseDisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseResourceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbmPrivateEndpointId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbmPrivateEndpointId
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

        [JsiiProperty(name: "enterpriseManagerBridgeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EnterpriseManagerBridgeId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enterpriseManagerEntityDisplayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EnterpriseManagerEntityDisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enterpriseManagerEntityIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EnterpriseManagerEntityIdentifier
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enterpriseManagerEntityName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EnterpriseManagerEntityName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enterpriseManagerEntityType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EnterpriseManagerEntityType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enterpriseManagerIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EnterpriseManagerIdentifier
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "entitySource", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EntitySource
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "exadataInsightId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExadataInsightId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isAdvancedFeaturesEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsAdvancedFeaturesEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isHeatWaveClusterAttached", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsHeatWaveClusterAttached
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isHighlyAvailable", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsHighlyAvailable
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "managementAgentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagementAgentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "opsiPrivateEndpointId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OpsiPrivateEndpointId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "parentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "processorCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ProcessorCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "rootId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RootId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciOpsiDatabaseInsights.DataOciOpsiDatabaseInsightsDatabaseInsightsCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciOpsiDatabaseInsights.IDataOciOpsiDatabaseInsightsDatabaseInsightsCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciOpsiDatabaseInsights.IDataOciOpsiDatabaseInsightsDatabaseInsightsCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
