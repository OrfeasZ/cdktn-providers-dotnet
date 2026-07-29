using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2Hosts
{
    [JsiiInterface(nativeType: typeof(IDataAwsEc2HostsFilter), fullyQualifiedName: "aws.dataAwsEc2Hosts.DataAwsEc2HostsFilter")]
    public interface IDataAwsEc2HostsFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.0/docs/data-sources/ec2_hosts#name DataAwsEc2Hosts#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.0/docs/data-sources/ec2_hosts#values DataAwsEc2Hosts#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsEc2HostsFilter), fullyQualifiedName: "aws.dataAwsEc2Hosts.DataAwsEc2HostsFilter")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsEc2Hosts.IDataAwsEc2HostsFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.0/docs/data-sources/ec2_hosts#name DataAwsEc2Hosts#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.0/docs/data-sources/ec2_hosts#values DataAwsEc2Hosts#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
