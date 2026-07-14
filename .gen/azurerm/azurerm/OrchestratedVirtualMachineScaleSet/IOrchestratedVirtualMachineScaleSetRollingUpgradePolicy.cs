using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.OrchestratedVirtualMachineScaleSet
{
    [JsiiInterface(nativeType: typeof(IOrchestratedVirtualMachineScaleSetRollingUpgradePolicy), fullyQualifiedName: "azurerm.orchestratedVirtualMachineScaleSet.OrchestratedVirtualMachineScaleSetRollingUpgradePolicy")]
    public interface IOrchestratedVirtualMachineScaleSetRollingUpgradePolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/orchestrated_virtual_machine_scale_set#max_batch_instance_percent OrchestratedVirtualMachineScaleSet#max_batch_instance_percent}.</summary>
        [JsiiProperty(name: "maxBatchInstancePercent", typeJson: "{\"primitive\":\"number\"}")]
        double MaxBatchInstancePercent
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/orchestrated_virtual_machine_scale_set#max_unhealthy_instance_percent OrchestratedVirtualMachineScaleSet#max_unhealthy_instance_percent}.</summary>
        [JsiiProperty(name: "maxUnhealthyInstancePercent", typeJson: "{\"primitive\":\"number\"}")]
        double MaxUnhealthyInstancePercent
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/orchestrated_virtual_machine_scale_set#max_unhealthy_upgraded_instance_percent OrchestratedVirtualMachineScaleSet#max_unhealthy_upgraded_instance_percent}.</summary>
        [JsiiProperty(name: "maxUnhealthyUpgradedInstancePercent", typeJson: "{\"primitive\":\"number\"}")]
        double MaxUnhealthyUpgradedInstancePercent
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/orchestrated_virtual_machine_scale_set#pause_time_between_batches OrchestratedVirtualMachineScaleSet#pause_time_between_batches}.</summary>
        [JsiiProperty(name: "pauseTimeBetweenBatches", typeJson: "{\"primitive\":\"string\"}")]
        string PauseTimeBetweenBatches
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/orchestrated_virtual_machine_scale_set#cross_zone_upgrades_enabled OrchestratedVirtualMachineScaleSet#cross_zone_upgrades_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "crossZoneUpgradesEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CrossZoneUpgradesEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/orchestrated_virtual_machine_scale_set#maximum_surge_instances_enabled OrchestratedVirtualMachineScaleSet#maximum_surge_instances_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "maximumSurgeInstancesEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MaximumSurgeInstancesEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/orchestrated_virtual_machine_scale_set#prioritize_unhealthy_instances_enabled OrchestratedVirtualMachineScaleSet#prioritize_unhealthy_instances_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "prioritizeUnhealthyInstancesEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PrioritizeUnhealthyInstancesEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOrchestratedVirtualMachineScaleSetRollingUpgradePolicy), fullyQualifiedName: "azurerm.orchestratedVirtualMachineScaleSet.OrchestratedVirtualMachineScaleSetRollingUpgradePolicy")]
        internal sealed class _Proxy : DeputyBase, azurerm.OrchestratedVirtualMachineScaleSet.IOrchestratedVirtualMachineScaleSetRollingUpgradePolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/orchestrated_virtual_machine_scale_set#max_batch_instance_percent OrchestratedVirtualMachineScaleSet#max_batch_instance_percent}.</summary>
            [JsiiProperty(name: "maxBatchInstancePercent", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxBatchInstancePercent
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/orchestrated_virtual_machine_scale_set#max_unhealthy_instance_percent OrchestratedVirtualMachineScaleSet#max_unhealthy_instance_percent}.</summary>
            [JsiiProperty(name: "maxUnhealthyInstancePercent", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxUnhealthyInstancePercent
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/orchestrated_virtual_machine_scale_set#max_unhealthy_upgraded_instance_percent OrchestratedVirtualMachineScaleSet#max_unhealthy_upgraded_instance_percent}.</summary>
            [JsiiProperty(name: "maxUnhealthyUpgradedInstancePercent", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxUnhealthyUpgradedInstancePercent
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/orchestrated_virtual_machine_scale_set#pause_time_between_batches OrchestratedVirtualMachineScaleSet#pause_time_between_batches}.</summary>
            [JsiiProperty(name: "pauseTimeBetweenBatches", typeJson: "{\"primitive\":\"string\"}")]
            public string PauseTimeBetweenBatches
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/orchestrated_virtual_machine_scale_set#cross_zone_upgrades_enabled OrchestratedVirtualMachineScaleSet#cross_zone_upgrades_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "crossZoneUpgradesEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? CrossZoneUpgradesEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/orchestrated_virtual_machine_scale_set#maximum_surge_instances_enabled OrchestratedVirtualMachineScaleSet#maximum_surge_instances_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maximumSurgeInstancesEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? MaximumSurgeInstancesEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/orchestrated_virtual_machine_scale_set#prioritize_unhealthy_instances_enabled OrchestratedVirtualMachineScaleSet#prioritize_unhealthy_instances_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "prioritizeUnhealthyInstancesEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? PrioritizeUnhealthyInstancesEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
