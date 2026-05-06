using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciGenerativeAiModel
{
    [JsiiClass(nativeType: typeof(oci.DataOciGenerativeAiModel.DataOciGenerativeAiModelFineTuneDetailsTrainingConfigOutputReference), fullyQualifiedName: "oci.dataOciGenerativeAiModel.DataOciGenerativeAiModelFineTuneDetailsTrainingConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciGenerativeAiModelFineTuneDetailsTrainingConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciGenerativeAiModelFineTuneDetailsTrainingConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciGenerativeAiModelFineTuneDetailsTrainingConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciGenerativeAiModelFineTuneDetailsTrainingConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "earlyStoppingPatience", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EarlyStoppingPatience
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "earlyStoppingThreshold", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EarlyStoppingThreshold
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "learningRate", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LearningRate
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "logModelMetricsIntervalInSteps", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LogModelMetricsIntervalInSteps
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "loraAlpha", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LoraAlpha
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "loraDropout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LoraDropout
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "loraR", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LoraR
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "numOfLastLayers", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NumOfLastLayers
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "totalTrainingEpochs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalTrainingEpochs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "trainingBatchSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TrainingBatchSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "trainingConfigType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TrainingConfigType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciGenerativeAiModel.DataOciGenerativeAiModelFineTuneDetailsTrainingConfig\"}", isOptional: true)]
        public virtual oci.DataOciGenerativeAiModel.IDataOciGenerativeAiModelFineTuneDetailsTrainingConfig? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciGenerativeAiModel.IDataOciGenerativeAiModelFineTuneDetailsTrainingConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
