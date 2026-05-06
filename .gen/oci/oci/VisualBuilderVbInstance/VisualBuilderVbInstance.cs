using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.VisualBuilderVbInstance
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/visual_builder_vb_instance oci_visual_builder_vb_instance}.</summary>
    [JsiiClass(nativeType: typeof(oci.VisualBuilderVbInstance.VisualBuilderVbInstance), fullyQualifiedName: "oci.visualBuilderVbInstance.VisualBuilderVbInstance", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.visualBuilderVbInstance.VisualBuilderVbInstanceConfig\"}}]")]
    public class VisualBuilderVbInstance : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/visual_builder_vb_instance oci_visual_builder_vb_instance} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public VisualBuilderVbInstance(Constructs.Construct scope, string id, oci.VisualBuilderVbInstance.IVisualBuilderVbInstanceConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.VisualBuilderVbInstance.IVisualBuilderVbInstanceConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VisualBuilderVbInstance(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VisualBuilderVbInstance(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a VisualBuilderVbInstance resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the VisualBuilderVbInstance to import.</param>
        /// <param name="importFromId">The id of the existing VisualBuilderVbInstance that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the VisualBuilderVbInstance to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the VisualBuilderVbInstance to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/visual_builder_vb_instance#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing VisualBuilderVbInstance that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the VisualBuilderVbInstance to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.VisualBuilderVbInstance.VisualBuilderVbInstance), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAlternateCustomEndpoints", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.visualBuilderVbInstance.VisualBuilderVbInstanceAlternateCustomEndpoints\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAlternateCustomEndpoints(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.VisualBuilderVbInstance.IVisualBuilderVbInstanceAlternateCustomEndpoints[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.VisualBuilderVbInstance.IVisualBuilderVbInstanceAlternateCustomEndpoints).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.VisualBuilderVbInstance.IVisualBuilderVbInstanceAlternateCustomEndpoints).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCustomEndpoint", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.visualBuilderVbInstance.VisualBuilderVbInstanceCustomEndpoint\"}}]")]
        public virtual void PutCustomEndpoint(oci.VisualBuilderVbInstance.IVisualBuilderVbInstanceCustomEndpoint @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.VisualBuilderVbInstance.IVisualBuilderVbInstanceCustomEndpoint)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetworkEndpointDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.visualBuilderVbInstance.VisualBuilderVbInstanceNetworkEndpointDetails\"}}]")]
        public virtual void PutNetworkEndpointDetails(oci.VisualBuilderVbInstance.IVisualBuilderVbInstanceNetworkEndpointDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.VisualBuilderVbInstance.IVisualBuilderVbInstanceNetworkEndpointDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.visualBuilderVbInstance.VisualBuilderVbInstanceTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.VisualBuilderVbInstance.IVisualBuilderVbInstanceTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.VisualBuilderVbInstance.IVisualBuilderVbInstanceTimeouts)}, new object[]{@value});
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

        [JsiiMethod(name: "resetIdcsOpenId")]
        public virtual void ResetIdcsOpenId()
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
        = GetStaticProperty<string>(typeof(oci.VisualBuilderVbInstance.VisualBuilderVbInstance))!;

        [JsiiProperty(name: "alternateCustomEndpoints", typeJson: "{\"fqn\":\"oci.visualBuilderVbInstance.VisualBuilderVbInstanceAlternateCustomEndpointsList\"}")]
        public virtual oci.VisualBuilderVbInstance.VisualBuilderVbInstanceAlternateCustomEndpointsList AlternateCustomEndpoints
        {
            get => GetInstanceProperty<oci.VisualBuilderVbInstance.VisualBuilderVbInstanceAlternateCustomEndpointsList>()!;
        }

        [JsiiProperty(name: "customEndpoint", typeJson: "{\"fqn\":\"oci.visualBuilderVbInstance.VisualBuilderVbInstanceCustomEndpointOutputReference\"}")]
        public virtual oci.VisualBuilderVbInstance.VisualBuilderVbInstanceCustomEndpointOutputReference CustomEndpoint
        {
            get => GetInstanceProperty<oci.VisualBuilderVbInstance.VisualBuilderVbInstanceCustomEndpointOutputReference>()!;
        }

        [JsiiProperty(name: "instanceUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "managementNatGatewayIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagementNatGatewayIp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "managementVcnId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagementVcnId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkEndpointDetails", typeJson: "{\"fqn\":\"oci.visualBuilderVbInstance.VisualBuilderVbInstanceNetworkEndpointDetailsOutputReference\"}")]
        public virtual oci.VisualBuilderVbInstance.VisualBuilderVbInstanceNetworkEndpointDetailsOutputReference NetworkEndpointDetails
        {
            get => GetInstanceProperty<oci.VisualBuilderVbInstance.VisualBuilderVbInstanceNetworkEndpointDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "serviceNatGatewayIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceNatGatewayIp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceVcnId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceVcnId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.visualBuilderVbInstance.VisualBuilderVbInstanceTimeoutsOutputReference\"}")]
        public virtual oci.VisualBuilderVbInstance.VisualBuilderVbInstanceTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.VisualBuilderVbInstance.VisualBuilderVbInstanceTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "alternateCustomEndpointsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.visualBuilderVbInstance.VisualBuilderVbInstanceAlternateCustomEndpoints\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        [JsiiProperty(name: "customEndpointInput", typeJson: "{\"fqn\":\"oci.visualBuilderVbInstance.VisualBuilderVbInstanceCustomEndpoint\"}", isOptional: true)]
        public virtual oci.VisualBuilderVbInstance.IVisualBuilderVbInstanceCustomEndpoint? CustomEndpointInput
        {
            get => GetInstanceProperty<oci.VisualBuilderVbInstance.IVisualBuilderVbInstanceCustomEndpoint?>();
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
        [JsiiProperty(name: "freeformTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? FreeformTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idcsOpenIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdcsOpenIdInput
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
        [JsiiProperty(name: "isVisualBuilderEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsVisualBuilderEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkEndpointDetailsInput", typeJson: "{\"fqn\":\"oci.visualBuilderVbInstance.VisualBuilderVbInstanceNetworkEndpointDetails\"}", isOptional: true)]
        public virtual oci.VisualBuilderVbInstance.IVisualBuilderVbInstanceNetworkEndpointDetails? NetworkEndpointDetailsInput
        {
            get => GetInstanceProperty<oci.VisualBuilderVbInstance.IVisualBuilderVbInstanceNetworkEndpointDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nodeCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NodeCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.visualBuilderVbInstance.VisualBuilderVbInstanceTimeouts\"}]}}", isOptional: true)]
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

        [JsiiProperty(name: "idcsOpenId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsOpenId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
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

        [JsiiProperty(name: "nodeCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NodeCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
