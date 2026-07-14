using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CognitiveAccount
{
    [JsiiInterface(nativeType: typeof(ICognitiveAccountNetworkInjection), fullyQualifiedName: "azurerm.cognitiveAccount.CognitiveAccountNetworkInjection")]
    public interface ICognitiveAccountNetworkInjection
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/cognitive_account#scenario CognitiveAccount#scenario}.</summary>
        [JsiiProperty(name: "scenario", typeJson: "{\"primitive\":\"string\"}")]
        string Scenario
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/cognitive_account#subnet_id CognitiveAccount#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        string SubnetId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitiveAccountNetworkInjection), fullyQualifiedName: "azurerm.cognitiveAccount.CognitiveAccountNetworkInjection")]
        internal sealed class _Proxy : DeputyBase, azurerm.CognitiveAccount.ICognitiveAccountNetworkInjection
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/cognitive_account#scenario CognitiveAccount#scenario}.</summary>
            [JsiiProperty(name: "scenario", typeJson: "{\"primitive\":\"string\"}")]
            public string Scenario
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/cognitive_account#subnet_id CognitiveAccount#subnet_id}.</summary>
            [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
            public string SubnetId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
