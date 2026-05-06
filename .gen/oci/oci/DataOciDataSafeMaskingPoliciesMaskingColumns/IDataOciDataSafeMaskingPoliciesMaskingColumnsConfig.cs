using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeMaskingPoliciesMaskingColumns
{
    [JsiiInterface(nativeType: typeof(IDataOciDataSafeMaskingPoliciesMaskingColumnsConfig), fullyQualifiedName: "oci.dataOciDataSafeMaskingPoliciesMaskingColumns.DataOciDataSafeMaskingPoliciesMaskingColumnsConfig")]
    public interface IDataOciDataSafeMaskingPoliciesMaskingColumnsConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_masking_policies_masking_columns#masking_policy_id DataOciDataSafeMaskingPoliciesMaskingColumns#masking_policy_id}.</summary>
        [JsiiProperty(name: "maskingPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        string MaskingPolicyId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_masking_policies_masking_columns#column_name DataOciDataSafeMaskingPoliciesMaskingColumns#column_name}.</summary>
        [JsiiProperty(name: "columnName", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ColumnName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_masking_policies_masking_columns#data_type DataOciDataSafeMaskingPoliciesMaskingColumns#data_type}.</summary>
        [JsiiProperty(name: "dataType", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? DataType
        {
            get
            {
                return null;
            }
        }

        /// <summary>filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_masking_policies_masking_columns#filter DataOciDataSafeMaskingPoliciesMaskingColumns#filter}
        /// </remarks>
        [JsiiProperty(name: "filter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciDataSafeMaskingPoliciesMaskingColumns.DataOciDataSafeMaskingPoliciesMaskingColumnsFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Filter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_masking_policies_masking_columns#id DataOciDataSafeMaskingPoliciesMaskingColumns#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_masking_policies_masking_columns#is_masking_enabled DataOciDataSafeMaskingPoliciesMaskingColumns#is_masking_enabled}.</summary>
        [JsiiProperty(name: "isMaskingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsMaskingEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_masking_policies_masking_columns#is_seed_required DataOciDataSafeMaskingPoliciesMaskingColumns#is_seed_required}.</summary>
        [JsiiProperty(name: "isSeedRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsSeedRequired
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_masking_policies_masking_columns#masking_column_group DataOciDataSafeMaskingPoliciesMaskingColumns#masking_column_group}.</summary>
        [JsiiProperty(name: "maskingColumnGroup", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? MaskingColumnGroup
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_masking_policies_masking_columns#masking_column_lifecycle_state DataOciDataSafeMaskingPoliciesMaskingColumns#masking_column_lifecycle_state}.</summary>
        [JsiiProperty(name: "maskingColumnLifecycleState", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaskingColumnLifecycleState
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_masking_policies_masking_columns#object DataOciDataSafeMaskingPoliciesMaskingColumns#object}.</summary>
        [JsiiProperty(name: "object", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Object
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_masking_policies_masking_columns#object_type DataOciDataSafeMaskingPoliciesMaskingColumns#object_type}.</summary>
        [JsiiProperty(name: "objectType", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ObjectType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_masking_policies_masking_columns#schema_name DataOciDataSafeMaskingPoliciesMaskingColumns#schema_name}.</summary>
        [JsiiProperty(name: "schemaName", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SchemaName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_masking_policies_masking_columns#sensitive_type_id DataOciDataSafeMaskingPoliciesMaskingColumns#sensitive_type_id}.</summary>
        [JsiiProperty(name: "sensitiveTypeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SensitiveTypeId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_masking_policies_masking_columns#time_created_greater_than_or_equal_to DataOciDataSafeMaskingPoliciesMaskingColumns#time_created_greater_than_or_equal_to}.</summary>
        [JsiiProperty(name: "timeCreatedGreaterThanOrEqualTo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeCreatedGreaterThanOrEqualTo
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_masking_policies_masking_columns#time_created_less_than DataOciDataSafeMaskingPoliciesMaskingColumns#time_created_less_than}.</summary>
        [JsiiProperty(name: "timeCreatedLessThan", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeCreatedLessThan
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_masking_policies_masking_columns#time_updated_greater_than_or_equal_to DataOciDataSafeMaskingPoliciesMaskingColumns#time_updated_greater_than_or_equal_to}.</summary>
        [JsiiProperty(name: "timeUpdatedGreaterThanOrEqualTo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeUpdatedGreaterThanOrEqualTo
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_masking_policies_masking_columns#time_updated_less_than DataOciDataSafeMaskingPoliciesMaskingColumns#time_updated_less_than}.</summary>
        [JsiiProperty(name: "timeUpdatedLessThan", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeUpdatedLessThan
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataOciDataSafeMaskingPoliciesMaskingColumnsConfig), fullyQualifiedName: "oci.dataOciDataSafeMaskingPoliciesMaskingColumns.DataOciDataSafeMaskingPoliciesMaskingColumnsConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciDataSafeMaskingPoliciesMaskingColumns.IDataOciDataSafeMaskingPoliciesMaskingColumnsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_masking_policies_masking_columns#masking_policy_id DataOciDataSafeMaskingPoliciesMaskingColumns#masking_policy_id}.</summary>
            [JsiiProperty(name: "maskingPolicyId", typeJson: "{\"primitive\":\"string\"}")]
            public string MaskingPolicyId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_masking_policies_masking_columns#column_name DataOciDataSafeMaskingPoliciesMaskingColumns#column_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "columnName", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ColumnName
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_masking_policies_masking_columns#data_type DataOciDataSafeMaskingPoliciesMaskingColumns#data_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dataType", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? DataType
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_masking_policies_masking_columns#filter DataOciDataSafeMaskingPoliciesMaskingColumns#filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciDataSafeMaskingPoliciesMaskingColumns.DataOciDataSafeMaskingPoliciesMaskingColumnsFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Filter
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_masking_policies_masking_columns#id DataOciDataSafeMaskingPoliciesMaskingColumns#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_masking_policies_masking_columns#is_masking_enabled DataOciDataSafeMaskingPoliciesMaskingColumns#is_masking_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isMaskingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsMaskingEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_masking_policies_masking_columns#is_seed_required DataOciDataSafeMaskingPoliciesMaskingColumns#is_seed_required}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isSeedRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsSeedRequired
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_masking_policies_masking_columns#masking_column_group DataOciDataSafeMaskingPoliciesMaskingColumns#masking_column_group}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maskingColumnGroup", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? MaskingColumnGroup
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_masking_policies_masking_columns#masking_column_lifecycle_state DataOciDataSafeMaskingPoliciesMaskingColumns#masking_column_lifecycle_state}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maskingColumnLifecycleState", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaskingColumnLifecycleState
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_masking_policies_masking_columns#object DataOciDataSafeMaskingPoliciesMaskingColumns#object}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "object", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Object
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_masking_policies_masking_columns#object_type DataOciDataSafeMaskingPoliciesMaskingColumns#object_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "objectType", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ObjectType
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_masking_policies_masking_columns#schema_name DataOciDataSafeMaskingPoliciesMaskingColumns#schema_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "schemaName", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SchemaName
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_masking_policies_masking_columns#sensitive_type_id DataOciDataSafeMaskingPoliciesMaskingColumns#sensitive_type_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sensitiveTypeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SensitiveTypeId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_masking_policies_masking_columns#time_created_greater_than_or_equal_to DataOciDataSafeMaskingPoliciesMaskingColumns#time_created_greater_than_or_equal_to}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeCreatedGreaterThanOrEqualTo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeCreatedGreaterThanOrEqualTo
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_masking_policies_masking_columns#time_created_less_than DataOciDataSafeMaskingPoliciesMaskingColumns#time_created_less_than}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeCreatedLessThan", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeCreatedLessThan
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_masking_policies_masking_columns#time_updated_greater_than_or_equal_to DataOciDataSafeMaskingPoliciesMaskingColumns#time_updated_greater_than_or_equal_to}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeUpdatedGreaterThanOrEqualTo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeUpdatedGreaterThanOrEqualTo
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_masking_policies_masking_columns#time_updated_less_than DataOciDataSafeMaskingPoliciesMaskingColumns#time_updated_less_than}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeUpdatedLessThan", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeUpdatedLessThan
            {
                get => GetInstanceProperty<string?>();
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
