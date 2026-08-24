using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PagesProject
{
    [JsiiInterface(nativeType: typeof(IPagesProjectDeploymentConfigsProduction), fullyQualifiedName: "cloudflare.pagesProject.PagesProjectDeploymentConfigsProduction")]
    public interface IPagesProjectDeploymentConfigsProduction
    {
        /// <summary>Constellation bindings used for Pages Functions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/pages_project#ai_bindings PagesProject#ai_bindings}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, <see cref="cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionAiBindings" />&gt;</para>
        /// </remarks>
        [JsiiProperty(name: "aiBindings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionAiBindings\"},\"kind\":\"map\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/pages_project#always_use_latest_compatibility_date PagesProject#always_use_latest_compatibility_date}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/pages_project#analytics_engine_datasets PagesProject#analytics_engine_datasets}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, <see cref="cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionAnalyticsEngineDatasets" />&gt;</para>
        /// </remarks>
        [JsiiProperty(name: "analyticsEngineDatasets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionAnalyticsEngineDatasets\"},\"kind\":\"map\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/pages_project#browsers PagesProject#browsers}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, <see cref="cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionBrowsers" />&gt;</para>
        /// </remarks>
        [JsiiProperty(name: "browsers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionBrowsers\"},\"kind\":\"map\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/pages_project#build_image_major_version PagesProject#build_image_major_version}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/pages_project#compatibility_date PagesProject#compatibility_date}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/pages_project#compatibility_flags PagesProject#compatibility_flags}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/pages_project#d1_databases PagesProject#d1_databases}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, <see cref="cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionD1Databases" />&gt;</para>
        /// </remarks>
        [JsiiProperty(name: "d1Databases", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionD1Databases\"},\"kind\":\"map\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/pages_project#durable_object_namespaces PagesProject#durable_object_namespaces}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, <see cref="cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionDurableObjectNamespaces" />&gt;</para>
        /// </remarks>
        [JsiiProperty(name: "durableObjectNamespaces", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionDurableObjectNamespaces\"},\"kind\":\"map\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/pages_project#env_vars PagesProject#env_vars}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, <see cref="cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionEnvVars" />&gt;</para>
        /// </remarks>
        [JsiiProperty(name: "envVars", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionEnvVars\"},\"kind\":\"map\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/pages_project#fail_open PagesProject#fail_open}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/pages_project#hyperdrive_bindings PagesProject#hyperdrive_bindings}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, <see cref="cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionHyperdriveBindings" />&gt;</para>
        /// </remarks>
        [JsiiProperty(name: "hyperdriveBindings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionHyperdriveBindings\"},\"kind\":\"map\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/pages_project#kv_namespaces PagesProject#kv_namespaces}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, <see cref="cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionKvNamespaces" />&gt;</para>
        /// </remarks>
        [JsiiProperty(name: "kvNamespaces", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionKvNamespaces\"},\"kind\":\"map\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/pages_project#limits PagesProject#limits}
        /// </remarks>
        [JsiiProperty(name: "limits", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionLimits\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionLimits? Limits
        {
            get
            {
                return null;
            }
        }

        /// <summary>mTLS bindings used for Pages Functions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/pages_project#mtls_certificates PagesProject#mtls_certificates}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, <see cref="cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionMtlsCertificates" />&gt;</para>
        /// </remarks>
        [JsiiProperty(name: "mtlsCertificates", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionMtlsCertificates\"},\"kind\":\"map\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/pages_project#placement PagesProject#placement}
        /// </remarks>
        [JsiiProperty(name: "placement", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionPlacement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionPlacement? Placement
        {
            get
            {
                return null;
            }
        }

        /// <summary>Queue Producer bindings used for Pages Functions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/pages_project#queue_producers PagesProject#queue_producers}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, <see cref="cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionQueueProducers" />&gt;</para>
        /// </remarks>
        [JsiiProperty(name: "queueProducers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionQueueProducers\"},\"kind\":\"map\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/pages_project#r2_buckets PagesProject#r2_buckets}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, <see cref="cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionR2Buckets" />&gt;</para>
        /// </remarks>
        [JsiiProperty(name: "r2Buckets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionR2Buckets\"},\"kind\":\"map\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/pages_project#services PagesProject#services}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, <see cref="cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionServices" />&gt;</para>
        /// </remarks>
        [JsiiProperty(name: "services", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionServices\"},\"kind\":\"map\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/pages_project#usage_model PagesProject#usage_model}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/pages_project#vectorize_bindings PagesProject#vectorize_bindings}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, <see cref="cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionVectorizeBindings" />&gt;</para>
        /// </remarks>
        [JsiiProperty(name: "vectorizeBindings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionVectorizeBindings\"},\"kind\":\"map\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/pages_project#wrangler_config_hash PagesProject#wrangler_config_hash}
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

        [JsiiTypeProxy(nativeType: typeof(IPagesProjectDeploymentConfigsProduction), fullyQualifiedName: "cloudflare.pagesProject.PagesProjectDeploymentConfigsProduction")]
        internal sealed class _Proxy : DeputyBase, cloudflare.PagesProject.IPagesProjectDeploymentConfigsProduction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Constellation bindings used for Pages Functions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/pages_project#ai_bindings PagesProject#ai_bindings}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, <see cref="cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionAiBindings" />&gt;</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "aiBindings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionAiBindings\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? AiBindings
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether to always use the latest compatibility date for Pages Functions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/pages_project#always_use_latest_compatibility_date PagesProject#always_use_latest_compatibility_date}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "alwaysUseLatestCompatibilityDate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AlwaysUseLatestCompatibilityDate
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Analytics Engine bindings used for Pages Functions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/pages_project#analytics_engine_datasets PagesProject#analytics_engine_datasets}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, <see cref="cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionAnalyticsEngineDatasets" />&gt;</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "analyticsEngineDatasets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionAnalyticsEngineDatasets\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? AnalyticsEngineDatasets
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Browser bindings used for Pages Functions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/pages_project#browsers PagesProject#browsers}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, <see cref="cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionBrowsers" />&gt;</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "browsers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionBrowsers\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? Browsers
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The major version of the build image to use for Pages Functions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/pages_project#build_image_major_version PagesProject#build_image_major_version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "buildImageMajorVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BuildImageMajorVersion
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Compatibility date used for Pages Functions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/pages_project#compatibility_date PagesProject#compatibility_date}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "compatibilityDate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CompatibilityDate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Compatibility flags used for Pages Functions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/pages_project#compatibility_flags PagesProject#compatibility_flags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "compatibilityFlags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? CompatibilityFlags
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>D1 databases used for Pages Functions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/pages_project#d1_databases PagesProject#d1_databases}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, <see cref="cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionD1Databases" />&gt;</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "d1Databases", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionD1Databases\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? D1Databases
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Durable Object namespaces used for Pages Functions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/pages_project#durable_object_namespaces PagesProject#durable_object_namespaces}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, <see cref="cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionDurableObjectNamespaces" />&gt;</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "durableObjectNamespaces", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionDurableObjectNamespaces\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? DurableObjectNamespaces
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Environment variables used for builds and Pages Functions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/pages_project#env_vars PagesProject#env_vars}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, <see cref="cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionEnvVars" />&gt;</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "envVars", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionEnvVars\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? EnvVars
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether to fail open when the deployment config cannot be applied.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/pages_project#fail_open PagesProject#fail_open}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "failOpen", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? FailOpen
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Hyperdrive bindings used for Pages Functions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/pages_project#hyperdrive_bindings PagesProject#hyperdrive_bindings}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, <see cref="cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionHyperdriveBindings" />&gt;</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hyperdriveBindings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionHyperdriveBindings\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? HyperdriveBindings
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>KV namespaces used for Pages Functions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/pages_project#kv_namespaces PagesProject#kv_namespaces}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, <see cref="cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionKvNamespaces" />&gt;</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kvNamespaces", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionKvNamespaces\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? KvNamespaces
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Limits for Pages Functions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/pages_project#limits PagesProject#limits}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "limits", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionLimits\"}", isOptional: true)]
            public cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionLimits? Limits
            {
                get => GetInstanceProperty<cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionLimits?>();
            }

            /// <summary>mTLS bindings used for Pages Functions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/pages_project#mtls_certificates PagesProject#mtls_certificates}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, <see cref="cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionMtlsCertificates" />&gt;</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mtlsCertificates", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionMtlsCertificates\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? MtlsCertificates
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Placement setting used for Pages Functions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/pages_project#placement PagesProject#placement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "placement", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionPlacement\"}", isOptional: true)]
            public cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionPlacement? Placement
            {
                get => GetInstanceProperty<cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionPlacement?>();
            }

            /// <summary>Queue Producer bindings used for Pages Functions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/pages_project#queue_producers PagesProject#queue_producers}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, <see cref="cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionQueueProducers" />&gt;</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queueProducers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionQueueProducers\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? QueueProducers
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>R2 buckets used for Pages Functions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/pages_project#r2_buckets PagesProject#r2_buckets}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, <see cref="cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionR2Buckets" />&gt;</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "r2Buckets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionR2Buckets\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? R2Buckets
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Services used for Pages Functions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/pages_project#services PagesProject#services}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, <see cref="cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionServices" />&gt;</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "services", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionServices\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? Services
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The usage model for Pages Functions. Available values: "standard", "bundled", "unbound".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/pages_project#usage_model PagesProject#usage_model}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "usageModel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UsageModel
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Vectorize bindings used for Pages Functions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/pages_project#vectorize_bindings PagesProject#vectorize_bindings}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, <see cref="cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionVectorizeBindings" />&gt;</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vectorizeBindings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionVectorizeBindings\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? VectorizeBindings
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Hash of the Wrangler configuration used for the deployment.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/pages_project#wrangler_config_hash PagesProject#wrangler_config_hash}
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
