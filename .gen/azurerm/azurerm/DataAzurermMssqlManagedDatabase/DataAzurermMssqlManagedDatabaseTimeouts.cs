using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermMssqlManagedDatabase
{
    [JsiiByValue(fqn: "azurerm.dataAzurermMssqlManagedDatabase.DataAzurermMssqlManagedDatabaseTimeouts")]
    public class DataAzurermMssqlManagedDatabaseTimeouts : azurerm.DataAzurermMssqlManagedDatabase.IDataAzurermMssqlManagedDatabaseTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/data-sources/mssql_managed_database#read DataAzurermMssqlManagedDatabase#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
