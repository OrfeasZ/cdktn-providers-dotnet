using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ArcMachine
{
    [JsiiInterface(nativeType: typeof(IArcMachineIdentity), fullyQualifiedName: "azurerm.arcMachine.ArcMachineIdentity")]
    public interface IArcMachineIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/arc_machine#type ArcMachine#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IArcMachineIdentity), fullyQualifiedName: "azurerm.arcMachine.ArcMachineIdentity")]
        internal sealed class _Proxy : DeputyBase, azurerm.ArcMachine.IArcMachineIdentity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/arc_machine#type ArcMachine#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
