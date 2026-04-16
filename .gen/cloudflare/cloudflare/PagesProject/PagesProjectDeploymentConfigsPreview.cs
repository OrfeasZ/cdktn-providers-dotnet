using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PagesProject
{
    [JsiiByValue(fqn: "cloudflare.pagesProject.PagesProjectDeploymentConfigsPreview")]
    public class PagesProjectDeploymentConfigsPreview : cloudflare.PagesProject.IPagesProjectDeploymentConfigsPreview
    {
        private object? _aiBindings;

        /// <summary>Constellation bindings used for Pages Functions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#ai_bindings PagesProject#ai_bindings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "aiBindings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewAiBindings\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public object? AiBindings
        {
            get => _aiBindings;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case System.Collections.Generic.IDictionary<string, cloudflare.PagesProject.IPagesProjectDeploymentConfigsPreviewAiBindings> cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, {typeof(cloudflare.PagesProject.IPagesProjectDeploymentConfigsPreviewAiBindings).FullName}>; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _aiBindings = value;
            }
        }

        private object? _alwaysUseLatestCompatibilityDate;

        /// <summary>Whether to always use the latest compatibility date for Pages Functions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#always_use_latest_compatibility_date PagesProject#always_use_latest_compatibility_date}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "alwaysUseLatestCompatibilityDate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? AlwaysUseLatestCompatibilityDate
        {
            get => _alwaysUseLatestCompatibilityDate;
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
                _alwaysUseLatestCompatibilityDate = value;
            }
        }

        private object? _analyticsEngineDatasets;

        /// <summary>Analytics Engine bindings used for Pages Functions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#analytics_engine_datasets PagesProject#analytics_engine_datasets}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "analyticsEngineDatasets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewAnalyticsEngineDatasets\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public object? AnalyticsEngineDatasets
        {
            get => _analyticsEngineDatasets;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case System.Collections.Generic.IDictionary<string, cloudflare.PagesProject.IPagesProjectDeploymentConfigsPreviewAnalyticsEngineDatasets> cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, {typeof(cloudflare.PagesProject.IPagesProjectDeploymentConfigsPreviewAnalyticsEngineDatasets).FullName}>; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _analyticsEngineDatasets = value;
            }
        }

        private object? _browsers;

        /// <summary>Browser bindings used for Pages Functions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#browsers PagesProject#browsers}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "browsers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewBrowsers\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public object? Browsers
        {
            get => _browsers;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case System.Collections.Generic.IDictionary<string, cloudflare.PagesProject.IPagesProjectDeploymentConfigsPreviewBrowsers> cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, {typeof(cloudflare.PagesProject.IPagesProjectDeploymentConfigsPreviewBrowsers).FullName}>; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _browsers = value;
            }
        }

        /// <summary>The major version of the build image to use for Pages Functions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#build_image_major_version PagesProject#build_image_major_version}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "buildImageMajorVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BuildImageMajorVersion
        {
            get;
            set;
        }

        /// <summary>Compatibility date used for Pages Functions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#compatibility_date PagesProject#compatibility_date}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "compatibilityDate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CompatibilityDate
        {
            get;
            set;
        }

        /// <summary>Compatibility flags used for Pages Functions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#compatibility_flags PagesProject#compatibility_flags}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "compatibilityFlags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? CompatibilityFlags
        {
            get;
            set;
        }

        private object? _d1Databases;

        /// <summary>D1 databases used for Pages Functions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#d1_databases PagesProject#d1_databases}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "d1Databases", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewD1Databases\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public object? D1Databases
        {
            get => _d1Databases;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case System.Collections.Generic.IDictionary<string, cloudflare.PagesProject.IPagesProjectDeploymentConfigsPreviewD1Databases> cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, {typeof(cloudflare.PagesProject.IPagesProjectDeploymentConfigsPreviewD1Databases).FullName}>; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _d1Databases = value;
            }
        }

        private object? _durableObjectNamespaces;

        /// <summary>Durable Object namespaces used for Pages Functions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#durable_object_namespaces PagesProject#durable_object_namespaces}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "durableObjectNamespaces", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewDurableObjectNamespaces\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public object? DurableObjectNamespaces
        {
            get => _durableObjectNamespaces;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case System.Collections.Generic.IDictionary<string, cloudflare.PagesProject.IPagesProjectDeploymentConfigsPreviewDurableObjectNamespaces> cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, {typeof(cloudflare.PagesProject.IPagesProjectDeploymentConfigsPreviewDurableObjectNamespaces).FullName}>; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _durableObjectNamespaces = value;
            }
        }

        private object? _envVars;

        /// <summary>Environment variables used for builds and Pages Functions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#env_vars PagesProject#env_vars}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "envVars", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewEnvVars\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public object? EnvVars
        {
            get => _envVars;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case System.Collections.Generic.IDictionary<string, cloudflare.PagesProject.IPagesProjectDeploymentConfigsPreviewEnvVars> cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, {typeof(cloudflare.PagesProject.IPagesProjectDeploymentConfigsPreviewEnvVars).FullName}>; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _envVars = value;
            }
        }

        private object? _failOpen;

        /// <summary>Whether to fail open when the deployment config cannot be applied.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#fail_open PagesProject#fail_open}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "failOpen", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? FailOpen
        {
            get => _failOpen;
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
                _failOpen = value;
            }
        }

        private object? _hyperdriveBindings;

        /// <summary>Hyperdrive bindings used for Pages Functions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#hyperdrive_bindings PagesProject#hyperdrive_bindings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hyperdriveBindings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewHyperdriveBindings\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public object? HyperdriveBindings
        {
            get => _hyperdriveBindings;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case System.Collections.Generic.IDictionary<string, cloudflare.PagesProject.IPagesProjectDeploymentConfigsPreviewHyperdriveBindings> cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, {typeof(cloudflare.PagesProject.IPagesProjectDeploymentConfigsPreviewHyperdriveBindings).FullName}>; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _hyperdriveBindings = value;
            }
        }

        private object? _kvNamespaces;

        /// <summary>KV namespaces used for Pages Functions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#kv_namespaces PagesProject#kv_namespaces}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kvNamespaces", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewKvNamespaces\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public object? KvNamespaces
        {
            get => _kvNamespaces;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case System.Collections.Generic.IDictionary<string, cloudflare.PagesProject.IPagesProjectDeploymentConfigsPreviewKvNamespaces> cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, {typeof(cloudflare.PagesProject.IPagesProjectDeploymentConfigsPreviewKvNamespaces).FullName}>; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _kvNamespaces = value;
            }
        }

        /// <summary>Limits for Pages Functions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#limits PagesProject#limits}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "limits", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewLimits\"}", isOptional: true)]
        public cloudflare.PagesProject.IPagesProjectDeploymentConfigsPreviewLimits? Limits
        {
            get;
            set;
        }

        private object? _mtlsCertificates;

        /// <summary>mTLS bindings used for Pages Functions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#mtls_certificates PagesProject#mtls_certificates}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mtlsCertificates", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewMtlsCertificates\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public object? MtlsCertificates
        {
            get => _mtlsCertificates;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case System.Collections.Generic.IDictionary<string, cloudflare.PagesProject.IPagesProjectDeploymentConfigsPreviewMtlsCertificates> cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, {typeof(cloudflare.PagesProject.IPagesProjectDeploymentConfigsPreviewMtlsCertificates).FullName}>; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _mtlsCertificates = value;
            }
        }

        /// <summary>Placement setting used for Pages Functions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#placement PagesProject#placement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "placement", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewPlacement\"}", isOptional: true)]
        public cloudflare.PagesProject.IPagesProjectDeploymentConfigsPreviewPlacement? Placement
        {
            get;
            set;
        }

        private object? _queueProducers;

        /// <summary>Queue Producer bindings used for Pages Functions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#queue_producers PagesProject#queue_producers}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "queueProducers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewQueueProducers\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public object? QueueProducers
        {
            get => _queueProducers;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case System.Collections.Generic.IDictionary<string, cloudflare.PagesProject.IPagesProjectDeploymentConfigsPreviewQueueProducers> cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, {typeof(cloudflare.PagesProject.IPagesProjectDeploymentConfigsPreviewQueueProducers).FullName}>; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _queueProducers = value;
            }
        }

        private object? _r2Buckets;

        /// <summary>R2 buckets used for Pages Functions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#r2_buckets PagesProject#r2_buckets}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "r2Buckets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewR2Buckets\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public object? R2Buckets
        {
            get => _r2Buckets;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case System.Collections.Generic.IDictionary<string, cloudflare.PagesProject.IPagesProjectDeploymentConfigsPreviewR2Buckets> cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, {typeof(cloudflare.PagesProject.IPagesProjectDeploymentConfigsPreviewR2Buckets).FullName}>; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _r2Buckets = value;
            }
        }

        private object? _services;

        /// <summary>Services used for Pages Functions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#services PagesProject#services}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "services", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewServices\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public object? Services
        {
            get => _services;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case System.Collections.Generic.IDictionary<string, cloudflare.PagesProject.IPagesProjectDeploymentConfigsPreviewServices> cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, {typeof(cloudflare.PagesProject.IPagesProjectDeploymentConfigsPreviewServices).FullName}>; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _services = value;
            }
        }

        /// <summary>The usage model for Pages Functions. Available values: "standard", "bundled", "unbound".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#usage_model PagesProject#usage_model}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "usageModel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UsageModel
        {
            get;
            set;
        }

        private object? _vectorizeBindings;

        /// <summary>Vectorize bindings used for Pages Functions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#vectorize_bindings PagesProject#vectorize_bindings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vectorizeBindings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewVectorizeBindings\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public object? VectorizeBindings
        {
            get => _vectorizeBindings;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case System.Collections.Generic.IDictionary<string, cloudflare.PagesProject.IPagesProjectDeploymentConfigsPreviewVectorizeBindings> cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, {typeof(cloudflare.PagesProject.IPagesProjectDeploymentConfigsPreviewVectorizeBindings).FullName}>; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _vectorizeBindings = value;
            }
        }

        /// <summary>Hash of the Wrangler configuration used for the deployment.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#wrangler_config_hash PagesProject#wrangler_config_hash}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "wranglerConfigHash", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WranglerConfigHash
        {
            get;
            set;
        }
    }
}
