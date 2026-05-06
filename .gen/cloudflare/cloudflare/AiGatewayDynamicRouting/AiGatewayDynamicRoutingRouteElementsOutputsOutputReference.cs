using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiGatewayDynamicRouting
{
    [JsiiClass(nativeType: typeof(cloudflare.AiGatewayDynamicRouting.AiGatewayDynamicRoutingRouteElementsOutputsOutputReference), fullyQualifiedName: "cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingRouteElementsOutputsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AiGatewayDynamicRoutingRouteElementsOutputsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AiGatewayDynamicRoutingRouteElementsOutputsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AiGatewayDynamicRoutingRouteElementsOutputsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AiGatewayDynamicRoutingRouteElementsOutputsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "elementId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ElementId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fallback", typeJson: "{\"fqn\":\"cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingRouteElementsOutputsFallbackOutputReference\"}")]
        public virtual cloudflare.AiGatewayDynamicRouting.AiGatewayDynamicRoutingRouteElementsOutputsFallbackOutputReference Fallback
        {
            get => GetInstanceProperty<cloudflare.AiGatewayDynamicRouting.AiGatewayDynamicRoutingRouteElementsOutputsFallbackOutputReference>()!;
        }

        [JsiiProperty(name: "false", typeJson: "{\"fqn\":\"cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingRouteElementsOutputsFalseOutputReference\"}")]
        public virtual cloudflare.AiGatewayDynamicRouting.AiGatewayDynamicRoutingRouteElementsOutputsFalseOutputReference False
        {
            get => GetInstanceProperty<cloudflare.AiGatewayDynamicRouting.AiGatewayDynamicRoutingRouteElementsOutputsFalseOutputReference>()!;
        }

        [JsiiProperty(name: "next", typeJson: "{\"fqn\":\"cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingRouteElementsOutputsNextOutputReference\"}")]
        public virtual cloudflare.AiGatewayDynamicRouting.AiGatewayDynamicRoutingRouteElementsOutputsNextOutputReference Next
        {
            get => GetInstanceProperty<cloudflare.AiGatewayDynamicRouting.AiGatewayDynamicRoutingRouteElementsOutputsNextOutputReference>()!;
        }

        [JsiiProperty(name: "success", typeJson: "{\"fqn\":\"cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingRouteElementsOutputsSuccessOutputReference\"}")]
        public virtual cloudflare.AiGatewayDynamicRouting.AiGatewayDynamicRoutingRouteElementsOutputsSuccessOutputReference Success
        {
            get => GetInstanceProperty<cloudflare.AiGatewayDynamicRouting.AiGatewayDynamicRoutingRouteElementsOutputsSuccessOutputReference>()!;
        }

        [JsiiProperty(name: "true", typeJson: "{\"fqn\":\"cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingRouteElementsOutputsTrueOutputReference\"}")]
        public virtual cloudflare.AiGatewayDynamicRouting.AiGatewayDynamicRoutingRouteElementsOutputsTrueOutputReference True
        {
            get => GetInstanceProperty<cloudflare.AiGatewayDynamicRouting.AiGatewayDynamicRoutingRouteElementsOutputsTrueOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingRouteElementsOutputs\"}", isOptional: true)]
        public virtual cloudflare.AiGatewayDynamicRouting.IAiGatewayDynamicRoutingRouteElementsOutputs? InternalValue
        {
            get => GetInstanceProperty<cloudflare.AiGatewayDynamicRouting.IAiGatewayDynamicRoutingRouteElementsOutputs?>();
            set => SetInstanceProperty(value);
        }
    }
}
