using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Snippets
{
    [JsiiInterface(nativeType: typeof(ISnippetsMetadata), fullyQualifiedName: "cloudflare.snippets.SnippetsMetadata")]
    public interface ISnippetsMetadata
    {
        /// <summary>Main module name of uploaded snippet.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/snippets#main_module Snippets#main_module}
        /// </remarks>
        [JsiiProperty(name: "mainModule", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MainModule
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISnippetsMetadata), fullyQualifiedName: "cloudflare.snippets.SnippetsMetadata")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Snippets.ISnippetsMetadata
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Main module name of uploaded snippet.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/snippets#main_module Snippets#main_module}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mainModule", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MainModule
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
