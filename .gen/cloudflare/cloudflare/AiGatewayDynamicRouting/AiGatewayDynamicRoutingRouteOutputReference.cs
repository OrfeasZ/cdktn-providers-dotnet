using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiGatewayDynamicRouting
{
    [JsiiClass(nativeType: typeof(cloudflare.AiGatewayDynamicRouting.AiGatewayDynamicRoutingRouteOutputReference), fullyQualifiedName: "cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingRouteOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AiGatewayDynamicRoutingRouteOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AiGatewayDynamicRoutingRouteOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AiGatewayDynamicRoutingRouteOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AiGatewayDynamicRoutingRouteOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "accountTag", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountTag
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deployment", typeJson: "{\"fqn\":\"cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingRouteDeploymentOutputReference\"}")]
        public virtual cloudflare.AiGatewayDynamicRouting.AiGatewayDynamicRoutingRouteDeploymentOutputReference Deployment
        {
            get => GetInstanceProperty<cloudflare.AiGatewayDynamicRouting.AiGatewayDynamicRoutingRouteDeploymentOutputReference>()!;
        }

        [JsiiProperty(name: "elements", typeJson: "{\"fqn\":\"cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingRouteElementsList\"}")]
        public virtual cloudflare.AiGatewayDynamicRouting.AiGatewayDynamicRoutingRouteElementsList Elements
        {
            get => GetInstanceProperty<cloudflare.AiGatewayDynamicRouting.AiGatewayDynamicRoutingRouteElementsList>()!;
        }

        [JsiiProperty(name: "gatewayId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GatewayId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "modifiedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModifiedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"fqn\":\"cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingRouteVersionOutputReference\"}")]
        public virtual cloudflare.AiGatewayDynamicRouting.AiGatewayDynamicRoutingRouteVersionOutputReference Version
        {
            get => GetInstanceProperty<cloudflare.AiGatewayDynamicRouting.AiGatewayDynamicRoutingRouteVersionOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.aiGatewayDynamicRouting.AiGatewayDynamicRoutingRoute\"}", isOptional: true)]
        public virtual cloudflare.AiGatewayDynamicRouting.IAiGatewayDynamicRoutingRoute? InternalValue
        {
            get => GetInstanceProperty<cloudflare.AiGatewayDynamicRouting.IAiGatewayDynamicRoutingRoute?>();
            set => SetInstanceProperty(value);
        }
    }
}
