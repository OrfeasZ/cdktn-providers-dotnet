using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.GradientaiKnowledgeBase
{
    [JsiiByValue(fqn: "digitalocean.gradientaiKnowledgeBase.GradientaiKnowledgeBaseDatasourcesFileUploadDataSource")]
    public class GradientaiKnowledgeBaseDatasourcesFileUploadDataSource : digitalocean.GradientaiKnowledgeBase.IGradientaiKnowledgeBaseDatasourcesFileUploadDataSource
    {
        /// <summary>The original name of the uploaded file.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/gradientai_knowledge_base#original_file_name GradientaiKnowledgeBase#original_file_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "originalFileName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OriginalFileName
        {
            get;
            set;
        }

        /// <summary>The size of the file in bytes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/gradientai_knowledge_base#size_in_bytes GradientaiKnowledgeBase#size_in_bytes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sizeInBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SizeInBytes
        {
            get;
            set;
        }

        /// <summary>The stored object key for the file.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/gradientai_knowledge_base#stored_object_key GradientaiKnowledgeBase#stored_object_key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "storedObjectKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StoredObjectKey
        {
            get;
            set;
        }
    }
}
