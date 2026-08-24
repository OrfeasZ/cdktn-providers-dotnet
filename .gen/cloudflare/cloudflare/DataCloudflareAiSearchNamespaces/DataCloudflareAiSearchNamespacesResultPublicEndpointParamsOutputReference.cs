using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareAiSearchNamespaces
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareAiSearchNamespaces.DataCloudflareAiSearchNamespacesResultPublicEndpointParamsOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareAiSearchNamespaces.DataCloudflareAiSearchNamespacesResultPublicEndpointParamsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareAiSearchNamespacesResultPublicEndpointParamsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareAiSearchNamespacesResultPublicEndpointParamsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareAiSearchNamespacesResultPublicEndpointParamsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareAiSearchNamespacesResultPublicEndpointParamsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "authorizedHosts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AuthorizedHosts
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "chatCompletionsEndpoint", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiSearchNamespaces.DataCloudflareAiSearchNamespacesResultPublicEndpointParamsChatCompletionsEndpointOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAiSearchNamespaces.DataCloudflareAiSearchNamespacesResultPublicEndpointParamsChatCompletionsEndpointOutputReference ChatCompletionsEndpoint
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiSearchNamespaces.DataCloudflareAiSearchNamespacesResultPublicEndpointParamsChatCompletionsEndpointOutputReference>()!;
        }

        [JsiiProperty(name: "customDomains", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] CustomDomains
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "defaultDomainEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable DefaultDomainEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Enabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "instancesAllowed", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] InstancesAllowed
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "mcp", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiSearchNamespaces.DataCloudflareAiSearchNamespacesResultPublicEndpointParamsMcpOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAiSearchNamespaces.DataCloudflareAiSearchNamespacesResultPublicEndpointParamsMcpOutputReference Mcp
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiSearchNamespaces.DataCloudflareAiSearchNamespacesResultPublicEndpointParamsMcpOutputReference>()!;
        }

        [JsiiProperty(name: "rateLimit", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiSearchNamespaces.DataCloudflareAiSearchNamespacesResultPublicEndpointParamsRateLimitOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAiSearchNamespaces.DataCloudflareAiSearchNamespacesResultPublicEndpointParamsRateLimitOutputReference RateLimit
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiSearchNamespaces.DataCloudflareAiSearchNamespacesResultPublicEndpointParamsRateLimitOutputReference>()!;
        }

        [JsiiProperty(name: "searchEndpoint", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiSearchNamespaces.DataCloudflareAiSearchNamespacesResultPublicEndpointParamsSearchEndpointOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAiSearchNamespaces.DataCloudflareAiSearchNamespacesResultPublicEndpointParamsSearchEndpointOutputReference SearchEndpoint
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiSearchNamespaces.DataCloudflareAiSearchNamespacesResultPublicEndpointParamsSearchEndpointOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiSearchNamespaces.DataCloudflareAiSearchNamespacesResultPublicEndpointParams\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareAiSearchNamespaces.IDataCloudflareAiSearchNamespacesResultPublicEndpointParams? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiSearchNamespaces.IDataCloudflareAiSearchNamespacesResultPublicEndpointParams?>();
            set => SetInstanceProperty(value);
        }
    }
}
