using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.OrchestratedVirtualMachineScaleSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.orchestratedVirtualMachineScaleSet.OrchestratedVirtualMachineScaleSetOsProfileWindowsConfiguration")]
    public class OrchestratedVirtualMachineScaleSetOsProfileWindowsConfiguration : azurerm.OrchestratedVirtualMachineScaleSet.IOrchestratedVirtualMachineScaleSetOsProfileWindowsConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/orchestrated_virtual_machine_scale_set#admin_password OrchestratedVirtualMachineScaleSet#admin_password}.</summary>
        [JsiiProperty(name: "adminPassword", typeJson: "{\"primitive\":\"string\"}")]
        public string AdminPassword
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/orchestrated_virtual_machine_scale_set#admin_username OrchestratedVirtualMachineScaleSet#admin_username}.</summary>
        [JsiiProperty(name: "adminUsername", typeJson: "{\"primitive\":\"string\"}")]
        public string AdminUsername
        {
            get;
            set;
        }

        private object? _additionalUnattendContent;

        /// <summary>additional_unattend_content block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/orchestrated_virtual_machine_scale_set#additional_unattend_content OrchestratedVirtualMachineScaleSet#additional_unattend_content}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.OrchestratedVirtualMachineScaleSet.IOrchestratedVirtualMachineScaleSetOsProfileWindowsConfigurationAdditionalUnattendContent" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "additionalUnattendContent", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.orchestratedVirtualMachineScaleSet.OrchestratedVirtualMachineScaleSetOsProfileWindowsConfigurationAdditionalUnattendContent\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AdditionalUnattendContent
        {
            get => _additionalUnattendContent;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.OrchestratedVirtualMachineScaleSet.IOrchestratedVirtualMachineScaleSetOsProfileWindowsConfigurationAdditionalUnattendContent[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.OrchestratedVirtualMachineScaleSet.IOrchestratedVirtualMachineScaleSetOsProfileWindowsConfigurationAdditionalUnattendContent).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _additionalUnattendContent = value;
            }
        }

        private object? _automaticUpdatesEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/orchestrated_virtual_machine_scale_set#automatic_updates_enabled OrchestratedVirtualMachineScaleSet#automatic_updates_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "automaticUpdatesEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? AutomaticUpdatesEnabled
        {
            get => _automaticUpdatesEnabled;
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
                _automaticUpdatesEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/orchestrated_virtual_machine_scale_set#computer_name_prefix OrchestratedVirtualMachineScaleSet#computer_name_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "computerNamePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ComputerNamePrefix
        {
            get;
            set;
        }

        private object? _hotpatchingEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/orchestrated_virtual_machine_scale_set#hotpatching_enabled OrchestratedVirtualMachineScaleSet#hotpatching_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hotpatchingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? HotpatchingEnabled
        {
            get => _hotpatchingEnabled;
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
                _hotpatchingEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/orchestrated_virtual_machine_scale_set#patch_assessment_mode OrchestratedVirtualMachineScaleSet#patch_assessment_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "patchAssessmentMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PatchAssessmentMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/orchestrated_virtual_machine_scale_set#patch_mode OrchestratedVirtualMachineScaleSet#patch_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "patchMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PatchMode
        {
            get;
            set;
        }

        private object? _provisionVmAgent;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/orchestrated_virtual_machine_scale_set#provision_vm_agent OrchestratedVirtualMachineScaleSet#provision_vm_agent}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provisionVmAgent", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ProvisionVmAgent
        {
            get => _provisionVmAgent;
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
                _provisionVmAgent = value;
            }
        }

        private object? _secret;

        /// <summary>secret block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/orchestrated_virtual_machine_scale_set#secret OrchestratedVirtualMachineScaleSet#secret}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.OrchestratedVirtualMachineScaleSet.IOrchestratedVirtualMachineScaleSetOsProfileWindowsConfigurationSecret" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secret", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.orchestratedVirtualMachineScaleSet.OrchestratedVirtualMachineScaleSetOsProfileWindowsConfigurationSecret\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Secret
        {
            get => _secret;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.OrchestratedVirtualMachineScaleSet.IOrchestratedVirtualMachineScaleSetOsProfileWindowsConfigurationSecret[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.OrchestratedVirtualMachineScaleSet.IOrchestratedVirtualMachineScaleSetOsProfileWindowsConfigurationSecret).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _secret = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/orchestrated_virtual_machine_scale_set#timezone OrchestratedVirtualMachineScaleSet#timezone}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Timezone
        {
            get;
            set;
        }

        private object? _winrmListener;

        /// <summary>winrm_listener block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/orchestrated_virtual_machine_scale_set#winrm_listener OrchestratedVirtualMachineScaleSet#winrm_listener}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.OrchestratedVirtualMachineScaleSet.IOrchestratedVirtualMachineScaleSetOsProfileWindowsConfigurationWinrmListener" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "winrmListener", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.orchestratedVirtualMachineScaleSet.OrchestratedVirtualMachineScaleSetOsProfileWindowsConfigurationWinrmListener\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? WinrmListener
        {
            get => _winrmListener;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.OrchestratedVirtualMachineScaleSet.IOrchestratedVirtualMachineScaleSetOsProfileWindowsConfigurationWinrmListener[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.OrchestratedVirtualMachineScaleSet.IOrchestratedVirtualMachineScaleSetOsProfileWindowsConfigurationWinrmListener).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _winrmListener = value;
            }
        }
    }
}
