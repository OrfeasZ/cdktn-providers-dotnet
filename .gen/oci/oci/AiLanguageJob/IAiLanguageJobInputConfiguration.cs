using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AiLanguageJob
{
    [JsiiInterface(nativeType: typeof(IAiLanguageJobInputConfiguration), fullyQualifiedName: "oci.aiLanguageJob.AiLanguageJobInputConfiguration")]
    public interface IAiLanguageJobInputConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/ai_language_job#configuration AiLanguageJob#configuration}.</summary>
        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, Dictionary&lt;string, string&gt;&gt;</para>
        /// </remarks>
        [JsiiProperty(name: "configuration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}},\"kind\":\"map\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Configuration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/ai_language_job#document_types AiLanguageJob#document_types}.</summary>
        [JsiiProperty(name: "documentTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? DocumentTypes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAiLanguageJobInputConfiguration), fullyQualifiedName: "oci.aiLanguageJob.AiLanguageJobInputConfiguration")]
        internal sealed class _Proxy : DeputyBase, oci.AiLanguageJob.IAiLanguageJobInputConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/ai_language_job#configuration AiLanguageJob#configuration}.</summary>
            /// <remarks>
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, Dictionary&lt;string, string&gt;&gt;</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "configuration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? Configuration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/ai_language_job#document_types AiLanguageJob#document_types}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "documentTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? DocumentTypes
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
