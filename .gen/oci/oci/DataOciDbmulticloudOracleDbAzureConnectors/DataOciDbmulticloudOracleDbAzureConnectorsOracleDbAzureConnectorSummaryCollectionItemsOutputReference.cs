using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDbmulticloudOracleDbAzureConnectors
{
    [JsiiClass(nativeType: typeof(oci.DataOciDbmulticloudOracleDbAzureConnectors.DataOciDbmulticloudOracleDbAzureConnectorsOracleDbAzureConnectorSummaryCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDbmulticloudOracleDbAzureConnectors.DataOciDbmulticloudOracleDbAzureConnectorsOracleDbAzureConnectorSummaryCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDbmulticloudOracleDbAzureConnectorsOracleDbAzureConnectorSummaryCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDbmulticloudOracleDbAzureConnectorsOracleDbAzureConnectorSummaryCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDbmulticloudOracleDbAzureConnectorsOracleDbAzureConnectorSummaryCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDbmulticloudOracleDbAzureConnectorsOracleDbAzureConnectorSummaryCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "accessToken", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccessToken
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "arcAgentNodes", typeJson: "{\"fqn\":\"oci.dataOciDbmulticloudOracleDbAzureConnectors.DataOciDbmulticloudOracleDbAzureConnectorsOracleDbAzureConnectorSummaryCollectionItemsArcAgentNodesList\"}")]
        public virtual oci.DataOciDbmulticloudOracleDbAzureConnectors.DataOciDbmulticloudOracleDbAzureConnectorsOracleDbAzureConnectorSummaryCollectionItemsArcAgentNodesList ArcAgentNodes
        {
            get => GetInstanceProperty<oci.DataOciDbmulticloudOracleDbAzureConnectors.DataOciDbmulticloudOracleDbAzureConnectorsOracleDbAzureConnectorSummaryCollectionItemsArcAgentNodesList>()!;
        }

        [JsiiProperty(name: "azureIdentityConnectivityStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AzureIdentityConnectivityStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "azureIdentityMechanism", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AzureIdentityMechanism
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "azureResourceGroup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AzureResourceGroup
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "azureSubscriptionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AzureSubscriptionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "azureTenantId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AzureTenantId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbClusterResourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbClusterResourceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastModification", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastModification
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleStateDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleStateDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
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

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDbmulticloudOracleDbAzureConnectors.DataOciDbmulticloudOracleDbAzureConnectorsOracleDbAzureConnectorSummaryCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDbmulticloudOracleDbAzureConnectors.IDataOciDbmulticloudOracleDbAzureConnectorsOracleDbAzureConnectorSummaryCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDbmulticloudOracleDbAzureConnectors.IDataOciDbmulticloudOracleDbAzureConnectorsOracleDbAzureConnectorSummaryCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
