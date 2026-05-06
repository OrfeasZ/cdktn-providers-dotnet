using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PagesProject
{
    [JsiiInterface(nativeType: typeof(IPagesProjectDeploymentConfigsPreviewVectorizeBindings), fullyQualifiedName: "cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewVectorizeBindings")]
    public interface IPagesProjectDeploymentConfigsPreviewVectorizeBindings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#index_name PagesProject#index_name}.</summary>
        [JsiiProperty(name: "indexName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IndexName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPagesProjectDeploymentConfigsPreviewVectorizeBindings), fullyQualifiedName: "cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewVectorizeBindings")]
        internal sealed class _Proxy : DeputyBase, cloudflare.PagesProject.IPagesProjectDeploymentConfigsPreviewVectorizeBindings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#index_name PagesProject#index_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "indexName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IndexName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
