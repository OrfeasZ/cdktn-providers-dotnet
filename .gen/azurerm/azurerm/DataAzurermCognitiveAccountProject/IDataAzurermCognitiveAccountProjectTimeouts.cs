using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermCognitiveAccountProject
{
    [JsiiInterface(nativeType: typeof(IDataAzurermCognitiveAccountProjectTimeouts), fullyQualifiedName: "azurerm.dataAzurermCognitiveAccountProject.DataAzurermCognitiveAccountProjectTimeouts")]
    public interface IDataAzurermCognitiveAccountProjectTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/data-sources/cognitive_account_project#read DataAzurermCognitiveAccountProject#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermCognitiveAccountProjectTimeouts), fullyQualifiedName: "azurerm.dataAzurermCognitiveAccountProject.DataAzurermCognitiveAccountProjectTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermCognitiveAccountProject.IDataAzurermCognitiveAccountProjectTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/data-sources/cognitive_account_project#read DataAzurermCognitiveAccountProject#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
