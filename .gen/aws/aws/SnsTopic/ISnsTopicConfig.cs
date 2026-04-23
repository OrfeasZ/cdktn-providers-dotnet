using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SnsTopic
{
    [JsiiInterface(nativeType: typeof(ISnsTopicConfig), fullyQualifiedName: "aws.snsTopic.SnsTopicConfig")]
    public interface ISnsTopicConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#application_failure_feedback_role_arn SnsTopic#application_failure_feedback_role_arn}.</summary>
        [JsiiProperty(name: "applicationFailureFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ApplicationFailureFeedbackRoleArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#application_success_feedback_role_arn SnsTopic#application_success_feedback_role_arn}.</summary>
        [JsiiProperty(name: "applicationSuccessFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ApplicationSuccessFeedbackRoleArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#application_success_feedback_sample_rate SnsTopic#application_success_feedback_sample_rate}.</summary>
        [JsiiProperty(name: "applicationSuccessFeedbackSampleRate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ApplicationSuccessFeedbackSampleRate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#archive_policy SnsTopic#archive_policy}.</summary>
        [JsiiProperty(name: "archivePolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ArchivePolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#content_based_deduplication SnsTopic#content_based_deduplication}.</summary>
        [JsiiProperty(name: "contentBasedDeduplication", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ContentBasedDeduplication
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#delivery_policy SnsTopic#delivery_policy}.</summary>
        [JsiiProperty(name: "deliveryPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeliveryPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#display_name SnsTopic#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#fifo_throughput_scope SnsTopic#fifo_throughput_scope}.</summary>
        [JsiiProperty(name: "fifoThroughputScope", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FifoThroughputScope
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#fifo_topic SnsTopic#fifo_topic}.</summary>
        [JsiiProperty(name: "fifoTopic", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FifoTopic
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#firehose_failure_feedback_role_arn SnsTopic#firehose_failure_feedback_role_arn}.</summary>
        [JsiiProperty(name: "firehoseFailureFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FirehoseFailureFeedbackRoleArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#firehose_success_feedback_role_arn SnsTopic#firehose_success_feedback_role_arn}.</summary>
        [JsiiProperty(name: "firehoseSuccessFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FirehoseSuccessFeedbackRoleArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#firehose_success_feedback_sample_rate SnsTopic#firehose_success_feedback_sample_rate}.</summary>
        [JsiiProperty(name: "firehoseSuccessFeedbackSampleRate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? FirehoseSuccessFeedbackSampleRate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#http_failure_feedback_role_arn SnsTopic#http_failure_feedback_role_arn}.</summary>
        [JsiiProperty(name: "httpFailureFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HttpFailureFeedbackRoleArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#http_success_feedback_role_arn SnsTopic#http_success_feedback_role_arn}.</summary>
        [JsiiProperty(name: "httpSuccessFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HttpSuccessFeedbackRoleArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#http_success_feedback_sample_rate SnsTopic#http_success_feedback_sample_rate}.</summary>
        [JsiiProperty(name: "httpSuccessFeedbackSampleRate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? HttpSuccessFeedbackSampleRate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#id SnsTopic#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#kms_master_key_id SnsTopic#kms_master_key_id}.</summary>
        [JsiiProperty(name: "kmsMasterKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsMasterKeyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#lambda_failure_feedback_role_arn SnsTopic#lambda_failure_feedback_role_arn}.</summary>
        [JsiiProperty(name: "lambdaFailureFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LambdaFailureFeedbackRoleArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#lambda_success_feedback_role_arn SnsTopic#lambda_success_feedback_role_arn}.</summary>
        [JsiiProperty(name: "lambdaSuccessFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LambdaSuccessFeedbackRoleArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#lambda_success_feedback_sample_rate SnsTopic#lambda_success_feedback_sample_rate}.</summary>
        [JsiiProperty(name: "lambdaSuccessFeedbackSampleRate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? LambdaSuccessFeedbackSampleRate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#name SnsTopic#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#name_prefix SnsTopic#name_prefix}.</summary>
        [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NamePrefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#policy SnsTopic#policy}.</summary>
        [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Policy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#region SnsTopic#region}
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#signature_version SnsTopic#signature_version}.</summary>
        [JsiiProperty(name: "signatureVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SignatureVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#sqs_failure_feedback_role_arn SnsTopic#sqs_failure_feedback_role_arn}.</summary>
        [JsiiProperty(name: "sqsFailureFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SqsFailureFeedbackRoleArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#sqs_success_feedback_role_arn SnsTopic#sqs_success_feedback_role_arn}.</summary>
        [JsiiProperty(name: "sqsSuccessFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SqsSuccessFeedbackRoleArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#sqs_success_feedback_sample_rate SnsTopic#sqs_success_feedback_sample_rate}.</summary>
        [JsiiProperty(name: "sqsSuccessFeedbackSampleRate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SqsSuccessFeedbackSampleRate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#tags SnsTopic#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#tags_all SnsTopic#tags_all}.</summary>
        [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? TagsAll
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#tracing_config SnsTopic#tracing_config}.</summary>
        [JsiiProperty(name: "tracingConfig", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TracingConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISnsTopicConfig), fullyQualifiedName: "aws.snsTopic.SnsTopicConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SnsTopic.ISnsTopicConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#application_failure_feedback_role_arn SnsTopic#application_failure_feedback_role_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "applicationFailureFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ApplicationFailureFeedbackRoleArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#application_success_feedback_role_arn SnsTopic#application_success_feedback_role_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "applicationSuccessFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ApplicationSuccessFeedbackRoleArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#application_success_feedback_sample_rate SnsTopic#application_success_feedback_sample_rate}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "applicationSuccessFeedbackSampleRate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ApplicationSuccessFeedbackSampleRate
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#archive_policy SnsTopic#archive_policy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "archivePolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ArchivePolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#content_based_deduplication SnsTopic#content_based_deduplication}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "contentBasedDeduplication", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ContentBasedDeduplication
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#delivery_policy SnsTopic#delivery_policy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deliveryPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeliveryPolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#display_name SnsTopic#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#fifo_throughput_scope SnsTopic#fifo_throughput_scope}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fifoThroughputScope", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FifoThroughputScope
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#fifo_topic SnsTopic#fifo_topic}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fifoTopic", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? FifoTopic
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#firehose_failure_feedback_role_arn SnsTopic#firehose_failure_feedback_role_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "firehoseFailureFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FirehoseFailureFeedbackRoleArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#firehose_success_feedback_role_arn SnsTopic#firehose_success_feedback_role_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "firehoseSuccessFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FirehoseSuccessFeedbackRoleArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#firehose_success_feedback_sample_rate SnsTopic#firehose_success_feedback_sample_rate}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "firehoseSuccessFeedbackSampleRate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? FirehoseSuccessFeedbackSampleRate
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#http_failure_feedback_role_arn SnsTopic#http_failure_feedback_role_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "httpFailureFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HttpFailureFeedbackRoleArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#http_success_feedback_role_arn SnsTopic#http_success_feedback_role_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "httpSuccessFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HttpSuccessFeedbackRoleArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#http_success_feedback_sample_rate SnsTopic#http_success_feedback_sample_rate}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "httpSuccessFeedbackSampleRate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HttpSuccessFeedbackSampleRate
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#id SnsTopic#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#kms_master_key_id SnsTopic#kms_master_key_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kmsMasterKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsMasterKeyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#lambda_failure_feedback_role_arn SnsTopic#lambda_failure_feedback_role_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lambdaFailureFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LambdaFailureFeedbackRoleArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#lambda_success_feedback_role_arn SnsTopic#lambda_success_feedback_role_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lambdaSuccessFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LambdaSuccessFeedbackRoleArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#lambda_success_feedback_sample_rate SnsTopic#lambda_success_feedback_sample_rate}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lambdaSuccessFeedbackSampleRate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? LambdaSuccessFeedbackSampleRate
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#name SnsTopic#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#name_prefix SnsTopic#name_prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NamePrefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#policy SnsTopic#policy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Policy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#region SnsTopic#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#signature_version SnsTopic#signature_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "signatureVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SignatureVersion
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#sqs_failure_feedback_role_arn SnsTopic#sqs_failure_feedback_role_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sqsFailureFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SqsFailureFeedbackRoleArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#sqs_success_feedback_role_arn SnsTopic#sqs_success_feedback_role_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sqsSuccessFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SqsSuccessFeedbackRoleArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#sqs_success_feedback_sample_rate SnsTopic#sqs_success_feedback_sample_rate}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sqsSuccessFeedbackSampleRate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SqsSuccessFeedbackSampleRate
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#tags SnsTopic#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#tags_all SnsTopic#tags_all}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? TagsAll
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sns_topic#tracing_config SnsTopic#tracing_config}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tracingConfig", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TracingConfig
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
