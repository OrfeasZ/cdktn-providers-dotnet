using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns
{
    [JsiiInterface(nativeType: typeof(IDataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumnsConfig), fullyQualifiedName: "oci.dataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns.DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumnsConfig")]
    public interface IDataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumnsConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_sdm_masking_policy_difference_difference_columns#sdm_masking_policy_difference_id DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns#sdm_masking_policy_difference_id}.</summary>
        [JsiiProperty(name: "sdmMaskingPolicyDifferenceId", typeJson: "{\"primitive\":\"string\"}")]
        string SdmMaskingPolicyDifferenceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_sdm_masking_policy_difference_difference_columns#column_name DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns#column_name}.</summary>
        [JsiiProperty(name: "columnName", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ColumnName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_sdm_masking_policy_difference_difference_columns#difference_type DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns#difference_type}.</summary>
        [JsiiProperty(name: "differenceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DifferenceType
        {
            get
            {
                return null;
            }
        }

        /// <summary>filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_sdm_masking_policy_difference_difference_columns#filter DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns#filter}
        /// </remarks>
        [JsiiProperty(name: "filter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns.DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumnsFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Filter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_sdm_masking_policy_difference_difference_columns#id DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_sdm_masking_policy_difference_difference_columns#object DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns#object}.</summary>
        [JsiiProperty(name: "object", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Object
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_sdm_masking_policy_difference_difference_columns#planned_action DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns#planned_action}.</summary>
        [JsiiProperty(name: "plannedAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PlannedAction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_sdm_masking_policy_difference_difference_columns#schema_name DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns#schema_name}.</summary>
        [JsiiProperty(name: "schemaName", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SchemaName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_sdm_masking_policy_difference_difference_columns#sync_status DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns#sync_status}.</summary>
        [JsiiProperty(name: "syncStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SyncStatus
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumnsConfig), fullyQualifiedName: "oci.dataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns.DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumnsConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns.IDataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumnsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_sdm_masking_policy_difference_difference_columns#sdm_masking_policy_difference_id DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns#sdm_masking_policy_difference_id}.</summary>
            [JsiiProperty(name: "sdmMaskingPolicyDifferenceId", typeJson: "{\"primitive\":\"string\"}")]
            public string SdmMaskingPolicyDifferenceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_sdm_masking_policy_difference_difference_columns#column_name DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns#column_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "columnName", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ColumnName
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_sdm_masking_policy_difference_difference_columns#difference_type DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns#difference_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "differenceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DifferenceType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_sdm_masking_policy_difference_difference_columns#filter DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns#filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns.DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumnsFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Filter
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_sdm_masking_policy_difference_difference_columns#id DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_sdm_masking_policy_difference_difference_columns#object DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns#object}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "object", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Object
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_sdm_masking_policy_difference_difference_columns#planned_action DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns#planned_action}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "plannedAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PlannedAction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_sdm_masking_policy_difference_difference_columns#schema_name DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns#schema_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "schemaName", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SchemaName
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_sdm_masking_policy_difference_difference_columns#sync_status DataOciDataSafeSdmMaskingPolicyDifferenceDifferenceColumns#sync_status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "syncStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SyncStatus
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
