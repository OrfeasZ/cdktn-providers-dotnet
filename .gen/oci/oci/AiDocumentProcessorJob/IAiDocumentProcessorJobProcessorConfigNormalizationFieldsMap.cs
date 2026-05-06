using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AiDocumentProcessorJob
{
    [JsiiInterface(nativeType: typeof(IAiDocumentProcessorJobProcessorConfigNormalizationFieldsMap), fullyQualifiedName: "oci.aiDocumentProcessorJob.AiDocumentProcessorJobProcessorConfigNormalizationFieldsMap")]
    public interface IAiDocumentProcessorJobProcessorConfigNormalizationFieldsMap
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#normalization_type AiDocumentProcessorJob#normalization_type}.</summary>
        [JsiiProperty(name: "normalizationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NormalizationType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAiDocumentProcessorJobProcessorConfigNormalizationFieldsMap), fullyQualifiedName: "oci.aiDocumentProcessorJob.AiDocumentProcessorJobProcessorConfigNormalizationFieldsMap")]
        internal sealed class _Proxy : DeputyBase, oci.AiDocumentProcessorJob.IAiDocumentProcessorJobProcessorConfigNormalizationFieldsMap
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#normalization_type AiDocumentProcessorJob#normalization_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "normalizationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NormalizationType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
