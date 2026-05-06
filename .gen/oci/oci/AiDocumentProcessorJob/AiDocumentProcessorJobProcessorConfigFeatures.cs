using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AiDocumentProcessorJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.aiDocumentProcessorJob.AiDocumentProcessorJobProcessorConfigFeatures")]
    public class AiDocumentProcessorJobProcessorConfigFeatures : oci.AiDocumentProcessorJob.IAiDocumentProcessorJobProcessorConfigFeatures
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#feature_type AiDocumentProcessorJob#feature_type}.</summary>
        [JsiiProperty(name: "featureType", typeJson: "{\"primitive\":\"string\"}")]
        public string FeatureType
        {
            get;
            set;
        }

        private object? _generateSearchablePdf;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#generate_searchable_pdf AiDocumentProcessorJob#generate_searchable_pdf}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "generateSearchablePdf", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? GenerateSearchablePdf
        {
            get => _generateSearchablePdf;
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
                _generateSearchablePdf = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#max_results AiDocumentProcessorJob#max_results}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxResults", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxResults
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

        private object? _selectionMarkDetection;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#selection_mark_detection AiDocumentProcessorJob#selection_mark_detection}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "selectionMarkDetection", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? SelectionMarkDetection
        {
            get => _selectionMarkDetection;
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
                _selectionMarkDetection = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#tenancy_id AiDocumentProcessorJob#tenancy_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tenancyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TenancyId
        {
            get;
            set;
        }
    }
}
