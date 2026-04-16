using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareRuleset
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareRuleset.DataCloudflareRulesetRulesActionParametersOverridesOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareRuleset.DataCloudflareRulesetRulesActionParametersOverridesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareRulesetRulesActionParametersOverridesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareRulesetRulesActionParametersOverridesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareRulesetRulesActionParametersOverridesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareRulesetRulesActionParametersOverridesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Action
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "categories", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareRuleset.DataCloudflareRulesetRulesActionParametersOverridesCategoriesList\"}")]
        public virtual cloudflare.DataCloudflareRuleset.DataCloudflareRulesetRulesActionParametersOverridesCategoriesList Categories
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareRuleset.DataCloudflareRulesetRulesActionParametersOverridesCategoriesList>()!;
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Enabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "rules", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareRuleset.DataCloudflareRulesetRulesActionParametersOverridesRulesList\"}")]
        public virtual cloudflare.DataCloudflareRuleset.DataCloudflareRulesetRulesActionParametersOverridesRulesList Rules
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareRuleset.DataCloudflareRulesetRulesActionParametersOverridesRulesList>()!;
        }

        [JsiiProperty(name: "sensitivityLevel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SensitivityLevel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareRuleset.DataCloudflareRulesetRulesActionParametersOverrides\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareRuleset.IDataCloudflareRulesetRulesActionParametersOverrides? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareRuleset.IDataCloudflareRulesetRulesActionParametersOverrides?>();
            set => SetInstanceProperty(value);
        }
    }
}
