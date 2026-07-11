using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SystemCenterVirtualMachineManagerVirtualMachineInstance
{
    [JsiiInterface(nativeType: typeof(ISystemCenterVirtualMachineManagerVirtualMachineInstanceInfrastructure), fullyQualifiedName: "azurerm.systemCenterVirtualMachineManagerVirtualMachineInstance.SystemCenterVirtualMachineManagerVirtualMachineInstanceInfrastructure")]
    public interface ISystemCenterVirtualMachineManagerVirtualMachineInstanceInfrastructure
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance#checkpoint_type SystemCenterVirtualMachineManagerVirtualMachineInstance#checkpoint_type}.</summary>
        [JsiiProperty(name: "checkpointType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CheckpointType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance#system_center_virtual_machine_manager_cloud_id SystemCenterVirtualMachineManagerVirtualMachineInstance#system_center_virtual_machine_manager_cloud_id}.</summary>
        [JsiiProperty(name: "systemCenterVirtualMachineManagerCloudId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SystemCenterVirtualMachineManagerCloudId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance#system_center_virtual_machine_manager_inventory_item_id SystemCenterVirtualMachineManagerVirtualMachineInstance#system_center_virtual_machine_manager_inventory_item_id}.</summary>
        [JsiiProperty(name: "systemCenterVirtualMachineManagerInventoryItemId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SystemCenterVirtualMachineManagerInventoryItemId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance#system_center_virtual_machine_manager_template_id SystemCenterVirtualMachineManagerVirtualMachineInstance#system_center_virtual_machine_manager_template_id}.</summary>
        [JsiiProperty(name: "systemCenterVirtualMachineManagerTemplateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SystemCenterVirtualMachineManagerTemplateId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance#system_center_virtual_machine_manager_virtual_machine_server_id SystemCenterVirtualMachineManagerVirtualMachineInstance#system_center_virtual_machine_manager_virtual_machine_server_id}.</summary>
        [JsiiProperty(name: "systemCenterVirtualMachineManagerVirtualMachineServerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SystemCenterVirtualMachineManagerVirtualMachineServerId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISystemCenterVirtualMachineManagerVirtualMachineInstanceInfrastructure), fullyQualifiedName: "azurerm.systemCenterVirtualMachineManagerVirtualMachineInstance.SystemCenterVirtualMachineManagerVirtualMachineInstanceInfrastructure")]
        internal sealed class _Proxy : DeputyBase, azurerm.SystemCenterVirtualMachineManagerVirtualMachineInstance.ISystemCenterVirtualMachineManagerVirtualMachineInstanceInfrastructure
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance#checkpoint_type SystemCenterVirtualMachineManagerVirtualMachineInstance#checkpoint_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "checkpointType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CheckpointType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance#system_center_virtual_machine_manager_cloud_id SystemCenterVirtualMachineManagerVirtualMachineInstance#system_center_virtual_machine_manager_cloud_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "systemCenterVirtualMachineManagerCloudId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SystemCenterVirtualMachineManagerCloudId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance#system_center_virtual_machine_manager_inventory_item_id SystemCenterVirtualMachineManagerVirtualMachineInstance#system_center_virtual_machine_manager_inventory_item_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "systemCenterVirtualMachineManagerInventoryItemId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SystemCenterVirtualMachineManagerInventoryItemId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance#system_center_virtual_machine_manager_template_id SystemCenterVirtualMachineManagerVirtualMachineInstance#system_center_virtual_machine_manager_template_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "systemCenterVirtualMachineManagerTemplateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SystemCenterVirtualMachineManagerTemplateId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/system_center_virtual_machine_manager_virtual_machine_instance#system_center_virtual_machine_manager_virtual_machine_server_id SystemCenterVirtualMachineManagerVirtualMachineInstance#system_center_virtual_machine_manager_virtual_machine_server_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "systemCenterVirtualMachineManagerVirtualMachineServerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SystemCenterVirtualMachineManagerVirtualMachineServerId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
