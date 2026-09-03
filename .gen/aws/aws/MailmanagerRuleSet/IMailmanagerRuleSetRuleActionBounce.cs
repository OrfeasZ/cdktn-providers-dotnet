using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MailmanagerRuleSet
{
    [JsiiInterface(nativeType: typeof(IMailmanagerRuleSetRuleActionBounce), fullyQualifiedName: "aws.mailmanagerRuleSet.MailmanagerRuleSetRuleActionBounce")]
    public interface IMailmanagerRuleSetRuleActionBounce
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_rule_set#diagnostic_message MailmanagerRuleSet#diagnostic_message}.</summary>
        [JsiiProperty(name: "diagnosticMessage", typeJson: "{\"primitive\":\"string\"}")]
        string DiagnosticMessage
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_rule_set#role_arn MailmanagerRuleSet#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_rule_set#sender MailmanagerRuleSet#sender}.</summary>
        [JsiiProperty(name: "sender", typeJson: "{\"primitive\":\"string\"}")]
        string Sender
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_rule_set#smtp_reply_code MailmanagerRuleSet#smtp_reply_code}.</summary>
        [JsiiProperty(name: "smtpReplyCode", typeJson: "{\"primitive\":\"string\"}")]
        string SmtpReplyCode
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_rule_set#status_code MailmanagerRuleSet#status_code}.</summary>
        [JsiiProperty(name: "statusCode", typeJson: "{\"primitive\":\"string\"}")]
        string StatusCode
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_rule_set#message MailmanagerRuleSet#message}.</summary>
        [JsiiProperty(name: "message", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Message
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMailmanagerRuleSetRuleActionBounce), fullyQualifiedName: "aws.mailmanagerRuleSet.MailmanagerRuleSetRuleActionBounce")]
        internal sealed class _Proxy : DeputyBase, aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleActionBounce
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_rule_set#diagnostic_message MailmanagerRuleSet#diagnostic_message}.</summary>
            [JsiiProperty(name: "diagnosticMessage", typeJson: "{\"primitive\":\"string\"}")]
            public string DiagnosticMessage
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_rule_set#role_arn MailmanagerRuleSet#role_arn}.</summary>
            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_rule_set#sender MailmanagerRuleSet#sender}.</summary>
            [JsiiProperty(name: "sender", typeJson: "{\"primitive\":\"string\"}")]
            public string Sender
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_rule_set#smtp_reply_code MailmanagerRuleSet#smtp_reply_code}.</summary>
            [JsiiProperty(name: "smtpReplyCode", typeJson: "{\"primitive\":\"string\"}")]
            public string SmtpReplyCode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_rule_set#status_code MailmanagerRuleSet#status_code}.</summary>
            [JsiiProperty(name: "statusCode", typeJson: "{\"primitive\":\"string\"}")]
            public string StatusCode
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_rule_set#message MailmanagerRuleSet#message}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "message", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Message
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
