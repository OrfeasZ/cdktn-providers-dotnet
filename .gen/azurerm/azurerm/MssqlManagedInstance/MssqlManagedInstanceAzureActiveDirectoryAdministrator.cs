using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MssqlManagedInstance
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.mssqlManagedInstance.MssqlManagedInstanceAzureActiveDirectoryAdministrator")]
    public class MssqlManagedInstanceAzureActiveDirectoryAdministrator : azurerm.MssqlManagedInstance.IMssqlManagedInstanceAzureActiveDirectoryAdministrator
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/mssql_managed_instance#login_username MssqlManagedInstance#login_username}.</summary>
        [JsiiProperty(name: "loginUsername", typeJson: "{\"primitive\":\"string\"}")]
        public string LoginUsername
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/mssql_managed_instance#object_id MssqlManagedInstance#object_id}.</summary>
        [JsiiProperty(name: "objectId", typeJson: "{\"primitive\":\"string\"}")]
        public string ObjectId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/mssql_managed_instance#principal_type MssqlManagedInstance#principal_type}.</summary>
        [JsiiProperty(name: "principalType", typeJson: "{\"primitive\":\"string\"}")]
        public string PrincipalType
        {
            get;
            set;
        }

        private object? _azureadAuthenticationOnlyEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/mssql_managed_instance#azuread_authentication_only_enabled MssqlManagedInstance#azuread_authentication_only_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "azureadAuthenticationOnlyEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? AzureadAuthenticationOnlyEnabled
        {
            get => _azureadAuthenticationOnlyEnabled;
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
                _azureadAuthenticationOnlyEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/mssql_managed_instance#tenant_id MssqlManagedInstance#tenant_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tenantId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TenantId
        {
            get;
            set;
        }
    }
}
