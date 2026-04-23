using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Instance
{
    [JsiiInterface(nativeType: typeof(IInstanceSecondaryNetworkInterface), fullyQualifiedName: "aws.instance.InstanceSecondaryNetworkInterface")]
    public interface IInstanceSecondaryNetworkInterface
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/instance#network_card_index Instance#network_card_index}.</summary>
        [JsiiProperty(name: "networkCardIndex", typeJson: "{\"primitive\":\"number\"}")]
        double NetworkCardIndex
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/instance#secondary_subnet_id Instance#secondary_subnet_id}.</summary>
        [JsiiProperty(name: "secondarySubnetId", typeJson: "{\"primitive\":\"string\"}")]
        string SecondarySubnetId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/instance#delete_on_termination Instance#delete_on_termination}.</summary>
        [JsiiProperty(name: "deleteOnTermination", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DeleteOnTermination
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/instance#device_index Instance#device_index}.</summary>
        [JsiiProperty(name: "deviceIndex", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DeviceIndex
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/instance#interface_type Instance#interface_type}.</summary>
        [JsiiProperty(name: "interfaceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InterfaceType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/instance#private_ip_address_count Instance#private_ip_address_count}.</summary>
        [JsiiProperty(name: "privateIpAddressCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PrivateIpAddressCount
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IInstanceSecondaryNetworkInterface), fullyQualifiedName: "aws.instance.InstanceSecondaryNetworkInterface")]
        internal sealed class _Proxy : DeputyBase, aws.Instance.IInstanceSecondaryNetworkInterface
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/instance#network_card_index Instance#network_card_index}.</summary>
            [JsiiProperty(name: "networkCardIndex", typeJson: "{\"primitive\":\"number\"}")]
            public double NetworkCardIndex
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/instance#secondary_subnet_id Instance#secondary_subnet_id}.</summary>
            [JsiiProperty(name: "secondarySubnetId", typeJson: "{\"primitive\":\"string\"}")]
            public string SecondarySubnetId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/instance#delete_on_termination Instance#delete_on_termination}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deleteOnTermination", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DeleteOnTermination
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/instance#device_index Instance#device_index}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deviceIndex", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DeviceIndex
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/instance#interface_type Instance#interface_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "interfaceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InterfaceType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/instance#private_ip_address_count Instance#private_ip_address_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "privateIpAddressCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PrivateIpAddressCount
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
