using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedApplication
{
    [JsiiInterface(nativeType: typeof(IManagedApplicationIdentity), fullyQualifiedName: "azurerm.managedApplication.ManagedApplicationIdentity")]
    public interface IManagedApplicationIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/managed_application#type ManagedApplication#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/managed_application#identity_ids ManagedApplication#identity_ids}.</summary>
        [JsiiProperty(name: "identityIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? IdentityIds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IManagedApplicationIdentity), fullyQualifiedName: "azurerm.managedApplication.ManagedApplicationIdentity")]
        internal sealed class _Proxy : DeputyBase, azurerm.ManagedApplication.IManagedApplicationIdentity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/managed_application#type ManagedApplication#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/managed_application#identity_ids ManagedApplication#identity_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "identityIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? IdentityIds
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
