using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiImportedModel
{
    [JsiiByValue(fqn: "oci.generativeAiImportedModel.GenerativeAiImportedModelDataSource")]
    public class GenerativeAiImportedModelDataSource : oci.GenerativeAiImportedModel.IGenerativeAiImportedModelDataSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/generative_ai_imported_model#access_token GenerativeAiImportedModel#access_token}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accessToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccessToken
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/generative_ai_imported_model#branch GenerativeAiImportedModel#branch}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "branch", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Branch
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/generative_ai_imported_model#bucket GenerativeAiImportedModel#bucket}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Bucket
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/generative_ai_imported_model#commit GenerativeAiImportedModel#commit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "commit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Commit
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/generative_ai_imported_model#model_id GenerativeAiImportedModel#model_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "modelId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ModelId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/generative_ai_imported_model#namespace GenerativeAiImportedModel#namespace}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Namespace
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/generative_ai_imported_model#prefix_name GenerativeAiImportedModel#prefix_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "prefixName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrefixName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/generative_ai_imported_model#region GenerativeAiImportedModel#region}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Region
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/generative_ai_imported_model#source_type GenerativeAiImportedModel#source_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceType
        {
            get;
            set;
        }
    }
}
