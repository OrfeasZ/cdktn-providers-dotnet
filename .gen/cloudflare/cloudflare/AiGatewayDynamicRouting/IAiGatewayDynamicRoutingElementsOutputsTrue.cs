using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiGatewayDynamicRouting
{
    [JsiiInterface(nativeType: typeof(IAiGatewayDynamicRoutingElementsOutputsTrue), fullyQualifiedName: "cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputsTrue")]
    public interface IAiGatewayDynamicRoutingElementsOutputsTrue
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_gateway_dynamic_routing#element_id AiGatewayDynamicRouting#element_id}.</summary>
        [JsiiProperty(name: "elementId", typeJson: "{\"primitive\":\"string\"}")]
        string ElementId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAiGatewayDynamicRoutingElementsOutputsTrue), fullyQualifiedName: "cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingElementsOutputsTrue")]
        internal sealed class _Proxy : DeputyBase, cloudflare.AiGatewayDynamicRouting.IAiGatewayDynamicRoutingElementsOutputsTrue
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ai_gateway_dynamic_routing#element_id AiGatewayDynamicRouting#element_id}.</summary>
            [JsiiProperty(name: "elementId", typeJson: "{\"primitive\":\"string\"}")]
            public string ElementId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
