using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Pinpointsmsvoicev2EventDestination
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.pinpointsmsvoicev2EventDestination.Pinpointsmsvoicev2EventDestinationCloudwatchLogsDestination")]
    public class Pinpointsmsvoicev2EventDestinationCloudwatchLogsDestination : aws.Pinpointsmsvoicev2EventDestination.IPinpointsmsvoicev2EventDestinationCloudwatchLogsDestination
    {
        /// <summary>ARN of the IAM role that End User Messaging SMS assumes to write to the log group.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/pinpointsmsvoicev2_event_destination#iam_role_arn Pinpointsmsvoicev2EventDestination#iam_role_arn}
        /// </remarks>
        [JsiiProperty(name: "iamRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public string IamRoleArn
        {
            get;
            set;
        }

        /// <summary>ARN of the Amazon CloudWatch log group that receives the events.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.52.0/docs/resources/pinpointsmsvoicev2_event_destination#log_group_arn Pinpointsmsvoicev2EventDestination#log_group_arn}
        /// </remarks>
        [JsiiProperty(name: "logGroupArn", typeJson: "{\"primitive\":\"string\"}")]
        public string LogGroupArn
        {
            get;
            set;
        }
    }
}
