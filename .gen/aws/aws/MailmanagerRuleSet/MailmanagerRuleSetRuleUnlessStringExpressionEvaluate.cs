using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MailmanagerRuleSet
{
    [JsiiByValue(fqn: "aws.mailmanagerRuleSet.MailmanagerRuleSetRuleUnlessStringExpressionEvaluate")]
    public class MailmanagerRuleSetRuleUnlessStringExpressionEvaluate : aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleUnlessStringExpressionEvaluate
    {
        private object? _analysis;

        /// <summary>analysis block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_rule_set#analysis MailmanagerRuleSet#analysis}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleUnlessStringExpressionEvaluateAnalysis" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "analysis", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerRuleSet.MailmanagerRuleSetRuleUnlessStringExpressionEvaluateAnalysis\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Analysis
        {
            get => _analysis;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleUnlessStringExpressionEvaluateAnalysis[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.MailmanagerRuleSet.IMailmanagerRuleSetRuleUnlessStringExpressionEvaluateAnalysis).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _analysis = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_rule_set#attribute MailmanagerRuleSet#attribute}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "attribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Attribute
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_rule_set#client_certificate_attribute MailmanagerRuleSet#client_certificate_attribute}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clientCertificateAttribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientCertificateAttribute
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_rule_set#mime_header_attribute MailmanagerRuleSet#mime_header_attribute}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mimeHeaderAttribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MimeHeaderAttribute
        {
            get;
            set;
        }
    }
}
