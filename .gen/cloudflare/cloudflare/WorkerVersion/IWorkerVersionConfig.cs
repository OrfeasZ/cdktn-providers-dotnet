using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkerVersion
{
    [JsiiInterface(nativeType: typeof(IWorkerVersionConfig), fullyQualifiedName: "cloudflare.workerVersion.WorkerVersionConfig")]
    public interface IWorkerVersionConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#account_id WorkerVersion#account_id}
        /// </remarks>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        string AccountId
        {
            get;
        }

        /// <summary>Identifier for the Worker, which can be ID or name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#worker_id WorkerVersion#worker_id}
        /// </remarks>
        [JsiiProperty(name: "workerId", typeJson: "{\"primitive\":\"string\"}")]
        string WorkerId
        {
            get;
        }

        /// <summary>Metadata about the version.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#annotations WorkerVersion#annotations}
        /// </remarks>
        [JsiiProperty(name: "annotations", typeJson: "{\"fqn\":\"cloudflare.workerVersion.WorkerVersionAnnotations\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.WorkerVersion.IWorkerVersionAnnotations? Annotations
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configuration for assets within a Worker.</summary>
        /// <remarks>
        /// <a href="https://developers.cloudflare.com/workers/static-assets/headers/#custom-headers"><c>_headers</c></a> and
        /// <a href="https://developers.cloudflare.com/workers/static-assets/redirects/"><c>_redirects</c></a> files should be
        /// included as modules named <c>_headers</c> and <c>_redirects</c> with content type <c>text/plain</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#assets WorkerVersion#assets}
        /// </remarks>
        [JsiiProperty(name: "assets", typeJson: "{\"fqn\":\"cloudflare.workerVersion.WorkerVersionAssets\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.WorkerVersion.IWorkerVersionAssets? Assets
        {
            get
            {
                return null;
            }
        }

        /// <summary>List of bindings attached to a Worker. You can find more about bindings on our docs: https://developers.cloudflare.com/workers/configuration/multipart-upload-metadata/#bindings.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#bindings WorkerVersion#bindings}
        /// </remarks>
        [JsiiProperty(name: "bindings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.workerVersion.WorkerVersionBindings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Bindings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Date indicating targeted support in the Workers runtime.</summary>
        /// <remarks>
        /// Backwards incompatible fixes to the runtime following this date will not affect this Worker.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#compatibility_date WorkerVersion#compatibility_date}
        /// </remarks>
        [JsiiProperty(name: "compatibilityDate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CompatibilityDate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Flags that enable or disable certain features in the Workers runtime.</summary>
        /// <remarks>
        /// Used to enable upcoming features or opt in or out of specific changes not included in a <c>compatibility_date</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#compatibility_flags WorkerVersion#compatibility_flags}
        /// </remarks>
        [JsiiProperty(name: "compatibilityFlags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? CompatibilityFlags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Resource limits enforced at runtime.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#limits WorkerVersion#limits}
        /// </remarks>
        [JsiiProperty(name: "limits", typeJson: "{\"fqn\":\"cloudflare.workerVersion.WorkerVersionLimits\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.WorkerVersion.IWorkerVersionLimits? Limits
        {
            get
            {
                return null;
            }
        }

        /// <summary>The name of the main module in the `modules` array (e.g. the name of the module that exports a `fetch` handler).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#main_module WorkerVersion#main_module}
        /// </remarks>
        [JsiiProperty(name: "mainModule", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MainModule
        {
            get
            {
                return null;
            }
        }

        /// <summary>Migrations for Durable Objects associated with the version. Migrations are applied when the version is deployed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#migrations WorkerVersion#migrations}
        /// </remarks>
        [JsiiProperty(name: "migrations", typeJson: "{\"fqn\":\"cloudflare.workerVersion.WorkerVersionMigrations\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.WorkerVersion.IWorkerVersionMigrations? Migrations
        {
            get
            {
                return null;
            }
        }

        /// <summary>Code, sourcemaps, and other content used at runtime.</summary>
        /// <remarks>
        /// This includes <a href="https://developers.cloudflare.com/workers/static-assets/headers/#custom-headers"><c>_headers</c></a> and
        /// <a href="https://developers.cloudflare.com/workers/static-assets/redirects/"><c>_redirects</c></a> files used to configure
        /// <a href="https://developers.cloudflare.com/workers/static-assets/">Static Assets</a>. <c>_headers</c> and <c>_redirects</c> files should be
        /// included as modules named <c>_headers</c> and <c>_redirects</c> with content type <c>text/plain</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#modules WorkerVersion#modules}
        /// </remarks>
        [JsiiProperty(name: "modules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.workerVersion.WorkerVersionModules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Modules
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configuration for [Smart Placement](https://developers.cloudflare.com/workers/configuration/smart-placement). Specify mode='smart' for Smart Placement, or one of region/hostname/host.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#placement WorkerVersion#placement}
        /// </remarks>
        [JsiiProperty(name: "placement", typeJson: "{\"fqn\":\"cloudflare.workerVersion.WorkerVersionPlacement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.WorkerVersion.IWorkerVersionPlacement? Placement
        {
            get
            {
                return null;
            }
        }

        /// <summary>Usage model for the version. Available values: "standard", "bundled", "unbound".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#usage_model WorkerVersion#usage_model}
        /// </remarks>
        [JsiiProperty(name: "usageModel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UsageModel
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkerVersionConfig), fullyQualifiedName: "cloudflare.workerVersion.WorkerVersionConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.WorkerVersion.IWorkerVersionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#account_id WorkerVersion#account_id}
            /// </remarks>
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
            public string AccountId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Identifier for the Worker, which can be ID or name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#worker_id WorkerVersion#worker_id}
            /// </remarks>
            [JsiiProperty(name: "workerId", typeJson: "{\"primitive\":\"string\"}")]
            public string WorkerId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Metadata about the version.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#annotations WorkerVersion#annotations}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "annotations", typeJson: "{\"fqn\":\"cloudflare.workerVersion.WorkerVersionAnnotations\"}", isOptional: true)]
            public cloudflare.WorkerVersion.IWorkerVersionAnnotations? Annotations
            {
                get => GetInstanceProperty<cloudflare.WorkerVersion.IWorkerVersionAnnotations?>();
            }

            /// <summary>Configuration for assets within a Worker.</summary>
            /// <remarks>
            /// <a href="https://developers.cloudflare.com/workers/static-assets/headers/#custom-headers"><c>_headers</c></a> and
            /// <a href="https://developers.cloudflare.com/workers/static-assets/redirects/"><c>_redirects</c></a> files should be
            /// included as modules named <c>_headers</c> and <c>_redirects</c> with content type <c>text/plain</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#assets WorkerVersion#assets}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "assets", typeJson: "{\"fqn\":\"cloudflare.workerVersion.WorkerVersionAssets\"}", isOptional: true)]
            public cloudflare.WorkerVersion.IWorkerVersionAssets? Assets
            {
                get => GetInstanceProperty<cloudflare.WorkerVersion.IWorkerVersionAssets?>();
            }

            /// <summary>List of bindings attached to a Worker. You can find more about bindings on our docs: https://developers.cloudflare.com/workers/configuration/multipart-upload-metadata/#bindings.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#bindings WorkerVersion#bindings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bindings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.workerVersion.WorkerVersionBindings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Bindings
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Date indicating targeted support in the Workers runtime.</summary>
            /// <remarks>
            /// Backwards incompatible fixes to the runtime following this date will not affect this Worker.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#compatibility_date WorkerVersion#compatibility_date}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "compatibilityDate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CompatibilityDate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Flags that enable or disable certain features in the Workers runtime.</summary>
            /// <remarks>
            /// Used to enable upcoming features or opt in or out of specific changes not included in a <c>compatibility_date</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#compatibility_flags WorkerVersion#compatibility_flags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "compatibilityFlags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? CompatibilityFlags
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Resource limits enforced at runtime.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#limits WorkerVersion#limits}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "limits", typeJson: "{\"fqn\":\"cloudflare.workerVersion.WorkerVersionLimits\"}", isOptional: true)]
            public cloudflare.WorkerVersion.IWorkerVersionLimits? Limits
            {
                get => GetInstanceProperty<cloudflare.WorkerVersion.IWorkerVersionLimits?>();
            }

            /// <summary>The name of the main module in the `modules` array (e.g. the name of the module that exports a `fetch` handler).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#main_module WorkerVersion#main_module}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mainModule", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MainModule
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Migrations for Durable Objects associated with the version. Migrations are applied when the version is deployed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#migrations WorkerVersion#migrations}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "migrations", typeJson: "{\"fqn\":\"cloudflare.workerVersion.WorkerVersionMigrations\"}", isOptional: true)]
            public cloudflare.WorkerVersion.IWorkerVersionMigrations? Migrations
            {
                get => GetInstanceProperty<cloudflare.WorkerVersion.IWorkerVersionMigrations?>();
            }

            /// <summary>Code, sourcemaps, and other content used at runtime.</summary>
            /// <remarks>
            /// This includes <a href="https://developers.cloudflare.com/workers/static-assets/headers/#custom-headers"><c>_headers</c></a> and
            /// <a href="https://developers.cloudflare.com/workers/static-assets/redirects/"><c>_redirects</c></a> files used to configure
            /// <a href="https://developers.cloudflare.com/workers/static-assets/">Static Assets</a>. <c>_headers</c> and <c>_redirects</c> files should be
            /// included as modules named <c>_headers</c> and <c>_redirects</c> with content type <c>text/plain</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#modules WorkerVersion#modules}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "modules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.workerVersion.WorkerVersionModules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Modules
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Configuration for [Smart Placement](https://developers.cloudflare.com/workers/configuration/smart-placement). Specify mode='smart' for Smart Placement, or one of region/hostname/host.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#placement WorkerVersion#placement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "placement", typeJson: "{\"fqn\":\"cloudflare.workerVersion.WorkerVersionPlacement\"}", isOptional: true)]
            public cloudflare.WorkerVersion.IWorkerVersionPlacement? Placement
            {
                get => GetInstanceProperty<cloudflare.WorkerVersion.IWorkerVersionPlacement?>();
            }

            /// <summary>Usage model for the version. Available values: "standard", "bundled", "unbound".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/worker_version#usage_model WorkerVersion#usage_model}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "usageModel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UsageModel
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
