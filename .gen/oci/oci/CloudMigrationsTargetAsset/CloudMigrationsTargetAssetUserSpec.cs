using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudMigrationsTargetAsset
{
    [JsiiByValue(fqn: "oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpec")]
    public class CloudMigrationsTargetAssetUserSpec : oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpec
    {
        /// <summary>agent_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#agent_config CloudMigrationsTargetAsset#agent_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "agentConfig", typeJson: "{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecAgentConfig\"}", isOptional: true)]
        public oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecAgentConfig? AgentConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#availability_domain CloudMigrationsTargetAsset#availability_domain}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AvailabilityDomain
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#capacity_reservation_id CloudMigrationsTargetAsset#capacity_reservation_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "capacityReservationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CapacityReservationId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#compartment_id CloudMigrationsTargetAsset#compartment_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CompartmentId
        {
            get;
            set;
        }

        /// <summary>create_vnic_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#create_vnic_details CloudMigrationsTargetAsset#create_vnic_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "createVnicDetails", typeJson: "{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecCreateVnicDetails\"}", isOptional: true)]
        public oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecCreateVnicDetails? CreateVnicDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#dedicated_vm_host_id CloudMigrationsTargetAsset#dedicated_vm_host_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dedicatedVmHostId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DedicatedVmHostId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#defined_tags CloudMigrationsTargetAsset#defined_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#display_name CloudMigrationsTargetAsset#display_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DisplayName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#fault_domain CloudMigrationsTargetAsset#fault_domain}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "faultDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FaultDomain
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#freeform_tags CloudMigrationsTargetAsset#freeform_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#hostname_label CloudMigrationsTargetAsset#hostname_label}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hostnameLabel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HostnameLabel
        {
            get;
            set;
        }

        /// <summary>instance_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#instance_options CloudMigrationsTargetAsset#instance_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "instanceOptions", typeJson: "{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecInstanceOptions\"}", isOptional: true)]
        public oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecInstanceOptions? InstanceOptions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#ipxe_script CloudMigrationsTargetAsset#ipxe_script}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipxeScript", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IpxeScript
        {
            get;
            set;
        }

        private object? _isPvEncryptionInTransitEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#is_pv_encryption_in_transit_enabled CloudMigrationsTargetAsset#is_pv_encryption_in_transit_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isPvEncryptionInTransitEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsPvEncryptionInTransitEnabled
        {
            get => _isPvEncryptionInTransitEnabled;
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
                _isPvEncryptionInTransitEnabled = value;
            }
        }

        /// <summary>preemptible_instance_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#preemptible_instance_config CloudMigrationsTargetAsset#preemptible_instance_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "preemptibleInstanceConfig", typeJson: "{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecPreemptibleInstanceConfig\"}", isOptional: true)]
        public oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecPreemptibleInstanceConfig? PreemptibleInstanceConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#shape CloudMigrationsTargetAsset#shape}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Shape
        {
            get;
            set;
        }

        /// <summary>shape_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#shape_config CloudMigrationsTargetAsset#shape_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "shapeConfig", typeJson: "{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecShapeConfig\"}", isOptional: true)]
        public oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecShapeConfig? ShapeConfig
        {
            get;
            set;
        }

        /// <summary>source_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#source_details CloudMigrationsTargetAsset#source_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sourceDetails", typeJson: "{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecSourceDetails\"}", isOptional: true)]
        public oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecSourceDetails? SourceDetails
        {
            get;
            set;
        }
    }
}
