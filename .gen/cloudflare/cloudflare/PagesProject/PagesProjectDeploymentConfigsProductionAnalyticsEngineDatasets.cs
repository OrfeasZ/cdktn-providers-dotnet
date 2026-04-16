using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PagesProject
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionAnalyticsEngineDatasets")]
    public class PagesProjectDeploymentConfigsProductionAnalyticsEngineDatasets : cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionAnalyticsEngineDatasets
    {
        /// <summary>Name of the dataset.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#dataset PagesProject#dataset}
        /// </remarks>
        [JsiiProperty(name: "dataset", typeJson: "{\"primitive\":\"string\"}")]
        public string Dataset
        {
            get;
            set;
        }
    }
}
