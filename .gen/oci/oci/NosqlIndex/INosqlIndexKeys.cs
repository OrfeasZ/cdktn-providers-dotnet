using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.NosqlIndex
{
    [JsiiInterface(nativeType: typeof(INosqlIndexKeys), fullyQualifiedName: "oci.nosqlIndex.NosqlIndexKeys")]
    public interface INosqlIndexKeys
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/nosql_index#column_name NosqlIndex#column_name}.</summary>
        [JsiiProperty(name: "columnName", typeJson: "{\"primitive\":\"string\"}")]
        string ColumnName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/nosql_index#json_field_type NosqlIndex#json_field_type}.</summary>
        [JsiiProperty(name: "jsonFieldType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? JsonFieldType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/nosql_index#json_path NosqlIndex#json_path}.</summary>
        [JsiiProperty(name: "jsonPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? JsonPath
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INosqlIndexKeys), fullyQualifiedName: "oci.nosqlIndex.NosqlIndexKeys")]
        internal sealed class _Proxy : DeputyBase, oci.NosqlIndex.INosqlIndexKeys
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/nosql_index#column_name NosqlIndex#column_name}.</summary>
            [JsiiProperty(name: "columnName", typeJson: "{\"primitive\":\"string\"}")]
            public string ColumnName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/nosql_index#json_field_type NosqlIndex#json_field_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "jsonFieldType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? JsonFieldType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/nosql_index#json_path NosqlIndex#json_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "jsonPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? JsonPath
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
