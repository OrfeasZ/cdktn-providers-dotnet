using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiByValue(fqn: "digitalocean.app.AppSpecIngressRule")]
    public class AppSpecIngressRule : digitalocean.App.IAppSpecIngressRule
    {
        /// <summary>component block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#component App#component}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "component", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecIngressRuleComponent\"}", isOptional: true)]
        public digitalocean.App.IAppSpecIngressRuleComponent? Component
        {
            get;
            set;
        }

        /// <summary>cors block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#cors App#cors}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cors", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecIngressRuleCors\"}", isOptional: true)]
        public digitalocean.App.IAppSpecIngressRuleCors? Cors
        {
            get;
            set;
        }

        /// <summary>match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#match App#match}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecIngressRuleMatch\"}", isOptional: true)]
        public digitalocean.App.IAppSpecIngressRuleMatch? Match
        {
            get;
            set;
        }

        /// <summary>redirect block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/app#redirect App#redirect}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "redirect", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecIngressRuleRedirect\"}", isOptional: true)]
        public digitalocean.App.IAppSpecIngressRuleRedirect? Redirect
        {
            get;
            set;
        }
    }
}
