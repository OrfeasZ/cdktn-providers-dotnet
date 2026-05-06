using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseManagementCloudDbSystemDiscovery
{
    [JsiiClass(nativeType: typeof(oci.DatabaseManagementCloudDbSystemDiscovery.DatabaseManagementCloudDbSystemDiscoveryPatchOperationsValueOutputReference), fullyQualifiedName: "oci.databaseManagementCloudDbSystemDiscovery.DatabaseManagementCloudDbSystemDiscoveryPatchOperationsValueOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatabaseManagementCloudDbSystemDiscoveryPatchOperationsValueOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatabaseManagementCloudDbSystemDiscoveryPatchOperationsValueOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatabaseManagementCloudDbSystemDiscoveryPatchOperationsValueOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseManagementCloudDbSystemDiscoveryPatchOperationsValueOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putConnector", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseManagementCloudDbSystemDiscovery.DatabaseManagementCloudDbSystemDiscoveryPatchOperationsValueConnector\"}}]")]
        public virtual void PutConnector(oci.DatabaseManagementCloudDbSystemDiscovery.IDatabaseManagementCloudDbSystemDiscoveryPatchOperationsValueConnector @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseManagementCloudDbSystemDiscovery.IDatabaseManagementCloudDbSystemDiscoveryPatchOperationsValueConnector)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCompartmentId")]
        public virtual void ResetCompartmentId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConnector")]
        public virtual void ResetConnector()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisplayName")]
        public virtual void ResetDisplayName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsSelectedForMonitoring")]
        public virtual void ResetIsSelectedForMonitoring()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "connector", typeJson: "{\"fqn\":\"oci.databaseManagementCloudDbSystemDiscovery.DatabaseManagementCloudDbSystemDiscoveryPatchOperationsValueConnectorOutputReference\"}")]
        public virtual oci.DatabaseManagementCloudDbSystemDiscovery.DatabaseManagementCloudDbSystemDiscoveryPatchOperationsValueConnectorOutputReference Connector
        {
            get => GetInstanceProperty<oci.DatabaseManagementCloudDbSystemDiscovery.DatabaseManagementCloudDbSystemDiscoveryPatchOperationsValueConnectorOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectorInput", typeJson: "{\"fqn\":\"oci.databaseManagementCloudDbSystemDiscovery.DatabaseManagementCloudDbSystemDiscoveryPatchOperationsValueConnector\"}", isOptional: true)]
        public virtual oci.DatabaseManagementCloudDbSystemDiscovery.IDatabaseManagementCloudDbSystemDiscoveryPatchOperationsValueConnector? ConnectorInput
        {
            get => GetInstanceProperty<oci.DatabaseManagementCloudDbSystemDiscovery.IDatabaseManagementCloudDbSystemDiscoveryPatchOperationsValueConnector?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isSelectedForMonitoringInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsSelectedForMonitoringInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "isSelectedForMonitoring", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsSelectedForMonitoring
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.databaseManagementCloudDbSystemDiscovery.DatabaseManagementCloudDbSystemDiscoveryPatchOperationsValue\"}", isOptional: true)]
        public virtual oci.DatabaseManagementCloudDbSystemDiscovery.IDatabaseManagementCloudDbSystemDiscoveryPatchOperationsValue? InternalValue
        {
            get => GetInstanceProperty<oci.DatabaseManagementCloudDbSystemDiscovery.IDatabaseManagementCloudDbSystemDiscoveryPatchOperationsValue?>();
            set => SetInstanceProperty(value);
        }
    }
}
