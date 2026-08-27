using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AutomationRuntimeEnvironmentPackage
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/automation_runtime_environment_package azurerm_automation_runtime_environment_package}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.AutomationRuntimeEnvironmentPackage.AutomationRuntimeEnvironmentPackage), fullyQualifiedName: "azurerm.automationRuntimeEnvironmentPackage.AutomationRuntimeEnvironmentPackage", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.automationRuntimeEnvironmentPackage.AutomationRuntimeEnvironmentPackageConfig\"}}]")]
    public class AutomationRuntimeEnvironmentPackage : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/automation_runtime_environment_package azurerm_automation_runtime_environment_package} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public AutomationRuntimeEnvironmentPackage(Constructs.Construct scope, string id, azurerm.AutomationRuntimeEnvironmentPackage.IAutomationRuntimeEnvironmentPackageConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.AutomationRuntimeEnvironmentPackage.IAutomationRuntimeEnvironmentPackageConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutomationRuntimeEnvironmentPackage(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutomationRuntimeEnvironmentPackage(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a AutomationRuntimeEnvironmentPackage resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the AutomationRuntimeEnvironmentPackage to import.</param>
        /// <param name="importFromId">The id of the existing AutomationRuntimeEnvironmentPackage that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the AutomationRuntimeEnvironmentPackage to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the AutomationRuntimeEnvironmentPackage to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/automation_runtime_environment_package#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing AutomationRuntimeEnvironmentPackage that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the AutomationRuntimeEnvironmentPackage to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurerm.AutomationRuntimeEnvironmentPackage.AutomationRuntimeEnvironmentPackage), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.automationRuntimeEnvironmentPackage.AutomationRuntimeEnvironmentPackageTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.AutomationRuntimeEnvironmentPackage.IAutomationRuntimeEnvironmentPackageTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.AutomationRuntimeEnvironmentPackage.IAutomationRuntimeEnvironmentPackageTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetContentVersion")]
        public virtual void ResetContentVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHashAlgorithm")]
        public virtual void ResetHashAlgorithm()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHashValue")]
        public virtual void ResetHashValue()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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
        = GetStaticProperty<string>(typeof(azurerm.AutomationRuntimeEnvironmentPackage.AutomationRuntimeEnvironmentPackage))!;

        [JsiiProperty(name: "default", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Default
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "sizeInBytes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SizeInBytes
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.automationRuntimeEnvironmentPackage.AutomationRuntimeEnvironmentPackageTimeoutsOutputReference\"}")]
        public virtual azurerm.AutomationRuntimeEnvironmentPackage.AutomationRuntimeEnvironmentPackageTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.AutomationRuntimeEnvironmentPackage.AutomationRuntimeEnvironmentPackageTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "automationRuntimeEnvironmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AutomationRuntimeEnvironmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "contentUriInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ContentUriInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "contentVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ContentVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hashAlgorithmInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HashAlgorithmInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hashValueInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HashValueInput
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
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.AutomationRuntimeEnvironmentPackage.IAutomationRuntimeEnvironmentPackageTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.automationRuntimeEnvironmentPackage.AutomationRuntimeEnvironmentPackageTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "automationRuntimeEnvironmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutomationRuntimeEnvironmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "contentUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContentUri
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "contentVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContentVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "hashAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HashAlgorithm
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "hashValue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HashValue
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

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
