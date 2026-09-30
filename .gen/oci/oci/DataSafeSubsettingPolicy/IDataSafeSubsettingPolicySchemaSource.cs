using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeSubsettingPolicy
{
    [JsiiInterface(nativeType: typeof(IDataSafeSubsettingPolicySchemaSource), fullyQualifiedName: "oci.dataSafeSubsettingPolicy.DataSafeSubsettingPolicySchemaSource")]
    public interface IDataSafeSubsettingPolicySchemaSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/data_safe_subsetting_policy#schema_source DataSafeSubsettingPolicy#schema_source}.</summary>
        [JsiiProperty(name: "schemaSource", typeJson: "{\"primitive\":\"string\"}")]
        string SchemaSource
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/data_safe_subsetting_policy#schemas_for_subsetting DataSafeSubsettingPolicy#schemas_for_subsetting}.</summary>
        [JsiiProperty(name: "schemasForSubsetting", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SchemasForSubsetting
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/data_safe_subsetting_policy#sensitive_data_model_id DataSafeSubsettingPolicy#sensitive_data_model_id}.</summary>
        [JsiiProperty(name: "sensitiveDataModelId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SensitiveDataModelId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/data_safe_subsetting_policy#target_id DataSafeSubsettingPolicy#target_id}.</summary>
        [JsiiProperty(name: "targetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TargetId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataSafeSubsettingPolicySchemaSource), fullyQualifiedName: "oci.dataSafeSubsettingPolicy.DataSafeSubsettingPolicySchemaSource")]
        internal sealed class _Proxy : DeputyBase, oci.DataSafeSubsettingPolicy.IDataSafeSubsettingPolicySchemaSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/data_safe_subsetting_policy#schema_source DataSafeSubsettingPolicy#schema_source}.</summary>
            [JsiiProperty(name: "schemaSource", typeJson: "{\"primitive\":\"string\"}")]
            public string SchemaSource
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/data_safe_subsetting_policy#schemas_for_subsetting DataSafeSubsettingPolicy#schemas_for_subsetting}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "schemasForSubsetting", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SchemasForSubsetting
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/data_safe_subsetting_policy#sensitive_data_model_id DataSafeSubsettingPolicy#sensitive_data_model_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sensitiveDataModelId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SensitiveDataModelId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/data_safe_subsetting_policy#target_id DataSafeSubsettingPolicy#target_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TargetId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
