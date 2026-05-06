using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AiDocumentModel
{
    [JsiiClass(nativeType: typeof(oci.AiDocumentModel.AiDocumentModelMetricsOutputReference), fullyQualifiedName: "oci.aiDocumentModel.AiDocumentModelMetricsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AiDocumentModelMetricsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public AiDocumentModelMetricsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected AiDocumentModelMetricsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AiDocumentModelMetricsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "datasetSummary", typeJson: "{\"fqn\":\"oci.aiDocumentModel.AiDocumentModelMetricsDatasetSummaryList\"}")]
        public virtual oci.AiDocumentModel.AiDocumentModelMetricsDatasetSummaryList DatasetSummary
        {
            get => GetInstanceProperty<oci.AiDocumentModel.AiDocumentModelMetricsDatasetSummaryList>()!;
        }

        [JsiiProperty(name: "labelMetricsReport", typeJson: "{\"fqn\":\"oci.aiDocumentModel.AiDocumentModelMetricsLabelMetricsReportList\"}")]
        public virtual oci.AiDocumentModel.AiDocumentModelMetricsLabelMetricsReportList LabelMetricsReport
        {
            get => GetInstanceProperty<oci.AiDocumentModel.AiDocumentModelMetricsLabelMetricsReportList>()!;
        }

        [JsiiProperty(name: "modelType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "overallMetricsReport", typeJson: "{\"fqn\":\"oci.aiDocumentModel.AiDocumentModelMetricsOverallMetricsReportList\"}")]
        public virtual oci.AiDocumentModel.AiDocumentModelMetricsOverallMetricsReportList OverallMetricsReport
        {
            get => GetInstanceProperty<oci.AiDocumentModel.AiDocumentModelMetricsOverallMetricsReportList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.aiDocumentModel.AiDocumentModelMetrics\"}", isOptional: true)]
        public virtual oci.AiDocumentModel.IAiDocumentModelMetrics? InternalValue
        {
            get => GetInstanceProperty<oci.AiDocumentModel.IAiDocumentModelMetrics?>();
            set => SetInstanceProperty(value);
        }
    }
}
