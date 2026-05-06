using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeReportDefinition
{
    [JsiiInterface(nativeType: typeof(IDataSafeReportDefinitionColumnInfo), fullyQualifiedName: "oci.dataSafeReportDefinition.DataSafeReportDefinitionColumnInfo")]
    public interface IDataSafeReportDefinitionColumnInfo
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_report_definition#display_name DataSafeReportDefinition#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_report_definition#display_order DataSafeReportDefinition#display_order}.</summary>
        [JsiiProperty(name: "displayOrder", typeJson: "{\"primitive\":\"number\"}")]
        double DisplayOrder
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_report_definition#field_name DataSafeReportDefinition#field_name}.</summary>
        [JsiiProperty(name: "fieldName", typeJson: "{\"primitive\":\"string\"}")]
        string FieldName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_report_definition#is_hidden DataSafeReportDefinition#is_hidden}.</summary>
        [JsiiProperty(name: "isHidden", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object IsHidden
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_report_definition#applicable_operators DataSafeReportDefinition#applicable_operators}.</summary>
        [JsiiProperty(name: "applicableOperators", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ApplicableOperators
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_report_definition#data_type DataSafeReportDefinition#data_type}.</summary>
        [JsiiProperty(name: "dataType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DataType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_report_definition#is_virtual DataSafeReportDefinition#is_virtual}.</summary>
        [JsiiProperty(name: "isVirtual", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsVirtual
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataSafeReportDefinitionColumnInfo), fullyQualifiedName: "oci.dataSafeReportDefinition.DataSafeReportDefinitionColumnInfo")]
        internal sealed class _Proxy : DeputyBase, oci.DataSafeReportDefinition.IDataSafeReportDefinitionColumnInfo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_report_definition#display_name DataSafeReportDefinition#display_name}.</summary>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_report_definition#display_order DataSafeReportDefinition#display_order}.</summary>
            [JsiiProperty(name: "displayOrder", typeJson: "{\"primitive\":\"number\"}")]
            public double DisplayOrder
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_report_definition#field_name DataSafeReportDefinition#field_name}.</summary>
            [JsiiProperty(name: "fieldName", typeJson: "{\"primitive\":\"string\"}")]
            public string FieldName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_report_definition#is_hidden DataSafeReportDefinition#is_hidden}.</summary>
            [JsiiProperty(name: "isHidden", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object IsHidden
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_report_definition#applicable_operators DataSafeReportDefinition#applicable_operators}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "applicableOperators", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ApplicableOperators
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_report_definition#data_type DataSafeReportDefinition#data_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dataType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DataType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_report_definition#is_virtual DataSafeReportDefinition#is_virtual}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isVirtual", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsVirtual
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
