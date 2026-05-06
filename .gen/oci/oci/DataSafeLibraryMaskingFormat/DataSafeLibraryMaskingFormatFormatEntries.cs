using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeLibraryMaskingFormat
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.dataSafeLibraryMaskingFormat.DataSafeLibraryMaskingFormatFormatEntries")]
    public class DataSafeLibraryMaskingFormatFormatEntries : oci.DataSafeLibraryMaskingFormat.IDataSafeLibraryMaskingFormatFormatEntries
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#type DataSafeLibraryMaskingFormat#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#column_name DataSafeLibraryMaskingFormat#column_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "columnName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ColumnName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#description DataSafeLibraryMaskingFormat#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#end_date DataSafeLibraryMaskingFormat#end_date}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "endDate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EndDate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#end_length DataSafeLibraryMaskingFormat#end_length}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "endLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? EndLength
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#end_value DataSafeLibraryMaskingFormat#end_value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "endValue", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? EndValue
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#fixed_number DataSafeLibraryMaskingFormat#fixed_number}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fixedNumber", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? FixedNumber
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#fixed_string DataSafeLibraryMaskingFormat#fixed_string}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fixedString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FixedString
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#grouping_columns DataSafeLibraryMaskingFormat#grouping_columns}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "groupingColumns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? GroupingColumns
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#length DataSafeLibraryMaskingFormat#length}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "length", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Length
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#library_masking_format_id DataSafeLibraryMaskingFormat#library_masking_format_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "libraryMaskingFormatId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LibraryMaskingFormatId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#pattern DataSafeLibraryMaskingFormat#pattern}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pattern", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Pattern
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#post_processing_function DataSafeLibraryMaskingFormat#post_processing_function}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "postProcessingFunction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PostProcessingFunction
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#random_list DataSafeLibraryMaskingFormat#random_list}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "randomList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? RandomList
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#regular_expression DataSafeLibraryMaskingFormat#regular_expression}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "regularExpression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RegularExpression
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#replace_with DataSafeLibraryMaskingFormat#replace_with}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "replaceWith", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReplaceWith
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#schema_name DataSafeLibraryMaskingFormat#schema_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "schemaName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SchemaName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#sql_expression DataSafeLibraryMaskingFormat#sql_expression}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sqlExpression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SqlExpression
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#start_date DataSafeLibraryMaskingFormat#start_date}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "startDate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StartDate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#start_length DataSafeLibraryMaskingFormat#start_length}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "startLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? StartLength
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#start_position DataSafeLibraryMaskingFormat#start_position}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "startPosition", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? StartPosition
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#start_value DataSafeLibraryMaskingFormat#start_value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "startValue", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? StartValue
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#table_name DataSafeLibraryMaskingFormat#table_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TableName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#user_defined_function DataSafeLibraryMaskingFormat#user_defined_function}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userDefinedFunction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UserDefinedFunction
        {
            get;
            set;
        }
    }
}
