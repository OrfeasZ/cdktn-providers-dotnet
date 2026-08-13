using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataFactoryIntegrationRuntimeAzureSsis
{
    [JsiiByValue(fqn: "azurerm.dataFactoryIntegrationRuntimeAzureSsis.DataFactoryIntegrationRuntimeAzureSsisExpressCustomSetup")]
    public class DataFactoryIntegrationRuntimeAzureSsisExpressCustomSetup : azurerm.DataFactoryIntegrationRuntimeAzureSsis.IDataFactoryIntegrationRuntimeAzureSsisExpressCustomSetup
    {
        private object? _commandKey;

        /// <summary>command_key block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/data_factory_integration_runtime_azure_ssis#command_key DataFactoryIntegrationRuntimeAzureSsis#command_key}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.DataFactoryIntegrationRuntimeAzureSsis.IDataFactoryIntegrationRuntimeAzureSsisExpressCustomSetupCommandKey" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "commandKey", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.dataFactoryIntegrationRuntimeAzureSsis.DataFactoryIntegrationRuntimeAzureSsisExpressCustomSetupCommandKey\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CommandKey
        {
            get => _commandKey;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.DataFactoryIntegrationRuntimeAzureSsis.IDataFactoryIntegrationRuntimeAzureSsisExpressCustomSetupCommandKey[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.DataFactoryIntegrationRuntimeAzureSsis.IDataFactoryIntegrationRuntimeAzureSsisExpressCustomSetupCommandKey).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _commandKey = value;
            }
        }

        private object? _component;

        /// <summary>component block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/data_factory_integration_runtime_azure_ssis#component DataFactoryIntegrationRuntimeAzureSsis#component}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.DataFactoryIntegrationRuntimeAzureSsis.IDataFactoryIntegrationRuntimeAzureSsisExpressCustomSetupComponent" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "component", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.dataFactoryIntegrationRuntimeAzureSsis.DataFactoryIntegrationRuntimeAzureSsisExpressCustomSetupComponent\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Component
        {
            get => _component;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.DataFactoryIntegrationRuntimeAzureSsis.IDataFactoryIntegrationRuntimeAzureSsisExpressCustomSetupComponent[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.DataFactoryIntegrationRuntimeAzureSsis.IDataFactoryIntegrationRuntimeAzureSsisExpressCustomSetupComponent).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _component = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/data_factory_integration_runtime_azure_ssis#environment DataFactoryIntegrationRuntimeAzureSsis#environment}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "environment", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Environment
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/data_factory_integration_runtime_azure_ssis#powershell_version DataFactoryIntegrationRuntimeAzureSsis#powershell_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "powershellVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PowershellVersion
        {
            get;
            set;
        }
    }
}
