using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualDesktopScalingPlanHostPoolAssociation
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/virtual_desktop_scaling_plan_host_pool_association azurerm_virtual_desktop_scaling_plan_host_pool_association}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.VirtualDesktopScalingPlanHostPoolAssociation.VirtualDesktopScalingPlanHostPoolAssociation), fullyQualifiedName: "azurerm.virtualDesktopScalingPlanHostPoolAssociation.VirtualDesktopScalingPlanHostPoolAssociation", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.virtualDesktopScalingPlanHostPoolAssociation.VirtualDesktopScalingPlanHostPoolAssociationConfig\"}}]")]
    public class VirtualDesktopScalingPlanHostPoolAssociation : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/virtual_desktop_scaling_plan_host_pool_association azurerm_virtual_desktop_scaling_plan_host_pool_association} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public VirtualDesktopScalingPlanHostPoolAssociation(Constructs.Construct scope, string id, azurerm.VirtualDesktopScalingPlanHostPoolAssociation.IVirtualDesktopScalingPlanHostPoolAssociationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.VirtualDesktopScalingPlanHostPoolAssociation.IVirtualDesktopScalingPlanHostPoolAssociationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VirtualDesktopScalingPlanHostPoolAssociation(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VirtualDesktopScalingPlanHostPoolAssociation(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a VirtualDesktopScalingPlanHostPoolAssociation resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the VirtualDesktopScalingPlanHostPoolAssociation to import.</param>
        /// <param name="importFromId">The id of the existing VirtualDesktopScalingPlanHostPoolAssociation that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the VirtualDesktopScalingPlanHostPoolAssociation to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the VirtualDesktopScalingPlanHostPoolAssociation to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/virtual_desktop_scaling_plan_host_pool_association#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing VirtualDesktopScalingPlanHostPoolAssociation that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the VirtualDesktopScalingPlanHostPoolAssociation to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurerm.VirtualDesktopScalingPlanHostPoolAssociation.VirtualDesktopScalingPlanHostPoolAssociation), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.virtualDesktopScalingPlanHostPoolAssociation.VirtualDesktopScalingPlanHostPoolAssociationTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.VirtualDesktopScalingPlanHostPoolAssociation.IVirtualDesktopScalingPlanHostPoolAssociationTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.VirtualDesktopScalingPlanHostPoolAssociation.IVirtualDesktopScalingPlanHostPoolAssociationTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(azurerm.VirtualDesktopScalingPlanHostPoolAssociation.VirtualDesktopScalingPlanHostPoolAssociation))!;

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.virtualDesktopScalingPlanHostPoolAssociation.VirtualDesktopScalingPlanHostPoolAssociationTimeoutsOutputReference\"}")]
        public virtual azurerm.VirtualDesktopScalingPlanHostPoolAssociation.VirtualDesktopScalingPlanHostPoolAssociationTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.VirtualDesktopScalingPlanHostPoolAssociation.VirtualDesktopScalingPlanHostPoolAssociationTimeoutsOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostPoolIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HostPoolIdInput
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
        [JsiiProperty(name: "scalingPlanIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScalingPlanIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.VirtualDesktopScalingPlanHostPoolAssociation.IVirtualDesktopScalingPlanHostPoolAssociationTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.virtualDesktopScalingPlanHostPoolAssociation.VirtualDesktopScalingPlanHostPoolAssociationTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Enabled
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

        [JsiiProperty(name: "hostPoolId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostPoolId
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

        [JsiiProperty(name: "scalingPlanId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScalingPlanId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
