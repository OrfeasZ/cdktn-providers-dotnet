using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataccInfrastructure
{
    [JsiiInterface(nativeType: typeof(IDataccInfrastructureConfig), fullyQualifiedName: "oci.dataccInfrastructure.DataccInfrastructureConfig")]
    public interface IDataccInfrastructureConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#cloud_control_plane_server1 DataccInfrastructure#cloud_control_plane_server1}.</summary>
        [JsiiProperty(name: "cloudControlPlaneServer1", typeJson: "{\"primitive\":\"string\"}")]
        string CloudControlPlaneServer1
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#cloud_control_plane_server2 DataccInfrastructure#cloud_control_plane_server2}.</summary>
        [JsiiProperty(name: "cloudControlPlaneServer2", typeJson: "{\"primitive\":\"string\"}")]
        string CloudControlPlaneServer2
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#compartment_id DataccInfrastructure#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string CompartmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#display_name DataccInfrastructure#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#dns_servers DataccInfrastructure#dns_servers}.</summary>
        [JsiiProperty(name: "dnsServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] DnsServers
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#gateway DataccInfrastructure#gateway}.</summary>
        [JsiiProperty(name: "gateway", typeJson: "{\"primitive\":\"string\"}")]
        string Gateway
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#netmask DataccInfrastructure#netmask}.</summary>
        [JsiiProperty(name: "netmask", typeJson: "{\"primitive\":\"string\"}")]
        string Netmask
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#ntp_servers DataccInfrastructure#ntp_servers}.</summary>
        [JsiiProperty(name: "ntpServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] NtpServers
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#shape DataccInfrastructure#shape}.</summary>
        [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}")]
        string Shape
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#system_model DataccInfrastructure#system_model}.</summary>
        [JsiiProperty(name: "systemModel", typeJson: "{\"primitive\":\"string\"}")]
        string SystemModel
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#acfs_file_system_storage_in_gbs DataccInfrastructure#acfs_file_system_storage_in_gbs}.</summary>
        [JsiiProperty(name: "acfsFileSystemStorageInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AcfsFileSystemStorageInGbs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#admin_networkcidr DataccInfrastructure#admin_networkcidr}.</summary>
        [JsiiProperty(name: "adminNetworkcidr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AdminNetworkcidr
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#backup_network_bonding_interface DataccInfrastructure#backup_network_bonding_interface}.</summary>
        [JsiiProperty(name: "backupNetworkBondingInterface", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BackupNetworkBondingInterface
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#backup_network_bonding_mode DataccInfrastructure#backup_network_bonding_mode}.</summary>
        [JsiiProperty(name: "backupNetworkBondingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BackupNetworkBondingMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#client_network_bonding_interface DataccInfrastructure#client_network_bonding_interface}.</summary>
        [JsiiProperty(name: "clientNetworkBondingInterface", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientNetworkBondingInterface
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#client_network_bonding_mode DataccInfrastructure#client_network_bonding_mode}.</summary>
        [JsiiProperty(name: "clientNetworkBondingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientNetworkBondingMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>contacts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#contacts DataccInfrastructure#contacts}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DataccInfrastructure.IDataccInfrastructureContacts" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "contacts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataccInfrastructure.DataccInfrastructureContacts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Contacts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#corporate_proxy DataccInfrastructure#corporate_proxy}.</summary>
        [JsiiProperty(name: "corporateProxy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CorporateProxy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#cps_network_bonding_interface DataccInfrastructure#cps_network_bonding_interface}.</summary>
        [JsiiProperty(name: "cpsNetworkBondingInterface", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CpsNetworkBondingInterface
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#cps_network_bonding_mode DataccInfrastructure#cps_network_bonding_mode}.</summary>
        [JsiiProperty(name: "cpsNetworkBondingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CpsNetworkBondingMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#data_disk_percentage DataccInfrastructure#data_disk_percentage}.</summary>
        [JsiiProperty(name: "dataDiskPercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DataDiskPercentage
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#defined_tags DataccInfrastructure#defined_tags}.</summary>
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#description DataccInfrastructure#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#freeform_tags DataccInfrastructure#freeform_tags}.</summary>
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#id DataccInfrastructure#id}.</summary>
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

        /// <summary>maintenance_window block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#maintenance_window DataccInfrastructure#maintenance_window}
        /// </remarks>
        [JsiiProperty(name: "maintenanceWindow", typeJson: "{\"fqn\":\"oci.dataccInfrastructure.DataccInfrastructureMaintenanceWindow\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DataccInfrastructure.IDataccInfrastructureMaintenanceWindow? MaintenanceWindow
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#scale_storage_trigger DataccInfrastructure#scale_storage_trigger}.</summary>
        [JsiiProperty(name: "scaleStorageTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ScaleStorageTrigger
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#timeouts DataccInfrastructure#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.dataccInfrastructure.DataccInfrastructureTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DataccInfrastructure.IDataccInfrastructureTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#vlan_id DataccInfrastructure#vlan_id}.</summary>
        [JsiiProperty(name: "vlanId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VlanId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataccInfrastructureConfig), fullyQualifiedName: "oci.dataccInfrastructure.DataccInfrastructureConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DataccInfrastructure.IDataccInfrastructureConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#cloud_control_plane_server1 DataccInfrastructure#cloud_control_plane_server1}.</summary>
            [JsiiProperty(name: "cloudControlPlaneServer1", typeJson: "{\"primitive\":\"string\"}")]
            public string CloudControlPlaneServer1
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#cloud_control_plane_server2 DataccInfrastructure#cloud_control_plane_server2}.</summary>
            [JsiiProperty(name: "cloudControlPlaneServer2", typeJson: "{\"primitive\":\"string\"}")]
            public string CloudControlPlaneServer2
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#compartment_id DataccInfrastructure#compartment_id}.</summary>
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string CompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#display_name DataccInfrastructure#display_name}.</summary>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#dns_servers DataccInfrastructure#dns_servers}.</summary>
            [JsiiProperty(name: "dnsServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] DnsServers
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#gateway DataccInfrastructure#gateway}.</summary>
            [JsiiProperty(name: "gateway", typeJson: "{\"primitive\":\"string\"}")]
            public string Gateway
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#netmask DataccInfrastructure#netmask}.</summary>
            [JsiiProperty(name: "netmask", typeJson: "{\"primitive\":\"string\"}")]
            public string Netmask
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#ntp_servers DataccInfrastructure#ntp_servers}.</summary>
            [JsiiProperty(name: "ntpServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] NtpServers
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#shape DataccInfrastructure#shape}.</summary>
            [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}")]
            public string Shape
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#system_model DataccInfrastructure#system_model}.</summary>
            [JsiiProperty(name: "systemModel", typeJson: "{\"primitive\":\"string\"}")]
            public string SystemModel
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#acfs_file_system_storage_in_gbs DataccInfrastructure#acfs_file_system_storage_in_gbs}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "acfsFileSystemStorageInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AcfsFileSystemStorageInGbs
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#admin_networkcidr DataccInfrastructure#admin_networkcidr}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "adminNetworkcidr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AdminNetworkcidr
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#backup_network_bonding_interface DataccInfrastructure#backup_network_bonding_interface}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "backupNetworkBondingInterface", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BackupNetworkBondingInterface
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#backup_network_bonding_mode DataccInfrastructure#backup_network_bonding_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "backupNetworkBondingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BackupNetworkBondingMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#client_network_bonding_interface DataccInfrastructure#client_network_bonding_interface}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "clientNetworkBondingInterface", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientNetworkBondingInterface
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#client_network_bonding_mode DataccInfrastructure#client_network_bonding_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "clientNetworkBondingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientNetworkBondingMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>contacts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#contacts DataccInfrastructure#contacts}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DataccInfrastructure.IDataccInfrastructureContacts" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "contacts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataccInfrastructure.DataccInfrastructureContacts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Contacts
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#corporate_proxy DataccInfrastructure#corporate_proxy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "corporateProxy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CorporateProxy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#cps_network_bonding_interface DataccInfrastructure#cps_network_bonding_interface}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cpsNetworkBondingInterface", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CpsNetworkBondingInterface
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#cps_network_bonding_mode DataccInfrastructure#cps_network_bonding_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cpsNetworkBondingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CpsNetworkBondingMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#data_disk_percentage DataccInfrastructure#data_disk_percentage}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dataDiskPercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DataDiskPercentage
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#defined_tags DataccInfrastructure#defined_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? DefinedTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#description DataccInfrastructure#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#freeform_tags DataccInfrastructure#freeform_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? FreeformTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#id DataccInfrastructure#id}.</summary>
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

            /// <summary>maintenance_window block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#maintenance_window DataccInfrastructure#maintenance_window}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maintenanceWindow", typeJson: "{\"fqn\":\"oci.dataccInfrastructure.DataccInfrastructureMaintenanceWindow\"}", isOptional: true)]
            public oci.DataccInfrastructure.IDataccInfrastructureMaintenanceWindow? MaintenanceWindow
            {
                get => GetInstanceProperty<oci.DataccInfrastructure.IDataccInfrastructureMaintenanceWindow?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#scale_storage_trigger DataccInfrastructure#scale_storage_trigger}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scaleStorageTrigger", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ScaleStorageTrigger
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#timeouts DataccInfrastructure#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.dataccInfrastructure.DataccInfrastructureTimeouts\"}", isOptional: true)]
            public oci.DataccInfrastructure.IDataccInfrastructureTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.DataccInfrastructure.IDataccInfrastructureTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/datacc_infrastructure#vlan_id DataccInfrastructure#vlan_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vlanId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VlanId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
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
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
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
