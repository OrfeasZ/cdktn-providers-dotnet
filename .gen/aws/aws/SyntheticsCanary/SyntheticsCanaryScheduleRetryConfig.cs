using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SyntheticsCanary
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.syntheticsCanary.SyntheticsCanaryScheduleRetryConfig")]
    public class SyntheticsCanaryScheduleRetryConfig : aws.SyntheticsCanary.ISyntheticsCanaryScheduleRetryConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/synthetics_canary#max_retries SyntheticsCanary#max_retries}.</summary>
        [JsiiProperty(name: "maxRetries", typeJson: "{\"primitive\":\"number\"}")]
        public double MaxRetries
        {
            get;
            set;
        }
    }
}
