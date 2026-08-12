using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MailmanagerRuleSet
{
    [JsiiInterface(nativeType: typeof(IMailmanagerRuleSetRuleUnlessStringExpressionEvaluate), fullyQualifiedName: "aws.mailmanagerRuleSet.MailmanagerRuleSetRuleUnlessStringExpressionEvaluate")]
    public interface IMailmanagerRuleSetRuleUnlessStringExpressionEvaluate
    {
        /// <summary>analysis block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/mailmanager_rule_set#analysis MailmanagerRuleSet#analysis}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleUnlessStringExpressionEvaluateAnalysis" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "analysis", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerRuleSet.MailmanagerRuleSetRuleUnlessStringExpressionEvaluateAnalysis\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Analysis
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/mailmanager_rule_set#attribute MailmanagerRuleSet#attribute}.</summary>
        [JsiiProperty(name: "attribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Attribute
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/mailmanager_rule_set#client_certificate_attribute MailmanagerRuleSet#client_certificate_attribute}.</summary>
        [JsiiProperty(name: "clientCertificateAttribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientCertificateAttribute
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/mailmanager_rule_set#mime_header_attribute MailmanagerRuleSet#mime_header_attribute}.</summary>
        [JsiiProperty(name: "mimeHeaderAttribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MimeHeaderAttribute
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMailmanagerRuleSetRuleUnlessStringExpressionEvaluate), fullyQualifiedName: "aws.mailmanagerRuleSet.MailmanagerRuleSetRuleUnlessStringExpressionEvaluate")]
        internal sealed class _Proxy : DeputyBase, aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleUnlessStringExpressionEvaluate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>analysis block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/mailmanager_rule_set#analysis MailmanagerRuleSet#analysis}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleUnlessStringExpressionEvaluateAnalysis" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "analysis", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerRuleSet.MailmanagerRuleSetRuleUnlessStringExpressionEvaluateAnalysis\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Analysis
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/mailmanager_rule_set#attribute MailmanagerRuleSet#attribute}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "attribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Attribute
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/mailmanager_rule_set#client_certificate_attribute MailmanagerRuleSet#client_certificate_attribute}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "clientCertificateAttribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientCertificateAttribute
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/mailmanager_rule_set#mime_header_attribute MailmanagerRuleSet#mime_header_attribute}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mimeHeaderAttribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MimeHeaderAttribute
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
