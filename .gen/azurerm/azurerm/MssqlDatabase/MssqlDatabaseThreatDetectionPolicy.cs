using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MssqlDatabase
{
    [JsiiByValue(fqn: "azurerm.mssqlDatabase.MssqlDatabaseThreatDetectionPolicy")]
    public class MssqlDatabaseThreatDetectionPolicy : azurerm.MssqlDatabase.IMssqlDatabaseThreatDetectionPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/mssql_database#disabled_alerts MssqlDatabase#disabled_alerts}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "disabledAlerts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? DisabledAlerts
        {
            get;
            set;
        }

        private object? _emailAccountAdminsEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/mssql_database#email_account_admins_enabled MssqlDatabase#email_account_admins_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "emailAccountAdminsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? EmailAccountAdminsEnabled
        {
            get => _emailAccountAdminsEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _emailAccountAdminsEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/mssql_database#email_addresses MssqlDatabase#email_addresses}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "emailAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? EmailAddresses
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/mssql_database#retention_days MssqlDatabase#retention_days}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "retentionDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RetentionDays
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/mssql_database#state MssqlDatabase#state}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? State
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/mssql_database#storage_account_access_key MssqlDatabase#storage_account_access_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "storageAccountAccessKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StorageAccountAccessKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/mssql_database#storage_endpoint MssqlDatabase#storage_endpoint}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "storageEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StorageEndpoint
        {
            get;
            set;
        }
    }
}
