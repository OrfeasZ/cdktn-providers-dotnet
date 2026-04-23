using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkInterface
{
    [JsiiByValue(fqn: "aws.networkInterface.NetworkInterfaceEnaSrdSpecificationEnaSrdUdpSpecification")]
    public class NetworkInterfaceEnaSrdSpecificationEnaSrdUdpSpecification : aws.NetworkInterface.INetworkInterfaceEnaSrdSpecificationEnaSrdUdpSpecification
    {
        private object? _enaSrdUdpEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/network_interface#ena_srd_udp_enabled NetworkInterface#ena_srd_udp_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enaSrdUdpEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? EnaSrdUdpEnabled
        {
            get => _enaSrdUdpEnabled;
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
                _enaSrdUdpEnabled = value;
            }
        }
    }
}
