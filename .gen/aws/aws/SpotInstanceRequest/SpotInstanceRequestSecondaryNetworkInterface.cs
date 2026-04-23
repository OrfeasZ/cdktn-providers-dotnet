using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SpotInstanceRequest
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.spotInstanceRequest.SpotInstanceRequestSecondaryNetworkInterface")]
    public class SpotInstanceRequestSecondaryNetworkInterface : aws.SpotInstanceRequest.ISpotInstanceRequestSecondaryNetworkInterface
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/spot_instance_request#network_card_index SpotInstanceRequest#network_card_index}.</summary>
        [JsiiProperty(name: "networkCardIndex", typeJson: "{\"primitive\":\"number\"}")]
        public double NetworkCardIndex
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/spot_instance_request#secondary_subnet_id SpotInstanceRequest#secondary_subnet_id}.</summary>
        [JsiiProperty(name: "secondarySubnetId", typeJson: "{\"primitive\":\"string\"}")]
        public string SecondarySubnetId
        {
            get;
            set;
        }

        private object? _deleteOnTermination;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/spot_instance_request#delete_on_termination SpotInstanceRequest#delete_on_termination}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/spot_instance_request#device_index SpotInstanceRequest#device_index}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deviceIndex", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DeviceIndex
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/spot_instance_request#interface_type SpotInstanceRequest#interface_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "interfaceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InterfaceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/spot_instance_request#private_ip_address_count SpotInstanceRequest#private_ip_address_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateIpAddressCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PrivateIpAddressCount
        {
            get;
            set;
        }
    }
}
