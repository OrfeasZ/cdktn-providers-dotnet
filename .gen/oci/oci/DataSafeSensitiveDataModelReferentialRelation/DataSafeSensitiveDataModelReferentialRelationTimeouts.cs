using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeSensitiveDataModelReferentialRelation
{
    [JsiiByValue(fqn: "oci.dataSafeSensitiveDataModelReferentialRelation.DataSafeSensitiveDataModelReferentialRelationTimeouts")]
    public class DataSafeSensitiveDataModelReferentialRelationTimeouts : oci.DataSafeSensitiveDataModelReferentialRelation.IDataSafeSensitiveDataModelReferentialRelationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_data_model_referential_relation#create DataSafeSensitiveDataModelReferentialRelation#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_data_model_referential_relation#delete DataSafeSensitiveDataModelReferentialRelation#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_data_model_referential_relation#update DataSafeSensitiveDataModelReferentialRelation#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
