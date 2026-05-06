using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiModel
{
    [JsiiClass(nativeType: typeof(oci.GenerativeAiModel.GenerativeAiModelFineTuneDetailsOutputReference), fullyQualifiedName: "oci.generativeAiModel.GenerativeAiModelFineTuneDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GenerativeAiModelFineTuneDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GenerativeAiModelFineTuneDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected GenerativeAiModelFineTuneDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GenerativeAiModelFineTuneDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putTrainingConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.generativeAiModel.GenerativeAiModelFineTuneDetailsTrainingConfig\"}}]")]
        public virtual void PutTrainingConfig(oci.GenerativeAiModel.IGenerativeAiModelFineTuneDetailsTrainingConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.GenerativeAiModel.IGenerativeAiModelFineTuneDetailsTrainingConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTrainingDataset", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.generativeAiModel.GenerativeAiModelFineTuneDetailsTrainingDataset\"}}]")]
        public virtual void PutTrainingDataset(oci.GenerativeAiModel.IGenerativeAiModelFineTuneDetailsTrainingDataset @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.GenerativeAiModel.IGenerativeAiModelFineTuneDetailsTrainingDataset)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetTrainingConfig")]
        public virtual void ResetTrainingConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "trainingConfig", typeJson: "{\"fqn\":\"oci.generativeAiModel.GenerativeAiModelFineTuneDetailsTrainingConfigOutputReference\"}")]
        public virtual oci.GenerativeAiModel.GenerativeAiModelFineTuneDetailsTrainingConfigOutputReference TrainingConfig
        {
            get => GetInstanceProperty<oci.GenerativeAiModel.GenerativeAiModelFineTuneDetailsTrainingConfigOutputReference>()!;
        }

        [JsiiProperty(name: "trainingDataset", typeJson: "{\"fqn\":\"oci.generativeAiModel.GenerativeAiModelFineTuneDetailsTrainingDatasetOutputReference\"}")]
        public virtual oci.GenerativeAiModel.GenerativeAiModelFineTuneDetailsTrainingDatasetOutputReference TrainingDataset
        {
            get => GetInstanceProperty<oci.GenerativeAiModel.GenerativeAiModelFineTuneDetailsTrainingDatasetOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dedicatedAiClusterIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DedicatedAiClusterIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "trainingConfigInput", typeJson: "{\"fqn\":\"oci.generativeAiModel.GenerativeAiModelFineTuneDetailsTrainingConfig\"}", isOptional: true)]
        public virtual oci.GenerativeAiModel.IGenerativeAiModelFineTuneDetailsTrainingConfig? TrainingConfigInput
        {
            get => GetInstanceProperty<oci.GenerativeAiModel.IGenerativeAiModelFineTuneDetailsTrainingConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "trainingDatasetInput", typeJson: "{\"fqn\":\"oci.generativeAiModel.GenerativeAiModelFineTuneDetailsTrainingDataset\"}", isOptional: true)]
        public virtual oci.GenerativeAiModel.IGenerativeAiModelFineTuneDetailsTrainingDataset? TrainingDatasetInput
        {
            get => GetInstanceProperty<oci.GenerativeAiModel.IGenerativeAiModelFineTuneDetailsTrainingDataset?>();
        }

        [JsiiProperty(name: "dedicatedAiClusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DedicatedAiClusterId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.generativeAiModel.GenerativeAiModelFineTuneDetails\"}", isOptional: true)]
        public virtual oci.GenerativeAiModel.IGenerativeAiModelFineTuneDetails? InternalValue
        {
            get => GetInstanceProperty<oci.GenerativeAiModel.IGenerativeAiModelFineTuneDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
