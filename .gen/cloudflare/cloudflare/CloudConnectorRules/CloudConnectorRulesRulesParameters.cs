using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.CloudConnectorRules
{
    [JsiiByValue(fqn: "cloudflare.cloudConnectorRules.CloudConnectorRulesRulesParameters")]
    public class CloudConnectorRulesRulesParameters : cloudflare.CloudConnectorRules.ICloudConnectorRulesRulesParameters
    {
        /// <summary>Host to perform Cloud Connection to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/cloud_connector_rules#host CloudConnectorRules#host}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Host
        {
            get;
            set;
        }
    }
}
