using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AiDocumentModel
{
    [JsiiInterface(nativeType: typeof(IAiDocumentModelTrainingDataset), fullyQualifiedName: "oci.aiDocumentModel.AiDocumentModelTrainingDataset")]
    public interface IAiDocumentModelTrainingDataset
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_model#dataset_type AiDocumentModel#dataset_type}.</summary>
        [JsiiProperty(name: "datasetType", typeJson: "{\"primitive\":\"string\"}")]
        string DatasetType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_model#bucket AiDocumentModel#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Bucket
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_model#dataset_id AiDocumentModel#dataset_id}.</summary>
        [JsiiProperty(name: "datasetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DatasetId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_model#namespace AiDocumentModel#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Namespace
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_model#object AiDocumentModel#object}.</summary>
        [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Object
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAiDocumentModelTrainingDataset), fullyQualifiedName: "oci.aiDocumentModel.AiDocumentModelTrainingDataset")]
        internal sealed class _Proxy : DeputyBase, oci.AiDocumentModel.IAiDocumentModelTrainingDataset
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_model#dataset_type AiDocumentModel#dataset_type}.</summary>
            [JsiiProperty(name: "datasetType", typeJson: "{\"primitive\":\"string\"}")]
            public string DatasetType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_model#bucket AiDocumentModel#bucket}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Bucket
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_model#dataset_id AiDocumentModel#dataset_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "datasetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DatasetId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_model#namespace AiDocumentModel#namespace}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Namespace
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_document_model#object AiDocumentModel#object}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Object
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
