using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareAiSearchInstances
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareAiSearchInstances.DataCloudflareAiSearchInstancesResultPublicEndpointParamsOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareAiSearchInstances.DataCloudflareAiSearchInstancesResultPublicEndpointParamsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareAiSearchInstancesResultPublicEndpointParamsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareAiSearchInstancesResultPublicEndpointParamsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareAiSearchInstancesResultPublicEndpointParamsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareAiSearchInstancesResultPublicEndpointParamsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "authorizedHosts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AuthorizedHosts
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "chatCompletionsEndpoint", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiSearchInstances.DataCloudflareAiSearchInstancesResultPublicEndpointParamsChatCompletionsEndpointOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAiSearchInstances.DataCloudflareAiSearchInstancesResultPublicEndpointParamsChatCompletionsEndpointOutputReference ChatCompletionsEndpoint
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiSearchInstances.DataCloudflareAiSearchInstancesResultPublicEndpointParamsChatCompletionsEndpointOutputReference>()!;
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Enabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "mcp", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiSearchInstances.DataCloudflareAiSearchInstancesResultPublicEndpointParamsMcpOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAiSearchInstances.DataCloudflareAiSearchInstancesResultPublicEndpointParamsMcpOutputReference Mcp
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiSearchInstances.DataCloudflareAiSearchInstancesResultPublicEndpointParamsMcpOutputReference>()!;
        }

        [JsiiProperty(name: "rateLimit", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiSearchInstances.DataCloudflareAiSearchInstancesResultPublicEndpointParamsRateLimitOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAiSearchInstances.DataCloudflareAiSearchInstancesResultPublicEndpointParamsRateLimitOutputReference RateLimit
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiSearchInstances.DataCloudflareAiSearchInstancesResultPublicEndpointParamsRateLimitOutputReference>()!;
        }

        [JsiiProperty(name: "searchEndpoint", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiSearchInstances.DataCloudflareAiSearchInstancesResultPublicEndpointParamsSearchEndpointOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAiSearchInstances.DataCloudflareAiSearchInstancesResultPublicEndpointParamsSearchEndpointOutputReference SearchEndpoint
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiSearchInstances.DataCloudflareAiSearchInstancesResultPublicEndpointParamsSearchEndpointOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiSearchInstances.DataCloudflareAiSearchInstancesResultPublicEndpointParams\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareAiSearchInstances.IDataCloudflareAiSearchInstancesResultPublicEndpointParams? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiSearchInstances.IDataCloudflareAiSearchInstancesResultPublicEndpointParams?>();
            set => SetInstanceProperty(value);
        }
    }
}
