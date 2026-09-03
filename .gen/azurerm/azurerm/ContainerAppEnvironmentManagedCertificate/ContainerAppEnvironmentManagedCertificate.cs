using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerAppEnvironmentManagedCertificate
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/container_app_environment_managed_certificate azurerm_container_app_environment_managed_certificate}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.ContainerAppEnvironmentManagedCertificate.ContainerAppEnvironmentManagedCertificate), fullyQualifiedName: "azurerm.containerAppEnvironmentManagedCertificate.ContainerAppEnvironmentManagedCertificate", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.containerAppEnvironmentManagedCertificate.ContainerAppEnvironmentManagedCertificateConfig\"}}]")]
    public class ContainerAppEnvironmentManagedCertificate : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/container_app_environment_managed_certificate azurerm_container_app_environment_managed_certificate} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ContainerAppEnvironmentManagedCertificate(Constructs.Construct scope, string id, azurerm.ContainerAppEnvironmentManagedCertificate.IContainerAppEnvironmentManagedCertificateConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.ContainerAppEnvironmentManagedCertificate.IContainerAppEnvironmentManagedCertificateConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ContainerAppEnvironmentManagedCertificate(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ContainerAppEnvironmentManagedCertificate(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a ContainerAppEnvironmentManagedCertificate resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ContainerAppEnvironmentManagedCertificate to import.</param>
        /// <param name="importFromId">The id of the existing ContainerAppEnvironmentManagedCertificate that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ContainerAppEnvironmentManagedCertificate to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ContainerAppEnvironmentManagedCertificate to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/container_app_environment_managed_certificate#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ContainerAppEnvironmentManagedCertificate that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ContainerAppEnvironmentManagedCertificate to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurerm.ContainerAppEnvironmentManagedCertificate.ContainerAppEnvironmentManagedCertificate), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.containerAppEnvironmentManagedCertificate.ContainerAppEnvironmentManagedCertificateTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.ContainerAppEnvironmentManagedCertificate.IContainerAppEnvironmentManagedCertificateTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ContainerAppEnvironmentManagedCertificate.IContainerAppEnvironmentManagedCertificateTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDomainControlValidation")]
        public virtual void ResetDomainControlValidation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
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
        = GetStaticProperty<string>(typeof(azurerm.ContainerAppEnvironmentManagedCertificate.ContainerAppEnvironmentManagedCertificate))!;

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.containerAppEnvironmentManagedCertificate.ContainerAppEnvironmentManagedCertificateTimeoutsOutputReference\"}")]
        public virtual azurerm.ContainerAppEnvironmentManagedCertificate.ContainerAppEnvironmentManagedCertificateTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.ContainerAppEnvironmentManagedCertificate.ContainerAppEnvironmentManagedCertificateTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "validationToken", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ValidationToken
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "containerAppEnvironmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ContainerAppEnvironmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "domainControlValidationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DomainControlValidationInput
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

        [JsiiOptional]
        [JsiiProperty(name: "subjectNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubjectNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.ContainerAppEnvironmentManagedCertificate.IContainerAppEnvironmentManagedCertificateTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.containerAppEnvironmentManagedCertificate.ContainerAppEnvironmentManagedCertificateTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "containerAppEnvironmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContainerAppEnvironmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "domainControlValidation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainControlValidation
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

        [JsiiProperty(name: "subjectName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubjectName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
