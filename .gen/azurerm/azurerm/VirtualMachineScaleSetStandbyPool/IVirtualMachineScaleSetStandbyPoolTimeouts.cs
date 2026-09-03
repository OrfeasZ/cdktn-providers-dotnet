using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualMachineScaleSetStandbyPool
{
    [JsiiInterface(nativeType: typeof(IVirtualMachineScaleSetStandbyPoolTimeouts), fullyQualifiedName: "azurerm.virtualMachineScaleSetStandbyPool.VirtualMachineScaleSetStandbyPoolTimeouts")]
    public interface IVirtualMachineScaleSetStandbyPoolTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set_standby_pool#create VirtualMachineScaleSetStandbyPool#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set_standby_pool#delete VirtualMachineScaleSetStandbyPool#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set_standby_pool#read VirtualMachineScaleSetStandbyPool#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set_standby_pool#update VirtualMachineScaleSetStandbyPool#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVirtualMachineScaleSetStandbyPoolTimeouts), fullyQualifiedName: "azurerm.virtualMachineScaleSetStandbyPool.VirtualMachineScaleSetStandbyPoolTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.VirtualMachineScaleSetStandbyPool.IVirtualMachineScaleSetStandbyPoolTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set_standby_pool#create VirtualMachineScaleSetStandbyPool#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set_standby_pool#delete VirtualMachineScaleSetStandbyPool#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set_standby_pool#read VirtualMachineScaleSetStandbyPool#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/virtual_machine_scale_set_standby_pool#update VirtualMachineScaleSetStandbyPool#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
