using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OcvpSddc
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.ocvpSddc.OcvpSddcInitialConfigurationInitialClusterConfigurations")]
    public class OcvpSddcInitialConfigurationInitialClusterConfigurations : oci.OcvpSddc.IOcvpSddcInitialConfigurationInitialClusterConfigurations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ocvp_sddc#compute_availability_domain OcvpSddc#compute_availability_domain}.</summary>
        [JsiiProperty(name: "computeAvailabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        public string ComputeAvailabilityDomain
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ocvp_sddc#esxi_hosts_count OcvpSddc#esxi_hosts_count}.</summary>
        [JsiiProperty(name: "esxiHostsCount", typeJson: "{\"primitive\":\"number\"}")]
        public double EsxiHostsCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ocvp_sddc#vsphere_type OcvpSddc#vsphere_type}.</summary>
        [JsiiProperty(name: "vsphereType", typeJson: "{\"primitive\":\"string\"}")]
        public string VsphereType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ocvp_sddc#capacity_reservation_id OcvpSddc#capacity_reservation_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "capacityReservationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CapacityReservationId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ocvp_sddc#datastore_cluster_ids OcvpSddc#datastore_cluster_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "datastoreClusterIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? DatastoreClusterIds
        {
            get;
            set;
        }

        private object? _datastores;

        /// <summary>datastores block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ocvp_sddc#datastores OcvpSddc#datastores}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "datastores", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.ocvpSddc.OcvpSddcInitialConfigurationInitialClusterConfigurationsDatastores\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Datastores
        {
            get => _datastores;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.OcvpSddc.IOcvpSddcInitialConfigurationInitialClusterConfigurationsDatastores[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.OcvpSddc.IOcvpSddcInitialConfigurationInitialClusterConfigurationsDatastores).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _datastores = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ocvp_sddc#display_name OcvpSddc#display_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DisplayName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ocvp_sddc#initial_commitment OcvpSddc#initial_commitment}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "initialCommitment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InitialCommitment
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ocvp_sddc#initial_host_ocpu_count OcvpSddc#initial_host_ocpu_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "initialHostOcpuCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? InitialHostOcpuCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ocvp_sddc#initial_host_shape_name OcvpSddc#initial_host_shape_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "initialHostShapeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InitialHostShapeName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ocvp_sddc#instance_display_name_prefix OcvpSddc#instance_display_name_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceDisplayNamePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InstanceDisplayNamePrefix
        {
            get;
            set;
        }

        private object? _isShieldedInstanceEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ocvp_sddc#is_shielded_instance_enabled OcvpSddc#is_shielded_instance_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isShieldedInstanceEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsShieldedInstanceEnabled
        {
            get => _isShieldedInstanceEnabled;
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
                _isShieldedInstanceEnabled = value;
            }
        }

        /// <summary>network_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ocvp_sddc#network_configuration OcvpSddc#network_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkConfiguration", typeJson: "{\"fqn\":\"oci.ocvpSddc.OcvpSddcInitialConfigurationInitialClusterConfigurationsNetworkConfiguration\"}", isOptional: true)]
        public oci.OcvpSddc.IOcvpSddcInitialConfigurationInitialClusterConfigurationsNetworkConfiguration? NetworkConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ocvp_sddc#workload_network_cidr OcvpSddc#workload_network_cidr}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "workloadNetworkCidr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WorkloadNetworkCidr
        {
            get;
            set;
        }
    }
}
