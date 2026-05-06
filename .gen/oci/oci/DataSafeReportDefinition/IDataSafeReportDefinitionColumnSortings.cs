using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeReportDefinition
{
    [JsiiInterface(nativeType: typeof(IDataSafeReportDefinitionColumnSortings), fullyQualifiedName: "oci.dataSafeReportDefinition.DataSafeReportDefinitionColumnSortings")]
    public interface IDataSafeReportDefinitionColumnSortings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_report_definition#field_name DataSafeReportDefinition#field_name}.</summary>
        [JsiiProperty(name: "fieldName", typeJson: "{\"primitive\":\"string\"}")]
        string FieldName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_report_definition#is_ascending DataSafeReportDefinition#is_ascending}.</summary>
        [JsiiProperty(name: "isAscending", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object IsAscending
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_report_definition#sorting_order DataSafeReportDefinition#sorting_order}.</summary>
        [JsiiProperty(name: "sortingOrder", typeJson: "{\"primitive\":\"number\"}")]
        double SortingOrder
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataSafeReportDefinitionColumnSortings), fullyQualifiedName: "oci.dataSafeReportDefinition.DataSafeReportDefinitionColumnSortings")]
        internal sealed class _Proxy : DeputyBase, oci.DataSafeReportDefinition.IDataSafeReportDefinitionColumnSortings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_report_definition#field_name DataSafeReportDefinition#field_name}.</summary>
            [JsiiProperty(name: "fieldName", typeJson: "{\"primitive\":\"string\"}")]
            public string FieldName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_report_definition#is_ascending DataSafeReportDefinition#is_ascending}.</summary>
            [JsiiProperty(name: "isAscending", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object IsAscending
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_report_definition#sorting_order DataSafeReportDefinition#sorting_order}.</summary>
            [JsiiProperty(name: "sortingOrder", typeJson: "{\"primitive\":\"number\"}")]
            public double SortingOrder
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
