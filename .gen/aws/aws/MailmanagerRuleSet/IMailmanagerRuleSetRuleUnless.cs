using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MailmanagerRuleSet
{
    [JsiiInterface(nativeType: typeof(IMailmanagerRuleSetRuleUnless), fullyQualifiedName: "aws.mailmanagerRuleSet.MailmanagerRuleSetRuleUnless")]
    public interface IMailmanagerRuleSetRuleUnless
    {
        /// <summary>boolean_expression block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_rule_set#boolean_expression MailmanagerRuleSet#boolean_expression}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleUnlessBooleanExpression" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "booleanExpression", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerRuleSet.MailmanagerRuleSetRuleUnlessBooleanExpression\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? BooleanExpression
        {
            get
            {
                return null;
            }
        }

        /// <summary>dmarc_expression block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_rule_set#dmarc_expression MailmanagerRuleSet#dmarc_expression}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleUnlessDmarcExpression" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "dmarcExpression", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerRuleSet.MailmanagerRuleSetRuleUnlessDmarcExpression\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DmarcExpression
        {
            get
            {
                return null;
            }
        }

        /// <summary>ip_expression block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_rule_set#ip_expression MailmanagerRuleSet#ip_expression}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleUnlessIpExpression" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "ipExpression", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerRuleSet.MailmanagerRuleSetRuleUnlessIpExpression\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IpExpression
        {
            get
            {
                return null;
            }
        }

        /// <summary>number_expression block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_rule_set#number_expression MailmanagerRuleSet#number_expression}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleUnlessNumberExpression" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "numberExpression", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerRuleSet.MailmanagerRuleSetRuleUnlessNumberExpression\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NumberExpression
        {
            get
            {
                return null;
            }
        }

        /// <summary>string_expression block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_rule_set#string_expression MailmanagerRuleSet#string_expression}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleUnlessStringExpression" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "stringExpression", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerRuleSet.MailmanagerRuleSetRuleUnlessStringExpression\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StringExpression
        {
            get
            {
                return null;
            }
        }

        /// <summary>verdict_expression block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_rule_set#verdict_expression MailmanagerRuleSet#verdict_expression}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleUnlessVerdictExpression" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "verdictExpression", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerRuleSet.MailmanagerRuleSetRuleUnlessVerdictExpression\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? VerdictExpression
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMailmanagerRuleSetRuleUnless), fullyQualifiedName: "aws.mailmanagerRuleSet.MailmanagerRuleSetRuleUnless")]
        internal sealed class _Proxy : DeputyBase, aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleUnless
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>boolean_expression block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_rule_set#boolean_expression MailmanagerRuleSet#boolean_expression}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleUnlessBooleanExpression" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "booleanExpression", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerRuleSet.MailmanagerRuleSetRuleUnlessBooleanExpression\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? BooleanExpression
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>dmarc_expression block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_rule_set#dmarc_expression MailmanagerRuleSet#dmarc_expression}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleUnlessDmarcExpression" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dmarcExpression", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerRuleSet.MailmanagerRuleSetRuleUnlessDmarcExpression\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DmarcExpression
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ip_expression block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_rule_set#ip_expression MailmanagerRuleSet#ip_expression}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleUnlessIpExpression" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ipExpression", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerRuleSet.MailmanagerRuleSetRuleUnlessIpExpression\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? IpExpression
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>number_expression block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_rule_set#number_expression MailmanagerRuleSet#number_expression}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleUnlessNumberExpression" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "numberExpression", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerRuleSet.MailmanagerRuleSetRuleUnlessNumberExpression\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? NumberExpression
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>string_expression block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_rule_set#string_expression MailmanagerRuleSet#string_expression}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleUnlessStringExpression" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stringExpression", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerRuleSet.MailmanagerRuleSetRuleUnlessStringExpression\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? StringExpression
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>verdict_expression block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_rule_set#verdict_expression MailmanagerRuleSet#verdict_expression}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleUnlessVerdictExpression" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "verdictExpression", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerRuleSet.MailmanagerRuleSetRuleUnlessVerdictExpression\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? VerdictExpression
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
