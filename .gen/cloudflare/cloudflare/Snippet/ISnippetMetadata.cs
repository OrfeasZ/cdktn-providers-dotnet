using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Snippet
{
    [JsiiInterface(nativeType: typeof(ISnippetMetadata), fullyQualifiedName: "cloudflare.snippet.SnippetMetadata")]
    public interface ISnippetMetadata
    {
        /// <summary>Specify the name of the file that contains the main module of the snippet.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/snippet#main_module Snippet#main_module}
        /// </remarks>
        [JsiiProperty(name: "mainModule", typeJson: "{\"primitive\":\"string\"}")]
        string MainModule
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISnippetMetadata), fullyQualifiedName: "cloudflare.snippet.SnippetMetadata")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Snippet.ISnippetMetadata
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Specify the name of the file that contains the main module of the snippet.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/snippet#main_module Snippet#main_module}
            /// </remarks>
            [JsiiProperty(name: "mainModule", typeJson: "{\"primitive\":\"string\"}")]
            public string MainModule
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
