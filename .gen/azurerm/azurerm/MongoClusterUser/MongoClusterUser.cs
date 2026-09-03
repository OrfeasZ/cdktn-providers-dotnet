using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MongoClusterUser
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/mongo_cluster_user azurerm_mongo_cluster_user}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.MongoClusterUser.MongoClusterUser), fullyQualifiedName: "azurerm.mongoClusterUser.MongoClusterUser", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.mongoClusterUser.MongoClusterUserConfig\"}}]")]
    public class MongoClusterUser : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/mongo_cluster_user azurerm_mongo_cluster_user} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public MongoClusterUser(Constructs.Construct scope, string id, azurerm.MongoClusterUser.IMongoClusterUserConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.MongoClusterUser.IMongoClusterUserConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MongoClusterUser(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MongoClusterUser(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a MongoClusterUser resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the MongoClusterUser to import.</param>
        /// <param name="importFromId">The id of the existing MongoClusterUser that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the MongoClusterUser to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the MongoClusterUser to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/mongo_cluster_user#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing MongoClusterUser that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the MongoClusterUser to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurerm.MongoClusterUser.MongoClusterUser), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.MongoClusterUser.IMongoClusterUserRole" />)[]</param>
        [JsiiMethod(name: "putRole", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.mongoClusterUser.MongoClusterUserRole\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRole(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.MongoClusterUser.IMongoClusterUserRole[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.MongoClusterUser.IMongoClusterUserRole).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.MongoClusterUser.IMongoClusterUserRole).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.mongoClusterUser.MongoClusterUserTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.MongoClusterUser.IMongoClusterUserTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MongoClusterUser.IMongoClusterUserTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(azurerm.MongoClusterUser.MongoClusterUser))!;

        [JsiiProperty(name: "role", typeJson: "{\"fqn\":\"azurerm.mongoClusterUser.MongoClusterUserRoleList\"}")]
        public virtual azurerm.MongoClusterUser.MongoClusterUserRoleList Role
        {
            get => GetInstanceProperty<azurerm.MongoClusterUser.MongoClusterUserRoleList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.mongoClusterUser.MongoClusterUserTimeoutsOutputReference\"}")]
        public virtual azurerm.MongoClusterUser.MongoClusterUserTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.MongoClusterUser.MongoClusterUserTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityProviderTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdentityProviderTypeInput
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
        [JsiiProperty(name: "mongoClusterIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MongoClusterIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "objectIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ObjectIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "principalTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrincipalTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.MongoClusterUser.IMongoClusterUserRole" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "roleInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.mongoClusterUser.MongoClusterUserRole\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RoleInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.MongoClusterUser.IMongoClusterUserTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.mongoClusterUser.MongoClusterUserTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "identityProviderType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdentityProviderType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "mongoClusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MongoClusterId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "objectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ObjectId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "principalType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrincipalType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
