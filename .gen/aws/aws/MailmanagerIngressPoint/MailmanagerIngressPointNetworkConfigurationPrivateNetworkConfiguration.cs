using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MailmanagerIngressPoint
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.mailmanagerIngressPoint.MailmanagerIngressPointNetworkConfigurationPrivateNetworkConfiguration")]
    public class MailmanagerIngressPointNetworkConfigurationPrivateNetworkConfiguration : aws.MailmanagerIngressPoint.IMailmanagerIngressPointNetworkConfigurationPrivateNetworkConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.60.0/docs/resources/mailmanager_ingress_point#vpc_endpoint_id MailmanagerIngressPoint#vpc_endpoint_id}.</summary>
        [JsiiProperty(name: "vpcEndpointId", typeJson: "{\"primitive\":\"string\"}")]
        public string VpcEndpointId
        {
            get;
            set;
        }
    }
}
