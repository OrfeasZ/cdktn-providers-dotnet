using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkersScript
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.workersScript.WorkersScriptPackageDependencies")]
    public class WorkersScriptPackageDependencies : cloudflare.WorkersScript.IWorkersScriptPackageDependencies
    {
        /// <summary>The exact version that was resolved and installed by the package manager.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/workers_script#installed_version WorkersScript#installed_version}
        /// </remarks>
        [JsiiProperty(name: "installedVersion", typeJson: "{\"primitive\":\"string\"}")]
        public string InstalledVersion
        {
            get;
            set;
        }

        /// <summary>The npm package name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/workers_script#name WorkersScript#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>The version constraint as written in package.json.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/workers_script#package_json_version WorkersScript#package_json_version}
        /// </remarks>
        [JsiiProperty(name: "packageJsonVersion", typeJson: "{\"primitive\":\"string\"}")]
        public string PackageJsonVersion
        {
            get;
            set;
        }
    }
}
