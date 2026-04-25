using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PagesProject
{
    [JsiiInterface(nativeType: typeof(IPagesProjectDeploymentConfigsPreviewKvNamespaces), fullyQualifiedName: "cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewKvNamespaces")]
    public interface IPagesProjectDeploymentConfigsPreviewKvNamespaces
    {
        /// <summary>ID of the KV namespace.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pages_project#namespace_id PagesProject#namespace_id}
        /// </remarks>
        [JsiiProperty(name: "namespaceId", typeJson: "{\"primitive\":\"string\"}")]
        string NamespaceId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPagesProjectDeploymentConfigsPreviewKvNamespaces), fullyQualifiedName: "cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewKvNamespaces")]
        internal sealed class _Proxy : DeputyBase, cloudflare.PagesProject.IPagesProjectDeploymentConfigsPreviewKvNamespaces
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ID of the KV namespace.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pages_project#namespace_id PagesProject#namespace_id}
            /// </remarks>
            [JsiiProperty(name: "namespaceId", typeJson: "{\"primitive\":\"string\"}")]
            public string NamespaceId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
