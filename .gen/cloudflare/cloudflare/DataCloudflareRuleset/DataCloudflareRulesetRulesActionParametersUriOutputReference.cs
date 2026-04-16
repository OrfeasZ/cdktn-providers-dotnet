using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareRuleset
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareRuleset.DataCloudflareRulesetRulesActionParametersUriOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareRuleset.DataCloudflareRulesetRulesActionParametersUriOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareRulesetRulesActionParametersUriOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareRulesetRulesActionParametersUriOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareRulesetRulesActionParametersUriOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareRulesetRulesActionParametersUriOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "origin", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Origin
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "path", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareRuleset.DataCloudflareRulesetRulesActionParametersUriPathOutputReference\"}")]
        public virtual cloudflare.DataCloudflareRuleset.DataCloudflareRulesetRulesActionParametersUriPathOutputReference Path
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareRuleset.DataCloudflareRulesetRulesActionParametersUriPathOutputReference>()!;
        }

        [JsiiProperty(name: "query", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareRuleset.DataCloudflareRulesetRulesActionParametersUriQueryOutputReference\"}")]
        public virtual cloudflare.DataCloudflareRuleset.DataCloudflareRulesetRulesActionParametersUriQueryOutputReference Query
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareRuleset.DataCloudflareRulesetRulesActionParametersUriQueryOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareRuleset.DataCloudflareRulesetRulesActionParametersUri\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareRuleset.IDataCloudflareRulesetRulesActionParametersUri? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareRuleset.IDataCloudflareRulesetRulesActionParametersUri?>();
            set => SetInstanceProperty(value);
        }
    }
}
