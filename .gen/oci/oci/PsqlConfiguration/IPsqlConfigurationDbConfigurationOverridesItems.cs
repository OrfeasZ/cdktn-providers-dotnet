using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.PsqlConfiguration
{
    [JsiiInterface(nativeType: typeof(IPsqlConfigurationDbConfigurationOverridesItems), fullyQualifiedName: "oci.psqlConfiguration.PsqlConfigurationDbConfigurationOverridesItems")]
    public interface IPsqlConfigurationDbConfigurationOverridesItems
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_configuration#config_key PsqlConfiguration#config_key}.</summary>
        [JsiiProperty(name: "configKey", typeJson: "{\"primitive\":\"string\"}")]
        string ConfigKey
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_configuration#overriden_config_value PsqlConfiguration#overriden_config_value}.</summary>
        [JsiiProperty(name: "overridenConfigValue", typeJson: "{\"primitive\":\"string\"}")]
        string OverridenConfigValue
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPsqlConfigurationDbConfigurationOverridesItems), fullyQualifiedName: "oci.psqlConfiguration.PsqlConfigurationDbConfigurationOverridesItems")]
        internal sealed class _Proxy : DeputyBase, oci.PsqlConfiguration.IPsqlConfigurationDbConfigurationOverridesItems
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_configuration#config_key PsqlConfiguration#config_key}.</summary>
            [JsiiProperty(name: "configKey", typeJson: "{\"primitive\":\"string\"}")]
            public string ConfigKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_configuration#overriden_config_value PsqlConfiguration#overriden_config_value}.</summary>
            [JsiiProperty(name: "overridenConfigValue", typeJson: "{\"primitive\":\"string\"}")]
            public string OverridenConfigValue
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
