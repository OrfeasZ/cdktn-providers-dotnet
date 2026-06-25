using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LogAnalyticsNamespaceAssociation
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/log_analytics_namespace_association oci_log_analytics_namespace_association}.</summary>
    [JsiiClass(nativeType: typeof(oci.LogAnalyticsNamespaceAssociation.LogAnalyticsNamespaceAssociation), fullyQualifiedName: "oci.logAnalyticsNamespaceAssociation.LogAnalyticsNamespaceAssociation", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.logAnalyticsNamespaceAssociation.LogAnalyticsNamespaceAssociationConfig\"}}]")]
    public class LogAnalyticsNamespaceAssociation : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/log_analytics_namespace_association oci_log_analytics_namespace_association} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public LogAnalyticsNamespaceAssociation(Constructs.Construct scope, string id, oci.LogAnalyticsNamespaceAssociation.ILogAnalyticsNamespaceAssociationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.LogAnalyticsNamespaceAssociation.ILogAnalyticsNamespaceAssociationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LogAnalyticsNamespaceAssociation(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LogAnalyticsNamespaceAssociation(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a LogAnalyticsNamespaceAssociation resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the LogAnalyticsNamespaceAssociation to import.</param>
        /// <param name="importFromId">The id of the existing LogAnalyticsNamespaceAssociation that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the LogAnalyticsNamespaceAssociation to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the LogAnalyticsNamespaceAssociation to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/log_analytics_namespace_association#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing LogAnalyticsNamespaceAssociation that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the LogAnalyticsNamespaceAssociation to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.LogAnalyticsNamespaceAssociation.LogAnalyticsNamespaceAssociation), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.LogAnalyticsNamespaceAssociation.ILogAnalyticsNamespaceAssociationAssociationProperties" />)[]</param>
        [JsiiMethod(name: "putAssociationProperties", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.logAnalyticsNamespaceAssociation.LogAnalyticsNamespaceAssociationAssociationProperties\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAssociationProperties(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.LogAnalyticsNamespaceAssociation.ILogAnalyticsNamespaceAssociationAssociationProperties[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.LogAnalyticsNamespaceAssociation.ILogAnalyticsNamespaceAssociationAssociationProperties).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.LogAnalyticsNamespaceAssociation.ILogAnalyticsNamespaceAssociationAssociationProperties).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.logAnalyticsNamespaceAssociation.LogAnalyticsNamespaceAssociationTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.LogAnalyticsNamespaceAssociation.ILogAnalyticsNamespaceAssociationTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.LogAnalyticsNamespaceAssociation.ILogAnalyticsNamespaceAssociationTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAssociationProperties")]
        public virtual void ResetAssociationProperties()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsFromRepublish")]
        public virtual void ResetIsFromRepublish()
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
        = GetStaticProperty<string>(typeof(oci.LogAnalyticsNamespaceAssociation.LogAnalyticsNamespaceAssociation))!;

        [JsiiProperty(name: "agentEntityName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AgentEntityName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "agentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AgentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "associationProperties", typeJson: "{\"fqn\":\"oci.logAnalyticsNamespaceAssociation.LogAnalyticsNamespaceAssociationAssociationPropertiesList\"}")]
        public virtual oci.LogAnalyticsNamespaceAssociation.LogAnalyticsNamespaceAssociationAssociationPropertiesList AssociationProperties
        {
            get => GetInstanceProperty<oci.LogAnalyticsNamespaceAssociation.LogAnalyticsNamespaceAssociationAssociationPropertiesList>()!;
        }

        [JsiiProperty(name: "entityName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EntityName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "entityTypeDisplayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EntityTypeDisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "entityTypeName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EntityTypeName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "failureMessage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FailureMessage
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Host
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logGroupCompartment", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogGroupCompartment
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogGroupName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "retryCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RetryCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "sourceDisplayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceDisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceTypeName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceTypeName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeLastAttempted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLastAttempted
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.logAnalyticsNamespaceAssociation.LogAnalyticsNamespaceAssociationTimeoutsOutputReference\"}")]
        public virtual oci.LogAnalyticsNamespaceAssociation.LogAnalyticsNamespaceAssociationTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.LogAnalyticsNamespaceAssociation.LogAnalyticsNamespaceAssociationTimeoutsOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.LogAnalyticsNamespaceAssociation.ILogAnalyticsNamespaceAssociationAssociationProperties" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "associationPropertiesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.logAnalyticsNamespaceAssociation.LogAnalyticsNamespaceAssociationAssociationProperties\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AssociationPropertiesInput
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
        [JsiiProperty(name: "entityIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EntityIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isFromRepublishInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsFromRepublishInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logGroupIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LogGroupIdInput
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
        [JsiiProperty(name: "sourceNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.LogAnalyticsNamespaceAssociation.ILogAnalyticsNamespaceAssociationTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.logAnalyticsNamespaceAssociation.LogAnalyticsNamespaceAssociationTimeouts\"}]}}", isOptional: true)]
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

        [JsiiProperty(name: "entityId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EntityId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isFromRepublish", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsFromRepublish
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

        [JsiiProperty(name: "logGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogGroupId
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

        [JsiiProperty(name: "sourceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
