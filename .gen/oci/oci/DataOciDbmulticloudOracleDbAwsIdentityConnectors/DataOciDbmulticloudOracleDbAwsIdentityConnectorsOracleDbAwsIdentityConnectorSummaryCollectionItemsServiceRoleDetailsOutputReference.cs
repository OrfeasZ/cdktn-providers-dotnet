using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDbmulticloudOracleDbAwsIdentityConnectors
{
    [JsiiClass(nativeType: typeof(oci.DataOciDbmulticloudOracleDbAwsIdentityConnectors.DataOciDbmulticloudOracleDbAwsIdentityConnectorsOracleDbAwsIdentityConnectorSummaryCollectionItemsServiceRoleDetailsOutputReference), fullyQualifiedName: "oci.dataOciDbmulticloudOracleDbAwsIdentityConnectors.DataOciDbmulticloudOracleDbAwsIdentityConnectorsOracleDbAwsIdentityConnectorSummaryCollectionItemsServiceRoleDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDbmulticloudOracleDbAwsIdentityConnectorsOracleDbAwsIdentityConnectorSummaryCollectionItemsServiceRoleDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDbmulticloudOracleDbAwsIdentityConnectorsOracleDbAwsIdentityConnectorSummaryCollectionItemsServiceRoleDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDbmulticloudOracleDbAwsIdentityConnectorsOracleDbAwsIdentityConnectorSummaryCollectionItemsServiceRoleDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDbmulticloudOracleDbAwsIdentityConnectorsOracleDbAwsIdentityConnectorSummaryCollectionItemsServiceRoleDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "assumeRoleStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssumeRoleStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "awsNodes", typeJson: "{\"fqn\":\"oci.dataOciDbmulticloudOracleDbAwsIdentityConnectors.DataOciDbmulticloudOracleDbAwsIdentityConnectorsOracleDbAwsIdentityConnectorSummaryCollectionItemsServiceRoleDetailsAwsNodesList\"}")]
        public virtual oci.DataOciDbmulticloudOracleDbAwsIdentityConnectors.DataOciDbmulticloudOracleDbAwsIdentityConnectorsOracleDbAwsIdentityConnectorSummaryCollectionItemsServiceRoleDetailsAwsNodesList AwsNodes
        {
            get => GetInstanceProperty<oci.DataOciDbmulticloudOracleDbAwsIdentityConnectors.DataOciDbmulticloudOracleDbAwsIdentityConnectorsOracleDbAwsIdentityConnectorSummaryCollectionItemsServiceRoleDetailsAwsNodesList>()!;
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoleArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "servicePrivateEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServicePrivateEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDbmulticloudOracleDbAwsIdentityConnectors.DataOciDbmulticloudOracleDbAwsIdentityConnectorsOracleDbAwsIdentityConnectorSummaryCollectionItemsServiceRoleDetails\"}", isOptional: true)]
        public virtual oci.DataOciDbmulticloudOracleDbAwsIdentityConnectors.IDataOciDbmulticloudOracleDbAwsIdentityConnectorsOracleDbAwsIdentityConnectorSummaryCollectionItemsServiceRoleDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDbmulticloudOracleDbAwsIdentityConnectors.IDataOciDbmulticloudOracleDbAwsIdentityConnectorsOracleDbAwsIdentityConnectorSummaryCollectionItemsServiceRoleDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
