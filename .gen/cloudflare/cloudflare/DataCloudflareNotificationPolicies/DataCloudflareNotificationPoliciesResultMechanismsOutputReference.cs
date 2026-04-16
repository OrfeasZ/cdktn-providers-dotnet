using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareNotificationPolicies
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareNotificationPolicies.DataCloudflareNotificationPoliciesResultMechanismsOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareNotificationPolicies.DataCloudflareNotificationPoliciesResultMechanismsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareNotificationPoliciesResultMechanismsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareNotificationPoliciesResultMechanismsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareNotificationPoliciesResultMechanismsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareNotificationPoliciesResultMechanismsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "email", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareNotificationPolicies.DataCloudflareNotificationPoliciesResultMechanismsEmailList\"}")]
        public virtual cloudflare.DataCloudflareNotificationPolicies.DataCloudflareNotificationPoliciesResultMechanismsEmailList Email
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareNotificationPolicies.DataCloudflareNotificationPoliciesResultMechanismsEmailList>()!;
        }

        [JsiiProperty(name: "pagerduty", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareNotificationPolicies.DataCloudflareNotificationPoliciesResultMechanismsPagerdutyList\"}")]
        public virtual cloudflare.DataCloudflareNotificationPolicies.DataCloudflareNotificationPoliciesResultMechanismsPagerdutyList Pagerduty
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareNotificationPolicies.DataCloudflareNotificationPoliciesResultMechanismsPagerdutyList>()!;
        }

        [JsiiProperty(name: "webhooks", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareNotificationPolicies.DataCloudflareNotificationPoliciesResultMechanismsWebhooksList\"}")]
        public virtual cloudflare.DataCloudflareNotificationPolicies.DataCloudflareNotificationPoliciesResultMechanismsWebhooksList Webhooks
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareNotificationPolicies.DataCloudflareNotificationPoliciesResultMechanismsWebhooksList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareNotificationPolicies.DataCloudflareNotificationPoliciesResultMechanisms\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareNotificationPolicies.IDataCloudflareNotificationPoliciesResultMechanisms? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareNotificationPolicies.IDataCloudflareNotificationPoliciesResultMechanisms?>();
            set => SetInstanceProperty(value);
        }
    }
}
