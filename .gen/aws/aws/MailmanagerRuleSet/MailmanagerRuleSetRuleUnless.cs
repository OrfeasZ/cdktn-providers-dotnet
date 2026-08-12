using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MailmanagerRuleSet
{
    [JsiiByValue(fqn: "aws.mailmanagerRuleSet.MailmanagerRuleSetRuleUnless")]
    public class MailmanagerRuleSetRuleUnless : aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleUnless
    {
        private object? _booleanExpression;

        /// <summary>boolean_expression block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/mailmanager_rule_set#boolean_expression MailmanagerRuleSet#boolean_expression}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleUnlessBooleanExpression" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "booleanExpression", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerRuleSet.MailmanagerRuleSetRuleUnlessBooleanExpression\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? BooleanExpression
        {
            get => _booleanExpression;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleUnlessBooleanExpression[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleUnlessBooleanExpression).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _booleanExpression = value;
            }
        }

        private object? _dmarcExpression;

        /// <summary>dmarc_expression block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/mailmanager_rule_set#dmarc_expression MailmanagerRuleSet#dmarc_expression}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleUnlessDmarcExpression" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dmarcExpression", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerRuleSet.MailmanagerRuleSetRuleUnlessDmarcExpression\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DmarcExpression
        {
            get => _dmarcExpression;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleUnlessDmarcExpression[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleUnlessDmarcExpression).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _dmarcExpression = value;
            }
        }

        private object? _ipExpression;

        /// <summary>ip_expression block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/mailmanager_rule_set#ip_expression MailmanagerRuleSet#ip_expression}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleUnlessIpExpression" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipExpression", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerRuleSet.MailmanagerRuleSetRuleUnlessIpExpression\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? IpExpression
        {
            get => _ipExpression;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleUnlessIpExpression[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleUnlessIpExpression).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ipExpression = value;
            }
        }

        private object? _numberExpression;

        /// <summary>number_expression block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/mailmanager_rule_set#number_expression MailmanagerRuleSet#number_expression}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleUnlessNumberExpression" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "numberExpression", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerRuleSet.MailmanagerRuleSetRuleUnlessNumberExpression\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? NumberExpression
        {
            get => _numberExpression;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleUnlessNumberExpression[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleUnlessNumberExpression).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _numberExpression = value;
            }
        }

        private object? _stringExpression;

        /// <summary>string_expression block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/mailmanager_rule_set#string_expression MailmanagerRuleSet#string_expression}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleUnlessStringExpression" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stringExpression", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerRuleSet.MailmanagerRuleSetRuleUnlessStringExpression\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? StringExpression
        {
            get => _stringExpression;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleUnlessStringExpression[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleUnlessStringExpression).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _stringExpression = value;
            }
        }

        private object? _verdictExpression;

        /// <summary>verdict_expression block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/mailmanager_rule_set#verdict_expression MailmanagerRuleSet#verdict_expression}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleUnlessVerdictExpression" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "verdictExpression", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerRuleSet.MailmanagerRuleSetRuleUnlessVerdictExpression\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? VerdictExpression
        {
            get => _verdictExpression;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleUnlessVerdictExpression[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleUnlessVerdictExpression).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _verdictExpression = value;
            }
        }
    }
}
