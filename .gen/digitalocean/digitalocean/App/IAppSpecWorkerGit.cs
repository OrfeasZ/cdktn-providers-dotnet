using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiInterface(nativeType: typeof(IAppSpecWorkerGit), fullyQualifiedName: "digitalocean.app.AppSpecWorkerGit")]
    public interface IAppSpecWorkerGit
    {
        /// <summary>The name of the branch to use.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#branch App#branch}
        /// </remarks>
        [JsiiProperty(name: "branch", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Branch
        {
            get
            {
                return null;
            }
        }

        /// <summary>The clone URL of the repo.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#repo_clone_url App#repo_clone_url}
        /// </remarks>
        [JsiiProperty(name: "repoCloneUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RepoCloneUrl
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppSpecWorkerGit), fullyQualifiedName: "digitalocean.app.AppSpecWorkerGit")]
        internal sealed class _Proxy : DeputyBase, digitalocean.App.IAppSpecWorkerGit
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The name of the branch to use.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#branch App#branch}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "branch", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Branch
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The clone URL of the repo.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#repo_clone_url App#repo_clone_url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "repoCloneUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RepoCloneUrl
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
