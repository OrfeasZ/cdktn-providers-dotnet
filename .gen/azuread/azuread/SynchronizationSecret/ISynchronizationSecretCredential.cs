using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.SynchronizationSecret
{
    [JsiiInterface(nativeType: typeof(ISynchronizationSecretCredential), fullyQualifiedName: "azuread.synchronizationSecret.SynchronizationSecretCredential")]
    public interface ISynchronizationSecretCredential
    {
        /// <summary>Name for this key-value pair.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/synchronization_secret#key SynchronizationSecret#key}
        /// </remarks>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Value for this key-value pair.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/synchronization_secret#value SynchronizationSecret#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISynchronizationSecretCredential), fullyQualifiedName: "azuread.synchronizationSecret.SynchronizationSecretCredential")]
        internal sealed class _Proxy : DeputyBase, azuread.SynchronizationSecret.ISynchronizationSecretCredential
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Name for this key-value pair.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/synchronization_secret#key SynchronizationSecret#key}
            /// </remarks>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Value for this key-value pair.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/synchronization_secret#value SynchronizationSecret#value}
            /// </remarks>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
