using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagementStation
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.osManagementHubManagementStation.OsManagementHubManagementStationMirror")]
    public class OsManagementHubManagementStationMirror : oci.OsManagementHubManagementStation.IOsManagementHubManagementStationMirror
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_management_station#directory OsManagementHubManagementStation#directory}.</summary>
        [JsiiProperty(name: "directory", typeJson: "{\"primitive\":\"string\"}")]
        public string Directory
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_management_station#port OsManagementHubManagementStation#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"string\"}")]
        public string Port
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_management_station#sslport OsManagementHubManagementStation#sslport}.</summary>
        [JsiiProperty(name: "sslport", typeJson: "{\"primitive\":\"string\"}")]
        public string Sslport
        {
            get;
            set;
        }

        private object? _isSslverifyEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_management_station#is_sslverify_enabled OsManagementHubManagementStation#is_sslverify_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isSslverifyEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsSslverifyEnabled
        {
            get => _isSslverifyEnabled;
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
                _isSslverifyEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_management_station#sslcert OsManagementHubManagementStation#sslcert}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sslcert", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Sslcert
        {
            get;
            set;
        }
    }
}
