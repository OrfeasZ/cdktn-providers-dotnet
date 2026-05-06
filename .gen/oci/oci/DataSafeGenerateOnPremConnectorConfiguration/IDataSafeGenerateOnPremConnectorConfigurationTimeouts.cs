using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeGenerateOnPremConnectorConfiguration
{
    [JsiiInterface(nativeType: typeof(IDataSafeGenerateOnPremConnectorConfigurationTimeouts), fullyQualifiedName: "oci.dataSafeGenerateOnPremConnectorConfiguration.DataSafeGenerateOnPremConnectorConfigurationTimeouts")]
    public interface IDataSafeGenerateOnPremConnectorConfigurationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_generate_on_prem_connector_configuration#create DataSafeGenerateOnPremConnectorConfiguration#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_generate_on_prem_connector_configuration#delete DataSafeGenerateOnPremConnectorConfiguration#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_generate_on_prem_connector_configuration#update DataSafeGenerateOnPremConnectorConfiguration#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataSafeGenerateOnPremConnectorConfigurationTimeouts), fullyQualifiedName: "oci.dataSafeGenerateOnPremConnectorConfiguration.DataSafeGenerateOnPremConnectorConfigurationTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.DataSafeGenerateOnPremConnectorConfiguration.IDataSafeGenerateOnPremConnectorConfigurationTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_generate_on_prem_connector_configuration#create DataSafeGenerateOnPremConnectorConfiguration#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_generate_on_prem_connector_configuration#delete DataSafeGenerateOnPremConnectorConfiguration#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_generate_on_prem_connector_configuration#update DataSafeGenerateOnPremConnectorConfiguration#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
