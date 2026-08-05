using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MailmanagerTrafficPolicy
{
    [JsiiByValue(fqn: "aws.mailmanagerTrafficPolicy.MailmanagerTrafficPolicyPolicyStatementCondition")]
    public class MailmanagerTrafficPolicyPolicyStatementCondition : aws.MailmanagerTrafficPolicy.IMailmanagerTrafficPolicyPolicyStatementCondition
    {
        private object? _booleanExpression;

        /// <summary>boolean_expression block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/mailmanager_traffic_policy#boolean_expression MailmanagerTrafficPolicy#boolean_expression}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerTrafficPolicy.IMailmanagerTrafficPolicyPolicyStatementConditionBooleanExpression" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "booleanExpression", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerTrafficPolicy.MailmanagerTrafficPolicyPolicyStatementConditionBooleanExpression\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.MailmanagerTrafficPolicy.IMailmanagerTrafficPolicyPolicyStatementConditionBooleanExpression[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.MailmanagerTrafficPolicy.IMailmanagerTrafficPolicyPolicyStatementConditionBooleanExpression).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _booleanExpression = value;
            }
        }

        private object? _ipExpression;

        /// <summary>ip_expression block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/mailmanager_traffic_policy#ip_expression MailmanagerTrafficPolicy#ip_expression}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerTrafficPolicy.IMailmanagerTrafficPolicyPolicyStatementConditionIpExpression" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipExpression", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerTrafficPolicy.MailmanagerTrafficPolicyPolicyStatementConditionIpExpression\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.MailmanagerTrafficPolicy.IMailmanagerTrafficPolicyPolicyStatementConditionIpExpression[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.MailmanagerTrafficPolicy.IMailmanagerTrafficPolicyPolicyStatementConditionIpExpression).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ipExpression = value;
            }
        }

        private object? _ipv6Expression;

        /// <summary>ipv6_expression block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/mailmanager_traffic_policy#ipv6_expression MailmanagerTrafficPolicy#ipv6_expression}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerTrafficPolicy.IMailmanagerTrafficPolicyPolicyStatementConditionIpv6Expression" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipv6Expression", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerTrafficPolicy.MailmanagerTrafficPolicyPolicyStatementConditionIpv6Expression\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Ipv6Expression
        {
            get => _ipv6Expression;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.MailmanagerTrafficPolicy.IMailmanagerTrafficPolicyPolicyStatementConditionIpv6Expression[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.MailmanagerTrafficPolicy.IMailmanagerTrafficPolicyPolicyStatementConditionIpv6Expression).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ipv6Expression = value;
            }
        }

        private object? _stringExpression;

        /// <summary>string_expression block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/mailmanager_traffic_policy#string_expression MailmanagerTrafficPolicy#string_expression}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerTrafficPolicy.IMailmanagerTrafficPolicyPolicyStatementConditionStringExpression" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stringExpression", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerTrafficPolicy.MailmanagerTrafficPolicyPolicyStatementConditionStringExpression\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.MailmanagerTrafficPolicy.IMailmanagerTrafficPolicyPolicyStatementConditionStringExpression[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.MailmanagerTrafficPolicy.IMailmanagerTrafficPolicyPolicyStatementConditionStringExpression).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _stringExpression = value;
            }
        }

        private object? _tlsExpression;

        /// <summary>tls_expression block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/mailmanager_traffic_policy#tls_expression MailmanagerTrafficPolicy#tls_expression}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerTrafficPolicy.IMailmanagerTrafficPolicyPolicyStatementConditionTlsExpression" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tlsExpression", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerTrafficPolicy.MailmanagerTrafficPolicyPolicyStatementConditionTlsExpression\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TlsExpression
        {
            get => _tlsExpression;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.MailmanagerTrafficPolicy.IMailmanagerTrafficPolicyPolicyStatementConditionTlsExpression[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.MailmanagerTrafficPolicy.IMailmanagerTrafficPolicyPolicyStatementConditionTlsExpression).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _tlsExpression = value;
            }
        }
    }
}
