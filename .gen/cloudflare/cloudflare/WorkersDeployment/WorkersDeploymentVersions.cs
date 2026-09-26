using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkersDeployment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.workersDeployment.WorkersDeploymentVersions")]
    public class WorkersDeploymentVersions : cloudflare.WorkersDeployment.IWorkersDeploymentVersions
    {
        /// <summary>Percentage of traffic served by this version.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/workers_deployment#percentage WorkersDeployment#percentage}
        /// </remarks>
        [JsiiProperty(name: "percentage", typeJson: "{\"primitive\":\"number\"}")]
        public double Percentage
        {
            get;
            set;
        }

        /// <summary>Identifier of the Worker Version.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/workers_deployment#version_id WorkersDeployment#version_id}
        /// </remarks>
        [JsiiProperty(name: "versionId", typeJson: "{\"primitive\":\"string\"}")]
        public string VersionId
        {
            get;
            set;
        }
    }
}
