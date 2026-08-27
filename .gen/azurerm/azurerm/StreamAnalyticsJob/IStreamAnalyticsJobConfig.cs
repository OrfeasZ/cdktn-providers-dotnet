using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StreamAnalyticsJob
{
    [JsiiInterface(nativeType: typeof(IStreamAnalyticsJobConfig), fullyQualifiedName: "azurerm.streamAnalyticsJob.StreamAnalyticsJobConfig")]
    public interface IStreamAnalyticsJobConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_job#location StreamAnalyticsJob#location}.</summary>
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        string Location
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_job#name StreamAnalyticsJob#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_job#resource_group_name StreamAnalyticsJob#resource_group_name}.</summary>
        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceGroupName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_job#transformation_query StreamAnalyticsJob#transformation_query}.</summary>
        [JsiiProperty(name: "transformationQuery", typeJson: "{\"primitive\":\"string\"}")]
        string TransformationQuery
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_job#compatibility_level StreamAnalyticsJob#compatibility_level}.</summary>
        [JsiiProperty(name: "compatibilityLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CompatibilityLevel
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_job#content_storage_policy StreamAnalyticsJob#content_storage_policy}.</summary>
        [JsiiProperty(name: "contentStoragePolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ContentStoragePolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_job#data_locale StreamAnalyticsJob#data_locale}.</summary>
        [JsiiProperty(name: "dataLocale", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DataLocale
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_job#events_late_arrival_max_delay_in_seconds StreamAnalyticsJob#events_late_arrival_max_delay_in_seconds}.</summary>
        [JsiiProperty(name: "eventsLateArrivalMaxDelayInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? EventsLateArrivalMaxDelayInSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_job#events_out_of_order_max_delay_in_seconds StreamAnalyticsJob#events_out_of_order_max_delay_in_seconds}.</summary>
        [JsiiProperty(name: "eventsOutOfOrderMaxDelayInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? EventsOutOfOrderMaxDelayInSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_job#events_out_of_order_policy StreamAnalyticsJob#events_out_of_order_policy}.</summary>
        [JsiiProperty(name: "eventsOutOfOrderPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EventsOutOfOrderPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_job#id StreamAnalyticsJob#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>identity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_job#identity StreamAnalyticsJob#identity}
        /// </remarks>
        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.streamAnalyticsJob.StreamAnalyticsJobIdentity\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.StreamAnalyticsJob.IStreamAnalyticsJobIdentity? Identity
        {
            get
            {
                return null;
            }
        }

        /// <summary>job_storage_account block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_job#job_storage_account StreamAnalyticsJob#job_storage_account}
        /// </remarks>
        [JsiiProperty(name: "jobStorageAccount", typeJson: "{\"fqn\":\"azurerm.streamAnalyticsJob.StreamAnalyticsJobJobStorageAccount\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.StreamAnalyticsJob.IStreamAnalyticsJobJobStorageAccount? JobStorageAccount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_job#output_error_policy StreamAnalyticsJob#output_error_policy}.</summary>
        [JsiiProperty(name: "outputErrorPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OutputErrorPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_job#sku_name StreamAnalyticsJob#sku_name}.</summary>
        [JsiiProperty(name: "skuName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SkuName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_job#stream_analytics_cluster_id StreamAnalyticsJob#stream_analytics_cluster_id}.</summary>
        [JsiiProperty(name: "streamAnalyticsClusterId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StreamAnalyticsClusterId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_job#streaming_units StreamAnalyticsJob#streaming_units}.</summary>
        [JsiiProperty(name: "streamingUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? StreamingUnits
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_job#tags StreamAnalyticsJob#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_job#timeouts StreamAnalyticsJob#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.streamAnalyticsJob.StreamAnalyticsJobTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.StreamAnalyticsJob.IStreamAnalyticsJobTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_job#type StreamAnalyticsJob#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStreamAnalyticsJobConfig), fullyQualifiedName: "azurerm.streamAnalyticsJob.StreamAnalyticsJobConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.StreamAnalyticsJob.IStreamAnalyticsJobConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_job#location StreamAnalyticsJob#location}.</summary>
            [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
            public string Location
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_job#name StreamAnalyticsJob#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_job#resource_group_name StreamAnalyticsJob#resource_group_name}.</summary>
            [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_job#transformation_query StreamAnalyticsJob#transformation_query}.</summary>
            [JsiiProperty(name: "transformationQuery", typeJson: "{\"primitive\":\"string\"}")]
            public string TransformationQuery
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_job#compatibility_level StreamAnalyticsJob#compatibility_level}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "compatibilityLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CompatibilityLevel
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_job#content_storage_policy StreamAnalyticsJob#content_storage_policy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "contentStoragePolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ContentStoragePolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_job#data_locale StreamAnalyticsJob#data_locale}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dataLocale", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DataLocale
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_job#events_late_arrival_max_delay_in_seconds StreamAnalyticsJob#events_late_arrival_max_delay_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "eventsLateArrivalMaxDelayInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? EventsLateArrivalMaxDelayInSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_job#events_out_of_order_max_delay_in_seconds StreamAnalyticsJob#events_out_of_order_max_delay_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "eventsOutOfOrderMaxDelayInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? EventsOutOfOrderMaxDelayInSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_job#events_out_of_order_policy StreamAnalyticsJob#events_out_of_order_policy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "eventsOutOfOrderPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EventsOutOfOrderPolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_job#id StreamAnalyticsJob#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>identity block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_job#identity StreamAnalyticsJob#identity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.streamAnalyticsJob.StreamAnalyticsJobIdentity\"}", isOptional: true)]
            public azurerm.StreamAnalyticsJob.IStreamAnalyticsJobIdentity? Identity
            {
                get => GetInstanceProperty<azurerm.StreamAnalyticsJob.IStreamAnalyticsJobIdentity?>();
            }

            /// <summary>job_storage_account block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_job#job_storage_account StreamAnalyticsJob#job_storage_account}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jobStorageAccount", typeJson: "{\"fqn\":\"azurerm.streamAnalyticsJob.StreamAnalyticsJobJobStorageAccount\"}", isOptional: true)]
            public azurerm.StreamAnalyticsJob.IStreamAnalyticsJobJobStorageAccount? JobStorageAccount
            {
                get => GetInstanceProperty<azurerm.StreamAnalyticsJob.IStreamAnalyticsJobJobStorageAccount?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_job#output_error_policy StreamAnalyticsJob#output_error_policy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "outputErrorPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OutputErrorPolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_job#sku_name StreamAnalyticsJob#sku_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "skuName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SkuName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_job#stream_analytics_cluster_id StreamAnalyticsJob#stream_analytics_cluster_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "streamAnalyticsClusterId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StreamAnalyticsClusterId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_job#streaming_units StreamAnalyticsJob#streaming_units}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "streamingUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? StreamingUnits
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_job#tags StreamAnalyticsJob#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_job#timeouts StreamAnalyticsJob#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.streamAnalyticsJob.StreamAnalyticsJobTimeouts\"}", isOptional: true)]
            public azurerm.StreamAnalyticsJob.IStreamAnalyticsJobTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.StreamAnalyticsJob.IStreamAnalyticsJobTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/stream_analytics_job#type StreamAnalyticsJob#type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
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
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
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
