using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustAccessApplication
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesConnectionRulesOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesConnectionRulesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareZeroTrustAccessApplicationPoliciesConnectionRulesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareZeroTrustAccessApplicationPoliciesConnectionRulesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareZeroTrustAccessApplicationPoliciesConnectionRulesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustAccessApplicationPoliciesConnectionRulesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "ssh", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesConnectionRulesSshOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesConnectionRulesSshOutputReference Ssh
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesConnectionRulesSshOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationPoliciesConnectionRules\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplication.IDataCloudflareZeroTrustAccessApplicationPoliciesConnectionRules? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplication.IDataCloudflareZeroTrustAccessApplicationPoliciesConnectionRules?>();
            set => SetInstanceProperty(value);
        }
    }
}
