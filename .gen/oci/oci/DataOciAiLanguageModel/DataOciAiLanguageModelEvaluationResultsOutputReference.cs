using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciAiLanguageModel
{
    [JsiiClass(nativeType: typeof(oci.DataOciAiLanguageModel.DataOciAiLanguageModelEvaluationResultsOutputReference), fullyQualifiedName: "oci.dataOciAiLanguageModel.DataOciAiLanguageModelEvaluationResultsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciAiLanguageModelEvaluationResultsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciAiLanguageModelEvaluationResultsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciAiLanguageModelEvaluationResultsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciAiLanguageModelEvaluationResultsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "classMetrics", typeJson: "{\"fqn\":\"oci.dataOciAiLanguageModel.DataOciAiLanguageModelEvaluationResultsClassMetricsList\"}")]
        public virtual oci.DataOciAiLanguageModel.DataOciAiLanguageModelEvaluationResultsClassMetricsList ClassMetrics
        {
            get => GetInstanceProperty<oci.DataOciAiLanguageModel.DataOciAiLanguageModelEvaluationResultsClassMetricsList>()!;
        }

        [JsiiProperty(name: "confusionMatrix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfusionMatrix
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "entityMetrics", typeJson: "{\"fqn\":\"oci.dataOciAiLanguageModel.DataOciAiLanguageModelEvaluationResultsEntityMetricsList\"}")]
        public virtual oci.DataOciAiLanguageModel.DataOciAiLanguageModelEvaluationResultsEntityMetricsList EntityMetrics
        {
            get => GetInstanceProperty<oci.DataOciAiLanguageModel.DataOciAiLanguageModelEvaluationResultsEntityMetricsList>()!;
        }

        [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Labels
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "metrics", typeJson: "{\"fqn\":\"oci.dataOciAiLanguageModel.DataOciAiLanguageModelEvaluationResultsMetricsList\"}")]
        public virtual oci.DataOciAiLanguageModel.DataOciAiLanguageModelEvaluationResultsMetricsList Metrics
        {
            get => GetInstanceProperty<oci.DataOciAiLanguageModel.DataOciAiLanguageModelEvaluationResultsMetricsList>()!;
        }

        [JsiiProperty(name: "modelType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciAiLanguageModel.DataOciAiLanguageModelEvaluationResults\"}", isOptional: true)]
        public virtual oci.DataOciAiLanguageModel.IDataOciAiLanguageModelEvaluationResults? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciAiLanguageModel.IDataOciAiLanguageModelEvaluationResults?>();
            set => SetInstanceProperty(value);
        }
    }
}
