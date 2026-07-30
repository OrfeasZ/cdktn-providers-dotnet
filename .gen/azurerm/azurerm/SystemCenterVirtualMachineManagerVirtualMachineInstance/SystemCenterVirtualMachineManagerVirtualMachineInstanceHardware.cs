using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SystemCenterVirtualMachineManagerVirtualMachineInstance
{
    [JsiiByValue(fqn: "azurerm.systemCenterVirtualMachineManagerVirtualMachineInstance.SystemCenterVirtualMachineManagerVirtualMachineInstanceHardware")]
    public class SystemCenterVirtualMachineManagerVirtualMachineInstanceHardware : azurerm.SystemCenterVirtualMachineManagerVirtualMachineInstance.ISystemCenterVirtualMachineManagerVirtualMachineInstanceHardware
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance#cpu_count SystemCenterVirtualMachineManagerVirtualMachineInstance#cpu_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cpuCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? CpuCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance#dynamic_memory_max_in_mb SystemCenterVirtualMachineManagerVirtualMachineInstance#dynamic_memory_max_in_mb}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dynamicMemoryMaxInMb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DynamicMemoryMaxInMb
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance#dynamic_memory_min_in_mb SystemCenterVirtualMachineManagerVirtualMachineInstance#dynamic_memory_min_in_mb}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dynamicMemoryMinInMb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DynamicMemoryMinInMb
        {
            get;
            set;
        }

        private object? _limitCpuForMigrationEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance#limit_cpu_for_migration_enabled SystemCenterVirtualMachineManagerVirtualMachineInstance#limit_cpu_for_migration_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "limitCpuForMigrationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? LimitCpuForMigrationEnabled
        {
            get => _limitCpuForMigrationEnabled;
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
                _limitCpuForMigrationEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance#memory_in_mb SystemCenterVirtualMachineManagerVirtualMachineInstance#memory_in_mb}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "memoryInMb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MemoryInMb
        {
            get;
            set;
        }
    }
}
