using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ChatbotSlackChannelConfiguration
{
    [JsiiInterface(nativeType: typeof(IChatbotSlackChannelConfigurationConfig), fullyQualifiedName: "aws.chatbotSlackChannelConfiguration.ChatbotSlackChannelConfigurationConfig")]
    public interface IChatbotSlackChannelConfigurationConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/chatbot_slack_channel_configuration#configuration_name ChatbotSlackChannelConfiguration#configuration_name}.</summary>
        [JsiiProperty(name: "configurationName", typeJson: "{\"primitive\":\"string\"}")]
        string ConfigurationName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/chatbot_slack_channel_configuration#iam_role_arn ChatbotSlackChannelConfiguration#iam_role_arn}.</summary>
        [JsiiProperty(name: "iamRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        string IamRoleArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/chatbot_slack_channel_configuration#slack_channel_id ChatbotSlackChannelConfiguration#slack_channel_id}.</summary>
        [JsiiProperty(name: "slackChannelId", typeJson: "{\"primitive\":\"string\"}")]
        string SlackChannelId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/chatbot_slack_channel_configuration#slack_team_id ChatbotSlackChannelConfiguration#slack_team_id}.</summary>
        [JsiiProperty(name: "slackTeamId", typeJson: "{\"primitive\":\"string\"}")]
        string SlackTeamId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/chatbot_slack_channel_configuration#guardrail_policy_arns ChatbotSlackChannelConfiguration#guardrail_policy_arns}.</summary>
        [JsiiProperty(name: "guardrailPolicyArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? GuardrailPolicyArns
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/chatbot_slack_channel_configuration#logging_level ChatbotSlackChannelConfiguration#logging_level}.</summary>
        [JsiiProperty(name: "loggingLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LoggingLevel
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/chatbot_slack_channel_configuration#region ChatbotSlackChannelConfiguration#region}
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/chatbot_slack_channel_configuration#sns_topic_arns ChatbotSlackChannelConfiguration#sns_topic_arns}.</summary>
        [JsiiProperty(name: "snsTopicArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SnsTopicArns
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/chatbot_slack_channel_configuration#tags ChatbotSlackChannelConfiguration#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/chatbot_slack_channel_configuration#timeouts ChatbotSlackChannelConfiguration#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.chatbotSlackChannelConfiguration.ChatbotSlackChannelConfigurationTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ChatbotSlackChannelConfiguration.IChatbotSlackChannelConfigurationTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/chatbot_slack_channel_configuration#user_authorization_required ChatbotSlackChannelConfiguration#user_authorization_required}.</summary>
        [JsiiProperty(name: "userAuthorizationRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UserAuthorizationRequired
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IChatbotSlackChannelConfigurationConfig), fullyQualifiedName: "aws.chatbotSlackChannelConfiguration.ChatbotSlackChannelConfigurationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ChatbotSlackChannelConfiguration.IChatbotSlackChannelConfigurationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/chatbot_slack_channel_configuration#configuration_name ChatbotSlackChannelConfiguration#configuration_name}.</summary>
            [JsiiProperty(name: "configurationName", typeJson: "{\"primitive\":\"string\"}")]
            public string ConfigurationName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/chatbot_slack_channel_configuration#iam_role_arn ChatbotSlackChannelConfiguration#iam_role_arn}.</summary>
            [JsiiProperty(name: "iamRoleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string IamRoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/chatbot_slack_channel_configuration#slack_channel_id ChatbotSlackChannelConfiguration#slack_channel_id}.</summary>
            [JsiiProperty(name: "slackChannelId", typeJson: "{\"primitive\":\"string\"}")]
            public string SlackChannelId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/chatbot_slack_channel_configuration#slack_team_id ChatbotSlackChannelConfiguration#slack_team_id}.</summary>
            [JsiiProperty(name: "slackTeamId", typeJson: "{\"primitive\":\"string\"}")]
            public string SlackTeamId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/chatbot_slack_channel_configuration#guardrail_policy_arns ChatbotSlackChannelConfiguration#guardrail_policy_arns}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "guardrailPolicyArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? GuardrailPolicyArns
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/chatbot_slack_channel_configuration#logging_level ChatbotSlackChannelConfiguration#logging_level}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "loggingLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LoggingLevel
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/chatbot_slack_channel_configuration#region ChatbotSlackChannelConfiguration#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/chatbot_slack_channel_configuration#sns_topic_arns ChatbotSlackChannelConfiguration#sns_topic_arns}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "snsTopicArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SnsTopicArns
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/chatbot_slack_channel_configuration#tags ChatbotSlackChannelConfiguration#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/chatbot_slack_channel_configuration#timeouts ChatbotSlackChannelConfiguration#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.chatbotSlackChannelConfiguration.ChatbotSlackChannelConfigurationTimeouts\"}", isOptional: true)]
            public aws.ChatbotSlackChannelConfiguration.IChatbotSlackChannelConfigurationTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.ChatbotSlackChannelConfiguration.IChatbotSlackChannelConfigurationTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/chatbot_slack_channel_configuration#user_authorization_required ChatbotSlackChannelConfiguration#user_authorization_required}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userAuthorizationRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? UserAuthorizationRequired
            {
                get => GetInstanceProperty<object?>();
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
