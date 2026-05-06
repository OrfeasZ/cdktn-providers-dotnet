using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AiDocumentProcessorJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.aiDocumentProcessorJob.AiDocumentProcessorJobInputLocation")]
    public class AiDocumentProcessorJobInputLocation : oci.AiDocumentProcessorJob.IAiDocumentProcessorJobInputLocation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#source_type AiDocumentProcessorJob#source_type}.</summary>
        [JsiiProperty(name: "sourceType", typeJson: "{\"primitive\":\"string\"}")]
        public string SourceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#data AiDocumentProcessorJob#data}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "data", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Data
        {
            get;
            set;
        }

        private object? _objectLocations;

        /// <summary>object_locations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#object_locations AiDocumentProcessorJob#object_locations}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "objectLocations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.aiDocumentProcessorJob.AiDocumentProcessorJobInputLocationObjectLocations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ObjectLocations
        {
            get => _objectLocations;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.AiDocumentProcessorJob.IAiDocumentProcessorJobInputLocationObjectLocations[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.AiDocumentProcessorJob.IAiDocumentProcessorJobInputLocationObjectLocations).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _objectLocations = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#page_range AiDocumentProcessorJob#page_range}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pageRange", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? PageRange
        {
            get;
            set;
        }
    }
}
