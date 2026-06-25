using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LogAnalyticsNamespaceScheduledTask
{
    [JsiiClass(nativeType: typeof(oci.LogAnalyticsNamespaceScheduledTask.LogAnalyticsNamespaceScheduledTaskActionMetricExtractionOutputReference), fullyQualifiedName: "oci.logAnalyticsNamespaceScheduledTask.LogAnalyticsNamespaceScheduledTaskActionMetricExtractionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LogAnalyticsNamespaceScheduledTaskActionMetricExtractionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LogAnalyticsNamespaceScheduledTaskActionMetricExtractionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected LogAnalyticsNamespaceScheduledTaskActionMetricExtractionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LogAnalyticsNamespaceScheduledTaskActionMetricExtractionOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.LogAnalyticsNamespaceScheduledTask.ILogAnalyticsNamespaceScheduledTaskActionMetricExtractionMetricCollections" />)[]</param>
        [JsiiMethod(name: "putMetricCollections", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.logAnalyticsNamespaceScheduledTask.LogAnalyticsNamespaceScheduledTaskActionMetricExtractionMetricCollections\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutMetricCollections(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.LogAnalyticsNamespaceScheduledTask.ILogAnalyticsNamespaceScheduledTaskActionMetricExtractionMetricCollections[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.LogAnalyticsNamespaceScheduledTask.ILogAnalyticsNamespaceScheduledTaskActionMetricExtractionMetricCollections).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.LogAnalyticsNamespaceScheduledTask.ILogAnalyticsNamespaceScheduledTaskActionMetricExtractionMetricCollections).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCompartmentId")]
        public virtual void ResetCompartmentId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetricCollections")]
        public virtual void ResetMetricCollections()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetricName")]
        public virtual void ResetMetricName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNamespace")]
        public virtual void ResetNamespace()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceGroup")]
        public virtual void ResetResourceGroup()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "metricCollections", typeJson: "{\"fqn\":\"oci.logAnalyticsNamespaceScheduledTask.LogAnalyticsNamespaceScheduledTaskActionMetricExtractionMetricCollectionsList\"}")]
        public virtual oci.LogAnalyticsNamespaceScheduledTask.LogAnalyticsNamespaceScheduledTaskActionMetricExtractionMetricCollectionsList MetricCollections
        {
            get => GetInstanceProperty<oci.LogAnalyticsNamespaceScheduledTask.LogAnalyticsNamespaceScheduledTaskActionMetricExtractionMetricCollectionsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.LogAnalyticsNamespaceScheduledTask.ILogAnalyticsNamespaceScheduledTaskActionMetricExtractionMetricCollections" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metricCollectionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.logAnalyticsNamespaceScheduledTask.LogAnalyticsNamespaceScheduledTaskActionMetricExtractionMetricCollections\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? MetricCollectionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metricNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MetricNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "namespaceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NamespaceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceGroupInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "metricName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MetricName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Namespace
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceGroup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceGroup
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.logAnalyticsNamespaceScheduledTask.LogAnalyticsNamespaceScheduledTaskActionMetricExtraction\"}", isOptional: true)]
        public virtual oci.LogAnalyticsNamespaceScheduledTask.ILogAnalyticsNamespaceScheduledTaskActionMetricExtraction? InternalValue
        {
            get => GetInstanceProperty<oci.LogAnalyticsNamespaceScheduledTask.ILogAnalyticsNamespaceScheduledTaskActionMetricExtraction?>();
            set => SetInstanceProperty(value);
        }
    }
}
