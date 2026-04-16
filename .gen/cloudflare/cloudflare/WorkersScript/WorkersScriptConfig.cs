using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkersScript
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.workersScript.WorkersScriptConfig")]
    public class WorkersScriptConfig : cloudflare.WorkersScript.IWorkersScriptConfig
    {
        /// <summary>Identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#account_id WorkersScript#account_id}
        /// </remarks>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        public string AccountId
        {
            get;
            set;
        }

        /// <summary>Name of the script, used in URLs and route configuration.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#script_name WorkersScript#script_name}
        /// </remarks>
        [JsiiProperty(name: "scriptName", typeJson: "{\"primitive\":\"string\"}")]
        public string ScriptName
        {
            get;
            set;
        }

        /// <summary>Configuration for assets within a Worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#assets WorkersScript#assets}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "assets", typeJson: "{\"fqn\":\"cloudflare.workersScript.WorkersScriptAssets\"}", isOptional: true)]
        public cloudflare.WorkersScript.IWorkersScriptAssets? Assets
        {
            get;
            set;
        }

        private object? _bindings;

        /// <summary>List of bindings attached to a Worker. You can find more about bindings on our docs: https://developers.cloudflare.com/workers/configuration/multipart-upload-metadata/#bindings.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#bindings WorkersScript#bindings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bindings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.workersScript.WorkersScriptBindings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case cloudflare.WorkersScript.IWorkersScriptBindings[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.WorkersScript.IWorkersScriptBindings).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _bindings = value;
            }
        }

        /// <summary>Name of the uploaded file that contains the script (e.g. the file adding a listener to the `fetch` event). Indicates a `service worker syntax` Worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#body_part WorkersScript#body_part}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bodyPart", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BodyPart
        {
            get;
            set;
        }

        /// <summary>Date indicating targeted support in the Workers runtime.</summary>
        /// <remarks>
        /// Backwards incompatible fixes to the runtime following this date will not affect this Worker.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#compatibility_date WorkersScript#compatibility_date}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#compatibility_flags WorkersScript#compatibility_flags}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "compatibilityFlags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? CompatibilityFlags
        {
            get;
            set;
        }

        /// <summary>Module or Service Worker contents of the Worker. Conflicts with `content_file`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#content WorkersScript#content}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Content
        {
            get;
            set;
        }

        /// <summary>Path to a file containing the Module or Service Worker contents of the Worker.</summary>
        /// <remarks>
        /// Conflicts with <c>content</c>. Must be paired with <c>content_sha256</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#content_file WorkersScript#content_file}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "contentFile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ContentFile
        {
            get;
            set;
        }

        /// <summary>SHA-256 hash of the Worker contents.</summary>
        /// <remarks>
        /// Used to trigger updates when source code changes. Must be provided when <c>content_file</c> is specified.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#content_sha256 WorkersScript#content_sha256}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "contentSha256", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ContentSha256
        {
            get;
            set;
        }

        /// <summary>Content-Type of the Worker. Required if uploading a non-JavaScript Worker (e.g. "text/x-python").</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#content_type WorkersScript#content_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "contentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ContentType
        {
            get;
            set;
        }

        private object? _keepAssets;

        /// <summary>Retain assets which exist for a previously uploaded Worker version; used in lieu of providing a completion token.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#keep_assets WorkersScript#keep_assets}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "keepAssets", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? KeepAssets
        {
            get => _keepAssets;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _keepAssets = value;
            }
        }

        /// <summary>List of binding types to keep from previous_upload.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#keep_bindings WorkersScript#keep_bindings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "keepBindings", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? KeepBindings
        {
            get;
            set;
        }

        /// <summary>Limits to apply for this Worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#limits WorkersScript#limits}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "limits", typeJson: "{\"fqn\":\"cloudflare.workersScript.WorkersScriptLimits\"}", isOptional: true)]
        public cloudflare.WorkersScript.IWorkersScriptLimits? Limits
        {
            get;
            set;
        }

        private object? _logpush;

        /// <summary>Whether Logpush is turned on for the Worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#logpush WorkersScript#logpush}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "logpush", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Logpush
        {
            get => _logpush;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _logpush = value;
            }
        }

        /// <summary>Name of the uploaded file that contains the main module (e.g. the file exporting a `fetch` handler). Indicates a `module syntax` Worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#main_module WorkersScript#main_module}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mainModule", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MainModule
        {
            get;
            set;
        }

        /// <summary>Migrations to apply for Durable Objects associated with this Worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#migrations WorkersScript#migrations}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "migrations", typeJson: "{\"fqn\":\"cloudflare.workersScript.WorkersScriptMigrations\"}", isOptional: true)]
        public cloudflare.WorkersScript.IWorkersScriptMigrations? Migrations
        {
            get;
            set;
        }

        /// <summary>Observability settings for the Worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#observability WorkersScript#observability}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "observability", typeJson: "{\"fqn\":\"cloudflare.workersScript.WorkersScriptObservability\"}", isOptional: true)]
        public cloudflare.WorkersScript.IWorkersScriptObservability? Observability
        {
            get;
            set;
        }

        /// <summary>Configuration for [Smart Placement](https://developers.cloudflare.com/workers/configuration/smart-placement). Specify mode='smart' for Smart Placement, or one of region/hostname/host.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#placement WorkersScript#placement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "placement", typeJson: "{\"fqn\":\"cloudflare.workersScript.WorkersScriptPlacement\"}", isOptional: true)]
        public cloudflare.WorkersScript.IWorkersScriptPlacement? Placement
        {
            get;
            set;
        }

        private object? _tailConsumers;

        /// <summary>List of Workers that will consume logs from the attached Worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#tail_consumers WorkersScript#tail_consumers}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tailConsumers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.workersScript.WorkersScriptTailConsumers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TailConsumers
        {
            get => _tailConsumers;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.WorkersScript.IWorkersScriptTailConsumers[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.WorkersScript.IWorkersScriptTailConsumers).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _tailConsumers = value;
            }
        }

        /// <summary>Usage model for the Worker invocations. Available values: "standard", "bundled", "unbound".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#usage_model WorkersScript#usage_model}
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
