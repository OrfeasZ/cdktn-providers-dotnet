using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ArcMachineAutomanageConfigurationAssignment
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/arc_machine_automanage_configuration_assignment azurerm_arc_machine_automanage_configuration_assignment}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.ArcMachineAutomanageConfigurationAssignment.ArcMachineAutomanageConfigurationAssignment), fullyQualifiedName: "azurerm.arcMachineAutomanageConfigurationAssignment.ArcMachineAutomanageConfigurationAssignment", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.arcMachineAutomanageConfigurationAssignment.ArcMachineAutomanageConfigurationAssignmentConfig\"}}]")]
    public class ArcMachineAutomanageConfigurationAssignment : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/arc_machine_automanage_configuration_assignment azurerm_arc_machine_automanage_configuration_assignment} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ArcMachineAutomanageConfigurationAssignment(Constructs.Construct scope, string id, azurerm.ArcMachineAutomanageConfigurationAssignment.IArcMachineAutomanageConfigurationAssignmentConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.ArcMachineAutomanageConfigurationAssignment.IArcMachineAutomanageConfigurationAssignmentConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ArcMachineAutomanageConfigurationAssignment(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ArcMachineAutomanageConfigurationAssignment(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a ArcMachineAutomanageConfigurationAssignment resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ArcMachineAutomanageConfigurationAssignment to import.</param>
        /// <param name="importFromId">The id of the existing ArcMachineAutomanageConfigurationAssignment that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ArcMachineAutomanageConfigurationAssignment to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ArcMachineAutomanageConfigurationAssignment to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/arc_machine_automanage_configuration_assignment#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ArcMachineAutomanageConfigurationAssignment that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ArcMachineAutomanageConfigurationAssignment to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurerm.ArcMachineAutomanageConfigurationAssignment.ArcMachineAutomanageConfigurationAssignment), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.arcMachineAutomanageConfigurationAssignment.ArcMachineAutomanageConfigurationAssignmentTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.ArcMachineAutomanageConfigurationAssignment.IArcMachineAutomanageConfigurationAssignmentTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ArcMachineAutomanageConfigurationAssignment.IArcMachineAutomanageConfigurationAssignmentTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(azurerm.ArcMachineAutomanageConfigurationAssignment.ArcMachineAutomanageConfigurationAssignment))!;

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.arcMachineAutomanageConfigurationAssignment.ArcMachineAutomanageConfigurationAssignmentTimeoutsOutputReference\"}")]
        public virtual azurerm.ArcMachineAutomanageConfigurationAssignment.ArcMachineAutomanageConfigurationAssignmentTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.ArcMachineAutomanageConfigurationAssignment.ArcMachineAutomanageConfigurationAssignmentTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "arcMachineIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ArcMachineIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "configurationIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConfigurationIdInput
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.ArcMachineAutomanageConfigurationAssignment.IArcMachineAutomanageConfigurationAssignmentTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.arcMachineAutomanageConfigurationAssignment.ArcMachineAutomanageConfigurationAssignmentTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "arcMachineId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ArcMachineId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "configurationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigurationId
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
    }
}
