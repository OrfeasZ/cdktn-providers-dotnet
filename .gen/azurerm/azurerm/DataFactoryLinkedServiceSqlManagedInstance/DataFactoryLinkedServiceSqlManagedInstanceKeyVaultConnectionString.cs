using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataFactoryLinkedServiceSqlManagedInstance
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.dataFactoryLinkedServiceSqlManagedInstance.DataFactoryLinkedServiceSqlManagedInstanceKeyVaultConnectionString")]
    public class DataFactoryLinkedServiceSqlManagedInstanceKeyVaultConnectionString : azurerm.DataFactoryLinkedServiceSqlManagedInstance.IDataFactoryLinkedServiceSqlManagedInstanceKeyVaultConnectionString
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_factory_linked_service_sql_managed_instance#linked_service_name DataFactoryLinkedServiceSqlManagedInstance#linked_service_name}.</summary>
        [JsiiProperty(name: "linkedServiceName", typeJson: "{\"primitive\":\"string\"}")]
        public string LinkedServiceName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/data_factory_linked_service_sql_managed_instance#secret_name DataFactoryLinkedServiceSqlManagedInstance#secret_name}.</summary>
        [JsiiProperty(name: "secretName", typeJson: "{\"primitive\":\"string\"}")]
        public string SecretName
        {
            get;
            set;
        }
    }
}
