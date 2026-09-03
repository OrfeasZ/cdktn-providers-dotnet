using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MailmanagerIngressPoint
{
    [JsiiByValue(fqn: "aws.mailmanagerIngressPoint.MailmanagerIngressPointIngressPointConfigurationTlsAuthConfiguration")]
    public class MailmanagerIngressPointIngressPointConfigurationTlsAuthConfiguration : aws.MailmanagerIngressPoint.IMailmanagerIngressPointIngressPointConfigurationTlsAuthConfiguration
    {
        private object? _trustStore;

        /// <summary>trust_store block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/mailmanager_ingress_point#trust_store MailmanagerIngressPoint#trust_store}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerIngressPoint.IMailmanagerIngressPointIngressPointConfigurationTlsAuthConfigurationTrustStore" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "trustStore", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerIngressPoint.MailmanagerIngressPointIngressPointConfigurationTlsAuthConfigurationTrustStore\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TrustStore
        {
            get => _trustStore;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.MailmanagerIngressPoint.IMailmanagerIngressPointIngressPointConfigurationTlsAuthConfigurationTrustStore[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.MailmanagerIngressPoint.IMailmanagerIngressPointIngressPointConfigurationTlsAuthConfigurationTrustStore).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _trustStore = value;
            }
        }
    }
}
