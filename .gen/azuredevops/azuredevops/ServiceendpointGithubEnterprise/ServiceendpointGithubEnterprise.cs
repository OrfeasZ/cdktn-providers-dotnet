using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointGithubEnterprise
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_github_enterprise azuredevops_serviceendpoint_github_enterprise}.</summary>
    [JsiiClass(nativeType: typeof(azuredevops.ServiceendpointGithubEnterprise.ServiceendpointGithubEnterprise), fullyQualifiedName: "azuredevops.serviceendpointGithubEnterprise.ServiceendpointGithubEnterprise", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azuredevops.serviceendpointGithubEnterprise.ServiceendpointGithubEnterpriseConfig\"}}]")]
    public class ServiceendpointGithubEnterprise : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_github_enterprise azuredevops_serviceendpoint_github_enterprise} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ServiceendpointGithubEnterprise(Constructs.Construct scope, string id, azuredevops.ServiceendpointGithubEnterprise.IServiceendpointGithubEnterpriseConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azuredevops.ServiceendpointGithubEnterprise.IServiceendpointGithubEnterpriseConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServiceendpointGithubEnterprise(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServiceendpointGithubEnterprise(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a ServiceendpointGithubEnterprise resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ServiceendpointGithubEnterprise to import.</param>
        /// <param name="importFromId">The id of the existing ServiceendpointGithubEnterprise that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ServiceendpointGithubEnterprise to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ServiceendpointGithubEnterprise to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_github_enterprise#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ServiceendpointGithubEnterprise that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ServiceendpointGithubEnterprise to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azuredevops.ServiceendpointGithubEnterprise.ServiceendpointGithubEnterprise), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAuthOauth", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.serviceendpointGithubEnterprise.ServiceendpointGithubEnterpriseAuthOauth\"}}]")]
        public virtual void PutAuthOauth(azuredevops.ServiceendpointGithubEnterprise.IServiceendpointGithubEnterpriseAuthOauth @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.ServiceendpointGithubEnterprise.IServiceendpointGithubEnterpriseAuthOauth)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAuthPersonal", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.serviceendpointGithubEnterprise.ServiceendpointGithubEnterpriseAuthPersonal\"}}]")]
        public virtual void PutAuthPersonal(azuredevops.ServiceendpointGithubEnterprise.IServiceendpointGithubEnterpriseAuthPersonal @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.ServiceendpointGithubEnterprise.IServiceendpointGithubEnterpriseAuthPersonal)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.serviceendpointGithubEnterprise.ServiceendpointGithubEnterpriseTimeouts\"}}]")]
        public virtual void PutTimeouts(azuredevops.ServiceendpointGithubEnterprise.IServiceendpointGithubEnterpriseTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.ServiceendpointGithubEnterprise.IServiceendpointGithubEnterpriseTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAuthOauth")]
        public virtual void ResetAuthOauth()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAuthPersonal")]
        public virtual void ResetAuthPersonal()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
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

        [JsiiMethod(name: "resetUrl")]
        public virtual void ResetUrl()
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
        = GetStaticProperty<string>(typeof(azuredevops.ServiceendpointGithubEnterprise.ServiceendpointGithubEnterprise))!;

        [JsiiProperty(name: "authOauth", typeJson: "{\"fqn\":\"azuredevops.serviceendpointGithubEnterprise.ServiceendpointGithubEnterpriseAuthOauthOutputReference\"}")]
        public virtual azuredevops.ServiceendpointGithubEnterprise.ServiceendpointGithubEnterpriseAuthOauthOutputReference AuthOauth
        {
            get => GetInstanceProperty<azuredevops.ServiceendpointGithubEnterprise.ServiceendpointGithubEnterpriseAuthOauthOutputReference>()!;
        }

        [JsiiProperty(name: "authorization", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap Authorization
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "authPersonal", typeJson: "{\"fqn\":\"azuredevops.serviceendpointGithubEnterprise.ServiceendpointGithubEnterpriseAuthPersonalOutputReference\"}")]
        public virtual azuredevops.ServiceendpointGithubEnterprise.ServiceendpointGithubEnterpriseAuthPersonalOutputReference AuthPersonal
        {
            get => GetInstanceProperty<azuredevops.ServiceendpointGithubEnterprise.ServiceendpointGithubEnterpriseAuthPersonalOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuredevops.serviceendpointGithubEnterprise.ServiceendpointGithubEnterpriseTimeoutsOutputReference\"}")]
        public virtual azuredevops.ServiceendpointGithubEnterprise.ServiceendpointGithubEnterpriseTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azuredevops.ServiceendpointGithubEnterprise.ServiceendpointGithubEnterpriseTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "authOauthInput", typeJson: "{\"fqn\":\"azuredevops.serviceendpointGithubEnterprise.ServiceendpointGithubEnterpriseAuthOauth\"}", isOptional: true)]
        public virtual azuredevops.ServiceendpointGithubEnterprise.IServiceendpointGithubEnterpriseAuthOauth? AuthOauthInput
        {
            get => GetInstanceProperty<azuredevops.ServiceendpointGithubEnterprise.IServiceendpointGithubEnterpriseAuthOauth?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authPersonalInput", typeJson: "{\"fqn\":\"azuredevops.serviceendpointGithubEnterprise.ServiceendpointGithubEnterpriseAuthPersonal\"}", isOptional: true)]
        public virtual azuredevops.ServiceendpointGithubEnterprise.IServiceendpointGithubEnterpriseAuthPersonal? AuthPersonalInput
        {
            get => GetInstanceProperty<azuredevops.ServiceendpointGithubEnterprise.IServiceendpointGithubEnterpriseAuthPersonal?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
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
        [JsiiProperty(name: "projectIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProjectIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceEndpointNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceEndpointNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azuredevops.ServiceendpointGithubEnterprise.IServiceendpointGithubEnterpriseTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azuredevops.serviceendpointGithubEnterprise.ServiceendpointGithubEnterpriseTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "urlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
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

        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProjectId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceEndpointName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceEndpointName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Url
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
