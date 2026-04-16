using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace neon.Provider
{
    [JsiiByValue(fqn: "neon.provider.NeonProviderConfig")]
    public class NeonProviderConfig : neon.Provider.INeonProviderConfig
    {
        /// <summary>Alias name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs#alias NeonProvider#alias}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Alias
        {
            get;
            set;
        }

        /// <summary>API access key. Default is read from the environment variable `NEON_API_KEY`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs#api_key NeonProvider#api_key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "apiKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ApiKey
        {
            get;
            set;
        }
    }
}
