using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanGradientaiAgent
{
    [JsiiByValue(fqn: "digitalocean.dataDigitaloceanGradientaiAgent.DataDigitaloceanGradientaiAgentModelVersions")]
    public class DataDigitaloceanGradientaiAgentModelVersions : digitalocean.DataDigitaloceanGradientaiAgent.IDataDigitaloceanGradientaiAgentModelVersions
    {
        /// <summary>Major version of the model.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/gradientai_agent#major DataDigitaloceanGradientaiAgent#major}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/gradientai_agent#minor DataDigitaloceanGradientaiAgent#minor}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/data-sources/gradientai_agent#patch DataDigitaloceanGradientaiAgent#patch}
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
