using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsExpressGatewayService
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ecsExpressGatewayService.EcsExpressGatewayServicePrimaryContainer")]
    public class EcsExpressGatewayServicePrimaryContainer : aws.EcsExpressGatewayService.IEcsExpressGatewayServicePrimaryContainer
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ecs_express_gateway_service#image EcsExpressGatewayService#image}.</summary>
        [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}")]
        public string Image
        {
            get;
            set;
        }

        private object? _awsLogsConfiguration;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ecs_express_gateway_service#aws_logs_configuration EcsExpressGatewayService#aws_logs_configuration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "awsLogsConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsExpressGatewayService.EcsExpressGatewayServicePrimaryContainerAwsLogsConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AwsLogsConfiguration
        {
            get => _awsLogsConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.EcsExpressGatewayService.IEcsExpressGatewayServicePrimaryContainerAwsLogsConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.EcsExpressGatewayService.IEcsExpressGatewayServicePrimaryContainerAwsLogsConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _awsLogsConfiguration = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ecs_express_gateway_service#command EcsExpressGatewayService#command}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "command", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Command
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ecs_express_gateway_service#container_port EcsExpressGatewayService#container_port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "containerPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ContainerPort
        {
            get;
            set;
        }

        private object? _environment;

        /// <summary>environment block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ecs_express_gateway_service#environment EcsExpressGatewayService#environment}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "environment", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsExpressGatewayService.EcsExpressGatewayServicePrimaryContainerEnvironment\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Environment
        {
            get => _environment;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.EcsExpressGatewayService.IEcsExpressGatewayServicePrimaryContainerEnvironment[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.EcsExpressGatewayService.IEcsExpressGatewayServicePrimaryContainerEnvironment).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _environment = value;
            }
        }

        private object? _repositoryCredentials;

        /// <summary>repository_credentials block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ecs_express_gateway_service#repository_credentials EcsExpressGatewayService#repository_credentials}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "repositoryCredentials", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsExpressGatewayService.EcsExpressGatewayServicePrimaryContainerRepositoryCredentials\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RepositoryCredentials
        {
            get => _repositoryCredentials;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.EcsExpressGatewayService.IEcsExpressGatewayServicePrimaryContainerRepositoryCredentials[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.EcsExpressGatewayService.IEcsExpressGatewayServicePrimaryContainerRepositoryCredentials).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _repositoryCredentials = value;
            }
        }

        private object? _secret;

        /// <summary>secret block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/ecs_express_gateway_service#secret EcsExpressGatewayService#secret}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secret", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsExpressGatewayService.EcsExpressGatewayServicePrimaryContainerSecret\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Secret
        {
            get => _secret;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.EcsExpressGatewayService.IEcsExpressGatewayServicePrimaryContainerSecret[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.EcsExpressGatewayService.IEcsExpressGatewayServicePrimaryContainerSecret).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _secret = value;
            }
        }
    }
}
