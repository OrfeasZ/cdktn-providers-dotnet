using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Pinpointsmsvoicev2EventDestination
{
    [JsiiInterface(nativeType: typeof(IPinpointsmsvoicev2EventDestinationKinesisFirehoseDestination), fullyQualifiedName: "aws.pinpointsmsvoicev2EventDestination.Pinpointsmsvoicev2EventDestinationKinesisFirehoseDestination")]
    public interface IPinpointsmsvoicev2EventDestinationKinesisFirehoseDestination
    {
        /// <summary>ARN of the Amazon Data Firehose delivery stream that receives the events.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.53.0/docs/resources/pinpointsmsvoicev2_event_destination#delivery_stream_arn Pinpointsmsvoicev2EventDestination#delivery_stream_arn}
        /// </remarks>
        [JsiiProperty(name: "deliveryStreamArn", typeJson: "{\"primitive\":\"string\"}")]
        string DeliveryStreamArn
        {
            get;
        }

        /// <summary>ARN of the IAM role that End User Messaging SMS assumes to write to the delivery stream.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.53.0/docs/resources/pinpointsmsvoicev2_event_destination#iam_role_arn Pinpointsmsvoicev2EventDestination#iam_role_arn}
        /// </remarks>
        [JsiiProperty(name: "iamRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        string IamRoleArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPinpointsmsvoicev2EventDestinationKinesisFirehoseDestination), fullyQualifiedName: "aws.pinpointsmsvoicev2EventDestination.Pinpointsmsvoicev2EventDestinationKinesisFirehoseDestination")]
        internal sealed class _Proxy : DeputyBase, aws.Pinpointsmsvoicev2EventDestination.IPinpointsmsvoicev2EventDestinationKinesisFirehoseDestination
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ARN of the Amazon Data Firehose delivery stream that receives the events.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.53.0/docs/resources/pinpointsmsvoicev2_event_destination#delivery_stream_arn Pinpointsmsvoicev2EventDestination#delivery_stream_arn}
            /// </remarks>
            [JsiiProperty(name: "deliveryStreamArn", typeJson: "{\"primitive\":\"string\"}")]
            public string DeliveryStreamArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>ARN of the IAM role that End User Messaging SMS assumes to write to the delivery stream.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.53.0/docs/resources/pinpointsmsvoicev2_event_destination#iam_role_arn Pinpointsmsvoicev2EventDestination#iam_role_arn}
            /// </remarks>
            [JsiiProperty(name: "iamRoleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string IamRoleArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
