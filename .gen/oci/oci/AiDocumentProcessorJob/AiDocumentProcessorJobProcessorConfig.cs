using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AiDocumentProcessorJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.aiDocumentProcessorJob.AiDocumentProcessorJobProcessorConfig")]
    public class AiDocumentProcessorJobProcessorConfig : oci.AiDocumentProcessorJob.IAiDocumentProcessorJobProcessorConfig
    {
        private object _features;

        /// <summary>features block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#features AiDocumentProcessorJob#features}
        /// </remarks>
        [JsiiProperty(name: "features", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.aiDocumentProcessorJob.AiDocumentProcessorJobProcessorConfigFeatures\"},\"kind\":\"array\"}}]}}")]
        public object Features
        {
            get => _features;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.AiDocumentProcessorJob.IAiDocumentProcessorJobProcessorConfigFeatures[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.AiDocumentProcessorJob.IAiDocumentProcessorJobProcessorConfigFeatures).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.AiDocumentProcessorJob.IAiDocumentProcessorJobProcessorConfigFeatures).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _features = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#processor_type AiDocumentProcessorJob#processor_type}.</summary>
        [JsiiProperty(name: "processorType", typeJson: "{\"primitive\":\"string\"}")]
        public string ProcessorType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#document_type AiDocumentProcessorJob#document_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "documentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DocumentType
        {
            get;
            set;
        }

        private object? _isZipOutputEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#is_zip_output_enabled AiDocumentProcessorJob#is_zip_output_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isZipOutputEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsZipOutputEnabled
        {
            get => _isZipOutputEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isZipOutputEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#language AiDocumentProcessorJob#language}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "language", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Language
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#model_id AiDocumentProcessorJob#model_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "modelId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ModelId
        {
            get;
            set;
        }

        private object? _normalizationFields;

        /// <summary>normalization_fields block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#normalization_fields AiDocumentProcessorJob#normalization_fields}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "normalizationFields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.aiDocumentProcessorJob.AiDocumentProcessorJobProcessorConfigNormalizationFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? NormalizationFields
        {
            get => _normalizationFields;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.AiDocumentProcessorJob.IAiDocumentProcessorJobProcessorConfigNormalizationFields[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.AiDocumentProcessorJob.IAiDocumentProcessorJobProcessorConfigNormalizationFields).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _normalizationFields = value;
            }
        }
    }
}
