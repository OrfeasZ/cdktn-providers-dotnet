using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Pinpointsmsvoicev2EventDestination
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.pinpointsmsvoicev2EventDestination.Pinpointsmsvoicev2EventDestinationKinesisFirehoseDestination")]
    public class Pinpointsmsvoicev2EventDestinationKinesisFirehoseDestination : aws.Pinpointsmsvoicev2EventDestination.IPinpointsmsvoicev2EventDestinationKinesisFirehoseDestination
    {
        /// <summary>ARN of the Amazon Data Firehose delivery stream that receives the events.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/pinpointsmsvoicev2_event_destination#delivery_stream_arn Pinpointsmsvoicev2EventDestination#delivery_stream_arn}
        /// </remarks>
        [JsiiProperty(name: "deliveryStreamArn", typeJson: "{\"primitive\":\"string\"}")]
        public string DeliveryStreamArn
        {
            get;
            set;
        }

        /// <summary>ARN of the IAM role that End User Messaging SMS assumes to write to the delivery stream.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/pinpointsmsvoicev2_event_destination#iam_role_arn Pinpointsmsvoicev2EventDestination#iam_role_arn}
        /// </remarks>
        [JsiiProperty(name: "iamRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public string IamRoleArn
        {
            get;
            set;
        }
    }
}
