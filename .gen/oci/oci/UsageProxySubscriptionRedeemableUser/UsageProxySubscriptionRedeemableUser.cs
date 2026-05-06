using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.UsageProxySubscriptionRedeemableUser
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/usage_proxy_subscription_redeemable_user oci_usage_proxy_subscription_redeemable_user}.</summary>
    [JsiiClass(nativeType: typeof(oci.UsageProxySubscriptionRedeemableUser.UsageProxySubscriptionRedeemableUser), fullyQualifiedName: "oci.usageProxySubscriptionRedeemableUser.UsageProxySubscriptionRedeemableUser", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.usageProxySubscriptionRedeemableUser.UsageProxySubscriptionRedeemableUserConfig\"}}]")]
    public class UsageProxySubscriptionRedeemableUser : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/usage_proxy_subscription_redeemable_user oci_usage_proxy_subscription_redeemable_user} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public UsageProxySubscriptionRedeemableUser(Constructs.Construct scope, string id, oci.UsageProxySubscriptionRedeemableUser.IUsageProxySubscriptionRedeemableUserConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.UsageProxySubscriptionRedeemableUser.IUsageProxySubscriptionRedeemableUserConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected UsageProxySubscriptionRedeemableUser(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected UsageProxySubscriptionRedeemableUser(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a UsageProxySubscriptionRedeemableUser resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the UsageProxySubscriptionRedeemableUser to import.</param>
        /// <param name="importFromId">The id of the existing UsageProxySubscriptionRedeemableUser that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the UsageProxySubscriptionRedeemableUser to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the UsageProxySubscriptionRedeemableUser to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/usage_proxy_subscription_redeemable_user#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing UsageProxySubscriptionRedeemableUser that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the UsageProxySubscriptionRedeemableUser to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.UsageProxySubscriptionRedeemableUser.UsageProxySubscriptionRedeemableUser), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putItems", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.usageProxySubscriptionRedeemableUser.UsageProxySubscriptionRedeemableUserItems\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutItems(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.UsageProxySubscriptionRedeemableUser.IUsageProxySubscriptionRedeemableUserItems[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.UsageProxySubscriptionRedeemableUser.IUsageProxySubscriptionRedeemableUserItems).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.UsageProxySubscriptionRedeemableUser.IUsageProxySubscriptionRedeemableUserItems).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.usageProxySubscriptionRedeemableUser.UsageProxySubscriptionRedeemableUserTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.UsageProxySubscriptionRedeemableUser.IUsageProxySubscriptionRedeemableUserTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.UsageProxySubscriptionRedeemableUser.IUsageProxySubscriptionRedeemableUserTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(oci.UsageProxySubscriptionRedeemableUser.UsageProxySubscriptionRedeemableUser))!;

        [JsiiProperty(name: "items", typeJson: "{\"fqn\":\"oci.usageProxySubscriptionRedeemableUser.UsageProxySubscriptionRedeemableUserItemsList\"}")]
        public virtual oci.UsageProxySubscriptionRedeemableUser.UsageProxySubscriptionRedeemableUserItemsList Items
        {
            get => GetInstanceProperty<oci.UsageProxySubscriptionRedeemableUser.UsageProxySubscriptionRedeemableUserItemsList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.usageProxySubscriptionRedeemableUser.UsageProxySubscriptionRedeemableUserTimeoutsOutputReference\"}")]
        public virtual oci.UsageProxySubscriptionRedeemableUser.UsageProxySubscriptionRedeemableUserTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.UsageProxySubscriptionRedeemableUser.UsageProxySubscriptionRedeemableUserTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "itemsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.usageProxySubscriptionRedeemableUser.UsageProxySubscriptionRedeemableUserItems\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ItemsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subscriptionIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubscriptionIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tenancyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TenancyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.usageProxySubscriptionRedeemableUser.UsageProxySubscriptionRedeemableUserTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
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

        [JsiiProperty(name: "subscriptionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubscriptionId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tenancyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenancyId
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
