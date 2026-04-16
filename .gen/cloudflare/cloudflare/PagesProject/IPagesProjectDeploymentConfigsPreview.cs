using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PagesProject
{
    [JsiiInterface(nativeType: typeof(IPagesProjectDeploymentConfigsPreview), fullyQualifiedName: "cloudflare.pagesProject.PagesProjectDeploymentConfigsPreview")]
    public interface IPagesProjectDeploymentConfigsPreview
    {
        /// <summary>Constellation bindings used for Pages Functions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#ai_bindings PagesProject#ai_bindings}
        /// </remarks>
        [JsiiProperty(name: "aiBindings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewAiBindings\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AiBindings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether to always use the latest compatibility date for Pages Functions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#always_use_latest_compatibility_date PagesProject#always_use_latest_compatibility_date}
        /// </remarks>
        [JsiiProperty(name: "alwaysUseLatestCompatibilityDate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AlwaysUseLatestCompatibilityDate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Analytics Engine bindings used for Pages Functions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#analytics_engine_datasets PagesProject#analytics_engine_datasets}
        /// </remarks>
        [JsiiProperty(name: "analyticsEngineDatasets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewAnalyticsEngineDatasets\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AnalyticsEngineDatasets
        {
            get
            {
                return null;
            }
        }

        /// <summary>Browser bindings used for Pages Functions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#browsers PagesProject#browsers}
        /// </remarks>
        [JsiiProperty(name: "browsers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewBrowsers\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Browsers
        {
            get
            {
                return null;
            }
        }

        /// <summary>The major version of the build image to use for Pages Functions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#build_image_major_version PagesProject#build_image_major_version}
        /// </remarks>
        [JsiiProperty(name: "buildImageMajorVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BuildImageMajorVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Compatibility date used for Pages Functions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#compatibility_date PagesProject#compatibility_date}
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

        /// <summary>Compatibility flags used for Pages Functions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#compatibility_flags PagesProject#compatibility_flags}
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

        /// <summary>D1 databases used for Pages Functions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#d1_databases PagesProject#d1_databases}
        /// </remarks>
        [JsiiProperty(name: "d1Databases", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewD1Databases\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? D1Databases
        {
            get
            {
                return null;
            }
        }

        /// <summary>Durable Object namespaces used for Pages Functions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#durable_object_namespaces PagesProject#durable_object_namespaces}
        /// </remarks>
        [JsiiProperty(name: "durableObjectNamespaces", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewDurableObjectNamespaces\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DurableObjectNamespaces
        {
            get
            {
                return null;
            }
        }

        /// <summary>Environment variables used for builds and Pages Functions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#env_vars PagesProject#env_vars}
        /// </remarks>
        [JsiiProperty(name: "envVars", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewEnvVars\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnvVars
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether to fail open when the deployment config cannot be applied.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#fail_open PagesProject#fail_open}
        /// </remarks>
        [JsiiProperty(name: "failOpen", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FailOpen
        {
            get
            {
                return null;
            }
        }

        /// <summary>Hyperdrive bindings used for Pages Functions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#hyperdrive_bindings PagesProject#hyperdrive_bindings}
        /// </remarks>
        [JsiiProperty(name: "hyperdriveBindings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewHyperdriveBindings\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HyperdriveBindings
        {
            get
            {
                return null;
            }
        }

        /// <summary>KV namespaces used for Pages Functions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#kv_namespaces PagesProject#kv_namespaces}
        /// </remarks>
        [JsiiProperty(name: "kvNamespaces", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewKvNamespaces\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? KvNamespaces
        {
            get
            {
                return null;
            }
        }

        /// <summary>Limits for Pages Functions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#limits PagesProject#limits}
        /// </remarks>
        [JsiiProperty(name: "limits", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewLimits\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.PagesProject.IPagesProjectDeploymentConfigsPreviewLimits? Limits
        {
            get
            {
                return null;
            }
        }

        /// <summary>mTLS bindings used for Pages Functions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#mtls_certificates PagesProject#mtls_certificates}
        /// </remarks>
        [JsiiProperty(name: "mtlsCertificates", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewMtlsCertificates\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MtlsCertificates
        {
            get
            {
                return null;
            }
        }

        /// <summary>Placement setting used for Pages Functions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#placement PagesProject#placement}
        /// </remarks>
        [JsiiProperty(name: "placement", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewPlacement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.PagesProject.IPagesProjectDeploymentConfigsPreviewPlacement? Placement
        {
            get
            {
                return null;
            }
        }

        /// <summary>Queue Producer bindings used for Pages Functions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#queue_producers PagesProject#queue_producers}
        /// </remarks>
        [JsiiProperty(name: "queueProducers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewQueueProducers\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? QueueProducers
        {
            get
            {
                return null;
            }
        }

        /// <summary>R2 buckets used for Pages Functions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#r2_buckets PagesProject#r2_buckets}
        /// </remarks>
        [JsiiProperty(name: "r2Buckets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewR2Buckets\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? R2Buckets
        {
            get
            {
                return null;
            }
        }

        /// <summary>Services used for Pages Functions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#services PagesProject#services}
        /// </remarks>
        [JsiiProperty(name: "services", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewServices\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Services
        {
            get
            {
                return null;
            }
        }

        /// <summary>The usage model for Pages Functions. Available values: "standard", "bundled", "unbound".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#usage_model PagesProject#usage_model}
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

        /// <summary>Vectorize bindings used for Pages Functions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#vectorize_bindings PagesProject#vectorize_bindings}
        /// </remarks>
        [JsiiProperty(name: "vectorizeBindings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewVectorizeBindings\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? VectorizeBindings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Hash of the Wrangler configuration used for the deployment.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#wrangler_config_hash PagesProject#wrangler_config_hash}
        /// </remarks>
        [JsiiProperty(name: "wranglerConfigHash", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WranglerConfigHash
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPagesProjectDeploymentConfigsPreview), fullyQualifiedName: "cloudflare.pagesProject.PagesProjectDeploymentConfigsPreview")]
        internal sealed class _Proxy : DeputyBase, cloudflare.PagesProject.IPagesProjectDeploymentConfigsPreview
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Constellation bindings used for Pages Functions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#ai_bindings PagesProject#ai_bindings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "aiBindings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewAiBindings\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? AiBindings
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether to always use the latest compatibility date for Pages Functions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#always_use_latest_compatibility_date PagesProject#always_use_latest_compatibility_date}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "alwaysUseLatestCompatibilityDate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AlwaysUseLatestCompatibilityDate
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Analytics Engine bindings used for Pages Functions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#analytics_engine_datasets PagesProject#analytics_engine_datasets}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "analyticsEngineDatasets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewAnalyticsEngineDatasets\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? AnalyticsEngineDatasets
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Browser bindings used for Pages Functions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#browsers PagesProject#browsers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "browsers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewBrowsers\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? Browsers
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The major version of the build image to use for Pages Functions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#build_image_major_version PagesProject#build_image_major_version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "buildImageMajorVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BuildImageMajorVersion
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Compatibility date used for Pages Functions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#compatibility_date PagesProject#compatibility_date}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "compatibilityDate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CompatibilityDate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Compatibility flags used for Pages Functions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#compatibility_flags PagesProject#compatibility_flags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "compatibilityFlags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? CompatibilityFlags
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>D1 databases used for Pages Functions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#d1_databases PagesProject#d1_databases}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "d1Databases", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewD1Databases\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? D1Databases
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Durable Object namespaces used for Pages Functions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#durable_object_namespaces PagesProject#durable_object_namespaces}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "durableObjectNamespaces", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewDurableObjectNamespaces\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? DurableObjectNamespaces
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Environment variables used for builds and Pages Functions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#env_vars PagesProject#env_vars}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "envVars", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewEnvVars\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? EnvVars
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether to fail open when the deployment config cannot be applied.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#fail_open PagesProject#fail_open}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "failOpen", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? FailOpen
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Hyperdrive bindings used for Pages Functions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#hyperdrive_bindings PagesProject#hyperdrive_bindings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hyperdriveBindings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewHyperdriveBindings\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? HyperdriveBindings
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>KV namespaces used for Pages Functions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#kv_namespaces PagesProject#kv_namespaces}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kvNamespaces", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewKvNamespaces\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? KvNamespaces
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Limits for Pages Functions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#limits PagesProject#limits}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "limits", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewLimits\"}", isOptional: true)]
            public cloudflare.PagesProject.IPagesProjectDeploymentConfigsPreviewLimits? Limits
            {
                get => GetInstanceProperty<cloudflare.PagesProject.IPagesProjectDeploymentConfigsPreviewLimits?>();
            }

            /// <summary>mTLS bindings used for Pages Functions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#mtls_certificates PagesProject#mtls_certificates}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mtlsCertificates", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewMtlsCertificates\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? MtlsCertificates
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Placement setting used for Pages Functions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#placement PagesProject#placement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "placement", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewPlacement\"}", isOptional: true)]
            public cloudflare.PagesProject.IPagesProjectDeploymentConfigsPreviewPlacement? Placement
            {
                get => GetInstanceProperty<cloudflare.PagesProject.IPagesProjectDeploymentConfigsPreviewPlacement?>();
            }

            /// <summary>Queue Producer bindings used for Pages Functions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#queue_producers PagesProject#queue_producers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queueProducers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewQueueProducers\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? QueueProducers
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>R2 buckets used for Pages Functions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#r2_buckets PagesProject#r2_buckets}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "r2Buckets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewR2Buckets\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? R2Buckets
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Services used for Pages Functions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#services PagesProject#services}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "services", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewServices\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? Services
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The usage model for Pages Functions. Available values: "standard", "bundled", "unbound".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#usage_model PagesProject#usage_model}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "usageModel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UsageModel
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Vectorize bindings used for Pages Functions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#vectorize_bindings PagesProject#vectorize_bindings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vectorizeBindings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewVectorizeBindings\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? VectorizeBindings
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Hash of the Wrangler configuration used for the deployment.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#wrangler_config_hash PagesProject#wrangler_config_hash}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "wranglerConfigHash", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WranglerConfigHash
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
