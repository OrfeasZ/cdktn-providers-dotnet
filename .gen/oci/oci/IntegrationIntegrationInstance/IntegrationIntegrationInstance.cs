using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IntegrationIntegrationInstance
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/integration_integration_instance oci_integration_integration_instance}.</summary>
    [JsiiClass(nativeType: typeof(oci.IntegrationIntegrationInstance.IntegrationIntegrationInstance), fullyQualifiedName: "oci.integrationIntegrationInstance.IntegrationIntegrationInstance", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.integrationIntegrationInstance.IntegrationIntegrationInstanceConfig\"}}]")]
    public class IntegrationIntegrationInstance : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/integration_integration_instance oci_integration_integration_instance} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public IntegrationIntegrationInstance(Constructs.Construct scope, string id, oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IntegrationIntegrationInstance(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IntegrationIntegrationInstance(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a IntegrationIntegrationInstance resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the IntegrationIntegrationInstance to import.</param>
        /// <param name="importFromId">The id of the existing IntegrationIntegrationInstance that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the IntegrationIntegrationInstance to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the IntegrationIntegrationInstance to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/integration_integration_instance#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing IntegrationIntegrationInstance that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the IntegrationIntegrationInstance to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.IntegrationIntegrationInstance.IntegrationIntegrationInstance), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAlternateCustomEndpoints", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.integrationIntegrationInstance.IntegrationIntegrationInstanceAlternateCustomEndpoints\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAlternateCustomEndpoints(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceAlternateCustomEndpoints[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceAlternateCustomEndpoints).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceAlternateCustomEndpoints).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCustomEndpoint", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.integrationIntegrationInstance.IntegrationIntegrationInstanceCustomEndpoint\"}}]")]
        public virtual void PutCustomEndpoint(oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceCustomEndpoint @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceCustomEndpoint)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetworkEndpointDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.integrationIntegrationInstance.IntegrationIntegrationInstanceNetworkEndpointDetails\"}}]")]
        public virtual void PutNetworkEndpointDetails(oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceNetworkEndpointDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceNetworkEndpointDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.integrationIntegrationInstance.IntegrationIntegrationInstanceTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAlternateCustomEndpoints")]
        public virtual void ResetAlternateCustomEndpoints()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConsumptionModel")]
        public virtual void ResetConsumptionModel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomEndpoint")]
        public virtual void ResetCustomEndpoint()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDomainId")]
        public virtual void ResetDomainId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnableProcessAutomationTrigger")]
        public virtual void ResetEnableProcessAutomationTrigger()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExtendDataRetentionTrigger")]
        public virtual void ResetExtendDataRetentionTrigger()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFailoverTrigger")]
        public virtual void ResetFailoverTrigger()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFreeformTags")]
        public virtual void ResetFreeformTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIdcsAt")]
        public virtual void ResetIdcsAt()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsDisasterRecoveryEnabled")]
        public virtual void ResetIsDisasterRecoveryEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsFileServerEnabled")]
        public virtual void ResetIsFileServerEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsVisualBuilderEnabled")]
        public virtual void ResetIsVisualBuilderEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkEndpointDetails")]
        public virtual void ResetNetworkEndpointDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecurityAttributes")]
        public virtual void ResetSecurityAttributes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShape")]
        public virtual void ResetShape()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetState")]
        public virtual void ResetState()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(oci.IntegrationIntegrationInstance.IntegrationIntegrationInstance))!;

        [JsiiProperty(name: "alternateCustomEndpoints", typeJson: "{\"fqn\":\"oci.integrationIntegrationInstance.IntegrationIntegrationInstanceAlternateCustomEndpointsList\"}")]
        public virtual oci.IntegrationIntegrationInstance.IntegrationIntegrationInstanceAlternateCustomEndpointsList AlternateCustomEndpoints
        {
            get => GetInstanceProperty<oci.IntegrationIntegrationInstance.IntegrationIntegrationInstanceAlternateCustomEndpointsList>()!;
        }

        [JsiiProperty(name: "attachments", typeJson: "{\"fqn\":\"oci.integrationIntegrationInstance.IntegrationIntegrationInstanceAttachmentsList\"}")]
        public virtual oci.IntegrationIntegrationInstance.IntegrationIntegrationInstanceAttachmentsList Attachments
        {
            get => GetInstanceProperty<oci.IntegrationIntegrationInstance.IntegrationIntegrationInstanceAttachmentsList>()!;
        }

        [JsiiProperty(name: "customEndpoint", typeJson: "{\"fqn\":\"oci.integrationIntegrationInstance.IntegrationIntegrationInstanceCustomEndpointOutputReference\"}")]
        public virtual oci.IntegrationIntegrationInstance.IntegrationIntegrationInstanceCustomEndpointOutputReference CustomEndpoint
        {
            get => GetInstanceProperty<oci.IntegrationIntegrationInstance.IntegrationIntegrationInstanceCustomEndpointOutputReference>()!;
        }

        [JsiiProperty(name: "dataRetentionPeriod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataRetentionPeriod
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "disasterRecoveryDetails", typeJson: "{\"fqn\":\"oci.integrationIntegrationInstance.IntegrationIntegrationInstanceDisasterRecoveryDetailsList\"}")]
        public virtual oci.IntegrationIntegrationInstance.IntegrationIntegrationInstanceDisasterRecoveryDetailsList DisasterRecoveryDetails
        {
            get => GetInstanceProperty<oci.IntegrationIntegrationInstance.IntegrationIntegrationInstanceDisasterRecoveryDetailsList>()!;
        }

        [JsiiProperty(name: "idcsInfo", typeJson: "{\"fqn\":\"oci.integrationIntegrationInstance.IntegrationIntegrationInstanceIdcsInfoList\"}")]
        public virtual oci.IntegrationIntegrationInstance.IntegrationIntegrationInstanceIdcsInfoList IdcsInfo
        {
            get => GetInstanceProperty<oci.IntegrationIntegrationInstance.IntegrationIntegrationInstanceIdcsInfoList>()!;
        }

        [JsiiProperty(name: "instanceDesignTimeUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceDesignTimeUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instanceUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkEndpointDetails", typeJson: "{\"fqn\":\"oci.integrationIntegrationInstance.IntegrationIntegrationInstanceNetworkEndpointDetailsOutputReference\"}")]
        public virtual oci.IntegrationIntegrationInstance.IntegrationIntegrationInstanceNetworkEndpointDetailsOutputReference NetworkEndpointDetails
        {
            get => GetInstanceProperty<oci.IntegrationIntegrationInstance.IntegrationIntegrationInstanceNetworkEndpointDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "privateEndpointOutboundConnection", typeJson: "{\"fqn\":\"oci.integrationIntegrationInstance.IntegrationIntegrationInstancePrivateEndpointOutboundConnectionList\"}")]
        public virtual oci.IntegrationIntegrationInstance.IntegrationIntegrationInstancePrivateEndpointOutboundConnectionList PrivateEndpointOutboundConnection
        {
            get => GetInstanceProperty<oci.IntegrationIntegrationInstance.IntegrationIntegrationInstancePrivateEndpointOutboundConnectionList>()!;
        }

        [JsiiProperty(name: "stateMessage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StateMessage
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.integrationIntegrationInstance.IntegrationIntegrationInstanceTimeoutsOutputReference\"}")]
        public virtual oci.IntegrationIntegrationInstance.IntegrationIntegrationInstanceTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.IntegrationIntegrationInstance.IntegrationIntegrationInstanceTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "alternateCustomEndpointsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.integrationIntegrationInstance.IntegrationIntegrationInstanceAlternateCustomEndpoints\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AlternateCustomEndpointsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "consumptionModelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConsumptionModelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customEndpointInput", typeJson: "{\"fqn\":\"oci.integrationIntegrationInstance.IntegrationIntegrationInstanceCustomEndpoint\"}", isOptional: true)]
        public virtual oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceCustomEndpoint? CustomEndpointInput
        {
            get => GetInstanceProperty<oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceCustomEndpoint?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "definedTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? DefinedTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "domainIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DomainIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableProcessAutomationTriggerInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? EnableProcessAutomationTriggerInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "extendDataRetentionTriggerInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ExtendDataRetentionTriggerInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "failoverTriggerInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? FailoverTriggerInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "freeformTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? FreeformTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idcsAtInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdcsAtInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "integrationInstanceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IntegrationInstanceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isByolInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsByolInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isDisasterRecoveryEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsDisasterRecoveryEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isFileServerEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsFileServerEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isVisualBuilderEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsVisualBuilderEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "messagePacksInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MessagePacksInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkEndpointDetailsInput", typeJson: "{\"fqn\":\"oci.integrationIntegrationInstance.IntegrationIntegrationInstanceNetworkEndpointDetails\"}", isOptional: true)]
        public virtual oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceNetworkEndpointDetails? NetworkEndpointDetailsInput
        {
            get => GetInstanceProperty<oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceNetworkEndpointDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityAttributesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? SecurityAttributesInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shapeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ShapeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.integrationIntegrationInstance.IntegrationIntegrationInstanceTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "consumptionModel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConsumptionModel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> DefinedTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "domainId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enableProcessAutomationTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EnableProcessAutomationTrigger
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "extendDataRetentionTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ExtendDataRetentionTrigger
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "failoverTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FailoverTrigger
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> FreeformTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "idcsAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsAt
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "integrationInstanceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IntegrationInstanceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "isByol", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsByol
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

        [JsiiProperty(name: "isDisasterRecoveryEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsDisasterRecoveryEnabled
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

        [JsiiProperty(name: "isFileServerEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsFileServerEnabled
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

        [JsiiProperty(name: "isVisualBuilderEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsVisualBuilderEnabled
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

        [JsiiProperty(name: "messagePacks", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MessagePacks
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "securityAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> SecurityAttributes
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Shape
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
