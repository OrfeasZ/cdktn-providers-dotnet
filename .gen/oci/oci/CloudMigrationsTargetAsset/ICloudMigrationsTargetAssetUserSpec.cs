using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudMigrationsTargetAsset
{
    [JsiiInterface(nativeType: typeof(ICloudMigrationsTargetAssetUserSpec), fullyQualifiedName: "oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpec")]
    public interface ICloudMigrationsTargetAssetUserSpec
    {
        /// <summary>agent_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#agent_config CloudMigrationsTargetAsset#agent_config}
        /// </remarks>
        [JsiiProperty(name: "agentConfig", typeJson: "{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecAgentConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecAgentConfig? AgentConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#availability_domain CloudMigrationsTargetAsset#availability_domain}.</summary>
        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AvailabilityDomain
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#capacity_reservation_id CloudMigrationsTargetAsset#capacity_reservation_id}.</summary>
        [JsiiProperty(name: "capacityReservationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CapacityReservationId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#compartment_id CloudMigrationsTargetAsset#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CompartmentId
        {
            get
            {
                return null;
            }
        }

        /// <summary>create_vnic_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#create_vnic_details CloudMigrationsTargetAsset#create_vnic_details}
        /// </remarks>
        [JsiiProperty(name: "createVnicDetails", typeJson: "{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecCreateVnicDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecCreateVnicDetails? CreateVnicDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#dedicated_vm_host_id CloudMigrationsTargetAsset#dedicated_vm_host_id}.</summary>
        [JsiiProperty(name: "dedicatedVmHostId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DedicatedVmHostId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#defined_tags CloudMigrationsTargetAsset#defined_tags}.</summary>
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#display_name CloudMigrationsTargetAsset#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#fault_domain CloudMigrationsTargetAsset#fault_domain}.</summary>
        [JsiiProperty(name: "faultDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FaultDomain
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#freeform_tags CloudMigrationsTargetAsset#freeform_tags}.</summary>
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#hostname_label CloudMigrationsTargetAsset#hostname_label}.</summary>
        [JsiiProperty(name: "hostnameLabel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HostnameLabel
        {
            get
            {
                return null;
            }
        }

        /// <summary>instance_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#instance_options CloudMigrationsTargetAsset#instance_options}
        /// </remarks>
        [JsiiProperty(name: "instanceOptions", typeJson: "{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecInstanceOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecInstanceOptions? InstanceOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#ipxe_script CloudMigrationsTargetAsset#ipxe_script}.</summary>
        [JsiiProperty(name: "ipxeScript", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IpxeScript
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#is_pv_encryption_in_transit_enabled CloudMigrationsTargetAsset#is_pv_encryption_in_transit_enabled}.</summary>
        [JsiiProperty(name: "isPvEncryptionInTransitEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsPvEncryptionInTransitEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>preemptible_instance_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#preemptible_instance_config CloudMigrationsTargetAsset#preemptible_instance_config}
        /// </remarks>
        [JsiiProperty(name: "preemptibleInstanceConfig", typeJson: "{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecPreemptibleInstanceConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecPreemptibleInstanceConfig? PreemptibleInstanceConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#shape CloudMigrationsTargetAsset#shape}.</summary>
        [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Shape
        {
            get
            {
                return null;
            }
        }

        /// <summary>shape_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#shape_config CloudMigrationsTargetAsset#shape_config}
        /// </remarks>
        [JsiiProperty(name: "shapeConfig", typeJson: "{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecShapeConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecShapeConfig? ShapeConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>source_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#source_details CloudMigrationsTargetAsset#source_details}
        /// </remarks>
        [JsiiProperty(name: "sourceDetails", typeJson: "{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecSourceDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecSourceDetails? SourceDetails
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudMigrationsTargetAssetUserSpec), fullyQualifiedName: "oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpec")]
        internal sealed class _Proxy : DeputyBase, oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpec
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>agent_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#agent_config CloudMigrationsTargetAsset#agent_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "agentConfig", typeJson: "{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecAgentConfig\"}", isOptional: true)]
            public oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecAgentConfig? AgentConfig
            {
                get => GetInstanceProperty<oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecAgentConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#availability_domain CloudMigrationsTargetAsset#availability_domain}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AvailabilityDomain
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#capacity_reservation_id CloudMigrationsTargetAsset#capacity_reservation_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "capacityReservationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CapacityReservationId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#compartment_id CloudMigrationsTargetAsset#compartment_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CompartmentId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>create_vnic_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#create_vnic_details CloudMigrationsTargetAsset#create_vnic_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "createVnicDetails", typeJson: "{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecCreateVnicDetails\"}", isOptional: true)]
            public oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecCreateVnicDetails? CreateVnicDetails
            {
                get => GetInstanceProperty<oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecCreateVnicDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#dedicated_vm_host_id CloudMigrationsTargetAsset#dedicated_vm_host_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dedicatedVmHostId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DedicatedVmHostId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#defined_tags CloudMigrationsTargetAsset#defined_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? DefinedTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#display_name CloudMigrationsTargetAsset#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#fault_domain CloudMigrationsTargetAsset#fault_domain}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "faultDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FaultDomain
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#freeform_tags CloudMigrationsTargetAsset#freeform_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? FreeformTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#hostname_label CloudMigrationsTargetAsset#hostname_label}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hostnameLabel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HostnameLabel
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>instance_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#instance_options CloudMigrationsTargetAsset#instance_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "instanceOptions", typeJson: "{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecInstanceOptions\"}", isOptional: true)]
            public oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecInstanceOptions? InstanceOptions
            {
                get => GetInstanceProperty<oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecInstanceOptions?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#ipxe_script CloudMigrationsTargetAsset#ipxe_script}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipxeScript", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IpxeScript
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#is_pv_encryption_in_transit_enabled CloudMigrationsTargetAsset#is_pv_encryption_in_transit_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isPvEncryptionInTransitEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsPvEncryptionInTransitEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>preemptible_instance_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#preemptible_instance_config CloudMigrationsTargetAsset#preemptible_instance_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "preemptibleInstanceConfig", typeJson: "{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecPreemptibleInstanceConfig\"}", isOptional: true)]
            public oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecPreemptibleInstanceConfig? PreemptibleInstanceConfig
            {
                get => GetInstanceProperty<oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecPreemptibleInstanceConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#shape CloudMigrationsTargetAsset#shape}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Shape
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>shape_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#shape_config CloudMigrationsTargetAsset#shape_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "shapeConfig", typeJson: "{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecShapeConfig\"}", isOptional: true)]
            public oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecShapeConfig? ShapeConfig
            {
                get => GetInstanceProperty<oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecShapeConfig?>();
            }

            /// <summary>source_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#source_details CloudMigrationsTargetAsset#source_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sourceDetails", typeJson: "{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecSourceDetails\"}", isOptional: true)]
            public oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecSourceDetails? SourceDetails
            {
                get => GetInstanceProperty<oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecSourceDetails?>();
            }
        }
    }
}
