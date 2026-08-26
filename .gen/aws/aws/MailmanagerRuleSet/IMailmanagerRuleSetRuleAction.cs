using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MailmanagerRuleSet
{
    [JsiiInterface(nativeType: typeof(IMailmanagerRuleSetRuleAction), fullyQualifiedName: "aws.mailmanagerRuleSet.MailmanagerRuleSetRuleAction")]
    public interface IMailmanagerRuleSetRuleAction
    {
        /// <summary>add_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_rule_set#add_header MailmanagerRuleSet#add_header}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleActionAddHeader" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "addHeader", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerRuleSet.MailmanagerRuleSetRuleActionAddHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AddHeader
        {
            get
            {
                return null;
            }
        }

        /// <summary>archive block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_rule_set#archive MailmanagerRuleSet#archive}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleActionArchive" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "archive", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerRuleSet.MailmanagerRuleSetRuleActionArchive\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Archive
        {
            get
            {
                return null;
            }
        }

        /// <summary>bounce block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_rule_set#bounce MailmanagerRuleSet#bounce}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleActionBounce" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "bounce", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerRuleSet.MailmanagerRuleSetRuleActionBounce\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Bounce
        {
            get
            {
                return null;
            }
        }

        /// <summary>deliver_to_mailbox block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_rule_set#deliver_to_mailbox MailmanagerRuleSet#deliver_to_mailbox}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleActionDeliverToMailbox" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "deliverToMailbox", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerRuleSet.MailmanagerRuleSetRuleActionDeliverToMailbox\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DeliverToMailbox
        {
            get
            {
                return null;
            }
        }

        /// <summary>deliver_to_q_business block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_rule_set#deliver_to_q_business MailmanagerRuleSet#deliver_to_q_business}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleActionDeliverToQBusiness" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "deliverToQBusiness", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerRuleSet.MailmanagerRuleSetRuleActionDeliverToQBusiness\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DeliverToQBusiness
        {
            get
            {
                return null;
            }
        }

        /// <summary>drop block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_rule_set#drop MailmanagerRuleSet#drop}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleActionDrop" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "drop", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerRuleSet.MailmanagerRuleSetRuleActionDrop\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Drop
        {
            get
            {
                return null;
            }
        }

        /// <summary>invoke_lambda block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_rule_set#invoke_lambda MailmanagerRuleSet#invoke_lambda}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleActionInvokeLambda" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "invokeLambda", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerRuleSet.MailmanagerRuleSetRuleActionInvokeLambda\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? InvokeLambda
        {
            get
            {
                return null;
            }
        }

        /// <summary>publish_to_sns block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_rule_set#publish_to_sns MailmanagerRuleSet#publish_to_sns}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleActionPublishToSns" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "publishToSns", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerRuleSet.MailmanagerRuleSetRuleActionPublishToSns\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PublishToSns
        {
            get
            {
                return null;
            }
        }

        /// <summary>relay block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_rule_set#relay MailmanagerRuleSet#relay}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleActionRelay" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "relay", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerRuleSet.MailmanagerRuleSetRuleActionRelay\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Relay
        {
            get
            {
                return null;
            }
        }

        /// <summary>replace_recipient block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_rule_set#replace_recipient MailmanagerRuleSet#replace_recipient}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleActionReplaceRecipient" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "replaceRecipient", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerRuleSet.MailmanagerRuleSetRuleActionReplaceRecipient\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ReplaceRecipient
        {
            get
            {
                return null;
            }
        }

        /// <summary>send block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_rule_set#send MailmanagerRuleSet#send}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleActionSend" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "send", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerRuleSet.MailmanagerRuleSetRuleActionSend\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Send
        {
            get
            {
                return null;
            }
        }

        /// <summary>write_to_s3 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_rule_set#write_to_s3 MailmanagerRuleSet#write_to_s3}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleActionWriteToS3" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "writeToS3", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerRuleSet.MailmanagerRuleSetRuleActionWriteToS3\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? WriteToS3
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMailmanagerRuleSetRuleAction), fullyQualifiedName: "aws.mailmanagerRuleSet.MailmanagerRuleSetRuleAction")]
        internal sealed class _Proxy : DeputyBase, aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>add_header block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_rule_set#add_header MailmanagerRuleSet#add_header}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleActionAddHeader" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "addHeader", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerRuleSet.MailmanagerRuleSetRuleActionAddHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AddHeader
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>archive block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_rule_set#archive MailmanagerRuleSet#archive}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleActionArchive" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "archive", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerRuleSet.MailmanagerRuleSetRuleActionArchive\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Archive
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>bounce block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_rule_set#bounce MailmanagerRuleSet#bounce}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleActionBounce" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bounce", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerRuleSet.MailmanagerRuleSetRuleActionBounce\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Bounce
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>deliver_to_mailbox block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_rule_set#deliver_to_mailbox MailmanagerRuleSet#deliver_to_mailbox}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleActionDeliverToMailbox" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deliverToMailbox", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerRuleSet.MailmanagerRuleSetRuleActionDeliverToMailbox\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DeliverToMailbox
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>deliver_to_q_business block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_rule_set#deliver_to_q_business MailmanagerRuleSet#deliver_to_q_business}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleActionDeliverToQBusiness" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deliverToQBusiness", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerRuleSet.MailmanagerRuleSetRuleActionDeliverToQBusiness\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DeliverToQBusiness
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>drop block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_rule_set#drop MailmanagerRuleSet#drop}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleActionDrop" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "drop", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerRuleSet.MailmanagerRuleSetRuleActionDrop\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Drop
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>invoke_lambda block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_rule_set#invoke_lambda MailmanagerRuleSet#invoke_lambda}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleActionInvokeLambda" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "invokeLambda", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerRuleSet.MailmanagerRuleSetRuleActionInvokeLambda\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? InvokeLambda
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>publish_to_sns block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_rule_set#publish_to_sns MailmanagerRuleSet#publish_to_sns}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleActionPublishToSns" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "publishToSns", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerRuleSet.MailmanagerRuleSetRuleActionPublishToSns\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PublishToSns
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>relay block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_rule_set#relay MailmanagerRuleSet#relay}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleActionRelay" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "relay", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerRuleSet.MailmanagerRuleSetRuleActionRelay\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Relay
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>replace_recipient block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_rule_set#replace_recipient MailmanagerRuleSet#replace_recipient}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleActionReplaceRecipient" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "replaceRecipient", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerRuleSet.MailmanagerRuleSetRuleActionReplaceRecipient\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ReplaceRecipient
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>send block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_rule_set#send MailmanagerRuleSet#send}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleActionSend" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "send", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerRuleSet.MailmanagerRuleSetRuleActionSend\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Send
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>write_to_s3 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_rule_set#write_to_s3 MailmanagerRuleSet#write_to_s3}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleActionWriteToS3" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "writeToS3", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerRuleSet.MailmanagerRuleSetRuleActionWriteToS3\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? WriteToS3
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
