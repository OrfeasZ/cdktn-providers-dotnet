using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.SchServiceConnector
{
    [JsiiClass(nativeType: typeof(oci.SchServiceConnector.SchServiceConnectorSourceOutputReference), fullyQualifiedName: "oci.schServiceConnector.SchServiceConnectorSourceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SchServiceConnectorSourceOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SchServiceConnectorSourceOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SchServiceConnectorSourceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SchServiceConnectorSourceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCursor", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.schServiceConnector.SchServiceConnectorSourceCursor\"}}]")]
        public virtual void PutCursor(oci.SchServiceConnector.ISchServiceConnectorSourceCursor @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.SchServiceConnector.ISchServiceConnectorSourceCursor)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLogSources", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.schServiceConnector.SchServiceConnectorSourceLogSources\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutLogSources(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.SchServiceConnector.ISchServiceConnectorSourceLogSources[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.SchServiceConnector.ISchServiceConnectorSourceLogSources).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.SchServiceConnector.ISchServiceConnectorSourceLogSources).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMonitoringSources", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.schServiceConnector.SchServiceConnectorSourceMonitoringSources\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutMonitoringSources(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.SchServiceConnector.ISchServiceConnectorSourceMonitoringSources[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.SchServiceConnector.ISchServiceConnectorSourceMonitoringSources).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.SchServiceConnector.ISchServiceConnectorSourceMonitoringSources).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetConfigMap")]
        public virtual void ResetConfigMap()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCursor")]
        public virtual void ResetCursor()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogSources")]
        public virtual void ResetLogSources()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMonitoringSources")]
        public virtual void ResetMonitoringSources()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPluginName")]
        public virtual void ResetPluginName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStreamId")]
        public virtual void ResetStreamId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "cursor", typeJson: "{\"fqn\":\"oci.schServiceConnector.SchServiceConnectorSourceCursorOutputReference\"}")]
        public virtual oci.SchServiceConnector.SchServiceConnectorSourceCursorOutputReference Cursor
        {
            get => GetInstanceProperty<oci.SchServiceConnector.SchServiceConnectorSourceCursorOutputReference>()!;
        }

        [JsiiProperty(name: "logSources", typeJson: "{\"fqn\":\"oci.schServiceConnector.SchServiceConnectorSourceLogSourcesList\"}")]
        public virtual oci.SchServiceConnector.SchServiceConnectorSourceLogSourcesList LogSources
        {
            get => GetInstanceProperty<oci.SchServiceConnector.SchServiceConnectorSourceLogSourcesList>()!;
        }

        [JsiiProperty(name: "monitoringSources", typeJson: "{\"fqn\":\"oci.schServiceConnector.SchServiceConnectorSourceMonitoringSourcesList\"}")]
        public virtual oci.SchServiceConnector.SchServiceConnectorSourceMonitoringSourcesList MonitoringSources
        {
            get => GetInstanceProperty<oci.SchServiceConnector.SchServiceConnectorSourceMonitoringSourcesList>()!;
        }

        [JsiiProperty(name: "privateEndpointMetadata", typeJson: "{\"fqn\":\"oci.schServiceConnector.SchServiceConnectorSourcePrivateEndpointMetadataList\"}")]
        public virtual oci.SchServiceConnector.SchServiceConnectorSourcePrivateEndpointMetadataList PrivateEndpointMetadata
        {
            get => GetInstanceProperty<oci.SchServiceConnector.SchServiceConnectorSourcePrivateEndpointMetadataList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "configMapInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConfigMapInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cursorInput", typeJson: "{\"fqn\":\"oci.schServiceConnector.SchServiceConnectorSourceCursor\"}", isOptional: true)]
        public virtual oci.SchServiceConnector.ISchServiceConnectorSourceCursor? CursorInput
        {
            get => GetInstanceProperty<oci.SchServiceConnector.ISchServiceConnectorSourceCursor?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kindInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KindInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logSourcesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.schServiceConnector.SchServiceConnectorSourceLogSources\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LogSourcesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "monitoringSourcesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.schServiceConnector.SchServiceConnectorSourceMonitoringSources\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? MonitoringSourcesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pluginNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PluginNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "streamIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StreamIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "configMap", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigMap
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Kind
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pluginName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PluginName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "streamId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StreamId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.schServiceConnector.SchServiceConnectorSource\"}", isOptional: true)]
        public virtual oci.SchServiceConnector.ISchServiceConnectorSource? InternalValue
        {
            get => GetInstanceProperty<oci.SchServiceConnector.ISchServiceConnectorSource?>();
            set => SetInstanceProperty(value);
        }
    }
}
