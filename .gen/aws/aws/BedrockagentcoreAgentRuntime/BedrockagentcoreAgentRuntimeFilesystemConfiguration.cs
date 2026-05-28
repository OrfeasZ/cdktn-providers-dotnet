using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreAgentRuntime
{
    [JsiiByValue(fqn: "aws.bedrockagentcoreAgentRuntime.BedrockagentcoreAgentRuntimeFilesystemConfiguration")]
    public class BedrockagentcoreAgentRuntimeFilesystemConfiguration : aws.BedrockagentcoreAgentRuntime.IBedrockagentcoreAgentRuntimeFilesystemConfiguration
    {
        private object? _efsAccessPoint;

        /// <summary>efs_access_point block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_agent_runtime#efs_access_point BedrockagentcoreAgentRuntime#efs_access_point}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "efsAccessPoint", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreAgentRuntime.BedrockagentcoreAgentRuntimeFilesystemConfigurationEfsAccessPoint\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? EfsAccessPoint
        {
            get => _efsAccessPoint;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreAgentRuntime.IBedrockagentcoreAgentRuntimeFilesystemConfigurationEfsAccessPoint[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreAgentRuntime.IBedrockagentcoreAgentRuntimeFilesystemConfigurationEfsAccessPoint).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _efsAccessPoint = value;
            }
        }

        private object? _s3FilesAccessPoint;

        /// <summary>s3_files_access_point block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_agent_runtime#s3_files_access_point BedrockagentcoreAgentRuntime#s3_files_access_point}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3FilesAccessPoint", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreAgentRuntime.BedrockagentcoreAgentRuntimeFilesystemConfigurationS3FilesAccessPoint\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? S3FilesAccessPoint
        {
            get => _s3FilesAccessPoint;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreAgentRuntime.IBedrockagentcoreAgentRuntimeFilesystemConfigurationS3FilesAccessPoint[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreAgentRuntime.IBedrockagentcoreAgentRuntimeFilesystemConfigurationS3FilesAccessPoint).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _s3FilesAccessPoint = value;
            }
        }

        private object? _sessionStorage;

        /// <summary>session_storage block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/bedrockagentcore_agent_runtime#session_storage BedrockagentcoreAgentRuntime#session_storage}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sessionStorage", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreAgentRuntime.BedrockagentcoreAgentRuntimeFilesystemConfigurationSessionStorage\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SessionStorage
        {
            get => _sessionStorage;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreAgentRuntime.IBedrockagentcoreAgentRuntimeFilesystemConfigurationSessionStorage[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreAgentRuntime.IBedrockagentcoreAgentRuntimeFilesystemConfigurationSessionStorage).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _sessionStorage = value;
            }
        }
    }
}
