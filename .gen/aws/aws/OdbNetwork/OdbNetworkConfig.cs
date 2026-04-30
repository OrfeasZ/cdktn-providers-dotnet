using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OdbNetwork
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.odbNetwork.OdbNetworkConfig")]
    public class OdbNetworkConfig : aws.OdbNetwork.IOdbNetworkConfig
    {
        /// <summary>The AZ ID of the AZ where the ODB network is located.</summary>
        /// <remarks>
        /// Changing this will force terraform to create new resource.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#availability_zone_id OdbNetwork#availability_zone_id}
        /// </remarks>
        [JsiiProperty(name: "availabilityZoneId", typeJson: "{\"primitive\":\"string\"}")]
        public string AvailabilityZoneId
        {
            get;
            set;
        }

        /// <summary>The CIDR range of the backup subnet for the ODB network.</summary>
        /// <remarks>
        /// Changing this will force terraform to create new resource.
        /// Constraints:
        ///
        /// <list type="bullet">
        /// <description>Must not overlap with the CIDR range of the client subnet.</description>
        /// <description>Must not overlap with the CIDR ranges of the VPCs that are connected to the
        /// ODB network.</description>
        /// <description>Must not use the following CIDR ranges that are reserved by OCI:</description>
        /// <description>100.106.0.0/16 and 100.107.0.0/16</description>
        /// <description>169.254.0.0/16</description>
        /// <description>224.0.0.0 - 239.255.255.255</description>
        /// <description>240.0.0.0 - 255.255.255.255</description>
        /// </list>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#backup_subnet_cidr OdbNetwork#backup_subnet_cidr}
        /// </remarks>
        [JsiiProperty(name: "backupSubnetCidr", typeJson: "{\"primitive\":\"string\"}")]
        public string BackupSubnetCidr
        {
            get;
            set;
        }

        /// <summary>The CIDR notation for the network resource.</summary>
        /// <remarks>
        /// Changing this will force terraform to create new resource.
        /// Constraints:
        ///
        /// <list type="bullet">
        /// <description>Must not overlap with the CIDR range of the backup subnet.</description>
        /// <description>Must not overlap with the CIDR ranges of the VPCs that are connected to the
        /// ODB network.</description>
        /// <description>Must not use the following CIDR ranges that are reserved by OCI:</description>
        /// <description>100.106.0.0/16 and 100.107.0.0/16</description>
        /// <description>169.254.0.0/16</description>
        /// <description>224.0.0.0 - 239.255.255.255</description>
        /// <description>240.0.0.0 - 255.255.255.255</description>
        /// </list>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#client_subnet_cidr OdbNetwork#client_subnet_cidr}
        /// </remarks>
        [JsiiProperty(name: "clientSubnetCidr", typeJson: "{\"primitive\":\"string\"}")]
        public string ClientSubnetCidr
        {
            get;
            set;
        }

        /// <summary>The user-friendly name for the odb network. Changing this will force terraform to create a new resource.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#display_name OdbNetwork#display_name}
        /// </remarks>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public string DisplayName
        {
            get;
            set;
        }

        /// <summary>Specifies the configuration for Amazon S3 access from the ODB network.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#s3_access OdbNetwork#s3_access}
        /// </remarks>
        [JsiiProperty(name: "s3Access", typeJson: "{\"primitive\":\"string\"}")]
        public string S3Access
        {
            get;
            set;
        }

        /// <summary>Specifies the configuration for Zero-ETL access from the ODB network.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#zero_etl_access OdbNetwork#zero_etl_access}
        /// </remarks>
        [JsiiProperty(name: "zeroEtlAccess", typeJson: "{\"primitive\":\"string\"}")]
        public string ZeroEtlAccess
        {
            get;
            set;
        }

        /// <summary>The name of the Availability Zone (AZ) where the odb network is located.</summary>
        /// <remarks>
        /// Changing this will force terraform to create new resource
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#availability_zone OdbNetwork#availability_zone}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "availabilityZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AvailabilityZone
        {
            get;
            set;
        }

        /// <summary>The list of regions enabled for cross-region restore in the ODB network.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#cross_region_s3_restore_sources_access OdbNetwork#cross_region_s3_restore_sources_access}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "crossRegionS3RestoreSourcesAccess", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? CrossRegionS3RestoreSourcesAccess
        {
            get;
            set;
        }

        /// <summary>The name of the custom domain that the network is located. custom_domain_name and default_dns_prefix both can't be given.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#custom_domain_name OdbNetwork#custom_domain_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customDomainName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CustomDomainName
        {
            get;
            set;
        }

        /// <summary>The default DNS prefix for the network resource. Changing this will force terraform to create new resource.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#default_dns_prefix OdbNetwork#default_dns_prefix}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "defaultDnsPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultDnsPrefix
        {
            get;
            set;
        }

        private object? _deleteAssociatedResources;

        /// <summary>If set to true deletes associated OCI resources. Default false.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#delete_associated_resources OdbNetwork#delete_associated_resources}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "deleteAssociatedResources", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? DeleteAssociatedResources
        {
            get => _deleteAssociatedResources;
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
                _deleteAssociatedResources = value;
            }
        }

        /// <summary>Specifies the configuration for Amazon KMS access from the ODB network.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#kms_access OdbNetwork#kms_access}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kmsAccess", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsAccess
        {
            get;
            set;
        }

        /// <summary>Specifies the endpoint policy for Amazon KMS access from the ODB network.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#kms_policy_document OdbNetwork#kms_policy_document}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kmsPolicyDocument", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsPolicyDocument
        {
            get;
            set;
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#region OdbNetwork#region}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Region
        {
            get;
            set;
        }

        /// <summary>Specifies the endpoint policy for Amazon S3 access from the ODB network.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#s3_policy_document OdbNetwork#s3_policy_document}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3PolicyDocument", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? S3PolicyDocument
        {
            get;
            set;
        }

        /// <summary>Specifies the configuration for Amazon STS access from the ODB network.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#sts_access OdbNetwork#sts_access}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stsAccess", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StsAccess
        {
            get;
            set;
        }

        /// <summary>Specifies the endpoint policy for Amazon STS access from the ODB network.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#sts_policy_document OdbNetwork#sts_policy_document}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stsPolicyDocument", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StsPolicyDocument
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#tags OdbNetwork#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_network#timeouts OdbNetwork#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.odbNetwork.OdbNetworkTimeouts\"}", isOptional: true)]
        public aws.OdbNetwork.IOdbNetworkTimeouts? Timeouts
        {
            get;
            set;
        }

        private object? _connection;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
        public object? Connection
        {
            get => _connection;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.ISSHProvisionerConnection cast_cd4240:
                            break;
                        case Io.Cdktn.IWinrmProvisionerConnection cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.ISSHProvisionerConnection).FullName}, {typeof(Io.Cdktn.IWinrmProvisionerConnection).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _connection = value;
            }
        }

        private object? _count;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
        public object? Count
        {
            get => _count;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case double cast_cd4240:
                            break;
                        case byte cast_cd4240:
                            break;
                        case decimal cast_cd4240:
                            break;
                        case float cast_cd4240:
                            break;
                        case int cast_cd4240:
                            break;
                        case long cast_cd4240:
                            break;
                        case sbyte cast_cd4240:
                            break;
                        case short cast_cd4240:
                            break;
                        case uint cast_cd4240:
                            break;
                        case ulong cast_cd4240:
                            break;
                        case ushort cast_cd4240:
                            break;
                        case Io.Cdktn.TerraformCount cast_cd4240:
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: double, {typeof(Io.Cdktn.TerraformCount).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _count = value;
            }
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public Io.Cdktn.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
        public Io.Cdktn.ITerraformIterator? ForEach
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
        public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
        public Io.Cdktn.TerraformProvider? Provider
        {
            get;
            set;
        }

        private object[]? _provisioners;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
        public object[]? Provisioners
        {
            get => _provisioners;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    for (var __idx_cd4240 = 0 ; __idx_cd4240 < value.Length ; __idx_cd4240++)
                    {
                        switch (value[__idx_cd4240])
                        {
                            case Io.Cdktn.IFileProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.ILocalExecProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.IRemoteExecProvisioner cast_e9c63e:
                                break;
                            case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_e9c63e:
                                // Not enough information to type-check...
                                break;
                            case null:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received null", nameof(value));
                            default:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received {value[__idx_cd4240].GetType().FullName}", nameof(value));
                        }
                    }
                }
                _provisioners = value;
            }
        }
    }
}
