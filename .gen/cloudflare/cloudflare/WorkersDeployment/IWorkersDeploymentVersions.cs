using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkersDeployment
{
    [JsiiInterface(nativeType: typeof(IWorkersDeploymentVersions), fullyQualifiedName: "cloudflare.workersDeployment.WorkersDeploymentVersions")]
    public interface IWorkersDeploymentVersions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_deployment#percentage WorkersDeployment#percentage}.</summary>
        [JsiiProperty(name: "percentage", typeJson: "{\"primitive\":\"number\"}")]
        double Percentage
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_deployment#version_id WorkersDeployment#version_id}.</summary>
        [JsiiProperty(name: "versionId", typeJson: "{\"primitive\":\"string\"}")]
        string VersionId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkersDeploymentVersions), fullyQualifiedName: "cloudflare.workersDeployment.WorkersDeploymentVersions")]
        internal sealed class _Proxy : DeputyBase, cloudflare.WorkersDeployment.IWorkersDeploymentVersions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_deployment#percentage WorkersDeployment#percentage}.</summary>
            [JsiiProperty(name: "percentage", typeJson: "{\"primitive\":\"number\"}")]
            public double Percentage
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_deployment#version_id WorkersDeployment#version_id}.</summary>
            [JsiiProperty(name: "versionId", typeJson: "{\"primitive\":\"string\"}")]
            public string VersionId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
