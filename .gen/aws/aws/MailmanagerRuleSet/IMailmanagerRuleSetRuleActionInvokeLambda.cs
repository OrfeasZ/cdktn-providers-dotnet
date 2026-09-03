using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MailmanagerRuleSet
{
    [JsiiInterface(nativeType: typeof(IMailmanagerRuleSetRuleActionInvokeLambda), fullyQualifiedName: "aws.mailmanagerRuleSet.MailmanagerRuleSetRuleActionInvokeLambda")]
    public interface IMailmanagerRuleSetRuleActionInvokeLambda
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_rule_set#function_arn MailmanagerRuleSet#function_arn}.</summary>
        [JsiiProperty(name: "functionArn", typeJson: "{\"primitive\":\"string\"}")]
        string FunctionArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_rule_set#invocation_type MailmanagerRuleSet#invocation_type}.</summary>
        [JsiiProperty(name: "invocationType", typeJson: "{\"primitive\":\"string\"}")]
        string InvocationType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_rule_set#role_arn MailmanagerRuleSet#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_rule_set#retry_time_minutes MailmanagerRuleSet#retry_time_minutes}.</summary>
        [JsiiProperty(name: "retryTimeMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RetryTimeMinutes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMailmanagerRuleSetRuleActionInvokeLambda), fullyQualifiedName: "aws.mailmanagerRuleSet.MailmanagerRuleSetRuleActionInvokeLambda")]
        internal sealed class _Proxy : DeputyBase, aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleActionInvokeLambda
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_rule_set#function_arn MailmanagerRuleSet#function_arn}.</summary>
            [JsiiProperty(name: "functionArn", typeJson: "{\"primitive\":\"string\"}")]
            public string FunctionArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_rule_set#invocation_type MailmanagerRuleSet#invocation_type}.</summary>
            [JsiiProperty(name: "invocationType", typeJson: "{\"primitive\":\"string\"}")]
            public string InvocationType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_rule_set#role_arn MailmanagerRuleSet#role_arn}.</summary>
            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_rule_set#retry_time_minutes MailmanagerRuleSet#retry_time_minutes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "retryTimeMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RetryTimeMinutes
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
