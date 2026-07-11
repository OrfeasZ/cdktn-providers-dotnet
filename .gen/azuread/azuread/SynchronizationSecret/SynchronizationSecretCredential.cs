using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.SynchronizationSecret
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuread.synchronizationSecret.SynchronizationSecretCredential")]
    public class SynchronizationSecretCredential : azuread.SynchronizationSecret.ISynchronizationSecretCredential
    {
        /// <summary>Name for this key-value pair.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/synchronization_secret#key SynchronizationSecret#key}
        /// </remarks>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>Value for this key-value pair.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/synchronization_secret#value SynchronizationSecret#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
