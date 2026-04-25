using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PagesProject
{
    [JsiiInterface(nativeType: typeof(IPagesProjectDeploymentConfigsProductionAnalyticsEngineDatasets), fullyQualifiedName: "cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionAnalyticsEngineDatasets")]
    public interface IPagesProjectDeploymentConfigsProductionAnalyticsEngineDatasets
    {
        /// <summary>Name of the dataset.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pages_project#dataset PagesProject#dataset}
        /// </remarks>
        [JsiiProperty(name: "dataset", typeJson: "{\"primitive\":\"string\"}")]
        string Dataset
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPagesProjectDeploymentConfigsProductionAnalyticsEngineDatasets), fullyQualifiedName: "cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionAnalyticsEngineDatasets")]
        internal sealed class _Proxy : DeputyBase, cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionAnalyticsEngineDatasets
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Name of the dataset.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pages_project#dataset PagesProject#dataset}
            /// </remarks>
            [JsiiProperty(name: "dataset", typeJson: "{\"primitive\":\"string\"}")]
            public string Dataset
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
