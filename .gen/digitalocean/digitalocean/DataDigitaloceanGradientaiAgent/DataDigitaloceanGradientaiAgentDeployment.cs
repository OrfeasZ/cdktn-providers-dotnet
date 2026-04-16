using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanGradientaiAgent
{
    [JsiiByValue(fqn: "digitalocean.dataDigitaloceanGradientaiAgent.DataDigitaloceanGradientaiAgentDeployment")]
    public class DataDigitaloceanGradientaiAgentDeployment : digitalocean.DataDigitaloceanGradientaiAgent.IDataDigitaloceanGradientaiAgentDeployment
    {
        /// <summary>Name of the API Key.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#name DataDigitaloceanGradientaiAgent#name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Status of the Deployment.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#status DataDigitaloceanGradientaiAgent#status}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Status
        {
            get;
            set;
        }

        /// <summary>Url of the Deployment.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#url DataDigitaloceanGradientaiAgent#url}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Url
        {
            get;
            set;
        }

        /// <summary>API Key value.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#uuid DataDigitaloceanGradientaiAgent#uuid}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "uuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Uuid
        {
            get;
            set;
        }

        /// <summary>Visibility of the Deployment.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_agent#visibility DataDigitaloceanGradientaiAgent#visibility}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "visibility", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Visibility
        {
            get;
            set;
        }
    }
}
