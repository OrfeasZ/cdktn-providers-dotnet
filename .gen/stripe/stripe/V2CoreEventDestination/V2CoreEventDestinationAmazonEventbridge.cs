using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2CoreEventDestination
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.v2CoreEventDestination.V2CoreEventDestinationAmazonEventbridge")]
    public class V2CoreEventDestinationAmazonEventbridge : stripe.V2CoreEventDestination.IV2CoreEventDestinationAmazonEventbridge
    {
        /// <summary>The AWS account ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_core_event_destination#aws_account_id V2CoreEventDestination#aws_account_id}
        /// </remarks>
        [JsiiProperty(name: "awsAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public string AwsAccountId
        {
            get;
            set;
        }

        /// <summary>The region of the AWS event source.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_core_event_destination#aws_region V2CoreEventDestination#aws_region}
        /// </remarks>
        [JsiiProperty(name: "awsRegion", typeJson: "{\"primitive\":\"string\"}")]
        public string AwsRegion
        {
            get;
            set;
        }
    }
}
