using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataFactoryLinkedServiceSqlManagedInstance
{
    [JsiiInterface(nativeType: typeof(IDataFactoryLinkedServiceSqlManagedInstanceKeyVaultConnectionString), fullyQualifiedName: "azurerm.dataFactoryLinkedServiceSqlManagedInstance.DataFactoryLinkedServiceSqlManagedInstanceKeyVaultConnectionString")]
    public interface IDataFactoryLinkedServiceSqlManagedInstanceKeyVaultConnectionString
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/data_factory_linked_service_sql_managed_instance#linked_service_name DataFactoryLinkedServiceSqlManagedInstance#linked_service_name}.</summary>
        [JsiiProperty(name: "linkedServiceName", typeJson: "{\"primitive\":\"string\"}")]
        string LinkedServiceName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/data_factory_linked_service_sql_managed_instance#secret_name DataFactoryLinkedServiceSqlManagedInstance#secret_name}.</summary>
        [JsiiProperty(name: "secretName", typeJson: "{\"primitive\":\"string\"}")]
        string SecretName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataFactoryLinkedServiceSqlManagedInstanceKeyVaultConnectionString), fullyQualifiedName: "azurerm.dataFactoryLinkedServiceSqlManagedInstance.DataFactoryLinkedServiceSqlManagedInstanceKeyVaultConnectionString")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataFactoryLinkedServiceSqlManagedInstance.IDataFactoryLinkedServiceSqlManagedInstanceKeyVaultConnectionString
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/data_factory_linked_service_sql_managed_instance#linked_service_name DataFactoryLinkedServiceSqlManagedInstance#linked_service_name}.</summary>
            [JsiiProperty(name: "linkedServiceName", typeJson: "{\"primitive\":\"string\"}")]
            public string LinkedServiceName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/data_factory_linked_service_sql_managed_instance#secret_name DataFactoryLinkedServiceSqlManagedInstance#secret_name}.</summary>
            [JsiiProperty(name: "secretName", typeJson: "{\"primitive\":\"string\"}")]
            public string SecretName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
