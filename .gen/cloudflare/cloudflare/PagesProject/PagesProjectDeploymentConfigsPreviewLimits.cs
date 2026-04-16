using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PagesProject
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewLimits")]
    public class PagesProjectDeploymentConfigsPreviewLimits : cloudflare.PagesProject.IPagesProjectDeploymentConfigsPreviewLimits
    {
        /// <summary>CPU time limit in milliseconds.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#cpu_ms PagesProject#cpu_ms}
        /// </remarks>
        [JsiiProperty(name: "cpuMs", typeJson: "{\"primitive\":\"number\"}")]
        public double CpuMs
        {
            get;
            set;
        }
    }
}
