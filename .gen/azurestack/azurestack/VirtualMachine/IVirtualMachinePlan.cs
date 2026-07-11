using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.VirtualMachine
{
    [JsiiInterface(nativeType: typeof(IVirtualMachinePlan), fullyQualifiedName: "azurestack.virtualMachine.VirtualMachinePlan")]
    public interface IVirtualMachinePlan
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#name VirtualMachine#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#product VirtualMachine#product}.</summary>
        [JsiiProperty(name: "product", typeJson: "{\"primitive\":\"string\"}")]
        string Product
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#publisher VirtualMachine#publisher}.</summary>
        [JsiiProperty(name: "publisher", typeJson: "{\"primitive\":\"string\"}")]
        string Publisher
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IVirtualMachinePlan), fullyQualifiedName: "azurestack.virtualMachine.VirtualMachinePlan")]
        internal sealed class _Proxy : DeputyBase, azurestack.VirtualMachine.IVirtualMachinePlan
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#name VirtualMachine#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#product VirtualMachine#product}.</summary>
            [JsiiProperty(name: "product", typeJson: "{\"primitive\":\"string\"}")]
            public string Product
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_machine#publisher VirtualMachine#publisher}.</summary>
            [JsiiProperty(name: "publisher", typeJson: "{\"primitive\":\"string\"}")]
            public string Publisher
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
