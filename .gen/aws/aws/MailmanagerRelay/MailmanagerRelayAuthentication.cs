using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MailmanagerRelay
{
    [JsiiByValue(fqn: "aws.mailmanagerRelay.MailmanagerRelayAuthentication")]
    public class MailmanagerRelayAuthentication : aws.MailmanagerRelay.IMailmanagerRelayAuthentication
    {
        private object? _noAuthentication;

        /// <summary>no_authentication block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_relay#no_authentication MailmanagerRelay#no_authentication}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerRelay.IMailmanagerRelayAuthenticationNoAuthentication" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "noAuthentication", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerRelay.MailmanagerRelayAuthenticationNoAuthentication\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? NoAuthentication
        {
            get => _noAuthentication;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.MailmanagerRelay.IMailmanagerRelayAuthenticationNoAuthentication[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.MailmanagerRelay.IMailmanagerRelayAuthenticationNoAuthentication).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _noAuthentication = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_relay#secret_arn MailmanagerRelay#secret_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "secretArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecretArn
        {
            get;
            set;
        }
    }
}
