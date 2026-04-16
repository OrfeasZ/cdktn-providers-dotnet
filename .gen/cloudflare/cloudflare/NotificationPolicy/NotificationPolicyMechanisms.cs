using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.NotificationPolicy
{
    [JsiiByValue(fqn: "cloudflare.notificationPolicy.NotificationPolicyMechanisms")]
    public class NotificationPolicyMechanisms : cloudflare.NotificationPolicy.INotificationPolicyMechanisms
    {
        private object? _email;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#email NotificationPolicy#email}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "email", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.notificationPolicy.NotificationPolicyMechanismsEmail\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Email
        {
            get => _email;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.NotificationPolicy.INotificationPolicyMechanismsEmail[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.NotificationPolicy.INotificationPolicyMechanismsEmail).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _email = value;
            }
        }

        private object? _pagerduty;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#pagerduty NotificationPolicy#pagerduty}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pagerduty", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.notificationPolicy.NotificationPolicyMechanismsPagerduty\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Pagerduty
        {
            get => _pagerduty;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.NotificationPolicy.INotificationPolicyMechanismsPagerduty[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.NotificationPolicy.INotificationPolicyMechanismsPagerduty).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _pagerduty = value;
            }
        }

        private object? _webhooks;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/notification_policy#webhooks NotificationPolicy#webhooks}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "webhooks", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.notificationPolicy.NotificationPolicyMechanismsWebhooks\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Webhooks
        {
            get => _webhooks;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.NotificationPolicy.INotificationPolicyMechanismsWebhooks[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.NotificationPolicy.INotificationPolicyMechanismsWebhooks).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _webhooks = value;
            }
        }
    }
}
