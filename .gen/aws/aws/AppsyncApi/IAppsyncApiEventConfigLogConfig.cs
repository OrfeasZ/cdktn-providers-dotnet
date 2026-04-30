using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncApi
{
    [JsiiInterface(nativeType: typeof(IAppsyncApiEventConfigLogConfig), fullyQualifiedName: "aws.appsyncApi.AppsyncApiEventConfigLogConfig")]
    public interface IAppsyncApiEventConfigLogConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/appsync_api#cloudwatch_logs_role_arn AppsyncApi#cloudwatch_logs_role_arn}.</summary>
        [JsiiProperty(name: "cloudwatchLogsRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        string CloudwatchLogsRoleArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/appsync_api#log_level AppsyncApi#log_level}.</summary>
        [JsiiProperty(name: "logLevel", typeJson: "{\"primitive\":\"string\"}")]
        string LogLevel
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppsyncApiEventConfigLogConfig), fullyQualifiedName: "aws.appsyncApi.AppsyncApiEventConfigLogConfig")]
        internal sealed class _Proxy : DeputyBase, aws.AppsyncApi.IAppsyncApiEventConfigLogConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/appsync_api#cloudwatch_logs_role_arn AppsyncApi#cloudwatch_logs_role_arn}.</summary>
            [JsiiProperty(name: "cloudwatchLogsRoleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string CloudwatchLogsRoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/appsync_api#log_level AppsyncApi#log_level}.</summary>
            [JsiiProperty(name: "logLevel", typeJson: "{\"primitive\":\"string\"}")]
            public string LogLevel
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
