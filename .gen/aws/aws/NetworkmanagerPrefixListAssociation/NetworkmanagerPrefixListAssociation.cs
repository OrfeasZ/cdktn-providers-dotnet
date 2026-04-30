using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkmanagerPrefixListAssociation
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/networkmanager_prefix_list_association aws_networkmanager_prefix_list_association}.</summary>
    [JsiiClass(nativeType: typeof(aws.NetworkmanagerPrefixListAssociation.NetworkmanagerPrefixListAssociation), fullyQualifiedName: "aws.networkmanagerPrefixListAssociation.NetworkmanagerPrefixListAssociation", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.networkmanagerPrefixListAssociation.NetworkmanagerPrefixListAssociationConfig\"}}]")]
    public class NetworkmanagerPrefixListAssociation : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/networkmanager_prefix_list_association aws_networkmanager_prefix_list_association} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public NetworkmanagerPrefixListAssociation(Constructs.Construct scope, string id, aws.NetworkmanagerPrefixListAssociation.INetworkmanagerPrefixListAssociationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.NetworkmanagerPrefixListAssociation.INetworkmanagerPrefixListAssociationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetworkmanagerPrefixListAssociation(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetworkmanagerPrefixListAssociation(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a NetworkmanagerPrefixListAssociation resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the NetworkmanagerPrefixListAssociation to import.</param>
        /// <param name="importFromId">The id of the existing NetworkmanagerPrefixListAssociation that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the NetworkmanagerPrefixListAssociation to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the NetworkmanagerPrefixListAssociation to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/networkmanager_prefix_list_association#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing NetworkmanagerPrefixListAssociation that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the NetworkmanagerPrefixListAssociation to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(aws.NetworkmanagerPrefixListAssociation.NetworkmanagerPrefixListAssociation), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(aws.NetworkmanagerPrefixListAssociation.NetworkmanagerPrefixListAssociation))!;

        [JsiiOptional]
        [JsiiProperty(name: "coreNetworkIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CoreNetworkIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "prefixListAliasInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrefixListAliasInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "prefixListArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrefixListArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "coreNetworkId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CoreNetworkId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "prefixListAlias", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrefixListAlias
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "prefixListArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrefixListArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
