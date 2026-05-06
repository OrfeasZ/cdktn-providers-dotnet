using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PagesProject
{
    [JsiiByValue(fqn: "cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionAnalyticsEngineDatasets")]
    public class PagesProjectDeploymentConfigsProductionAnalyticsEngineDatasets : cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionAnalyticsEngineDatasets
    {
        /// <summary>Name of the dataset.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#dataset PagesProject#dataset}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataset", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Dataset
        {
            get;
            set;
        }
    }
}
