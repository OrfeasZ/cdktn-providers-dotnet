using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MeteringComputationCustomTable
{
    [JsiiInterface(nativeType: typeof(IMeteringComputationCustomTableSavedCustomTable), fullyQualifiedName: "oci.meteringComputationCustomTable.MeteringComputationCustomTableSavedCustomTable")]
    public interface IMeteringComputationCustomTableSavedCustomTable
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_custom_table#display_name MeteringComputationCustomTable#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_custom_table#column_group_by MeteringComputationCustomTable#column_group_by}.</summary>
        [JsiiProperty(name: "columnGroupBy", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ColumnGroupBy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_custom_table#compartment_depth MeteringComputationCustomTable#compartment_depth}.</summary>
        [JsiiProperty(name: "compartmentDepth", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CompartmentDepth
        {
            get
            {
                return null;
            }
        }

        /// <summary>group_by_tag block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_custom_table#group_by_tag MeteringComputationCustomTable#group_by_tag}
        /// </remarks>
        [JsiiProperty(name: "groupByTag", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.meteringComputationCustomTable.MeteringComputationCustomTableSavedCustomTableGroupByTag\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? GroupByTag
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_custom_table#row_group_by MeteringComputationCustomTable#row_group_by}.</summary>
        [JsiiProperty(name: "rowGroupBy", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? RowGroupBy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_custom_table#version MeteringComputationCustomTable#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Version
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMeteringComputationCustomTableSavedCustomTable), fullyQualifiedName: "oci.meteringComputationCustomTable.MeteringComputationCustomTableSavedCustomTable")]
        internal sealed class _Proxy : DeputyBase, oci.MeteringComputationCustomTable.IMeteringComputationCustomTableSavedCustomTable
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_custom_table#display_name MeteringComputationCustomTable#display_name}.</summary>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_custom_table#column_group_by MeteringComputationCustomTable#column_group_by}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "columnGroupBy", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ColumnGroupBy
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_custom_table#compartment_depth MeteringComputationCustomTable#compartment_depth}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "compartmentDepth", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CompartmentDepth
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>group_by_tag block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_custom_table#group_by_tag MeteringComputationCustomTable#group_by_tag}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "groupByTag", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.meteringComputationCustomTable.MeteringComputationCustomTableSavedCustomTableGroupByTag\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? GroupByTag
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_custom_table#row_group_by MeteringComputationCustomTable#row_group_by}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rowGroupBy", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? RowGroupBy
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/metering_computation_custom_table#version MeteringComputationCustomTable#version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Version
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
