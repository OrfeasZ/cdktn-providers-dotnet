using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageAccount
{
    [JsiiInterface(nativeType: typeof(IStorageAccountImmutabilityPolicy), fullyQualifiedName: "azurerm.storageAccount.StorageAccountImmutabilityPolicy")]
    public interface IStorageAccountImmutabilityPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/storage_account#allow_protected_append_writes StorageAccount#allow_protected_append_writes}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "allowProtectedAppendWrites", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object AllowProtectedAppendWrites
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/storage_account#period_since_creation_in_days StorageAccount#period_since_creation_in_days}.</summary>
        [JsiiProperty(name: "periodSinceCreationInDays", typeJson: "{\"primitive\":\"number\"}")]
        double PeriodSinceCreationInDays
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/storage_account#state StorageAccount#state}.</summary>
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        string State
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IStorageAccountImmutabilityPolicy), fullyQualifiedName: "azurerm.storageAccount.StorageAccountImmutabilityPolicy")]
        internal sealed class _Proxy : DeputyBase, azurerm.StorageAccount.IStorageAccountImmutabilityPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/storage_account#allow_protected_append_writes StorageAccount#allow_protected_append_writes}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "allowProtectedAppendWrites", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object AllowProtectedAppendWrites
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/storage_account#period_since_creation_in_days StorageAccount#period_since_creation_in_days}.</summary>
            [JsiiProperty(name: "periodSinceCreationInDays", typeJson: "{\"primitive\":\"number\"}")]
            public double PeriodSinceCreationInDays
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/storage_account#state StorageAccount#state}.</summary>
            [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
            public string State
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
