using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2ServiceLinkVirtualInterface
{
    [JsiiInterface(nativeType: typeof(IDataAwsEc2ServiceLinkVirtualInterfaceFilter), fullyQualifiedName: "aws.dataAwsEc2ServiceLinkVirtualInterface.DataAwsEc2ServiceLinkVirtualInterfaceFilter")]
    public interface IDataAwsEc2ServiceLinkVirtualInterfaceFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/ec2_service_link_virtual_interface#name DataAwsEc2ServiceLinkVirtualInterface#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/ec2_service_link_virtual_interface#values DataAwsEc2ServiceLinkVirtualInterface#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsEc2ServiceLinkVirtualInterfaceFilter), fullyQualifiedName: "aws.dataAwsEc2ServiceLinkVirtualInterface.DataAwsEc2ServiceLinkVirtualInterfaceFilter")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsEc2ServiceLinkVirtualInterface.IDataAwsEc2ServiceLinkVirtualInterfaceFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/ec2_service_link_virtual_interface#name DataAwsEc2ServiceLinkVirtualInterface#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/ec2_service_link_virtual_interface#values DataAwsEc2ServiceLinkVirtualInterface#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
