using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiGateway
{
    [JsiiInterface(nativeType: typeof(IAiGatewaySpendLimitsRulesModel), fullyQualifiedName: "cloudflare.aiGateway.AiGatewaySpendLimitsRulesModel")]
    public interface IAiGatewaySpendLimitsRulesModel
    {
        /// <summary>Available values: "filter".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/ai_gateway#mode AiGateway#mode}
        /// </remarks>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        string Mode
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/ai_gateway#values AiGateway#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAiGatewaySpendLimitsRulesModel), fullyQualifiedName: "cloudflare.aiGateway.AiGatewaySpendLimitsRulesModel")]
        internal sealed class _Proxy : DeputyBase, cloudflare.AiGateway.IAiGatewaySpendLimitsRulesModel
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Available values: "filter".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/ai_gateway#mode AiGateway#mode}
            /// </remarks>
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
            public string Mode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/ai_gateway#values AiGateway#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
