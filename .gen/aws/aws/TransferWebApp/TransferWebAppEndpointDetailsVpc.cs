using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TransferWebApp
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.transferWebApp.TransferWebAppEndpointDetailsVpc")]
    public class TransferWebAppEndpointDetailsVpc : aws.TransferWebApp.ITransferWebAppEndpointDetailsVpc
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/transfer_web_app#subnet_ids TransferWebApp#subnet_ids}.</summary>
        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] SubnetIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/transfer_web_app#vpc_id TransferWebApp#vpc_id}.</summary>
        [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}")]
        public string VpcId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/transfer_web_app#security_group_ids TransferWebApp#security_group_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SecurityGroupIds
        {
            get;
            set;
        }
    }
}
