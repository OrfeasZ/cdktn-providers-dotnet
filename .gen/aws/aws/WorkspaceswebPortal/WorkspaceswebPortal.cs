using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WorkspaceswebPortal
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workspacesweb_portal aws_workspacesweb_portal}.</summary>
    [JsiiClass(nativeType: typeof(aws.WorkspaceswebPortal.WorkspaceswebPortal), fullyQualifiedName: "aws.workspaceswebPortal.WorkspaceswebPortal", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.workspaceswebPortal.WorkspaceswebPortalConfig\"}}]")]
    public class WorkspaceswebPortal : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workspacesweb_portal aws_workspacesweb_portal} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public WorkspaceswebPortal(Constructs.Construct scope, string id, aws.WorkspaceswebPortal.IWorkspaceswebPortalConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.WorkspaceswebPortal.IWorkspaceswebPortalConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WorkspaceswebPortal(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WorkspaceswebPortal(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a WorkspaceswebPortal resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the WorkspaceswebPortal to import.</param>
        /// <param name="importFromId">The id of the existing WorkspaceswebPortal that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the WorkspaceswebPortal to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the WorkspaceswebPortal to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workspacesweb_portal#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing WorkspaceswebPortal that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the WorkspaceswebPortal to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(aws.WorkspaceswebPortal.WorkspaceswebPortal), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.workspaceswebPortal.WorkspaceswebPortalTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.WorkspaceswebPortal.IWorkspaceswebPortalTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.WorkspaceswebPortal.IWorkspaceswebPortalTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAdditionalEncryptionContext")]
        public virtual void ResetAdditionalEncryptionContext()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAuthenticationType")]
        public virtual void ResetAuthenticationType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBrowserSettingsArn")]
        public virtual void ResetBrowserSettingsArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomerManagedKey")]
        public virtual void ResetCustomerManagedKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisplayName")]
        public virtual void ResetDisplayName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceType")]
        public virtual void ResetInstanceType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxConcurrentSessions")]
        public virtual void ResetMaxConcurrentSessions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
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
        = GetStaticProperty<string>(typeof(aws.WorkspaceswebPortal.WorkspaceswebPortal))!;

        [JsiiProperty(name: "browserType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BrowserType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "creationDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreationDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dataProtectionSettingsArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataProtectionSettingsArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ipAccessSettingsArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpAccessSettingsArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkSettingsArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkSettingsArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "portalArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PortalArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "portalEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PortalEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "portalStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PortalStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rendererType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RendererType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sessionLoggerArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SessionLoggerArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "statusReason", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StatusReason
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tagsAll", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap TagsAll
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.workspaceswebPortal.WorkspaceswebPortalTimeoutsOutputReference\"}")]
        public virtual aws.WorkspaceswebPortal.WorkspaceswebPortalTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.WorkspaceswebPortal.WorkspaceswebPortalTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "trustStoreArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TrustStoreArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userAccessLoggingSettingsArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserAccessLoggingSettingsArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userSettingsArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserSettingsArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "additionalEncryptionContextInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? AdditionalEncryptionContextInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authenticationTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AuthenticationTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "browserSettingsArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BrowserSettingsArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customerManagedKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CustomerManagedKeyInput
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
        [JsiiProperty(name: "instanceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxConcurrentSessionsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxConcurrentSessionsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.workspaceswebPortal.WorkspaceswebPortalTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "additionalEncryptionContext", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> AdditionalEncryptionContext
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "authenticationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthenticationType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "browserSettingsArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BrowserSettingsArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "customerManagedKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomerManagedKey
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

        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxConcurrentSessions", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxConcurrentSessions
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
