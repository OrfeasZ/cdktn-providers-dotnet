using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.GradientaiAgent
{
    [JsiiByValue(fqn: "digitalocean.gradientaiAgent.GradientaiAgentTemplateModelVersions")]
    public class GradientaiAgentTemplateModelVersions : digitalocean.GradientaiAgent.IGradientaiAgentTemplateModelVersions
    {
        /// <summary>Major version of the model.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#major GradientaiAgent#major}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "major", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Major
        {
            get;
            set;
        }

        /// <summary>Minor version of the model.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#minor GradientaiAgent#minor}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "minor", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Minor
        {
            get;
            set;
        }

        /// <summary>Patch version of the model.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#patch GradientaiAgent#patch}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "patch", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Patch
        {
            get;
            set;
        }
    }
}
