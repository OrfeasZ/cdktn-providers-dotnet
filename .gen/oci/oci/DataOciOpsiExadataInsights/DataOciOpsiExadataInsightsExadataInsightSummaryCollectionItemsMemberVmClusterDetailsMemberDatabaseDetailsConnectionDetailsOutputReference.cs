using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOpsiExadataInsights
{
    [JsiiClass(nativeType: typeof(oci.DataOciOpsiExadataInsights.DataOciOpsiExadataInsightsExadataInsightSummaryCollectionItemsMemberVmClusterDetailsMemberDatabaseDetailsConnectionDetailsOutputReference), fullyQualifiedName: "oci.dataOciOpsiExadataInsights.DataOciOpsiExadataInsightsExadataInsightSummaryCollectionItemsMemberVmClusterDetailsMemberDatabaseDetailsConnectionDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciOpsiExadataInsightsExadataInsightSummaryCollectionItemsMemberVmClusterDetailsMemberDatabaseDetailsConnectionDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciOpsiExadataInsightsExadataInsightSummaryCollectionItemsMemberVmClusterDetailsMemberDatabaseDetailsConnectionDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciOpsiExadataInsightsExadataInsightSummaryCollectionItemsMemberVmClusterDetailsMemberDatabaseDetailsConnectionDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOpsiExadataInsightsExadataInsightSummaryCollectionItemsMemberVmClusterDetailsMemberDatabaseDetailsConnectionDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "hostName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hosts", typeJson: "{\"fqn\":\"oci.dataOciOpsiExadataInsights.DataOciOpsiExadataInsightsExadataInsightSummaryCollectionItemsMemberVmClusterDetailsMemberDatabaseDetailsConnectionDetailsHostsList\"}")]
        public virtual oci.DataOciOpsiExadataInsights.DataOciOpsiExadataInsightsExadataInsightSummaryCollectionItemsMemberVmClusterDetailsMemberDatabaseDetailsConnectionDetailsHostsList Hosts
        {
            get => GetInstanceProperty<oci.DataOciOpsiExadataInsights.DataOciOpsiExadataInsightsExadataInsightSummaryCollectionItemsMemberVmClusterDetailsMemberDatabaseDetailsConnectionDetailsHostsList>()!;
        }

        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Port
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Protocol
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciOpsiExadataInsights.DataOciOpsiExadataInsightsExadataInsightSummaryCollectionItemsMemberVmClusterDetailsMemberDatabaseDetailsConnectionDetails\"}", isOptional: true)]
        public virtual oci.DataOciOpsiExadataInsights.IDataOciOpsiExadataInsightsExadataInsightSummaryCollectionItemsMemberVmClusterDetailsMemberDatabaseDetailsConnectionDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciOpsiExadataInsights.IDataOciOpsiExadataInsightsExadataInsightSummaryCollectionItemsMemberVmClusterDetailsMemberDatabaseDetailsConnectionDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
