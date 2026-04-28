using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.GradientaiKnowledgeBaseDataSource
{
    [JsiiByValue(fqn: "digitalocean.gradientaiKnowledgeBaseDataSource.GradientaiKnowledgeBaseDataSourceSpacesDataSource")]
    public class GradientaiKnowledgeBaseDataSourceSpacesDataSource : digitalocean.GradientaiKnowledgeBaseDataSource.IGradientaiKnowledgeBaseDataSourceSpacesDataSource
    {
        /// <summary>The name of the Spaces bucket.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/gradientai_knowledge_base_data_source#bucket_name GradientaiKnowledgeBaseDataSource#bucket_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BucketName
        {
            get;
            set;
        }

        /// <summary>The path to the item in the bucket.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/gradientai_knowledge_base_data_source#item_path GradientaiKnowledgeBaseDataSource#item_path}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "itemPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ItemPath
        {
            get;
            set;
        }

        /// <summary>The region of the Spaces bucket.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/gradientai_knowledge_base_data_source#region GradientaiKnowledgeBaseDataSource#region}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Region
        {
            get;
            set;
        }
    }
}
