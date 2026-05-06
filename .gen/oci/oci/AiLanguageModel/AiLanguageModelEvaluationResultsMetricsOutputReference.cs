using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AiLanguageModel
{
    [JsiiClass(nativeType: typeof(oci.AiLanguageModel.AiLanguageModelEvaluationResultsMetricsOutputReference), fullyQualifiedName: "oci.aiLanguageModel.AiLanguageModelEvaluationResultsMetricsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AiLanguageModelEvaluationResultsMetricsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public AiLanguageModelEvaluationResultsMetricsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected AiLanguageModelEvaluationResultsMetricsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AiLanguageModelEvaluationResultsMetricsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "accuracy", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Accuracy
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "macroF1", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MacroF1
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "macroPrecision", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MacroPrecision
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "macroRecall", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MacroRecall
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "microF1", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MicroF1
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "microPrecision", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MicroPrecision
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "microRecall", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MicroRecall
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "weightedF1", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double WeightedF1
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "weightedPrecision", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double WeightedPrecision
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "weightedRecall", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double WeightedRecall
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.aiLanguageModel.AiLanguageModelEvaluationResultsMetrics\"}", isOptional: true)]
        public virtual oci.AiLanguageModel.IAiLanguageModelEvaluationResultsMetrics? InternalValue
        {
            get => GetInstanceProperty<oci.AiLanguageModel.IAiLanguageModelEvaluationResultsMetrics?>();
            set => SetInstanceProperty(value);
        }
    }
}
