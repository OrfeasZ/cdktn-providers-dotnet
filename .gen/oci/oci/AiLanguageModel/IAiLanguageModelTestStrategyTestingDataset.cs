using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AiLanguageModel
{
    [JsiiInterface(nativeType: typeof(IAiLanguageModelTestStrategyTestingDataset), fullyQualifiedName: "oci.aiLanguageModel.AiLanguageModelTestStrategyTestingDataset")]
    public interface IAiLanguageModelTestStrategyTestingDataset
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_language_model#dataset_type AiLanguageModel#dataset_type}.</summary>
        [JsiiProperty(name: "datasetType", typeJson: "{\"primitive\":\"string\"}")]
        string DatasetType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_language_model#dataset_id AiLanguageModel#dataset_id}.</summary>
        [JsiiProperty(name: "datasetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DatasetId
        {
            get
            {
                return null;
            }
        }

        /// <summary>location_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_language_model#location_details AiLanguageModel#location_details}
        /// </remarks>
        [JsiiProperty(name: "locationDetails", typeJson: "{\"fqn\":\"oci.aiLanguageModel.AiLanguageModelTestStrategyTestingDatasetLocationDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.AiLanguageModel.IAiLanguageModelTestStrategyTestingDatasetLocationDetails? LocationDetails
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAiLanguageModelTestStrategyTestingDataset), fullyQualifiedName: "oci.aiLanguageModel.AiLanguageModelTestStrategyTestingDataset")]
        internal sealed class _Proxy : DeputyBase, oci.AiLanguageModel.IAiLanguageModelTestStrategyTestingDataset
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_language_model#dataset_type AiLanguageModel#dataset_type}.</summary>
            [JsiiProperty(name: "datasetType", typeJson: "{\"primitive\":\"string\"}")]
            public string DatasetType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_language_model#dataset_id AiLanguageModel#dataset_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "datasetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DatasetId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>location_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_language_model#location_details AiLanguageModel#location_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "locationDetails", typeJson: "{\"fqn\":\"oci.aiLanguageModel.AiLanguageModelTestStrategyTestingDatasetLocationDetails\"}", isOptional: true)]
            public oci.AiLanguageModel.IAiLanguageModelTestStrategyTestingDatasetLocationDetails? LocationDetails
            {
                get => GetInstanceProperty<oci.AiLanguageModel.IAiLanguageModelTestStrategyTestingDatasetLocationDetails?>();
            }
        }
    }
}
