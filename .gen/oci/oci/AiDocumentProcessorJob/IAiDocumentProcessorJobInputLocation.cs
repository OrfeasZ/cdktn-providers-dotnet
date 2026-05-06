using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AiDocumentProcessorJob
{
    [JsiiInterface(nativeType: typeof(IAiDocumentProcessorJobInputLocation), fullyQualifiedName: "oci.aiDocumentProcessorJob.AiDocumentProcessorJobInputLocation")]
    public interface IAiDocumentProcessorJobInputLocation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#source_type AiDocumentProcessorJob#source_type}.</summary>
        [JsiiProperty(name: "sourceType", typeJson: "{\"primitive\":\"string\"}")]
        string SourceType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#data AiDocumentProcessorJob#data}.</summary>
        [JsiiProperty(name: "data", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Data
        {
            get
            {
                return null;
            }
        }

        /// <summary>object_locations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#object_locations AiDocumentProcessorJob#object_locations}
        /// </remarks>
        [JsiiProperty(name: "objectLocations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.aiDocumentProcessorJob.AiDocumentProcessorJobInputLocationObjectLocations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ObjectLocations
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#page_range AiDocumentProcessorJob#page_range}.</summary>
        [JsiiProperty(name: "pageRange", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? PageRange
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAiDocumentProcessorJobInputLocation), fullyQualifiedName: "oci.aiDocumentProcessorJob.AiDocumentProcessorJobInputLocation")]
        internal sealed class _Proxy : DeputyBase, oci.AiDocumentProcessorJob.IAiDocumentProcessorJobInputLocation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#source_type AiDocumentProcessorJob#source_type}.</summary>
            [JsiiProperty(name: "sourceType", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#data AiDocumentProcessorJob#data}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "data", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Data
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>object_locations block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#object_locations AiDocumentProcessorJob#object_locations}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "objectLocations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.aiDocumentProcessorJob.AiDocumentProcessorJobInputLocationObjectLocations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ObjectLocations
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_processor_job#page_range AiDocumentProcessorJob#page_range}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "pageRange", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? PageRange
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
