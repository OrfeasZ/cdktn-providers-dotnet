using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AiDocumentProcessorJob
{
    [JsiiByValue(fqn: "oci.aiDocumentProcessorJob.AiDocumentProcessorJobProcessorConfigNormalizationFieldsMap")]
    public class AiDocumentProcessorJobProcessorConfigNormalizationFieldsMap : oci.AiDocumentProcessorJob.IAiDocumentProcessorJobProcessorConfigNormalizationFieldsMap
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#normalization_type AiDocumentProcessorJob#normalization_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "normalizationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NormalizationType
        {
            get;
            set;
        }
    }
}
