using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareRuleset
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareRuleset.DataCloudflareRulesetRulesRatelimitOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareRuleset.DataCloudflareRulesetRulesRatelimitOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareRulesetRulesRatelimitOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareRulesetRulesRatelimitOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareRulesetRulesRatelimitOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareRulesetRulesRatelimitOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "characteristics", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Characteristics
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "countingExpression", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CountingExpression
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mitigationTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MitigationTimeout
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "period", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Period
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "requestsPerPeriod", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RequestsPerPeriod
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "requestsToOrigin", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable RequestsToOrigin
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "scorePerPeriod", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ScorePerPeriod
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "scoreResponseHeaderName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScoreResponseHeaderName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareRuleset.DataCloudflareRulesetRulesRatelimit\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareRuleset.IDataCloudflareRulesetRulesRatelimit? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareRuleset.IDataCloudflareRulesetRulesRatelimit?>();
            set => SetInstanceProperty(value);
        }
    }
}
