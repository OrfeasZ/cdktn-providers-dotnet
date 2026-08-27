using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool oci_database_tools_runtime_database_tools_database_api_gateway_config_pool}.</summary>
    [JsiiClass(nativeType: typeof(oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool), fullyQualifiedName: "oci.databaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.databaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolConfig\"}}]")]
    public class DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool oci_database_tools_runtime_database_tools_database_api_gateway_config_pool} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool(Constructs.Construct scope, string id, oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool.IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool.IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool to import.</param>
        /// <param name="importFromId">The id of the existing DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_pool#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool.IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool.IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAdvancedProperties")]
        public virtual void ResetAdvancedProperties()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDatabaseActionsStatus")]
        public virtual void ResetDatabaseActionsStatus()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInitialPoolSize")]
        public virtual void ResetInitialPoolSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJwtProfileAudience")]
        public virtual void ResetJwtProfileAudience()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJwtProfileIssuer")]
        public virtual void ResetJwtProfileIssuer()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJwtProfileJwkUrl")]
        public virtual void ResetJwtProfileJwkUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJwtProfileRoleClaimName")]
        public virtual void ResetJwtProfileRoleClaimName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxPoolSize")]
        public virtual void ResetMaxPoolSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinPoolSize")]
        public virtual void ResetMinPoolSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRestEnabledSqlStatus")]
        public virtual void ResetRestEnabledSqlStatus()
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
        = GetStaticProperty<string>(typeof(oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool))!;

        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Key
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolTimeoutsOutputReference\"}")]
        public virtual oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "advancedPropertiesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? AdvancedPropertiesInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseActionsStatusInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DatabaseActionsStatusInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseToolsConnectionIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DatabaseToolsConnectionIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseToolsDatabaseApiGatewayConfigIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DatabaseToolsDatabaseApiGatewayConfigIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
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
        [JsiiProperty(name: "initialPoolSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? InitialPoolSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jwtProfileAudienceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? JwtProfileAudienceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jwtProfileIssuerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? JwtProfileIssuerInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jwtProfileJwkUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? JwtProfileJwkUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jwtProfileRoleClaimNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? JwtProfileRoleClaimNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxPoolSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxPoolSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minPoolSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinPoolSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "poolRouteValueInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PoolRouteValueInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "restEnabledSqlStatusInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RestEnabledSqlStatusInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool.IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.databaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPool.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "advancedProperties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> AdvancedProperties
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "databaseActionsStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseActionsStatus
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "databaseToolsConnectionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseToolsConnectionId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "databaseToolsDatabaseApiGatewayConfigId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseToolsDatabaseApiGatewayConfigId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
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

        [JsiiProperty(name: "initialPoolSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InitialPoolSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "jwtProfileAudience", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JwtProfileAudience
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "jwtProfileIssuer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JwtProfileIssuer
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "jwtProfileJwkUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JwtProfileJwkUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "jwtProfileRoleClaimName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JwtProfileRoleClaimName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxPoolSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxPoolSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minPoolSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinPoolSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "poolRouteValue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PoolRouteValue
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "restEnabledSqlStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RestEnabledSqlStatus
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
