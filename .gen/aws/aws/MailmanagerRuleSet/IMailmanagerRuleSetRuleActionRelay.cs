using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MailmanagerRuleSet
{
    [JsiiInterface(nativeType: typeof(IMailmanagerRuleSetRuleActionRelay), fullyQualifiedName: "aws.mailmanagerRuleSet.MailmanagerRuleSetRuleActionRelay")]
    public interface IMailmanagerRuleSetRuleActionRelay
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_rule_set#relay MailmanagerRuleSet#relay}.</summary>
        [JsiiProperty(name: "relay", typeJson: "{\"primitive\":\"string\"}")]
        string Relay
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_rule_set#action_failure_policy MailmanagerRuleSet#action_failure_policy}.</summary>
        [JsiiProperty(name: "actionFailurePolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ActionFailurePolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_rule_set#mail_from MailmanagerRuleSet#mail_from}.</summary>
        [JsiiProperty(name: "mailFrom", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MailFrom
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMailmanagerRuleSetRuleActionRelay), fullyQualifiedName: "aws.mailmanagerRuleSet.MailmanagerRuleSetRuleActionRelay")]
        internal sealed class _Proxy : DeputyBase, aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleActionRelay
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_rule_set#relay MailmanagerRuleSet#relay}.</summary>
            [JsiiProperty(name: "relay", typeJson: "{\"primitive\":\"string\"}")]
            public string Relay
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_rule_set#action_failure_policy MailmanagerRuleSet#action_failure_policy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "actionFailurePolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ActionFailurePolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_rule_set#mail_from MailmanagerRuleSet#mail_from}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mailFrom", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MailFrom
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
