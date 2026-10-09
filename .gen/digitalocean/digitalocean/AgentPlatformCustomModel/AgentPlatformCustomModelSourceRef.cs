using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.AgentPlatformCustomModel
{
    [JsiiByValue(fqn: "digitalocean.agentPlatformCustomModel.AgentPlatformCustomModelSourceRef")]
    public class AgentPlatformCustomModelSourceRef : digitalocean.AgentPlatformCustomModel.IAgentPlatformCustomModelSourceRef
    {
        /// <summary>Access type for the source repository. One of ACCESS_TYPE_PUBLIC, ACCESS_TYPE_PRIVATE, ACCESS_TYPE_GATED.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_custom_model#access_type AgentPlatformCustomModel#access_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "accessType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccessType
        {
            get;
            set;
        }

        /// <summary>Spaces bucket name for SOURCE_TYPE_SPACES_BUCKET sources.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_custom_model#bucket AgentPlatformCustomModel#bucket}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Bucket
        {
            get;
            set;
        }

        /// <summary>Commit SHA to pin for the import. If omitted, the API resolves and returns the SHA actually imported.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_custom_model#commit_sha AgentPlatformCustomModel#commit_sha}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "commitSha", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CommitSha
        {
            get;
            set;
        }

        /// <summary>HuggingFace token used to access ACCESS_TYPE_PRIVATE or ACCESS_TYPE_GATED repositories. Write-only.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_custom_model#hf_token AgentPlatformCustomModel#hf_token}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hfToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HfToken
        {
            get;
            set;
        }

        /// <summary>Key prefix inside the source bucket.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_custom_model#prefix AgentPlatformCustomModel#prefix}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Prefix
        {
            get;
            set;
        }

        /// <summary>Region of the source bucket.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_custom_model#region AgentPlatformCustomModel#region}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Region
        {
            get;
            set;
        }

        /// <summary>Repository identifier (e.g. the HuggingFace repo). Required for SOURCE_TYPE_HUGGINGFACE sources.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/resources/agent_platform_custom_model#repo_id AgentPlatformCustomModel#repo_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "repoId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RepoId
        {
            get;
            set;
        }
    }
}
