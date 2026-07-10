using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.NotificationPolicy
{
    [JsiiInterface(nativeType: typeof(INotificationPolicyMechanisms), fullyQualifiedName: "cloudflare.notificationPolicy.NotificationPolicyMechanisms")]
    public interface INotificationPolicyMechanisms
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/notification_policy#email NotificationPolicy#email}.</summary>
        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="cloudflare.NotificationPolicy.INotificationPolicyMechanismsEmail" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "email", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.notificationPolicy.NotificationPolicyMechanismsEmail\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Email
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/notification_policy#pagerduty NotificationPolicy#pagerduty}.</summary>
        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="cloudflare.NotificationPolicy.INotificationPolicyMechanismsPagerduty" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "pagerduty", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.notificationPolicy.NotificationPolicyMechanismsPagerduty\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Pagerduty
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/notification_policy#webhooks NotificationPolicy#webhooks}.</summary>
        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="cloudflare.NotificationPolicy.INotificationPolicyMechanismsWebhooks" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "webhooks", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.notificationPolicy.NotificationPolicyMechanismsWebhooks\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Webhooks
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INotificationPolicyMechanisms), fullyQualifiedName: "cloudflare.notificationPolicy.NotificationPolicyMechanisms")]
        internal sealed class _Proxy : DeputyBase, cloudflare.NotificationPolicy.INotificationPolicyMechanisms
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/notification_policy#email NotificationPolicy#email}.</summary>
            /// <remarks>
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="cloudflare.NotificationPolicy.INotificationPolicyMechanismsEmail" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "email", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.notificationPolicy.NotificationPolicyMechanismsEmail\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Email
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/notification_policy#pagerduty NotificationPolicy#pagerduty}.</summary>
            /// <remarks>
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="cloudflare.NotificationPolicy.INotificationPolicyMechanismsPagerduty" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pagerduty", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.notificationPolicy.NotificationPolicyMechanismsPagerduty\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Pagerduty
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/notification_policy#webhooks NotificationPolicy#webhooks}.</summary>
            /// <remarks>
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="cloudflare.NotificationPolicy.INotificationPolicyMechanismsWebhooks" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "webhooks", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.notificationPolicy.NotificationPolicyMechanismsWebhooks\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Webhooks
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
