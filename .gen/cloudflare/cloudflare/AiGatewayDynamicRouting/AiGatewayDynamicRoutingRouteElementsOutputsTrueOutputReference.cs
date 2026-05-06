using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiGatewayDynamicRouting
{
    [JsiiClass(nativeType: typeof(cloudflare.AiGatewayDynamicRouting.AiGatewayDynamicRoutingRouteElementsOutputsTrueOutputReference), fullyQualifiedName: "cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingRouteElementsOutputsTrueOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AiGatewayDynamicRoutingRouteElementsOutputsTrueOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AiGatewayDynamicRoutingRouteElementsOutputsTrueOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AiGatewayDynamicRoutingRouteElementsOutputsTrueOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AiGatewayDynamicRoutingRouteElementsOutputsTrueOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "elementId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ElementId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingRouteElementsOutputsTrue\"}", isOptional: true)]
        public virtual cloudflare.AiGatewayDynamicRouting.IAiGatewayDynamicRoutingRouteElementsOutputsTrue? InternalValue
        {
            get => GetInstanceProperty<cloudflare.AiGatewayDynamicRouting.IAiGatewayDynamicRoutingRouteElementsOutputsTrue?>();
            set => SetInstanceProperty(value);
        }
    }
}
