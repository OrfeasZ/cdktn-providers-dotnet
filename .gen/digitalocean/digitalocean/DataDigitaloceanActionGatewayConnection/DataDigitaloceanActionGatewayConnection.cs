using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanActionGatewayConnection
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/data-sources/action_gateway_connection digitalocean_action_gateway_connection}.</summary>
    [JsiiClass(nativeType: typeof(digitalocean.DataDigitaloceanActionGatewayConnection.DataDigitaloceanActionGatewayConnection), fullyQualifiedName: "digitalocean.dataDigitaloceanActionGatewayConnection.DataDigitaloceanActionGatewayConnection", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"digitalocean.dataDigitaloceanActionGatewayConnection.DataDigitaloceanActionGatewayConnectionConfig\"}}]")]
    public class DataDigitaloceanActionGatewayConnection : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/data-sources/action_gateway_connection digitalocean_action_gateway_connection} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataDigitaloceanActionGatewayConnection(Constructs.Construct scope, string id, digitalocean.DataDigitaloceanActionGatewayConnection.IDataDigitaloceanActionGatewayConnectionConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, digitalocean.DataDigitaloceanActionGatewayConnection.IDataDigitaloceanActionGatewayConnectionConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataDigitaloceanActionGatewayConnection(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataDigitaloceanActionGatewayConnection(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataDigitaloceanActionGatewayConnection resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataDigitaloceanActionGatewayConnection to import.</param>
        /// <param name="importFromId">The id of the existing DataDigitaloceanActionGatewayConnection that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataDigitaloceanActionGatewayConnection to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataDigitaloceanActionGatewayConnection to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/data-sources/action_gateway_connection#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataDigitaloceanActionGatewayConnection that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataDigitaloceanActionGatewayConnection to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(digitalocean.DataDigitaloceanActionGatewayConnection.DataDigitaloceanActionGatewayConnection), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetToolProvider")]
        public virtual void ResetToolProvider()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserId")]
        public virtual void ResetUserId()
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
        = GetStaticProperty<string>(typeof(digitalocean.DataDigitaloceanActionGatewayConnection.DataDigitaloceanActionGatewayConnection))!;

        [JsiiProperty(name: "authorization", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanActionGatewayConnection.DataDigitaloceanActionGatewayConnectionAuthorizationList\"}")]
        public virtual digitalocean.DataDigitaloceanActionGatewayConnection.DataDigitaloceanActionGatewayConnectionAuthorizationList Authorization
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanActionGatewayConnection.DataDigitaloceanActionGatewayConnectionAuthorizationList>()!;
        }

        [JsiiProperty(name: "connectionParameters", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap ConnectionParameters
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "credentialId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CredentialId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "credentialKind", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CredentialKind
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "grantedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GrantedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "owningUserId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OwningUserId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Scopes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "toolProviderDisplayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ToolProviderDisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "updatedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vpc", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanActionGatewayConnection.DataDigitaloceanActionGatewayConnectionVpcList\"}")]
        public virtual digitalocean.DataDigitaloceanActionGatewayConnection.DataDigitaloceanActionGatewayConnectionVpcList Vpc
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanActionGatewayConnection.DataDigitaloceanActionGatewayConnectionVpcList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "toolProviderInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ToolProviderInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UserIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "toolProvider", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ToolProvider
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "userId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
