using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkersScript
{
    [JsiiInterface(nativeType: typeof(IWorkersScriptPackageDependencies), fullyQualifiedName: "cloudflare.workersScript.WorkersScriptPackageDependencies")]
    public interface IWorkersScriptPackageDependencies
    {
        /// <summary>The exact version that was resolved and installed by the package manager.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/workers_script#installed_version WorkersScript#installed_version}
        /// </remarks>
        [JsiiProperty(name: "installedVersion", typeJson: "{\"primitive\":\"string\"}")]
        string InstalledVersion
        {
            get;
        }

        /// <summary>The npm package name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/workers_script#name WorkersScript#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>The version constraint as written in package.json.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/workers_script#package_json_version WorkersScript#package_json_version}
        /// </remarks>
        [JsiiProperty(name: "packageJsonVersion", typeJson: "{\"primitive\":\"string\"}")]
        string PackageJsonVersion
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkersScriptPackageDependencies), fullyQualifiedName: "cloudflare.workersScript.WorkersScriptPackageDependencies")]
        internal sealed class _Proxy : DeputyBase, cloudflare.WorkersScript.IWorkersScriptPackageDependencies
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The exact version that was resolved and installed by the package manager.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/workers_script#installed_version WorkersScript#installed_version}
            /// </remarks>
            [JsiiProperty(name: "installedVersion", typeJson: "{\"primitive\":\"string\"}")]
            public string InstalledVersion
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The npm package name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/workers_script#name WorkersScript#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The version constraint as written in package.json.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/workers_script#package_json_version WorkersScript#package_json_version}
            /// </remarks>
            [JsiiProperty(name: "packageJsonVersion", typeJson: "{\"primitive\":\"string\"}")]
            public string PackageJsonVersion
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
