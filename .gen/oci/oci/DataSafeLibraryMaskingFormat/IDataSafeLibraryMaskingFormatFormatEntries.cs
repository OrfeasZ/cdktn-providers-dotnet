using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeLibraryMaskingFormat
{
    [JsiiInterface(nativeType: typeof(IDataSafeLibraryMaskingFormatFormatEntries), fullyQualifiedName: "oci.dataSafeLibraryMaskingFormat.DataSafeLibraryMaskingFormatFormatEntries")]
    public interface IDataSafeLibraryMaskingFormatFormatEntries
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#type DataSafeLibraryMaskingFormat#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#column_name DataSafeLibraryMaskingFormat#column_name}.</summary>
        [JsiiProperty(name: "columnName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ColumnName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#description DataSafeLibraryMaskingFormat#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#end_date DataSafeLibraryMaskingFormat#end_date}.</summary>
        [JsiiProperty(name: "endDate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EndDate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#end_length DataSafeLibraryMaskingFormat#end_length}.</summary>
        [JsiiProperty(name: "endLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? EndLength
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#end_value DataSafeLibraryMaskingFormat#end_value}.</summary>
        [JsiiProperty(name: "endValue", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? EndValue
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#fixed_number DataSafeLibraryMaskingFormat#fixed_number}.</summary>
        [JsiiProperty(name: "fixedNumber", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? FixedNumber
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#fixed_string DataSafeLibraryMaskingFormat#fixed_string}.</summary>
        [JsiiProperty(name: "fixedString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FixedString
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#grouping_columns DataSafeLibraryMaskingFormat#grouping_columns}.</summary>
        [JsiiProperty(name: "groupingColumns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? GroupingColumns
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#length DataSafeLibraryMaskingFormat#length}.</summary>
        [JsiiProperty(name: "length", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Length
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#library_masking_format_id DataSafeLibraryMaskingFormat#library_masking_format_id}.</summary>
        [JsiiProperty(name: "libraryMaskingFormatId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LibraryMaskingFormatId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#pattern DataSafeLibraryMaskingFormat#pattern}.</summary>
        [JsiiProperty(name: "pattern", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Pattern
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#post_processing_function DataSafeLibraryMaskingFormat#post_processing_function}.</summary>
        [JsiiProperty(name: "postProcessingFunction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PostProcessingFunction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#random_list DataSafeLibraryMaskingFormat#random_list}.</summary>
        [JsiiProperty(name: "randomList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? RandomList
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#regular_expression DataSafeLibraryMaskingFormat#regular_expression}.</summary>
        [JsiiProperty(name: "regularExpression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RegularExpression
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#replace_with DataSafeLibraryMaskingFormat#replace_with}.</summary>
        [JsiiProperty(name: "replaceWith", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReplaceWith
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#schema_name DataSafeLibraryMaskingFormat#schema_name}.</summary>
        [JsiiProperty(name: "schemaName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SchemaName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#sql_expression DataSafeLibraryMaskingFormat#sql_expression}.</summary>
        [JsiiProperty(name: "sqlExpression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SqlExpression
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#start_date DataSafeLibraryMaskingFormat#start_date}.</summary>
        [JsiiProperty(name: "startDate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StartDate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#start_length DataSafeLibraryMaskingFormat#start_length}.</summary>
        [JsiiProperty(name: "startLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? StartLength
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#start_position DataSafeLibraryMaskingFormat#start_position}.</summary>
        [JsiiProperty(name: "startPosition", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? StartPosition
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#start_value DataSafeLibraryMaskingFormat#start_value}.</summary>
        [JsiiProperty(name: "startValue", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? StartValue
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#table_name DataSafeLibraryMaskingFormat#table_name}.</summary>
        [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TableName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#user_defined_function DataSafeLibraryMaskingFormat#user_defined_function}.</summary>
        [JsiiProperty(name: "userDefinedFunction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserDefinedFunction
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataSafeLibraryMaskingFormatFormatEntries), fullyQualifiedName: "oci.dataSafeLibraryMaskingFormat.DataSafeLibraryMaskingFormatFormatEntries")]
        internal sealed class _Proxy : DeputyBase, oci.DataSafeLibraryMaskingFormat.IDataSafeLibraryMaskingFormatFormatEntries
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#type DataSafeLibraryMaskingFormat#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#column_name DataSafeLibraryMaskingFormat#column_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "columnName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ColumnName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#description DataSafeLibraryMaskingFormat#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#end_date DataSafeLibraryMaskingFormat#end_date}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "endDate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EndDate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#end_length DataSafeLibraryMaskingFormat#end_length}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "endLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? EndLength
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#end_value DataSafeLibraryMaskingFormat#end_value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "endValue", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? EndValue
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#fixed_number DataSafeLibraryMaskingFormat#fixed_number}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fixedNumber", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? FixedNumber
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#fixed_string DataSafeLibraryMaskingFormat#fixed_string}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fixedString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FixedString
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#grouping_columns DataSafeLibraryMaskingFormat#grouping_columns}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "groupingColumns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? GroupingColumns
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#length DataSafeLibraryMaskingFormat#length}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "length", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Length
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#library_masking_format_id DataSafeLibraryMaskingFormat#library_masking_format_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "libraryMaskingFormatId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LibraryMaskingFormatId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#pattern DataSafeLibraryMaskingFormat#pattern}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "pattern", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Pattern
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#post_processing_function DataSafeLibraryMaskingFormat#post_processing_function}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "postProcessingFunction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PostProcessingFunction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#random_list DataSafeLibraryMaskingFormat#random_list}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "randomList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? RandomList
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#regular_expression DataSafeLibraryMaskingFormat#regular_expression}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "regularExpression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RegularExpression
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#replace_with DataSafeLibraryMaskingFormat#replace_with}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "replaceWith", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReplaceWith
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#schema_name DataSafeLibraryMaskingFormat#schema_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "schemaName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SchemaName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#sql_expression DataSafeLibraryMaskingFormat#sql_expression}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sqlExpression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SqlExpression
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#start_date DataSafeLibraryMaskingFormat#start_date}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "startDate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StartDate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#start_length DataSafeLibraryMaskingFormat#start_length}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "startLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? StartLength
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#start_position DataSafeLibraryMaskingFormat#start_position}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "startPosition", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? StartPosition
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#start_value DataSafeLibraryMaskingFormat#start_value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "startValue", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? StartValue
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#table_name DataSafeLibraryMaskingFormat#table_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TableName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_library_masking_format#user_defined_function DataSafeLibraryMaskingFormat#user_defined_function}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userDefinedFunction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserDefinedFunction
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
