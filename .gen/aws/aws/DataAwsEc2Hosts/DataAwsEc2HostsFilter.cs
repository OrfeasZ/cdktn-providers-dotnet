using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2Hosts
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dataAwsEc2Hosts.DataAwsEc2HostsFilter")]
    public class DataAwsEc2HostsFilter : aws.DataAwsEc2Hosts.IDataAwsEc2HostsFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/data-sources/ec2_hosts#name DataAwsEc2Hosts#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/data-sources/ec2_hosts#values DataAwsEc2Hosts#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Values
        {
            get;
            set;
        }
    }
}
