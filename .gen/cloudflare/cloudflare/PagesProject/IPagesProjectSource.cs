using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PagesProject
{
    [JsiiInterface(nativeType: typeof(IPagesProjectSource), fullyQualifiedName: "cloudflare.pagesProject.PagesProjectSource")]
    public interface IPagesProjectSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#config PagesProject#config}.</summary>
        [JsiiProperty(name: "config", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectSourceConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.PagesProject.IPagesProjectSourceConfig? Config
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#type PagesProject#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPagesProjectSource), fullyQualifiedName: "cloudflare.pagesProject.PagesProjectSource")]
        internal sealed class _Proxy : DeputyBase, cloudflare.PagesProject.IPagesProjectSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#config PagesProject#config}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "config", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectSourceConfig\"}", isOptional: true)]
            public cloudflare.PagesProject.IPagesProjectSourceConfig? Config
            {
                get => GetInstanceProperty<cloudflare.PagesProject.IPagesProjectSourceConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#type PagesProject#type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
