using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MailmanagerIngressPoint
{
    [JsiiByValue(fqn: "aws.mailmanagerIngressPoint.MailmanagerIngressPointIngressPointConfiguration")]
    public class MailmanagerIngressPointIngressPointConfiguration : aws.MailmanagerIngressPoint.IMailmanagerIngressPointIngressPointConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_ingress_point#secret_arn MailmanagerIngressPoint#secret_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "secretArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecretArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_ingress_point#smtp_password_wo MailmanagerIngressPoint#smtp_password_wo}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "smtpPasswordWo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SmtpPasswordWo
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_ingress_point#smtp_password_wo_version MailmanagerIngressPoint#smtp_password_wo_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "smtpPasswordWoVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SmtpPasswordWoVersion
        {
            get;
            set;
        }

        private object? _tlsAuthConfiguration;

        /// <summary>tls_auth_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_ingress_point#tls_auth_configuration MailmanagerIngressPoint#tls_auth_configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerIngressPoint.IMailmanagerIngressPointIngressPointConfigurationTlsAuthConfiguration" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tlsAuthConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerIngressPoint.MailmanagerIngressPointIngressPointConfigurationTlsAuthConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TlsAuthConfiguration
        {
            get => _tlsAuthConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.MailmanagerIngressPoint.IMailmanagerIngressPointIngressPointConfigurationTlsAuthConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.MailmanagerIngressPoint.IMailmanagerIngressPointIngressPointConfigurationTlsAuthConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _tlsAuthConfiguration = value;
            }
        }
    }
}
