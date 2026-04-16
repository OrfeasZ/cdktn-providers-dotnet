using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkersScript
{
    [JsiiInterface(nativeType: typeof(IWorkersScriptConfig), fullyQualifiedName: "cloudflare.workersScript.WorkersScriptConfig")]
    public interface IWorkersScriptConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#account_id WorkersScript#account_id}
        /// </remarks>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        string AccountId
        {
            get;
        }

        /// <summary>Name of the script, used in URLs and route configuration.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#script_name WorkersScript#script_name}
        /// </remarks>
        [JsiiProperty(name: "scriptName", typeJson: "{\"primitive\":\"string\"}")]
        string ScriptName
        {
            get;
        }

        /// <summary>Configuration for assets within a Worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#assets WorkersScript#assets}
        /// </remarks>
        [JsiiProperty(name: "assets", typeJson: "{\"fqn\":\"cloudflare.workersScript.WorkersScriptAssets\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.WorkersScript.IWorkersScriptAssets? Assets
        {
            get
            {
                return null;
            }
        }

        /// <summary>List of bindings attached to a Worker. You can find more about bindings on our docs: https://developers.cloudflare.com/workers/configuration/multipart-upload-metadata/#bindings.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#bindings WorkersScript#bindings}
        /// </remarks>
        [JsiiProperty(name: "bindings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.workersScript.WorkersScriptBindings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Bindings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name of the uploaded file that contains the script (e.g. the file adding a listener to the `fetch` event). Indicates a `service worker syntax` Worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#body_part WorkersScript#body_part}
        /// </remarks>
        [JsiiProperty(name: "bodyPart", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BodyPart
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#compatibility_date WorkersScript#compatibility_date}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#compatibility_flags WorkersScript#compatibility_flags}
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

        /// <summary>Module or Service Worker contents of the Worker. Conflicts with `content_file`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#content WorkersScript#content}
        /// </remarks>
        [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Content
        {
            get
            {
                return null;
            }
        }

        /// <summary>Path to a file containing the Module or Service Worker contents of the Worker.</summary>
        /// <remarks>
        /// Conflicts with <c>content</c>. Must be paired with <c>content_sha256</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#content_file WorkersScript#content_file}
        /// </remarks>
        [JsiiProperty(name: "contentFile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ContentFile
        {
            get
            {
                return null;
            }
        }

        /// <summary>SHA-256 hash of the Worker contents.</summary>
        /// <remarks>
        /// Used to trigger updates when source code changes. Must be provided when <c>content_file</c> is specified.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#content_sha256 WorkersScript#content_sha256}
        /// </remarks>
        [JsiiProperty(name: "contentSha256", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ContentSha256
        {
            get
            {
                return null;
            }
        }

        /// <summary>Content-Type of the Worker. Required if uploading a non-JavaScript Worker (e.g. "text/x-python").</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#content_type WorkersScript#content_type}
        /// </remarks>
        [JsiiProperty(name: "contentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ContentType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Retain assets which exist for a previously uploaded Worker version; used in lieu of providing a completion token.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#keep_assets WorkersScript#keep_assets}
        /// </remarks>
        [JsiiProperty(name: "keepAssets", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? KeepAssets
        {
            get
            {
                return null;
            }
        }

        /// <summary>List of binding types to keep from previous_upload.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#keep_bindings WorkersScript#keep_bindings}
        /// </remarks>
        [JsiiProperty(name: "keepBindings", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? KeepBindings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Limits to apply for this Worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#limits WorkersScript#limits}
        /// </remarks>
        [JsiiProperty(name: "limits", typeJson: "{\"fqn\":\"cloudflare.workersScript.WorkersScriptLimits\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.WorkersScript.IWorkersScriptLimits? Limits
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether Logpush is turned on for the Worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#logpush WorkersScript#logpush}
        /// </remarks>
        [JsiiProperty(name: "logpush", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Logpush
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name of the uploaded file that contains the main module (e.g. the file exporting a `fetch` handler). Indicates a `module syntax` Worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#main_module WorkersScript#main_module}
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

        /// <summary>Migrations to apply for Durable Objects associated with this Worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#migrations WorkersScript#migrations}
        /// </remarks>
        [JsiiProperty(name: "migrations", typeJson: "{\"fqn\":\"cloudflare.workersScript.WorkersScriptMigrations\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.WorkersScript.IWorkersScriptMigrations? Migrations
        {
            get
            {
                return null;
            }
        }

        /// <summary>Observability settings for the Worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#observability WorkersScript#observability}
        /// </remarks>
        [JsiiProperty(name: "observability", typeJson: "{\"fqn\":\"cloudflare.workersScript.WorkersScriptObservability\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.WorkersScript.IWorkersScriptObservability? Observability
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configuration for [Smart Placement](https://developers.cloudflare.com/workers/configuration/smart-placement). Specify mode='smart' for Smart Placement, or one of region/hostname/host.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#placement WorkersScript#placement}
        /// </remarks>
        [JsiiProperty(name: "placement", typeJson: "{\"fqn\":\"cloudflare.workersScript.WorkersScriptPlacement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.WorkersScript.IWorkersScriptPlacement? Placement
        {
            get
            {
                return null;
            }
        }

        /// <summary>List of Workers that will consume logs from the attached Worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#tail_consumers WorkersScript#tail_consumers}
        /// </remarks>
        [JsiiProperty(name: "tailConsumers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.workersScript.WorkersScriptTailConsumers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TailConsumers
        {
            get
            {
                return null;
            }
        }

        /// <summary>Usage model for the Worker invocations. Available values: "standard", "bundled", "unbound".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#usage_model WorkersScript#usage_model}
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

        [JsiiTypeProxy(nativeType: typeof(IWorkersScriptConfig), fullyQualifiedName: "cloudflare.workersScript.WorkersScriptConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.WorkersScript.IWorkersScriptConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#account_id WorkersScript#account_id}
            /// </remarks>
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
            public string AccountId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Name of the script, used in URLs and route configuration.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#script_name WorkersScript#script_name}
            /// </remarks>
            [JsiiProperty(name: "scriptName", typeJson: "{\"primitive\":\"string\"}")]
            public string ScriptName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Configuration for assets within a Worker.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#assets WorkersScript#assets}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "assets", typeJson: "{\"fqn\":\"cloudflare.workersScript.WorkersScriptAssets\"}", isOptional: true)]
            public cloudflare.WorkersScript.IWorkersScriptAssets? Assets
            {
                get => GetInstanceProperty<cloudflare.WorkersScript.IWorkersScriptAssets?>();
            }

            /// <summary>List of bindings attached to a Worker. You can find more about bindings on our docs: https://developers.cloudflare.com/workers/configuration/multipart-upload-metadata/#bindings.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#bindings WorkersScript#bindings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bindings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.workersScript.WorkersScriptBindings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Bindings
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Name of the uploaded file that contains the script (e.g. the file adding a listener to the `fetch` event). Indicates a `service worker syntax` Worker.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#body_part WorkersScript#body_part}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bodyPart", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BodyPart
            {
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Module or Service Worker contents of the Worker. Conflicts with `content_file`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#content WorkersScript#content}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Content
            {
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Content-Type of the Worker. Required if uploading a non-JavaScript Worker (e.g. "text/x-python").</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#content_type WorkersScript#content_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "contentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ContentType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Retain assets which exist for a previously uploaded Worker version; used in lieu of providing a completion token.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#keep_assets WorkersScript#keep_assets}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "keepAssets", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? KeepAssets
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>List of binding types to keep from previous_upload.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#keep_bindings WorkersScript#keep_bindings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "keepBindings", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? KeepBindings
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Limits to apply for this Worker.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#limits WorkersScript#limits}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "limits", typeJson: "{\"fqn\":\"cloudflare.workersScript.WorkersScriptLimits\"}", isOptional: true)]
            public cloudflare.WorkersScript.IWorkersScriptLimits? Limits
            {
                get => GetInstanceProperty<cloudflare.WorkersScript.IWorkersScriptLimits?>();
            }

            /// <summary>Whether Logpush is turned on for the Worker.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#logpush WorkersScript#logpush}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logpush", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Logpush
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Name of the uploaded file that contains the main module (e.g. the file exporting a `fetch` handler). Indicates a `module syntax` Worker.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#main_module WorkersScript#main_module}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mainModule", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MainModule
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Migrations to apply for Durable Objects associated with this Worker.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#migrations WorkersScript#migrations}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "migrations", typeJson: "{\"fqn\":\"cloudflare.workersScript.WorkersScriptMigrations\"}", isOptional: true)]
            public cloudflare.WorkersScript.IWorkersScriptMigrations? Migrations
            {
                get => GetInstanceProperty<cloudflare.WorkersScript.IWorkersScriptMigrations?>();
            }

            /// <summary>Observability settings for the Worker.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#observability WorkersScript#observability}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "observability", typeJson: "{\"fqn\":\"cloudflare.workersScript.WorkersScriptObservability\"}", isOptional: true)]
            public cloudflare.WorkersScript.IWorkersScriptObservability? Observability
            {
                get => GetInstanceProperty<cloudflare.WorkersScript.IWorkersScriptObservability?>();
            }

            /// <summary>Configuration for [Smart Placement](https://developers.cloudflare.com/workers/configuration/smart-placement). Specify mode='smart' for Smart Placement, or one of region/hostname/host.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#placement WorkersScript#placement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "placement", typeJson: "{\"fqn\":\"cloudflare.workersScript.WorkersScriptPlacement\"}", isOptional: true)]
            public cloudflare.WorkersScript.IWorkersScriptPlacement? Placement
            {
                get => GetInstanceProperty<cloudflare.WorkersScript.IWorkersScriptPlacement?>();
            }

            /// <summary>List of Workers that will consume logs from the attached Worker.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#tail_consumers WorkersScript#tail_consumers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tailConsumers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.workersScript.WorkersScriptTailConsumers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TailConsumers
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Usage model for the Worker invocations. Available values: "standard", "bundled", "unbound".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/workers_script#usage_model WorkersScript#usage_model}
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
