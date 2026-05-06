using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeSensitiveDataModelsSensitiveColumn
{
    [JsiiInterface(nativeType: typeof(IDataSafeSensitiveDataModelsSensitiveColumnTimeouts), fullyQualifiedName: "oci.dataSafeSensitiveDataModelsSensitiveColumn.DataSafeSensitiveDataModelsSensitiveColumnTimeouts")]
    public interface IDataSafeSensitiveDataModelsSensitiveColumnTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_data_models_sensitive_column#create DataSafeSensitiveDataModelsSensitiveColumn#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_data_models_sensitive_column#delete DataSafeSensitiveDataModelsSensitiveColumn#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_data_models_sensitive_column#update DataSafeSensitiveDataModelsSensitiveColumn#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataSafeSensitiveDataModelsSensitiveColumnTimeouts), fullyQualifiedName: "oci.dataSafeSensitiveDataModelsSensitiveColumn.DataSafeSensitiveDataModelsSensitiveColumnTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.DataSafeSensitiveDataModelsSensitiveColumn.IDataSafeSensitiveDataModelsSensitiveColumnTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_data_models_sensitive_column#create DataSafeSensitiveDataModelsSensitiveColumn#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_data_models_sensitive_column#delete DataSafeSensitiveDataModelsSensitiveColumn#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_data_models_sensitive_column#update DataSafeSensitiveDataModelsSensitiveColumn#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
