using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Instance
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.instance.InstancePrimaryNetworkInterface")]
    public class InstancePrimaryNetworkInterface : aws.Instance.IInstancePrimaryNetworkInterface
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/instance#network_interface_id Instance#network_interface_id}.</summary>
        [JsiiProperty(name: "networkInterfaceId", typeJson: "{\"primitive\":\"string\"}")]
        public string NetworkInterfaceId
        {
            get;
            set;
        }
    }
}
