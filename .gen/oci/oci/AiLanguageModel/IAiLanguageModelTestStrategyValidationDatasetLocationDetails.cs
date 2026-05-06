using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AiLanguageModel
{
    [JsiiInterface(nativeType: typeof(IAiLanguageModelTestStrategyValidationDatasetLocationDetails), fullyQualifiedName: "oci.aiLanguageModel.AiLanguageModelTestStrategyValidationDatasetLocationDetails")]
    public interface IAiLanguageModelTestStrategyValidationDatasetLocationDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_language_model#bucket AiLanguageModel#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        string Bucket
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_language_model#location_type AiLanguageModel#location_type}.</summary>
        [JsiiProperty(name: "locationType", typeJson: "{\"primitive\":\"string\"}")]
        string LocationType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_language_model#namespace AiLanguageModel#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        string Namespace
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_language_model#object_names AiLanguageModel#object_names}.</summary>
        [JsiiProperty(name: "objectNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] ObjectNames
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAiLanguageModelTestStrategyValidationDatasetLocationDetails), fullyQualifiedName: "oci.aiLanguageModel.AiLanguageModelTestStrategyValidationDatasetLocationDetails")]
        internal sealed class _Proxy : DeputyBase, oci.AiLanguageModel.IAiLanguageModelTestStrategyValidationDatasetLocationDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_language_model#bucket AiLanguageModel#bucket}.</summary>
            [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
            public string Bucket
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_language_model#location_type AiLanguageModel#location_type}.</summary>
            [JsiiProperty(name: "locationType", typeJson: "{\"primitive\":\"string\"}")]
            public string LocationType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_language_model#namespace AiLanguageModel#namespace}.</summary>
            [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
            public string Namespace
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_language_model#object_names AiLanguageModel#object_names}.</summary>
            [JsiiProperty(name: "objectNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] ObjectNames
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
