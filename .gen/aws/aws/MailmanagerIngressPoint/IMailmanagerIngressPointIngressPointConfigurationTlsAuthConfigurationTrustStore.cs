using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MailmanagerIngressPoint
{
    [JsiiInterface(nativeType: typeof(IMailmanagerIngressPointIngressPointConfigurationTlsAuthConfigurationTrustStore), fullyQualifiedName: "aws.mailmanagerIngressPoint.MailmanagerIngressPointIngressPointConfigurationTlsAuthConfigurationTrustStore")]
    public interface IMailmanagerIngressPointIngressPointConfigurationTlsAuthConfigurationTrustStore
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_ingress_point#ca_content MailmanagerIngressPoint#ca_content}.</summary>
        [JsiiProperty(name: "caContent", typeJson: "{\"primitive\":\"string\"}")]
        string CaContent
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_ingress_point#crl_content MailmanagerIngressPoint#crl_content}.</summary>
        [JsiiProperty(name: "crlContent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CrlContent
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_ingress_point#kms_key_arn MailmanagerIngressPoint#kms_key_arn}.</summary>
        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKeyArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMailmanagerIngressPointIngressPointConfigurationTlsAuthConfigurationTrustStore), fullyQualifiedName: "aws.mailmanagerIngressPoint.MailmanagerIngressPointIngressPointConfigurationTlsAuthConfigurationTrustStore")]
        internal sealed class _Proxy : DeputyBase, aws.MailmanagerIngressPoint.IMailmanagerIngressPointIngressPointConfigurationTlsAuthConfigurationTrustStore
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_ingress_point#ca_content MailmanagerIngressPoint#ca_content}.</summary>
            [JsiiProperty(name: "caContent", typeJson: "{\"primitive\":\"string\"}")]
            public string CaContent
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_ingress_point#crl_content MailmanagerIngressPoint#crl_content}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "crlContent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CrlContent
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/mailmanager_ingress_point#kms_key_arn MailmanagerIngressPoint#kms_key_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKeyArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
