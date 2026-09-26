using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustCasbPolicies
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustCasbPolicies.DataCloudflareZeroTrustCasbPoliciesResultActionsOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustCasbPolicies.DataCloudflareZeroTrustCasbPoliciesResultActionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareZeroTrustCasbPoliciesResultActionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareZeroTrustCasbPoliciesResultActionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareZeroTrustCasbPoliciesResultActionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustCasbPoliciesResultActionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "remediationTypes", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustCasbPolicies.DataCloudflareZeroTrustCasbPoliciesResultActionsRemediationTypesList\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustCasbPolicies.DataCloudflareZeroTrustCasbPoliciesResultActionsRemediationTypesList RemediationTypes
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustCasbPolicies.DataCloudflareZeroTrustCasbPoliciesResultActionsRemediationTypesList>()!;
        }

        [JsiiProperty(name: "webhookConfigs", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustCasbPolicies.DataCloudflareZeroTrustCasbPoliciesResultActionsWebhookConfigsList\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustCasbPolicies.DataCloudflareZeroTrustCasbPoliciesResultActionsWebhookConfigsList WebhookConfigs
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustCasbPolicies.DataCloudflareZeroTrustCasbPoliciesResultActionsWebhookConfigsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustCasbPolicies.DataCloudflareZeroTrustCasbPoliciesResultActions\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZeroTrustCasbPolicies.IDataCloudflareZeroTrustCasbPoliciesResultActions? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustCasbPolicies.IDataCloudflareZeroTrustCasbPoliciesResultActions?>();
            set => SetInstanceProperty(value);
        }
    }
}
