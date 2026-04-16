using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Organization
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/organization cloudflare_organization}.</summary>
    [JsiiClass(nativeType: typeof(cloudflare.Organization.Organization), fullyQualifiedName: "cloudflare.organization.Organization", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"cloudflare.organization.OrganizationConfig\"}}]")]
    public class Organization : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/organization cloudflare_organization} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public Organization(Constructs.Construct scope, string id, cloudflare.Organization.IOrganizationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, cloudflare.Organization.IOrganizationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Organization(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Organization(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a Organization resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the Organization to import.</param>
        /// <param name="importFromId">The id of the existing Organization that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the Organization to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the Organization to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/organization#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing Organization that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the Organization to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(cloudflare.Organization.Organization), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putParent", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.organization.OrganizationParent\"}}]")]
        public virtual void PutParent(cloudflare.Organization.IOrganizationParent @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.Organization.IOrganizationParent)}, new object[]{@value});
        }

        [JsiiMethod(name: "putProfile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.organization.OrganizationProfile\"}}]")]
        public virtual void PutProfile(cloudflare.Organization.IOrganizationProfile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.Organization.IOrganizationProfile)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetParent")]
        public virtual void ResetParent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProfile")]
        public virtual void ResetProfile()
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
        = GetStaticProperty<string>(typeof(cloudflare.Organization.Organization))!;

        [JsiiProperty(name: "createTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreateTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "meta", typeJson: "{\"fqn\":\"cloudflare.organization.OrganizationMetaOutputReference\"}")]
        public virtual cloudflare.Organization.OrganizationMetaOutputReference Meta
        {
            get => GetInstanceProperty<cloudflare.Organization.OrganizationMetaOutputReference>()!;
        }

        [JsiiProperty(name: "parent", typeJson: "{\"fqn\":\"cloudflare.organization.OrganizationParentOutputReference\"}")]
        public virtual cloudflare.Organization.OrganizationParentOutputReference Parent
        {
            get => GetInstanceProperty<cloudflare.Organization.OrganizationParentOutputReference>()!;
        }

        [JsiiProperty(name: "profile", typeJson: "{\"fqn\":\"cloudflare.organization.OrganizationProfileOutputReference\"}")]
        public virtual cloudflare.Organization.OrganizationProfileOutputReference Profile
        {
            get => GetInstanceProperty<cloudflare.Organization.OrganizationProfileOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "parentInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.organization.OrganizationParent\"}]}}", isOptional: true)]
        public virtual object? ParentInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "profileInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.organization.OrganizationProfile\"}]}}", isOptional: true)]
        public virtual object? ProfileInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
