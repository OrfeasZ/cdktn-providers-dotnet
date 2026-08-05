using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchLogS3TableIntegrationSource
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudwatchLogS3TableIntegrationSource.CloudwatchLogS3TableIntegrationSourceDataSource")]
    public class CloudwatchLogS3TableIntegrationSourceDataSource : aws.CloudwatchLogS3TableIntegrationSource.ICloudwatchLogS3TableIntegrationSourceDataSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/cloudwatch_log_s3_table_integration_source#name CloudwatchLogS3TableIntegrationSource#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/cloudwatch_log_s3_table_integration_source#type CloudwatchLogS3TableIntegrationSource#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
