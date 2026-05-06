using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AiDocumentProcessorJob
{
    [JsiiInterface(nativeType: typeof(IAiDocumentProcessorJobProcessorConfig), fullyQualifiedName: "oci.aiDocumentProcessorJob.AiDocumentProcessorJobProcessorConfig")]
    public interface IAiDocumentProcessorJobProcessorConfig
    {
        /// <summary>features block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#features AiDocumentProcessorJob#features}
        /// </remarks>
        [JsiiProperty(name: "features", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.aiDocumentProcessorJob.AiDocumentProcessorJobProcessorConfigFeatures\"},\"kind\":\"array\"}}]}}")]
        object Features
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#processor_type AiDocumentProcessorJob#processor_type}.</summary>
        [JsiiProperty(name: "processorType", typeJson: "{\"primitive\":\"string\"}")]
        string ProcessorType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#document_type AiDocumentProcessorJob#document_type}.</summary>
        [JsiiProperty(name: "documentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DocumentType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#is_zip_output_enabled AiDocumentProcessorJob#is_zip_output_enabled}.</summary>
        [JsiiProperty(name: "isZipOutputEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsZipOutputEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#language AiDocumentProcessorJob#language}.</summary>
        [JsiiProperty(name: "language", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Language
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

        /// <summary>normalization_fields block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#normalization_fields AiDocumentProcessorJob#normalization_fields}
        /// </remarks>
        [JsiiProperty(name: "normalizationFields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.aiDocumentProcessorJob.AiDocumentProcessorJobProcessorConfigNormalizationFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NormalizationFields
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAiDocumentProcessorJobProcessorConfig), fullyQualifiedName: "oci.aiDocumentProcessorJob.AiDocumentProcessorJobProcessorConfig")]
        internal sealed class _Proxy : DeputyBase, oci.AiDocumentProcessorJob.IAiDocumentProcessorJobProcessorConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>features block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#features AiDocumentProcessorJob#features}
            /// </remarks>
            [JsiiProperty(name: "features", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.aiDocumentProcessorJob.AiDocumentProcessorJobProcessorConfigFeatures\"},\"kind\":\"array\"}}]}}")]
            public object Features
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#processor_type AiDocumentProcessorJob#processor_type}.</summary>
            [JsiiProperty(name: "processorType", typeJson: "{\"primitive\":\"string\"}")]
            public string ProcessorType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#document_type AiDocumentProcessorJob#document_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "documentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DocumentType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#is_zip_output_enabled AiDocumentProcessorJob#is_zip_output_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isZipOutputEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsZipOutputEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#language AiDocumentProcessorJob#language}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "language", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Language
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#model_id AiDocumentProcessorJob#model_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "modelId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ModelId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>normalization_fields block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#normalization_fields AiDocumentProcessorJob#normalization_fields}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "normalizationFields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.aiDocumentProcessorJob.AiDocumentProcessorJobProcessorConfigNormalizationFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? NormalizationFields
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
