using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2ServiceLinkVirtualInterface
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dataAwsEc2ServiceLinkVirtualInterface.DataAwsEc2ServiceLinkVirtualInterfaceFilter")]
    public class DataAwsEc2ServiceLinkVirtualInterfaceFilter : aws.DataAwsEc2ServiceLinkVirtualInterface.IDataAwsEc2ServiceLinkVirtualInterfaceFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/ec2_service_link_virtual_interface#name DataAwsEc2ServiceLinkVirtualInterface#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/ec2_service_link_virtual_interface#values DataAwsEc2ServiceLinkVirtualInterface#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Values
        {
            get;
            set;
        }
    }
}
