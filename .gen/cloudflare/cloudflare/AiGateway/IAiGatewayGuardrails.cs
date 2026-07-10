using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiGateway
{
    [JsiiInterface(nativeType: typeof(IAiGatewayGuardrails), fullyQualifiedName: "cloudflare.aiGateway.AiGatewayGuardrails")]
    public interface IAiGatewayGuardrails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/ai_gateway#prompt AiGateway#prompt}.</summary>
        [JsiiProperty(name: "prompt", typeJson: "{\"fqn\":\"cloudflare.aiGateway.AiGatewayGuardrailsPrompt\"}")]
        cloudflare.AiGateway.IAiGatewayGuardrailsPrompt Prompt
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/ai_gateway#response AiGateway#response}.</summary>
        [JsiiProperty(name: "response", typeJson: "{\"fqn\":\"cloudflare.aiGateway.AiGatewayGuardrailsResponse\"}")]
        cloudflare.AiGateway.IAiGatewayGuardrailsResponse Response
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAiGatewayGuardrails), fullyQualifiedName: "cloudflare.aiGateway.AiGatewayGuardrails")]
        internal sealed class _Proxy : DeputyBase, cloudflare.AiGateway.IAiGatewayGuardrails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/ai_gateway#prompt AiGateway#prompt}.</summary>
            [JsiiProperty(name: "prompt", typeJson: "{\"fqn\":\"cloudflare.aiGateway.AiGatewayGuardrailsPrompt\"}")]
            public cloudflare.AiGateway.IAiGatewayGuardrailsPrompt Prompt
            {
                get => GetInstanceProperty<cloudflare.AiGateway.IAiGatewayGuardrailsPrompt>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/ai_gateway#response AiGateway#response}.</summary>
            [JsiiProperty(name: "response", typeJson: "{\"fqn\":\"cloudflare.aiGateway.AiGatewayGuardrailsResponse\"}")]
            public cloudflare.AiGateway.IAiGatewayGuardrailsResponse Response
            {
                get => GetInstanceProperty<cloudflare.AiGateway.IAiGatewayGuardrailsResponse>()!;
            }
        }
    }
}
