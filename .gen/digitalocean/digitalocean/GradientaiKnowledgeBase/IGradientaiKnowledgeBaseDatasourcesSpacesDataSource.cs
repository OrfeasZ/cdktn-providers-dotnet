using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.GradientaiKnowledgeBase
{
    [JsiiInterface(nativeType: typeof(IGradientaiKnowledgeBaseDatasourcesSpacesDataSource), fullyQualifiedName: "digitalocean.gradientaiKnowledgeBase.GradientaiKnowledgeBaseDatasourcesSpacesDataSource")]
    public interface IGradientaiKnowledgeBaseDatasourcesSpacesDataSource
    {
        /// <summary>The name of the Spaces bucket.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/gradientai_knowledge_base#bucket_name GradientaiKnowledgeBase#bucket_name}
        /// </remarks>
        [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BucketName
        {
            get
            {
                return null;
            }
        }

        /// <summary>The path to the item in the bucket.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/gradientai_knowledge_base#item_path GradientaiKnowledgeBase#item_path}
        /// </remarks>
        [JsiiProperty(name: "itemPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ItemPath
        {
            get
            {
                return null;
            }
        }

        /// <summary>The region of the Spaces bucket.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/gradientai_knowledge_base#region GradientaiKnowledgeBase#region}
        /// </remarks>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Region
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGradientaiKnowledgeBaseDatasourcesSpacesDataSource), fullyQualifiedName: "digitalocean.gradientaiKnowledgeBase.GradientaiKnowledgeBaseDatasourcesSpacesDataSource")]
        internal sealed class _Proxy : DeputyBase, digitalocean.GradientaiKnowledgeBase.IGradientaiKnowledgeBaseDatasourcesSpacesDataSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The name of the Spaces bucket.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/gradientai_knowledge_base#bucket_name GradientaiKnowledgeBase#bucket_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BucketName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The path to the item in the bucket.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/gradientai_knowledge_base#item_path GradientaiKnowledgeBase#item_path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "itemPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ItemPath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The region of the Spaces bucket.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/gradientai_knowledge_base#region GradientaiKnowledgeBase#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
