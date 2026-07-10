using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiGateway
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.aiGateway.AiGatewayGuardrails")]
    public class AiGatewayGuardrails : cloudflare.AiGateway.IAiGatewayGuardrails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/ai_gateway#prompt AiGateway#prompt}.</summary>
        [JsiiProperty(name: "prompt", typeJson: "{\"fqn\":\"cloudflare.aiGateway.AiGatewayGuardrailsPrompt\"}")]
        public cloudflare.AiGateway.IAiGatewayGuardrailsPrompt Prompt
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/ai_gateway#response AiGateway#response}.</summary>
        [JsiiProperty(name: "response", typeJson: "{\"fqn\":\"cloudflare.aiGateway.AiGatewayGuardrailsResponse\"}")]
        public cloudflare.AiGateway.IAiGatewayGuardrailsResponse Response
        {
            get;
            set;
        }
    }
}
