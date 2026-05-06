using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AiDocumentProcessorJob
{
    [JsiiInterface(nativeType: typeof(IAiDocumentProcessorJobProcessorConfigNormalizationFields), fullyQualifiedName: "oci.aiDocumentProcessorJob.AiDocumentProcessorJobProcessorConfigNormalizationFields")]
    public interface IAiDocumentProcessorJobProcessorConfigNormalizationFields
    {
        /// <summary>map block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#map AiDocumentProcessorJob#map}
        /// </remarks>
        [JsiiProperty(name: "map", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.aiDocumentProcessorJob.AiDocumentProcessorJobProcessorConfigNormalizationFieldsMap\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Map
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAiDocumentProcessorJobProcessorConfigNormalizationFields), fullyQualifiedName: "oci.aiDocumentProcessorJob.AiDocumentProcessorJobProcessorConfigNormalizationFields")]
        internal sealed class _Proxy : DeputyBase, oci.AiDocumentProcessorJob.IAiDocumentProcessorJobProcessorConfigNormalizationFields
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>map block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#map AiDocumentProcessorJob#map}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "map", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.aiDocumentProcessorJob.AiDocumentProcessorJobProcessorConfigNormalizationFieldsMap\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Map
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
