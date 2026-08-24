using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareAiSearchNamespace
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareAiSearchNamespace.DataCloudflareAiSearchNamespacePublicEndpointParamsOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareAiSearchNamespace.DataCloudflareAiSearchNamespacePublicEndpointParamsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareAiSearchNamespacePublicEndpointParamsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareAiSearchNamespacePublicEndpointParamsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareAiSearchNamespacePublicEndpointParamsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareAiSearchNamespacePublicEndpointParamsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "authorizedHosts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AuthorizedHosts
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "chatCompletionsEndpoint", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiSearchNamespace.DataCloudflareAiSearchNamespacePublicEndpointParamsChatCompletionsEndpointOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAiSearchNamespace.DataCloudflareAiSearchNamespacePublicEndpointParamsChatCompletionsEndpointOutputReference ChatCompletionsEndpoint
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiSearchNamespace.DataCloudflareAiSearchNamespacePublicEndpointParamsChatCompletionsEndpointOutputReference>()!;
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

        [JsiiProperty(name: "mcp", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiSearchNamespace.DataCloudflareAiSearchNamespacePublicEndpointParamsMcpOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAiSearchNamespace.DataCloudflareAiSearchNamespacePublicEndpointParamsMcpOutputReference Mcp
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiSearchNamespace.DataCloudflareAiSearchNamespacePublicEndpointParamsMcpOutputReference>()!;
        }

        [JsiiProperty(name: "rateLimit", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiSearchNamespace.DataCloudflareAiSearchNamespacePublicEndpointParamsRateLimitOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAiSearchNamespace.DataCloudflareAiSearchNamespacePublicEndpointParamsRateLimitOutputReference RateLimit
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiSearchNamespace.DataCloudflareAiSearchNamespacePublicEndpointParamsRateLimitOutputReference>()!;
        }

        [JsiiProperty(name: "searchEndpoint", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiSearchNamespace.DataCloudflareAiSearchNamespacePublicEndpointParamsSearchEndpointOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAiSearchNamespace.DataCloudflareAiSearchNamespacePublicEndpointParamsSearchEndpointOutputReference SearchEndpoint
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiSearchNamespace.DataCloudflareAiSearchNamespacePublicEndpointParamsSearchEndpointOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiSearchNamespace.DataCloudflareAiSearchNamespacePublicEndpointParams\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareAiSearchNamespace.IDataCloudflareAiSearchNamespacePublicEndpointParams? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiSearchNamespace.IDataCloudflareAiSearchNamespacePublicEndpointParams?>();
            set => SetInstanceProperty(value);
        }
    }
}
