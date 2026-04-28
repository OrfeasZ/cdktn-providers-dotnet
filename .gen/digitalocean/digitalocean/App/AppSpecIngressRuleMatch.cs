using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiByValue(fqn: "digitalocean.app.AppSpecIngressRuleMatch")]
    public class AppSpecIngressRuleMatch : digitalocean.App.IAppSpecIngressRuleMatch
    {
        /// <summary>authority block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#authority App#authority}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "authority", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecIngressRuleMatchAuthority\"}", isOptional: true)]
        public digitalocean.App.IAppSpecIngressRuleMatchAuthority? Authority
        {
            get;
            set;
        }

        /// <summary>path block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#path App#path}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "path", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecIngressRuleMatchPath\"}", isOptional: true)]
        public digitalocean.App.IAppSpecIngressRuleMatchPath? Path
        {
            get;
            set;
        }
    }
}
