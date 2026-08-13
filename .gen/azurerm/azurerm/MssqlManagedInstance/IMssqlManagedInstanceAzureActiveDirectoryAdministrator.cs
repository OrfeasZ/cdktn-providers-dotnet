using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MssqlManagedInstance
{
    [JsiiInterface(nativeType: typeof(IMssqlManagedInstanceAzureActiveDirectoryAdministrator), fullyQualifiedName: "azurerm.mssqlManagedInstance.MssqlManagedInstanceAzureActiveDirectoryAdministrator")]
    public interface IMssqlManagedInstanceAzureActiveDirectoryAdministrator
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/mssql_managed_instance#login_username MssqlManagedInstance#login_username}.</summary>
        [JsiiProperty(name: "loginUsername", typeJson: "{\"primitive\":\"string\"}")]
        string LoginUsername
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/mssql_managed_instance#object_id MssqlManagedInstance#object_id}.</summary>
        [JsiiProperty(name: "objectId", typeJson: "{\"primitive\":\"string\"}")]
        string ObjectId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/mssql_managed_instance#principal_type MssqlManagedInstance#principal_type}.</summary>
        [JsiiProperty(name: "principalType", typeJson: "{\"primitive\":\"string\"}")]
        string PrincipalType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/mssql_managed_instance#azuread_authentication_only_enabled MssqlManagedInstance#azuread_authentication_only_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "azureadAuthenticationOnlyEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AzureadAuthenticationOnlyEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/mssql_managed_instance#tenant_id MssqlManagedInstance#tenant_id}.</summary>
        [JsiiProperty(name: "tenantId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TenantId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMssqlManagedInstanceAzureActiveDirectoryAdministrator), fullyQualifiedName: "azurerm.mssqlManagedInstance.MssqlManagedInstanceAzureActiveDirectoryAdministrator")]
        internal sealed class _Proxy : DeputyBase, azurerm.MssqlManagedInstance.IMssqlManagedInstanceAzureActiveDirectoryAdministrator
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/mssql_managed_instance#login_username MssqlManagedInstance#login_username}.</summary>
            [JsiiProperty(name: "loginUsername", typeJson: "{\"primitive\":\"string\"}")]
            public string LoginUsername
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/mssql_managed_instance#object_id MssqlManagedInstance#object_id}.</summary>
            [JsiiProperty(name: "objectId", typeJson: "{\"primitive\":\"string\"}")]
            public string ObjectId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/mssql_managed_instance#principal_type MssqlManagedInstance#principal_type}.</summary>
            [JsiiProperty(name: "principalType", typeJson: "{\"primitive\":\"string\"}")]
            public string PrincipalType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/mssql_managed_instance#azuread_authentication_only_enabled MssqlManagedInstance#azuread_authentication_only_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "azureadAuthenticationOnlyEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AzureadAuthenticationOnlyEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/mssql_managed_instance#tenant_id MssqlManagedInstance#tenant_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tenantId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TenantId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
