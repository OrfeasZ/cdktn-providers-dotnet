using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareRuleset
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareRuleset.DataCloudflareRulesetRulesActionParametersCacheKeyCustomKeyUserOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareRuleset.DataCloudflareRulesetRulesActionParametersCacheKeyCustomKeyUserOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareRulesetRulesActionParametersCacheKeyCustomKeyUserOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareRulesetRulesActionParametersCacheKeyCustomKeyUserOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareRulesetRulesActionParametersCacheKeyCustomKeyUserOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareRulesetRulesActionParametersCacheKeyCustomKeyUserOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "deviceType", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable DeviceType
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "geo", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Geo
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lang", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Lang
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareRuleset.DataCloudflareRulesetRulesActionParametersCacheKeyCustomKeyUser\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareRuleset.IDataCloudflareRulesetRulesActionParametersCacheKeyCustomKeyUser? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareRuleset.IDataCloudflareRulesetRulesActionParametersCacheKeyCustomKeyUser?>();
            set => SetInstanceProperty(value);
        }
    }
}
