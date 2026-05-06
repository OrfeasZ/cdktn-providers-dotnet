using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeReportDefinition
{
    [JsiiInterface(nativeType: typeof(IDataSafeReportDefinitionSummary), fullyQualifiedName: "oci.dataSafeReportDefinition.DataSafeReportDefinitionSummary")]
    public interface IDataSafeReportDefinitionSummary
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_report_definition#display_order DataSafeReportDefinition#display_order}.</summary>
        [JsiiProperty(name: "displayOrder", typeJson: "{\"primitive\":\"number\"}")]
        double DisplayOrder
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_report_definition#name DataSafeReportDefinition#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_report_definition#count_of DataSafeReportDefinition#count_of}.</summary>
        [JsiiProperty(name: "countOf", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CountOf
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_report_definition#group_by_field_name DataSafeReportDefinition#group_by_field_name}.</summary>
        [JsiiProperty(name: "groupByFieldName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GroupByFieldName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_report_definition#is_hidden DataSafeReportDefinition#is_hidden}.</summary>
        [JsiiProperty(name: "isHidden", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsHidden
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_report_definition#scim_filter DataSafeReportDefinition#scim_filter}.</summary>
        [JsiiProperty(name: "scimFilter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScimFilter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataSafeReportDefinitionSummary), fullyQualifiedName: "oci.dataSafeReportDefinition.DataSafeReportDefinitionSummary")]
        internal sealed class _Proxy : DeputyBase, oci.DataSafeReportDefinition.IDataSafeReportDefinitionSummary
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_report_definition#display_order DataSafeReportDefinition#display_order}.</summary>
            [JsiiProperty(name: "displayOrder", typeJson: "{\"primitive\":\"number\"}")]
            public double DisplayOrder
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_report_definition#name DataSafeReportDefinition#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_report_definition#count_of DataSafeReportDefinition#count_of}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "countOf", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CountOf
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_report_definition#group_by_field_name DataSafeReportDefinition#group_by_field_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "groupByFieldName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GroupByFieldName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_report_definition#is_hidden DataSafeReportDefinition#is_hidden}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isHidden", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsHidden
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_report_definition#scim_filter DataSafeReportDefinition#scim_filter}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scimFilter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScimFilter
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
