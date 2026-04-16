using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareWebAnalyticsSite
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareWebAnalyticsSite.DataCloudflareWebAnalyticsSiteRulesetOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareWebAnalyticsSite.DataCloudflareWebAnalyticsSiteRulesetOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareWebAnalyticsSiteRulesetOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareWebAnalyticsSiteRulesetOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareWebAnalyticsSiteRulesetOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareWebAnalyticsSiteRulesetOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Enabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "zoneName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ZoneName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "zoneTag", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ZoneTag
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWebAnalyticsSite.DataCloudflareWebAnalyticsSiteRuleset\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareWebAnalyticsSite.IDataCloudflareWebAnalyticsSiteRuleset? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWebAnalyticsSite.IDataCloudflareWebAnalyticsSiteRuleset?>();
            set => SetInstanceProperty(value);
        }
    }
}
