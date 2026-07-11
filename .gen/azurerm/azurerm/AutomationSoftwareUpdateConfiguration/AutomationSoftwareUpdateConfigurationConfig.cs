using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AutomationSoftwareUpdateConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.automationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationConfig")]
    public class AutomationSoftwareUpdateConfigurationConfig : azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/automation_software_update_configuration#automation_account_id AutomationSoftwareUpdateConfiguration#automation_account_id}.</summary>
        [JsiiProperty(name: "automationAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public string AutomationAccountId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/automation_software_update_configuration#name AutomationSoftwareUpdateConfiguration#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/automation_software_update_configuration#schedule AutomationSoftwareUpdateConfiguration#schedule}
        /// </remarks>
        [JsiiProperty(name: "schedule", typeJson: "{\"fqn\":\"azurerm.automationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationSchedule\"}")]
        public azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationSchedule Schedule
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/automation_software_update_configuration#duration AutomationSoftwareUpdateConfiguration#duration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Duration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/automation_software_update_configuration#id AutomationSoftwareUpdateConfiguration#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Id
        {
            get;
            set;
        }

        /// <summary>linux block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/automation_software_update_configuration#linux AutomationSoftwareUpdateConfiguration#linux}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "linux", typeJson: "{\"fqn\":\"azurerm.automationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationLinux\"}", isOptional: true)]
        public azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationLinux? Linux
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/automation_software_update_configuration#non_azure_computer_names AutomationSoftwareUpdateConfiguration#non_azure_computer_names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nonAzureComputerNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? NonAzureComputerNames
        {
            get;
            set;
        }

        /// <summary>post_task block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/automation_software_update_configuration#post_task AutomationSoftwareUpdateConfiguration#post_task}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "postTask", typeJson: "{\"fqn\":\"azurerm.automationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationPostTask\"}", isOptional: true)]
        public azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationPostTask? PostTask
        {
            get;
            set;
        }

        /// <summary>pre_task block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/automation_software_update_configuration#pre_task AutomationSoftwareUpdateConfiguration#pre_task}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "preTask", typeJson: "{\"fqn\":\"azurerm.automationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationPreTask\"}", isOptional: true)]
        public azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationPreTask? PreTask
        {
            get;
            set;
        }

        /// <summary>target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/automation_software_update_configuration#target AutomationSoftwareUpdateConfiguration#target}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"azurerm.automationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationTarget\"}", isOptional: true)]
        public azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationTarget? Target
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/automation_software_update_configuration#timeouts AutomationSoftwareUpdateConfiguration#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.automationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationTimeouts\"}", isOptional: true)]
        public azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationTimeouts? Timeouts
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/automation_software_update_configuration#virtual_machine_ids AutomationSoftwareUpdateConfiguration#virtual_machine_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "virtualMachineIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? VirtualMachineIds
        {
            get;
            set;
        }

        /// <summary>windows block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/automation_software_update_configuration#windows AutomationSoftwareUpdateConfiguration#windows}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "windows", typeJson: "{\"fqn\":\"azurerm.automationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationWindows\"}", isOptional: true)]
        public azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationWindows? Windows
        {
            get;
            set;
        }

        private object? _connection;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
        public object? Connection
        {
            get => _connection;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.ISSHProvisionerConnection cast_cd4240:
                            break;
                        case Io.Cdktn.IWinrmProvisionerConnection cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.ISSHProvisionerConnection).FullName}, {typeof(Io.Cdktn.IWinrmProvisionerConnection).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _connection = value;
            }
        }

        private object? _count;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
        public object? Count
        {
            get => _count;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case double cast_cd4240:
                            break;
                        case byte cast_cd4240:
                            break;
                        case decimal cast_cd4240:
                            break;
                        case float cast_cd4240:
                            break;
                        case int cast_cd4240:
                            break;
                        case long cast_cd4240:
                            break;
                        case sbyte cast_cd4240:
                            break;
                        case short cast_cd4240:
                            break;
                        case uint cast_cd4240:
                            break;
                        case ulong cast_cd4240:
                            break;
                        case ushort cast_cd4240:
                            break;
                        case Io.Cdktn.TerraformCount cast_cd4240:
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: double, {typeof(Io.Cdktn.TerraformCount).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _count = value;
            }
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public Io.Cdktn.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
        public Io.Cdktn.ITerraformIterator? ForEach
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
        public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
        public Io.Cdktn.TerraformProvider? Provider
        {
            get;
            set;
        }

        private object[]? _provisioners;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
        public object[]? Provisioners
        {
            get => _provisioners;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    for (var __idx_cd4240 = 0 ; __idx_cd4240 < value.Length ; __idx_cd4240++)
                    {
                        switch (value[__idx_cd4240])
                        {
                            case Io.Cdktn.IFileProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.ILocalExecProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.IRemoteExecProvisioner cast_e9c63e:
                                break;
                            case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_e9c63e:
                                // Not enough information to type-check...
                                break;
                            case null:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received null", nameof(value));
                            default:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received {value[__idx_cd4240].GetType().FullName}", nameof(value));
                        }
                    }
                }
                _provisioners = value;
            }
        }
    }
}
