using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.SchServiceConnector
{
    [JsiiClass(nativeType: typeof(oci.SchServiceConnector.SchServiceConnectorSourceMonitoringSourcesNamespaceDetailsOutputReference), fullyQualifiedName: "oci.schServiceConnector.SchServiceConnectorSourceMonitoringSourcesNamespaceDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SchServiceConnectorSourceMonitoringSourcesNamespaceDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SchServiceConnectorSourceMonitoringSourcesNamespaceDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SchServiceConnectorSourceMonitoringSourcesNamespaceDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SchServiceConnectorSourceMonitoringSourcesNamespaceDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putNamespaces", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.schServiceConnector.SchServiceConnectorSourceMonitoringSourcesNamespaceDetailsNamespaces\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNamespaces(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.SchServiceConnector.ISchServiceConnectorSourceMonitoringSourcesNamespaceDetailsNamespaces[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.SchServiceConnector.ISchServiceConnectorSourceMonitoringSourcesNamespaceDetailsNamespaces).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.SchServiceConnector.ISchServiceConnectorSourceMonitoringSourcesNamespaceDetailsNamespaces).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiProperty(name: "namespaces", typeJson: "{\"fqn\":\"oci.schServiceConnector.SchServiceConnectorSourceMonitoringSourcesNamespaceDetailsNamespacesList\"}")]
        public virtual oci.SchServiceConnector.SchServiceConnectorSourceMonitoringSourcesNamespaceDetailsNamespacesList Namespaces
        {
            get => GetInstanceProperty<oci.SchServiceConnector.SchServiceConnectorSourceMonitoringSourcesNamespaceDetailsNamespacesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "kindInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KindInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "namespacesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.schServiceConnector.SchServiceConnectorSourceMonitoringSourcesNamespaceDetailsNamespaces\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NamespacesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Kind
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.schServiceConnector.SchServiceConnectorSourceMonitoringSourcesNamespaceDetails\"}", isOptional: true)]
        public virtual oci.SchServiceConnector.ISchServiceConnectorSourceMonitoringSourcesNamespaceDetails? InternalValue
        {
            get => GetInstanceProperty<oci.SchServiceConnector.ISchServiceConnectorSourceMonitoringSourcesNamespaceDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
