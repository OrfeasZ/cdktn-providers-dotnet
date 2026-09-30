using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DirectoryservicedataUser
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/6.67.0/docs/resources/directoryservicedata_user aws_directoryservicedata_user}.</summary>
    [JsiiClass(nativeType: typeof(aws.DirectoryservicedataUser.DirectoryservicedataUser), fullyQualifiedName: "aws.directoryservicedataUser.DirectoryservicedataUser", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.directoryservicedataUser.DirectoryservicedataUserConfig\"}}]")]
    public class DirectoryservicedataUser : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/6.67.0/docs/resources/directoryservicedata_user aws_directoryservicedata_user} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DirectoryservicedataUser(Constructs.Construct scope, string id, aws.DirectoryservicedataUser.IDirectoryservicedataUserConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DirectoryservicedataUser.IDirectoryservicedataUserConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DirectoryservicedataUser(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DirectoryservicedataUser(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DirectoryservicedataUser resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DirectoryservicedataUser to import.</param>
        /// <param name="importFromId">The id of the existing DirectoryservicedataUser that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DirectoryservicedataUser to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DirectoryservicedataUser to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/6.67.0/docs/resources/directoryservicedata_user#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DirectoryservicedataUser that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DirectoryservicedataUser to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(aws.DirectoryservicedataUser.DirectoryservicedataUser), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetEmailAddress")]
        public virtual void ResetEmailAddress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGivenName")]
        public virtual void ResetGivenName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSurname")]
        public virtual void ResetSurname()
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
        = GetStaticProperty<string>(typeof(aws.DirectoryservicedataUser.DirectoryservicedataUser))!;

        [JsiiProperty(name: "distinguishedName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DistinguishedName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Enabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "realm", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Realm
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Sid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userPrincipalName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserPrincipalName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "directoryIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DirectoryIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailAddressInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EmailAddressInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "givenNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GivenNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "samAccountNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SamAccountNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "surnameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SurnameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "directoryId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DirectoryId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "emailAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EmailAddress
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "givenName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GivenName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "samAccountName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SamAccountName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "surname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Surname
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
