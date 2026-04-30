using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TransferWebApp
{
    [JsiiByValue(fqn: "aws.transferWebApp.TransferWebAppIdentityProviderDetailsIdentityCenterConfig")]
    public class TransferWebAppIdentityProviderDetailsIdentityCenterConfig : aws.TransferWebApp.ITransferWebAppIdentityProviderDetailsIdentityCenterConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/transfer_web_app#instance_arn TransferWebApp#instance_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InstanceArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/transfer_web_app#role TransferWebApp#role}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Role
        {
            get;
            set;
        }
    }
}
