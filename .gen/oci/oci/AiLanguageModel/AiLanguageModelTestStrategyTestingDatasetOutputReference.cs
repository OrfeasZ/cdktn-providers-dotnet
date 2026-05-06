using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AiLanguageModel
{
    [JsiiClass(nativeType: typeof(oci.AiLanguageModel.AiLanguageModelTestStrategyTestingDatasetOutputReference), fullyQualifiedName: "oci.aiLanguageModel.AiLanguageModelTestStrategyTestingDatasetOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AiLanguageModelTestStrategyTestingDatasetOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AiLanguageModelTestStrategyTestingDatasetOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AiLanguageModelTestStrategyTestingDatasetOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AiLanguageModelTestStrategyTestingDatasetOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putLocationDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.aiLanguageModel.AiLanguageModelTestStrategyTestingDatasetLocationDetails\"}}]")]
        public virtual void PutLocationDetails(oci.AiLanguageModel.IAiLanguageModelTestStrategyTestingDatasetLocationDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.AiLanguageModel.IAiLanguageModelTestStrategyTestingDatasetLocationDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDatasetId")]
        public virtual void ResetDatasetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLocationDetails")]
        public virtual void ResetLocationDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "locationDetails", typeJson: "{\"fqn\":\"oci.aiLanguageModel.AiLanguageModelTestStrategyTestingDatasetLocationDetailsOutputReference\"}")]
        public virtual oci.AiLanguageModel.AiLanguageModelTestStrategyTestingDatasetLocationDetailsOutputReference LocationDetails
        {
            get => GetInstanceProperty<oci.AiLanguageModel.AiLanguageModelTestStrategyTestingDatasetLocationDetailsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "datasetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DatasetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "datasetTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DatasetTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "locationDetailsInput", typeJson: "{\"fqn\":\"oci.aiLanguageModel.AiLanguageModelTestStrategyTestingDatasetLocationDetails\"}", isOptional: true)]
        public virtual oci.AiLanguageModel.IAiLanguageModelTestStrategyTestingDatasetLocationDetails? LocationDetailsInput
        {
            get => GetInstanceProperty<oci.AiLanguageModel.IAiLanguageModelTestStrategyTestingDatasetLocationDetails?>();
        }

        [JsiiProperty(name: "datasetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatasetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "datasetType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatasetType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.aiLanguageModel.AiLanguageModelTestStrategyTestingDataset\"}", isOptional: true)]
        public virtual oci.AiLanguageModel.IAiLanguageModelTestStrategyTestingDataset? InternalValue
        {
            get => GetInstanceProperty<oci.AiLanguageModel.IAiLanguageModelTestStrategyTestingDataset?>();
            set => SetInstanceProperty(value);
        }
    }
}
