using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeReportDefinition
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.dataSafeReportDefinition.DataSafeReportDefinitionSummary")]
    public class DataSafeReportDefinitionSummary : oci.DataSafeReportDefinition.IDataSafeReportDefinitionSummary
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_report_definition#display_order DataSafeReportDefinition#display_order}.</summary>
        [JsiiProperty(name: "displayOrder", typeJson: "{\"primitive\":\"number\"}")]
        public double DisplayOrder
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_report_definition#name DataSafeReportDefinition#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_report_definition#count_of DataSafeReportDefinition#count_of}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "countOf", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CountOf
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_report_definition#group_by_field_name DataSafeReportDefinition#group_by_field_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "groupByFieldName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GroupByFieldName
        {
            get;
            set;
        }

        private object? _isHidden;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_report_definition#is_hidden DataSafeReportDefinition#is_hidden}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isHidden", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsHidden
        {
            get => _isHidden;
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
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isHidden = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_report_definition#scim_filter DataSafeReportDefinition#scim_filter}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scimFilter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ScimFilter
        {
            get;
            set;
        }
    }
}
