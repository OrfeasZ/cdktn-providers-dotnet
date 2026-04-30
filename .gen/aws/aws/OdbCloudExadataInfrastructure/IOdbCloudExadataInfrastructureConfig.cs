using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OdbCloudExadataInfrastructure
{
    [JsiiInterface(nativeType: typeof(IOdbCloudExadataInfrastructureConfig), fullyQualifiedName: "aws.odbCloudExadataInfrastructure.OdbCloudExadataInfrastructureConfig")]
    public interface IOdbCloudExadataInfrastructureConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The AZ ID of the AZ where the Exadata infrastructure is located.</summary>
        /// <remarks>
        /// Changing this will force terraform to create new resource
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_exadata_infrastructure#availability_zone_id OdbCloudExadataInfrastructure#availability_zone_id}
        /// </remarks>
        [JsiiProperty(name: "availabilityZoneId", typeJson: "{\"primitive\":\"string\"}")]
        string AvailabilityZoneId
        {
            get;
        }

        /// <summary>The user-friendly name for the Exadata infrastructure. Changing this will force terraform to create a new resource.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_exadata_infrastructure#display_name OdbCloudExadataInfrastructure#display_name}
        /// </remarks>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>The model name of the Exadata infrastructure. Changing this will force terraform to create new resource.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_exadata_infrastructure#shape OdbCloudExadataInfrastructure#shape}
        /// </remarks>
        [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}")]
        string Shape
        {
            get;
        }

        /// <summary>The name of the Availability Zone (AZ) where the Exadata infrastructure is located.</summary>
        /// <remarks>
        /// Changing this will force terraform to create new resource
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_exadata_infrastructure#availability_zone OdbCloudExadataInfrastructure#availability_zone}
        /// </remarks>
        [JsiiProperty(name: "availabilityZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AvailabilityZone
        {
            get
            {
                return null;
            }
        }

        /// <summary>The number of compute instances that the Exadata infrastructure is located.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_exadata_infrastructure#compute_count OdbCloudExadataInfrastructure#compute_count}
        /// </remarks>
        [JsiiProperty(name: "computeCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ComputeCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>The email addresses of contacts to receive notification from Oracle about maintenance updates for the Exadata infrastructure.</summary>
        /// <remarks>
        /// Changing this will force terraform to create new resource
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_exadata_infrastructure#customer_contacts_to_send_to_oci OdbCloudExadataInfrastructure#customer_contacts_to_send_to_oci}
        /// </remarks>
        [JsiiProperty(name: "customerContactsToSendToOci", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.odbCloudExadataInfrastructure.OdbCloudExadataInfrastructureCustomerContactsToSendToOci\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CustomerContactsToSendToOci
        {
            get
            {
                return null;
            }
        }

        /// <summary>The database server model type of the Exadata infrastructure.</summary>
        /// <remarks>
        /// For the list of valid model names, use the ListDbSystemShapes operation
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_exadata_infrastructure#database_server_type OdbCloudExadataInfrastructure#database_server_type}
        /// </remarks>
        [JsiiProperty(name: "databaseServerType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DatabaseServerType
        {
            get
            {
                return null;
            }
        }

        /// <summary>maintenance_window block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_exadata_infrastructure#maintenance_window OdbCloudExadataInfrastructure#maintenance_window}
        /// </remarks>
        [JsiiProperty(name: "maintenanceWindow", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.odbCloudExadataInfrastructure.OdbCloudExadataInfrastructureMaintenanceWindow\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MaintenanceWindow
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_exadata_infrastructure#region OdbCloudExadataInfrastructure#region}
        /// </remarks>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Region
        {
            get
            {
                return null;
            }
        }

        /// <summary>TThe number of storage servers that are activated for the Exadata infrastructure.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_exadata_infrastructure#storage_count OdbCloudExadataInfrastructure#storage_count}
        /// </remarks>
        [JsiiProperty(name: "storageCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? StorageCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>The storage server model type of the Exadata infrastructure.</summary>
        /// <remarks>
        /// For the list of valid model names, use the ListDbSystemShapes operation
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_exadata_infrastructure#storage_server_type OdbCloudExadataInfrastructure#storage_server_type}
        /// </remarks>
        [JsiiProperty(name: "storageServerType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StorageServerType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_exadata_infrastructure#tags OdbCloudExadataInfrastructure#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_exadata_infrastructure#timeouts OdbCloudExadataInfrastructure#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.odbCloudExadataInfrastructure.OdbCloudExadataInfrastructureTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.OdbCloudExadataInfrastructure.IOdbCloudExadataInfrastructureTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOdbCloudExadataInfrastructureConfig), fullyQualifiedName: "aws.odbCloudExadataInfrastructure.OdbCloudExadataInfrastructureConfig")]
        internal sealed class _Proxy : DeputyBase, aws.OdbCloudExadataInfrastructure.IOdbCloudExadataInfrastructureConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The AZ ID of the AZ where the Exadata infrastructure is located.</summary>
            /// <remarks>
            /// Changing this will force terraform to create new resource
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_exadata_infrastructure#availability_zone_id OdbCloudExadataInfrastructure#availability_zone_id}
            /// </remarks>
            [JsiiProperty(name: "availabilityZoneId", typeJson: "{\"primitive\":\"string\"}")]
            public string AvailabilityZoneId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The user-friendly name for the Exadata infrastructure. Changing this will force terraform to create a new resource.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_exadata_infrastructure#display_name OdbCloudExadataInfrastructure#display_name}
            /// </remarks>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The model name of the Exadata infrastructure. Changing this will force terraform to create new resource.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_exadata_infrastructure#shape OdbCloudExadataInfrastructure#shape}
            /// </remarks>
            [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}")]
            public string Shape
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The name of the Availability Zone (AZ) where the Exadata infrastructure is located.</summary>
            /// <remarks>
            /// Changing this will force terraform to create new resource
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_exadata_infrastructure#availability_zone OdbCloudExadataInfrastructure#availability_zone}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "availabilityZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AvailabilityZone
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The number of compute instances that the Exadata infrastructure is located.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_exadata_infrastructure#compute_count OdbCloudExadataInfrastructure#compute_count}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "computeCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ComputeCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The email addresses of contacts to receive notification from Oracle about maintenance updates for the Exadata infrastructure.</summary>
            /// <remarks>
            /// Changing this will force terraform to create new resource
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_exadata_infrastructure#customer_contacts_to_send_to_oci OdbCloudExadataInfrastructure#customer_contacts_to_send_to_oci}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customerContactsToSendToOci", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.odbCloudExadataInfrastructure.OdbCloudExadataInfrastructureCustomerContactsToSendToOci\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CustomerContactsToSendToOci
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The database server model type of the Exadata infrastructure.</summary>
            /// <remarks>
            /// For the list of valid model names, use the ListDbSystemShapes operation
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_exadata_infrastructure#database_server_type OdbCloudExadataInfrastructure#database_server_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "databaseServerType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DatabaseServerType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>maintenance_window block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_exadata_infrastructure#maintenance_window OdbCloudExadataInfrastructure#maintenance_window}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maintenanceWindow", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.odbCloudExadataInfrastructure.OdbCloudExadataInfrastructureMaintenanceWindow\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? MaintenanceWindow
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_exadata_infrastructure#region OdbCloudExadataInfrastructure#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>TThe number of storage servers that are activated for the Exadata infrastructure.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_exadata_infrastructure#storage_count OdbCloudExadataInfrastructure#storage_count}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storageCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? StorageCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The storage server model type of the Exadata infrastructure.</summary>
            /// <remarks>
            /// For the list of valid model names, use the ListDbSystemShapes operation
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_exadata_infrastructure#storage_server_type OdbCloudExadataInfrastructure#storage_server_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storageServerType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StorageServerType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_exadata_infrastructure#tags OdbCloudExadataInfrastructure#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/odb_cloud_exadata_infrastructure#timeouts OdbCloudExadataInfrastructure#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.odbCloudExadataInfrastructure.OdbCloudExadataInfrastructureTimeouts\"}", isOptional: true)]
            public aws.OdbCloudExadataInfrastructure.IOdbCloudExadataInfrastructureTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.OdbCloudExadataInfrastructure.IOdbCloudExadataInfrastructureTimeouts?>();
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
