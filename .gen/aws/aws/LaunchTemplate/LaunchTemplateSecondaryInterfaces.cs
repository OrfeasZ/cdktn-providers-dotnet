using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LaunchTemplate
{
    [JsiiByValue(fqn: "aws.launchTemplate.LaunchTemplateSecondaryInterfaces")]
    public class LaunchTemplateSecondaryInterfaces : aws.LaunchTemplate.ILaunchTemplateSecondaryInterfaces
    {
        private object? _deleteOnTermination;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/launch_template#delete_on_termination LaunchTemplate#delete_on_termination}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/launch_template#device_index LaunchTemplate#device_index}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deviceIndex", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DeviceIndex
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/launch_template#interface_type LaunchTemplate#interface_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "interfaceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InterfaceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/launch_template#network_card_index LaunchTemplate#network_card_index}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "networkCardIndex", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NetworkCardIndex
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/launch_template#private_ip_address_count LaunchTemplate#private_ip_address_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateIpAddressCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PrivateIpAddressCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/launch_template#private_ip_addresses LaunchTemplate#private_ip_addresses}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateIpAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? PrivateIpAddresses
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/launch_template#secondary_subnet_id LaunchTemplate#secondary_subnet_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "secondarySubnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecondarySubnetId
        {
            get;
            set;
        }
    }
}
