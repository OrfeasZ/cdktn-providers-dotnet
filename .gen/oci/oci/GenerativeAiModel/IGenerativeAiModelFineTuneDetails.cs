using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiModel
{
    [JsiiInterface(nativeType: typeof(IGenerativeAiModelFineTuneDetails), fullyQualifiedName: "oci.generativeAiModel.GenerativeAiModelFineTuneDetails")]
    public interface IGenerativeAiModelFineTuneDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_model#dedicated_ai_cluster_id GenerativeAiModel#dedicated_ai_cluster_id}.</summary>
        [JsiiProperty(name: "dedicatedAiClusterId", typeJson: "{\"primitive\":\"string\"}")]
        string DedicatedAiClusterId
        {
            get;
        }

        /// <summary>training_dataset block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_model#training_dataset GenerativeAiModel#training_dataset}
        /// </remarks>
        [JsiiProperty(name: "trainingDataset", typeJson: "{\"fqn\":\"oci.generativeAiModel.GenerativeAiModelFineTuneDetailsTrainingDataset\"}")]
        oci.GenerativeAiModel.IGenerativeAiModelFineTuneDetailsTrainingDataset TrainingDataset
        {
            get;
        }

        /// <summary>training_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_model#training_config GenerativeAiModel#training_config}
        /// </remarks>
        [JsiiProperty(name: "trainingConfig", typeJson: "{\"fqn\":\"oci.generativeAiModel.GenerativeAiModelFineTuneDetailsTrainingConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.GenerativeAiModel.IGenerativeAiModelFineTuneDetailsTrainingConfig? TrainingConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGenerativeAiModelFineTuneDetails), fullyQualifiedName: "oci.generativeAiModel.GenerativeAiModelFineTuneDetails")]
        internal sealed class _Proxy : DeputyBase, oci.GenerativeAiModel.IGenerativeAiModelFineTuneDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_model#dedicated_ai_cluster_id GenerativeAiModel#dedicated_ai_cluster_id}.</summary>
            [JsiiProperty(name: "dedicatedAiClusterId", typeJson: "{\"primitive\":\"string\"}")]
            public string DedicatedAiClusterId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>training_dataset block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_model#training_dataset GenerativeAiModel#training_dataset}
            /// </remarks>
            [JsiiProperty(name: "trainingDataset", typeJson: "{\"fqn\":\"oci.generativeAiModel.GenerativeAiModelFineTuneDetailsTrainingDataset\"}")]
            public oci.GenerativeAiModel.IGenerativeAiModelFineTuneDetailsTrainingDataset TrainingDataset
            {
                get => GetInstanceProperty<oci.GenerativeAiModel.IGenerativeAiModelFineTuneDetailsTrainingDataset>()!;
            }

            /// <summary>training_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_model#training_config GenerativeAiModel#training_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "trainingConfig", typeJson: "{\"fqn\":\"oci.generativeAiModel.GenerativeAiModelFineTuneDetailsTrainingConfig\"}", isOptional: true)]
            public oci.GenerativeAiModel.IGenerativeAiModelFineTuneDetailsTrainingConfig? TrainingConfig
            {
                get => GetInstanceProperty<oci.GenerativeAiModel.IGenerativeAiModelFineTuneDetailsTrainingConfig?>();
            }
        }
    }
}
