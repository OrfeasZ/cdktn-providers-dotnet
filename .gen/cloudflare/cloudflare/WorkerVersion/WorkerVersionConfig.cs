using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkerVersion
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.workerVersion.WorkerVersionConfig")]
    public class WorkerVersionConfig : cloudflare.WorkerVersion.IWorkerVersionConfig
    {
        /// <summary>Identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/worker_version#account_id WorkerVersion#account_id}
        /// </remarks>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        public string AccountId
        {
            get;
            set;
        }

        /// <summary>Identifier for the Worker, which can be ID or name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/worker_version#worker_id WorkerVersion#worker_id}
        /// </remarks>
        [JsiiProperty(name: "workerId", typeJson: "{\"primitive\":\"string\"}")]
        public string WorkerId
        {
            get;
            set;
        }

        /// <summary>Metadata about the version.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/worker_version#annotations WorkerVersion#annotations}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "annotations", typeJson: "{\"fqn\":\"cloudflare.workerVersion.WorkerVersionAnnotations\"}", isOptional: true)]
        public cloudflare.WorkerVersion.IWorkerVersionAnnotations? Annotations
        {
            get;
            set;
        }

        /// <summary>Configuration for assets within a Worker.</summary>
        /// <remarks>
        /// <a href="https://developers.cloudflare.com/workers/static-assets/headers/#custom-headers"><c>_headers</c></a> and
        /// <a href="https://developers.cloudflare.com/workers/static-assets/redirects/"><c>_redirects</c></a> files should be
        /// included as modules named <c>_headers</c> and <c>_redirects</c> with content type <c>text/plain</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/worker_version#assets WorkerVersion#assets}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "assets", typeJson: "{\"fqn\":\"cloudflare.workerVersion.WorkerVersionAssets\"}", isOptional: true)]
        public cloudflare.WorkerVersion.IWorkerVersionAssets? Assets
        {
            get;
            set;
        }

        private object? _bindings;

        /// <summary>List of bindings attached to a Worker. You can find more about bindings on our docs: https://developers.cloudflare.com/workers/configuration/multipart-upload-metadata/#bindings.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/worker_version#bindings WorkerVersion#bindings}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="cloudflare.WorkerVersion.IWorkerVersionBindings" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bindings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.workerVersion.WorkerVersionBindings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Bindings
        {
            get => _bindings;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.WorkerVersion.IWorkerVersionBindings[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.WorkerVersion.IWorkerVersionBindings).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _bindings = value;
            }
        }

        /// <summary>Global CacheW configuration for the Worker.</summary>
        /// <remarks>
        /// When caching is on,
        /// the platform provisions a <c>cloudflare.app</c> zone for the Worker.
        /// A <c>type: worker</c> entry in the <c>exports</c> map can override this
        /// value for a single entrypoint.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/worker_version#cache_options WorkerVersion#cache_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cacheOptions", typeJson: "{\"fqn\":\"cloudflare.workerVersion.WorkerVersionCacheOptions\"}", isOptional: true)]
        public cloudflare.WorkerVersion.IWorkerVersionCacheOptions? CacheOptions
        {
            get;
            set;
        }

        /// <summary>Date indicating targeted support in the Workers runtime.</summary>
        /// <remarks>
        /// Backwards incompatible fixes to the runtime following this date will not affect this Worker.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/worker_version#compatibility_date WorkerVersion#compatibility_date}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "compatibilityDate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CompatibilityDate
        {
            get;
            set;
        }

        /// <summary>Flags that enable or disable certain features in the Workers runtime.</summary>
        /// <remarks>
        /// Used to enable upcoming features or opt in or out of specific changes not included in a <c>compatibility_date</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/worker_version#compatibility_flags WorkerVersion#compatibility_flags}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "compatibilityFlags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? CompatibilityFlags
        {
            get;
            set;
        }

        private object? _containers;

        /// <summary>List of containers attached to a Worker.</summary>
        /// <remarks>
        /// Containers can only be attached to Durable Object classes of this Worker script.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/worker_version#containers WorkerVersion#containers}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="cloudflare.WorkerVersion.IWorkerVersionContainers" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "containers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.workerVersion.WorkerVersionContainers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Containers
        {
            get => _containers;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.WorkerVersion.IWorkerVersionContainers[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.WorkerVersion.IWorkerVersionContainers).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _containers = value;
            }
        }

        private object? _exports;

        /// <summary>Declarative exports for the version, including Durable Object classes (with their `storage` backend) and named Worker entrypoints.</summary>
        /// <remarks>
        /// On reads, tombstoned lifecycle entries are
        /// omitted, so only live exports (<c>created</c> and
        /// <c>expecting-transfer</c>) are returned. <c>exports</c> and <c>migrations</c>
        /// are mutually exclusive on upload.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/worker_version#exports WorkerVersion#exports}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, <see cref="cloudflare.WorkerVersion.IWorkerVersionExports" />&gt;</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "exports", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.workerVersion.WorkerVersionExports\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public object? Exports
        {
            get => _exports;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case System.Collections.Generic.IDictionary<string, cloudflare.WorkerVersion.IWorkerVersionExports> cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, {typeof(cloudflare.WorkerVersion.IWorkerVersionExports).FullName}>; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _exports = value;
            }
        }

        /// <summary>Resource limits enforced at runtime.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/worker_version#limits WorkerVersion#limits}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "limits", typeJson: "{\"fqn\":\"cloudflare.workerVersion.WorkerVersionLimits\"}", isOptional: true)]
        public cloudflare.WorkerVersion.IWorkerVersionLimits? Limits
        {
            get;
            set;
        }

        /// <summary>The name of the main module in the `modules` array (e.g. the name of the module that exports a `fetch` handler).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/worker_version#main_module WorkerVersion#main_module}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mainModule", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MainModule
        {
            get;
            set;
        }

        /// <summary>Migrations for Durable Objects associated with the version. Migrations are applied when the version is deployed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/worker_version#migrations WorkerVersion#migrations}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "migrations", typeJson: "{\"fqn\":\"cloudflare.workerVersion.WorkerVersionMigrations\"}", isOptional: true)]
        public cloudflare.WorkerVersion.IWorkerVersionMigrations? Migrations
        {
            get;
            set;
        }

        private object? _modules;

        /// <summary>Code, sourcemaps, and other content used at runtime.</summary>
        /// <remarks>
        /// This includes <a href="https://developers.cloudflare.com/workers/static-assets/headers/#custom-headers"><c>_headers</c></a> and
        /// <a href="https://developers.cloudflare.com/workers/static-assets/redirects/"><c>_redirects</c></a> files used to configure
        /// <a href="https://developers.cloudflare.com/workers/static-assets/">Static Assets</a>. <c>_headers</c> and <c>_redirects</c> files should be
        /// included as modules named <c>_headers</c> and <c>_redirects</c> with content type <c>text/plain</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/worker_version#modules WorkerVersion#modules}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="cloudflare.WorkerVersion.IWorkerVersionModules" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "modules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.workerVersion.WorkerVersionModules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Modules
        {
            get => _modules;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.WorkerVersion.IWorkerVersionModules[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.WorkerVersion.IWorkerVersionModules).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _modules = value;
            }
        }

        private object? _packageDependencies;

        /// <summary>The list of npm packages that were installed and used when this Worker version was built.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/worker_version#package_dependencies WorkerVersion#package_dependencies}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="cloudflare.WorkerVersion.IWorkerVersionPackageDependencies" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "packageDependencies", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.workerVersion.WorkerVersionPackageDependencies\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? PackageDependencies
        {
            get => _packageDependencies;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.WorkerVersion.IWorkerVersionPackageDependencies[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.WorkerVersion.IWorkerVersionPackageDependencies).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _packageDependencies = value;
            }
        }

        /// <summary>Configuration for [Smart Placement](https://developers.cloudflare.com/workers/configuration/smart-placement). Specify mode='smart' for Smart Placement, or one of region/hostname/host.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/worker_version#placement WorkerVersion#placement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "placement", typeJson: "{\"fqn\":\"cloudflare.workerVersion.WorkerVersionPlacement\"}", isOptional: true)]
        public cloudflare.WorkerVersion.IWorkerVersionPlacement? Placement
        {
            get;
            set;
        }

        /// <summary>Usage model for the version. Available values: "standard", "bundled", "unbound".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/worker_version#usage_model WorkerVersion#usage_model}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "usageModel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UsageModel
        {
            get;
            set;
        }

        private object? _connection;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
        public object? Connection
        {
            get => _connection;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.ISSHProvisionerConnection cast_cd4240:
                            break;
                        case Io.Cdktn.IWinrmProvisionerConnection cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.ISSHProvisionerConnection).FullName}, {typeof(Io.Cdktn.IWinrmProvisionerConnection).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _connection = value;
            }
        }

        private object? _count;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
        public object? Count
        {
            get => _count;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case double cast_cd4240:
                            break;
                        case byte cast_cd4240:
                            break;
                        case decimal cast_cd4240:
                            break;
                        case float cast_cd4240:
                            break;
                        case int cast_cd4240:
                            break;
                        case long cast_cd4240:
                            break;
                        case sbyte cast_cd4240:
                            break;
                        case short cast_cd4240:
                            break;
                        case uint cast_cd4240:
                            break;
                        case ulong cast_cd4240:
                            break;
                        case ushort cast_cd4240:
                            break;
                        case Io.Cdktn.TerraformCount cast_cd4240:
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: double, {typeof(Io.Cdktn.TerraformCount).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _count = value;
            }
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public Io.Cdktn.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
        public Io.Cdktn.ITerraformIterator? ForEach
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
        public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
        public Io.Cdktn.TerraformProvider? Provider
        {
            get;
            set;
        }

        private object[]? _provisioners;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
        public object[]? Provisioners
        {
            get => _provisioners;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    for (var __idx_cd4240 = 0 ; __idx_cd4240 < value.Length ; __idx_cd4240++)
                    {
                        switch (value[__idx_cd4240])
                        {
                            case Io.Cdktn.IFileProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.ILocalExecProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.IRemoteExecProvisioner cast_e9c63e:
                                break;
                            case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_e9c63e:
                                // Not enough information to type-check...
                                break;
                            case null:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received null", nameof(value));
                            default:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received {value[__idx_cd4240].GetType().FullName}", nameof(value));
                        }
                    }
                }
                _provisioners = value;
            }
        }
    }
}
