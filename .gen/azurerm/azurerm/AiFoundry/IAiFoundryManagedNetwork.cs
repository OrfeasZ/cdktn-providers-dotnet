using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AiFoundry
{
    [JsiiInterface(nativeType: typeof(IAiFoundryManagedNetwork), fullyQualifiedName: "azurerm.aiFoundry.AiFoundryManagedNetwork")]
    public interface IAiFoundryManagedNetwork
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/ai_foundry#isolation_mode AiFoundry#isolation_mode}.</summary>
        [JsiiProperty(name: "isolationMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IsolationMode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAiFoundryManagedNetwork), fullyQualifiedName: "azurerm.aiFoundry.AiFoundryManagedNetwork")]
        internal sealed class _Proxy : DeputyBase, azurerm.AiFoundry.IAiFoundryManagedNetwork
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/ai_foundry#isolation_mode AiFoundry#isolation_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isolationMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IsolationMode
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
