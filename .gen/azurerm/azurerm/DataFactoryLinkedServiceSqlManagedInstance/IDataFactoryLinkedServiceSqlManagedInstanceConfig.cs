using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataFactoryLinkedServiceSqlManagedInstance
{
    [JsiiInterface(nativeType: typeof(IDataFactoryLinkedServiceSqlManagedInstanceConfig), fullyQualifiedName: "azurerm.dataFactoryLinkedServiceSqlManagedInstance.DataFactoryLinkedServiceSqlManagedInstanceConfig")]
    public interface IDataFactoryLinkedServiceSqlManagedInstanceConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_sql_managed_instance#data_factory_id DataFactoryLinkedServiceSqlManagedInstance#data_factory_id}.</summary>
        [JsiiProperty(name: "dataFactoryId", typeJson: "{\"primitive\":\"string\"}")]
        string DataFactoryId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_sql_managed_instance#name DataFactoryLinkedServiceSqlManagedInstance#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_sql_managed_instance#annotations DataFactoryLinkedServiceSqlManagedInstance#annotations}.</summary>
        [JsiiProperty(name: "annotations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Annotations
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_sql_managed_instance#connection_string DataFactoryLinkedServiceSqlManagedInstance#connection_string}.</summary>
        [JsiiProperty(name: "connectionString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConnectionString
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_sql_managed_instance#description DataFactoryLinkedServiceSqlManagedInstance#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_sql_managed_instance#id DataFactoryLinkedServiceSqlManagedInstance#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_sql_managed_instance#integration_runtime_name DataFactoryLinkedServiceSqlManagedInstance#integration_runtime_name}.</summary>
        [JsiiProperty(name: "integrationRuntimeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IntegrationRuntimeName
        {
            get
            {
                return null;
            }
        }

        /// <summary>key_vault_connection_string block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_sql_managed_instance#key_vault_connection_string DataFactoryLinkedServiceSqlManagedInstance#key_vault_connection_string}
        /// </remarks>
        [JsiiProperty(name: "keyVaultConnectionString", typeJson: "{\"fqn\":\"azurerm.dataFactoryLinkedServiceSqlManagedInstance.DataFactoryLinkedServiceSqlManagedInstanceKeyVaultConnectionString\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.DataFactoryLinkedServiceSqlManagedInstance.IDataFactoryLinkedServiceSqlManagedInstanceKeyVaultConnectionString? KeyVaultConnectionString
        {
            get
            {
                return null;
            }
        }

        /// <summary>key_vault_password block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_sql_managed_instance#key_vault_password DataFactoryLinkedServiceSqlManagedInstance#key_vault_password}
        /// </remarks>
        [JsiiProperty(name: "keyVaultPassword", typeJson: "{\"fqn\":\"azurerm.dataFactoryLinkedServiceSqlManagedInstance.DataFactoryLinkedServiceSqlManagedInstanceKeyVaultPassword\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.DataFactoryLinkedServiceSqlManagedInstance.IDataFactoryLinkedServiceSqlManagedInstanceKeyVaultPassword? KeyVaultPassword
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_sql_managed_instance#parameters DataFactoryLinkedServiceSqlManagedInstance#parameters}.</summary>
        [JsiiProperty(name: "parameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Parameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_sql_managed_instance#service_principal_id DataFactoryLinkedServiceSqlManagedInstance#service_principal_id}.</summary>
        [JsiiProperty(name: "servicePrincipalId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServicePrincipalId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_sql_managed_instance#service_principal_key DataFactoryLinkedServiceSqlManagedInstance#service_principal_key}.</summary>
        [JsiiProperty(name: "servicePrincipalKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServicePrincipalKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_sql_managed_instance#tenant DataFactoryLinkedServiceSqlManagedInstance#tenant}.</summary>
        [JsiiProperty(name: "tenant", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Tenant
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_sql_managed_instance#timeouts DataFactoryLinkedServiceSqlManagedInstance#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataFactoryLinkedServiceSqlManagedInstance.DataFactoryLinkedServiceSqlManagedInstanceTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.DataFactoryLinkedServiceSqlManagedInstance.IDataFactoryLinkedServiceSqlManagedInstanceTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataFactoryLinkedServiceSqlManagedInstanceConfig), fullyQualifiedName: "azurerm.dataFactoryLinkedServiceSqlManagedInstance.DataFactoryLinkedServiceSqlManagedInstanceConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataFactoryLinkedServiceSqlManagedInstance.IDataFactoryLinkedServiceSqlManagedInstanceConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_sql_managed_instance#data_factory_id DataFactoryLinkedServiceSqlManagedInstance#data_factory_id}.</summary>
            [JsiiProperty(name: "dataFactoryId", typeJson: "{\"primitive\":\"string\"}")]
            public string DataFactoryId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_sql_managed_instance#name DataFactoryLinkedServiceSqlManagedInstance#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_sql_managed_instance#annotations DataFactoryLinkedServiceSqlManagedInstance#annotations}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "annotations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Annotations
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_sql_managed_instance#connection_string DataFactoryLinkedServiceSqlManagedInstance#connection_string}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "connectionString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConnectionString
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_sql_managed_instance#description DataFactoryLinkedServiceSqlManagedInstance#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_sql_managed_instance#id DataFactoryLinkedServiceSqlManagedInstance#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_sql_managed_instance#integration_runtime_name DataFactoryLinkedServiceSqlManagedInstance#integration_runtime_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "integrationRuntimeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IntegrationRuntimeName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>key_vault_connection_string block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_sql_managed_instance#key_vault_connection_string DataFactoryLinkedServiceSqlManagedInstance#key_vault_connection_string}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "keyVaultConnectionString", typeJson: "{\"fqn\":\"azurerm.dataFactoryLinkedServiceSqlManagedInstance.DataFactoryLinkedServiceSqlManagedInstanceKeyVaultConnectionString\"}", isOptional: true)]
            public azurerm.DataFactoryLinkedServiceSqlManagedInstance.IDataFactoryLinkedServiceSqlManagedInstanceKeyVaultConnectionString? KeyVaultConnectionString
            {
                get => GetInstanceProperty<azurerm.DataFactoryLinkedServiceSqlManagedInstance.IDataFactoryLinkedServiceSqlManagedInstanceKeyVaultConnectionString?>();
            }

            /// <summary>key_vault_password block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_sql_managed_instance#key_vault_password DataFactoryLinkedServiceSqlManagedInstance#key_vault_password}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "keyVaultPassword", typeJson: "{\"fqn\":\"azurerm.dataFactoryLinkedServiceSqlManagedInstance.DataFactoryLinkedServiceSqlManagedInstanceKeyVaultPassword\"}", isOptional: true)]
            public azurerm.DataFactoryLinkedServiceSqlManagedInstance.IDataFactoryLinkedServiceSqlManagedInstanceKeyVaultPassword? KeyVaultPassword
            {
                get => GetInstanceProperty<azurerm.DataFactoryLinkedServiceSqlManagedInstance.IDataFactoryLinkedServiceSqlManagedInstanceKeyVaultPassword?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_sql_managed_instance#parameters DataFactoryLinkedServiceSqlManagedInstance#parameters}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "parameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Parameters
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_sql_managed_instance#service_principal_id DataFactoryLinkedServiceSqlManagedInstance#service_principal_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "servicePrincipalId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServicePrincipalId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_sql_managed_instance#service_principal_key DataFactoryLinkedServiceSqlManagedInstance#service_principal_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "servicePrincipalKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServicePrincipalKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_sql_managed_instance#tenant DataFactoryLinkedServiceSqlManagedInstance#tenant}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tenant", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Tenant
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/data_factory_linked_service_sql_managed_instance#timeouts DataFactoryLinkedServiceSqlManagedInstance#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataFactoryLinkedServiceSqlManagedInstance.DataFactoryLinkedServiceSqlManagedInstanceTimeouts\"}", isOptional: true)]
            public azurerm.DataFactoryLinkedServiceSqlManagedInstance.IDataFactoryLinkedServiceSqlManagedInstanceTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.DataFactoryLinkedServiceSqlManagedInstance.IDataFactoryLinkedServiceSqlManagedInstanceTimeouts?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
