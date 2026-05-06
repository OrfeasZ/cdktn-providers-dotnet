using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PagesProject
{
    [JsiiInterface(nativeType: typeof(IPagesProjectDeploymentConfigsProduction), fullyQualifiedName: "cloudflare.pagesProject.PagesProjectDeploymentConfigsProduction")]
    public interface IPagesProjectDeploymentConfigsProduction
    {
        /// <summary>Constellation bindings used for Pages Functions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#ai_bindings PagesProject#ai_bindings}
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

        /// <summary>Analytics Engine bindings used for Pages Functions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#analytics_engine_datasets PagesProject#analytics_engine_datasets}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#browsers PagesProject#browsers}
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

        /// <summary>Compatibility date used for Pages Functions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#compatibility_date PagesProject#compatibility_date}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#compatibility_flags PagesProject#compatibility_flags}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#d1_databases PagesProject#d1_databases}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#durable_object_namespaces PagesProject#durable_object_namespaces}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#env_vars PagesProject#env_vars}
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

        /// <summary>Hyperdrive bindings used for Pages Functions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#hyperdrive_bindings PagesProject#hyperdrive_bindings}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#kv_namespaces PagesProject#kv_namespaces}
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

        /// <summary>mTLS bindings used for Pages Functions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#mtls_certificates PagesProject#mtls_certificates}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#placement PagesProject#placement}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#queue_producers PagesProject#queue_producers}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#r2_buckets PagesProject#r2_buckets}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#services PagesProject#services}
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

        /// <summary>Vectorize bindings used for Pages Functions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#vectorize_bindings PagesProject#vectorize_bindings}
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

        [JsiiTypeProxy(nativeType: typeof(IPagesProjectDeploymentConfigsProduction), fullyQualifiedName: "cloudflare.pagesProject.PagesProjectDeploymentConfigsProduction")]
        internal sealed class _Proxy : DeputyBase, cloudflare.PagesProject.IPagesProjectDeploymentConfigsProduction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Constellation bindings used for Pages Functions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#ai_bindings PagesProject#ai_bindings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "aiBindings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionAiBindings\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? AiBindings
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Analytics Engine bindings used for Pages Functions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#analytics_engine_datasets PagesProject#analytics_engine_datasets}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "analyticsEngineDatasets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionAnalyticsEngineDatasets\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? AnalyticsEngineDatasets
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Browser bindings used for Pages Functions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#browsers PagesProject#browsers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "browsers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionBrowsers\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? Browsers
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Compatibility date used for Pages Functions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#compatibility_date PagesProject#compatibility_date}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "compatibilityDate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CompatibilityDate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Compatibility flags used for Pages Functions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#compatibility_flags PagesProject#compatibility_flags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "compatibilityFlags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? CompatibilityFlags
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>D1 databases used for Pages Functions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#d1_databases PagesProject#d1_databases}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "d1Databases", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionD1Databases\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? D1Databases
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Durable Object namespaces used for Pages Functions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#durable_object_namespaces PagesProject#durable_object_namespaces}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "durableObjectNamespaces", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionDurableObjectNamespaces\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? DurableObjectNamespaces
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Environment variables used for builds and Pages Functions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#env_vars PagesProject#env_vars}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "envVars", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionEnvVars\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? EnvVars
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Hyperdrive bindings used for Pages Functions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#hyperdrive_bindings PagesProject#hyperdrive_bindings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hyperdriveBindings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionHyperdriveBindings\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? HyperdriveBindings
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>KV namespaces used for Pages Functions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#kv_namespaces PagesProject#kv_namespaces}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kvNamespaces", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionKvNamespaces\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? KvNamespaces
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>mTLS bindings used for Pages Functions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#mtls_certificates PagesProject#mtls_certificates}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mtlsCertificates", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionMtlsCertificates\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? MtlsCertificates
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Placement setting used for Pages Functions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#placement PagesProject#placement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "placement", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionPlacement\"}", isOptional: true)]
            public cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionPlacement? Placement
            {
                get => GetInstanceProperty<cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionPlacement?>();
            }

            /// <summary>Queue Producer bindings used for Pages Functions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#queue_producers PagesProject#queue_producers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queueProducers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionQueueProducers\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? QueueProducers
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>R2 buckets used for Pages Functions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#r2_buckets PagesProject#r2_buckets}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "r2Buckets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionR2Buckets\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? R2Buckets
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Services used for Pages Functions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#services PagesProject#services}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "services", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionServices\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? Services
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Vectorize bindings used for Pages Functions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/pages_project#vectorize_bindings PagesProject#vectorize_bindings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vectorizeBindings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionVectorizeBindings\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? VectorizeBindings
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
