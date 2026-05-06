using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringMonitoredResourcesListMember
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resources_list_member oci_stack_monitoring_monitored_resources_list_member}.</summary>
    [JsiiClass(nativeType: typeof(oci.StackMonitoringMonitoredResourcesListMember.StackMonitoringMonitoredResourcesListMember), fullyQualifiedName: "oci.stackMonitoringMonitoredResourcesListMember.StackMonitoringMonitoredResourcesListMember", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.stackMonitoringMonitoredResourcesListMember.StackMonitoringMonitoredResourcesListMemberConfig\"}}]")]
    public class StackMonitoringMonitoredResourcesListMember : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resources_list_member oci_stack_monitoring_monitored_resources_list_member} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public StackMonitoringMonitoredResourcesListMember(Constructs.Construct scope, string id, oci.StackMonitoringMonitoredResourcesListMember.IStackMonitoringMonitoredResourcesListMemberConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.StackMonitoringMonitoredResourcesListMember.IStackMonitoringMonitoredResourcesListMemberConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StackMonitoringMonitoredResourcesListMember(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StackMonitoringMonitoredResourcesListMember(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a StackMonitoringMonitoredResourcesListMember resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the StackMonitoringMonitoredResourcesListMember to import.</param>
        /// <param name="importFromId">The id of the existing StackMonitoringMonitoredResourcesListMember that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the StackMonitoringMonitoredResourcesListMember to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the StackMonitoringMonitoredResourcesListMember to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitored_resources_list_member#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing StackMonitoringMonitoredResourcesListMember that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the StackMonitoringMonitoredResourcesListMember to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.StackMonitoringMonitoredResourcesListMember.StackMonitoringMonitoredResourcesListMember), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.stackMonitoringMonitoredResourcesListMember.StackMonitoringMonitoredResourcesListMemberTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.StackMonitoringMonitoredResourcesListMember.IStackMonitoringMonitoredResourcesListMemberTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.StackMonitoringMonitoredResourcesListMember.IStackMonitoringMonitoredResourcesListMemberTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDestinationResourceId")]
        public virtual void ResetDestinationResourceId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLimitLevel")]
        public virtual void ResetLimitLevel()
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
        = GetStaticProperty<string>(typeof(oci.StackMonitoringMonitoredResourcesListMember.StackMonitoringMonitoredResourcesListMember))!;

        [JsiiProperty(name: "items", typeJson: "{\"fqn\":\"oci.stackMonitoringMonitoredResourcesListMember.StackMonitoringMonitoredResourcesListMemberItemsList\"}")]
        public virtual oci.StackMonitoringMonitoredResourcesListMember.StackMonitoringMonitoredResourcesListMemberItemsList Items
        {
            get => GetInstanceProperty<oci.StackMonitoringMonitoredResourcesListMember.StackMonitoringMonitoredResourcesListMemberItemsList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.stackMonitoringMonitoredResourcesListMember.StackMonitoringMonitoredResourcesListMemberTimeoutsOutputReference\"}")]
        public virtual oci.StackMonitoringMonitoredResourcesListMember.StackMonitoringMonitoredResourcesListMemberTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.StackMonitoringMonitoredResourcesListMember.StackMonitoringMonitoredResourcesListMemberTimeoutsOutputReference>()!;
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
        [JsiiProperty(name: "limitLevelInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? LimitLevelInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "monitoredResourceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MonitoredResourceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.stackMonitoringMonitoredResourcesListMember.StackMonitoringMonitoredResourcesListMemberTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
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

        [JsiiProperty(name: "limitLevel", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LimitLevel
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "monitoredResourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MonitoredResourceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
