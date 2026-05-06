using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeReportDefinition
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.dataSafeReportDefinition.DataSafeReportDefinitionColumnSortings")]
    public class DataSafeReportDefinitionColumnSortings : oci.DataSafeReportDefinition.IDataSafeReportDefinitionColumnSortings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_report_definition#field_name DataSafeReportDefinition#field_name}.</summary>
        [JsiiProperty(name: "fieldName", typeJson: "{\"primitive\":\"string\"}")]
        public string FieldName
        {
            get;
            set;
        }

        private object _isAscending;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_report_definition#is_ascending DataSafeReportDefinition#is_ascending}.</summary>
        [JsiiProperty(name: "isAscending", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public object IsAscending
        {
            get => _isAscending;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isAscending = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_report_definition#sorting_order DataSafeReportDefinition#sorting_order}.</summary>
        [JsiiProperty(name: "sortingOrder", typeJson: "{\"primitive\":\"number\"}")]
        public double SortingOrder
        {
            get;
            set;
        }
    }
}
