using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AdmRemediationRecipe
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe oci_adm_remediation_recipe}.</summary>
    [JsiiClass(nativeType: typeof(oci.AdmRemediationRecipe.AdmRemediationRecipe), fullyQualifiedName: "oci.admRemediationRecipe.AdmRemediationRecipe", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.admRemediationRecipe.AdmRemediationRecipeConfig\"}}]")]
    public class AdmRemediationRecipe : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe oci_adm_remediation_recipe} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public AdmRemediationRecipe(Constructs.Construct scope, string id, oci.AdmRemediationRecipe.IAdmRemediationRecipeConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.AdmRemediationRecipe.IAdmRemediationRecipeConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AdmRemediationRecipe(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AdmRemediationRecipe(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a AdmRemediationRecipe resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the AdmRemediationRecipe to import.</param>
        /// <param name="importFromId">The id of the existing AdmRemediationRecipe that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the AdmRemediationRecipe to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the AdmRemediationRecipe to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing AdmRemediationRecipe that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the AdmRemediationRecipe to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.AdmRemediationRecipe.AdmRemediationRecipe), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putDetectConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.admRemediationRecipe.AdmRemediationRecipeDetectConfiguration\"}}]")]
        public virtual void PutDetectConfiguration(oci.AdmRemediationRecipe.IAdmRemediationRecipeDetectConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.AdmRemediationRecipe.IAdmRemediationRecipeDetectConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetworkConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.admRemediationRecipe.AdmRemediationRecipeNetworkConfiguration\"}}]")]
        public virtual void PutNetworkConfiguration(oci.AdmRemediationRecipe.IAdmRemediationRecipeNetworkConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.AdmRemediationRecipe.IAdmRemediationRecipeNetworkConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putScmConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.admRemediationRecipe.AdmRemediationRecipeScmConfiguration\"}}]")]
        public virtual void PutScmConfiguration(oci.AdmRemediationRecipe.IAdmRemediationRecipeScmConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.AdmRemediationRecipe.IAdmRemediationRecipeScmConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.admRemediationRecipe.AdmRemediationRecipeTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.AdmRemediationRecipe.IAdmRemediationRecipeTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.AdmRemediationRecipe.IAdmRemediationRecipeTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVerifyConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.admRemediationRecipe.AdmRemediationRecipeVerifyConfiguration\"}}]")]
        public virtual void PutVerifyConfiguration(oci.AdmRemediationRecipe.IAdmRemediationRecipeVerifyConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.AdmRemediationRecipe.IAdmRemediationRecipeVerifyConfiguration)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(oci.AdmRemediationRecipe.AdmRemediationRecipe))!;

        [JsiiProperty(name: "detectConfiguration", typeJson: "{\"fqn\":\"oci.admRemediationRecipe.AdmRemediationRecipeDetectConfigurationOutputReference\"}")]
        public virtual oci.AdmRemediationRecipe.AdmRemediationRecipeDetectConfigurationOutputReference DetectConfiguration
        {
            get => GetInstanceProperty<oci.AdmRemediationRecipe.AdmRemediationRecipeDetectConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "networkConfiguration", typeJson: "{\"fqn\":\"oci.admRemediationRecipe.AdmRemediationRecipeNetworkConfigurationOutputReference\"}")]
        public virtual oci.AdmRemediationRecipe.AdmRemediationRecipeNetworkConfigurationOutputReference NetworkConfiguration
        {
            get => GetInstanceProperty<oci.AdmRemediationRecipe.AdmRemediationRecipeNetworkConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "scmConfiguration", typeJson: "{\"fqn\":\"oci.admRemediationRecipe.AdmRemediationRecipeScmConfigurationOutputReference\"}")]
        public virtual oci.AdmRemediationRecipe.AdmRemediationRecipeScmConfigurationOutputReference ScmConfiguration
        {
            get => GetInstanceProperty<oci.AdmRemediationRecipe.AdmRemediationRecipeScmConfigurationOutputReference>()!;
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

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.admRemediationRecipe.AdmRemediationRecipeTimeoutsOutputReference\"}")]
        public virtual oci.AdmRemediationRecipe.AdmRemediationRecipeTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.AdmRemediationRecipe.AdmRemediationRecipeTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "verifyConfiguration", typeJson: "{\"fqn\":\"oci.admRemediationRecipe.AdmRemediationRecipeVerifyConfigurationOutputReference\"}")]
        public virtual oci.AdmRemediationRecipe.AdmRemediationRecipeVerifyConfigurationOutputReference VerifyConfiguration
        {
            get => GetInstanceProperty<oci.AdmRemediationRecipe.AdmRemediationRecipeVerifyConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
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
        [JsiiProperty(name: "detectConfigurationInput", typeJson: "{\"fqn\":\"oci.admRemediationRecipe.AdmRemediationRecipeDetectConfiguration\"}", isOptional: true)]
        public virtual oci.AdmRemediationRecipe.IAdmRemediationRecipeDetectConfiguration? DetectConfigurationInput
        {
            get => GetInstanceProperty<oci.AdmRemediationRecipe.IAdmRemediationRecipeDetectConfiguration?>();
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
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isRunTriggeredOnKbChangeInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsRunTriggeredOnKbChangeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "knowledgeBaseIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KnowledgeBaseIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkConfigurationInput", typeJson: "{\"fqn\":\"oci.admRemediationRecipe.AdmRemediationRecipeNetworkConfiguration\"}", isOptional: true)]
        public virtual oci.AdmRemediationRecipe.IAdmRemediationRecipeNetworkConfiguration? NetworkConfigurationInput
        {
            get => GetInstanceProperty<oci.AdmRemediationRecipe.IAdmRemediationRecipeNetworkConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scmConfigurationInput", typeJson: "{\"fqn\":\"oci.admRemediationRecipe.AdmRemediationRecipeScmConfiguration\"}", isOptional: true)]
        public virtual oci.AdmRemediationRecipe.IAdmRemediationRecipeScmConfiguration? ScmConfigurationInput
        {
            get => GetInstanceProperty<oci.AdmRemediationRecipe.IAdmRemediationRecipeScmConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.admRemediationRecipe.AdmRemediationRecipeTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "verifyConfigurationInput", typeJson: "{\"fqn\":\"oci.admRemediationRecipe.AdmRemediationRecipeVerifyConfiguration\"}", isOptional: true)]
        public virtual oci.AdmRemediationRecipe.IAdmRemediationRecipeVerifyConfiguration? VerifyConfigurationInput
        {
            get => GetInstanceProperty<oci.AdmRemediationRecipe.IAdmRemediationRecipeVerifyConfiguration?>();
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
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

        [JsiiProperty(name: "isRunTriggeredOnKbChange", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsRunTriggeredOnKbChange
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

        [JsiiProperty(name: "knowledgeBaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KnowledgeBaseId
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
