using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.ActionGatewayConnection
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_connection digitalocean_action_gateway_connection}.</summary>
    [JsiiClass(nativeType: typeof(digitalocean.ActionGatewayConnection.ActionGatewayConnection), fullyQualifiedName: "digitalocean.actionGatewayConnection.ActionGatewayConnection", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"digitalocean.actionGatewayConnection.ActionGatewayConnectionConfig\"}}]")]
    public class ActionGatewayConnection : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_connection digitalocean_action_gateway_connection} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ActionGatewayConnection(Constructs.Construct scope, string id, digitalocean.ActionGatewayConnection.IActionGatewayConnectionConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, digitalocean.ActionGatewayConnection.IActionGatewayConnectionConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ActionGatewayConnection(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ActionGatewayConnection(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a ActionGatewayConnection resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ActionGatewayConnection to import.</param>
        /// <param name="importFromId">The id of the existing ActionGatewayConnection that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ActionGatewayConnection to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ActionGatewayConnection to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_connection#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ActionGatewayConnection that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ActionGatewayConnection to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(digitalocean.ActionGatewayConnection.ActionGatewayConnection), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putVpc", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.actionGatewayConnection.ActionGatewayConnectionVpc\"}}]")]
        public virtual void PutVpc(digitalocean.ActionGatewayConnection.IActionGatewayConnectionVpc @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.ActionGatewayConnection.IActionGatewayConnectionVpc)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetConnectionParameters")]
        public virtual void ResetConnectionParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCredentialId")]
        public virtual void ResetCredentialId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScopes")]
        public virtual void ResetScopes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVpc")]
        public virtual void ResetVpc()
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
        = GetStaticProperty<string>(typeof(digitalocean.ActionGatewayConnection.ActionGatewayConnection))!;

        [JsiiProperty(name: "authorization", typeJson: "{\"fqn\":\"digitalocean.actionGatewayConnection.ActionGatewayConnectionAuthorizationList\"}")]
        public virtual digitalocean.ActionGatewayConnection.ActionGatewayConnectionAuthorizationList Authorization
        {
            get => GetInstanceProperty<digitalocean.ActionGatewayConnection.ActionGatewayConnectionAuthorizationList>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
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

        [JsiiProperty(name: "vpc", typeJson: "{\"fqn\":\"digitalocean.actionGatewayConnection.ActionGatewayConnectionVpcOutputReference\"}")]
        public virtual digitalocean.ActionGatewayConnection.ActionGatewayConnectionVpcOutputReference Vpc
        {
            get => GetInstanceProperty<digitalocean.ActionGatewayConnection.ActionGatewayConnectionVpcOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectionParametersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? ConnectionParametersInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "credentialIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CredentialIdInput
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
        [JsiiProperty(name: "scopesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ScopesInput
        {
            get => GetInstanceProperty<string[]?>();
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

        [JsiiOptional]
        [JsiiProperty(name: "vpcInput", typeJson: "{\"fqn\":\"digitalocean.actionGatewayConnection.ActionGatewayConnectionVpc\"}", isOptional: true)]
        public virtual digitalocean.ActionGatewayConnection.IActionGatewayConnectionVpc? VpcInput
        {
            get => GetInstanceProperty<digitalocean.ActionGatewayConnection.IActionGatewayConnectionVpc?>();
        }

        [JsiiProperty(name: "connectionParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> ConnectionParameters
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "credentialId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CredentialId
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

        [JsiiProperty(name: "scopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Scopes
        {
            get => GetInstanceProperty<string[]>()!;
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
