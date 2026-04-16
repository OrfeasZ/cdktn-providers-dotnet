using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.R2BucketEventNotification
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.r2BucketEventNotification.R2BucketEventNotificationRules")]
    public class R2BucketEventNotificationRules : cloudflare.R2BucketEventNotification.IR2BucketEventNotificationRules
    {
        /// <summary>Array of R2 object actions that will trigger notifications.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/r2_bucket_event_notification#actions R2BucketEventNotification#actions}
        /// </remarks>
        [JsiiProperty(name: "actions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Actions
        {
            get;
            set;
        }

        /// <summary>A description that can be used to identify the event notification rule after creation.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/r2_bucket_event_notification#description R2BucketEventNotification#description}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Notifications will be sent only for objects with this prefix.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/r2_bucket_event_notification#prefix R2BucketEventNotification#prefix}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Prefix
        {
            get;
            set;
        }

        /// <summary>Notifications will be sent only for objects with this suffix.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/r2_bucket_event_notification#suffix R2BucketEventNotification#suffix}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "suffix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Suffix
        {
            get;
            set;
        }
    }
}
