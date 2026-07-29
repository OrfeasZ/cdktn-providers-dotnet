using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudBridgeAsset
{
    [JsiiByValue(fqn: "oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2")]
    public class CloudBridgeAssetAwsEc2 : oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_bridge_asset#architecture CloudBridgeAsset#architecture}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "architecture", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Architecture
        {
            get;
            set;
        }

        private object? _areElasticInferenceAcceleratorsPresent;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_bridge_asset#are_elastic_inference_accelerators_present CloudBridgeAsset#are_elastic_inference_accelerators_present}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "areElasticInferenceAcceleratorsPresent", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? AreElasticInferenceAcceleratorsPresent
        {
            get => _areElasticInferenceAcceleratorsPresent;
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
                _areElasticInferenceAcceleratorsPresent = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_bridge_asset#boot_mode CloudBridgeAsset#boot_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bootMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BootMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_bridge_asset#capacity_reservation_key CloudBridgeAsset#capacity_reservation_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "capacityReservationKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CapacityReservationKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_bridge_asset#image_key CloudBridgeAsset#image_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "imageKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ImageKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_bridge_asset#instance_key CloudBridgeAsset#instance_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InstanceKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_bridge_asset#instance_lifecycle CloudBridgeAsset#instance_lifecycle}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceLifecycle", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InstanceLifecycle
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_bridge_asset#instance_type CloudBridgeAsset#instance_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InstanceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_bridge_asset#ip_address CloudBridgeAsset#ip_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IpAddress
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_bridge_asset#ipv6address CloudBridgeAsset#ipv6address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipv6Address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ipv6Address
        {
            get;
            set;
        }

        private object? _isEnclaveOptions;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_bridge_asset#is_enclave_options CloudBridgeAsset#is_enclave_options}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isEnclaveOptions", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsEnclaveOptions
        {
            get => _isEnclaveOptions;
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
                _isEnclaveOptions = value;
            }
        }

        private object? _isHibernationOptions;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_bridge_asset#is_hibernation_options CloudBridgeAsset#is_hibernation_options}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isHibernationOptions", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsHibernationOptions
        {
            get => _isHibernationOptions;
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
                _isHibernationOptions = value;
            }
        }

        private object? _isSourceDestCheck;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_bridge_asset#is_source_dest_check CloudBridgeAsset#is_source_dest_check}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isSourceDestCheck", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsSourceDestCheck
        {
            get => _isSourceDestCheck;
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
                _isSourceDestCheck = value;
            }
        }

        private object? _isSpotInstance;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_bridge_asset#is_spot_instance CloudBridgeAsset#is_spot_instance}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isSpotInstance", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsSpotInstance
        {
            get => _isSpotInstance;
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
                _isSpotInstance = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_bridge_asset#kernel_key CloudBridgeAsset#kernel_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kernelKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KernelKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_bridge_asset#licenses CloudBridgeAsset#licenses}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "licenses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Licenses
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_bridge_asset#maintenance_options CloudBridgeAsset#maintenance_options}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maintenanceOptions", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaintenanceOptions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_bridge_asset#monitoring CloudBridgeAsset#monitoring}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "monitoring", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Monitoring
        {
            get;
            set;
        }

        private object? _networkInterfaces;

        /// <summary>network_interfaces block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_bridge_asset#network_interfaces CloudBridgeAsset#network_interfaces}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfaces" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkInterfaces", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2NetworkInterfaces\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? NetworkInterfaces
        {
            get => _networkInterfaces;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfaces[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfaces).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _networkInterfaces = value;
            }
        }

        /// <summary>placement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_bridge_asset#placement CloudBridgeAsset#placement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "placement", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2Placement\"}", isOptional: true)]
        public oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2Placement? Placement
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_bridge_asset#private_dns_name CloudBridgeAsset#private_dns_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateDnsName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivateDnsName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_bridge_asset#private_ip_address CloudBridgeAsset#private_ip_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateIpAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivateIpAddress
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_bridge_asset#root_device_name CloudBridgeAsset#root_device_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rootDeviceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RootDeviceName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_bridge_asset#root_device_type CloudBridgeAsset#root_device_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rootDeviceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RootDeviceType
        {
            get;
            set;
        }

        private object? _securityGroups;

        /// <summary>security_groups block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_bridge_asset#security_groups CloudBridgeAsset#security_groups}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2SecurityGroups" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "securityGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2SecurityGroups\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SecurityGroups
        {
            get => _securityGroups;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2SecurityGroups[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2SecurityGroups).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _securityGroups = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_bridge_asset#sriov_net_support CloudBridgeAsset#sriov_net_support}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sriovNetSupport", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SriovNetSupport
        {
            get;
            set;
        }

        /// <summary>state block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_bridge_asset#state CloudBridgeAsset#state}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "state", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2State\"}", isOptional: true)]
        public oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2State? State
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_bridge_asset#subnet_key CloudBridgeAsset#subnet_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subnetKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SubnetKey
        {
            get;
            set;
        }

        private object? _tags;

        /// <summary>tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_bridge_asset#tags CloudBridgeAsset#tags}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2Tags" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2Tags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Tags
        {
            get => _tags;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2Tags[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2Tags).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _tags = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_bridge_asset#time_launch CloudBridgeAsset#time_launch}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeLaunch", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeLaunch
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_bridge_asset#tpm_support CloudBridgeAsset#tpm_support}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tpmSupport", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TpmSupport
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_bridge_asset#virtualization_type CloudBridgeAsset#virtualization_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "virtualizationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VirtualizationType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/cloud_bridge_asset#vpc_key CloudBridgeAsset#vpc_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vpcKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VpcKey
        {
            get;
            set;
        }
    }
}
