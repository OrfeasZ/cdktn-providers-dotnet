using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncApi
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appsyncApi.AppsyncApiEventConfigLogConfig")]
    public class AppsyncApiEventConfigLogConfig : aws.AppsyncApi.IAppsyncApiEventConfigLogConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/appsync_api#cloudwatch_logs_role_arn AppsyncApi#cloudwatch_logs_role_arn}.</summary>
        [JsiiProperty(name: "cloudwatchLogsRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public string CloudwatchLogsRoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/appsync_api#log_level AppsyncApi#log_level}.</summary>
        [JsiiProperty(name: "logLevel", typeJson: "{\"primitive\":\"string\"}")]
        public string LogLevel
        {
            get;
            set;
        }
    }
}
