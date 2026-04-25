using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiGateway
{
    [JsiiInterface(nativeType: typeof(IAiGatewayStripeUsageEvents), fullyQualifiedName: "cloudflare.aiGateway.AiGatewayStripeUsageEvents")]
    public interface IAiGatewayStripeUsageEvents
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_gateway#payload AiGateway#payload}.</summary>
        [JsiiProperty(name: "payload", typeJson: "{\"primitive\":\"string\"}")]
        string Payload
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAiGatewayStripeUsageEvents), fullyQualifiedName: "cloudflare.aiGateway.AiGatewayStripeUsageEvents")]
        internal sealed class _Proxy : DeputyBase, cloudflare.AiGateway.IAiGatewayStripeUsageEvents
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_gateway#payload AiGateway#payload}.</summary>
            [JsiiProperty(name: "payload", typeJson: "{\"primitive\":\"string\"}")]
            public string Payload
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
