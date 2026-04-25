using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareAiGatewayDynamicRouting
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareAiGatewayDynamicRouting.DataCloudflareAiGatewayDynamicRoutingElementsOutputsOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareAiGatewayDynamicRouting.DataCloudflareAiGatewayDynamicRoutingElementsOutputsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareAiGatewayDynamicRoutingElementsOutputsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareAiGatewayDynamicRoutingElementsOutputsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareAiGatewayDynamicRoutingElementsOutputsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareAiGatewayDynamicRoutingElementsOutputsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "elementId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ElementId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fallback", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiGatewayDynamicRouting.DataCloudflareAiGatewayDynamicRoutingElementsOutputsFallbackOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAiGatewayDynamicRouting.DataCloudflareAiGatewayDynamicRoutingElementsOutputsFallbackOutputReference Fallback
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiGatewayDynamicRouting.DataCloudflareAiGatewayDynamicRoutingElementsOutputsFallbackOutputReference>()!;
        }

        [JsiiProperty(name: "false", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiGatewayDynamicRouting.DataCloudflareAiGatewayDynamicRoutingElementsOutputsFalseOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAiGatewayDynamicRouting.DataCloudflareAiGatewayDynamicRoutingElementsOutputsFalseOutputReference False
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiGatewayDynamicRouting.DataCloudflareAiGatewayDynamicRoutingElementsOutputsFalseOutputReference>()!;
        }

        [JsiiProperty(name: "next", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiGatewayDynamicRouting.DataCloudflareAiGatewayDynamicRoutingElementsOutputsNextOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAiGatewayDynamicRouting.DataCloudflareAiGatewayDynamicRoutingElementsOutputsNextOutputReference Next
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiGatewayDynamicRouting.DataCloudflareAiGatewayDynamicRoutingElementsOutputsNextOutputReference>()!;
        }

        [JsiiProperty(name: "success", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiGatewayDynamicRouting.DataCloudflareAiGatewayDynamicRoutingElementsOutputsSuccessOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAiGatewayDynamicRouting.DataCloudflareAiGatewayDynamicRoutingElementsOutputsSuccessOutputReference Success
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiGatewayDynamicRouting.DataCloudflareAiGatewayDynamicRoutingElementsOutputsSuccessOutputReference>()!;
        }

        [JsiiProperty(name: "true", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiGatewayDynamicRouting.DataCloudflareAiGatewayDynamicRoutingElementsOutputsTrueOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAiGatewayDynamicRouting.DataCloudflareAiGatewayDynamicRoutingElementsOutputsTrueOutputReference True
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiGatewayDynamicRouting.DataCloudflareAiGatewayDynamicRoutingElementsOutputsTrueOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiGatewayDynamicRouting.DataCloudflareAiGatewayDynamicRoutingElementsOutputs\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareAiGatewayDynamicRouting.IDataCloudflareAiGatewayDynamicRoutingElementsOutputs? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiGatewayDynamicRouting.IDataCloudflareAiGatewayDynamicRoutingElementsOutputs?>();
            set => SetInstanceProperty(value);
        }
    }
}
