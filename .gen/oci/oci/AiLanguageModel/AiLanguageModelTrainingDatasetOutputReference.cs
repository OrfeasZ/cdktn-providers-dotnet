using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AiLanguageModel
{
    [JsiiClass(nativeType: typeof(oci.AiLanguageModel.AiLanguageModelTrainingDatasetOutputReference), fullyQualifiedName: "oci.aiLanguageModel.AiLanguageModelTrainingDatasetOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AiLanguageModelTrainingDatasetOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AiLanguageModelTrainingDatasetOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AiLanguageModelTrainingDatasetOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AiLanguageModelTrainingDatasetOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putLocationDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.aiLanguageModel.AiLanguageModelTrainingDatasetLocationDetails\"}}]")]
        public virtual void PutLocationDetails(oci.AiLanguageModel.IAiLanguageModelTrainingDatasetLocationDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.AiLanguageModel.IAiLanguageModelTrainingDatasetLocationDetails)}, new object[]{@value});
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

        [JsiiProperty(name: "locationDetails", typeJson: "{\"fqn\":\"oci.aiLanguageModel.AiLanguageModelTrainingDatasetLocationDetailsOutputReference\"}")]
        public virtual oci.AiLanguageModel.AiLanguageModelTrainingDatasetLocationDetailsOutputReference LocationDetails
        {
            get => GetInstanceProperty<oci.AiLanguageModel.AiLanguageModelTrainingDatasetLocationDetailsOutputReference>()!;
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
        [JsiiProperty(name: "locationDetailsInput", typeJson: "{\"fqn\":\"oci.aiLanguageModel.AiLanguageModelTrainingDatasetLocationDetails\"}", isOptional: true)]
        public virtual oci.AiLanguageModel.IAiLanguageModelTrainingDatasetLocationDetails? LocationDetailsInput
        {
            get => GetInstanceProperty<oci.AiLanguageModel.IAiLanguageModelTrainingDatasetLocationDetails?>();
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.aiLanguageModel.AiLanguageModelTrainingDataset\"}", isOptional: true)]
        public virtual oci.AiLanguageModel.IAiLanguageModelTrainingDataset? InternalValue
        {
            get => GetInstanceProperty<oci.AiLanguageModel.IAiLanguageModelTrainingDataset?>();
            set => SetInstanceProperty(value);
        }
    }
}
