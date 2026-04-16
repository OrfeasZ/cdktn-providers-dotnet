using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkersDeployment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.workersDeployment.WorkersDeploymentVersions")]
    public class WorkersDeploymentVersions : cloudflare.WorkersDeployment.IWorkersDeploymentVersions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_deployment#percentage WorkersDeployment#percentage}.</summary>
        [JsiiProperty(name: "percentage", typeJson: "{\"primitive\":\"number\"}")]
        public double Percentage
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_deployment#version_id WorkersDeployment#version_id}.</summary>
        [JsiiProperty(name: "versionId", typeJson: "{\"primitive\":\"string\"}")]
        public string VersionId
        {
            get;
            set;
        }
    }
}
