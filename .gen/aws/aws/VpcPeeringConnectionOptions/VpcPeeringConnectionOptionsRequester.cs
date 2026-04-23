using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpcPeeringConnectionOptions
{
    [JsiiByValue(fqn: "aws.vpcPeeringConnectionOptions.VpcPeeringConnectionOptionsRequester")]
    public class VpcPeeringConnectionOptionsRequester : aws.VpcPeeringConnectionOptions.IVpcPeeringConnectionOptionsRequester
    {
        private object? _allowRemoteVpcDnsResolution;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/vpc_peering_connection_options#allow_remote_vpc_dns_resolution VpcPeeringConnectionOptions#allow_remote_vpc_dns_resolution}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowRemoteVpcDnsResolution", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? AllowRemoteVpcDnsResolution
        {
            get => _allowRemoteVpcDnsResolution;
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
                _allowRemoteVpcDnsResolution = value;
            }
        }
    }
}
