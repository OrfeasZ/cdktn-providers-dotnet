using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlBlueGreenDeployment
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/mysql_blue_green_deployment oci_mysql_blue_green_deployment}.</summary>
    [JsiiClass(nativeType: typeof(oci.MysqlBlueGreenDeployment.MysqlBlueGreenDeployment), fullyQualifiedName: "oci.mysqlBlueGreenDeployment.MysqlBlueGreenDeployment", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.mysqlBlueGreenDeployment.MysqlBlueGreenDeploymentConfig\"}}]")]
    public class MysqlBlueGreenDeployment : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/mysql_blue_green_deployment oci_mysql_blue_green_deployment} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public MysqlBlueGreenDeployment(Constructs.Construct scope, string id, oci.MysqlBlueGreenDeployment.IMysqlBlueGreenDeploymentConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.MysqlBlueGreenDeployment.IMysqlBlueGreenDeploymentConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MysqlBlueGreenDeployment(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MysqlBlueGreenDeployment(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a MysqlBlueGreenDeployment resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the MysqlBlueGreenDeployment to import.</param>
        /// <param name="importFromId">The id of the existing MysqlBlueGreenDeployment that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the MysqlBlueGreenDeployment to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the MysqlBlueGreenDeployment to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/mysql_blue_green_deployment#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing MysqlBlueGreenDeployment that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the MysqlBlueGreenDeployment to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.MysqlBlueGreenDeployment.MysqlBlueGreenDeployment), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putChannelDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.mysqlBlueGreenDeployment.MysqlBlueGreenDeploymentChannelDetails\"}}]")]
        public virtual void PutChannelDetails(oci.MysqlBlueGreenDeployment.IMysqlBlueGreenDeploymentChannelDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.MysqlBlueGreenDeployment.IMysqlBlueGreenDeploymentChannelDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTargetDbSystemDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.mysqlBlueGreenDeployment.MysqlBlueGreenDeploymentTargetDbSystemDetails\"}}]")]
        public virtual void PutTargetDbSystemDetails(oci.MysqlBlueGreenDeployment.IMysqlBlueGreenDeploymentTargetDbSystemDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.MysqlBlueGreenDeployment.IMysqlBlueGreenDeploymentTargetDbSystemDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.mysqlBlueGreenDeployment.MysqlBlueGreenDeploymentTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.MysqlBlueGreenDeployment.IMysqlBlueGreenDeploymentTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.MysqlBlueGreenDeployment.IMysqlBlueGreenDeploymentTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeleteTargetDbSystemOnDelete")]
        public virtual void ResetDeleteTargetDbSystemOnDelete()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFreeformTags")]
        public virtual void ResetFreeformTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSwitchoverTrigger")]
        public virtual void ResetSwitchoverTrigger()
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
        = GetStaticProperty<string>(typeof(oci.MysqlBlueGreenDeployment.MysqlBlueGreenDeployment))!;

        [JsiiProperty(name: "activeDbSystemId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ActiveDbSystemId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "channelDetails", typeJson: "{\"fqn\":\"oci.mysqlBlueGreenDeployment.MysqlBlueGreenDeploymentChannelDetailsOutputReference\"}")]
        public virtual oci.MysqlBlueGreenDeployment.MysqlBlueGreenDeploymentChannelDetailsOutputReference ChannelDetails
        {
            get => GetInstanceProperty<oci.MysqlBlueGreenDeployment.MysqlBlueGreenDeploymentChannelDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "replicationChannelId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReplicationChannelId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sslMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SslMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "switchoverStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SwitchoverStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "targetDbSystemDetails", typeJson: "{\"fqn\":\"oci.mysqlBlueGreenDeployment.MysqlBlueGreenDeploymentTargetDbSystemDetailsOutputReference\"}")]
        public virtual oci.MysqlBlueGreenDeployment.MysqlBlueGreenDeploymentTargetDbSystemDetailsOutputReference TargetDbSystemDetails
        {
            get => GetInstanceProperty<oci.MysqlBlueGreenDeployment.MysqlBlueGreenDeploymentTargetDbSystemDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "targetDbSystemId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetDbSystemId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.mysqlBlueGreenDeployment.MysqlBlueGreenDeploymentTimeoutsOutputReference\"}")]
        public virtual oci.MysqlBlueGreenDeployment.MysqlBlueGreenDeploymentTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.MysqlBlueGreenDeployment.MysqlBlueGreenDeploymentTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "channelDetailsInput", typeJson: "{\"fqn\":\"oci.mysqlBlueGreenDeployment.MysqlBlueGreenDeploymentChannelDetails\"}", isOptional: true)]
        public virtual oci.MysqlBlueGreenDeployment.IMysqlBlueGreenDeploymentChannelDetails? ChannelDetailsInput
        {
            get => GetInstanceProperty<oci.MysqlBlueGreenDeployment.IMysqlBlueGreenDeploymentChannelDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "definedTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? DefinedTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "deleteTargetDbSystemOnDeleteInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DeleteTargetDbSystemOnDeleteInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "freeformTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? FreeformTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceDbSystemIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceDbSystemIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "switchoverTriggerInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SwitchoverTriggerInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetDbSystemDetailsInput", typeJson: "{\"fqn\":\"oci.mysqlBlueGreenDeployment.MysqlBlueGreenDeploymentTargetDbSystemDetails\"}", isOptional: true)]
        public virtual oci.MysqlBlueGreenDeployment.IMysqlBlueGreenDeploymentTargetDbSystemDetails? TargetDbSystemDetailsInput
        {
            get => GetInstanceProperty<oci.MysqlBlueGreenDeployment.IMysqlBlueGreenDeploymentTargetDbSystemDetails?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.MysqlBlueGreenDeployment.IMysqlBlueGreenDeploymentTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.mysqlBlueGreenDeployment.MysqlBlueGreenDeploymentTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> DefinedTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "deleteTargetDbSystemOnDelete", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object DeleteTargetDbSystemOnDelete
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> FreeformTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceDbSystemId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceDbSystemId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "switchoverTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SwitchoverTrigger
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
