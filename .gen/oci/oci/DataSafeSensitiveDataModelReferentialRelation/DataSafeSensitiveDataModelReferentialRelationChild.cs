using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeSensitiveDataModelReferentialRelation
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.dataSafeSensitiveDataModelReferentialRelation.DataSafeSensitiveDataModelReferentialRelationChild")]
    public class DataSafeSensitiveDataModelReferentialRelationChild : oci.DataSafeSensitiveDataModelReferentialRelation.IDataSafeSensitiveDataModelReferentialRelationChild
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_data_model_referential_relation#app_name DataSafeSensitiveDataModelReferentialRelation#app_name}.</summary>
        [JsiiProperty(name: "appName", typeJson: "{\"primitive\":\"string\"}")]
        public string AppName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_data_model_referential_relation#column_group DataSafeSensitiveDataModelReferentialRelation#column_group}.</summary>
        [JsiiProperty(name: "columnGroup", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] ColumnGroup
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_data_model_referential_relation#object DataSafeSensitiveDataModelReferentialRelation#object}.</summary>
        [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}")]
        public string Object
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_data_model_referential_relation#object_type DataSafeSensitiveDataModelReferentialRelation#object_type}.</summary>
        [JsiiProperty(name: "objectType", typeJson: "{\"primitive\":\"string\"}")]
        public string ObjectType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_data_model_referential_relation#schema_name DataSafeSensitiveDataModelReferentialRelation#schema_name}.</summary>
        [JsiiProperty(name: "schemaName", typeJson: "{\"primitive\":\"string\"}")]
        public string SchemaName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_data_model_referential_relation#sensitive_type_ids DataSafeSensitiveDataModelReferentialRelation#sensitive_type_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sensitiveTypeIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SensitiveTypeIds
        {
            get;
            set;
        }
    }
}
