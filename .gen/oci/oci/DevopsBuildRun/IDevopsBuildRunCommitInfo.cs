using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsBuildRun
{
    [JsiiInterface(nativeType: typeof(IDevopsBuildRunCommitInfo), fullyQualifiedName: "oci.devopsBuildRun.DevopsBuildRunCommitInfo")]
    public interface IDevopsBuildRunCommitInfo
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_run#commit_hash DevopsBuildRun#commit_hash}.</summary>
        [JsiiProperty(name: "commitHash", typeJson: "{\"primitive\":\"string\"}")]
        string CommitHash
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_run#repository_branch DevopsBuildRun#repository_branch}.</summary>
        [JsiiProperty(name: "repositoryBranch", typeJson: "{\"primitive\":\"string\"}")]
        string RepositoryBranch
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_run#repository_url DevopsBuildRun#repository_url}.</summary>
        [JsiiProperty(name: "repositoryUrl", typeJson: "{\"primitive\":\"string\"}")]
        string RepositoryUrl
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsBuildRunCommitInfo), fullyQualifiedName: "oci.devopsBuildRun.DevopsBuildRunCommitInfo")]
        internal sealed class _Proxy : DeputyBase, oci.DevopsBuildRun.IDevopsBuildRunCommitInfo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_run#commit_hash DevopsBuildRun#commit_hash}.</summary>
            [JsiiProperty(name: "commitHash", typeJson: "{\"primitive\":\"string\"}")]
            public string CommitHash
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_run#repository_branch DevopsBuildRun#repository_branch}.</summary>
            [JsiiProperty(name: "repositoryBranch", typeJson: "{\"primitive\":\"string\"}")]
            public string RepositoryBranch
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_run#repository_url DevopsBuildRun#repository_url}.</summary>
            [JsiiProperty(name: "repositoryUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string RepositoryUrl
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
