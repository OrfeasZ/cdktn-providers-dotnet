using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdawebFunctionRevision
{
    [JsiiByValue(fqn: "aws.lambdawebFunctionRevision.LambdawebFunctionRevisionServiceConfigTelemetryConfigLoggingConfig")]
    public class LambdawebFunctionRevisionServiceConfigTelemetryConfigLoggingConfig : aws.LambdawebFunctionRevision.ILambdawebFunctionRevisionServiceConfigTelemetryConfigLoggingConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/lambdaweb_function_revision#application_log_level LambdawebFunctionRevision#application_log_level}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "applicationLogLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ApplicationLogLevel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/lambdaweb_function_revision#log_group LambdawebFunctionRevision#log_group}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogGroup
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/lambdaweb_function_revision#system_log_level LambdawebFunctionRevision#system_log_level}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "systemLogLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SystemLogLevel
        {
            get;
            set;
        }
    }
}
