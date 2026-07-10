using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkerVersion
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.workerVersion.WorkerVersionPackageDependencies")]
    public class WorkerVersionPackageDependencies : cloudflare.WorkerVersion.IWorkerVersionPackageDependencies
    {
        /// <summary>The exact version that was resolved and installed by the package manager.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/worker_version#installed_version WorkerVersion#installed_version}
        /// </remarks>
        [JsiiProperty(name: "installedVersion", typeJson: "{\"primitive\":\"string\"}")]
        public string InstalledVersion
        {
            get;
            set;
        }

        /// <summary>The npm package name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/worker_version#name WorkerVersion#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>The version constraint as written in package.json.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/worker_version#package_json_version WorkerVersion#package_json_version}
        /// </remarks>
        [JsiiProperty(name: "packageJsonVersion", typeJson: "{\"primitive\":\"string\"}")]
        public string PackageJsonVersion
        {
            get;
            set;
        }
    }
}
