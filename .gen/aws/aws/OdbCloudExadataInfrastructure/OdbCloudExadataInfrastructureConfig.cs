using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OdbCloudExadataInfrastructure
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.odbCloudExadataInfrastructure.OdbCloudExadataInfrastructureConfig")]
    public class OdbCloudExadataInfrastructureConfig : aws.OdbCloudExadataInfrastructure.IOdbCloudExadataInfrastructureConfig
    {
        /// <summary>The AZ ID of the AZ where the Exadata infrastructure is located.</summary>
        /// <remarks>
        /// Changing this will force terraform to create new resource
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/odb_cloud_exadata_infrastructure#availability_zone_id OdbCloudExadataInfrastructure#availability_zone_id}
        /// </remarks>
        [JsiiProperty(name: "availabilityZoneId", typeJson: "{\"primitive\":\"string\"}")]
        public string AvailabilityZoneId
        {
            get;
            set;
        }

        /// <summary>The user-friendly name for the Exadata infrastructure. Changing this will force terraform to create a new resource.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/odb_cloud_exadata_infrastructure#display_name OdbCloudExadataInfrastructure#display_name}
        /// </remarks>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public string DisplayName
        {
            get;
            set;
        }

        /// <summary>The model name of the Exadata infrastructure. Changing this will force terraform to create new resource.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/odb_cloud_exadata_infrastructure#shape OdbCloudExadataInfrastructure#shape}
        /// </remarks>
        [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}")]
        public string Shape
        {
            get;
            set;
        }

        /// <summary>The name of the Availability Zone (AZ) where the Exadata infrastructure is located.</summary>
        /// <remarks>
        /// Changing this will force terraform to create new resource
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/odb_cloud_exadata_infrastructure#availability_zone OdbCloudExadataInfrastructure#availability_zone}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "availabilityZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AvailabilityZone
        {
            get;
            set;
        }

        /// <summary>The number of compute instances that the Exadata infrastructure is located.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/odb_cloud_exadata_infrastructure#compute_count OdbCloudExadataInfrastructure#compute_count}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "computeCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ComputeCount
        {
            get;
            set;
        }

        private object? _customerContactsToSendToOci;

        /// <summary>The email addresses of contacts to receive notification from Oracle about maintenance updates for the Exadata infrastructure.</summary>
        /// <remarks>
        /// Changing this will force terraform to create new resource
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/odb_cloud_exadata_infrastructure#customer_contacts_to_send_to_oci OdbCloudExadataInfrastructure#customer_contacts_to_send_to_oci}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customerContactsToSendToOci", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.odbCloudExadataInfrastructure.OdbCloudExadataInfrastructureCustomerContactsToSendToOci\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CustomerContactsToSendToOci
        {
            get => _customerContactsToSendToOci;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.OdbCloudExadataInfrastructure.IOdbCloudExadataInfrastructureCustomerContactsToSendToOci[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.OdbCloudExadataInfrastructure.IOdbCloudExadataInfrastructureCustomerContactsToSendToOci).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _customerContactsToSendToOci = value;
            }
        }

        /// <summary>The database server model type of the Exadata infrastructure.</summary>
        /// <remarks>
        /// For the list of valid model names, use the ListDbSystemShapes operation
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/odb_cloud_exadata_infrastructure#database_server_type OdbCloudExadataInfrastructure#database_server_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "databaseServerType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DatabaseServerType
        {
            get;
            set;
        }

        private object? _maintenanceWindow;

        /// <summary>maintenance_window block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/odb_cloud_exadata_infrastructure#maintenance_window OdbCloudExadataInfrastructure#maintenance_window}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maintenanceWindow", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.odbCloudExadataInfrastructure.OdbCloudExadataInfrastructureMaintenanceWindow\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? MaintenanceWindow
        {
            get => _maintenanceWindow;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.OdbCloudExadataInfrastructure.IOdbCloudExadataInfrastructureMaintenanceWindow[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.OdbCloudExadataInfrastructure.IOdbCloudExadataInfrastructureMaintenanceWindow).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _maintenanceWindow = value;
            }
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/odb_cloud_exadata_infrastructure#region OdbCloudExadataInfrastructure#region}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Region
        {
            get;
            set;
        }

        /// <summary>TThe number of storage servers that are activated for the Exadata infrastructure.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/odb_cloud_exadata_infrastructure#storage_count OdbCloudExadataInfrastructure#storage_count}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "storageCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? StorageCount
        {
            get;
            set;
        }

        /// <summary>The storage server model type of the Exadata infrastructure.</summary>
        /// <remarks>
        /// For the list of valid model names, use the ListDbSystemShapes operation
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/odb_cloud_exadata_infrastructure#storage_server_type OdbCloudExadataInfrastructure#storage_server_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "storageServerType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StorageServerType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/odb_cloud_exadata_infrastructure#tags OdbCloudExadataInfrastructure#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/odb_cloud_exadata_infrastructure#timeouts OdbCloudExadataInfrastructure#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.odbCloudExadataInfrastructure.OdbCloudExadataInfrastructureTimeouts\"}", isOptional: true)]
        public aws.OdbCloudExadataInfrastructure.IOdbCloudExadataInfrastructureTimeouts? Timeouts
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
