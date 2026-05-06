using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AiLanguageModel
{
    [JsiiClass(nativeType: typeof(oci.AiLanguageModel.AiLanguageModelTestStrategyOutputReference), fullyQualifiedName: "oci.aiLanguageModel.AiLanguageModelTestStrategyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AiLanguageModelTestStrategyOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AiLanguageModelTestStrategyOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AiLanguageModelTestStrategyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AiLanguageModelTestStrategyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putTestingDataset", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.aiLanguageModel.AiLanguageModelTestStrategyTestingDataset\"}}]")]
        public virtual void PutTestingDataset(oci.AiLanguageModel.IAiLanguageModelTestStrategyTestingDataset @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.AiLanguageModel.IAiLanguageModelTestStrategyTestingDataset)}, new object[]{@value});
        }

        [JsiiMethod(name: "putValidationDataset", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.aiLanguageModel.AiLanguageModelTestStrategyValidationDataset\"}}]")]
        public virtual void PutValidationDataset(oci.AiLanguageModel.IAiLanguageModelTestStrategyValidationDataset @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.AiLanguageModel.IAiLanguageModelTestStrategyValidationDataset)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetValidationDataset")]
        public virtual void ResetValidationDataset()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "testingDataset", typeJson: "{\"fqn\":\"oci.aiLanguageModel.AiLanguageModelTestStrategyTestingDatasetOutputReference\"}")]
        public virtual oci.AiLanguageModel.AiLanguageModelTestStrategyTestingDatasetOutputReference TestingDataset
        {
            get => GetInstanceProperty<oci.AiLanguageModel.AiLanguageModelTestStrategyTestingDatasetOutputReference>()!;
        }

        [JsiiProperty(name: "validationDataset", typeJson: "{\"fqn\":\"oci.aiLanguageModel.AiLanguageModelTestStrategyValidationDatasetOutputReference\"}")]
        public virtual oci.AiLanguageModel.AiLanguageModelTestStrategyValidationDatasetOutputReference ValidationDataset
        {
            get => GetInstanceProperty<oci.AiLanguageModel.AiLanguageModelTestStrategyValidationDatasetOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "strategyTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StrategyTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "testingDatasetInput", typeJson: "{\"fqn\":\"oci.aiLanguageModel.AiLanguageModelTestStrategyTestingDataset\"}", isOptional: true)]
        public virtual oci.AiLanguageModel.IAiLanguageModelTestStrategyTestingDataset? TestingDatasetInput
        {
            get => GetInstanceProperty<oci.AiLanguageModel.IAiLanguageModelTestStrategyTestingDataset?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "validationDatasetInput", typeJson: "{\"fqn\":\"oci.aiLanguageModel.AiLanguageModelTestStrategyValidationDataset\"}", isOptional: true)]
        public virtual oci.AiLanguageModel.IAiLanguageModelTestStrategyValidationDataset? ValidationDatasetInput
        {
            get => GetInstanceProperty<oci.AiLanguageModel.IAiLanguageModelTestStrategyValidationDataset?>();
        }

        [JsiiProperty(name: "strategyType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StrategyType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.aiLanguageModel.AiLanguageModelTestStrategy\"}", isOptional: true)]
        public virtual oci.AiLanguageModel.IAiLanguageModelTestStrategy? InternalValue
        {
            get => GetInstanceProperty<oci.AiLanguageModel.IAiLanguageModelTestStrategy?>();
            set => SetInstanceProperty(value);
        }
    }
}
