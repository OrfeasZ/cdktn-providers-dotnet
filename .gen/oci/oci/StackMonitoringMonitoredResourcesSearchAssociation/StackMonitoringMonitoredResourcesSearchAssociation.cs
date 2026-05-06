using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringMonitoredResourcesSearchAssociation
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resources_search_association oci_stack_monitoring_monitored_resources_search_association}.</summary>
    [JsiiClass(nativeType: typeof(oci.StackMonitoringMonitoredResourcesSearchAssociation.StackMonitoringMonitoredResourcesSearchAssociation), fullyQualifiedName: "oci.stackMonitoringMonitoredResourcesSearchAssociation.StackMonitoringMonitoredResourcesSearchAssociation", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.stackMonitoringMonitoredResourcesSearchAssociation.StackMonitoringMonitoredResourcesSearchAssociationConfig\"}}]")]
    public class StackMonitoringMonitoredResourcesSearchAssociation : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resources_search_association oci_stack_monitoring_monitored_resources_search_association} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public StackMonitoringMonitoredResourcesSearchAssociation(Constructs.Construct scope, string id, oci.StackMonitoringMonitoredResourcesSearchAssociation.IStackMonitoringMonitoredResourcesSearchAssociationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.StackMonitoringMonitoredResourcesSearchAssociation.IStackMonitoringMonitoredResourcesSearchAssociationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StackMonitoringMonitoredResourcesSearchAssociation(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StackMonitoringMonitoredResourcesSearchAssociation(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a StackMonitoringMonitoredResourcesSearchAssociation resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the StackMonitoringMonitoredResourcesSearchAssociation to import.</param>
        /// <param name="importFromId">The id of the existing StackMonitoringMonitoredResourcesSearchAssociation that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the StackMonitoringMonitoredResourcesSearchAssociation to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the StackMonitoringMonitoredResourcesSearchAssociation to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resources_search_association#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing StackMonitoringMonitoredResourcesSearchAssociation that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the StackMonitoringMonitoredResourcesSearchAssociation to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.StackMonitoringMonitoredResourcesSearchAssociation.StackMonitoringMonitoredResourcesSearchAssociation), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.stackMonitoringMonitoredResourcesSearchAssociation.StackMonitoringMonitoredResourcesSearchAssociationTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.StackMonitoringMonitoredResourcesSearchAssociation.IStackMonitoringMonitoredResourcesSearchAssociationTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.StackMonitoringMonitoredResourcesSearchAssociation.IStackMonitoringMonitoredResourcesSearchAssociationTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAssociationType")]
        public virtual void ResetAssociationType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDestinationResourceId")]
        public virtual void ResetDestinationResourceId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDestinationResourceName")]
        public virtual void ResetDestinationResourceName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDestinationResourceType")]
        public virtual void ResetDestinationResourceType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceResourceId")]
        public virtual void ResetSourceResourceId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceResourceName")]
        public virtual void ResetSourceResourceName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceResourceType")]
        public virtual void ResetSourceResourceType()
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
        = GetStaticProperty<string>(typeof(oci.StackMonitoringMonitoredResourcesSearchAssociation.StackMonitoringMonitoredResourcesSearchAssociation))!;

        [JsiiProperty(name: "items", typeJson: "{\"fqn\":\"oci.stackMonitoringMonitoredResourcesSearchAssociation.StackMonitoringMonitoredResourcesSearchAssociationItemsList\"}")]
        public virtual oci.StackMonitoringMonitoredResourcesSearchAssociation.StackMonitoringMonitoredResourcesSearchAssociationItemsList Items
        {
            get => GetInstanceProperty<oci.StackMonitoringMonitoredResourcesSearchAssociation.StackMonitoringMonitoredResourcesSearchAssociationItemsList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.stackMonitoringMonitoredResourcesSearchAssociation.StackMonitoringMonitoredResourcesSearchAssociationTimeoutsOutputReference\"}")]
        public virtual oci.StackMonitoringMonitoredResourcesSearchAssociation.StackMonitoringMonitoredResourcesSearchAssociationTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.StackMonitoringMonitoredResourcesSearchAssociation.StackMonitoringMonitoredResourcesSearchAssociationTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "associationTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AssociationTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "destinationResourceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DestinationResourceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "destinationResourceNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DestinationResourceNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "destinationResourceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DestinationResourceTypeInput
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
        [JsiiProperty(name: "sourceResourceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceResourceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceResourceNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceResourceNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceResourceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceResourceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.stackMonitoringMonitoredResourcesSearchAssociation.StackMonitoringMonitoredResourcesSearchAssociationTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "associationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssociationType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "destinationResourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DestinationResourceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "destinationResourceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DestinationResourceName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "destinationResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DestinationResourceType
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

        [JsiiProperty(name: "sourceResourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceResourceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceResourceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceResourceName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceResourceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
