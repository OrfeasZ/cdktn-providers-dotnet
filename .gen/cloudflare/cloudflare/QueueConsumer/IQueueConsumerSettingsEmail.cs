using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.QueueConsumer
{
    [JsiiInterface(nativeType: typeof(IQueueConsumerSettingsEmail), fullyQualifiedName: "cloudflare.queueConsumer.QueueConsumerSettingsEmail")]
    public interface IQueueConsumerSettingsEmail
    {
        /// <summary>The email address.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/queue_consumer#id QueueConsumer#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        string Id
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IQueueConsumerSettingsEmail), fullyQualifiedName: "cloudflare.queueConsumer.QueueConsumerSettingsEmail")]
        internal sealed class _Proxy : DeputyBase, cloudflare.QueueConsumer.IQueueConsumerSettingsEmail
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The email address.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/queue_consumer#id QueueConsumer#id}
            ///
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
            public string Id
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
