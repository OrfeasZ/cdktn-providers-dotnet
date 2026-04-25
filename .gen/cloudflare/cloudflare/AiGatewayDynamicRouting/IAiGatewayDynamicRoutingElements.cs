using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiGatewayDynamicRouting
{
    [JsiiInterface(nativeType: typeof(IAiGatewayDynamicRoutingElements), fullyQualifiedName: "cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingElements")]
    public interface IAiGatewayDynamicRoutingElements
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_gateway_dynamic_routing#id AiGatewayDynamicRouting#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        string Id
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_gateway_dynamic_routing#outputs AiGatewayDynamicRouting#outputs}.</summary>
        [JsiiProperty(name: "outputs", typeJson: "{\"fqn\":\"cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputs\"}")]
        cloudflare.AiGatewayDynamicRouting.IAiGatewayDynamicRoutingElementsOutputs Outputs
        {
            get;
        }

        /// <summary>Available values: "start", "conditional", "percentage", "rate", "model", "end".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_gateway_dynamic_routing#type AiGatewayDynamicRouting#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_gateway_dynamic_routing#properties AiGatewayDynamicRouting#properties}.</summary>
        [JsiiProperty(name: "properties", typeJson: "{\"fqn\":\"cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsProperties\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.AiGatewayDynamicRouting.IAiGatewayDynamicRoutingElementsProperties? Properties
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAiGatewayDynamicRoutingElements), fullyQualifiedName: "cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingElements")]
        internal sealed class _Proxy : DeputyBase, cloudflare.AiGatewayDynamicRouting.IAiGatewayDynamicRoutingElements
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_gateway_dynamic_routing#id AiGatewayDynamicRouting#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
            public string Id
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_gateway_dynamic_routing#outputs AiGatewayDynamicRouting#outputs}.</summary>
            [JsiiProperty(name: "outputs", typeJson: "{\"fqn\":\"cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputs\"}")]
            public cloudflare.AiGatewayDynamicRouting.IAiGatewayDynamicRoutingElementsOutputs Outputs
            {
                get => GetInstanceProperty<cloudflare.AiGatewayDynamicRouting.IAiGatewayDynamicRoutingElementsOutputs>()!;
            }

            /// <summary>Available values: "start", "conditional", "percentage", "rate", "model", "end".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_gateway_dynamic_routing#type AiGatewayDynamicRouting#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_gateway_dynamic_routing#properties AiGatewayDynamicRouting#properties}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "properties", typeJson: "{\"fqn\":\"cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsProperties\"}", isOptional: true)]
            public cloudflare.AiGatewayDynamicRouting.IAiGatewayDynamicRoutingElementsProperties? Properties
            {
                get => GetInstanceProperty<cloudflare.AiGatewayDynamicRouting.IAiGatewayDynamicRoutingElementsProperties?>();
            }
        }
    }
}
