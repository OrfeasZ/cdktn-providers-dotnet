using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MailmanagerIngressPoint
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.mailmanagerIngressPoint.MailmanagerIngressPointNetworkConfigurationPublicNetworkConfiguration")]
    public class MailmanagerIngressPointNetworkConfigurationPublicNetworkConfiguration : aws.MailmanagerIngressPoint.IMailmanagerIngressPointNetworkConfigurationPublicNetworkConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/mailmanager_ingress_point#ip_type MailmanagerIngressPoint#ip_type}.</summary>
        [JsiiProperty(name: "ipType", typeJson: "{\"primitive\":\"string\"}")]
        public string IpType
        {
            get;
            set;
        }
    }
}
