using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiByValue(fqn: "digitalocean.app.AppSpecIngressRuleMatchAuthority")]
    public class AppSpecIngressRuleMatchAuthority : digitalocean.App.IAppSpecIngressRuleMatchAuthority
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#exact App#exact}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "exact", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Exact
        {
            get;
            set;
        }
    }
}
