using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanActionGatewayProviders
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "digitalocean.dataDigitaloceanActionGatewayProviders.DataDigitaloceanActionGatewayProvidersSort")]
    public class DataDigitaloceanActionGatewayProvidersSort : digitalocean.DataDigitaloceanActionGatewayProviders.IDataDigitaloceanActionGatewayProvidersSort
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/data-sources/action_gateway_providers#key DataDigitaloceanActionGatewayProviders#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/data-sources/action_gateway_providers#direction DataDigitaloceanActionGatewayProviders#direction}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Direction
        {
            get;
            set;
        }
    }
}
