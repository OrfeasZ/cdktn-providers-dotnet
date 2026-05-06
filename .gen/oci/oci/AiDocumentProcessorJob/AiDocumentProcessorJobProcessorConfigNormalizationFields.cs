using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AiDocumentProcessorJob
{
    [JsiiByValue(fqn: "oci.aiDocumentProcessorJob.AiDocumentProcessorJobProcessorConfigNormalizationFields")]
    public class AiDocumentProcessorJobProcessorConfigNormalizationFields : oci.AiDocumentProcessorJob.IAiDocumentProcessorJobProcessorConfigNormalizationFields
    {
        private object? _map;

        /// <summary>map block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#map AiDocumentProcessorJob#map}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "map", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.aiDocumentProcessorJob.AiDocumentProcessorJobProcessorConfigNormalizationFieldsMap\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Map
        {
            get => _map;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.AiDocumentProcessorJob.IAiDocumentProcessorJobProcessorConfigNormalizationFieldsMap[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.AiDocumentProcessorJob.IAiDocumentProcessorJobProcessorConfigNormalizationFieldsMap).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _map = value;
            }
        }
    }
}
