using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TransferWebApp
{
    [JsiiByValue(fqn: "aws.transferWebApp.TransferWebAppWebAppUnits")]
    public class TransferWebAppWebAppUnits : aws.TransferWebApp.ITransferWebAppWebAppUnits
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/transfer_web_app#provisioned TransferWebApp#provisioned}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "provisioned", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Provisioned
        {
            get;
            set;
        }
    }
}
