using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareRuleset
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareRuleset.DataCloudflareRulesetRulesActionParametersCacheKeyCustomKeyQueryStringOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareRuleset.DataCloudflareRulesetRulesActionParametersCacheKeyCustomKeyQueryStringOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareRulesetRulesActionParametersCacheKeyCustomKeyQueryStringOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareRulesetRulesActionParametersCacheKeyCustomKeyQueryStringOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareRulesetRulesActionParametersCacheKeyCustomKeyQueryStringOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareRulesetRulesActionParametersCacheKeyCustomKeyQueryStringOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "exclude", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareRuleset.DataCloudflareRulesetRulesActionParametersCacheKeyCustomKeyQueryStringExcludeOutputReference\"}")]
        public virtual cloudflare.DataCloudflareRuleset.DataCloudflareRulesetRulesActionParametersCacheKeyCustomKeyQueryStringExcludeOutputReference Exclude
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareRuleset.DataCloudflareRulesetRulesActionParametersCacheKeyCustomKeyQueryStringExcludeOutputReference>()!;
        }

        [JsiiProperty(name: "include", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareRuleset.DataCloudflareRulesetRulesActionParametersCacheKeyCustomKeyQueryStringIncludeOutputReference\"}")]
        public virtual cloudflare.DataCloudflareRuleset.DataCloudflareRulesetRulesActionParametersCacheKeyCustomKeyQueryStringIncludeOutputReference Include
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareRuleset.DataCloudflareRulesetRulesActionParametersCacheKeyCustomKeyQueryStringIncludeOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareRuleset.DataCloudflareRulesetRulesActionParametersCacheKeyCustomKeyQueryString\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareRuleset.IDataCloudflareRulesetRulesActionParametersCacheKeyCustomKeyQueryString? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareRuleset.IDataCloudflareRulesetRulesActionParametersCacheKeyCustomKeyQueryString?>();
            set => SetInstanceProperty(value);
        }
    }
}
