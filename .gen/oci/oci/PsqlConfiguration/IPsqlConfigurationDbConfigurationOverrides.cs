using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.PsqlConfiguration
{
    [JsiiInterface(nativeType: typeof(IPsqlConfigurationDbConfigurationOverrides), fullyQualifiedName: "oci.psqlConfiguration.PsqlConfigurationDbConfigurationOverrides")]
    public interface IPsqlConfigurationDbConfigurationOverrides
    {
        /// <summary>items block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_configuration#items PsqlConfiguration#items}
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.psqlConfiguration.PsqlConfigurationDbConfigurationOverridesItems\"},\"kind\":\"array\"}}]}}")]
        object Items
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPsqlConfigurationDbConfigurationOverrides), fullyQualifiedName: "oci.psqlConfiguration.PsqlConfigurationDbConfigurationOverrides")]
        internal sealed class _Proxy : DeputyBase, oci.PsqlConfiguration.IPsqlConfigurationDbConfigurationOverrides
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>items block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/psql_configuration#items PsqlConfiguration#items}
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.psqlConfiguration.PsqlConfigurationDbConfigurationOverridesItems\"},\"kind\":\"array\"}}]}}")]
            public object Items
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
