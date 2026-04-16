using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.SpacesKey
{
    [JsiiInterface(nativeType: typeof(ISpacesKeyGrant), fullyQualifiedName: "digitalocean.spacesKey.SpacesKeyGrant")]
    public interface ISpacesKeyGrant
    {
        /// <summary>The name of the bucket to grant the key access to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/spaces_key#bucket SpacesKey#bucket}
        /// </remarks>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        string Bucket
        {
            get;
        }

        /// <summary>The permission to grant the key. Valid values are `read`, `readwrite`, or `fullaccess`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/spaces_key#permission SpacesKey#permission}
        /// </remarks>
        [JsiiProperty(name: "permission", typeJson: "{\"primitive\":\"string\"}")]
        string Permission
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISpacesKeyGrant), fullyQualifiedName: "digitalocean.spacesKey.SpacesKeyGrant")]
        internal sealed class _Proxy : DeputyBase, digitalocean.SpacesKey.ISpacesKeyGrant
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The name of the bucket to grant the key access to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/spaces_key#bucket SpacesKey#bucket}
            /// </remarks>
            [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
            public string Bucket
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The permission to grant the key. Valid values are `read`, `readwrite`, or `fullaccess`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/spaces_key#permission SpacesKey#permission}
            /// </remarks>
            [JsiiProperty(name: "permission", typeJson: "{\"primitive\":\"string\"}")]
            public string Permission
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
