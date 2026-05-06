using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeSensitiveDataModelReferentialRelation
{
    [JsiiInterface(nativeType: typeof(IDataSafeSensitiveDataModelReferentialRelationChild), fullyQualifiedName: "oci.dataSafeSensitiveDataModelReferentialRelation.DataSafeSensitiveDataModelReferentialRelationChild")]
    public interface IDataSafeSensitiveDataModelReferentialRelationChild
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_data_model_referential_relation#app_name DataSafeSensitiveDataModelReferentialRelation#app_name}.</summary>
        [JsiiProperty(name: "appName", typeJson: "{\"primitive\":\"string\"}")]
        string AppName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_data_model_referential_relation#column_group DataSafeSensitiveDataModelReferentialRelation#column_group}.</summary>
        [JsiiProperty(name: "columnGroup", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] ColumnGroup
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_data_model_referential_relation#object DataSafeSensitiveDataModelReferentialRelation#object}.</summary>
        [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}")]
        string Object
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_data_model_referential_relation#object_type DataSafeSensitiveDataModelReferentialRelation#object_type}.</summary>
        [JsiiProperty(name: "objectType", typeJson: "{\"primitive\":\"string\"}")]
        string ObjectType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_data_model_referential_relation#schema_name DataSafeSensitiveDataModelReferentialRelation#schema_name}.</summary>
        [JsiiProperty(name: "schemaName", typeJson: "{\"primitive\":\"string\"}")]
        string SchemaName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_data_model_referential_relation#sensitive_type_ids DataSafeSensitiveDataModelReferentialRelation#sensitive_type_ids}.</summary>
        [JsiiProperty(name: "sensitiveTypeIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SensitiveTypeIds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataSafeSensitiveDataModelReferentialRelationChild), fullyQualifiedName: "oci.dataSafeSensitiveDataModelReferentialRelation.DataSafeSensitiveDataModelReferentialRelationChild")]
        internal sealed class _Proxy : DeputyBase, oci.DataSafeSensitiveDataModelReferentialRelation.IDataSafeSensitiveDataModelReferentialRelationChild
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_data_model_referential_relation#app_name DataSafeSensitiveDataModelReferentialRelation#app_name}.</summary>
            [JsiiProperty(name: "appName", typeJson: "{\"primitive\":\"string\"}")]
            public string AppName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_data_model_referential_relation#column_group DataSafeSensitiveDataModelReferentialRelation#column_group}.</summary>
            [JsiiProperty(name: "columnGroup", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] ColumnGroup
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_data_model_referential_relation#object DataSafeSensitiveDataModelReferentialRelation#object}.</summary>
            [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}")]
            public string Object
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_data_model_referential_relation#object_type DataSafeSensitiveDataModelReferentialRelation#object_type}.</summary>
            [JsiiProperty(name: "objectType", typeJson: "{\"primitive\":\"string\"}")]
            public string ObjectType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_data_model_referential_relation#schema_name DataSafeSensitiveDataModelReferentialRelation#schema_name}.</summary>
            [JsiiProperty(name: "schemaName", typeJson: "{\"primitive\":\"string\"}")]
            public string SchemaName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_data_model_referential_relation#sensitive_type_ids DataSafeSensitiveDataModelReferentialRelation#sensitive_type_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sensitiveTypeIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SensitiveTypeIds
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
