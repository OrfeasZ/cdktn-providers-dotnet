using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AiDocumentProcessorJob
{
    [JsiiInterface(nativeType: typeof(IAiDocumentProcessorJobProcessorConfigFeatures), fullyQualifiedName: "oci.aiDocumentProcessorJob.AiDocumentProcessorJobProcessorConfigFeatures")]
    public interface IAiDocumentProcessorJobProcessorConfigFeatures
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#feature_type AiDocumentProcessorJob#feature_type}.</summary>
        [JsiiProperty(name: "featureType", typeJson: "{\"primitive\":\"string\"}")]
        string FeatureType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#generate_searchable_pdf AiDocumentProcessorJob#generate_searchable_pdf}.</summary>
        [JsiiProperty(name: "generateSearchablePdf", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? GenerateSearchablePdf
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#max_results AiDocumentProcessorJob#max_results}.</summary>
        [JsiiProperty(name: "maxResults", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxResults
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#model_id AiDocumentProcessorJob#model_id}.</summary>
        [JsiiProperty(name: "modelId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ModelId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#selection_mark_detection AiDocumentProcessorJob#selection_mark_detection}.</summary>
        [JsiiProperty(name: "selectionMarkDetection", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SelectionMarkDetection
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#tenancy_id AiDocumentProcessorJob#tenancy_id}.</summary>
        [JsiiProperty(name: "tenancyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TenancyId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAiDocumentProcessorJobProcessorConfigFeatures), fullyQualifiedName: "oci.aiDocumentProcessorJob.AiDocumentProcessorJobProcessorConfigFeatures")]
        internal sealed class _Proxy : DeputyBase, oci.AiDocumentProcessorJob.IAiDocumentProcessorJobProcessorConfigFeatures
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#feature_type AiDocumentProcessorJob#feature_type}.</summary>
            [JsiiProperty(name: "featureType", typeJson: "{\"primitive\":\"string\"}")]
            public string FeatureType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#generate_searchable_pdf AiDocumentProcessorJob#generate_searchable_pdf}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "generateSearchablePdf", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? GenerateSearchablePdf
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#max_results AiDocumentProcessorJob#max_results}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxResults", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxResults
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#model_id AiDocumentProcessorJob#model_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "modelId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ModelId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#selection_mark_detection AiDocumentProcessorJob#selection_mark_detection}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "selectionMarkDetection", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? SelectionMarkDetection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#tenancy_id AiDocumentProcessorJob#tenancy_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tenancyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TenancyId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
