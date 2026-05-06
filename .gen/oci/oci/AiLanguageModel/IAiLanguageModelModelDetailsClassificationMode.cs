using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AiLanguageModel
{
    [JsiiInterface(nativeType: typeof(IAiLanguageModelModelDetailsClassificationMode), fullyQualifiedName: "oci.aiLanguageModel.AiLanguageModelModelDetailsClassificationMode")]
    public interface IAiLanguageModelModelDetailsClassificationMode
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_language_model#classification_mode AiLanguageModel#classification_mode}.</summary>
        [JsiiProperty(name: "classificationMode", typeJson: "{\"primitive\":\"string\"}")]
        string ClassificationMode
        {
            get;
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

        [JsiiTypeProxy(nativeType: typeof(IAiLanguageModelModelDetailsClassificationMode), fullyQualifiedName: "oci.aiLanguageModel.AiLanguageModelModelDetailsClassificationMode")]
        internal sealed class _Proxy : DeputyBase, oci.AiLanguageModel.IAiLanguageModelModelDetailsClassificationMode
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_language_model#classification_mode AiLanguageModel#classification_mode}.</summary>
            [JsiiProperty(name: "classificationMode", typeJson: "{\"primitive\":\"string\"}")]
            public string ClassificationMode
            {
                get => GetInstanceProperty<string>()!;
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
