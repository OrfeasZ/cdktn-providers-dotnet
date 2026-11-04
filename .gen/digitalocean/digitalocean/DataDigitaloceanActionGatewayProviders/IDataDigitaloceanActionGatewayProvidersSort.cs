using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanActionGatewayProviders
{
    [JsiiInterface(nativeType: typeof(IDataDigitaloceanActionGatewayProvidersSort), fullyQualifiedName: "digitalocean.dataDigitaloceanActionGatewayProviders.DataDigitaloceanActionGatewayProvidersSort")]
    public interface IDataDigitaloceanActionGatewayProvidersSort
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/data-sources/action_gateway_providers#key DataDigitaloceanActionGatewayProviders#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/data-sources/action_gateway_providers#direction DataDigitaloceanActionGatewayProviders#direction}.</summary>
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Direction
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataDigitaloceanActionGatewayProvidersSort), fullyQualifiedName: "digitalocean.dataDigitaloceanActionGatewayProviders.DataDigitaloceanActionGatewayProvidersSort")]
        internal sealed class _Proxy : DeputyBase, digitalocean.DataDigitaloceanActionGatewayProviders.IDataDigitaloceanActionGatewayProvidersSort
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/data-sources/action_gateway_providers#key DataDigitaloceanActionGatewayProviders#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/data-sources/action_gateway_providers#direction DataDigitaloceanActionGatewayProviders#direction}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Direction
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
