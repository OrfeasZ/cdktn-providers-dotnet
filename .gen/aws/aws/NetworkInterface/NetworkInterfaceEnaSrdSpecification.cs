using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkInterface
{
    [JsiiByValue(fqn: "aws.networkInterface.NetworkInterfaceEnaSrdSpecification")]
    public class NetworkInterfaceEnaSrdSpecification : aws.NetworkInterface.INetworkInterfaceEnaSrdSpecification
    {
        private object? _enaSrdEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/network_interface#ena_srd_enabled NetworkInterface#ena_srd_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enaSrdEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? EnaSrdEnabled
        {
            get => _enaSrdEnabled;
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
                _enaSrdEnabled = value;
            }
        }

        /// <summary>ena_srd_udp_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/network_interface#ena_srd_udp_specification NetworkInterface#ena_srd_udp_specification}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enaSrdUdpSpecification", typeJson: "{\"fqn\":\"aws.networkInterface.NetworkInterfaceEnaSrdSpecificationEnaSrdUdpSpecification\"}", isOptional: true)]
        public aws.NetworkInterface.INetworkInterfaceEnaSrdSpecificationEnaSrdUdpSpecification? EnaSrdUdpSpecification
        {
            get;
            set;
        }
    }
}
