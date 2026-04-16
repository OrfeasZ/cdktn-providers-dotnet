using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.GradientaiOpenaiApiKey
{
    [JsiiByValue(fqn: "digitalocean.gradientaiOpenaiApiKey.GradientaiOpenaiApiKeyModelVersions")]
    public class GradientaiOpenaiApiKeyModelVersions : digitalocean.GradientaiOpenaiApiKey.IGradientaiOpenaiApiKeyModelVersions
    {
        /// <summary>Major version of the model.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_openai_api_key#major GradientaiOpenaiApiKey#major}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_openai_api_key#minor GradientaiOpenaiApiKey#minor}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_openai_api_key#patch GradientaiOpenaiApiKey#patch}
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
