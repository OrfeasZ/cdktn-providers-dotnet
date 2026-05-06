using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PagesProject
{
    [JsiiByValue(fqn: "cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionMtlsCertificates")]
    public class PagesProjectDeploymentConfigsProductionMtlsCertificates : cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionMtlsCertificates
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#certificate_id PagesProject#certificate_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CertificateId
        {
            get;
            set;
        }
    }
}
