using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareAiGatewayDynamicRouting
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareAiGatewayDynamicRouting.DataCloudflareAiGatewayDynamicRoutingElementsPropertiesOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareAiGatewayDynamicRouting.DataCloudflareAiGatewayDynamicRoutingElementsPropertiesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareAiGatewayDynamicRoutingElementsPropertiesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareAiGatewayDynamicRoutingElementsPropertiesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareAiGatewayDynamicRoutingElementsPropertiesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareAiGatewayDynamicRoutingElementsPropertiesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "aiGatewayDynamicRoutingProvider", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AiGatewayDynamicRoutingProvider
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "conditions", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Conditions
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Key
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Limit
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "limitType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LimitType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "model", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Model
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "retries", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Retries
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Timeout
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "window", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Window
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiGatewayDynamicRouting.DataCloudflareAiGatewayDynamicRoutingElementsProperties\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareAiGatewayDynamicRouting.IDataCloudflareAiGatewayDynamicRoutingElementsProperties? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiGatewayDynamicRouting.IDataCloudflareAiGatewayDynamicRoutingElementsProperties?>();
            set => SetInstanceProperty(value);
        }
    }
}
