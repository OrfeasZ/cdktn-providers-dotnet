using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiByValue(fqn: "digitalocean.app.AppSpecStaticSiteGit")]
    public class AppSpecStaticSiteGit : digitalocean.App.IAppSpecStaticSiteGit
    {
        /// <summary>The name of the branch to use.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#branch App#branch}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "branch", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Branch
        {
            get;
            set;
        }

        /// <summary>The clone URL of the repo.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#repo_clone_url App#repo_clone_url}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "repoCloneUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RepoCloneUrl
        {
            get;
            set;
        }
    }
}
