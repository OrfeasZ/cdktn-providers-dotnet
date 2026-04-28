using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DropletAutoscale
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/droplet_autoscale digitalocean_droplet_autoscale}.</summary>
    [JsiiClass(nativeType: typeof(digitalocean.DropletAutoscale.DropletAutoscale), fullyQualifiedName: "digitalocean.dropletAutoscale.DropletAutoscale", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"digitalocean.dropletAutoscale.DropletAutoscaleConfig\"}}]")]
    public class DropletAutoscale : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/droplet_autoscale digitalocean_droplet_autoscale} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DropletAutoscale(Constructs.Construct scope, string id, digitalocean.DropletAutoscale.IDropletAutoscaleConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, digitalocean.DropletAutoscale.IDropletAutoscaleConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DropletAutoscale(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DropletAutoscale(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DropletAutoscale resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DropletAutoscale to import.</param>
        /// <param name="importFromId">The id of the existing DropletAutoscale that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DropletAutoscale to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DropletAutoscale to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/droplet_autoscale#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DropletAutoscale that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DropletAutoscale to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(digitalocean.DropletAutoscale.DropletAutoscale), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.dropletAutoscale.DropletAutoscaleConfigA\"}}]")]
        public virtual void PutConfig(digitalocean.DropletAutoscale.IDropletAutoscaleConfigA @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.DropletAutoscale.IDropletAutoscaleConfigA)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDropletTemplate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.dropletAutoscale.DropletAutoscaleDropletTemplate\"}}]")]
        public virtual void PutDropletTemplate(digitalocean.DropletAutoscale.IDropletAutoscaleDropletTemplate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.DropletAutoscale.IDropletAutoscaleDropletTemplate)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(digitalocean.DropletAutoscale.DropletAutoscale))!;

        [JsiiProperty(name: "config", typeJson: "{\"fqn\":\"digitalocean.dropletAutoscale.DropletAutoscaleConfigAOutputReference\"}")]
        public virtual digitalocean.DropletAutoscale.DropletAutoscaleConfigAOutputReference Config
        {
            get => GetInstanceProperty<digitalocean.DropletAutoscale.DropletAutoscaleConfigAOutputReference>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "currentUtilization", typeJson: "{\"fqn\":\"digitalocean.dropletAutoscale.DropletAutoscaleCurrentUtilizationList\"}")]
        public virtual digitalocean.DropletAutoscale.DropletAutoscaleCurrentUtilizationList CurrentUtilization
        {
            get => GetInstanceProperty<digitalocean.DropletAutoscale.DropletAutoscaleCurrentUtilizationList>()!;
        }

        [JsiiProperty(name: "dropletTemplate", typeJson: "{\"fqn\":\"digitalocean.dropletAutoscale.DropletAutoscaleDropletTemplateOutputReference\"}")]
        public virtual digitalocean.DropletAutoscale.DropletAutoscaleDropletTemplateOutputReference DropletTemplate
        {
            get => GetInstanceProperty<digitalocean.DropletAutoscale.DropletAutoscaleDropletTemplateOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "updatedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "configInput", typeJson: "{\"fqn\":\"digitalocean.dropletAutoscale.DropletAutoscaleConfigA\"}", isOptional: true)]
        public virtual digitalocean.DropletAutoscale.IDropletAutoscaleConfigA? ConfigInput
        {
            get => GetInstanceProperty<digitalocean.DropletAutoscale.IDropletAutoscaleConfigA?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dropletTemplateInput", typeJson: "{\"fqn\":\"digitalocean.dropletAutoscale.DropletAutoscaleDropletTemplate\"}", isOptional: true)]
        public virtual digitalocean.DropletAutoscale.IDropletAutoscaleDropletTemplate? DropletTemplateInput
        {
            get => GetInstanceProperty<digitalocean.DropletAutoscale.IDropletAutoscaleDropletTemplate?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
