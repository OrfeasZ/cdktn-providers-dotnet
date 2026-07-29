using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchLogS3TableIntegrationSource
{
    [JsiiByValue(fqn: "aws.cloudwatchLogS3TableIntegrationSource.CloudwatchLogS3TableIntegrationSourceTimeouts")]
    public class CloudwatchLogS3TableIntegrationSourceTimeouts : aws.CloudwatchLogS3TableIntegrationSource.ICloudwatchLogS3TableIntegrationSourceTimeouts
    {
        /// <summary>A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as "30s" or "2h45m". Valid time units are "s" (seconds), "m" (minutes), "h" (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/cloudwatch_log_s3_table_integration_source#delete CloudwatchLogS3TableIntegrationSource#delete}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }
    }
}
