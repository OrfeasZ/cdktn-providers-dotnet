using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkerVersion
{
    [JsiiInterface(nativeType: typeof(IWorkerVersionPackageDependencies), fullyQualifiedName: "cloudflare.workerVersion.WorkerVersionPackageDependencies")]
    public interface IWorkerVersionPackageDependencies
    {
        /// <summary>The exact version that was resolved and installed by the package manager.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/worker_version#installed_version WorkerVersion#installed_version}
        /// </remarks>
        [JsiiProperty(name: "installedVersion", typeJson: "{\"primitive\":\"string\"}")]
        string InstalledVersion
        {
            get;
        }

        /// <summary>The npm package name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/worker_version#name WorkerVersion#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>The version constraint as written in package.json.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/worker_version#package_json_version WorkerVersion#package_json_version}
        /// </remarks>
        [JsiiProperty(name: "packageJsonVersion", typeJson: "{\"primitive\":\"string\"}")]
        string PackageJsonVersion
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkerVersionPackageDependencies), fullyQualifiedName: "cloudflare.workerVersion.WorkerVersionPackageDependencies")]
        internal sealed class _Proxy : DeputyBase, cloudflare.WorkerVersion.IWorkerVersionPackageDependencies
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The exact version that was resolved and installed by the package manager.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/worker_version#installed_version WorkerVersion#installed_version}
            /// </remarks>
            [JsiiProperty(name: "installedVersion", typeJson: "{\"primitive\":\"string\"}")]
            public string InstalledVersion
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The npm package name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/worker_version#name WorkerVersion#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The version constraint as written in package.json.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/worker_version#package_json_version WorkerVersion#package_json_version}
            /// </remarks>
            [JsiiProperty(name: "packageJsonVersion", typeJson: "{\"primitive\":\"string\"}")]
            public string PackageJsonVersion
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
