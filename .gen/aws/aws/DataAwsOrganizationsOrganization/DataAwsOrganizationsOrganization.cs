using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsOrganizationsOrganization
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/organizations_organization aws_organizations_organization}.</summary>
    [JsiiClass(nativeType: typeof(aws.DataAwsOrganizationsOrganization.DataAwsOrganizationsOrganization), fullyQualifiedName: "aws.dataAwsOrganizationsOrganization.DataAwsOrganizationsOrganization", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.dataAwsOrganizationsOrganization.DataAwsOrganizationsOrganizationConfig\"}}]")]
    public class DataAwsOrganizationsOrganization : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/organizations_organization aws_organizations_organization} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsOrganizationsOrganization(Constructs.Construct scope, string id, aws.DataAwsOrganizationsOrganization.IDataAwsOrganizationsOrganizationConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DataAwsOrganizationsOrganization.IDataAwsOrganizationsOrganizationConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsOrganizationsOrganization(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsOrganizationsOrganization(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataAwsOrganizationsOrganization resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAwsOrganizationsOrganization to import.</param>
        /// <param name="importFromId">The id of the existing DataAwsOrganizationsOrganization that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAwsOrganizationsOrganization to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAwsOrganizationsOrganization to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/organizations_organization#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAwsOrganizationsOrganization that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAwsOrganizationsOrganization to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(aws.DataAwsOrganizationsOrganization.DataAwsOrganizationsOrganization), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReturnOrganizationOnly")]
        public virtual void ResetReturnOrganizationOnly()
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
        = GetStaticProperty<string>(typeof(aws.DataAwsOrganizationsOrganization.DataAwsOrganizationsOrganization))!;

        [JsiiProperty(name: "accounts", typeJson: "{\"fqn\":\"aws.dataAwsOrganizationsOrganization.DataAwsOrganizationsOrganizationAccountsList\"}")]
        public virtual aws.DataAwsOrganizationsOrganization.DataAwsOrganizationsOrganizationAccountsList Accounts
        {
            get => GetInstanceProperty<aws.DataAwsOrganizationsOrganization.DataAwsOrganizationsOrganizationAccountsList>()!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "awsServiceAccessPrincipals", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AwsServiceAccessPrincipals
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "enabledPolicyTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] EnabledPolicyTypes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "featureSet", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FeatureSet
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "masterAccountArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MasterAccountArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "masterAccountEmail", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MasterAccountEmail
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "masterAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MasterAccountId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "masterAccountName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MasterAccountName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nonMasterAccounts", typeJson: "{\"fqn\":\"aws.dataAwsOrganizationsOrganization.DataAwsOrganizationsOrganizationNonMasterAccountsList\"}")]
        public virtual aws.DataAwsOrganizationsOrganization.DataAwsOrganizationsOrganizationNonMasterAccountsList NonMasterAccounts
        {
            get => GetInstanceProperty<aws.DataAwsOrganizationsOrganization.DataAwsOrganizationsOrganizationNonMasterAccountsList>()!;
        }

        [JsiiProperty(name: "roots", typeJson: "{\"fqn\":\"aws.dataAwsOrganizationsOrganization.DataAwsOrganizationsOrganizationRootsList\"}")]
        public virtual aws.DataAwsOrganizationsOrganization.DataAwsOrganizationsOrganizationRootsList Roots
        {
            get => GetInstanceProperty<aws.DataAwsOrganizationsOrganization.DataAwsOrganizationsOrganizationRootsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "returnOrganizationOnlyInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ReturnOrganizationOnlyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "returnOrganizationOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object ReturnOrganizationOnly
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
    }
}
