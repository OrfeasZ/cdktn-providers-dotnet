using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareNotificationPolicy
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareNotificationPolicy.DataCloudflareNotificationPolicyMechanismsOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareNotificationPolicy.DataCloudflareNotificationPolicyMechanismsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareNotificationPolicyMechanismsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareNotificationPolicyMechanismsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareNotificationPolicyMechanismsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareNotificationPolicyMechanismsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "email", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareNotificationPolicy.DataCloudflareNotificationPolicyMechanismsEmailList\"}")]
        public virtual cloudflare.DataCloudflareNotificationPolicy.DataCloudflareNotificationPolicyMechanismsEmailList Email
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareNotificationPolicy.DataCloudflareNotificationPolicyMechanismsEmailList>()!;
        }

        [JsiiProperty(name: "pagerduty", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareNotificationPolicy.DataCloudflareNotificationPolicyMechanismsPagerdutyList\"}")]
        public virtual cloudflare.DataCloudflareNotificationPolicy.DataCloudflareNotificationPolicyMechanismsPagerdutyList Pagerduty
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareNotificationPolicy.DataCloudflareNotificationPolicyMechanismsPagerdutyList>()!;
        }

        [JsiiProperty(name: "webhooks", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareNotificationPolicy.DataCloudflareNotificationPolicyMechanismsWebhooksList\"}")]
        public virtual cloudflare.DataCloudflareNotificationPolicy.DataCloudflareNotificationPolicyMechanismsWebhooksList Webhooks
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareNotificationPolicy.DataCloudflareNotificationPolicyMechanismsWebhooksList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareNotificationPolicy.DataCloudflareNotificationPolicyMechanisms\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareNotificationPolicy.IDataCloudflareNotificationPolicyMechanisms? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareNotificationPolicy.IDataCloudflareNotificationPolicyMechanisms?>();
            set => SetInstanceProperty(value);
        }
    }
}
