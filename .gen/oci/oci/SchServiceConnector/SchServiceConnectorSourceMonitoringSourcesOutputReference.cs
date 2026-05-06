using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.SchServiceConnector
{
    [JsiiClass(nativeType: typeof(oci.SchServiceConnector.SchServiceConnectorSourceMonitoringSourcesOutputReference), fullyQualifiedName: "oci.schServiceConnector.SchServiceConnectorSourceMonitoringSourcesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class SchServiceConnectorSourceMonitoringSourcesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public SchServiceConnectorSourceMonitoringSourcesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SchServiceConnectorSourceMonitoringSourcesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SchServiceConnectorSourceMonitoringSourcesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putNamespaceDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.schServiceConnector.SchServiceConnectorSourceMonitoringSourcesNamespaceDetails\"}}]")]
        public virtual void PutNamespaceDetails(oci.SchServiceConnector.ISchServiceConnectorSourceMonitoringSourcesNamespaceDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.SchServiceConnector.ISchServiceConnectorSourceMonitoringSourcesNamespaceDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCompartmentId")]
        public virtual void ResetCompartmentId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNamespaceDetails")]
        public virtual void ResetNamespaceDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "namespaceDetails", typeJson: "{\"fqn\":\"oci.schServiceConnector.SchServiceConnectorSourceMonitoringSourcesNamespaceDetailsOutputReference\"}")]
        public virtual oci.SchServiceConnector.SchServiceConnectorSourceMonitoringSourcesNamespaceDetailsOutputReference NamespaceDetails
        {
            get => GetInstanceProperty<oci.SchServiceConnector.SchServiceConnectorSourceMonitoringSourcesNamespaceDetailsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "namespaceDetailsInput", typeJson: "{\"fqn\":\"oci.schServiceConnector.SchServiceConnectorSourceMonitoringSourcesNamespaceDetails\"}", isOptional: true)]
        public virtual oci.SchServiceConnector.ISchServiceConnectorSourceMonitoringSourcesNamespaceDetails? NamespaceDetailsInput
        {
            get => GetInstanceProperty<oci.SchServiceConnector.ISchServiceConnectorSourceMonitoringSourcesNamespaceDetails?>();
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.schServiceConnector.SchServiceConnectorSourceMonitoringSources\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.SchServiceConnector.ISchServiceConnectorSourceMonitoringSources cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.SchServiceConnector.ISchServiceConnectorSourceMonitoringSources).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
