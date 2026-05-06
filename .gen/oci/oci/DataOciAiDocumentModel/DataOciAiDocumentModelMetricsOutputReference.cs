using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciAiDocumentModel
{
    [JsiiClass(nativeType: typeof(oci.DataOciAiDocumentModel.DataOciAiDocumentModelMetricsOutputReference), fullyQualifiedName: "oci.dataOciAiDocumentModel.DataOciAiDocumentModelMetricsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciAiDocumentModelMetricsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciAiDocumentModelMetricsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciAiDocumentModelMetricsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciAiDocumentModelMetricsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "datasetSummary", typeJson: "{\"fqn\":\"oci.dataOciAiDocumentModel.DataOciAiDocumentModelMetricsDatasetSummaryList\"}")]
        public virtual oci.DataOciAiDocumentModel.DataOciAiDocumentModelMetricsDatasetSummaryList DatasetSummary
        {
            get => GetInstanceProperty<oci.DataOciAiDocumentModel.DataOciAiDocumentModelMetricsDatasetSummaryList>()!;
        }

        [JsiiProperty(name: "labelMetricsReport", typeJson: "{\"fqn\":\"oci.dataOciAiDocumentModel.DataOciAiDocumentModelMetricsLabelMetricsReportList\"}")]
        public virtual oci.DataOciAiDocumentModel.DataOciAiDocumentModelMetricsLabelMetricsReportList LabelMetricsReport
        {
            get => GetInstanceProperty<oci.DataOciAiDocumentModel.DataOciAiDocumentModelMetricsLabelMetricsReportList>()!;
        }

        [JsiiProperty(name: "modelType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "overallMetricsReport", typeJson: "{\"fqn\":\"oci.dataOciAiDocumentModel.DataOciAiDocumentModelMetricsOverallMetricsReportList\"}")]
        public virtual oci.DataOciAiDocumentModel.DataOciAiDocumentModelMetricsOverallMetricsReportList OverallMetricsReport
        {
            get => GetInstanceProperty<oci.DataOciAiDocumentModel.DataOciAiDocumentModelMetricsOverallMetricsReportList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciAiDocumentModel.DataOciAiDocumentModelMetrics\"}", isOptional: true)]
        public virtual oci.DataOciAiDocumentModel.IDataOciAiDocumentModelMetrics? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciAiDocumentModel.IDataOciAiDocumentModelMetrics?>();
            set => SetInstanceProperty(value);
        }
    }
}
