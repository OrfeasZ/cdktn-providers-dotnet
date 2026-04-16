using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Instance
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.instance.InstanceSecondaryNetworkInterface")]
    public class InstanceSecondaryNetworkInterface : aws.Instance.IInstanceSecondaryNetworkInterface
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/instance#network_card_index Instance#network_card_index}.</summary>
        [JsiiProperty(name: "networkCardIndex", typeJson: "{\"primitive\":\"number\"}")]
        public double NetworkCardIndex
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/instance#secondary_subnet_id Instance#secondary_subnet_id}.</summary>
        [JsiiProperty(name: "secondarySubnetId", typeJson: "{\"primitive\":\"string\"}")]
        public string SecondarySubnetId
        {
            get;
            set;
        }

        private object? _deleteOnTermination;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/instance#delete_on_termination Instance#delete_on_termination}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deleteOnTermination", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? DeleteOnTermination
        {
            get => _deleteOnTermination;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _deleteOnTermination = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/instance#device_index Instance#device_index}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deviceIndex", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DeviceIndex
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/instance#interface_type Instance#interface_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "interfaceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InterfaceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/instance#private_ip_address_count Instance#private_ip_address_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateIpAddressCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PrivateIpAddressCount
        {
            get;
            set;
        }
    }
}
