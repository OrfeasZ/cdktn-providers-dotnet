using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WebPubsubSocketio
{
    [JsiiInterface(nativeType: typeof(IWebPubsubSocketioIdentity), fullyQualifiedName: "azurerm.webPubsubSocketio.WebPubsubSocketioIdentity")]
    public interface IWebPubsubSocketioIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/web_pubsub_socketio#type WebPubsubSocketio#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/web_pubsub_socketio#identity_ids WebPubsubSocketio#identity_ids}.</summary>
        [JsiiProperty(name: "identityIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? IdentityIds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWebPubsubSocketioIdentity), fullyQualifiedName: "azurerm.webPubsubSocketio.WebPubsubSocketioIdentity")]
        internal sealed class _Proxy : DeputyBase, azurerm.WebPubsubSocketio.IWebPubsubSocketioIdentity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/web_pubsub_socketio#type WebPubsubSocketio#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/web_pubsub_socketio#identity_ids WebPubsubSocketio#identity_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "identityIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? IdentityIds
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
