using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PagesProject
{
    [JsiiByValue(fqn: "cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionR2Buckets")]
    public class PagesProjectDeploymentConfigsProductionR2Buckets : cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionR2Buckets
    {
        /// <summary>Jurisdiction of the R2 bucket.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#jurisdiction PagesProject#jurisdiction}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "jurisdiction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Jurisdiction
        {
            get;
            set;
        }

        /// <summary>Name of the R2 bucket.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#name PagesProject#name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }
    }
}
