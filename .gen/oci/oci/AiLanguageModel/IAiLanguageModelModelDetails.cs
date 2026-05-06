using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AiLanguageModel
{
    [JsiiInterface(nativeType: typeof(IAiLanguageModelModelDetails), fullyQualifiedName: "oci.aiLanguageModel.AiLanguageModelModelDetails")]
    public interface IAiLanguageModelModelDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_language_model#model_type AiLanguageModel#model_type}.</summary>
        [JsiiProperty(name: "modelType", typeJson: "{\"primitive\":\"string\"}")]
        string ModelType
        {
            get;
        }

        /// <summary>classification_mode block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_language_model#classification_mode AiLanguageModel#classification_mode}
        /// </remarks>
        [JsiiProperty(name: "classificationMode", typeJson: "{\"fqn\":\"oci.aiLanguageModel.AiLanguageModelModelDetailsClassificationMode\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.AiLanguageModel.IAiLanguageModelModelDetailsClassificationMode? ClassificationMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_language_model#language_code AiLanguageModel#language_code}.</summary>
        [JsiiProperty(name: "languageCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LanguageCode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_language_model#version AiLanguageModel#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Version
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAiLanguageModelModelDetails), fullyQualifiedName: "oci.aiLanguageModel.AiLanguageModelModelDetails")]
        internal sealed class _Proxy : DeputyBase, oci.AiLanguageModel.IAiLanguageModelModelDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_language_model#model_type AiLanguageModel#model_type}.</summary>
            [JsiiProperty(name: "modelType", typeJson: "{\"primitive\":\"string\"}")]
            public string ModelType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>classification_mode block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_language_model#classification_mode AiLanguageModel#classification_mode}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "classificationMode", typeJson: "{\"fqn\":\"oci.aiLanguageModel.AiLanguageModelModelDetailsClassificationMode\"}", isOptional: true)]
            public oci.AiLanguageModel.IAiLanguageModelModelDetailsClassificationMode? ClassificationMode
            {
                get => GetInstanceProperty<oci.AiLanguageModel.IAiLanguageModelModelDetailsClassificationMode?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_language_model#language_code AiLanguageModel#language_code}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "languageCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LanguageCode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_language_model#version AiLanguageModel#version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Version
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
