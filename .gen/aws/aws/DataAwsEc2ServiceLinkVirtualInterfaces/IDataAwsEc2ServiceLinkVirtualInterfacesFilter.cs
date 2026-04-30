using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2ServiceLinkVirtualInterfaces
{
    [JsiiInterface(nativeType: typeof(IDataAwsEc2ServiceLinkVirtualInterfacesFilter), fullyQualifiedName: "aws.dataAwsEc2ServiceLinkVirtualInterfaces.DataAwsEc2ServiceLinkVirtualInterfacesFilter")]
    public interface IDataAwsEc2ServiceLinkVirtualInterfacesFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/ec2_service_link_virtual_interfaces#name DataAwsEc2ServiceLinkVirtualInterfaces#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/ec2_service_link_virtual_interfaces#values DataAwsEc2ServiceLinkVirtualInterfaces#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsEc2ServiceLinkVirtualInterfacesFilter), fullyQualifiedName: "aws.dataAwsEc2ServiceLinkVirtualInterfaces.DataAwsEc2ServiceLinkVirtualInterfacesFilter")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsEc2ServiceLinkVirtualInterfaces.IDataAwsEc2ServiceLinkVirtualInterfacesFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/ec2_service_link_virtual_interfaces#name DataAwsEc2ServiceLinkVirtualInterfaces#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/ec2_service_link_virtual_interfaces#values DataAwsEc2ServiceLinkVirtualInterfaces#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
