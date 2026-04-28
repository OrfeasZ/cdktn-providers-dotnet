using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiInterface(nativeType: typeof(IAppSpecServiceGitlab), fullyQualifiedName: "digitalocean.app.AppSpecServiceGitlab")]
    public interface IAppSpecServiceGitlab
    {
        /// <summary>The name of the branch to use.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#branch App#branch}
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

        /// <summary>Whether to automatically deploy new commits made to the repo.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#deploy_on_push App#deploy_on_push}
        /// </remarks>
        [JsiiProperty(name: "deployOnPush", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DeployOnPush
        {
            get
            {
                return null;
            }
        }

        /// <summary>The name of the repo in the format `owner/repo`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#repo App#repo}
        /// </remarks>
        [JsiiProperty(name: "repo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Repo
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppSpecServiceGitlab), fullyQualifiedName: "digitalocean.app.AppSpecServiceGitlab")]
        internal sealed class _Proxy : DeputyBase, digitalocean.App.IAppSpecServiceGitlab
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The name of the branch to use.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#branch App#branch}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "branch", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Branch
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Whether to automatically deploy new commits made to the repo.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#deploy_on_push App#deploy_on_push}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deployOnPush", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DeployOnPush
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The name of the repo in the format `owner/repo`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#repo App#repo}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "repo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Repo
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
