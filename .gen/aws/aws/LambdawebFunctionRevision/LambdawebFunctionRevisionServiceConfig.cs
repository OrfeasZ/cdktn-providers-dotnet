using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdawebFunctionRevision
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lambdawebFunctionRevision.LambdawebFunctionRevisionServiceConfig")]
    public class LambdawebFunctionRevisionServiceConfig : aws.LambdawebFunctionRevision.ILambdawebFunctionRevisionServiceConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/lambdaweb_function_revision#execution_role_arn LambdawebFunctionRevision#execution_role_arn}.</summary>
        [JsiiProperty(name: "executionRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public string ExecutionRoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/lambdaweb_function_revision#egress_network_connector_arn LambdawebFunctionRevision#egress_network_connector_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "egressNetworkConnectorArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EgressNetworkConnectorArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/lambdaweb_function_revision#environment_variables LambdawebFunctionRevision#environment_variables}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "environmentVariables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? EnvironmentVariables
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/lambdaweb_function_revision#max_concurrency_per_environment LambdawebFunctionRevision#max_concurrency_per_environment}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxConcurrencyPerEnvironment", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxConcurrencyPerEnvironment
        {
            get;
            set;
        }

        private object? _telemetryConfig;

        /// <summary>telemetry_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/lambdaweb_function_revision#telemetry_config LambdawebFunctionRevision#telemetry_config}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.LambdawebFunctionRevision.ILambdawebFunctionRevisionServiceConfigTelemetryConfig" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "telemetryConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lambdawebFunctionRevision.LambdawebFunctionRevisionServiceConfigTelemetryConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TelemetryConfig
        {
            get => _telemetryConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.LambdawebFunctionRevision.ILambdawebFunctionRevisionServiceConfigTelemetryConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.LambdawebFunctionRevision.ILambdawebFunctionRevisionServiceConfigTelemetryConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _telemetryConfig = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/lambdaweb_function_revision#timeout_seconds LambdawebFunctionRevision#timeout_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TimeoutSeconds
        {
            get;
            set;
        }
    }
}
