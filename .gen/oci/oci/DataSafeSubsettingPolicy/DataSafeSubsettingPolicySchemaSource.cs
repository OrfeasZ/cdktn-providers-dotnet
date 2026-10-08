using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeSubsettingPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.dataSafeSubsettingPolicy.DataSafeSubsettingPolicySchemaSource")]
    public class DataSafeSubsettingPolicySchemaSource : oci.DataSafeSubsettingPolicy.IDataSafeSubsettingPolicySchemaSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy#schema_source DataSafeSubsettingPolicy#schema_source}.</summary>
        [JsiiProperty(name: "schemaSource", typeJson: "{\"primitive\":\"string\"}")]
        public string SchemaSource
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy#schemas_for_subsetting DataSafeSubsettingPolicy#schemas_for_subsetting}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "schemasForSubsetting", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SchemasForSubsetting
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy#sensitive_data_model_id DataSafeSubsettingPolicy#sensitive_data_model_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sensitiveDataModelId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SensitiveDataModelId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy#target_id DataSafeSubsettingPolicy#target_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetId
        {
            get;
            set;
        }
    }
}
