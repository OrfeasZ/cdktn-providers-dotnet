using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringMonitoredResourcesAssociateMonitoredResource
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resources_associate_monitored_resource oci_stack_monitoring_monitored_resources_associate_monitored_resource}.</summary>
    [JsiiClass(nativeType: typeof(oci.StackMonitoringMonitoredResourcesAssociateMonitoredResource.StackMonitoringMonitoredResourcesAssociateMonitoredResource), fullyQualifiedName: "oci.stackMonitoringMonitoredResourcesAssociateMonitoredResource.StackMonitoringMonitoredResourcesAssociateMonitoredResource", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.stackMonitoringMonitoredResourcesAssociateMonitoredResource.StackMonitoringMonitoredResourcesAssociateMonitoredResourceConfig\"}}]")]
    public class StackMonitoringMonitoredResourcesAssociateMonitoredResource : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resources_associate_monitored_resource oci_stack_monitoring_monitored_resources_associate_monitored_resource} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public StackMonitoringMonitoredResourcesAssociateMonitoredResource(Constructs.Construct scope, string id, oci.StackMonitoringMonitoredResourcesAssociateMonitoredResource.IStackMonitoringMonitoredResourcesAssociateMonitoredResourceConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.StackMonitoringMonitoredResourcesAssociateMonitoredResource.IStackMonitoringMonitoredResourcesAssociateMonitoredResourceConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StackMonitoringMonitoredResourcesAssociateMonitoredResource(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StackMonitoringMonitoredResourcesAssociateMonitoredResource(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a StackMonitoringMonitoredResourcesAssociateMonitoredResource resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the StackMonitoringMonitoredResourcesAssociateMonitoredResource to import.</param>
        /// <param name="importFromId">The id of the existing StackMonitoringMonitoredResourcesAssociateMonitoredResource that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the StackMonitoringMonitoredResourcesAssociateMonitoredResource to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the StackMonitoringMonitoredResourcesAssociateMonitoredResource to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resources_associate_monitored_resource#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing StackMonitoringMonitoredResourcesAssociateMonitoredResource that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the StackMonitoringMonitoredResourcesAssociateMonitoredResource to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.StackMonitoringMonitoredResourcesAssociateMonitoredResource.StackMonitoringMonitoredResourcesAssociateMonitoredResource), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.stackMonitoringMonitoredResourcesAssociateMonitoredResource.StackMonitoringMonitoredResourcesAssociateMonitoredResourceTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.StackMonitoringMonitoredResourcesAssociateMonitoredResource.IStackMonitoringMonitoredResourcesAssociateMonitoredResourceTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.StackMonitoringMonitoredResourcesAssociateMonitoredResource.IStackMonitoringMonitoredResourcesAssociateMonitoredResourceTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
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
        = GetStaticProperty<string>(typeof(oci.StackMonitoringMonitoredResourcesAssociateMonitoredResource.StackMonitoringMonitoredResourcesAssociateMonitoredResource))!;

        [JsiiProperty(name: "category", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Category
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "destinationResourceDetails", typeJson: "{\"fqn\":\"oci.stackMonitoringMonitoredResourcesAssociateMonitoredResource.StackMonitoringMonitoredResourcesAssociateMonitoredResourceDestinationResourceDetailsList\"}")]
        public virtual oci.StackMonitoringMonitoredResourcesAssociateMonitoredResource.StackMonitoringMonitoredResourcesAssociateMonitoredResourceDestinationResourceDetailsList DestinationResourceDetails
        {
            get => GetInstanceProperty<oci.StackMonitoringMonitoredResourcesAssociateMonitoredResource.StackMonitoringMonitoredResourcesAssociateMonitoredResourceDestinationResourceDetailsList>()!;
        }

        [JsiiProperty(name: "sourceResourceDetails", typeJson: "{\"fqn\":\"oci.stackMonitoringMonitoredResourcesAssociateMonitoredResource.StackMonitoringMonitoredResourcesAssociateMonitoredResourceSourceResourceDetailsList\"}")]
        public virtual oci.StackMonitoringMonitoredResourcesAssociateMonitoredResource.StackMonitoringMonitoredResourcesAssociateMonitoredResourceSourceResourceDetailsList SourceResourceDetails
        {
            get => GetInstanceProperty<oci.StackMonitoringMonitoredResourcesAssociateMonitoredResource.StackMonitoringMonitoredResourcesAssociateMonitoredResourceSourceResourceDetailsList>()!;
        }

        [JsiiProperty(name: "tenantId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenantId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.stackMonitoringMonitoredResourcesAssociateMonitoredResource.StackMonitoringMonitoredResourcesAssociateMonitoredResourceTimeoutsOutputReference\"}")]
        public virtual oci.StackMonitoringMonitoredResourcesAssociateMonitoredResource.StackMonitoringMonitoredResourcesAssociateMonitoredResourceTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.StackMonitoringMonitoredResourcesAssociateMonitoredResource.StackMonitoringMonitoredResourcesAssociateMonitoredResourceTimeoutsOutputReference>()!;
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.stackMonitoringMonitoredResourcesAssociateMonitoredResource.StackMonitoringMonitoredResourcesAssociateMonitoredResourceTimeouts\"}]}}", isOptional: true)]
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
    }
}
