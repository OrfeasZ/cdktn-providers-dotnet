using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiGatewayDynamicRouting
{
    [JsiiByValue(fqn: "cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputs")]
    public class AiGatewayDynamicRoutingElementsOutputs : cloudflare.AiGatewayDynamicRouting.IAiGatewayDynamicRoutingElementsOutputs
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_gateway_dynamic_routing#element_id AiGatewayDynamicRouting#element_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "elementId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ElementId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_gateway_dynamic_routing#fallback AiGatewayDynamicRouting#fallback}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fallback", typeJson: "{\"fqn\":\"cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputsFallback\"}", isOptional: true)]
        public cloudflare.AiGatewayDynamicRouting.IAiGatewayDynamicRoutingElementsOutputsFallback? Fallback
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_gateway_dynamic_routing#false AiGatewayDynamicRouting#false}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "false", typeJson: "{\"fqn\":\"cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputsFalse\"}", isOptional: true)]
        public cloudflare.AiGatewayDynamicRouting.IAiGatewayDynamicRoutingElementsOutputsFalse? False
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_gateway_dynamic_routing#next AiGatewayDynamicRouting#next}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "next", typeJson: "{\"fqn\":\"cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputsNext\"}", isOptional: true)]
        public cloudflare.AiGatewayDynamicRouting.IAiGatewayDynamicRoutingElementsOutputsNext? Next
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_gateway_dynamic_routing#success AiGatewayDynamicRouting#success}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "success", typeJson: "{\"fqn\":\"cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputsSuccess\"}", isOptional: true)]
        public cloudflare.AiGatewayDynamicRouting.IAiGatewayDynamicRoutingElementsOutputsSuccess? Success
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_gateway_dynamic_routing#true AiGatewayDynamicRouting#true}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "true", typeJson: "{\"fqn\":\"cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputsTrue\"}", isOptional: true)]
        public cloudflare.AiGatewayDynamicRouting.IAiGatewayDynamicRoutingElementsOutputsTrue? True
        {
            get;
            set;
        }
    }
}
