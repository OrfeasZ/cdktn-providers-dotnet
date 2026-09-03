using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MailmanagerRuleSet
{
    [JsiiInterface(nativeType: typeof(IMailmanagerRuleSetRuleActionPublishToSns), fullyQualifiedName: "aws.mailmanagerRuleSet.MailmanagerRuleSetRuleActionPublishToSns")]
    public interface IMailmanagerRuleSetRuleActionPublishToSns
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_rule_set#role_arn MailmanagerRuleSet#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_rule_set#topic_arn MailmanagerRuleSet#topic_arn}.</summary>
        [JsiiProperty(name: "topicArn", typeJson: "{\"primitive\":\"string\"}")]
        string TopicArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_rule_set#action_failure_policy MailmanagerRuleSet#action_failure_policy}.</summary>
        [JsiiProperty(name: "actionFailurePolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ActionFailurePolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_rule_set#encoding MailmanagerRuleSet#encoding}.</summary>
        [JsiiProperty(name: "encoding", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Encoding
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_rule_set#payload_type MailmanagerRuleSet#payload_type}.</summary>
        [JsiiProperty(name: "payloadType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PayloadType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMailmanagerRuleSetRuleActionPublishToSns), fullyQualifiedName: "aws.mailmanagerRuleSet.MailmanagerRuleSetRuleActionPublishToSns")]
        internal sealed class _Proxy : DeputyBase, aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleActionPublishToSns
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_rule_set#role_arn MailmanagerRuleSet#role_arn}.</summary>
            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_rule_set#topic_arn MailmanagerRuleSet#topic_arn}.</summary>
            [JsiiProperty(name: "topicArn", typeJson: "{\"primitive\":\"string\"}")]
            public string TopicArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_rule_set#action_failure_policy MailmanagerRuleSet#action_failure_policy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "actionFailurePolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ActionFailurePolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_rule_set#encoding MailmanagerRuleSet#encoding}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "encoding", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Encoding
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_rule_set#payload_type MailmanagerRuleSet#payload_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "payloadType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PayloadType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
