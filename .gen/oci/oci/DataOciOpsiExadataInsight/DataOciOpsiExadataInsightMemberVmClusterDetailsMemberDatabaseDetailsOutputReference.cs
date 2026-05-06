using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOpsiExadataInsight
{
    [JsiiClass(nativeType: typeof(oci.DataOciOpsiExadataInsight.DataOciOpsiExadataInsightMemberVmClusterDetailsMemberDatabaseDetailsOutputReference), fullyQualifiedName: "oci.dataOciOpsiExadataInsight.DataOciOpsiExadataInsightMemberVmClusterDetailsMemberDatabaseDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciOpsiExadataInsightMemberVmClusterDetailsMemberDatabaseDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciOpsiExadataInsightMemberVmClusterDetailsMemberDatabaseDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciOpsiExadataInsightMemberVmClusterDetailsMemberDatabaseDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOpsiExadataInsightMemberVmClusterDetailsMemberDatabaseDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "connectionCredentialDetails", typeJson: "{\"fqn\":\"oci.dataOciOpsiExadataInsight.DataOciOpsiExadataInsightMemberVmClusterDetailsMemberDatabaseDetailsConnectionCredentialDetailsList\"}")]
        public virtual oci.DataOciOpsiExadataInsight.DataOciOpsiExadataInsightMemberVmClusterDetailsMemberDatabaseDetailsConnectionCredentialDetailsList ConnectionCredentialDetails
        {
            get => GetInstanceProperty<oci.DataOciOpsiExadataInsight.DataOciOpsiExadataInsightMemberVmClusterDetailsMemberDatabaseDetailsConnectionCredentialDetailsList>()!;
        }

        [JsiiProperty(name: "connectionDetails", typeJson: "{\"fqn\":\"oci.dataOciOpsiExadataInsight.DataOciOpsiExadataInsightMemberVmClusterDetailsMemberDatabaseDetailsConnectionDetailsList\"}")]
        public virtual oci.DataOciOpsiExadataInsight.DataOciOpsiExadataInsightMemberVmClusterDetailsMemberDatabaseDetailsConnectionDetailsList ConnectionDetails
        {
            get => GetInstanceProperty<oci.DataOciOpsiExadataInsight.DataOciOpsiExadataInsightMemberVmClusterDetailsMemberDatabaseDetailsConnectionDetailsList>()!;
        }

        [JsiiProperty(name: "credentialDetails", typeJson: "{\"fqn\":\"oci.dataOciOpsiExadataInsight.DataOciOpsiExadataInsightMemberVmClusterDetailsMemberDatabaseDetailsCredentialDetailsList\"}")]
        public virtual oci.DataOciOpsiExadataInsight.DataOciOpsiExadataInsightMemberVmClusterDetailsMemberDatabaseDetailsCredentialDetailsList CredentialDetails
        {
            get => GetInstanceProperty<oci.DataOciOpsiExadataInsight.DataOciOpsiExadataInsightMemberVmClusterDetailsMemberDatabaseDetailsCredentialDetailsList>()!;
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciOpsiExadataInsight.DataOciOpsiExadataInsightMemberVmClusterDetailsMemberDatabaseDetails\"}", isOptional: true)]
        public virtual oci.DataOciOpsiExadataInsight.IDataOciOpsiExadataInsightMemberVmClusterDetailsMemberDatabaseDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciOpsiExadataInsight.IDataOciOpsiExadataInsightMemberVmClusterDetailsMemberDatabaseDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
