using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsBdsInstance
{
    [JsiiByValue(fqn: "oci.bdsBdsInstance.BdsBdsInstanceNetworkConfig")]
    public class BdsBdsInstanceNetworkConfig : oci.BdsBdsInstance.IBdsBdsInstanceNetworkConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance#cidr_block BdsBdsInstance#cidr_block}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cidrBlock", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CidrBlock
        {
            get;
            set;
        }

        private object? _isNatGatewayRequired;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance#is_nat_gateway_required BdsBdsInstance#is_nat_gateway_required}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isNatGatewayRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsNatGatewayRequired
        {
            get => _isNatGatewayRequired;
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
                _isNatGatewayRequired = value;
            }
        }
    }
}
