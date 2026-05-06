using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOpsiExadataInsights
{
    [JsiiClass(nativeType: typeof(oci.DataOciOpsiExadataInsights.DataOciOpsiExadataInsightsExadataInsightSummaryCollectionItemsMemberVmClusterDetailsMemberDatabaseDetailsOutputReference), fullyQualifiedName: "oci.dataOciOpsiExadataInsights.DataOciOpsiExadataInsightsExadataInsightSummaryCollectionItemsMemberVmClusterDetailsMemberDatabaseDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciOpsiExadataInsightsExadataInsightSummaryCollectionItemsMemberVmClusterDetailsMemberDatabaseDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciOpsiExadataInsightsExadataInsightSummaryCollectionItemsMemberVmClusterDetailsMemberDatabaseDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciOpsiExadataInsightsExadataInsightSummaryCollectionItemsMemberVmClusterDetailsMemberDatabaseDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOpsiExadataInsightsExadataInsightSummaryCollectionItemsMemberVmClusterDetailsMemberDatabaseDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "connectionCredentialDetails", typeJson: "{\"fqn\":\"oci.dataOciOpsiExadataInsights.DataOciOpsiExadataInsightsExadataInsightSummaryCollectionItemsMemberVmClusterDetailsMemberDatabaseDetailsConnectionCredentialDetailsList\"}")]
        public virtual oci.DataOciOpsiExadataInsights.DataOciOpsiExadataInsightsExadataInsightSummaryCollectionItemsMemberVmClusterDetailsMemberDatabaseDetailsConnectionCredentialDetailsList ConnectionCredentialDetails
        {
            get => GetInstanceProperty<oci.DataOciOpsiExadataInsights.DataOciOpsiExadataInsightsExadataInsightSummaryCollectionItemsMemberVmClusterDetailsMemberDatabaseDetailsConnectionCredentialDetailsList>()!;
        }

        [JsiiProperty(name: "connectionDetails", typeJson: "{\"fqn\":\"oci.dataOciOpsiExadataInsights.DataOciOpsiExadataInsightsExadataInsightSummaryCollectionItemsMemberVmClusterDetailsMemberDatabaseDetailsConnectionDetailsList\"}")]
        public virtual oci.DataOciOpsiExadataInsights.DataOciOpsiExadataInsightsExadataInsightSummaryCollectionItemsMemberVmClusterDetailsMemberDatabaseDetailsConnectionDetailsList ConnectionDetails
        {
            get => GetInstanceProperty<oci.DataOciOpsiExadataInsights.DataOciOpsiExadataInsightsExadataInsightSummaryCollectionItemsMemberVmClusterDetailsMemberDatabaseDetailsConnectionDetailsList>()!;
        }

        [JsiiProperty(name: "credentialDetails", typeJson: "{\"fqn\":\"oci.dataOciOpsiExadataInsights.DataOciOpsiExadataInsightsExadataInsightSummaryCollectionItemsMemberVmClusterDetailsMemberDatabaseDetailsCredentialDetailsList\"}")]
        public virtual oci.DataOciOpsiExadataInsights.DataOciOpsiExadataInsightsExadataInsightSummaryCollectionItemsMemberVmClusterDetailsMemberDatabaseDetailsCredentialDetailsList CredentialDetails
        {
            get => GetInstanceProperty<oci.DataOciOpsiExadataInsights.DataOciOpsiExadataInsightsExadataInsightSummaryCollectionItemsMemberVmClusterDetailsMemberDatabaseDetailsCredentialDetailsList>()!;
        }

        [JsiiProperty(name: "databaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseResourceType
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

        [JsiiProperty(name: "entitySource", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EntitySource
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
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

        [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciOpsiExadataInsights.DataOciOpsiExadataInsightsExadataInsightSummaryCollectionItemsMemberVmClusterDetailsMemberDatabaseDetails\"}", isOptional: true)]
        public virtual oci.DataOciOpsiExadataInsights.IDataOciOpsiExadataInsightsExadataInsightSummaryCollectionItemsMemberVmClusterDetailsMemberDatabaseDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciOpsiExadataInsights.IDataOciOpsiExadataInsightsExadataInsightSummaryCollectionItemsMemberVmClusterDetailsMemberDatabaseDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
