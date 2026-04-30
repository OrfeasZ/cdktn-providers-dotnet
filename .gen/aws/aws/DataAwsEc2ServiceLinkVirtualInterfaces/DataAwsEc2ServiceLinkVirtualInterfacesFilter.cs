using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2ServiceLinkVirtualInterfaces
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dataAwsEc2ServiceLinkVirtualInterfaces.DataAwsEc2ServiceLinkVirtualInterfacesFilter")]
    public class DataAwsEc2ServiceLinkVirtualInterfacesFilter : aws.DataAwsEc2ServiceLinkVirtualInterfaces.IDataAwsEc2ServiceLinkVirtualInterfacesFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/ec2_service_link_virtual_interfaces#name DataAwsEc2ServiceLinkVirtualInterfaces#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/ec2_service_link_virtual_interfaces#values DataAwsEc2ServiceLinkVirtualInterfaces#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Values
        {
            get;
            set;
        }
    }
}
