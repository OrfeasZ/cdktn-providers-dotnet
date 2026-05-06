using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.VisualBuilderVbInstance
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.visualBuilderVbInstance.VisualBuilderVbInstanceNetworkEndpointDetails")]
    public class VisualBuilderVbInstanceNetworkEndpointDetails : oci.VisualBuilderVbInstance.IVisualBuilderVbInstanceNetworkEndpointDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/visual_builder_vb_instance#network_endpoint_type VisualBuilderVbInstance#network_endpoint_type}.</summary>
        [JsiiProperty(name: "networkEndpointType", typeJson: "{\"primitive\":\"string\"}")]
        public string NetworkEndpointType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/visual_builder_vb_instance#allowlisted_http_ips VisualBuilderVbInstance#allowlisted_http_ips}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowlistedHttpIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AllowlistedHttpIps
        {
            get;
            set;
        }

        private object? _allowlistedHttpVcns;

        /// <summary>allowlisted_http_vcns block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/visual_builder_vb_instance#allowlisted_http_vcns VisualBuilderVbInstance#allowlisted_http_vcns}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allowlistedHttpVcns", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.visualBuilderVbInstance.VisualBuilderVbInstanceNetworkEndpointDetailsAllowlistedHttpVcns\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AllowlistedHttpVcns
        {
            get => _allowlistedHttpVcns;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.VisualBuilderVbInstance.IVisualBuilderVbInstanceNetworkEndpointDetailsAllowlistedHttpVcns[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.VisualBuilderVbInstance.IVisualBuilderVbInstanceNetworkEndpointDetailsAllowlistedHttpVcns).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _allowlistedHttpVcns = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/visual_builder_vb_instance#network_security_group_ids VisualBuilderVbInstance#network_security_group_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "networkSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? NetworkSecurityGroupIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/visual_builder_vb_instance#private_endpoint_ip VisualBuilderVbInstance#private_endpoint_ip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateEndpointIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivateEndpointIp
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/visual_builder_vb_instance#subnet_id VisualBuilderVbInstance#subnet_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SubnetId
        {
            get;
            set;
        }
    }
}
