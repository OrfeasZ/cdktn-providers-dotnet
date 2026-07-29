using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MailmanagerTrafficPolicy
{
    [JsiiInterface(nativeType: typeof(IMailmanagerTrafficPolicyPolicyStatementCondition), fullyQualifiedName: "aws.mailmanagerTrafficPolicy.MailmanagerTrafficPolicyPolicyStatementCondition")]
    public interface IMailmanagerTrafficPolicyPolicyStatementCondition
    {
        /// <summary>boolean_expression block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/mailmanager_traffic_policy#boolean_expression MailmanagerTrafficPolicy#boolean_expression}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerTrafficPolicy.IMailmanagerTrafficPolicyPolicyStatementConditionBooleanExpression" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "booleanExpression", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerTrafficPolicy.MailmanagerTrafficPolicyPolicyStatementConditionBooleanExpression\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? BooleanExpression
        {
            get
            {
                return null;
            }
        }

        /// <summary>ip_expression block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/mailmanager_traffic_policy#ip_expression MailmanagerTrafficPolicy#ip_expression}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerTrafficPolicy.IMailmanagerTrafficPolicyPolicyStatementConditionIpExpression" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "ipExpression", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerTrafficPolicy.MailmanagerTrafficPolicyPolicyStatementConditionIpExpression\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IpExpression
        {
            get
            {
                return null;
            }
        }

        /// <summary>ipv6_expression block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/mailmanager_traffic_policy#ipv6_expression MailmanagerTrafficPolicy#ipv6_expression}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerTrafficPolicy.IMailmanagerTrafficPolicyPolicyStatementConditionIpv6Expression" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "ipv6Expression", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerTrafficPolicy.MailmanagerTrafficPolicyPolicyStatementConditionIpv6Expression\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Ipv6Expression
        {
            get
            {
                return null;
            }
        }

        /// <summary>string_expression block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/mailmanager_traffic_policy#string_expression MailmanagerTrafficPolicy#string_expression}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerTrafficPolicy.IMailmanagerTrafficPolicyPolicyStatementConditionStringExpression" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "stringExpression", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerTrafficPolicy.MailmanagerTrafficPolicyPolicyStatementConditionStringExpression\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StringExpression
        {
            get
            {
                return null;
            }
        }

        /// <summary>tls_expression block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/mailmanager_traffic_policy#tls_expression MailmanagerTrafficPolicy#tls_expression}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerTrafficPolicy.IMailmanagerTrafficPolicyPolicyStatementConditionTlsExpression" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "tlsExpression", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerTrafficPolicy.MailmanagerTrafficPolicyPolicyStatementConditionTlsExpression\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TlsExpression
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMailmanagerTrafficPolicyPolicyStatementCondition), fullyQualifiedName: "aws.mailmanagerTrafficPolicy.MailmanagerTrafficPolicyPolicyStatementCondition")]
        internal sealed class _Proxy : DeputyBase, aws.MailmanagerTrafficPolicy.IMailmanagerTrafficPolicyPolicyStatementCondition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>boolean_expression block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/mailmanager_traffic_policy#boolean_expression MailmanagerTrafficPolicy#boolean_expression}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerTrafficPolicy.IMailmanagerTrafficPolicyPolicyStatementConditionBooleanExpression" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "booleanExpression", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerTrafficPolicy.MailmanagerTrafficPolicyPolicyStatementConditionBooleanExpression\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? BooleanExpression
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ip_expression block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/mailmanager_traffic_policy#ip_expression MailmanagerTrafficPolicy#ip_expression}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerTrafficPolicy.IMailmanagerTrafficPolicyPolicyStatementConditionIpExpression" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ipExpression", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerTrafficPolicy.MailmanagerTrafficPolicyPolicyStatementConditionIpExpression\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? IpExpression
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ipv6_expression block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/mailmanager_traffic_policy#ipv6_expression MailmanagerTrafficPolicy#ipv6_expression}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerTrafficPolicy.IMailmanagerTrafficPolicyPolicyStatementConditionIpv6Expression" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ipv6Expression", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerTrafficPolicy.MailmanagerTrafficPolicyPolicyStatementConditionIpv6Expression\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Ipv6Expression
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>string_expression block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/mailmanager_traffic_policy#string_expression MailmanagerTrafficPolicy#string_expression}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerTrafficPolicy.IMailmanagerTrafficPolicyPolicyStatementConditionStringExpression" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stringExpression", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerTrafficPolicy.MailmanagerTrafficPolicyPolicyStatementConditionStringExpression\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? StringExpression
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>tls_expression block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/mailmanager_traffic_policy#tls_expression MailmanagerTrafficPolicy#tls_expression}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerTrafficPolicy.IMailmanagerTrafficPolicyPolicyStatementConditionTlsExpression" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tlsExpression", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerTrafficPolicy.MailmanagerTrafficPolicyPolicyStatementConditionTlsExpression\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TlsExpression
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
