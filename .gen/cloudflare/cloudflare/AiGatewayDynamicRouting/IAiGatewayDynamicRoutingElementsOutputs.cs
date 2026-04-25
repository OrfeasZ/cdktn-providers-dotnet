using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiGatewayDynamicRouting
{
    [JsiiInterface(nativeType: typeof(IAiGatewayDynamicRoutingElementsOutputs), fullyQualifiedName: "cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputs")]
    public interface IAiGatewayDynamicRoutingElementsOutputs
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_gateway_dynamic_routing#element_id AiGatewayDynamicRouting#element_id}.</summary>
        [JsiiProperty(name: "elementId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ElementId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_gateway_dynamic_routing#fallback AiGatewayDynamicRouting#fallback}.</summary>
        [JsiiProperty(name: "fallback", typeJson: "{\"fqn\":\"cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputsFallback\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.AiGatewayDynamicRouting.IAiGatewayDynamicRoutingElementsOutputsFallback? Fallback
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_gateway_dynamic_routing#false AiGatewayDynamicRouting#false}.</summary>
        [JsiiProperty(name: "false", typeJson: "{\"fqn\":\"cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputsFalse\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.AiGatewayDynamicRouting.IAiGatewayDynamicRoutingElementsOutputsFalse? False
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_gateway_dynamic_routing#next AiGatewayDynamicRouting#next}.</summary>
        [JsiiProperty(name: "next", typeJson: "{\"fqn\":\"cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputsNext\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.AiGatewayDynamicRouting.IAiGatewayDynamicRoutingElementsOutputsNext? Next
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_gateway_dynamic_routing#success AiGatewayDynamicRouting#success}.</summary>
        [JsiiProperty(name: "success", typeJson: "{\"fqn\":\"cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputsSuccess\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.AiGatewayDynamicRouting.IAiGatewayDynamicRoutingElementsOutputsSuccess? Success
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_gateway_dynamic_routing#true AiGatewayDynamicRouting#true}.</summary>
        [JsiiProperty(name: "true", typeJson: "{\"fqn\":\"cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputsTrue\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.AiGatewayDynamicRouting.IAiGatewayDynamicRoutingElementsOutputsTrue? True
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAiGatewayDynamicRoutingElementsOutputs), fullyQualifiedName: "cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputs")]
        internal sealed class _Proxy : DeputyBase, cloudflare.AiGatewayDynamicRouting.IAiGatewayDynamicRoutingElementsOutputs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_gateway_dynamic_routing#element_id AiGatewayDynamicRouting#element_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "elementId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ElementId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_gateway_dynamic_routing#fallback AiGatewayDynamicRouting#fallback}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fallback", typeJson: "{\"fqn\":\"cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputsFallback\"}", isOptional: true)]
            public cloudflare.AiGatewayDynamicRouting.IAiGatewayDynamicRoutingElementsOutputsFallback? Fallback
            {
                get => GetInstanceProperty<cloudflare.AiGatewayDynamicRouting.IAiGatewayDynamicRoutingElementsOutputsFallback?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_gateway_dynamic_routing#false AiGatewayDynamicRouting#false}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "false", typeJson: "{\"fqn\":\"cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputsFalse\"}", isOptional: true)]
            public cloudflare.AiGatewayDynamicRouting.IAiGatewayDynamicRoutingElementsOutputsFalse? False
            {
                get => GetInstanceProperty<cloudflare.AiGatewayDynamicRouting.IAiGatewayDynamicRoutingElementsOutputsFalse?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_gateway_dynamic_routing#next AiGatewayDynamicRouting#next}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "next", typeJson: "{\"fqn\":\"cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputsNext\"}", isOptional: true)]
            public cloudflare.AiGatewayDynamicRouting.IAiGatewayDynamicRoutingElementsOutputsNext? Next
            {
                get => GetInstanceProperty<cloudflare.AiGatewayDynamicRouting.IAiGatewayDynamicRoutingElementsOutputsNext?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_gateway_dynamic_routing#success AiGatewayDynamicRouting#success}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "success", typeJson: "{\"fqn\":\"cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputsSuccess\"}", isOptional: true)]
            public cloudflare.AiGatewayDynamicRouting.IAiGatewayDynamicRoutingElementsOutputsSuccess? Success
            {
                get => GetInstanceProperty<cloudflare.AiGatewayDynamicRouting.IAiGatewayDynamicRoutingElementsOutputsSuccess?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_gateway_dynamic_routing#true AiGatewayDynamicRouting#true}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "true", typeJson: "{\"fqn\":\"cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputsTrue\"}", isOptional: true)]
            public cloudflare.AiGatewayDynamicRouting.IAiGatewayDynamicRoutingElementsOutputsTrue? True
            {
                get => GetInstanceProperty<cloudflare.AiGatewayDynamicRouting.IAiGatewayDynamicRoutingElementsOutputsTrue?>();
            }
        }
    }
}
