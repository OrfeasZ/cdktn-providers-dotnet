using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreDedicatedVmHost
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_dedicated_vm_host oci_core_dedicated_vm_host}.</summary>
    [JsiiClass(nativeType: typeof(oci.CoreDedicatedVmHost.CoreDedicatedVmHost), fullyQualifiedName: "oci.coreDedicatedVmHost.CoreDedicatedVmHost", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.coreDedicatedVmHost.CoreDedicatedVmHostConfig\"}}]")]
    public class CoreDedicatedVmHost : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_dedicated_vm_host oci_core_dedicated_vm_host} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public CoreDedicatedVmHost(Constructs.Construct scope, string id, oci.CoreDedicatedVmHost.ICoreDedicatedVmHostConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.CoreDedicatedVmHost.ICoreDedicatedVmHostConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CoreDedicatedVmHost(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CoreDedicatedVmHost(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a CoreDedicatedVmHost resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the CoreDedicatedVmHost to import.</param>
        /// <param name="importFromId">The id of the existing CoreDedicatedVmHost that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the CoreDedicatedVmHost to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the CoreDedicatedVmHost to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_dedicated_vm_host#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing CoreDedicatedVmHost that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the CoreDedicatedVmHost to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.CoreDedicatedVmHost.CoreDedicatedVmHost), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putPlacementConstraintDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreDedicatedVmHost.CoreDedicatedVmHostPlacementConstraintDetails\"}}]")]
        public virtual void PutPlacementConstraintDetails(oci.CoreDedicatedVmHost.ICoreDedicatedVmHostPlacementConstraintDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreDedicatedVmHost.ICoreDedicatedVmHostPlacementConstraintDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreDedicatedVmHost.CoreDedicatedVmHostTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.CoreDedicatedVmHost.ICoreDedicatedVmHostTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreDedicatedVmHost.ICoreDedicatedVmHostTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisplayName")]
        public virtual void ResetDisplayName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFaultDomain")]
        public virtual void ResetFaultDomain()
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

        [JsiiMethod(name: "resetPlacementConstraintDetails")]
        public virtual void ResetPlacementConstraintDetails()
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
        = GetStaticProperty<string>(typeof(oci.CoreDedicatedVmHost.CoreDedicatedVmHost))!;

        [JsiiProperty(name: "capacityBins", typeJson: "{\"fqn\":\"oci.coreDedicatedVmHost.CoreDedicatedVmHostCapacityBinsList\"}")]
        public virtual oci.CoreDedicatedVmHost.CoreDedicatedVmHostCapacityBinsList CapacityBins
        {
            get => GetInstanceProperty<oci.CoreDedicatedVmHost.CoreDedicatedVmHostCapacityBinsList>()!;
        }

        [JsiiProperty(name: "computeBareMetalHostId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputeBareMetalHostId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "placementConstraintDetails", typeJson: "{\"fqn\":\"oci.coreDedicatedVmHost.CoreDedicatedVmHostPlacementConstraintDetailsOutputReference\"}")]
        public virtual oci.CoreDedicatedVmHost.CoreDedicatedVmHostPlacementConstraintDetailsOutputReference PlacementConstraintDetails
        {
            get => GetInstanceProperty<oci.CoreDedicatedVmHost.CoreDedicatedVmHostPlacementConstraintDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "remainingMemoryInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RemainingMemoryInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "remainingOcpus", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RemainingOcpus
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.coreDedicatedVmHost.CoreDedicatedVmHostTimeoutsOutputReference\"}")]
        public virtual oci.CoreDedicatedVmHost.CoreDedicatedVmHostTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.CoreDedicatedVmHost.CoreDedicatedVmHostTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "totalMemoryInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalMemoryInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "totalOcpus", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalOcpus
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "availabilityDomainInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AvailabilityDomainInput
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
        [JsiiProperty(name: "dedicatedVmHostShapeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DedicatedVmHostShapeInput
        {
            get => GetInstanceProperty<string?>();
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
        [JsiiProperty(name: "faultDomainInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FaultDomainInput
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
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "placementConstraintDetailsInput", typeJson: "{\"fqn\":\"oci.coreDedicatedVmHost.CoreDedicatedVmHostPlacementConstraintDetails\"}", isOptional: true)]
        public virtual oci.CoreDedicatedVmHost.ICoreDedicatedVmHostPlacementConstraintDetails? PlacementConstraintDetailsInput
        {
            get => GetInstanceProperty<oci.CoreDedicatedVmHost.ICoreDedicatedVmHostPlacementConstraintDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.coreDedicatedVmHost.CoreDedicatedVmHostTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityDomain
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

        [JsiiProperty(name: "dedicatedVmHostShape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DedicatedVmHostShape
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

        [JsiiProperty(name: "faultDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FaultDomain
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
    }
}
