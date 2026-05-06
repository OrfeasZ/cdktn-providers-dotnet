using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseExascaleDbStorageVaults
{
    [JsiiInterface(nativeType: typeof(IDataOciDatabaseExascaleDbStorageVaultsConfig), fullyQualifiedName: "oci.dataOciDatabaseExascaleDbStorageVaults.DataOciDatabaseExascaleDbStorageVaultsConfig")]
    public interface IDataOciDatabaseExascaleDbStorageVaultsConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_exascale_db_storage_vaults#compartment_id DataOciDatabaseExascaleDbStorageVaults#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string CompartmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_exascale_db_storage_vaults#attached_shape_attributes DataOciDatabaseExascaleDbStorageVaults#attached_shape_attributes}.</summary>
        [JsiiProperty(name: "attachedShapeAttributes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AttachedShapeAttributes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_exascale_db_storage_vaults#attached_shape_attributes_not_equal_to DataOciDatabaseExascaleDbStorageVaults#attached_shape_attributes_not_equal_to}.</summary>
        [JsiiProperty(name: "attachedShapeAttributesNotEqualTo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AttachedShapeAttributesNotEqualTo
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_exascale_db_storage_vaults#cluster_placement_group_id DataOciDatabaseExascaleDbStorageVaults#cluster_placement_group_id}.</summary>
        [JsiiProperty(name: "clusterPlacementGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClusterPlacementGroupId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_exascale_db_storage_vaults#display_name DataOciDatabaseExascaleDbStorageVaults#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_exascale_db_storage_vaults#exadata_infrastructure_id DataOciDatabaseExascaleDbStorageVaults#exadata_infrastructure_id}.</summary>
        [JsiiProperty(name: "exadataInfrastructureId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExadataInfrastructureId
        {
            get
            {
                return null;
            }
        }

        /// <summary>filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_exascale_db_storage_vaults#filter DataOciDatabaseExascaleDbStorageVaults#filter}
        /// </remarks>
        [JsiiProperty(name: "filter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciDatabaseExascaleDbStorageVaults.DataOciDatabaseExascaleDbStorageVaultsFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Filter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_exascale_db_storage_vaults#id DataOciDatabaseExascaleDbStorageVaults#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_exascale_db_storage_vaults#state DataOciDatabaseExascaleDbStorageVaults#state}.</summary>
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? State
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_exascale_db_storage_vaults#vm_cluster_count_greater_than_or_equal_to DataOciDatabaseExascaleDbStorageVaults#vm_cluster_count_greater_than_or_equal_to}.</summary>
        [JsiiProperty(name: "vmClusterCountGreaterThanOrEqualTo", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? VmClusterCountGreaterThanOrEqualTo
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_exascale_db_storage_vaults#vm_cluster_count_less_than_or_equal_to DataOciDatabaseExascaleDbStorageVaults#vm_cluster_count_less_than_or_equal_to}.</summary>
        [JsiiProperty(name: "vmClusterCountLessThanOrEqualTo", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? VmClusterCountLessThanOrEqualTo
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataOciDatabaseExascaleDbStorageVaultsConfig), fullyQualifiedName: "oci.dataOciDatabaseExascaleDbStorageVaults.DataOciDatabaseExascaleDbStorageVaultsConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciDatabaseExascaleDbStorageVaults.IDataOciDatabaseExascaleDbStorageVaultsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_exascale_db_storage_vaults#compartment_id DataOciDatabaseExascaleDbStorageVaults#compartment_id}.</summary>
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string CompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_exascale_db_storage_vaults#attached_shape_attributes DataOciDatabaseExascaleDbStorageVaults#attached_shape_attributes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "attachedShapeAttributes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AttachedShapeAttributes
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_exascale_db_storage_vaults#attached_shape_attributes_not_equal_to DataOciDatabaseExascaleDbStorageVaults#attached_shape_attributes_not_equal_to}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "attachedShapeAttributesNotEqualTo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AttachedShapeAttributesNotEqualTo
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_exascale_db_storage_vaults#cluster_placement_group_id DataOciDatabaseExascaleDbStorageVaults#cluster_placement_group_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "clusterPlacementGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClusterPlacementGroupId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_exascale_db_storage_vaults#display_name DataOciDatabaseExascaleDbStorageVaults#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_exascale_db_storage_vaults#exadata_infrastructure_id DataOciDatabaseExascaleDbStorageVaults#exadata_infrastructure_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "exadataInfrastructureId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExadataInfrastructureId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_exascale_db_storage_vaults#filter DataOciDatabaseExascaleDbStorageVaults#filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciDatabaseExascaleDbStorageVaults.DataOciDatabaseExascaleDbStorageVaultsFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Filter
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_exascale_db_storage_vaults#id DataOciDatabaseExascaleDbStorageVaults#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_exascale_db_storage_vaults#state DataOciDatabaseExascaleDbStorageVaults#state}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? State
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_exascale_db_storage_vaults#vm_cluster_count_greater_than_or_equal_to DataOciDatabaseExascaleDbStorageVaults#vm_cluster_count_greater_than_or_equal_to}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vmClusterCountGreaterThanOrEqualTo", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? VmClusterCountGreaterThanOrEqualTo
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_exascale_db_storage_vaults#vm_cluster_count_less_than_or_equal_to DataOciDatabaseExascaleDbStorageVaults#vm_cluster_count_less_than_or_equal_to}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vmClusterCountLessThanOrEqualTo", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? VmClusterCountLessThanOrEqualTo
            {
                get => GetInstanceProperty<double?>();
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
