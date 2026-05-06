using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.SchServiceConnector
{
    [JsiiInterface(nativeType: typeof(ISchServiceConnectorSource), fullyQualifiedName: "oci.schServiceConnector.SchServiceConnectorSource")]
    public interface ISchServiceConnectorSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#kind SchServiceConnector#kind}.</summary>
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        string Kind
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#config_map SchServiceConnector#config_map}.</summary>
        [JsiiProperty(name: "configMap", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConfigMap
        {
            get
            {
                return null;
            }
        }

        /// <summary>cursor block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#cursor SchServiceConnector#cursor}
        /// </remarks>
        [JsiiProperty(name: "cursor", typeJson: "{\"fqn\":\"oci.schServiceConnector.SchServiceConnectorSourceCursor\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.SchServiceConnector.ISchServiceConnectorSourceCursor? Cursor
        {
            get
            {
                return null;
            }
        }

        /// <summary>log_sources block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#log_sources SchServiceConnector#log_sources}
        /// </remarks>
        [JsiiProperty(name: "logSources", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.schServiceConnector.SchServiceConnectorSourceLogSources\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LogSources
        {
            get
            {
                return null;
            }
        }

        /// <summary>monitoring_sources block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#monitoring_sources SchServiceConnector#monitoring_sources}
        /// </remarks>
        [JsiiProperty(name: "monitoringSources", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.schServiceConnector.SchServiceConnectorSourceMonitoringSources\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MonitoringSources
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#plugin_name SchServiceConnector#plugin_name}.</summary>
        [JsiiProperty(name: "pluginName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PluginName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#stream_id SchServiceConnector#stream_id}.</summary>
        [JsiiProperty(name: "streamId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StreamId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISchServiceConnectorSource), fullyQualifiedName: "oci.schServiceConnector.SchServiceConnectorSource")]
        internal sealed class _Proxy : DeputyBase, oci.SchServiceConnector.ISchServiceConnectorSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#kind SchServiceConnector#kind}.</summary>
            [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
            public string Kind
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#config_map SchServiceConnector#config_map}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "configMap", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConfigMap
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>cursor block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#cursor SchServiceConnector#cursor}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cursor", typeJson: "{\"fqn\":\"oci.schServiceConnector.SchServiceConnectorSourceCursor\"}", isOptional: true)]
            public oci.SchServiceConnector.ISchServiceConnectorSourceCursor? Cursor
            {
                get => GetInstanceProperty<oci.SchServiceConnector.ISchServiceConnectorSourceCursor?>();
            }

            /// <summary>log_sources block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#log_sources SchServiceConnector#log_sources}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logSources", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.schServiceConnector.SchServiceConnectorSourceLogSources\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LogSources
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>monitoring_sources block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#monitoring_sources SchServiceConnector#monitoring_sources}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "monitoringSources", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.schServiceConnector.SchServiceConnectorSourceMonitoringSources\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? MonitoringSources
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#plugin_name SchServiceConnector#plugin_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "pluginName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PluginName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#stream_id SchServiceConnector#stream_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "streamId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StreamId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
