using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.FabricCapacity
{
    [JsiiInterface(nativeType: typeof(IFabricCapacitySku), fullyQualifiedName: "azurerm.fabricCapacity.FabricCapacitySku")]
    public interface IFabricCapacitySku
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/fabric_capacity#name FabricCapacity#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/fabric_capacity#tier FabricCapacity#tier}.</summary>
        [JsiiProperty(name: "tier", typeJson: "{\"primitive\":\"string\"}")]
        string Tier
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IFabricCapacitySku), fullyQualifiedName: "azurerm.fabricCapacity.FabricCapacitySku")]
        internal sealed class _Proxy : DeputyBase, azurerm.FabricCapacity.IFabricCapacitySku
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/fabric_capacity#name FabricCapacity#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/fabric_capacity#tier FabricCapacity#tier}.</summary>
            [JsiiProperty(name: "tier", typeJson: "{\"primitive\":\"string\"}")]
            public string Tier
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
