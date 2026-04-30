using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchEventTarget
{
    [JsiiInterface(nativeType: typeof(ICloudwatchEventTargetConfig), fullyQualifiedName: "aws.cloudwatchEventTarget.CloudwatchEventTargetConfig")]
    public interface ICloudwatchEventTargetConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_event_target#arn CloudwatchEventTarget#arn}.</summary>
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        string Arn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_event_target#rule CloudwatchEventTarget#rule}.</summary>
        [JsiiProperty(name: "rule", typeJson: "{\"primitive\":\"string\"}")]
        string Rule
        {
            get;
        }

        /// <summary>appsync_target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_event_target#appsync_target CloudwatchEventTarget#appsync_target}
        /// </remarks>
        [JsiiProperty(name: "appsyncTarget", typeJson: "{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetAppsyncTarget\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CloudwatchEventTarget.ICloudwatchEventTargetAppsyncTarget? AppsyncTarget
        {
            get
            {
                return null;
            }
        }

        /// <summary>batch_target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_event_target#batch_target CloudwatchEventTarget#batch_target}
        /// </remarks>
        [JsiiProperty(name: "batchTarget", typeJson: "{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetBatchTarget\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CloudwatchEventTarget.ICloudwatchEventTargetBatchTarget? BatchTarget
        {
            get
            {
                return null;
            }
        }

        /// <summary>dead_letter_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_event_target#dead_letter_config CloudwatchEventTarget#dead_letter_config}
        /// </remarks>
        [JsiiProperty(name: "deadLetterConfig", typeJson: "{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetDeadLetterConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CloudwatchEventTarget.ICloudwatchEventTargetDeadLetterConfig? DeadLetterConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>ecs_target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_event_target#ecs_target CloudwatchEventTarget#ecs_target}
        /// </remarks>
        [JsiiProperty(name: "ecsTarget", typeJson: "{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetEcsTarget\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CloudwatchEventTarget.ICloudwatchEventTargetEcsTarget? EcsTarget
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_event_target#event_bus_name CloudwatchEventTarget#event_bus_name}.</summary>
        [JsiiProperty(name: "eventBusName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EventBusName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_event_target#force_destroy CloudwatchEventTarget#force_destroy}.</summary>
        [JsiiProperty(name: "forceDestroy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ForceDestroy
        {
            get
            {
                return null;
            }
        }

        /// <summary>http_target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_event_target#http_target CloudwatchEventTarget#http_target}
        /// </remarks>
        [JsiiProperty(name: "httpTarget", typeJson: "{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetHttpTarget\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CloudwatchEventTarget.ICloudwatchEventTargetHttpTarget? HttpTarget
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_event_target#id CloudwatchEventTarget#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_event_target#input CloudwatchEventTarget#input}.</summary>
        [JsiiProperty(name: "input", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Input
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_event_target#input_path CloudwatchEventTarget#input_path}.</summary>
        [JsiiProperty(name: "inputPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InputPath
        {
            get
            {
                return null;
            }
        }

        /// <summary>input_transformer block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_event_target#input_transformer CloudwatchEventTarget#input_transformer}
        /// </remarks>
        [JsiiProperty(name: "inputTransformer", typeJson: "{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetInputTransformer\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CloudwatchEventTarget.ICloudwatchEventTargetInputTransformer? InputTransformer
        {
            get
            {
                return null;
            }
        }

        /// <summary>kinesis_target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_event_target#kinesis_target CloudwatchEventTarget#kinesis_target}
        /// </remarks>
        [JsiiProperty(name: "kinesisTarget", typeJson: "{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetKinesisTarget\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CloudwatchEventTarget.ICloudwatchEventTargetKinesisTarget? KinesisTarget
        {
            get
            {
                return null;
            }
        }

        /// <summary>redshift_target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_event_target#redshift_target CloudwatchEventTarget#redshift_target}
        /// </remarks>
        [JsiiProperty(name: "redshiftTarget", typeJson: "{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetRedshiftTarget\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CloudwatchEventTarget.ICloudwatchEventTargetRedshiftTarget? RedshiftTarget
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_event_target#region CloudwatchEventTarget#region}
        /// </remarks>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Region
        {
            get
            {
                return null;
            }
        }

        /// <summary>retry_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_event_target#retry_policy CloudwatchEventTarget#retry_policy}
        /// </remarks>
        [JsiiProperty(name: "retryPolicy", typeJson: "{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetRetryPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CloudwatchEventTarget.ICloudwatchEventTargetRetryPolicy? RetryPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_event_target#role_arn CloudwatchEventTarget#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RoleArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>run_command_targets block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_event_target#run_command_targets CloudwatchEventTarget#run_command_targets}
        /// </remarks>
        [JsiiProperty(name: "runCommandTargets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetRunCommandTargets\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RunCommandTargets
        {
            get
            {
                return null;
            }
        }

        /// <summary>sagemaker_pipeline_target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_event_target#sagemaker_pipeline_target CloudwatchEventTarget#sagemaker_pipeline_target}
        /// </remarks>
        [JsiiProperty(name: "sagemakerPipelineTarget", typeJson: "{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetSagemakerPipelineTarget\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CloudwatchEventTarget.ICloudwatchEventTargetSagemakerPipelineTarget? SagemakerPipelineTarget
        {
            get
            {
                return null;
            }
        }

        /// <summary>sqs_target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_event_target#sqs_target CloudwatchEventTarget#sqs_target}
        /// </remarks>
        [JsiiProperty(name: "sqsTarget", typeJson: "{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetSqsTarget\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CloudwatchEventTarget.ICloudwatchEventTargetSqsTarget? SqsTarget
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_event_target#target_id CloudwatchEventTarget#target_id}.</summary>
        [JsiiProperty(name: "targetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TargetId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchEventTargetConfig), fullyQualifiedName: "aws.cloudwatchEventTarget.CloudwatchEventTargetConfig")]
        internal sealed class _Proxy : DeputyBase, aws.CloudwatchEventTarget.ICloudwatchEventTargetConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_event_target#arn CloudwatchEventTarget#arn}.</summary>
            [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
            public string Arn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_event_target#rule CloudwatchEventTarget#rule}.</summary>
            [JsiiProperty(name: "rule", typeJson: "{\"primitive\":\"string\"}")]
            public string Rule
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>appsync_target block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_event_target#appsync_target CloudwatchEventTarget#appsync_target}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "appsyncTarget", typeJson: "{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetAppsyncTarget\"}", isOptional: true)]
            public aws.CloudwatchEventTarget.ICloudwatchEventTargetAppsyncTarget? AppsyncTarget
            {
                get => GetInstanceProperty<aws.CloudwatchEventTarget.ICloudwatchEventTargetAppsyncTarget?>();
            }

            /// <summary>batch_target block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_event_target#batch_target CloudwatchEventTarget#batch_target}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "batchTarget", typeJson: "{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetBatchTarget\"}", isOptional: true)]
            public aws.CloudwatchEventTarget.ICloudwatchEventTargetBatchTarget? BatchTarget
            {
                get => GetInstanceProperty<aws.CloudwatchEventTarget.ICloudwatchEventTargetBatchTarget?>();
            }

            /// <summary>dead_letter_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_event_target#dead_letter_config CloudwatchEventTarget#dead_letter_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deadLetterConfig", typeJson: "{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetDeadLetterConfig\"}", isOptional: true)]
            public aws.CloudwatchEventTarget.ICloudwatchEventTargetDeadLetterConfig? DeadLetterConfig
            {
                get => GetInstanceProperty<aws.CloudwatchEventTarget.ICloudwatchEventTargetDeadLetterConfig?>();
            }

            /// <summary>ecs_target block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_event_target#ecs_target CloudwatchEventTarget#ecs_target}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ecsTarget", typeJson: "{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetEcsTarget\"}", isOptional: true)]
            public aws.CloudwatchEventTarget.ICloudwatchEventTargetEcsTarget? EcsTarget
            {
                get => GetInstanceProperty<aws.CloudwatchEventTarget.ICloudwatchEventTargetEcsTarget?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_event_target#event_bus_name CloudwatchEventTarget#event_bus_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "eventBusName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EventBusName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_event_target#force_destroy CloudwatchEventTarget#force_destroy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "forceDestroy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ForceDestroy
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>http_target block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_event_target#http_target CloudwatchEventTarget#http_target}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpTarget", typeJson: "{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetHttpTarget\"}", isOptional: true)]
            public aws.CloudwatchEventTarget.ICloudwatchEventTargetHttpTarget? HttpTarget
            {
                get => GetInstanceProperty<aws.CloudwatchEventTarget.ICloudwatchEventTargetHttpTarget?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_event_target#id CloudwatchEventTarget#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_event_target#input CloudwatchEventTarget#input}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "input", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Input
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_event_target#input_path CloudwatchEventTarget#input_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "inputPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InputPath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>input_transformer block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_event_target#input_transformer CloudwatchEventTarget#input_transformer}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "inputTransformer", typeJson: "{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetInputTransformer\"}", isOptional: true)]
            public aws.CloudwatchEventTarget.ICloudwatchEventTargetInputTransformer? InputTransformer
            {
                get => GetInstanceProperty<aws.CloudwatchEventTarget.ICloudwatchEventTargetInputTransformer?>();
            }

            /// <summary>kinesis_target block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_event_target#kinesis_target CloudwatchEventTarget#kinesis_target}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kinesisTarget", typeJson: "{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetKinesisTarget\"}", isOptional: true)]
            public aws.CloudwatchEventTarget.ICloudwatchEventTargetKinesisTarget? KinesisTarget
            {
                get => GetInstanceProperty<aws.CloudwatchEventTarget.ICloudwatchEventTargetKinesisTarget?>();
            }

            /// <summary>redshift_target block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_event_target#redshift_target CloudwatchEventTarget#redshift_target}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "redshiftTarget", typeJson: "{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetRedshiftTarget\"}", isOptional: true)]
            public aws.CloudwatchEventTarget.ICloudwatchEventTargetRedshiftTarget? RedshiftTarget
            {
                get => GetInstanceProperty<aws.CloudwatchEventTarget.ICloudwatchEventTargetRedshiftTarget?>();
            }

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_event_target#region CloudwatchEventTarget#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>retry_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_event_target#retry_policy CloudwatchEventTarget#retry_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "retryPolicy", typeJson: "{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetRetryPolicy\"}", isOptional: true)]
            public aws.CloudwatchEventTarget.ICloudwatchEventTargetRetryPolicy? RetryPolicy
            {
                get => GetInstanceProperty<aws.CloudwatchEventTarget.ICloudwatchEventTargetRetryPolicy?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_event_target#role_arn CloudwatchEventTarget#role_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RoleArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>run_command_targets block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_event_target#run_command_targets CloudwatchEventTarget#run_command_targets}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "runCommandTargets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetRunCommandTargets\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RunCommandTargets
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>sagemaker_pipeline_target block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_event_target#sagemaker_pipeline_target CloudwatchEventTarget#sagemaker_pipeline_target}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sagemakerPipelineTarget", typeJson: "{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetSagemakerPipelineTarget\"}", isOptional: true)]
            public aws.CloudwatchEventTarget.ICloudwatchEventTargetSagemakerPipelineTarget? SagemakerPipelineTarget
            {
                get => GetInstanceProperty<aws.CloudwatchEventTarget.ICloudwatchEventTargetSagemakerPipelineTarget?>();
            }

            /// <summary>sqs_target block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_event_target#sqs_target CloudwatchEventTarget#sqs_target}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sqsTarget", typeJson: "{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetSqsTarget\"}", isOptional: true)]
            public aws.CloudwatchEventTarget.ICloudwatchEventTargetSqsTarget? SqsTarget
            {
                get => GetInstanceProperty<aws.CloudwatchEventTarget.ICloudwatchEventTargetSqsTarget?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_event_target#target_id CloudwatchEventTarget#target_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TargetId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
