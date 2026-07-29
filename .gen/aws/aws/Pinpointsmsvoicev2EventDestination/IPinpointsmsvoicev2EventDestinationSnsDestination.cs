using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Pinpointsmsvoicev2EventDestination
{
    [JsiiInterface(nativeType: typeof(IPinpointsmsvoicev2EventDestinationSnsDestination), fullyQualifiedName: "aws.pinpointsmsvoicev2EventDestination.Pinpointsmsvoicev2EventDestinationSnsDestination")]
    public interface IPinpointsmsvoicev2EventDestinationSnsDestination
    {
        /// <summary>ARN of the Amazon SNS topic that receives the events.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.56.0/docs/resources/pinpointsmsvoicev2_event_destination#topic_arn Pinpointsmsvoicev2EventDestination#topic_arn}
        /// </remarks>
        [JsiiProperty(name: "topicArn", typeJson: "{\"primitive\":\"string\"}")]
        string TopicArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPinpointsmsvoicev2EventDestinationSnsDestination), fullyQualifiedName: "aws.pinpointsmsvoicev2EventDestination.Pinpointsmsvoicev2EventDestinationSnsDestination")]
        internal sealed class _Proxy : DeputyBase, aws.Pinpointsmsvoicev2EventDestination.IPinpointsmsvoicev2EventDestinationSnsDestination
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ARN of the Amazon SNS topic that receives the events.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.56.0/docs/resources/pinpointsmsvoicev2_event_destination#topic_arn Pinpointsmsvoicev2EventDestination#topic_arn}
            /// </remarks>
            [JsiiProperty(name: "topicArn", typeJson: "{\"primitive\":\"string\"}")]
            public string TopicArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
