using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AiLanguageModel
{
    [JsiiInterface(nativeType: typeof(IAiLanguageModelTestStrategy), fullyQualifiedName: "oci.aiLanguageModel.AiLanguageModelTestStrategy")]
    public interface IAiLanguageModelTestStrategy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_language_model#strategy_type AiLanguageModel#strategy_type}.</summary>
        [JsiiProperty(name: "strategyType", typeJson: "{\"primitive\":\"string\"}")]
        string StrategyType
        {
            get;
        }

        /// <summary>testing_dataset block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_language_model#testing_dataset AiLanguageModel#testing_dataset}
        /// </remarks>
        [JsiiProperty(name: "testingDataset", typeJson: "{\"fqn\":\"oci.aiLanguageModel.AiLanguageModelTestStrategyTestingDataset\"}")]
        oci.AiLanguageModel.IAiLanguageModelTestStrategyTestingDataset TestingDataset
        {
            get;
        }

        /// <summary>validation_dataset block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_language_model#validation_dataset AiLanguageModel#validation_dataset}
        /// </remarks>
        [JsiiProperty(name: "validationDataset", typeJson: "{\"fqn\":\"oci.aiLanguageModel.AiLanguageModelTestStrategyValidationDataset\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.AiLanguageModel.IAiLanguageModelTestStrategyValidationDataset? ValidationDataset
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAiLanguageModelTestStrategy), fullyQualifiedName: "oci.aiLanguageModel.AiLanguageModelTestStrategy")]
        internal sealed class _Proxy : DeputyBase, oci.AiLanguageModel.IAiLanguageModelTestStrategy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_language_model#strategy_type AiLanguageModel#strategy_type}.</summary>
            [JsiiProperty(name: "strategyType", typeJson: "{\"primitive\":\"string\"}")]
            public string StrategyType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>testing_dataset block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_language_model#testing_dataset AiLanguageModel#testing_dataset}
            /// </remarks>
            [JsiiProperty(name: "testingDataset", typeJson: "{\"fqn\":\"oci.aiLanguageModel.AiLanguageModelTestStrategyTestingDataset\"}")]
            public oci.AiLanguageModel.IAiLanguageModelTestStrategyTestingDataset TestingDataset
            {
                get => GetInstanceProperty<oci.AiLanguageModel.IAiLanguageModelTestStrategyTestingDataset>()!;
            }

            /// <summary>validation_dataset block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_language_model#validation_dataset AiLanguageModel#validation_dataset}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "validationDataset", typeJson: "{\"fqn\":\"oci.aiLanguageModel.AiLanguageModelTestStrategyValidationDataset\"}", isOptional: true)]
            public oci.AiLanguageModel.IAiLanguageModelTestStrategyValidationDataset? ValidationDataset
            {
                get => GetInstanceProperty<oci.AiLanguageModel.IAiLanguageModelTestStrategyValidationDataset?>();
            }
        }
    }
}
