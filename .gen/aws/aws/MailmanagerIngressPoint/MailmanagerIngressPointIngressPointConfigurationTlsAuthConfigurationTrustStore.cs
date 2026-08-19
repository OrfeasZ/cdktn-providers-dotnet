using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MailmanagerIngressPoint
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.mailmanagerIngressPoint.MailmanagerIngressPointIngressPointConfigurationTlsAuthConfigurationTrustStore")]
    public class MailmanagerIngressPointIngressPointConfigurationTlsAuthConfigurationTrustStore : aws.MailmanagerIngressPoint.IMailmanagerIngressPointIngressPointConfigurationTlsAuthConfigurationTrustStore
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/mailmanager_ingress_point#ca_content MailmanagerIngressPoint#ca_content}.</summary>
        [JsiiProperty(name: "caContent", typeJson: "{\"primitive\":\"string\"}")]
        public string CaContent
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/mailmanager_ingress_point#crl_content MailmanagerIngressPoint#crl_content}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "crlContent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CrlContent
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/mailmanager_ingress_point#kms_key_arn MailmanagerIngressPoint#kms_key_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsKeyArn
        {
            get;
            set;
        }
    }
}
