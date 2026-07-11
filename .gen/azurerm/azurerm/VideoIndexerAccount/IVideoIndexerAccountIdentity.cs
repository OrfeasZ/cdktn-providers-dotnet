using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VideoIndexerAccount
{
    [JsiiInterface(nativeType: typeof(IVideoIndexerAccountIdentity), fullyQualifiedName: "azurerm.videoIndexerAccount.VideoIndexerAccountIdentity")]
    public interface IVideoIndexerAccountIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/video_indexer_account#type VideoIndexerAccount#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/video_indexer_account#identity_ids VideoIndexerAccount#identity_ids}.</summary>
        [JsiiProperty(name: "identityIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? IdentityIds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVideoIndexerAccountIdentity), fullyQualifiedName: "azurerm.videoIndexerAccount.VideoIndexerAccountIdentity")]
        internal sealed class _Proxy : DeputyBase, azurerm.VideoIndexerAccount.IVideoIndexerAccountIdentity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/video_indexer_account#type VideoIndexerAccount#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/video_indexer_account#identity_ids VideoIndexerAccount#identity_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "identityIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? IdentityIds
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
