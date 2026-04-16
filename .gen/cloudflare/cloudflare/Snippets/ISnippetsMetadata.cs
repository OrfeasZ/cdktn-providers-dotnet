using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Snippets
{
    [JsiiInterface(nativeType: typeof(ISnippetsMetadata), fullyQualifiedName: "cloudflare.snippets.SnippetsMetadata")]
    public interface ISnippetsMetadata
    {
        /// <summary>Name of the file that contains the main module of the snippet.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/snippets#main_module Snippets#main_module}
        /// </remarks>
        [JsiiProperty(name: "mainModule", typeJson: "{\"primitive\":\"string\"}")]
        string MainModule
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISnippetsMetadata), fullyQualifiedName: "cloudflare.snippets.SnippetsMetadata")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Snippets.ISnippetsMetadata
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Name of the file that contains the main module of the snippet.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/snippets#main_module Snippets#main_module}
            /// </remarks>
            [JsiiProperty(name: "mainModule", typeJson: "{\"primitive\":\"string\"}")]
            public string MainModule
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
