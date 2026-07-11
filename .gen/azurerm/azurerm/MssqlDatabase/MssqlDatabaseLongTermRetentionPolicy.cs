using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MssqlDatabase
{
    [JsiiByValue(fqn: "azurerm.mssqlDatabase.MssqlDatabaseLongTermRetentionPolicy")]
    public class MssqlDatabaseLongTermRetentionPolicy : azurerm.MssqlDatabase.IMssqlDatabaseLongTermRetentionPolicy
    {
        private object? _immutableBackupsEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/mssql_database#immutable_backups_enabled MssqlDatabase#immutable_backups_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "immutableBackupsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ImmutableBackupsEnabled
        {
            get => _immutableBackupsEnabled;
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
                _immutableBackupsEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/mssql_database#monthly_retention MssqlDatabase#monthly_retention}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "monthlyRetention", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MonthlyRetention
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/mssql_database#weekly_retention MssqlDatabase#weekly_retention}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "weeklyRetention", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WeeklyRetention
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/mssql_database#week_of_year MssqlDatabase#week_of_year}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "weekOfYear", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? WeekOfYear
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/mssql_database#yearly_retention MssqlDatabase#yearly_retention}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "yearlyRetention", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? YearlyRetention
        {
            get;
            set;
        }
    }
}
