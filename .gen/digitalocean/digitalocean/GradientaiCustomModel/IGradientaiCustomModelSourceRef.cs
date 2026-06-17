using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.GradientaiCustomModel
{
    [JsiiInterface(nativeType: typeof(IGradientaiCustomModelSourceRef), fullyQualifiedName: "digitalocean.gradientaiCustomModel.GradientaiCustomModelSourceRef")]
    public interface IGradientaiCustomModelSourceRef
    {
        /// <summary>Access type for the source repository. One of ACCESS_TYPE_PUBLIC, ACCESS_TYPE_PRIVATE, ACCESS_TYPE_GATED.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.90.0/docs/resources/gradientai_custom_model#access_type GradientaiCustomModel#access_type}
        /// </remarks>
        [JsiiProperty(name: "accessType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccessType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Spaces bucket name for SOURCE_TYPE_SPACES_BUCKET sources.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.90.0/docs/resources/gradientai_custom_model#bucket GradientaiCustomModel#bucket}
        /// </remarks>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Bucket
        {
            get
            {
                return null;
            }
        }

        /// <summary>Commit SHA to pin for the import. If omitted, the API resolves and returns the SHA actually imported.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.90.0/docs/resources/gradientai_custom_model#commit_sha GradientaiCustomModel#commit_sha}
        /// </remarks>
        [JsiiProperty(name: "commitSha", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CommitSha
        {
            get
            {
                return null;
            }
        }

        /// <summary>HuggingFace token used to access ACCESS_TYPE_PRIVATE or ACCESS_TYPE_GATED repositories. Write-only.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.90.0/docs/resources/gradientai_custom_model#hf_token GradientaiCustomModel#hf_token}
        /// </remarks>
        [JsiiProperty(name: "hfToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HfToken
        {
            get
            {
                return null;
            }
        }

        /// <summary>Key prefix inside the source bucket.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.90.0/docs/resources/gradientai_custom_model#prefix GradientaiCustomModel#prefix}
        /// </remarks>
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Prefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region of the source bucket.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.90.0/docs/resources/gradientai_custom_model#region GradientaiCustomModel#region}
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

        /// <summary>Repository identifier (e.g. the HuggingFace repo). Required for SOURCE_TYPE_HUGGINGFACE sources.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.90.0/docs/resources/gradientai_custom_model#repo_id GradientaiCustomModel#repo_id}
        /// </remarks>
        [JsiiProperty(name: "repoId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RepoId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGradientaiCustomModelSourceRef), fullyQualifiedName: "digitalocean.gradientaiCustomModel.GradientaiCustomModelSourceRef")]
        internal sealed class _Proxy : DeputyBase, digitalocean.GradientaiCustomModel.IGradientaiCustomModelSourceRef
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Access type for the source repository. One of ACCESS_TYPE_PUBLIC, ACCESS_TYPE_PRIVATE, ACCESS_TYPE_GATED.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.90.0/docs/resources/gradientai_custom_model#access_type GradientaiCustomModel#access_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accessType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccessType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Spaces bucket name for SOURCE_TYPE_SPACES_BUCKET sources.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.90.0/docs/resources/gradientai_custom_model#bucket GradientaiCustomModel#bucket}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Bucket
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Commit SHA to pin for the import. If omitted, the API resolves and returns the SHA actually imported.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.90.0/docs/resources/gradientai_custom_model#commit_sha GradientaiCustomModel#commit_sha}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "commitSha", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CommitSha
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>HuggingFace token used to access ACCESS_TYPE_PRIVATE or ACCESS_TYPE_GATED repositories. Write-only.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.90.0/docs/resources/gradientai_custom_model#hf_token GradientaiCustomModel#hf_token}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hfToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HfToken
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Key prefix inside the source bucket.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.90.0/docs/resources/gradientai_custom_model#prefix GradientaiCustomModel#prefix}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Prefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Region of the source bucket.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.90.0/docs/resources/gradientai_custom_model#region GradientaiCustomModel#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Repository identifier (e.g. the HuggingFace repo). Required for SOURCE_TYPE_HUGGINGFACE sources.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.90.0/docs/resources/gradientai_custom_model#repo_id GradientaiCustomModel#repo_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "repoId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RepoId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
