using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeSensitiveDataModelReferentialRelation
{
    [JsiiInterface(nativeType: typeof(IDataSafeSensitiveDataModelReferentialRelationTimeouts), fullyQualifiedName: "oci.dataSafeSensitiveDataModelReferentialRelation.DataSafeSensitiveDataModelReferentialRelationTimeouts")]
    public interface IDataSafeSensitiveDataModelReferentialRelationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_data_model_referential_relation#create DataSafeSensitiveDataModelReferentialRelation#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_data_model_referential_relation#delete DataSafeSensitiveDataModelReferentialRelation#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_data_model_referential_relation#update DataSafeSensitiveDataModelReferentialRelation#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataSafeSensitiveDataModelReferentialRelationTimeouts), fullyQualifiedName: "oci.dataSafeSensitiveDataModelReferentialRelation.DataSafeSensitiveDataModelReferentialRelationTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.DataSafeSensitiveDataModelReferentialRelation.IDataSafeSensitiveDataModelReferentialRelationTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_data_model_referential_relation#create DataSafeSensitiveDataModelReferentialRelation#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_data_model_referential_relation#delete DataSafeSensitiveDataModelReferentialRelation#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_data_model_referential_relation#update DataSafeSensitiveDataModelReferentialRelation#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
