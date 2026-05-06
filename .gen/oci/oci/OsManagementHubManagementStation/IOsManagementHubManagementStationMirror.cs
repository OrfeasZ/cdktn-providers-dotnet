using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagementStation
{
    [JsiiInterface(nativeType: typeof(IOsManagementHubManagementStationMirror), fullyQualifiedName: "oci.osManagementHubManagementStation.OsManagementHubManagementStationMirror")]
    public interface IOsManagementHubManagementStationMirror
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_management_station#directory OsManagementHubManagementStation#directory}.</summary>
        [JsiiProperty(name: "directory", typeJson: "{\"primitive\":\"string\"}")]
        string Directory
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_management_station#port OsManagementHubManagementStation#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"string\"}")]
        string Port
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_management_station#sslport OsManagementHubManagementStation#sslport}.</summary>
        [JsiiProperty(name: "sslport", typeJson: "{\"primitive\":\"string\"}")]
        string Sslport
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_management_station#is_sslverify_enabled OsManagementHubManagementStation#is_sslverify_enabled}.</summary>
        [JsiiProperty(name: "isSslverifyEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsSslverifyEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_management_station#sslcert OsManagementHubManagementStation#sslcert}.</summary>
        [JsiiProperty(name: "sslcert", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Sslcert
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOsManagementHubManagementStationMirror), fullyQualifiedName: "oci.osManagementHubManagementStation.OsManagementHubManagementStationMirror")]
        internal sealed class _Proxy : DeputyBase, oci.OsManagementHubManagementStation.IOsManagementHubManagementStationMirror
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_management_station#directory OsManagementHubManagementStation#directory}.</summary>
            [JsiiProperty(name: "directory", typeJson: "{\"primitive\":\"string\"}")]
            public string Directory
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_management_station#port OsManagementHubManagementStation#port}.</summary>
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"string\"}")]
            public string Port
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_management_station#sslport OsManagementHubManagementStation#sslport}.</summary>
            [JsiiProperty(name: "sslport", typeJson: "{\"primitive\":\"string\"}")]
            public string Sslport
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_management_station#is_sslverify_enabled OsManagementHubManagementStation#is_sslverify_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isSslverifyEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsSslverifyEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_management_station#sslcert OsManagementHubManagementStation#sslcert}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sslcert", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Sslcert
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
