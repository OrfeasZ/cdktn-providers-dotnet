using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.R2BucketEventNotification
{
    [JsiiInterface(nativeType: typeof(IR2BucketEventNotificationRules), fullyQualifiedName: "cloudflare.r2BucketEventNotification.R2BucketEventNotificationRules")]
    public interface IR2BucketEventNotificationRules
    {
        /// <summary>Array of R2 object actions that will trigger notifications.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/r2_bucket_event_notification#actions R2BucketEventNotification#actions}
        /// </remarks>
        [JsiiProperty(name: "actions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Actions
        {
            get;
        }

        /// <summary>A description that can be used to identify the event notification rule after creation.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/r2_bucket_event_notification#description R2BucketEventNotification#description}
        /// </remarks>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Notifications will be sent only for objects with this prefix.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/r2_bucket_event_notification#prefix R2BucketEventNotification#prefix}
        /// </remarks>
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Prefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>Notifications will be sent only for objects with this suffix.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/r2_bucket_event_notification#suffix R2BucketEventNotification#suffix}
        /// </remarks>
        [JsiiProperty(name: "suffix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Suffix
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IR2BucketEventNotificationRules), fullyQualifiedName: "cloudflare.r2BucketEventNotification.R2BucketEventNotificationRules")]
        internal sealed class _Proxy : DeputyBase, cloudflare.R2BucketEventNotification.IR2BucketEventNotificationRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Array of R2 object actions that will trigger notifications.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/r2_bucket_event_notification#actions R2BucketEventNotification#actions}
            /// </remarks>
            [JsiiProperty(name: "actions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Actions
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>A description that can be used to identify the event notification rule after creation.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/r2_bucket_event_notification#description R2BucketEventNotification#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Notifications will be sent only for objects with this prefix.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/r2_bucket_event_notification#prefix R2BucketEventNotification#prefix}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Prefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Notifications will be sent only for objects with this suffix.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/r2_bucket_event_notification#suffix R2BucketEventNotification#suffix}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "suffix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Suffix
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
