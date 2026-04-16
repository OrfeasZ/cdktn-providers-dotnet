using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PagesProject
{
    [JsiiInterface(nativeType: typeof(IPagesProjectSource), fullyQualifiedName: "cloudflare.pagesProject.PagesProjectSource")]
    public interface IPagesProjectSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#config PagesProject#config}.</summary>
        [JsiiProperty(name: "config", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectSourceConfig\"}")]
        cloudflare.PagesProject.IPagesProjectSourceConfig Config
        {
            get;
        }

        /// <summary>The source control management provider. Available values: "github", "gitlab".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#type PagesProject#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPagesProjectSource), fullyQualifiedName: "cloudflare.pagesProject.PagesProjectSource")]
        internal sealed class _Proxy : DeputyBase, cloudflare.PagesProject.IPagesProjectSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#config PagesProject#config}.</summary>
            [JsiiProperty(name: "config", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectSourceConfig\"}")]
            public cloudflare.PagesProject.IPagesProjectSourceConfig Config
            {
                get => GetInstanceProperty<cloudflare.PagesProject.IPagesProjectSourceConfig>()!;
            }

            /// <summary>The source control management provider. Available values: "github", "gitlab".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#type PagesProject#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
