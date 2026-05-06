using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsBuildPipelineStage
{
    [JsiiInterface(nativeType: typeof(IDevopsBuildPipelineStageBuildSourceCollectionItems), fullyQualifiedName: "oci.devopsBuildPipelineStage.DevopsBuildPipelineStageBuildSourceCollectionItems")]
    public interface IDevopsBuildPipelineStageBuildSourceCollectionItems
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#connection_type DevopsBuildPipelineStage#connection_type}.</summary>
        [JsiiProperty(name: "connectionType", typeJson: "{\"primitive\":\"string\"}")]
        string ConnectionType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#branch DevopsBuildPipelineStage#branch}.</summary>
        [JsiiProperty(name: "branch", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Branch
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#connection_id DevopsBuildPipelineStage#connection_id}.</summary>
        [JsiiProperty(name: "connectionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConnectionId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#name DevopsBuildPipelineStage#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#repository_id DevopsBuildPipelineStage#repository_id}.</summary>
        [JsiiProperty(name: "repositoryId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RepositoryId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#repository_url DevopsBuildPipelineStage#repository_url}.</summary>
        [JsiiProperty(name: "repositoryUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RepositoryUrl
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsBuildPipelineStageBuildSourceCollectionItems), fullyQualifiedName: "oci.devopsBuildPipelineStage.DevopsBuildPipelineStageBuildSourceCollectionItems")]
        internal sealed class _Proxy : DeputyBase, oci.DevopsBuildPipelineStage.IDevopsBuildPipelineStageBuildSourceCollectionItems
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#connection_type DevopsBuildPipelineStage#connection_type}.</summary>
            [JsiiProperty(name: "connectionType", typeJson: "{\"primitive\":\"string\"}")]
            public string ConnectionType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#branch DevopsBuildPipelineStage#branch}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "branch", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Branch
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#connection_id DevopsBuildPipelineStage#connection_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "connectionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConnectionId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#name DevopsBuildPipelineStage#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#repository_id DevopsBuildPipelineStage#repository_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "repositoryId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RepositoryId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_pipeline_stage#repository_url DevopsBuildPipelineStage#repository_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "repositoryUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RepositoryUrl
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
