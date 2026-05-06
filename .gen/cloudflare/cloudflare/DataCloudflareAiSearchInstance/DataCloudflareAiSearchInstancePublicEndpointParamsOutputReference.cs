using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareAiSearchInstance
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareAiSearchInstance.DataCloudflareAiSearchInstancePublicEndpointParamsOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareAiSearchInstance.DataCloudflareAiSearchInstancePublicEndpointParamsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareAiSearchInstancePublicEndpointParamsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareAiSearchInstancePublicEndpointParamsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareAiSearchInstancePublicEndpointParamsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareAiSearchInstancePublicEndpointParamsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "authorizedHosts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AuthorizedHosts
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "chatCompletionsEndpoint", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiSearchInstance.DataCloudflareAiSearchInstancePublicEndpointParamsChatCompletionsEndpointOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAiSearchInstance.DataCloudflareAiSearchInstancePublicEndpointParamsChatCompletionsEndpointOutputReference ChatCompletionsEndpoint
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiSearchInstance.DataCloudflareAiSearchInstancePublicEndpointParamsChatCompletionsEndpointOutputReference>()!;
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Enabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "mcp", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiSearchInstance.DataCloudflareAiSearchInstancePublicEndpointParamsMcpOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAiSearchInstance.DataCloudflareAiSearchInstancePublicEndpointParamsMcpOutputReference Mcp
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiSearchInstance.DataCloudflareAiSearchInstancePublicEndpointParamsMcpOutputReference>()!;
        }

        [JsiiProperty(name: "rateLimit", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiSearchInstance.DataCloudflareAiSearchInstancePublicEndpointParamsRateLimitOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAiSearchInstance.DataCloudflareAiSearchInstancePublicEndpointParamsRateLimitOutputReference RateLimit
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiSearchInstance.DataCloudflareAiSearchInstancePublicEndpointParamsRateLimitOutputReference>()!;
        }

        [JsiiProperty(name: "searchEndpoint", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiSearchInstance.DataCloudflareAiSearchInstancePublicEndpointParamsSearchEndpointOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAiSearchInstance.DataCloudflareAiSearchInstancePublicEndpointParamsSearchEndpointOutputReference SearchEndpoint
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiSearchInstance.DataCloudflareAiSearchInstancePublicEndpointParamsSearchEndpointOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiSearchInstance.DataCloudflareAiSearchInstancePublicEndpointParams\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareAiSearchInstance.IDataCloudflareAiSearchInstancePublicEndpointParams? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiSearchInstance.IDataCloudflareAiSearchInstancePublicEndpointParams?>();
            set => SetInstanceProperty(value);
        }
    }
}
