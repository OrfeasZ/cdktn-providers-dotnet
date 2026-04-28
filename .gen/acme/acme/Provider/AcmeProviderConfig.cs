using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace acme.Provider
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "acme.provider.AcmeProviderConfig")]
    public class AcmeProviderConfig : acme.Provider.IAcmeProviderConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.1/docs#server_url AcmeProvider#server_url}.</summary>
        [JsiiProperty(name: "serverUrl", typeJson: "{\"primitive\":\"string\"}")]
        public string ServerUrl
        {
            get;
            set;
        }

        /// <summary>Alias name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/vancluever/acme/2.48.1/docs#alias AcmeProvider#alias}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Alias
        {
            get;
            set;
        }
    }
}
