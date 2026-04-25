using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiGateway
{
    [JsiiInterface(nativeType: typeof(IAiGatewayStripe), fullyQualifiedName: "cloudflare.aiGateway.AiGatewayStripe")]
    public interface IAiGatewayStripe
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_gateway#authorization AiGateway#authorization}.</summary>
        [JsiiProperty(name: "authorization", typeJson: "{\"primitive\":\"string\"}")]
        string Authorization
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_gateway#usage_events AiGateway#usage_events}.</summary>
        [JsiiProperty(name: "usageEvents", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.aiGateway.AiGatewayStripeUsageEvents\"},\"kind\":\"array\"}}]}}")]
        object UsageEvents
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAiGatewayStripe), fullyQualifiedName: "cloudflare.aiGateway.AiGatewayStripe")]
        internal sealed class _Proxy : DeputyBase, cloudflare.AiGateway.IAiGatewayStripe
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_gateway#authorization AiGateway#authorization}.</summary>
            [JsiiProperty(name: "authorization", typeJson: "{\"primitive\":\"string\"}")]
            public string Authorization
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_gateway#usage_events AiGateway#usage_events}.</summary>
            [JsiiProperty(name: "usageEvents", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.aiGateway.AiGatewayStripeUsageEvents\"},\"kind\":\"array\"}}]}}")]
            public object UsageEvents
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
