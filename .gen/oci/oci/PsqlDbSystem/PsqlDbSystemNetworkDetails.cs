using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.PsqlDbSystem
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.psqlDbSystem.PsqlDbSystemNetworkDetails")]
    public class PsqlDbSystemNetworkDetails : oci.PsqlDbSystem.IPsqlDbSystemNetworkDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_db_system#subnet_id PsqlDbSystem#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public string SubnetId
        {
            get;
            set;
        }

        private object? _isReaderEndpointEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_db_system#is_reader_endpoint_enabled PsqlDbSystem#is_reader_endpoint_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isReaderEndpointEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsReaderEndpointEnabled
        {
            get => _isReaderEndpointEnabled;
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
                _isReaderEndpointEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_db_system#nsg_ids PsqlDbSystem#nsg_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? NsgIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_db_system#primary_db_endpoint_private_ip PsqlDbSystem#primary_db_endpoint_private_ip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "primaryDbEndpointPrivateIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrimaryDbEndpointPrivateIp
        {
            get;
            set;
        }
    }
}
