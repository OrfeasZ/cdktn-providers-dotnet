using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.GradientaiKnowledgeBase
{
    [JsiiInterface(nativeType: typeof(IGradientaiKnowledgeBaseDatasourcesFileUploadDataSource), fullyQualifiedName: "digitalocean.gradientaiKnowledgeBase.GradientaiKnowledgeBaseDatasourcesFileUploadDataSource")]
    public interface IGradientaiKnowledgeBaseDatasourcesFileUploadDataSource
    {
        /// <summary>The original name of the uploaded file.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_knowledge_base#original_file_name GradientaiKnowledgeBase#original_file_name}
        /// </remarks>
        [JsiiProperty(name: "originalFileName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OriginalFileName
        {
            get
            {
                return null;
            }
        }

        /// <summary>The size of the file in bytes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_knowledge_base#size_in_bytes GradientaiKnowledgeBase#size_in_bytes}
        /// </remarks>
        [JsiiProperty(name: "sizeInBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SizeInBytes
        {
            get
            {
                return null;
            }
        }

        /// <summary>The stored object key for the file.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_knowledge_base#stored_object_key GradientaiKnowledgeBase#stored_object_key}
        /// </remarks>
        [JsiiProperty(name: "storedObjectKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StoredObjectKey
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGradientaiKnowledgeBaseDatasourcesFileUploadDataSource), fullyQualifiedName: "digitalocean.gradientaiKnowledgeBase.GradientaiKnowledgeBaseDatasourcesFileUploadDataSource")]
        internal sealed class _Proxy : DeputyBase, digitalocean.GradientaiKnowledgeBase.IGradientaiKnowledgeBaseDatasourcesFileUploadDataSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The original name of the uploaded file.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_knowledge_base#original_file_name GradientaiKnowledgeBase#original_file_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "originalFileName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OriginalFileName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The size of the file in bytes.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_knowledge_base#size_in_bytes GradientaiKnowledgeBase#size_in_bytes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sizeInBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SizeInBytes
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The stored object key for the file.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_knowledge_base#stored_object_key GradientaiKnowledgeBase#stored_object_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storedObjectKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StoredObjectKey
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
