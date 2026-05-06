using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiModel
{
    [JsiiClass(nativeType: typeof(oci.GenerativeAiModel.GenerativeAiModelFineTuneDetailsTrainingConfigOutputReference), fullyQualifiedName: "oci.generativeAiModel.GenerativeAiModelFineTuneDetailsTrainingConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GenerativeAiModelFineTuneDetailsTrainingConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GenerativeAiModelFineTuneDetailsTrainingConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GenerativeAiModelFineTuneDetailsTrainingConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GenerativeAiModelFineTuneDetailsTrainingConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetEarlyStoppingPatience")]
        public virtual void ResetEarlyStoppingPatience()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEarlyStoppingThreshold")]
        public virtual void ResetEarlyStoppingThreshold()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLearningRate")]
        public virtual void ResetLearningRate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogModelMetricsIntervalInSteps")]
        public virtual void ResetLogModelMetricsIntervalInSteps()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoraAlpha")]
        public virtual void ResetLoraAlpha()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoraDropout")]
        public virtual void ResetLoraDropout()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoraR")]
        public virtual void ResetLoraR()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNumOfLastLayers")]
        public virtual void ResetNumOfLastLayers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTotalTrainingEpochs")]
        public virtual void ResetTotalTrainingEpochs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTrainingBatchSize")]
        public virtual void ResetTrainingBatchSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "earlyStoppingPatienceInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? EarlyStoppingPatienceInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "earlyStoppingThresholdInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? EarlyStoppingThresholdInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "learningRateInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? LearningRateInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logModelMetricsIntervalInStepsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? LogModelMetricsIntervalInStepsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loraAlphaInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? LoraAlphaInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loraDropoutInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? LoraDropoutInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loraRInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? LoraRInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "numOfLastLayersInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NumOfLastLayersInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "totalTrainingEpochsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TotalTrainingEpochsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "trainingBatchSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TrainingBatchSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "trainingConfigTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TrainingConfigTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "earlyStoppingPatience", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EarlyStoppingPatience
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "earlyStoppingThreshold", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EarlyStoppingThreshold
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "learningRate", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LearningRate
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "logModelMetricsIntervalInSteps", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LogModelMetricsIntervalInSteps
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "loraAlpha", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LoraAlpha
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "loraDropout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LoraDropout
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "loraR", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LoraR
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "numOfLastLayers", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NumOfLastLayers
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "totalTrainingEpochs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalTrainingEpochs
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "trainingBatchSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TrainingBatchSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "trainingConfigType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TrainingConfigType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.generativeAiModel.GenerativeAiModelFineTuneDetailsTrainingConfig\"}", isOptional: true)]
        public virtual oci.GenerativeAiModel.IGenerativeAiModelFineTuneDetailsTrainingConfig? InternalValue
        {
            get => GetInstanceProperty<oci.GenerativeAiModel.IGenerativeAiModelFineTuneDetailsTrainingConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
