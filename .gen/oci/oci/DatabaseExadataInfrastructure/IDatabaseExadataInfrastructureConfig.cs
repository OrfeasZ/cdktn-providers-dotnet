using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseExadataInfrastructure
{
    [JsiiInterface(nativeType: typeof(IDatabaseExadataInfrastructureConfig), fullyQualifiedName: "oci.databaseExadataInfrastructure.DatabaseExadataInfrastructureConfig")]
    public interface IDatabaseExadataInfrastructureConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#admin_network_cidr DatabaseExadataInfrastructure#admin_network_cidr}.</summary>
        [JsiiProperty(name: "adminNetworkCidr", typeJson: "{\"primitive\":\"string\"}")]
        string AdminNetworkCidr
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#cloud_control_plane_server1 DatabaseExadataInfrastructure#cloud_control_plane_server1}.</summary>
        [JsiiProperty(name: "cloudControlPlaneServer1", typeJson: "{\"primitive\":\"string\"}")]
        string CloudControlPlaneServer1
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#cloud_control_plane_server2 DatabaseExadataInfrastructure#cloud_control_plane_server2}.</summary>
        [JsiiProperty(name: "cloudControlPlaneServer2", typeJson: "{\"primitive\":\"string\"}")]
        string CloudControlPlaneServer2
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#compartment_id DatabaseExadataInfrastructure#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string CompartmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#display_name DatabaseExadataInfrastructure#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#dns_server DatabaseExadataInfrastructure#dns_server}.</summary>
        [JsiiProperty(name: "dnsServer", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] DnsServer
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#gateway DatabaseExadataInfrastructure#gateway}.</summary>
        [JsiiProperty(name: "gateway", typeJson: "{\"primitive\":\"string\"}")]
        string Gateway
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#infini_band_network_cidr DatabaseExadataInfrastructure#infini_band_network_cidr}.</summary>
        [JsiiProperty(name: "infiniBandNetworkCidr", typeJson: "{\"primitive\":\"string\"}")]
        string InfiniBandNetworkCidr
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#netmask DatabaseExadataInfrastructure#netmask}.</summary>
        [JsiiProperty(name: "netmask", typeJson: "{\"primitive\":\"string\"}")]
        string Netmask
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#ntp_server DatabaseExadataInfrastructure#ntp_server}.</summary>
        [JsiiProperty(name: "ntpServer", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] NtpServer
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#shape DatabaseExadataInfrastructure#shape}.</summary>
        [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}")]
        string Shape
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#time_zone DatabaseExadataInfrastructure#time_zone}.</summary>
        [JsiiProperty(name: "timeZone", typeJson: "{\"primitive\":\"string\"}")]
        string TimeZone
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#activation_file DatabaseExadataInfrastructure#activation_file}.</summary>
        [JsiiProperty(name: "activationFile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ActivationFile
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#additional_storage_count DatabaseExadataInfrastructure#additional_storage_count}.</summary>
        [JsiiProperty(name: "additionalStorageCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AdditionalStorageCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#compute_count DatabaseExadataInfrastructure#compute_count}.</summary>
        [JsiiProperty(name: "computeCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ComputeCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>contacts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#contacts DatabaseExadataInfrastructure#contacts}
        /// </remarks>
        [JsiiProperty(name: "contacts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseExadataInfrastructure.DatabaseExadataInfrastructureContacts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Contacts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#corporate_proxy DatabaseExadataInfrastructure#corporate_proxy}.</summary>
        [JsiiProperty(name: "corporateProxy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CorporateProxy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#create_async DatabaseExadataInfrastructure#create_async}.</summary>
        [JsiiProperty(name: "createAsync", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CreateAsync
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#database_server_type DatabaseExadataInfrastructure#database_server_type}.</summary>
        [JsiiProperty(name: "databaseServerType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DatabaseServerType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#defined_tags DatabaseExadataInfrastructure#defined_tags}.</summary>
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#freeform_tags DatabaseExadataInfrastructure#freeform_tags}.</summary>
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#id DatabaseExadataInfrastructure#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#is_cps_offline_report_enabled DatabaseExadataInfrastructure#is_cps_offline_report_enabled}.</summary>
        [JsiiProperty(name: "isCpsOfflineReportEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsCpsOfflineReportEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#is_multi_rack_deployment DatabaseExadataInfrastructure#is_multi_rack_deployment}.</summary>
        [JsiiProperty(name: "isMultiRackDeployment", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsMultiRackDeployment
        {
            get
            {
                return null;
            }
        }

        /// <summary>maintenance_window block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#maintenance_window DatabaseExadataInfrastructure#maintenance_window}
        /// </remarks>
        [JsiiProperty(name: "maintenanceWindow", typeJson: "{\"fqn\":\"oci.databaseExadataInfrastructure.DatabaseExadataInfrastructureMaintenanceWindow\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseExadataInfrastructure.IDatabaseExadataInfrastructureMaintenanceWindow? MaintenanceWindow
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#multi_rack_configuration_file DatabaseExadataInfrastructure#multi_rack_configuration_file}.</summary>
        [JsiiProperty(name: "multiRackConfigurationFile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MultiRackConfigurationFile
        {
            get
            {
                return null;
            }
        }

        /// <summary>network_bonding_mode_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#network_bonding_mode_details DatabaseExadataInfrastructure#network_bonding_mode_details}
        /// </remarks>
        [JsiiProperty(name: "networkBondingModeDetails", typeJson: "{\"fqn\":\"oci.databaseExadataInfrastructure.DatabaseExadataInfrastructureNetworkBondingModeDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseExadataInfrastructure.IDatabaseExadataInfrastructureNetworkBondingModeDetails? NetworkBondingModeDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#storage_count DatabaseExadataInfrastructure#storage_count}.</summary>
        [JsiiProperty(name: "storageCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? StorageCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#storage_server_type DatabaseExadataInfrastructure#storage_server_type}.</summary>
        [JsiiProperty(name: "storageServerType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StorageServerType
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#timeouts DatabaseExadataInfrastructure#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseExadataInfrastructure.DatabaseExadataInfrastructureTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseExadataInfrastructure.IDatabaseExadataInfrastructureTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseExadataInfrastructureConfig), fullyQualifiedName: "oci.databaseExadataInfrastructure.DatabaseExadataInfrastructureConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseExadataInfrastructure.IDatabaseExadataInfrastructureConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#admin_network_cidr DatabaseExadataInfrastructure#admin_network_cidr}.</summary>
            [JsiiProperty(name: "adminNetworkCidr", typeJson: "{\"primitive\":\"string\"}")]
            public string AdminNetworkCidr
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#cloud_control_plane_server1 DatabaseExadataInfrastructure#cloud_control_plane_server1}.</summary>
            [JsiiProperty(name: "cloudControlPlaneServer1", typeJson: "{\"primitive\":\"string\"}")]
            public string CloudControlPlaneServer1
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#cloud_control_plane_server2 DatabaseExadataInfrastructure#cloud_control_plane_server2}.</summary>
            [JsiiProperty(name: "cloudControlPlaneServer2", typeJson: "{\"primitive\":\"string\"}")]
            public string CloudControlPlaneServer2
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#compartment_id DatabaseExadataInfrastructure#compartment_id}.</summary>
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string CompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#display_name DatabaseExadataInfrastructure#display_name}.</summary>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#dns_server DatabaseExadataInfrastructure#dns_server}.</summary>
            [JsiiProperty(name: "dnsServer", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] DnsServer
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#gateway DatabaseExadataInfrastructure#gateway}.</summary>
            [JsiiProperty(name: "gateway", typeJson: "{\"primitive\":\"string\"}")]
            public string Gateway
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#infini_band_network_cidr DatabaseExadataInfrastructure#infini_band_network_cidr}.</summary>
            [JsiiProperty(name: "infiniBandNetworkCidr", typeJson: "{\"primitive\":\"string\"}")]
            public string InfiniBandNetworkCidr
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#netmask DatabaseExadataInfrastructure#netmask}.</summary>
            [JsiiProperty(name: "netmask", typeJson: "{\"primitive\":\"string\"}")]
            public string Netmask
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#ntp_server DatabaseExadataInfrastructure#ntp_server}.</summary>
            [JsiiProperty(name: "ntpServer", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] NtpServer
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#shape DatabaseExadataInfrastructure#shape}.</summary>
            [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}")]
            public string Shape
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#time_zone DatabaseExadataInfrastructure#time_zone}.</summary>
            [JsiiProperty(name: "timeZone", typeJson: "{\"primitive\":\"string\"}")]
            public string TimeZone
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#activation_file DatabaseExadataInfrastructure#activation_file}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "activationFile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ActivationFile
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#additional_storage_count DatabaseExadataInfrastructure#additional_storage_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "additionalStorageCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AdditionalStorageCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#compute_count DatabaseExadataInfrastructure#compute_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "computeCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ComputeCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>contacts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#contacts DatabaseExadataInfrastructure#contacts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "contacts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseExadataInfrastructure.DatabaseExadataInfrastructureContacts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Contacts
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#corporate_proxy DatabaseExadataInfrastructure#corporate_proxy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "corporateProxy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CorporateProxy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#create_async DatabaseExadataInfrastructure#create_async}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "createAsync", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? CreateAsync
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#database_server_type DatabaseExadataInfrastructure#database_server_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "databaseServerType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DatabaseServerType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#defined_tags DatabaseExadataInfrastructure#defined_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? DefinedTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#freeform_tags DatabaseExadataInfrastructure#freeform_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? FreeformTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#id DatabaseExadataInfrastructure#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#is_cps_offline_report_enabled DatabaseExadataInfrastructure#is_cps_offline_report_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isCpsOfflineReportEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsCpsOfflineReportEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#is_multi_rack_deployment DatabaseExadataInfrastructure#is_multi_rack_deployment}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isMultiRackDeployment", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsMultiRackDeployment
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>maintenance_window block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#maintenance_window DatabaseExadataInfrastructure#maintenance_window}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maintenanceWindow", typeJson: "{\"fqn\":\"oci.databaseExadataInfrastructure.DatabaseExadataInfrastructureMaintenanceWindow\"}", isOptional: true)]
            public oci.DatabaseExadataInfrastructure.IDatabaseExadataInfrastructureMaintenanceWindow? MaintenanceWindow
            {
                get => GetInstanceProperty<oci.DatabaseExadataInfrastructure.IDatabaseExadataInfrastructureMaintenanceWindow?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#multi_rack_configuration_file DatabaseExadataInfrastructure#multi_rack_configuration_file}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "multiRackConfigurationFile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MultiRackConfigurationFile
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>network_bonding_mode_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#network_bonding_mode_details DatabaseExadataInfrastructure#network_bonding_mode_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "networkBondingModeDetails", typeJson: "{\"fqn\":\"oci.databaseExadataInfrastructure.DatabaseExadataInfrastructureNetworkBondingModeDetails\"}", isOptional: true)]
            public oci.DatabaseExadataInfrastructure.IDatabaseExadataInfrastructureNetworkBondingModeDetails? NetworkBondingModeDetails
            {
                get => GetInstanceProperty<oci.DatabaseExadataInfrastructure.IDatabaseExadataInfrastructureNetworkBondingModeDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#storage_count DatabaseExadataInfrastructure#storage_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "storageCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? StorageCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#storage_server_type DatabaseExadataInfrastructure#storage_server_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "storageServerType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StorageServerType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#timeouts DatabaseExadataInfrastructure#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseExadataInfrastructure.DatabaseExadataInfrastructureTimeouts\"}", isOptional: true)]
            public oci.DatabaseExadataInfrastructure.IDatabaseExadataInfrastructureTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.DatabaseExadataInfrastructure.IDatabaseExadataInfrastructureTimeouts?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
