using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.SchServiceConnector
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.schServiceConnector.SchServiceConnectorSource")]
    public class SchServiceConnectorSource : oci.SchServiceConnector.ISchServiceConnectorSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#kind SchServiceConnector#kind}.</summary>
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        public string Kind
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#config_map SchServiceConnector#config_map}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "configMap", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConfigMap
        {
            get;
            set;
        }

        /// <summary>cursor block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#cursor SchServiceConnector#cursor}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cursor", typeJson: "{\"fqn\":\"oci.schServiceConnector.SchServiceConnectorSourceCursor\"}", isOptional: true)]
        public oci.SchServiceConnector.ISchServiceConnectorSourceCursor? Cursor
        {
            get;
            set;
        }

        private object? _logSources;

        /// <summary>log_sources block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#log_sources SchServiceConnector#log_sources}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "logSources", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.schServiceConnector.SchServiceConnectorSourceLogSources\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? LogSources
        {
            get => _logSources;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.SchServiceConnector.ISchServiceConnectorSourceLogSources[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.SchServiceConnector.ISchServiceConnectorSourceLogSources).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _logSources = value;
            }
        }

        private object? _monitoringSources;

        /// <summary>monitoring_sources block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#monitoring_sources SchServiceConnector#monitoring_sources}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "monitoringSources", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.schServiceConnector.SchServiceConnectorSourceMonitoringSources\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? MonitoringSources
        {
            get => _monitoringSources;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.SchServiceConnector.ISchServiceConnectorSourceMonitoringSources[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.SchServiceConnector.ISchServiceConnectorSourceMonitoringSources).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _monitoringSources = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#plugin_name SchServiceConnector#plugin_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pluginName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PluginName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#stream_id SchServiceConnector#stream_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "streamId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StreamId
        {
            get;
            set;
        }
    }
}
